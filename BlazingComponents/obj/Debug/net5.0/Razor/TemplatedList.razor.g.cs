#pragma checksum "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingComponents\TemplatedList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9b97c296a7247980a0cb4ef1def0413995e8766"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class TemplatedList<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingComponents\TemplatedList.razor"
 if (items == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 5 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingComponents\TemplatedList.razor"
     Loading

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 5 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingComponents\TemplatedList.razor"
            
}
else if (!items.Any())
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 9 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingComponents\TemplatedList.razor"
     Empty

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 9 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingComponents\TemplatedList.razor"
          
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "list-group" + " " + (
#nullable restore
#line 13 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingComponents\TemplatedList.razor"
                            ListGroupClass

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 14 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingComponents\TemplatedList.razor"
         foreach (var item in items)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "list-group-item");
            __builder.AddContent(6, 
#nullable restore
#line 17 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingComponents\TemplatedList.razor"
                 Item(item)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingComponents\TemplatedList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingComponents\TemplatedList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Code\GitHub\blazor-workshop\save-points\00-get-started\BlazingComponents\TemplatedList.razor"
       
    IEnumerable<TItem> items;
    [Parameter] public Func<Task<IEnumerable<TItem>>> Loader { get; set; }
    [Parameter] public RenderFragment Loading { get; set; }
    [Parameter] public RenderFragment Empty { get; set; }
    [Parameter] public RenderFragment<TItem> Item { get; set; }
    [Parameter] public string ListGroupClass { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        items = await Loader();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591