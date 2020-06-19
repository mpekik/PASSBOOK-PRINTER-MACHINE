#pragma checksum "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\BukuTabungan\CetakBerhasilComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19e9dc4770d131706c1d9e535639d3e25f68ae7d"
// <auto-generated/>
#pragma warning disable 1591
namespace Integrasi_HTML.Component.BukuTabungan
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\_Imports.razor"
using Integrasi_HTML;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\_Imports.razor"
using Integrasi_HTML.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\BukuTabungan\CetakBerhasilComponent.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\BukuTabungan\CetakBerhasilComponent.razor"
using System.IO.Ports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\BukuTabungan\CetakBerhasilComponent.razor"
using Integrasi_HTML.Data;

#line default
#line hidden
#nullable disable
    public partial class CetakBerhasilComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""col-md-8"" style=""margin-top: 15%; text-align: center;"">
    <img src=""../../assets/img/icn-berhasil.png"" style=""width: 15%;""><br><br>
    <p class=""teks-desc6"">Buku <b style=""color: rgb(0, 211, 95);"">Berhasil</b> dicetak</p>
    <p class=""teks-desc6"">""Silakan Ambil Buku Tabungan Anda""</p>
</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\user\Source\Repos\mpekik\BNI-SPRINT\Component\BukuTabungan\CetakBerhasilComponent.razor"
       
    protected override async Task OnInitializedAsync()
    {//comment
        edc.Clear();
        edc.serialPort = new SerialPort();
        edc.serialPort.PortName = "COM6";
        edc.serialPort.DataReceived += new SerialDataReceivedEventHandler(edc.port_DataReceived);
        await Task.Run(() => edc.SendCommand(edc.serialPort, "13"));
        do
        {
            Task.Delay(100);
            if (edc.statusCode == "00")
            {
                break;
            }
            else if (edc.statusCode == "55" || edc.statusCode == "TO")
            {
                break;
            }
        } while (edc.statusCode == string.Empty);
        await Task.Delay(5000);
        navman.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EDC edc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navman { get; set; }
    }
}
#pragma warning restore 1591
