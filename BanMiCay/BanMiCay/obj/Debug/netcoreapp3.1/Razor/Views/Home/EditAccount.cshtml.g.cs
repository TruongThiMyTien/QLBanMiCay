#pragma checksum "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Demo\QLBanMiCay\BanMiCay\BanMiCay\Views\Home\EditAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58b9fe4694f1f15bfd19cdc366d895fee5f5aab1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditAccount), @"mvc.1.0.view", @"/Views/Home/EditAccount.cshtml")]
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
#line 1 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Demo\QLBanMiCay\BanMiCay\BanMiCay\Views\_ViewImports.cshtml"
using BanMiCay;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Demo\QLBanMiCay\BanMiCay\BanMiCay\Views\_ViewImports.cshtml"
using BanMiCay.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58b9fe4694f1f15bfd19cdc366d895fee5f5aab1", @"/Views/Home/EditAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f8e12a6613c91fca2e724ed48ced6a224486ee1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EditAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Demo\QLBanMiCay\BanMiCay\BanMiCay\Views\Home\EditAccount.cshtml"
  
    ViewData["Title"] = "Sửa thông tin tài khoản";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row justify-content-center\">\r\n        <h3 class=\"col-md-4 text-success\">Sửa thông tin tài khoản</h3>\r\n    </div>\r\n    <div class=\"row justify-content-center\">\r\n        <div class=\"col-md-4 \">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58b9fe4694f1f15bfd19cdc366d895fee5f5aab14131", async() => {
                WriteLiteral("\r\n                <div class=\"my-3\">\r\n                    <label>Họ tên</label>\r\n                    <input type=\"text\" name=\"hoten\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 489, "\"", 519, 1);
#nullable restore
#line 13 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Demo\QLBanMiCay\BanMiCay\BanMiCay\Views\Home\EditAccount.cshtml"
WriteAttributeValue("", 497, ViewBag.khachhang.Ten, 497, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"my-3\">\r\n                    <label>Số điện thoại</label>\r\n                    <input type=\"text\" name=\"dienthoai\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 711, "\"", 747, 1);
#nullable restore
#line 17 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Demo\QLBanMiCay\BanMiCay\BanMiCay\Views\Home\EditAccount.cshtml"
WriteAttributeValue("", 719, ViewBag.khachhang.Dienthoai, 719, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"my-3\">\r\n                    <label>Email</label>\r\n                    <input type=\"text\" name=\"email\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 927, "\"", 959, 1);
#nullable restore
#line 21 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Demo\QLBanMiCay\BanMiCay\BanMiCay\Views\Home\EditAccount.cshtml"
WriteAttributeValue("", 935, ViewBag.khachhang.Email, 935, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                </div>
                <div class=""my-3"">
                    <label>Mật khẩu mới</label>
                    <input type=""text"" name=""matkhau"" class=""form-control"" />
                </div>
                <div class=""my-3 d-grid"">
                    <input type=""submit"" value=""Lưu"" class=""btn btn-block btn-success"" />
                </div>
            ");
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
