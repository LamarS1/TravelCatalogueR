#pragma checksum "C:\Users\Lamar\source\repos\TravelCatalogue\TravelCatalogue\Views\Shared\_ForsideLand.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08b4d93fdeacb81bfa6fa157d7e28ffb360ad189"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ForsideLand), @"mvc.1.0.view", @"/Views/Shared/_ForsideLand.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Lamar\source\repos\TravelCatalogue\TravelCatalogue\Views\_ViewImports.cshtml"
using TravelCatalogue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lamar\source\repos\TravelCatalogue\TravelCatalogue\Views\Shared\_ForsideLand.cshtml"
using TravelCatalogue.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08b4d93fdeacb81bfa6fa157d7e28ffb360ad189", @"/Views/Shared/_ForsideLand.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46280552ad78ab8cfb733ae9993bbb2449cbf373", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ForsideLand : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelCatalogue.Models.BoxTips>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <div class=\"leftbox\">\r\n        <h2></h2>\r\n        <p></p>\r\n        <div class=\"infoboxes\">\r\n            <div class=\"infobox\">");
#nullable restore
#line 9 "C:\Users\Lamar\source\repos\TravelCatalogue\TravelCatalogue\Views\Shared\_ForsideLand.cshtml"
                            Write(Model.Culture);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"infobox\">");
#nullable restore
#line 10 "C:\Users\Lamar\source\repos\TravelCatalogue\TravelCatalogue\Views\Shared\_ForsideLand.cshtml"
                            Write(Model.Food);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"infobox\">");
#nullable restore
#line 11 "C:\Users\Lamar\source\repos\TravelCatalogue\TravelCatalogue\Views\Shared\_ForsideLand.cshtml"
                            Write(Model.Transport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n    <div class=\"rightbox\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 403, "\"", 437, 2);
            WriteAttributeValue("", 409, "/Images/", 409, 8, true);
#nullable restore
#line 15 "C:\Users\Lamar\source\repos\TravelCatalogue\TravelCatalogue\Views\Shared\_ForsideLand.cshtml"
WriteAttributeValue("", 417, Model.ImageFileName, 417, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 438, "\"", 456, 1);
#nullable restore
#line 15 "C:\Users\Lamar\source\repos\TravelCatalogue\TravelCatalogue\Views\Shared\_ForsideLand.cshtml"
WriteAttributeValue("", 444, Model.Title, 444, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\" />\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelCatalogue.Models.BoxTips> Html { get; private set; }
    }
}
#pragma warning restore 1591
