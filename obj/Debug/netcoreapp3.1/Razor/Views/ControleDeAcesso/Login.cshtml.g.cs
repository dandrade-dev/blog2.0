#pragma checksum "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\ControleDeAcesso\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4fcfeceef74f9d37c5aaa01b64bb791579a513c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ControleDeAcesso_Login), @"mvc.1.0.view", @"/Views/ControleDeAcesso/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4fcfeceef74f9d37c5aaa01b64bb791579a513c", @"/Views/ControleDeAcesso/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c906f599f5ea20069f61f157194e01c171f90b99", @"/Views/_ViewImports.cshtml")]
    public class Views_ControleDeAcesso_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PWABlog.ViewModels.ControleDeAcesso.ControleDeAcessoLoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-body login-card-body\">\r\n        <p class=\"login-box-msg\">Login</p>\r\n\r\n         \r\n        \r\n");
#nullable restore
#line 10 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\ControleDeAcesso\Login.cshtml"
             if (@Model.MensagemLogin != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger alert-dismissible\">\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button>\r\n                <h5><i class=\"icon fas fa-ban\"></i> Erro!</h5>\r\n                ");
#nullable restore
#line 14 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\ControleDeAcesso\Login.cshtml"
           Write(Model.MensagemLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 16 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\ControleDeAcesso\Login.cshtml"
            }           

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n");
#nullable restore
#line 18 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\ControleDeAcesso\Login.cshtml"
                 if (@Model.MensagemRegistro != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""alert alert-success alert-dismissible"">
                    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
                    <h5><i class=""icon fas fa-ban""></i> Sucesso!</h5>
                    ");
#nullable restore
#line 22 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\ControleDeAcesso\Login.cshtml"
               Write(Model.MensagemRegistro);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 24 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\ControleDeAcesso\Login.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4fcfeceef74f9d37c5aaa01b64bb791579a513c5785", async() => {
                WriteLiteral(@"
                    <div class=""input-group mb-3"">

                        <input name=""usuario"" id=""usuario"" type=""email"" class=""form-control"" placeholder=""seunome@mail.com.br"">
                        <div class=""input-group-append"">
                            <div class=""input-group-text"">
                                <span class=""fas fa-envelope""></span>
                            </div>
                        </div>
                    </div>
                    <div class=""input-group mb-3"">

                        <input id=""senha"" name=""senha"" type=""password"" class=""form-control"">
                        <div class=""input-group-append"">
                            <div class=""input-group-text"">
                                <span class=""fas fa-lock""></span>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-8"">
                            <div class=""i");
                WriteLiteral(@"check-primary"">
                                <input type=""checkbox"" id=""remember"">
                                <label for=""remember"">
                                    Lembrar de mim
                                </label>
                            </div>
                        </div>

                        <div class=""col-4"">
                            <input type=""hidden"" name=""destino""");
                BeginWriteAttribute("value", " value=\"", 2571, "\"", 2593, 1);
#nullable restore
#line 56 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\ControleDeAcesso\Login.cshtml"
WriteAttributeValue("", 2579, Model.Destino, 2579, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <button type=\"submit\" class=\"btn btn-primary btn-block\">Entrar</button>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 26 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\ControleDeAcesso\Login.cshtml"
AddHtmlAttributeValue("", 1028, Url.RouteUrl("controleDeAcesso", new {Action = "Login", RedirectUrl = @Model.Destino}), 1028, 87, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <p class=\"mb-1\">\r\n                    <a href=\"#\">Esqueci a senha</a>\r\n                </p>\r\n                <p class=\"mb-0\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2950, "\"", 3018, 1);
#nullable restore
#line 65 "C:\Users\PC\Desktop\pwa-blog-master\PWABlog\Views\ControleDeAcesso\Login.cshtml"
WriteAttributeValue("", 2957, Url.RouteUrl("controleDeAcesso", new {action = "Registrar"}), 2957, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-center\">Registrar novo usuário</a>\r\n                </p>\r\n            </div>\r\n            <!-- /.login-card-body -->\r\n        </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PWABlog.ViewModels.ControleDeAcesso.ControleDeAcessoLoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591