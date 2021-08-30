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
    public class FornecedorController : Controller
    {

         public IActionResult ListaFornecedor( string TipoFiltro, string DadosFiltro, string itensPorPagina, int NumDaPagina,  int PaginaAtual){

             if(HttpContext.Session.GetInt32("idUsuario") == null){
              //return RedirectToAction("../Home/Index"); 
                return Redirect("/Home/Index");
             }  
            

            // logica esta travada no 15 informado variavel itensporpagaina vem sempre nula ou branca
                ViewData[ "itensPorPagina"] = ( string.IsNullOrEmpty(itensPorPagina) ? 15 :  Int32.Parse(itensPorPagina));
                ViewData["PaginaAtual"] = ( PaginaAtual != 0 ? PaginaAtual: 1);
                ViewBag.SetPagina = itensPorPagina;
           
            string pSql = "SELECT * FROM fornecedor" ;
            if( DadosFiltro != null){

                    // texto ter uma '  e like e % para contido
                    if( TipoFiltro == "Nome" ){
                       pSql = "SELECT * FROM fornecedor WHERE nomeFornecedor LIKE '%" + DadosFiltro + "%'";
                    };


                    if( TipoFiltro == "Estado" ){
                       pSql = "SELECT * FROM fornecedor WHERE estadoFornecedor LIKE '%" + DadosFiltro + "%'";
                    };

                    if( TipoFiltro == "Cidade" ){
                       pSql = "SELECT * FROM fornecedor WHERE cidadeFornecedor LIKE '%" + DadosFiltro + "%'";
                    };

                    if( TipoFiltro == "Celular" ){
                       pSql = "SELECT * FROM fornecedor WHERE tel1Fornecedor LIKE '%" + DadosFiltro + "%'";
                    };

                    // numerico
                    if( TipoFiltro == "Id" ){
                       pSql = "SELECT * FROM fornecedor WHERE idFornecedor = "+ DadosFiltro +";" ;
                    };

            };
    

            // falta colocar filtro o usuario pegar a viagem
            //int iduser = Convert.ToInt32(HttpContext.Session.GetString("UmUS"));
            FornecedorBanco nCli = new FornecedorBanco();
            List<fornecedor> nLista = nCli.Listar(pSql);
            return View(nLista);
      
        }
         
        // Cadastrar o Cliente
         public IActionResult CadastroFornecedor(int ID, string pTipo){

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
                 ViewBag.TituloPrincipal = "Deletar / Apagar";
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
                 FornecedorBanco ur = new FornecedorBanco();
                 fornecedor edit = ur.BuscarID(ID);
                 
                 ViewBag.SelPessoa  = edit.pessoaFornecedor;
                 ViewBag.SelEstado  = edit.estadoFornecedor;
                 return View( edit );

            }else{ 
             // Cadastrar
                ViewBag.TituloPrincipal = "Novo Fornecedor" ;
                ViewBag.AcaoFomulario = "CADASTRADO"; 
                ViewBag.SytleTop = "font-weight: bold; color:white; background-color: rgba(0,0,255,1); border-radius: 0.5em; box-shadow: 0 8px 30px darkgrey; width:98%;";
                return View();
           
            }
            // return View();
         }

        [HttpPost]
        public IActionResult CadastroFornecedor( fornecedor nFor, string BtCadFornecedor){

            if(HttpContext.Session.GetInt32("idUsuario") == null){
                //return RedirectToAction("../Home/Index"); 
                  return Redirect("/Home/Index");
             }
            // Botao Cancelar em todos as acoe        
            if( BtCadFornecedor == "CANCELAR"){
               return Redirect("/Fornecedor/ListaFornecedor");
            }
            
            // BoTAO
            if( BtCadFornecedor == "SALVARCADASTRO"){ 
                //int iduser = Convert.ToInt32(HttpContext.Session.GetString("UmUS"));
                 FornecedorBanco ur = new FornecedorBanco();
                 ur.Insert( nFor );
                 return Redirect("/Fornecedor/ListaFornecedor");
            }
            // ALTERACAO
            if( BtCadFornecedor == "ALTERACAO"){ 
                //int iduser = Convert.ToInt32(HttpContext.Session.GetString("UmUS"));
                 FornecedorBanco ur = new FornecedorBanco();
                 ur.Alterar( nFor );
                 return Redirect("/Fornecedor/ListaFornecedor");
            }
 
            // DELETAR
            if( BtCadFornecedor == "DELETAR"){ 
                //int iduser = Convert.ToInt32(HttpContext.Session.GetString("UmUS"));
                 int nFornecedor = nFor.idFornecedor;
                 FornecedorBanco ur = new FornecedorBanco();
                 ur.Deletar( nFornecedor);
                 return Redirect("/Fornecedor/ListaFornecedor");
            }
 
             return Redirect("/Fornecedor/ListaFornecedor");

         }

        public IActionResult EditarFornecedor(int Id){
           string nVar = "EDITAR";
           return RedirectToAction("CadastroFornecedor", "Fornecedor", new{ ID = Id, pTipo = nVar });          
       }


        public IActionResult VerFornecedor(int Id){
           string nVar = "VER";
           return RedirectToAction("CadastroFornecedor", "Fornecedor", new{ ID = Id, pTipo = nVar });          
        }

        public IActionResult DeletarFornecedor(int Id){
           string nVar = "DELETAR";
           return RedirectToAction("CadastroFornecedor", "Fornecedor", new{ ID = Id, pTipo = nVar });          
        }

        public IActionResult VerUsuarioFornecedor(int Id){

             if(HttpContext.Session.GetInt32("idUsuario") == null){
                 ViewBag.Mensagem = "Usuario Logado - Favor Fazer  L O G I N";
                 return Redirect("/Usuario/LoginUser");
             }else{
                return Redirect("/Fornecedor/ListaFornecedor");
             }
         }


    }
}