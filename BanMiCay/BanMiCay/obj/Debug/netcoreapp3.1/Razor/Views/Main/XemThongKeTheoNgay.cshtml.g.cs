#pragma checksum "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e0863321954b877e537c03115f11b930788117cb066561ec5ee87ad00a7cf2f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_XemThongKeTheoNgay), @"mvc.1.0.view", @"/Views/Main/XemThongKeTheoNgay.cshtml")]
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
#line 1 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\_ViewImports.cshtml"
using BanMiCay;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\_ViewImports.cshtml"
using BanMiCay.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e0863321954b877e537c03115f11b930788117cb066561ec5ee87ad00a7cf2f5", @"/Views/Main/XemThongKeTheoNgay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"801e77daed53be91f2d08329a1e3ba1a39dced2649041bb2991ca47334302198", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Main_XemThongKeTheoNgay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BanMiCay.Models.HoaDon>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ThongKeTheoNgay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-info\">Thống kê hóa đơn theo ngày</h1>\r\n<label>Ngày bắt đầu: ");
#nullable restore
#line 8 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml"
                Write(ViewData["ngaybatdau"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n<label>Ngày kết thúc: ");
#nullable restore
#line 9 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml"
                 Write(ViewData["ngayketthuc"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n<label>Tổng tiền trong khoảng thời gian trên: ");
#nullable restore
#line 10 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml"
                                         Write(ViewData["tongtien"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0863321954b877e537c03115f11b930788117cb066561ec5ee87ad00a7cf2f54958", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml"
           Write(Html.DisplayNameFor(model => model.Mahd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml"
           Write(Html.DisplayNameFor(model => model.Ngay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml"
           Write(Html.DisplayNameFor(model => model.Tongtien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml"
           Write(Html.DisplayNameFor(model => model.MakhNavigation.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml"
           Write(Html.DisplayNameFor(model => model.MakhNavigation.Dienthoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml"
           Write(Html.DisplayNameFor(model => model.Trangthai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml"
               Write(Html.DisplayFor(modelItem => item.Mahd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ngay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tongtien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml"
               Write(Html.DisplayFor(modelItem => item.MakhNavigation.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml"
               Write(Html.DisplayFor(modelItem => item.MakhNavigation.Dienthoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml"
               Write(Html.DisplayFor(modelItem => item.Trangthai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 60 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Main\XemThongKeTheoNgay.cshtml"
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
