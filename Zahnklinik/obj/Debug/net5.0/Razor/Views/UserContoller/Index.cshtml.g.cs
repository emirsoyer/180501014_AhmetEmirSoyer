#pragma checksum "C:\Users\PC\source\repos\Zahnklinik\Zahnklinik\Views\UserContoller\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d739df3f9ad07c28ce5830ceb6ee89489fda59a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserContoller_Index), @"mvc.1.0.view", @"/Views/UserContoller/Index.cshtml")]
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
#line 1 "C:\Users\PC\source\repos\Zahnklinik\Zahnklinik\Views\_ViewImports.cshtml"
using Zahnklinik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\source\repos\Zahnklinik\Zahnklinik\Views\_ViewImports.cshtml"
using Zahnklinik.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\PC\source\repos\Zahnklinik\Zahnklinik\Views\UserContoller\Index.cshtml"
using Entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d739df3f9ad07c28ce5830ceb6ee89489fda59a", @"/Views/UserContoller/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"241f77ad5b80cb95b5e9a060a9c82e1bddb7a758", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_UserContoller_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\PC\source\repos\Zahnklinik\Zahnklinik\Views\UserContoller\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""/lib/bootstrap/dist/css/bootstrap.css"" rel=""stylesheet"" />
<table class=""table table-light"">
    <tr>
        <th>Identifikationsnummer</th>
        <th>Vorname</th>
        <th>Geschlecht</th>
        <th>E-Mail</th>
        <th>Titel</th>
        <th>Aktualisieren</th>
        <th>Löschen</th>
    </tr>
");
#nullable restore
#line 17 "C:\Users\PC\source\repos\Zahnklinik\Zahnklinik\Views\UserContoller\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\PC\source\repos\Zahnklinik\Zahnklinik\Views\UserContoller\Index.cshtml"
           Write(item.TCNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\PC\source\repos\Zahnklinik\Zahnklinik\Views\UserContoller\Index.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\PC\source\repos\Zahnklinik\Zahnklinik\Views\UserContoller\Index.cshtml"
           Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\PC\source\repos\Zahnklinik\Zahnklinik\Views\UserContoller\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\PC\source\repos\Zahnklinik\Zahnklinik\Views\UserContoller\Index.cshtml"
           Write(item.UserType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-warning\">Aktualisieren</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-danger\">Löschen</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\PC\source\repos\Zahnklinik\Zahnklinik\Views\UserContoller\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591