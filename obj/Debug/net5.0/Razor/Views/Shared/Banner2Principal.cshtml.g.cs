#pragma checksum "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Shared\Banner2Principal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaf92ed0f7ddb1f1d1bb6afc08b4c7ba688705a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Banner2Principal), @"mvc.1.0.view", @"/Views/Shared/Banner2Principal.cshtml")]
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
#line 2 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Shared\Banner2Principal.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Shared\Banner2Principal.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf92ed0f7ddb1f1d1bb6afc08b4c7ba688705a1", @"/Views/Shared/Banner2Principal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c76e4d29f9f713d607d9723e56f8803d89316042", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Banner2Principal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- nao utilizao -->\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Shared\Banner2Principal.cshtml"
     
      string nstilus = "Banner-Inicial";
       

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Shared\Banner2Principal.cshtml"
        if(Context.Session.GetInt32("idUsuario") != null){
          nstilus = "Banner-Inicial-logado";
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!--\r\n<div class=\"wrapper\" style=\"height: 300px;\">\r\n-->\r\n<div class=\"wrapper\"");
            BeginWriteAttribute("id", " id=\"", 349, "\"", 362, 1);
#nullable restore
#line 17 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Shared\Banner2Principal.cshtml"
WriteAttributeValue("", 354, nstilus, 354, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

			<div class=""slideshows"">

			  <div class=""slideshow slideshow--hero"">
				<div class=""slides"">
				  <div class=""slide slide1""></div>
				  <div class=""slide slide2""></div>
				  <div class=""slide slide3""></div>
				</div>
			  </div>

			  <div class=""slideshow slideshow--contrast slideshow--contrast--before"">
				<div class=""slides"">
				  <div class=""slide slide1""></div>
				  <div class=""slide slide2""></div>
				  <div class=""slide slide3""></div>
				</div>
			  </div>

			   <div class=""slideshow slideshow--contrast slideshow--contrast--after"">
				<div class=""slides"">
				  <div class=""slide slide1""></div>
				  <div class=""slide slide2""></div>
				  <div class=""slide slide3""></div>
				</div>
			   </div>

			</div>

</div>

 <style>

.wrapper {
  position: relative;
  
  width: 100vw;
  overflow: hidden;
  background-color: red; }


.slideshow {
  position: absolute;
  top: 0;
  left: 50%;
  width: 100%;
  height: 100%;
  transform: translateX(-50");
            WriteLiteral(@"%); }

 .slideshow--hero {
    z-index: 3;
    left: 0;
    top: 50%;
    height: 85%;
    transform: translateY(-50%) skewY(-10deg);
    transform-origin: center;
    overflow: hidden;
    box-shadow: 0 0 1rem rgba(0, 0, 0, 0.25); }

 .slideshow--hero .slides {
      position: absolute;
      left: 0;
      top: -10%;
      width: 100vw;
      height: 100vh;
      animation: 11s slideshow-hero-mobile -3s infinite; }

 .slideshow--hero .slide1 {
      background-image: url(""/imagens/imageminicial2.png"");
      background-size: 100% 100%; 
      animation: 20s slides-set-1 -0.1s infinite; }

 .slideshow--hero .slide2 {
      background-image: url(""/imagens/imgbanho.jpg"");
      background-size: 100% 100%;
      animation: 20s slides-set-2 -0.1s infinite; }

 .slideshow--hero .slide3 {
      background-image: url(""/imagens/imghotel.jpg"");
      background-size: 100% 100%;
      animation: 20s slides-set-3 -0.1s infinite; }


 ");
            WriteLiteral(@"@media (min-width: 600px) {
      .slideshow--hero {
        left: 50%;
        top: 0;
        width: 67%;
        height: 100%;
        transform: translateX(-50%) skewX(-10deg); }
        .slideshow--hero .slides {
          top: 0;
          left: -25%;
          height: 100%;
          animation: 11s slideshow-hero -3s infinite; } }

 .slideshow--contrast {
    z-index: 1;
    width: 100%;
    height: 50%;
    transform: none; }

 .slideshow--contrast--before {
      left: 0; }
      .slideshow--contrast--before .slides {
        width: 100vw; }

 .slideshow--contrast--after {
      z-index: 2;
      left: auto;
      right: 0; }
      .slideshow--contrast--after .slides {
        width: 100vw;
        left: auto;
        right: 0; }

 .slideshow--contrast .slides {
      animation: 14s slideshow-contrast -5s infinite; }

 .slideshow--contrast .slide1 {
      background-image: linear-gradient(to bottom, rgba(200, 200, 75, 0.25) 0, rgba(200, 75, 75, 0.5) 100%), url(""/i");
            WriteLiteral(@"magens/imageminicial2.png"");
      animation: 20s slides-set-1 -0.2s infinite; }

 .slideshow--contrast .slide2 {
      background-image: linear-gradient(to bottom, rgba(200, 200, 75, 0.25) 0, rgba(200, 75, 75, 0.5) 100%), url(""/imagens/imgbanho.jpg"");
      animation: 20s slides-set-2 -0.2s infinite; }

 .slideshow--contrast .slide3 {
      background-image: linear-gradient(to bottom, rgba(200, 200, 75, 0.25) 0, rgba(200, 75, 75, 0.5) 100%), url(""/imagens/imghotel.jpg"");
      animation: 20s slides-set-3 -0.2s infinite; }

 .slideshow--contrast--after {
      top: auto;
      bottom: 0; }

 .slideshow--contrast--after .slides {
        animation: 13s slideshow-contrast -13s infinite; }

 .slideshow--contrast--after .slide {
        background-position: right; }

 .slideshow--contrast--after .slide1 {
        animation: 20s slides-set-1 infinite; }

 .slideshow--contrast--after .slide2 {
        animation: 20s slides-set-2 infinite; }

 .slideshow--contrast--after .slide3 {
       ");
            WriteLiteral(" animation: 20s slides-set-3 infinite; }\r\n\r\n .slideshow--contrast--after .slide4 {\r\n        animation: 20s slides-set-4 infinite; }\r\n\r\n .slideshow--contrast--after .slide5 {\r\n        animation: 20s slides-set-5 infinite; }\r\n\r\n\r\n ");
            WriteLiteral(@"@media (min-width: 600px) {
      .slideshow--contrast {
        width: 50%;
        height: 100%; }

 .slideshow--contrast--after {
          top: 0;
          bottom: auto; }
          .slideshow--contrast--after .slides {
            width: 50vw; } }

.slides,
.slide {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background-position: center;
  background-size: cover;
  background-repeat: no-repeat; }

");
            WriteLiteral("@keyframes slideshow-hero-mobile {\r\n  0% {\r\n    transform: scale(1) skewY(10deg); }\r\n  50% {\r\n    transform: scale(1.05) skewY(10deg); }\r\n  100% {\r\n    transform: scale(1) skewY(10deg); } }\r\n\r\n");
            WriteLiteral("@keyframes slideshow-hero {\r\n  0% {\r\n    transform: scale(1) skewX(10deg); }\r\n  50% {\r\n    transform: scale(1.05) skewX(10deg); }\r\n  100% {\r\n    transform: scale(1) skewX(10deg); } }\r\n\r\n");
            WriteLiteral("@keyframes slideshow-contrast {\r\n  0% {\r\n    transform: scale(1.05); }\r\n  50% {\r\n    transform: scale(1); }\r\n  100% {\r\n    transform: scale(1.05); } }\r\n\r\n");
            WriteLiteral(@"@keyframes slides-set-1 {
  0% {
    opacity: 1;
    transform: scale(1); }
  31% {
    opacity: 1;
    transform: scale(1); }
  34% {
    opacity: 0;
    transform: scale(1.05); }
  97% {
    opacity: 0;
    transform: scale(1.05); }
  100% {
    opacity: 1;
    transform: scale(1); } }

");
            WriteLiteral(@"@keyframes slides-set-2 {
  0% {
    opacity: 0;
    transform: scale(1.05); }
  31% {
    opacity: 0;
    transform: scale(1.05); }
  34% {
    opacity: 1;
    transform: scale(1); }
  64% {
    opacity: 1;
    transform: scale(1); }
  67% {
    opacity: 0;
    transform: scale(1.05); }
  100% {
    opacity: 0;
    transform: scale(1.05); } }

");
            WriteLiteral(@"@keyframes slides-set-3 {
  0% {
    opacity: 0;
    transform: scale(1.05); }
  64% {
    opacity: 0;
    transform: scale(1.05); }
  67% {
    opacity: 1;
    transform: scale(1); }
  97% {
    opacity: 1;
    transform: scale(1); }
  100% {
    opacity: 0;
    transform: scale(1.05); } }
    

");
            WriteLiteral(@"@keyframes slides-set-4 {
  0% {
    opacity: 0;
    transform: scale(1.05); }
  64% {
    opacity: 0;
    transform: scale(1.05); }
  67% {
    opacity: 1;
    transform: scale(1); }
  97% {
    opacity: 1;
    transform: scale(1); }
  100% {
    opacity: 0;
    transform: scale(1.05); } }
    

");
            WriteLiteral(@"@keyframes slides-set-5 {
  0% {
    opacity: 0;
    transform: scale(1.05); }
  64% {
    opacity: 0;
    transform: scale(1.05); }
  67% {
    opacity: 1;
    transform: scale(1); }
  97% {
    opacity: 1;
    transform: scale(1); }
  100% {
    opacity: 0;
    transform: scale(1.05); } }
    

 </style>");
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