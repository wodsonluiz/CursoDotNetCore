#pragma checksum "C:\Users\aspnet8073\Desktop\Blog\Blog\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aebcff9af4202cbb1ceb0ce8e422875ec404c03c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Index.cshtml", typeof(AspNetCore.Views_Post_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aebcff9af4202cbb1ceb0ce8e422875ec404c03c", @"/Views/Post/Index.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\aspnet8073\Desktop\Blog\Blog\Views\Post\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(77, 18, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n");
            EndContext();
            BeginContext(96, 39, false);
#line 9 "C:\Users\aspnet8073\Desktop\Blog\Blog\Views\Post\Index.cshtml"
Write(Html.ActionLink("Incluir Post", "Novo"));

#line default
#line hidden
            EndContext();
            BeginContext(135, 232, true);
            WriteLiteral(";\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Titulo</th>\r\n            <th>Resumo</th>\r\n            <th>Categoria</th>\r\n            <th>Publicado?</th>\r\n            <th>Ações</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 21 "C:\Users\aspnet8073\Desktop\Blog\Blog\Views\Post\Index.cshtml"
         foreach (var p in Model)
        {

#line default
#line hidden
            BeginContext(413, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(444, 57, false);
#line 24 "C:\Users\aspnet8073\Desktop\Blog\Blog\Views\Post\Index.cshtml"
           Write(Html.ActionLink(p.Titulo, "Visualiza", new { Id = p.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(501, 24, true);
            WriteLiteral(";</td>\r\n            <td>");
            EndContext();
            BeginContext(526, 8, false);
#line 25 "C:\Users\aspnet8073\Desktop\Blog\Blog\Views\Post\Index.cshtml"
           Write(p.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(534, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(558, 8, false);
#line 26 "C:\Users\aspnet8073\Desktop\Blog\Blog\Views\Post\Index.cshtml"
           Write(p.Resumo);

#line default
#line hidden
            EndContext();
            BeginContext(566, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(590, 11, false);
#line 27 "C:\Users\aspnet8073\Desktop\Blog\Blog\Views\Post\Index.cshtml"
           Write(p.Categoria);

#line default
#line hidden
            EndContext();
            BeginContext(601, 25, true);
            WriteLiteral("</td>\r\n            <td>\r\n");
            EndContext();
#line 29 "C:\Users\aspnet8073\Desktop\Blog\Blog\Views\Post\Index.cshtml"
                 if (p.Publicado == true)
                {
                    

#line default
#line hidden
            BeginContext(709, 59, false);
#line 31 "C:\Users\aspnet8073\Desktop\Blog\Blog\Views\Post\Index.cshtml"
               Write(Html.Raw(string.Format("{0:dd/MM/yyyy}", p.DataPublicacao)));

#line default
#line hidden
            EndContext();
#line 31 "C:\Users\aspnet8073\Desktop\Blog\Blog\Views\Post\Index.cshtml"
                                                                                
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(851, 15, false);
#line 35 "C:\Users\aspnet8073\Desktop\Blog\Blog\Views\Post\Index.cshtml"
               Write(Html.Raw("Não"));

#line default
#line hidden
            EndContext();
#line 35 "C:\Users\aspnet8073\Desktop\Blog\Blog\Views\Post\Index.cshtml"
                                    ;
                }

#line default
#line hidden
            BeginContext(888, 35, true);
            WriteLiteral("            </td>\r\n            <td>");
            EndContext();
            BeginContext(924, 59, false);
#line 38 "C:\Users\aspnet8073\Desktop\Blog\Blog\Views\Post\Index.cshtml"
           Write(Html.ActionLink("Remover", "RemovePost", new { id = p.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(983, 24, true);
            WriteLiteral(";</td>\r\n            <td>");
            EndContext();
            BeginContext(1008, 61, false);
#line 39 "C:\Users\aspnet8073\Desktop\Blog\Blog\Views\Post\Index.cshtml"
           Write(Html.ActionLink("Publicar", "PublicaPost", new { id = p.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 23, true);
            WriteLiteral(";</td>\r\n        </tr>\r\n");
            EndContext();
#line 41 "C:\Users\aspnet8073\Desktop\Blog\Blog\Views\Post\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1103, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
