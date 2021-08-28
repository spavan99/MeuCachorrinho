using System;
using Meucachorro.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Meucachorro.Models

{
    public class servico
    {
        
       public int idServico{ get; set;}
       public string nomeServico{ get; set;}
       public string detalheServico{ get; set;}
       public double valorServico{ get; set;}
       public string fotoServico{ get; set; }
       public string tipoServico{ get; set;}
       public string cidadeServico{get; set;}
       public string estadoServico{get; set;}
       public int idForServico{ get; set;}

    }
}