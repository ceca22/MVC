#pragma checksum "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Shared\_TeamItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b016c7868df23e65bb19275db1274b16b38300d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TeamItem), @"mvc.1.0.view", @"/Views/Shared/_TeamItem.cshtml")]
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
#line 1 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\_ViewImports.cshtml"
using TeamsApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\_ViewImports.cshtml"
using TeamsApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b016c7868df23e65bb19275db1274b16b38300d1", @"/Views/Shared/_TeamItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a2e562742896597956e4599dd707fddd09eb904", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TeamItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Team ");
#nullable restore
#line 2 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Shared\_TeamItem.cshtml"
    Write(Model.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<br />\r\n<h6>Team Details</h6>\r\n<div class=\"column\">\r\n    <div >\r\n        <span class=\"input-group-addon\" style=\"font-weight:bold\">City: </span>\r\n        ");
#nullable restore
#line 8 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Shared\_TeamItem.cshtml"
   Write(Model.Team.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div >\r\n        <span class=\"input-group-addon\" style=\"font-weight:bold\">Stadium: </span>\r\n        ");
#nullable restore
#line 12 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Shared\_TeamItem.cshtml"
   Write(Model.Team.Stadium);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div >\r\n        <span class=\"input-group-addon \" style=\"font-weight:bold\">Year of Establishment: </span>\r\n        ");
#nullable restore
#line 16 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Shared\_TeamItem.cshtml"
   Write(Model.Team.YearOfEstablishment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div >\r\n        <span class=\"input-group-addon\" style=\"font-weight:bold\">History: </span>\r\n        ");
#nullable restore
#line 20 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Shared\_TeamItem.cshtml"
   Write(Model.Team.History);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591