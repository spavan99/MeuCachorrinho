#pragma checksum "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e0d91fbf1ef876b2dbd7a226e0cc02da35957fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e0d91fbf1ef876b2dbd7a226e0cc02da35957fe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c76e4d29f9f713d607d9723e56f8803d89316042", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "MeuCachorrinho";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"contanir-fluid px-0 mx-0\">\r\n\r\n");
#nullable restore
#line 8 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Home\Index.cshtml"
         
                //await Html.RenderPartialAsync("_TelaMenuInicial");
                await Html.RenderPartialAsync("_MenuInicialSERV");
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""row"">
            <div class=""col-12 text-center py-2""  id=""Cor-Tela-Principal-1"" >
                   </br>
                   <h4 style=""font-weight: bold;""> VEJA COMO É FACIL ACESSAR O SERVIÇO</h4>
            </div>
        </div> 
 
        <div class=""row py-5"" id=""Cor-Tela-Principal-1"">
            
            <div class=""col-sm-3  col-12  my-2"">
                    <div class=""btn-group col justify-content-center"" >
                        <a href=""/Sitegeral/Fazercontas"">
                            <button type=""button"" class=""btn-outline-danger btn-lg"" >Faça Sua Conta</button>
                        </a> 
                    </div>
            </div>
            
            <div class=""col-sm-3 col-12 my-2"">
                    <div class=""btn-group col justify-content-center"" >
                        <a href=""/Sitegeral/Facil"">
                            <button type=""button"" class=""btn btn-outline-dark btn-lg""   > 1) Cadastre Seu Perfil</button>
   ");
            WriteLiteral(@"                     </a>
                    </div>
            </div>
            
            <div class=""col-sm-3   col-12 my-2"">
                    <div class=""btn-group col justify-content-center"" >
                        <a href=""/Sitegeral/Facil"">
                            <button type=""button"" class=""btn btn-outline-dark btn-lg"" >2) Busque o Serviço</button>
                        </a>
                    </div>
            </div>
            
            <div class=""col-sm-3 col-12 my-2"">
                    <div class=""btn-group col justify-content-center"" >
                        <a href=""/Sitegeral/Facil"">
                            <button type=""button"" class=""btn btn-outline-dark btn-lg"" > 3) Contrate o Serviço</button>
                        </a>
                    </div>
            </div>
        
        </div>


</div>

");
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
