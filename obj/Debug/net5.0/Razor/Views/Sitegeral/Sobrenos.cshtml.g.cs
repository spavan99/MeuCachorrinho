#pragma checksum "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Sitegeral\Sobrenos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "583e6f520ea24a45ab57c5928bc0717ed05498a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sitegeral_Sobrenos), @"mvc.1.0.view", @"/Views/Sitegeral/Sobrenos.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\_ViewImports.cshtml"
using Meucachorro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\_ViewImports.cshtml"
using Meucachorro.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Sitegeral\Sobrenos.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"583e6f520ea24a45ab57c5928bc0717ed05498a5", @"/Views/Sitegeral/Sobrenos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c76e4d29f9f713d607d9723e56f8803d89316042", @"/Views/_ViewImports.cshtml")]
    public class Views_Sitegeral_Sobrenos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Sitegeral\Sobrenos.cshtml"
  
    Layout = "_LayoutPagina";
    ViewData["Title"] = "Quem Somos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Sitegeral\Sobrenos.cshtml"
  if(Context.Session.GetInt32("idUsuario") != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div>\r\n");
#nullable restore
#line 10 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Sitegeral\Sobrenos.cshtml"
       
     await Html.RenderPartialAsync("BarraUsuario");
     

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n     </div>\r\n");
#nullable restore
#line 15 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Sitegeral\Sobrenos.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid px-0 mx-0"">

    <div class=""row"">
       <div class=""col-12 pb-2 borda-principal""  style=""background-color: rgba(51,178,255,0.5);"" >
            <br/>               
            <h1 class=""text-center""> QUEM SOMOS</h1>
        </div>    
    </div>

    <div class=""row"">
        <div class=""col-md-12 pb-2 "" >
            <br/>               
            <h3 class=""text-center"" id=""Alinha-Texto""> Uma empresa apaixanada pelo que faz e inclusive com grande amor pelo seu Pet.</h2>
            <hr>
        </div>
    </div>
   
    <div class=""row justify-content-center"">

            <div class=""col-sm-3 my-2 mx-2""  style=""text-align: center"">
                <div class=""btn-group"" >
                    <button type=""button"" class=""btn btn-primary btn-lg"" data-toggle=""modal"" data-target=""#modalMissao""  > Missao</button>
                </div>
            </div>
            <div class=""col-sm-3  my-2 mx-2"" style=""text-align: center"">
                <div clas");
            WriteLiteral(@"s=""btn-group"" >
                    <button type=""button"" class=""btn btn-success btn-lg"" data-toggle=""modal"" data-target=""#modalPrincipios"">Principios</button>
                </div>
            </div>
            <div class=""col-sm-3  my-2 mx-2"" style=""text-align: center"">
                <div class=""btn-group"" >
                    <button type=""button"" class=""btn btn-danger btn-lg"" data-toggle=""modal"" data-target=""#modalPaixao"""">Nossa Paix??o</button>
                </div>
            </div>

      </div>

</div>

<!-- Modal MISSAO-->
<div class=""modal fade"" id=""modalMissao"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Miss??o da Empresa</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
          <span aria-hidden=""true"">&times;</span>
        <");
            WriteLiteral(@"/button>
      </div>
      <div class=""modal-body"">
          <p id=""Alinha-Texto""> Temos  como  miss??o  principal aproximar os 
              clientes apaixoandas por PETS dos forncedores adequados
               e tamb??m apaixonados pelos PETS.
          </p>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Fechar</button>
      </div>
    </div>
  </div>
</div>


<!-- Modal PRINCIPIOS-->
<div class=""modal fade"" id=""modalPrincipios"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Principio da Empresa</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
          <p");
            WriteLiteral(@" id=""Alinha-Texto""> Nosso Principios s??o: a) Amor e Paix??o pelos PETS;
              b) Homestidade; c) Transpar??ncia e) Compromisso</p>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-success"" data-dismiss=""modal"">Fechar</button>
      </div>
    </div>
  </div>
</div>


<!-- Modal  NOSSA PAIXAO-->
<div class=""modal fade"" id=""modalPaixao"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Nossa Paix??o</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
          <p id=""Alinha-Texto""> Como n??s do site temos, um enorme paix??o e 
               amor pelos nossos PETS em conjunto
               e parceri");
            WriteLiteral("a  com  nossos Clientes e \r\n               nossos Fornecedores.</p>\r\n      </div>\r\n      <div class=\"modal-footer\">\r\n        <button type=\"button\" class=\"btn btn-danger\" data-dismiss=\"modal\">Fechar</button>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
