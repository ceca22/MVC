#pragma checksum "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Team\AddTeam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79d94c9c45207f4425c4c3c0687196349c0c6ff1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_AddTeam), @"mvc.1.0.view", @"/Views/Team/AddTeam.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79d94c9c45207f4425c4c3c0687196349c0c6ff1", @"/Views/Team/AddTeam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a2e562742896597956e4599dd707fddd09eb904", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_AddTeam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeamViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Team\AddTeam.cshtml"
   ViewBag.Title = "Add a Team"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div align=\"center\">\n    <h3>New Team</h3>\n</div>\n\n");
#nullable restore
#line 7 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Team\AddTeam.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"column\" align=\"center\">\n    <div class=\"col-md-6\">\n        <span class=\"input-group-addon\">");
#nullable restore
#line 11 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Team\AddTeam.cshtml"
                                   Write(Html.LabelFor(x => x.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        ");
#nullable restore
#line 12 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Team\AddTeam.cshtml"
   Write(Html.TextBox("model.Name", null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"col-md-6\">\n        <span class=\"input-group-addon\">");
#nullable restore
#line 15 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Team\AddTeam.cshtml"
                                   Write(Html.LabelFor(x => x.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        ");
#nullable restore
#line 16 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Team\AddTeam.cshtml"
   Write(Html.TextBox("model.City", null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"col-md-6\">\n        <span class=\"input-group-addon\">");
#nullable restore
#line 19 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Team\AddTeam.cshtml"
                                   Write(Html.LabelFor(x => x.Stadium));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        ");
#nullable restore
#line 20 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Team\AddTeam.cshtml"
   Write(Html.TextBox("model.Stadium", null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"col-md-6\">\n        <span class=\"input-group-addon\">");
#nullable restore
#line 23 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Team\AddTeam.cshtml"
                                   Write(Html.LabelFor(x => x.YearOfEstablishment));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        ");
#nullable restore
#line 24 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Team\AddTeam.cshtml"
   Write(Html.TextBox("model.YearOfEstablishment", null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"col-md-6\">\n        <span class=\"input-group-addon\">");
#nullable restore
#line 27 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Team\AddTeam.cshtml"
                                   Write(Html.LabelFor(x => x.History));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        ");
#nullable restore
#line 28 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Team\AddTeam.cshtml"
   Write(Html.TextArea("model.History", null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </div>\n\n</div>\n    <br />\n    <button class=\"btn btn-danger\" type=\"submit\">Create</button>\n");
#nullable restore
#line 35 "C:\Users\Stefan\Desktop\kurs\job assignment\Innovation\Teams\TeamsApp\Views\Team\AddTeam.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
