#pragma checksum "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25962734ece125c2dd0607fc07aafcf757379a99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_ChiTietHoaDonDaHuy), @"mvc.1.0.view", @"/Views/Main/ChiTietHoaDonDaHuy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25962734ece125c2dd0607fc07aafcf757379a99", @"/Views/Main/ChiTietHoaDonDaHuy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f8e12a6613c91fca2e724ed48ced6a224486ee1", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_ChiTietHoaDonDaHuy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BanMiCay.Models.HoaDon>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
  
    ViewData["Title"] = "Chi tiết hóa đơn";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h4>Chi tiết hóa đơn</h4>
<hr />
<div class=""row"">
    <!--Thông tin hóa đơn-->
    <div class=""col-md"">
        <h5>Thông tin hóa đơn</h5>
        <dl class=""row"">
            <dt class=""col-sm-3"">
                Mã hóa đơn
            </dt>
            <dd class=""col-sm-9"">
                ");
#nullable restore
#line 16 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
           Write(Model.Mahd);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                Ngày lập\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 22 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
           Write(Model.Ngay);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                Tổng tiền\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 28 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
           Write(Model.Tongtien);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </dd>
        </dl>
    </div>

    <!--Thông tin khách hàng-->
    <div class=""col-md"">
        <h5>Thông tin khách hàng</h5>
        <dl class=""row"">
            <dt class=""col-sm-3"">
                Mã khách hàng
            </dt>
            <dd class=""col-sm-9"">
                ");
#nullable restore
#line 41 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
           Write(Model.Makh);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                Tên\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 47 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
           Write(Model.MakhNavigation.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                Điện thoại\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 53 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
           Write(Model.MakhNavigation.Dienthoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                Email\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 59 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
           Write(Model.MakhNavigation.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                Địa chỉ\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n");
#nullable restore
#line 65 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
                  
                    string diachi = Model.MadcNavigation.Diachi1 + ", " + Model.MadcNavigation.Phuongxa + ", " + Model.MadcNavigation.Quanhuyen + ", " + Model.MadcNavigation.Tinhthanh;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>");
#nullable restore
#line 67 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
                      Write(diachi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
            WriteLiteral(@"            </dd>
        </dl>
    </div>
</div>

<hr />

<h5>Thông tin sản phẩm</h5>
<table class=""table"">
    <thead>
        <tr>
            <th>STT</th>
            <th>Mã mặt hàng</th>
            <th>Tên</th>
            <th>Hình</th>
            <th>Đơn giá</th>
            <th>Số lượng</th>
            <th>Thành tiền</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 90 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
         foreach (CthoaDon c in ViewBag.chittiethoadon)
        {
            int stt = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 94 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
               Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 95 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
               Write(c.Mamh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 96 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
               Write(c.MamhNavigation.Ten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25962734ece125c2dd0607fc07aafcf757379a999731", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2650, "~/images/product/", 2650, 17, true);
#nullable restore
#line 97 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
AddHtmlAttributeValue("", 2667, c.MamhNavigation.Hinhanh, 2667, 25, false);

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
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 98 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
               Write(c.Dongia.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</td>\r\n                <td>");
#nullable restore
#line 99 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
               Write(c.Soluong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 100 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
               Write(c.Thanhtien.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</td>\r\n            </tr>\r\n");
#nullable restore
#line 102 "C:\Users\t0195\Desktop\Quản lý dự án phần mềm\Nhom\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\ChiTietHoaDonDaHuy.cshtml"
            stt++;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BanMiCay.Models.HoaDon> Html { get; private set; }
    }
}
#pragma warning restore 1591
