#pragma checksum "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a19d9b483ac4fd21aa1f4201b81a8e295dc64f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fornecedor_ListaFornecedor), @"mvc.1.0.view", @"/Views/Fornecedor/ListaFornecedor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a19d9b483ac4fd21aa1f4201b81a8e295dc64f6", @"/Views/Fornecedor/ListaFornecedor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c76e4d29f9f713d607d9723e56f8803d89316042", @"/Views/_ViewImports.cshtml")]
    public class Views_Fornecedor_ListaFornecedor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<fornecedor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/sitepet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Nome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Estado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Cidade", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Celular", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-2 py-1 mx-1 borda-principal pesquisa-grid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Fornecedor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListaFornecedor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9a19d9b483ac4fd21aa1f4201b81a8e295dc64f67097", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
  
    ViewData["Title"] = "Cadastro de Fornecedor - Grid";

    int FiltroPorPag = Int32.Parse(ViewData["itensPorPagina"].ToString());
    int PaginaAtual =  Int32.Parse(ViewData["PaginaAtual"].ToString());
    int NumItensPorPag = (Model.Count()<FiltroPorPag ? Model.Count() : FiltroPorPag);
    int NumTotalDePag = ( NumItensPorPag > 0 ? ( Model.Count()/NumItensPorPag  + (Model.Count()%NumItensPorPag==0 ? 0 : 1)) : 1 );
//    int NumTotalDePag = Model.Count/NumItensPorPag + (Model.Count%NumItensPorPag==0 ? 0 : 1); 


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 18 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
 if( ViewBag.Mensagem != null ){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        <p id=\"pMensagem\">");
#nullable restore
#line 20 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
                     Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 22 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 25 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
  
    await Html.RenderPartialAsync("_FerramentaFooter");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


 <div class=""container-fluid mx-0 px-0"" >
    <div class=""row "">
       <div class=""col-md-12 mx-2 my-2 borda-principal Listagem-Titulo"" >
            <br>        
            <h2  id=""pad-listagem-1""> Cadastro de Fornecedor </h2>
            <br/>
       </div>    
    </div>
 </div>

  <div class=""container-fluid mx-1 px-1"" >

        <div class=""row"">
            
            <div class=""col-md-12 mx-1 px-1 "">
                       
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a19d9b483ac4fd21aa1f4201b81a8e295dc64f610513", async() => {
                WriteLiteral("\r\n        \r\n                    <div class=\"form-group row px-2 \">\r\n \r\n                       <div class=\"col-sm-1 my-1 \">  \r\n                            <select name=\"TipoFiltro\" class=\"form-control\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a19d9b483ac4fd21aa1f4201b81a8e295dc64f611023", async() => {
                    WriteLiteral("Nome");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a19d9b483ac4fd21aa1f4201b81a8e295dc64f612277", async() => {
                    WriteLiteral("Estado");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a19d9b483ac4fd21aa1f4201b81a8e295dc64f613533", async() => {
                    WriteLiteral("Cidade");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a19d9b483ac4fd21aa1f4201b81a8e295dc64f614789", async() => {
                    WriteLiteral("Celular");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a19d9b483ac4fd21aa1f4201b81a8e295dc64f616046", async() => {
                    WriteLiteral("Id");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>

                       </div>

                       <div class=""col-sm-3 my-1 "">
                            <input type=""text"" placeholder=""Filtro"" name=""DadosFiltro"" class=""form-control""/>
                       </div>
                
                       <div class=""col-sm-1 my-1 "">
                           <button type=""submit"" class=""btn btn-primary mb-2  mx-sm-3"">Pesquisar</button>
                       </div>

<!--
                       <div class=""col-sm-2 my-1 "">
                             <select name=""itensSel"" id=""itensSel""   >
                                <option value=""10""  >10 Itens</option>
                                <option value=""15""   >15 Itens </option>
                                <option value=""15""  >15 Itens </option>
                                <option value=""20""  >20 Itens</option>
                                <option value=""35""  >35 Itens</option>
                                <option value=""5");
                WriteLiteral(@"0""  >50 Itens</option>
                           </select>
                        </div>
-->

                       <div class=""col-sm-7 my-1 justify-content-end"" id=""SeletorPaginas"">
                            <nav aria-label=""Navegação"">
                                <ul class=""pagination justify-content-end"">
                                    <li class=""page-item "">
                                    <a class=""page-link"" href=""/Fornecedor/ListaFornecedor?PaginaAtual=1"" tabindex=""-1"">Primeira</a>
                                    </li>
");
#nullable restore
#line 89 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
                                              string estilo = "";

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 91 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
                                             for(int i=1; i<=NumTotalDePag; i++)
                                            {
                                                if( PaginaAtual == i){
                                                    estilo= "active";
                                                }else{
                                                    estilo= "";
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <li");
                BeginWriteAttribute("class", " class=\"", 4162, "\"", 4187, 2);
                WriteAttributeValue("", 4170, "page-item", 4170, 9, true);
#nullable restore
#line 98 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
WriteAttributeValue(" ", 4179, estilo, 4180, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    <a class=\"page-link\"");
                BeginWriteAttribute("href", " href= \"", 4263, "\"", 4313, 2);
                WriteAttributeValue("", 4271, "/Fornecedor/ListaFornecedor?PaginaAtual=", 4271, 40, true);
#nullable restore
#line 99 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
WriteAttributeValue("", 4311, i, 4311, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 99 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
                                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                                </li>\r\n");
#nullable restore
#line 101 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"

                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            \r\n                                    <li class=\"page-item\">\r\n                                        <a class=\"page-link\"");
                BeginWriteAttribute("href", " href= \"", 4577, "\"", 4639, 2);
                WriteAttributeValue("", 4585, "/Fornecedor/ListaFornecedor?PaginaAtual=", 4585, 40, true);
#nullable restore
#line 105 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
WriteAttributeValue("", 4625, NumTotalDePag, 4625, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Ultima</a>\r\n                                    </li>\r\n    \r\n                                </ul>\r\n                            </nav>\r\n                       </div>\r\n\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n");
#nullable restore
#line 116 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
             if(Model.Count()!=0)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table  table-striped table-hover table-responsive""  id=""minhaTabela"" >
                <thead>
                    <tr>
                        <th scope=""col"">
                           <a href=""/Fornecedor/CadastroFornecedor"" class=""btn btn-success btnsm"">Cadastrar</a>  
                        </th>
                        <th scope=""col"">Id</th>
                        <th scope=""col"">Nome Fornecedor</th>
                        <th scope=""col"">Estado</th>
                        <th scope=""col"">Cidade</th>
                        <th scope=""col"">Celular</th>
                        <th scope=""col"">Tel Residencial</th>
                        <th scope=""col"">Tel Comercial</th>
                        <th scope=""col"">1-PF 2-PJ</th>

                    </tr>
                </thead>

                <tbody >

");
#nullable restore
#line 139 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
                    for(int i = (PaginaAtual-1)*NumItensPorPag; i<(NumItensPorPag*PaginaAtual<Model.Count()?NumItensPorPag*PaginaAtual:Model.Count()); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr >\r\n \r\n                            <td id=\"a.idFornecedor\"  class=\"actions\">\r\n\r\n                                  <a");
            BeginWriteAttribute("href", " href=\"", 6131, "\"", 6199, 2);
            WriteAttributeValue("", 6138, "/Fornecedor/EditarFornecedor/", 6138, 29, true);
#nullable restore
#line 145 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
WriteAttributeValue("", 6167, Model.ElementAt(i).idFornecedor, 6167, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n                                      <img src=\"/icones/edit2.png\"  width=\"25\" height=\"25\">\r\n                                  </a>\r\n                                  <a");
            BeginWriteAttribute("href", " href=\"", 6373, "\"", 6438, 2);
            WriteAttributeValue("", 6380, "/Fornecedor/VerFornecedor/", 6380, 26, true);
#nullable restore
#line 148 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
WriteAttributeValue("", 6406, Model.ElementAt(i).idFornecedor, 6406, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n                                      <img src=\"/icones/ver.png\"  width=\"25\" height=\"25\">\r\n                                  </a>\r\n                                  <a");
            BeginWriteAttribute("href", " href=\"", 6610, "\"", 6679, 2);
            WriteAttributeValue("", 6617, "/Fornecedor/DeletarFornecedor/", 6617, 30, true);
#nullable restore
#line 151 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
WriteAttributeValue("", 6647, Model.ElementAt(i).idFornecedor, 6647, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n                                      <img src=\"/icones/delete.png\"  width=\"25\" height=\"25\">\r\n                                  </a>\r\n                            </td> \r\n                            <td >");
#nullable restore
#line 155 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
                            Write(Model.ElementAt(i).idFornecedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 156 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
                           Write(Model.ElementAt(i).nomeFornecedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 157 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
                           Write(Model.ElementAt(i).estadoFornecedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 158 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
                           Write(Model.ElementAt(i).cidadeFornecedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 159 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
                           Write(Model.ElementAt(i).tel1Fornecedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 160 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
                           Write(Model.ElementAt(i).tel2Fornecedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 161 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
                           Write(Model.ElementAt(i).tel3Fornecedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 163 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
                             if( Model.ElementAt(i).pessoaFornecedor == "1"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\"1-Fisíca\"</td>\r\n");
#nullable restore
#line 165 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
                             }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\"2-Juridica\"</td>\r\n");
#nullable restore
#line 167 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                        \r\n                        </tr>\r\n");
#nullable restore
#line 171 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 174 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"

            }else{


#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"msg-nao-econtrado\"> Pesquisa nao econtrado no cadastro, Favor tentar outra !!!</p>\r\n");
#nullable restore
#line 178 "S:\senac-2021\projeto integrador - b\Meucachorro\Views\Fornecedor\ListaFornecedor.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </br>\r\n  </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<fornecedor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
