// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea_II.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\_Imports.razor"
using Tarea_II;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\_Imports.razor"
using Tarea_II.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio2")]
    public partial class Ejercicio2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\Pages\Ejercicio2.razor"
       

    SacadoDatos Apii = new SacadoDatos();
    string nombre = "", phone = "", email = "";
    string imagen = "", password = "", Direccion = "";

    
    public void obtenerDatos()
    {
        var datos = Apii.Conseguir();
        foreach (var people in datos)
        {

            nombre = people.name.first + " " + people.name.last;
            imagen = people.picture.large;
            phone = people.phone;
            Direccion = people.location.city + "," + people.location.country;
            email = people.email;


        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
