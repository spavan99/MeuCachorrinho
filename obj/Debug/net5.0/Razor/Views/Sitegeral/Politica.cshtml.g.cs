#pragma checksum "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Sitegeral\Politica.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d0214cdcde557ed61f604a40ba98ca53a5a8ecd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sitegeral_Politica), @"mvc.1.0.view", @"/Views/Sitegeral/Politica.cshtml")]
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
#line 1 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Sitegeral\Politica.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d0214cdcde557ed61f604a40ba98ca53a5a8ecd", @"/Views/Sitegeral/Politica.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c76e4d29f9f713d607d9723e56f8803d89316042", @"/Views/_ViewImports.cshtml")]
    public class Views_Sitegeral_Politica : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Sitegeral\Politica.cshtml"
  
    Layout = "_LayoutPagina";
    ViewData["Title"] = "Politica da Empresa";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Sitegeral\Politica.cshtml"
 if(Context.Session.GetInt32("idUsuario") != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div>\r\n");
#nullable restore
#line 11 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Sitegeral\Politica.cshtml"
       
     await Html.RenderPartialAsync("BarraUsuario");
     

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n     </div>\r\n");
#nullable restore
#line 16 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Sitegeral\Politica.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""container-fluid px-0 mx-0"">

<!--
<div class=""container-fluid hoverable-topic"">
olds entete -->

    <div class=""row"">
       <div class=""col-12 pb-2 borda-principal""  style=""background-color: rgba(51,178,255,0.5);"" >
            <br/>               
            <h1 class=""text-center""> POLITICA DA EMPRESA</h1>
        </div>    
    </div>

   <div class=""row"">
        <div class=""col-md-12 pb-2  borda-principal "" >

               <br/>               

               <p class=""text-justify"" id=""Alinha-Texto""> 
               Cliente ->> Atender os desejos dos nossos clientes, com produtos de alta qualidade, garantindo a melhor serviço com qualidade, amor e tranparencia.
               </p>

               <p class=""text-justify"" id=""Alinha-Texto"">
               Fornecedor ->> Prestar o melhor serviço aos nosso clientes, sempre com muito amor e qualidade 
               <p>

               <p class=""text-justify"" id=""Alinha-Texto"">
               Servicos  ->> Es");
            WriteLiteral(@"tabelecer processos seguros e estáveis, buscando a melhoria contínua e redução de custos de produção. Ser simples e eficaz.
               <p>
               
               <p class=""text-justify"" id=""Alinha-Texto"">
                Sociedade: Contribuir para o desenvolvimento econômico da região dando ênfase aos cuidados com o Meio Ambiente.
               </p>
             
               <p class=""text-justify"" id=""Alinha-Texto"">
               Colaboradores --> Estimular e motivar os colaboradores para o desenvolvimento pessoal e profissional, promovendo ambiente de trabalho seguro e harmonioso em nossa empresa.
              </p>           
           
               </br>
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