#pragma checksum "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\AdminPostagens\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c528a9634e605fe98e49b86424fce42ef9f09dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPostagens_Listar), @"mvc.1.0.view", @"/Views/AdminPostagens/Listar.cshtml")]
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
#line 1 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\_ViewImports.cshtml"
using PWABlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\_ViewImports.cshtml"
using PWABlog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\AdminPostagens\Listar.cshtml"
using PWABlog.ViewModels.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c528a9634e605fe98e49b86424fce42ef9f09dc", @"/Views/AdminPostagens/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c906f599f5ea20069f61f157194e01c171f90b99", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminPostagens_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PWABlog.ViewModels.Admin.AdminPostagensListarViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/postagens/criar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header"">
        <h3 class=""card-title"">Listagem de Postagens</h3>

        <div class=""card-tools"">
            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                <i class=""fas fa-minus""></i>
            </button>
        </div>
    </div>
    <div class=""card-body"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c528a9634e605fe98e49b86424fce42ef9f09dc4487", async() => {
                WriteLiteral("Criar nova Postagem");
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
            WriteLiteral(@"
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Nome</th>
                    <th>Categoria</th>
                    <th>Autor</th>
                    <th>Ações</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 27 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\AdminPostagens\Listar.cshtml"
                 foreach (PostagemAdminPostagens postagens in @Model.Postagens)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\AdminPostagens\Listar.cshtml"
                   Write(postagens.IdPostagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\AdminPostagens\Listar.cshtml"
                   Write(postagens.NomePostagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\AdminPostagens\Listar.cshtml"
                   Write(postagens.NomeCategoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\AdminPostagens\Listar.cshtml"
                   Write(postagens.NomeAutor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    \r\n                    <td>\r\n                        <a class=\"btn btn-default btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 1359, "\"", 1411, 2);
            WriteAttributeValue("", 1366, "/admin/etiquetas/editar/", 1366, 24, true);
#nullable restore
#line 36 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\AdminPostagens\Listar.cshtml"
WriteAttributeValue("", 1390, postagens.IdPostagem, 1390, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                        <a class=\"btn btn-danger btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 1481, "\"", 1534, 2);
            WriteAttributeValue("", 1488, "/admin/etiquetas/remover/", 1488, 25, true);
#nullable restore
#line 37 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\AdminPostagens\Listar.cshtml"
WriteAttributeValue("", 1513, postagens.IdPostagem, 1513, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remover</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 40 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\AdminPostagens\Listar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PWABlog.ViewModels.Admin.AdminPostagensListarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
