#pragma checksum "D:\2 - myProject\C#\Aps.Net\TrainTemplate\TrainWeb\Views\Home\ArticleDetait.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "40d6a5ecafc48dd49c9f01c2db0171c78ee3a1ed3aecfa1aa050ec90ab6c87ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ArticleDetait), @"mvc.1.0.view", @"/Views/Home/ArticleDetait.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\2 - myProject\C#\Aps.Net\TrainTemplate\TrainWeb\Views\_ViewImports.cshtml"
using TrainWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\2 - myProject\C#\Aps.Net\TrainTemplate\TrainWeb\Views\_ViewImports.cshtml"
using TrainWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"40d6a5ecafc48dd49c9f01c2db0171c78ee3a1ed3aecfa1aa050ec90ab6c87ca", @"/Views/Home/ArticleDetait.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bf934ca4549796e6d2d1e972cfe9344c8c8f88594846d8976b159315243314ea", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ArticleDetait : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Article>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\2 - myProject\C#\Aps.Net\TrainTemplate\TrainWeb\Views\Home\ArticleDetait.cshtml"
  
    ViewData["Title"] = "Contact Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""contact-section px-3 py-5 p-md-5"">
    <div class=""container"">
        <table class=""table table-bordered table-hover"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Image</th>
                    <th>Title</th>
                    <th>Description</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");
#nullable restore
#line 18 "D:\2 - myProject\C#\Aps.Net\TrainTemplate\TrainWeb\Views\Home\ArticleDetait.cshtml"
                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "40d6a5ecafc48dd49c9f01c2db0171c78ee3a1ed3aecfa1aa050ec90ab6c87ca4551", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 566, "~/assets/images/blog/", 566, 21, true);
#nullable restore
#line 19 "D:\2 - myProject\C#\Aps.Net\TrainTemplate\TrainWeb\Views\Home\ArticleDetait.cshtml"
AddHtmlAttributeValue("", 587, Model.Image, 587, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "D:\2 - myProject\C#\Aps.Net\TrainTemplate\TrainWeb\Views\Home\ArticleDetait.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "D:\2 - myProject\C#\Aps.Net\TrainTemplate\TrainWeb\Views\Home\ArticleDetait.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Article> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
