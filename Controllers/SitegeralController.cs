using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Meucachorro.Models;
using System.ComponentModel.DataAnnotations;
using MySqlConnector;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Meucachorrinho.Controllers
{

    public class SitegeralController : Controller
    {


        public IActionResult Sobrenos()
        {
            
            return View();
        }

        public IActionResult Politica()
        {
            
            return View();
        }

        public IActionResult Servico()
        {
            
            return View();
        }
 
        public IActionResult Fazercontas()
        {
            
            return View();
        }

        public IActionResult Desenvolvedor()
        {
            
            return View();
        }

        public IActionResult Facil()
        {
            
            return View();
        }


        public IActionResult PesquisaServico(string nTipoServico, string nEstado, string nCidade)
        {
            
         // estados Brasil 
            string[] vetorEstadoBrasil = { "Selecione Estado",  "AC - Acre",  "AL - Alagoas",  "AP - Amapá", "AM - Amazonas", 
                    "BA - Bahia",  "CE - Ceará",  "ES - Espírito Santo",  "GO - Goiás", "MA - Maranhão", 
                    "MT - Mato Grosso",  "MS - Mato Grosso do Sul",  "MG - Minas Gerais",  "PA - Pará",
                    "PB - Paraíba",  "PR - Paraná",  "PE - Pernambuco",   "PI - Piauí",  "RJ - Rio de Janeiro", 
                    "RN - Rio Grande do Norte",  "RS - Rio Grande do Sul", "RO - Rondônia",  "RR - Roraima",
                    "SC - Santa Catarina",  "SP - São Paulo",  "SE - Sergipe", "TO - Tocantins", 
                    "DF - Distrito Federal" }; 
            ViewBag.EstadoBrasil = vetorEstadoBrasil;
            
            ViewData["nTituloServico"] = nTipoServico;
            ServicoBanco nCon = new ServicoBanco(); 
            List<servico> nLista = nCon.Listar( null, nTipoServico, nEstado, nCidade);
            ViewBag.TIPOserv = nTipoServico;
            return View(nLista);
            //return View();

        }

        public IActionResult Banho()
        {
            return RedirectToAction("PesquisaServico", "Sitegeral", new{ nTipoServico = "Banho" }); 
           
        }

        public IActionResult Passear()
        {
        
            return RedirectToAction("PesquisaServico", "Sitegeral", new{ nTipoServico = "Passeio" }); 
        }

        public IActionResult Hotel()
        {
   
           return RedirectToAction("PesquisaServico", "Sitegeral", new{ nTipoServico = "Hotel" }); 
        }

        public IActionResult Veterinario()
        {
   
           return RedirectToAction("PesquisaServico", "Sitegeral", new{ nTipoServico = "Veterinario" }); 
        }


        public IActionResult Menu()
        {
            
            return View();
        }


        public IActionResult PoliticaTeste()
        {
            // testar como chamar duas paginas uma apos a outra
           //   await Task.Run(() => BaseDados.Incluir(modelo));
            //Task.Run(() => Banner);
            return RedirectToAction("banner");
            //return View();
        }

        [HttpPost]
        public IActionResult ProcuraPetServico(string tipoConsulta, string pesqEstado, string pesqCidade){
    
            return RedirectToAction("PesquisaServico", "Sitegeral", new{ nTipoServico = tipoConsulta,  nEstado = pesqEstado, nCidade = pesqCidade }); 
        // return View("/Home/Index");

        }


    }
}