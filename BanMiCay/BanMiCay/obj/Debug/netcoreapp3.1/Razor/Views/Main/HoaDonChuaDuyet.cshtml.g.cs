#pragma checksum "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81f53d0a4392c73b3b89236d5b303f961b1b976c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_HoaDonChuaDuyet), @"mvc.1.0.view", @"/Views/Main/HoaDonChuaDuyet.cshtml")]
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
#line 1 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\_ViewImports.cshtml"
using BanMiCay;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\_ViewImports.cshtml"
using BanMiCay.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81f53d0a4392c73b3b89236d5b303f961b1b976c", @"/Views/Main/HoaDonChuaDuyet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f8e12a6613c91fca2e724ed48ced6a224486ee1", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_HoaDonChuaDuyet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BanMiCay.Models.HoaDon>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChiTietHoaDonChuaDuyet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml"
  
    ViewData["Title"] = "Hóa đơn chưa duyệt";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Hóa đơn chưa duyệt</h1>
<table class=""table"">
    <thead>
        <tr>
            <th>Mã HD</th>
            <th>Ngày lập</th>
            <th>Tổng tiền (đ)</th>
            <th>Khách hàng</th>
            <th>Địa chỉ</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml"
         foreach (HoaDon i in Model)
        {
            string diachi = i.MadcNavigation.Diachi1 + ", " + i.MadcNavigation.Phuongxa + ", " + i.MadcNavigation.Quanhuyen + ", " + i.MadcNavigation.Tinhthanh;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml"
               Write(i.Mahd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml"
               Write(i.Ngay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml"
               Write(i.Tongtien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml"
               Write(i.MakhNavigation.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                \r\n                <td>");
#nullable restore
#line 27 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml"
               Write(diachi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81f53d0a4392c73b3b89236d5b303f961b1b976c6398", async() => {
                WriteLiteral("\r\n                         Chi tiết\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml"
                                                                                     WriteLiteral(i.Mahd);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BanMiCay.Models.HoaDon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
