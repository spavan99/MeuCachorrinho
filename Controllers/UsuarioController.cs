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
    public class UsuarioController : Controller
    {

        public IActionResult  LoginUser(){

            ViewBag.TituloPrincipal = "Faça Seu L O G I N";
            ViewBag.SytleTop = "font-weight: bold; color:white; background-color: rgba(51,178,255,0.6); border-radius: 0.5em; box-shadow: 0 8px 30px darkgrey; width:98%;";
            ViewBag.SytleLogin = "background-color: rgba(51,178,255,0.1); border-radius: 0.5em";

            return View();
        
        }

        [HttpPost]
        public IActionResult LoginUser(usuario u){
           
            UsuarioBanco ur = new UsuarioBanco();
            usuario usuario = ur.LoginUsuarioBD(u, "LOGIN");

            if(usuario != null)
            {
                HttpContext.Session.SetInt32("idUsuario", usuario.idUsuario);
                HttpContext.Session.SetString("UmUS", Convert.ToString(usuario.idUsuario));
                HttpContext.Session.SetString("loginUsuario", usuario.loginUsuario);

            }
            else
            {
                ViewBag.Mensagem = "Falha no Login - Ususario e/ou Senhas Invalidos ou NÂO Cadastrado";
                ViewBag.NovoLogin="SIM";
                //return View();

            }
            return Redirect("/Home/Index");

        }

        public IActionResult LogoutUser()
        {
            HttpContext.Session.Clear();//limpa toda a sessão
            return Redirect("/Home/Index");
        }


        public IActionResult CadUserNaoLogado(){

            string NewUSer = "NovoUsuarioSemLogin";
            return RedirectToAction("CadastroUsuario", "Usuario", new{ pNew = NewUSer }); 

        } 
  
 
         public IActionResult ListaUsuario( string TipoFiltro, string DadosFiltro, string itensPorPagina, int NumDaPagina,  int PaginaAtual)
         {
   
             if(HttpContext.Session.GetInt32("idUsuario") == null){
              //return RedirectToAction("../Home/Index"); 
                return Redirect("/Home/Index");
            }  
                // logica esta travada no 15 informado variavel itensporpagaina vem sempre nula ou branca
                ViewData[ "itensPorPagina"] = ( string.IsNullOrEmpty(itensPorPagina) ? 15 :  Int32.Parse(itensPorPagina));
                ViewData["PaginaAtual"] = ( PaginaAtual != 0 ? PaginaAtual: 1);
                ViewBag.SetPagina = itensPorPagina;
   
            
            string pSql = "SELECT * FROM usuario" ;
            if( DadosFiltro != null){

                    // texto ter uma '  e like e % para contido
                    if( TipoFiltro == "Login" ){
                       pSql = "SELECT * FROM usuario WHERE loginUsuario LIKE '%" + DadosFiltro + "%'";
                    };


                    if( TipoFiltro == "Email" ){
                       pSql = "SELECT * FROM usuario WHERE emailUsuario LIKE '%" + DadosFiltro + "%'";
                    };

                    // numerico
                    if( TipoFiltro == "Id" ){
                       pSql = "SELECT * FROM usuario WHERE idUsuario = "+ DadosFiltro +";" ;
                    };

            };


            // falta colocar filtro o usuario pegar a viagem
            //int iduser = Convert.ToInt32(HttpContext.Session.GetString("UmUS"));
            UsuarioBanco nUr = new UsuarioBanco();
            List<usuario> nLista = nUr.Listar(pSql);
            return View(nLista);
      
        }
         
        // Cadastrar o Usuario
         public IActionResult CadastroUsuario(int ID, string pTipo, string pNew){

            if( pNew == null ){
             //   if( pNew != "NovoUsuarioSemLogin"){
                    pNew = "OLDUsuario";
             //   }
            }

            if( pNew ==  "OLDUsuario"){
               
               //Console.WriteLine( "Checar usuaio cadastrado");
                if(HttpContext.Session.GetInt32("idUsuario") == null){
                    //return RedirectToAction("../Home/Index"); 
                      return Redirect("/Home/Index");
                }
                // null atribui cadastro 
            }

            ViewBag.SelUsuario = "";       
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
                 ViewBag.TituloPrincipal = "Consulta" ;
                 ViewBag.AcaoFomulario = "VER"; 
                 ViewBag.SytleTop = "font-weight: bold; color:white; background-color: rgba(51,204,51,0.9); border-radius: 0.5em; box-shadow: 0 8px 30px darkgrey; width:98%;";
             }
             // acoes para os metodos
            if( pTipo == "EDITAR" || pTipo == "DELETAR" || pTipo == "VER"){
                 UsuarioBanco ur = new UsuarioBanco();
                 usuario editUser = ur.BuscarID(ID);
                 ViewBag.SelUsuario = editUser.tipoUsuario;       
                 return View( editUser );

            }else{ 
             // Cadastrar
                ViewBag.TituloPrincipal = "Novo Usuario" ;
                ViewBag.AcaoFomulario = "CADASTRADO"; 
                ViewBag.SytleTop = "font-weight: bold; color:white; background-color: rgba(0,0,255,1); border-radius: 0.5em; box-shadow: 0 8px 30px darkgrey; width:98%;";
                 return View();
           
            }
            // return View();
         }

        [HttpPost]
        public IActionResult CadastroUsuario(usuario nPar, string BtCadastro){

            if( BtCadastro == "CANCELAR"){
                 // Console.WriteLine( " odl *************");
                 if(HttpContext.Session.GetInt32("idUsuario") == null){
                 //return RedirectToAction("../Home/Index"); 
                     return Redirect("/Home/Index");
                 }  
            }

           // Botao Cancelar em todos as acoe        
            if( BtCadastro == "CANCELAR2"){
                // return Redirect("/Home/Index");
                      return Redirect("/Usuario/ListaUsuario");
            }
            
 
            // Botao Cancelar em todos as acoe        
            if( BtCadastro == "CANCELAR"){
                    return Redirect("/Usuario/ListaUsuario");
            }
            
            // BoTAO
            if( BtCadastro == "SALVARCADASTRO"){ 
                //int iduser = Convert.ToInt32(HttpContext.Session.GetString("UmUS"));
                 UsuarioBanco ur = new UsuarioBanco();
 
                // ANTES DE INSERIRI VERICA LOGIN JA TEM CADASTRO
                 
                 usuario TemUser = ur.LoginUsuarioBD( nPar, "USER");
                
                 if( TemUser != null){
                     // encontrou logim
                     ViewBag.Mensagem = "Login de Usuario ja cadastrado :  " + nPar.loginUsuario + "  -> ESPECIFIQUE OUTRO LOGIN PARA PODER CADASTRADAR";
                     return View();
                 }else{
                     // nao encontro faz a insecaço
                     ur.Insert( nPar );
                        if(HttpContext.Session.GetInt32("idUsuario") != null){
                            return Redirect("/Usuario/ListaUsuario");
                        }else{
                            return Redirect("/Home/Index");                     
                        }
                 }
                 
//                 if(HttpContext.Session.GetInt32("idUsuario") != null){
 //                     return Redirect("/Usuario/ListaUsuario");
 //                }else{
//                    return Redirect("/Home/Index");                     
//                 }
            }
            // ALTERACAO
            if( BtCadastro == "ALTERACAO"){ 
                //int iduser = Convert.ToInt32(HttpContext.Session.GetString("UmUS"));
                 UsuarioBanco ur = new UsuarioBanco();
                 ur.Alterar( nPar );
                 return Redirect("/Usuario/ListaUsuario");
            }
 
            // DELETAR
            if( BtCadastro == "DELETAR"){ 
                //int iduser = Convert.ToInt32(HttpContext.Session.GetString("UmUS"));
                 int nDeletar = nPar.idUsuario;
                 UsuarioBanco ur = new UsuarioBanco();
                 ur.Deletar( nDeletar);
                 return Redirect("/Usuario/ListaUsuario");
            }
 
             return Redirect("/Usuario/ListaUsuario");

         }

        public IActionResult EditarUsuario(int Id){
           string nVar = "EDITAR";
           return RedirectToAction("CadastroUsuario", "Usuario", new{ ID = Id, pTipo = nVar });          
       }


        public IActionResult VerUsuario(int Id){
           string nVar = "VER";
           return RedirectToAction("CadastroUsuario", "Usuario", new{ ID = Id, pTipo = nVar });          
        }

        public IActionResult DeletarUsuario(int Id){
           string nVar = "DELETAR";
           return RedirectToAction("CadastroUsuario", "Usuario", new{ ID = Id, pTipo = nVar });          
        }


    }
}