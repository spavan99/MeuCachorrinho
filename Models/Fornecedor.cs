using System;
using Meucachorro.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Meucachorro.Models
{
    public class fornecedor
    {
        
     public int idFornecedor {get; set;}
      public string nomeFornecedor{ get; set;}
      public string enderecoFornecedor{ get; set;}
      public int nrresFornecedor{ get; set;}
      public string bairroFornecedor{ get; set;}
      public string complFornecedor{ get; set;}
      public string cepFornecedor{get; set;}
      public string cidadeFornecedor{get; set;}
      public string estadoFornecedor{get; set;}
      public string tel1Fornecedor{get; set;}
      public string tel2Fornecedor{get; set;}
      public string tel3Fornecedor{get; set;}
      public string pessoaFornecedor{get; set;}
      public string tpindFornecedor{get; set;}
      public string identFornecedor{ get; set;}
      public int idUsuarioFor{ get; set;}
      public DateTime dtcadFornecedor{ get; set;}


    }
}