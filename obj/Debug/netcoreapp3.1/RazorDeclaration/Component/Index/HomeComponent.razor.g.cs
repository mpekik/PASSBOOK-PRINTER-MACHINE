#pragma checksum "C:\Users\TRILOGI\Documents\Trilogi\Project\BNI\New folder\Integrasi HTML\Component\Index\HomeComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e101360a040c8efa5fd95f8186829bfd8d707d8f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Integrasi_HTML.Component.Index
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
#line 1 "C:\Users\TRILOGI\Documents\Trilogi\Project\BNI\New folder\Integrasi HTML\Component\Index\HomeComponent.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TRILOGI\Documents\Trilogi\Project\BNI\New folder\Integrasi HTML\Component\Index\HomeComponent.razor"
using Integrasi_HTML.Data;

#line default
#line hidden
#nullable disable
    public partial class HomeComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\TRILOGI\Documents\Trilogi\Project\BNI\New folder\Integrasi HTML\Component\Index\HomeComponent.razor"
               
            [Parameter]
            public EventCallback<string> OnClick { get; set; }

            public string cabangbni = "KCP Cikupa 3";

            public void login()
            {
                trx.setcabang(cabangbni);
                OnClick.InvokeAsync("login");
            }
        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private transaksi trx { get; set; }
    }
}
#pragma warning restore 1591