#pragma checksum "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2024b69608be333b2dbf7e75ee8bea9e269a69e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receta_Create), @"mvc.1.0.view", @"/Views/Receta/Create.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2024b69608be333b2dbf7e75ee8bea9e269a69e7", @"/Views/Receta/Create.cshtml")]
    public class Views_Receta_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaWebMisRecetas.Models.Receta>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
  
    ViewData["Title"] = $"{Model.Titulo}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("SideBar", async() => {
                WriteLiteral("\r\n    <div>\r\n        ");
#nullable restore
#line 10 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
   Write(Html.ActionLink("Armar una receta", "Create", "Receta"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 11 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
   Write(Html.ActionLink("Volver al inicio", "Index", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
   Write(Html.ActionLink("Volver al inicio", "Index", "Receta"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            WriteLiteral("    <div>\r\n    <h1>\r\n        ");
#nullable restore
#line 17 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
   Write(Html.DisplayFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n\r\n    <p>\r\n\r\n        ");
#nullable restore
#line 22 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
   Write(Html.DisplayNameFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n        ");
#nullable restore
#line 23 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
   Write(Html.DisplayFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </p>\r\n    <p>\r\n\r\n        ");
#nullable restore
#line 28 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
   Write(Html.DisplayNameFor(model => model.Ingredientes));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n        ");
#nullable restore
#line 29 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
   Write(Html.DisplayFor(model => model.Ingredientes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </p>\r\n    <p>\r\n\r\n        ");
#nullable restore
#line 34 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
   Write(Html.DisplayNameFor(model => model.Instrucciones));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n        ");
#nullable restore
#line 35 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
   Write(Html.DisplayFor(model => model.Instrucciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </p>\r\n    <p>\r\n\r\n        ");
#nullable restore
#line 40 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
   Write(Html.DisplayNameFor(model => model.NombreAutor));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n        ");
#nullable restore
#line 41 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
   Write(Html.DisplayFor(model => model.NombreAutor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </p>\r\n    <p>\r\n\r\n        ");
#nullable restore
#line 46 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
   Write(Html.DisplayNameFor(model => model.ApellidoAutor));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n        ");
#nullable restore
#line 47 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
   Write(Html.DisplayFor(model => model.ApellidoAutor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </p>\r\n    <p>\r\n\r\n        ");
#nullable restore
#line 52 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
   Write(Html.DisplayNameFor(model => model.EdadAutor));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n        ");
#nullable restore
#line 53 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
   Write(Html.DisplayFor(model => model.EdadAutor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </p>\r\n    <p>\r\n\r\n        ");
#nullable restore
#line 58 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
   Write(Html.DisplayNameFor(model => model.EmailAutor));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n        ");
#nullable restore
#line 59 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
   Write(Html.DisplayFor(model => model.EmailAutor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </p>\r\n\r\n\r\n    ");
#nullable restore
#line 64 "C:\Users\t.centurion\Desktop\slnCenturionTomas\slnCenturionTomas\Views\Receta\Create.cshtml"
Write(Html.ActionLink("Volver a la lista de recetas", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n}\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaWebMisRecetas.Models.Receta> Html { get; private set; }
    }
}
#pragma warning restore 1591
