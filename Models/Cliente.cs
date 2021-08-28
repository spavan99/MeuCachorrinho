using System;
using Meucachorro.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Meucachorro.Models
{
    public class cliente
    {
      public int idCliente {get; set;}
      public string nomeCliente{ get; set;}
      public string enderecoCliente{ get; set;}
      public int nrresCliente{ get; set;}
      public string bairroCliente{ get; set;}
      public string complCliente{ get; set;}
      public string cepCliente{get; set;}
      public string cidadeCliente{get; set;}
      public string estadoCliente{get; set;}
      public string tel1Cliente{get; set;}
      public string tel2Cliente{get; set;}
      public string tel3Cliente{get; set;}
      public string pessoaCliente{get; set;}
      public string tpindCliente{get; set;}
      public string identCliente{ get; set;}
      public int idUsuarioCli{ get; set;}
      public DateTime dtcadCliente{ get; set;}

    }
}