#pragma checksum "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Home\CreateBill.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9047e614eacbf6d507d23b4085528e885130d2747cd5a87c75879920eee417e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateBill), @"mvc.1.0.view", @"/Views/Home/CreateBill.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9047e614eacbf6d507d23b4085528e885130d2747cd5a87c75879920eee417e6", @"/Views/Home/CreateBill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"801e77daed53be91f2d08329a1e3ba1a39dced2649041bb2991ca47334302198", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_CreateBill : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BanMiCay.Models.HoaDon>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Home\CreateBill.cshtml"
  
    ViewData["Title"] = "Đặt hàng thành công";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>Đơn hàng có mã ");
#nullable restore
#line 5 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Home\CreateBill.cshtml"
              Write(Model.Mahd);

#line default
#line hidden
#nullable disable
            WriteLiteral(" trị giá ");
#nullable restore
#line 5 "C:\Users\NHUT TAN\Desktop\MiKhongCayyy\QLBanMiCay\BanMiCay\BanMiCay\Views\Home\CreateBill.cshtml"
                                  Write(Model.Tongtien);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đã được hệ thống ghi nhận. Chúng tôi sẽ sớm liên hệ với bạn...</h4>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BanMiCay.Models.HoaDon> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
