#pragma checksum "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Pages\PilihMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "482d4b8837a2ba952d032509bb62765f703c89fc"
// <auto-generated/>
#pragma warning disable 1591
namespace Integrasi_HTML.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\_Imports.razor"
using Integrasi_HTML;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\_Imports.razor"
using Integrasi_HTML.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pilihmenu")]
    public partial class PilihMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "wrapper");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "main-panel");
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "content");
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "container-fluid");
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.AddMarkupContent(15, @"<div class=""col-md-4"">
                            <img class=""bni-logo"" src=""../assets/img/bni-white.png""><br><br><br>
                            <div class=""text-white"">
                                <h2 class=""teks-sidebar font-qs-bold"">Cetak Transaksi Anda</h2><br>
                            </div>
                            <img class=""nav-vektor"" src=""../assets/img/vektor-a.png"">
                        </div>

                        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-md-8");
            __builder.AddAttribute(18, "style", "text-align: center; margin-top: 7%;");
            __builder.AddMarkupContent(19, "\r\n                            <img class=\"img-list-menu\" src=\"../assets/img/list-menu.png\">\r\n                            ");
            __builder.AddMarkupContent(20, "<h2 class=\"teks-jenis-trx\">Silakan pilih jenis Transaksi</h2>\r\n\r\n                            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "row2");
            __builder.AddAttribute(23, "style", "margin-left: 12%;");
            __builder.AddMarkupContent(24, "\r\n                                ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "card");
            __builder.AddAttribute(27, "style", "width: 17rem; height: 19rem;");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Pages\PilihMenu.razor"
                                                                                                 buku

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "\r\n                                    <img class=\"card-img-top\" src=\"../assets/img/card-bni.png\" alt=\"Card image cap\">\r\n                                    ");
            __builder.AddMarkupContent(30, @"<div class=""card-body"">
                                        <h5 class=""card-title"">Buku Tabungan</h5>
                                        <p class=""card-text"">Cetak transaksi pada buku tabungan Anda</p>
                                    </div>
                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n                                ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "card");
            __builder.AddAttribute(34, "style", "width: 17rem; height: 19rem; margin-left: 8rem;");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Pages\PilihMenu.razor"
                                                                                                                    histori

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "\r\n                                    <img class=\"card-img-top\" src=\"../assets/img/img-histori.png\" alt=\"Card image cap\" style=\"width: 52%;\">\r\n                                    ");
            __builder.AddMarkupContent(37, @"<div class=""card-body"">
                                        <h5 class=""card-title"">Histori Transaksi</h5>
                                        <p class=""card-text"">Cetak transaksi pada buku tabungan Anda</p>
                                    </div>
                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\user\Documents\Trilogi Persada\Percobaan\Percobaan HTML\Project BNI Passbook\Integrasi HTML\Pages\PilihMenu.razor"
       
    private void buku()
    {
        navman.NavigateTo("/bukutabungan");
    }
    private void histori()
    {
        navman.NavigateTo("/historitransaksi");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navman { get; set; }
    }
}
#pragma warning restore 1591
