#pragma checksum "/Users/daisukesato/AspNetCore.Docs/aspnetcore/data/ef-mvc/intro/samples/cu-final/Views/Courses/UpdateCourseCredits.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2c0b0c0db9470aaaeb6b56ef78ba7778225a9f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_UpdateCourseCredits), @"mvc.1.0.view", @"/Views/Courses/UpdateCourseCredits.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/UpdateCourseCredits.cshtml", typeof(AspNetCore.Views_Courses_UpdateCourseCredits))]
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
#line 1 "/Users/daisukesato/AspNetCore.Docs/aspnetcore/data/ef-mvc/intro/samples/cu-final/Views/_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
#line 2 "/Users/daisukesato/AspNetCore.Docs/aspnetcore/data/ef-mvc/intro/samples/cu-final/Views/_ViewImports.cshtml"
using ContosoUniversity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2c0b0c0db9470aaaeb6b56ef78ba7778225a9f1", @"/Views/Courses/UpdateCourseCredits.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd4358eedcd619245030e2e2b4d3f06dd6511943", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_UpdateCourseCredits : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateCourseCredits", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "/Users/daisukesato/AspNetCore.Docs/aspnetcore/data/ef-mvc/intro/samples/cu-final/Views/Courses/UpdateCourseCredits.cshtml"
  
    ViewBag.Title = "UpdateCourseCredits";

#line default
#line hidden
            BeginContext(48, 33, true);
            WriteLiteral("\n<h2>Update Course Credits</h2>\n\n");
            EndContext();
#line 7 "/Users/daisukesato/AspNetCore.Docs/aspnetcore/data/ef-mvc/intro/samples/cu-final/Views/Courses/UpdateCourseCredits.cshtml"
 if (ViewData["RowsAffected"] == null)
{

#line default
#line hidden
            BeginContext(122, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(126, 353, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2c0b0c0db9470aaaeb6b56ef78ba7778225a9f14329", async() => {
                BeginContext(165, 131, true);
                WriteLiteral("\n        <div class=\"form-actions no-color\">\n            <p>\n                Enter a number to multiply every course\'s credits by: ");
                EndContext();
                BeginContext(297, 26, false);
#line 12 "/Users/daisukesato/AspNetCore.Docs/aspnetcore/data/ef-mvc/intro/samples/cu-final/Views/Courses/UpdateCourseCredits.cshtml"
                                                                 Write(Html.TextBox("multiplier"));

#line default
#line hidden
                EndContext();
                BeginContext(323, 149, true);
                WriteLiteral("\n            </p>\n            <p>\n                <input type=\"submit\" value=\"Update\" class=\"btn btn-default\" />\n            </p>\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(479, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 19 "/Users/daisukesato/AspNetCore.Docs/aspnetcore/data/ef-mvc/intro/samples/cu-final/Views/Courses/UpdateCourseCredits.cshtml"
}

#line default
#line hidden
#line 20 "/Users/daisukesato/AspNetCore.Docs/aspnetcore/data/ef-mvc/intro/samples/cu-final/Views/Courses/UpdateCourseCredits.cshtml"
 if (ViewData["RowsAffected"] != null)
{

#line default
#line hidden
            BeginContext(523, 40, true);
            WriteLiteral("    <p>\n        Number of rows updated: ");
            EndContext();
            BeginContext(564, 24, false);
#line 23 "/Users/daisukesato/AspNetCore.Docs/aspnetcore/data/ef-mvc/intro/samples/cu-final/Views/Courses/UpdateCourseCredits.cshtml"
                           Write(ViewData["RowsAffected"]);

#line default
#line hidden
            EndContext();
            BeginContext(588, 10, true);
            WriteLiteral("\n    </p>\n");
            EndContext();
#line 25 "/Users/daisukesato/AspNetCore.Docs/aspnetcore/data/ef-mvc/intro/samples/cu-final/Views/Courses/UpdateCourseCredits.cshtml"
}

#line default
#line hidden
            BeginContext(600, 10, true);
            WriteLiteral("<div>\n    ");
            EndContext();
            BeginContext(611, 40, false);
#line 27 "/Users/daisukesato/AspNetCore.Docs/aspnetcore/data/ef-mvc/intro/samples/cu-final/Views/Courses/UpdateCourseCredits.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(651, 7, true);
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
