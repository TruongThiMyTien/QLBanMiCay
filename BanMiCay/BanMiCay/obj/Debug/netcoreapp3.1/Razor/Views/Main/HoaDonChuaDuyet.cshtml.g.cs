#pragma checksum "D:\Năm 4 - HK1\QL dự án phần mềm\Baocao\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ecebf4c15d2d983a7ee62926bba554d7d4bd81d2fe464058a4a9299d0954149c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_HoaDonChuaDuyet), @"mvc.1.0.view", @"/Views/Main/HoaDonChuaDuyet.cshtml")]
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
#line 1 "D:\Năm 4 - HK1\QL dự án phần mềm\Baocao\QLBanMiCay\BanMiCay\BanMiCay\Views\_ViewImports.cshtml"
using BanMiCay;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Năm 4 - HK1\QL dự án phần mềm\Baocao\QLBanMiCay\BanMiCay\BanMiCay\Views\_ViewImports.cshtml"
using BanMiCay.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ecebf4c15d2d983a7ee62926bba554d7d4bd81d2fe464058a4a9299d0954149c", @"/Views/Main/HoaDonChuaDuyet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"801e77daed53be91f2d08329a1e3ba1a39dced2649041bb2991ca47334302198", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Main_HoaDonChuaDuyet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BanMiCay.Models.HoaDon>>
    #nullable disable
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
#line 2 "D:\Năm 4 - HK1\QL dự án phần mềm\Baocao\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml"
  
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
#line 19 "D:\Năm 4 - HK1\QL dự án phần mềm\Baocao\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml"
         foreach (HoaDon i in Model)
        {
            string diachi = i.MadcNavigation.Diachi1 + ", " + i.MadcNavigation.Phuongxa + ", " + i.MadcNavigation.Quanhuyen + ", " + i.MadcNavigation.Tinhthanh;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "D:\Năm 4 - HK1\QL dự án phần mềm\Baocao\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml"
               Write(i.Mahd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "D:\Năm 4 - HK1\QL dự án phần mềm\Baocao\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml"
               Write(i.Ngay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "D:\Năm 4 - HK1\QL dự án phần mềm\Baocao\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml"
               Write(i.Tongtien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\Năm 4 - HK1\QL dự án phần mềm\Baocao\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml"
               Write(i.MakhNavigation.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                \r\n                <td>");
#nullable restore
#line 27 "D:\Năm 4 - HK1\QL dự án phần mềm\Baocao\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml"
               Write(diachi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecebf4c15d2d983a7ee62926bba554d7d4bd81d2fe464058a4a9299d0954149c6466", async() => {
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
#line 29 "D:\Năm 4 - HK1\QL dự án phần mềm\Baocao\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml"
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
#line 34 "D:\Năm 4 - HK1\QL dự án phần mềm\Baocao\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\HoaDonChuaDuyet.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BanMiCay.Models.HoaDon>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
