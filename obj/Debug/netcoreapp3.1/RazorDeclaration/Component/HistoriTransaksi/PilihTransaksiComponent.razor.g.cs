#pragma checksum "C:\Users\TRILOGI\Documents\Trilogi\Project\BNI\New folder\Integrasi HTML\Component\HistoriTransaksi\PilihTransaksiComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e42216d8e717ec9371779c3e6a5a3e53934113a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Integrasi_HTML.Component.HistoriTransaksi
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\TRILOGI\Documents\Trilogi\Project\BNI\New folder\Integrasi HTML\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TRILOGI\Documents\Trilogi\Project\BNI\New folder\Integrasi HTML\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TRILOGI\Documents\Trilogi\Project\BNI\New folder\Integrasi HTML\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\TRILOGI\Documents\Trilogi\Project\BNI\New folder\Integrasi HTML\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\TRILOGI\Documents\Trilogi\Project\BNI\New folder\Integrasi HTML\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\TRILOGI\Documents\Trilogi\Project\BNI\New folder\Integrasi HTML\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\TRILOGI\Documents\Trilogi\Project\BNI\New folder\Integrasi HTML\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\TRILOGI\Documents\Trilogi\Project\BNI\New folder\Integrasi HTML\_Imports.razor"
using Integrasi_HTML;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\TRILOGI\Documents\Trilogi\Project\BNI\New folder\Integrasi HTML\_Imports.razor"
using Integrasi_HTML.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\TRILOGI\Documents\Trilogi\Project\BNI\New folder\Integrasi HTML\Component\HistoriTransaksi\PilihTransaksiComponent.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TRILOGI\Documents\Trilogi\Project\BNI\New folder\Integrasi HTML\Component\HistoriTransaksi\PilihTransaksiComponent.razor"
using Integrasi_HTML.Data;

#line default
#line hidden
#nullable disable
    public partial class PilihTransaksiComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\TRILOGI\Documents\Trilogi\Project\BNI\New folder\Integrasi HTML\Component\HistoriTransaksi\PilihTransaksiComponent.razor"
       
    [Parameter]
    public EventCallback<string> OnClick { get; set; }

    private void pilihmenu()
    {
        navman.NavigateTo("/pilihmenu");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navman { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private transaksi trx { get; set; }
    }
}
#pragma warning restore 1591
