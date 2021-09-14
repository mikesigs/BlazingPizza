// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazingPizza.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using BlazingComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Pages\MyOrders.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/myorders")]
    public partial class MyOrders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Pages\MyOrders.razor"
       
    private async Task<IEnumerable<OrderWithStatus>> LoadOrders()
    {
        try
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            return await OrdersClient.GetOrders();
        }
        catch (AccessTokenNotAvailableException ex)
        {
            ex.Redirect();
        }

        return Enumerable.Empty<OrderWithStatus>();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrdersClient OrdersClient { get; set; }
    }
}
#pragma warning restore 1591