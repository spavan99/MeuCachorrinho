#pragma checksum "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Sitegeral\Desenvolvedor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "824d16b92fe7d81c1a461241617bee8f8fd4f4c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sitegeral_Desenvolvedor), @"mvc.1.0.view", @"/Views/Sitegeral/Desenvolvedor.cshtml")]
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
#line 1 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Sitegeral\Desenvolvedor.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"824d16b92fe7d81c1a461241617bee8f8fd4f4c3", @"/Views/Sitegeral/Desenvolvedor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c76e4d29f9f713d607d9723e56f8803d89316042", @"/Views/_ViewImports.cshtml")]
    public class Views_Sitegeral_Desenvolvedor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Sitegeral\Desenvolvedor.cshtml"
  
    Layout = "_LayoutPagina";
    ViewData["Title"] = "Desenvolver";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Sitegeral\Desenvolvedor.cshtml"
  if(Context.Session.GetInt32("idUsuario") != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div>\r\n");
#nullable restore
#line 9 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Sitegeral\Desenvolvedor.cshtml"
       
     await Html.RenderPartialAsync("BarraUsuario");
     

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n     </div>\r\n");
#nullable restore
#line 14 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Sitegeral\Desenvolvedor.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""container-fluid px-0 mx-0"">

    <div class=""row"">
       <div class=""col-12 pb-2 borda-principal""  style=""background-color: rgba(51,178,255,0.5);"" >
            <br/>               
            <h1 class=""text-center""> SISTEMA:  MEU CACHORRINHO - Versão 1.0</h1>
        </div>    
    </div>

    <div class=""row"">
        <div class=""col-6 pb-2 pt-4 "">
            <img src=""/imagens/logodesen.png"" width=100% height=200px alt=""Imagem Logo Desenvolvedor"" >
        </div>
        <div class=""col-6 pb-2 "" >
            </br>
            <P id=""Alinha-Texto""> Desenvolvido por:  Silvio Ap. M. Pavan</P>
            </br>
            <p id=""Alinha-Texto""> Empresa: Pavan Sistemas - spavan@terra.com.br</p>
            </br>
            <p id=""Alinha-Texto""> Copyrite Proibido conforme Leis de Proteçao</p>
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
