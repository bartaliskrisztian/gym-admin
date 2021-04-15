// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FitnessProject.Pages.ClientPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using FitnessProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using FitnessProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\_Imports.razor"
using FitnessProject.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/deleteClient/{CurrentId}")]
    public partial class DeleteClient : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "E:\Egyetem\VI\dotnet\FitnessProject\FitnessProject\Pages\ClientPages\DeleteClient.razor"
       
    [Parameter]
    public string CurrentId { get; set; }
    Client client = new Client();

    protected override async Task OnInitializedAsync()
    {
        client = await Task.Run(() => objClientService.GetClientById(Convert.ToInt32(CurrentId)));
    }

    protected void RemoveClient()
    {
        objClientService.DeleteClient(client);
        NavigationManager.NavigateTo("clients");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("clients");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientService objClientService { get; set; }
    }
}
#pragma warning restore 1591
