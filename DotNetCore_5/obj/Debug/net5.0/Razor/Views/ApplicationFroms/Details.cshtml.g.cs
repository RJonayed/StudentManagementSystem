#pragma checksum "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15d3df30ac5355b139ce5642fe04480a728f51fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplicationFroms_Details), @"mvc.1.0.view", @"/Views/ApplicationFroms/Details.cshtml")]
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
#line 1 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\_ViewImports.cshtml"
using DotNetCore_5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\_ViewImports.cshtml"
using DotNetCore_5.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\_ViewImports.cshtml"
using DotNetCore_5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\_ViewImports.cshtml"
using DotNetCore_5.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15d3df30ac5355b139ce5642fe04480a728f51fb", @"/Views/ApplicationFroms/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aec24495bc6e2be1d3148d1e44c546262549da7", @"/Views/_ViewImports.cshtml")]
    public class Views_ApplicationFroms_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNetCore_5.Models.ApplicationFrom>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("change_edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h4>Application From Details</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApplicantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicantName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApplicantName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Religion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayFor(model => model.Religion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BirthRegistrationNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayFor(model => model.BirthRegistrationNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FatherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayFor(model => model.FatherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MothrsName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayFor(model => model.MothrsName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ContNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayFor(model => model.ContNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsSelect));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsSelect));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Class));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayFor(model => model.Class.ClassName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Branch));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayFor(model => model.Branch.BranchLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.School));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
       Write(Html.DisplayFor(model => model.School.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Image\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "15d3df30ac5355b139ce5642fe04480a728f51fb16117", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/images/");
#nullable restore
#line 101 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
                   WriteLiteral(Model.ImageUrl);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 101 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15d3df30ac5355b139ce5642fe04480a728f51fb18834", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "E:\IDB-BiSEWITScholarship\Asp.Core-8\PROJECT\DotNetCore_5\DotNetCore_5\Views\ApplicationFroms\Details.cshtml"
                           WriteLiteral(Model.SlNO);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15d3df30ac5355b139ce5642fe04480a728f51fb21009", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<script>
    $(function () {
        $('.changeImage').change(function () {
            var input = this;
            if (input.files) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('.change_edit').attr('src', e.target.result);
                }
                reader.readAsDataURL(input.files[0]);
            }

        })
    })
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotNetCore_5.Models.ApplicationFrom> Html { get; private set; }
    }
}
#pragma warning restore 1591
