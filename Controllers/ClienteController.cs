using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Meucachorro.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;


namespace Meucachorro.Controllers
{
    public class ClienteController : Controller
    {


         public IActionResult ListaCliente( string TipoFiltro, string DadosFiltro, string itensPorPagina, int NumDaPagina,  int PaginaAtual){
   
             if(HttpContext.Session.GetInt32("idUsuario") == null){
              //return RedirectToAction("../Home/Index"); 
              return Redirect("/Home/Index");
             }  

               // logica esta travada no 15 informado variavel itensporpagaina vem sempre nula ou branca
                ViewData[ "itensPorPagina"] = ( string.IsNullOrEmpty(itensPorPagina) ? 15 :  Int32.Parse(itensPorPagina));
                ViewData["PaginaAtual"] = ( PaginaAtual != 0 ? PaginaAtual: 1);
                ViewBag.SetPagina = itensPorPagina;
   
            
            string pSql = "SELECT * FROM cliente" ;
            if( DadosFiltro != null){

                    // texto ter uma '  e like e % para contido
                    if( TipoFiltro == "Nome" ){
                       pSql = "SELECT * FROM cliente WHERE nomeCliente LIKE '%" + DadosFiltro + "%'";
                    };


                    if( TipoFiltro == "Estado" ){
                       pSql = "SELECT * FROM cliente WHERE estadoCliente LIKE '%" + DadosFiltro + "%'";
                    };

                    if( TipoFiltro == "Cidade" ){
                       pSql = "SELECT * FROM cliente WHERE cidadeCliente LIKE '%" + DadosFiltro + "%'";
                    };

                    if( TipoFiltro == "Celular" ){
                       pSql = "SELECT * FROM cliente WHERE tel1Cliente LIKE '%" + DadosFiltro + "%'";
                    };

                    // numerico
                    if( TipoFiltro == "Id" ){
                       pSql = "SELECT * FROM cliente WHERE idCliente = "+ DadosFiltro +";" ;
                    };

            };
           
            ClientesBanco nCli = new ClientesBanco();
            List<cliente> nListaCli = nCli.Listar(pSql);
            return View(nListaCli);
      
        }
         
        // Cadastrar o Cliente
         public IActionResult CadastroCliente(int ID, string pTipo){

            if(HttpContext.Session.GetInt32("idUsuario") == null){
                //return RedirectToAction("../Home/Index"); 
                  return Redirect("/Home/Index");
             }
            // null atribui cadastro 
            
            //ARRAY TIPO DE PESSOA JURIDICA OU FISICA
            string[] pessoa = { "Selecione PJ ou PF", "1 - Pessoa Fisica", "2 - Pessoa Juridica"};
            ViewBag.Pessoa = pessoa;
            ViewBag.SelPessoa = "";

            // eatados Brasil 
            string[] vetorEstadoBrasil = { "Selecione Estado",  "AC - Acre",  "AL - Alagoas",  "AP - Amapá", "AM - Amazonas", 
                    "BA - Bahia",  "CE - Ceará",  "ES - Espírito Santo",  "GO - Goiás", "MA - Maranhão", 
                    "MT - Mato Grosso",  "MS - Mato Grosso do Sul",  "MG - Minas Gerais",  "PA - Pará",
                    "PB - Paraíba",  "PR - Paraná",  "PE - Pernambuco",   "PI - Piauí",  "RJ - Rio de Janeiro", 
                    "RN - Rio Grande do Norte",  "RS - Rio Grande do Sul", "RO - Rondônia",  "RR - Roraima",
                    "SC - Santa Catarina",  "SP - São Paulo",  "SE - Sergipe", "TO - Tocantins", 
                    "DF - Distrito Federal" }; 
            ViewBag.EstadoBrasil = vetorEstadoBrasil;
            ViewBag.SelEstado = "";
        
            if( pTipo == null){
                pTipo = "CADASTRAR";
            }         

             //Titulo para Cabecalho  // Cadastrar  // Editar/Alterar  // Consultar  // Deletar
            // Editar    
            if( pTipo == "EDITAR"){
                 ViewBag.TituloPrincipal = "Alterar" ;
                 ViewBag.AcaoFomulario = "EDITAR"; 
                 ViewBag.SytleTop = "font-weight: bold; color:white; background-color: rgba(51,178,255,0.6); border-radius: 0.5em; box-shadow: 0 8px 30px darkgrey; width:98%;";
             }
            // Deletar
            if( pTipo == "DELETAR"){
                 ViewBag.TituloPrincipal = "Deletar / Apagar" ;
                 ViewBag.AcaoFomulario = "DELETAR"; 
                 ViewBag.SytleTop = "font-weight: bold; color:white; background-color: rgba(255,51,0,0.9); border-radius: 0.5em; box-shadow: 0 8px 30px darkgrey; width:98%;";
             }
            // Deletar
            if( pTipo == "VER"){
                 ViewBag.TituloPrincipal = "Consultar" ;
                 ViewBag.AcaoFomulario = "VER"; 
                 ViewBag.SytleTop = "font-weight: bold; color:white; background-color: rgba(51,204,51,0.9); border-radius: 0.5em; box-shadow: 0 8px 30px darkgrey; width:98%;";
             }
             // acoes para os metodos
            if( pTipo == "EDITAR" || pTipo == "DELETAR" || pTipo == "VER"){
                 ClientesBanco ur = new ClientesBanco();
                 cliente editCliente = ur.BuscarID(ID);
                 
                 ViewBag.SelPessoa  = editCliente.pessoaCliente;
                 ViewBag.SelEstado  = editCliente.estadoCliente;
                 return View( editCliente );

            }else{ 
             // Cadastrar
                ViewBag.TituloPrincipal = "Novo Cliente" ;
                ViewBag.AcaoFomulario = "CADASTRADO"; 
                ViewBag.SytleTop = "font-weight: bold; color:white; background-color: rgba(0,0,255,1); border-radius: 0.5em; box-shadow: 0 8px 30px darkgrey; width:98%;";
            return View();
           
            }
            // return View();
         }

        [HttpPost]
        public IActionResult CadastroCliente( cliente nCli, string BtCadCliente){

            if(HttpContext.Session.GetInt32("idUsuario") == null){
                //return RedirectToAction("../Home/Index"); 
                  return Redirect("/Home/Index");
             }
            // Botao Cancelar em todos as acoe        
            if( BtCadCliente == "CANCELAR"){
               return Redirect("/Cliente/ListaCliente");
            }
            
            // BoTAO
            if( BtCadCliente == "SALVARCADASTRO"){ 
                //int iduser = Convert.ToInt32(HttpContext.Session.GetString("UmUS"));
                 ClientesBanco ur = new ClientesBanco();
                 ur.Insert( nCli );
                 return Redirect("/Cliente/ListaCliente");
            }
            // ALTERACAO
            if( BtCadCliente == "ALTERACAO"){ 
                //int iduser = Convert.ToInt32(HttpContext.Session.GetString("UmUS"));
                 ClientesBanco ur = new ClientesBanco();
                 ur.Alterar( nCli );
                 return Redirect("/Cliente/ListaCliente");
            }
 
            // DELETAR
            if( BtCadCliente == "DELETAR"){ 
                //int iduser = Convert.ToInt32(HttpContext.Session.GetString("UmUS"));
                 int nCliDeletar = nCli.idCliente;
                 ClientesBanco ur = new ClientesBanco();
                 ur.Deletar( nCliDeletar);
                 return Redirect("/Cliente/ListaCliente");
            }
 
             return Redirect("/Cliente/ListaCliente");

         }

        public IActionResult EditarCliente(int Id){
           string nVar = "EDITAR";
           return RedirectToAction("CadastroCliente", "Cliente", new{ ID = Id, pTipo = nVar });          
       }


        public IActionResult VerCliente(int Id){
           string nVar = "VER";
           return RedirectToAction("CadastroCliente", "Cliente", new{ ID = Id, pTipo = nVar });          
        }

        public IActionResult DeletarCliente(int Id){
           string nVar = "DELETAR";
           return RedirectToAction("CadastroCliente", "Cliente", new{ ID = Id, pTipo = nVar });          
        }

        public IActionResult VerUsuarioCliente(int Id){

             if(HttpContext.Session.GetInt32("idUsuario") == null){
                 ViewBag.Mensagem = "Usuario Logado - Favor Fazer  L O G I N";
                 return Redirect("/Usuario/LoginUser");
             }else{
                return Redirect("/Cliente/ListaCliente");
             }  


        }


    }
}