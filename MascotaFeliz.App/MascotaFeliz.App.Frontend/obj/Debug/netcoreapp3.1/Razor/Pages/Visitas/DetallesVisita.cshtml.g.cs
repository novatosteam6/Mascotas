#pragma checksum "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Visitas\DetallesVisita.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94a49ff39a8b0839fca4f4b1f168e62d23e89fb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Visitas.Pages_Visitas_DetallesVisita), @"mvc.1.0.razor-page", @"/Pages/Visitas/DetallesVisita.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Visitas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94a49ff39a8b0839fca4f4b1f168e62d23e89fb4", @"/Pages/Visitas/DetallesVisita.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Visitas_DetallesVisita : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Visitas/ListaVisitas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Detallado De la visita</h1>\r\n\r\n<div>\r\n    Numero de Historia: ");
#nullable restore
#line 10 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Visitas\DetallesVisita.cshtml"
                   Write(Model.historia.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    id de la visita: ");
#nullable restore
#line 14 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Visitas\DetallesVisita.cshtml"
                Write(Model.visitaPyP.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    Fecha De Visita: ");
#nullable restore
#line 18 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Visitas\DetallesVisita.cshtml"
                Write(Model.visitaPyP.FechaVisita);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    Nombre mascota: ");
#nullable restore
#line 22 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Visitas\DetallesVisita.cshtml"
               Write(Model.mascota.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    Especie: ");
#nullable restore
#line 26 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Visitas\DetallesVisita.cshtml"
        Write(Model.mascota.Especie);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    Temperatura: ");
#nullable restore
#line 30 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Visitas\DetallesVisita.cshtml"
            Write(Model.visitaPyP.Temperatura);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    Peso: ");
#nullable restore
#line 34 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Visitas\DetallesVisita.cshtml"
     Write(Model.visitaPyP.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    Frecuencia Respiratoria: ");
#nullable restore
#line 38 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Visitas\DetallesVisita.cshtml"
                        Write(Model.visitaPyP.FrecuenciaRespiratoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    Frecuencia Cardiaca: ");
#nullable restore
#line 42 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Visitas\DetallesVisita.cshtml"
                    Write(Model.visitaPyP.FrecuenciaCardiaca);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    Estado de animo: ");
#nullable restore
#line 46 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Visitas\DetallesVisita.cshtml"
                Write(Model.visitaPyP.EstadoAnimo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    Recomendaciones: ");
#nullable restore
#line 50 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Visitas\DetallesVisita.cshtml"
                Write(Model.visitaPyP.Pecomendaciones);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<br>\r\n<br>\r\n<br>\r\n<div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94a49ff39a8b0839fca4f4b1f168e62d23e89fb47454", async() => {
                WriteLiteral("Volver A Lista Visitas");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-historiaId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Visitas\DetallesVisita.cshtml"
                                                          WriteLiteral(Model.historia.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["historiaId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-historiaId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["historiaId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Visitas\DetallesVisita.cshtml"
                                                                                                   WriteLiteral(Model.mascota.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mascotaId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mascotaId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mascotaId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.DetallesVisitaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetallesVisitaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetallesVisitaModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.DetallesVisitaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
