#pragma checksum "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Shared\BannerPrincipal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaf7c6c95e29d3ea2b332cb565b34bb49bd7672c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BannerPrincipal), @"mvc.1.0.view", @"/Views/Shared/BannerPrincipal.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
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
#line 1 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Shared\BannerPrincipal.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Shared\BannerPrincipal.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaf7c6c95e29d3ea2b332cb565b34bb49bd7672c", @"/Views/Shared/BannerPrincipal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c76e4d29f9f713d607d9723e56f8803d89316042", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BannerPrincipal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!-- Banner Carrosuel rotativo paginas de cadastro -->\r\n");
#nullable restore
#line 5 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Shared\BannerPrincipal.cshtml"
     
      string nstilus = "Banner-Inicial";
       

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Shared\BannerPrincipal.cshtml"
        if(Context.Session.GetInt32("idUsuario") != null){
          nstilus = "Banner-Inicial-logado";
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- baner pagina pricipal -->\r\n<!-- carrossel pagina principal -->\r\n<div id=\"carouselExampleFade\" class=\"carousel slide carousel-fade\" data-ride=\"carousel\" data-interval=\"1500\"");
            BeginWriteAttribute("id", " id=\"", 478, "\"", 491, 1);
#nullable restore
#line 14 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Shared\BannerPrincipal.cshtml"
WriteAttributeValue("", 483, nstilus, 483, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n    <div class=\"carousel-inner\">\r\n        <div class=\"carousel-item active\"");
            BeginWriteAttribute("id", " id=\"", 571, "\"", 584, 1);
#nullable restore
#line 16 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Shared\BannerPrincipal.cshtml"
WriteAttributeValue("", 576, nstilus, 576, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> \r\n            <img class=\"d-block w-100\" src=\"/imagens/imageminicial2.png\"  style=\"height: 100%; width:100%\" alt=\"Primeiro Slide\" >\r\n        </div>\r\n        <div class=\"carousel-item\"");
            BeginWriteAttribute("id", " id=\"", 770, "\"", 783, 1);
#nullable restore
#line 19 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Shared\BannerPrincipal.cshtml"
WriteAttributeValue("", 775, nstilus, 775, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img class=\"d-block w-100\" src=\"/imagens/imagem01.jpg\"  style=\"height: 100%; width:100%\" alt=\"Segundo Slide\">\r\n        </div>\r\n        <div class=\"carousel-item\"");
            BeginWriteAttribute("id", " id=\"", 960, "\"", 973, 1);
#nullable restore
#line 22 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Shared\BannerPrincipal.cshtml"
WriteAttributeValue("", 965, nstilus, 965, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <img class=""d-block w-100"" src=""/imagens/imagem2.jpg"" style=""height: 100%; width:100%"" alt=""Terceiro Slide"">
        </div>
    </div>
    <a class=""carousel-control-prev"" href=""#carouselExampleFade"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"" >Anterior</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleFade"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Próximo</span>
    </a>
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