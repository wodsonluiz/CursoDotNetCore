#pragma checksum "C:\Users\aspnet8073\Desktop\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f1bb35909b71ca0c183ba239623c79cf12adf4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_EditorTemplates_Post), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/EditorTemplates/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/EditorTemplates/Post.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_EditorTemplates_Post))]
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
#line 6 "C:\Users\aspnet8073\Desktop\Blog\Blog\Areas\Admin\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f1bb35909b71ca0c183ba239623c79cf12adf4a", @"/Areas/Admin/Views/Shared/EditorTemplates/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a949051d1bacac6f02e289135a3092db5b291f49", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_EditorTemplates_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(16, 28, false);
#line 3 "C:\Users\aspnet8073\Desktop\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.LabelFor(p => p.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(47, 61, false);
#line 4 "C:\Users\aspnet8073\Desktop\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.TextBoxFor(p => p.Titulo, new { @class="form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(108, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(111, 40, false);
#line 5 "C:\Users\aspnet8073\Desktop\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.ValidationMessageFor(p => p.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(151, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(156, 28, false);
#line 7 "C:\Users\aspnet8073\Desktop\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.LabelFor(p => p.Resumo));

#line default
#line hidden
            EndContext();
            BeginContext(184, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(187, 73, false);
#line 8 "C:\Users\aspnet8073\Desktop\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.TextBoxFor(p => p.Resumo, new { @class = "form-control" , rows = 6}));

#line default
#line hidden
            EndContext();
            BeginContext(260, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(263, 40, false);
#line 9 "C:\Users\aspnet8073\Desktop\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.ValidationMessageFor(p => p.Resumo));

#line default
#line hidden
            EndContext();
            BeginContext(303, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(308, 31, false);
#line 11 "C:\Users\aspnet8073\Desktop\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.LabelFor(p => p.Categoria));

#line default
#line hidden
            EndContext();
            BeginContext(339, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(342, 66, false);
#line 12 "C:\Users\aspnet8073\Desktop\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.TextBoxFor(p => p.Categoria, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(408, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(411, 43, false);
#line 13 "C:\Users\aspnet8073\Desktop\Blog\Blog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.ValidationMessageFor(p => p.Categoria));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
