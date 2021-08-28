using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Meucachorro.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Meucachorro.Controllers
{
    public class ServicoController : Controller
    {

       // pegar o endereço do servidor
       private readonly IWebHostEnvironment _appEnvironment;
        public ServicoController(IWebHostEnvironment env)
        {
            _appEnvironment = env;
        }

         public IActionResult ListaServico(){
   
             if(HttpContext.Session.GetInt32("idUsuario") == null){
              //return RedirectToAction("../Home/Index"); 
              return Redirect("/Home/Index");
             }  
            
            // falta colocar filtro o usuario pegar a viagem
            //int iduser = Convert.ToInt32(HttpContext.Session.GetString("UmUS"));
            ServicoBanco nSE = new ServicoBanco();
            List<servico> nListaSE = nSE.Listar(0, "", "", "");
            return View(nListaSE);
      
        }
         
        // Cadastrar o Servico
         public IActionResult CadastroServico(int ID, string pTipo){

            if(HttpContext.Session.GetInt32("idUsuario") == null){
                //return RedirectToAction("../Home/Index"); 
                  return Redirect("/Home/Index");
             }
            // null atribui cadastro 
            
            //ARRAY TIPO DE SERVICO
            string[] pessoa = { "Selecione Tipo Servico", "Banho", "Passeio", "Hotel", "Veterinario"};
            ViewBag.Pessoa = pessoa;
            ViewBag.SelPessoa = "";

          // estados Brasil 
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
                 ServicoBanco ur = new ServicoBanco();
                 servico editServico = ur.BuscarID(ID);
                 
                 ViewBag.SelPessoa  = editServico.tipoServico;
                 ViewBag.SelEstado  = editServico.estadoServico;
                 ViewBag.ImagemFoto = editServico.fotoServico;
                return View( editServico );

            }else{ 
             // Cadastrar
                ViewBag.TituloPrincipal = "Novo Serviço" ;
                ViewBag.AcaoFomulario = "CADASTRADO"; 
                ViewBag.SytleTop = "font-weight: bold; color:white; background-color: rgba(0,0,255,1); border-radius: 0.5em; box-shadow: 0 8px 30px darkgrey; width:98%;";
            return View();
           
            }
            // return View();
         }

        [HttpPost]
        public IActionResult CadastroServico( servico nSER, string BtCadServico, List<IFormFile> selFoto){

            if(HttpContext.Session.GetInt32("idUsuario") == null){
                //return RedirectToAction("../Home/Index"); 
                  return Redirect("/Home/Index");
             }
            // Botao Cancelar em todos as acoe        
            if( BtCadServico == "CANCELAR"){
               return Redirect("/Servico/ListaServico");
            }
            
            // BoTAO
            if( BtCadServico == "SALVARCADASTRO"){ 
                //int iduser = Convert.ToInt32(HttpContext.Session.GetString("UmUS"));
                 string nFotoChave = "SER"+nSER.tipoServico;
                 string caminho_WebRoot = _appEnvironment.WebRootPath;
                 string arquivoGravado = ""; 
                 ServicoBanco ur = new ServicoBanco();
                 
                 // nome da foto baixada para servidor
                 arquivoGravado = ur.GravaFoto( selFoto, caminho_WebRoot, nFotoChave); 
                 nSER.fotoServico = arquivoGravado;
                 // usuario ativo 
                  string user_ativo = HttpContext.Session.GetString("UmUS");
                  nSER.idForServico = Int32.Parse(user_ativo);
                  ur.Insert( nSER );
   
                // return RedirectToAction("EnviarArquivo", "Servico",  new{  ListaArquivos = selFoto } );          
                 //return Redirect("/Servico/ListaServico");
            }
            // ALTERACAO
            if( BtCadServico == "ALTERACAO"){ 
                 string nFotoChave = "SER"+nSER.tipoServico;
                 string caminho_WebRoot = _appEnvironment.WebRootPath;
                 string arquivoGravado = ""; 
                 
                //int iduser = Convert.ToInt32(HttpContext.Session.GetString("UmUS"));
                ServicoBanco ur = new ServicoBanco();
  
                  // nome da foto baixada para servidor
                 arquivoGravado = ur.GravaFoto( selFoto, caminho_WebRoot, nFotoChave); 

                 if( arquivoGravado == "ERRO"){
                     // manten a foto anterior 
                 }else{
                     nSER.fotoServico = arquivoGravado;
                 }
                 ur.Alterar( nSER );
                 return Redirect("/Servico/ListaServico");
            }
 
            // DELETAR
            if( BtCadServico == "DELETAR"){ 
                //int iduser = Convert.ToInt32(HttpContext.Session.GetString("UmUS"));
                 int nSERDeletar = nSER.idServico;
                 ServicoBanco ur = new ServicoBanco();
                 ur.Deletar( nSERDeletar);
                 return Redirect("/Servico/ListaServico");
            }
 
             return Redirect("/Servico/ListaServico");

         }

        public IActionResult EditarServico(int Id){
           string nVar = "EDITAR";
           return RedirectToAction("CadastroServico", "Servico", new{ ID = Id, pTipo = nVar });          
       }


        public IActionResult VerServico(int Id){
           string nVar = "VER";
           return RedirectToAction("CadastroServico", "Servico", new{ ID = Id, pTipo = nVar });          
        }

        public IActionResult DeletarServico(int Id){
           string nVar = "DELETAR";
           return RedirectToAction("CadastroServico", "Servico", new{ ID = Id, pTipo = nVar });          
        }

        public IActionResult VerUsuarioServico(int Id){

             if(HttpContext.Session.GetInt32("idUsuario") == null){
                 ViewBag.Mensagem = "Usuario Logado - Favor Fazer  L O G I N";
                 return Redirect("/Usuario/LoginUser");
             }else{
                return Redirect("/Servico/ListaServico");
             }  

        }

    }
}