#pragma checksum "C:\Users\Stefan\Desktop\kurs\CV\MVC\Teams\TeamsApp\Views\Team\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f782c48b9cecb4467d1555d4e6feacd3ff51f16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_Search), @"mvc.1.0.view", @"/Views/Team/Search.cshtml")]
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
#line 1 "C:\Users\Stefan\Desktop\kurs\CV\MVC\Teams\TeamsApp\Views\_ViewImports.cshtml"
using TeamsApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Stefan\Desktop\kurs\CV\MVC\Teams\TeamsApp\Views\_ViewImports.cshtml"
using TeamsApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f782c48b9cecb4467d1555d4e6feacd3ff51f16", @"/Views/Team/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a2e562742896597956e4599dd707fddd09eb904", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FindTeamByNameViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>Search</h3>\r\n<br />\r\n");
#nullable restore
#line 4 "C:\Users\Stefan\Desktop\kurs\CV\MVC\Teams\TeamsApp\Views\Team\Search.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span class=\"input-group-addon\"></span>\r\n");
#nullable restore
#line 7 "C:\Users\Stefan\Desktop\kurs\CV\MVC\Teams\TeamsApp\Views\Team\Search.cshtml"
Write(Html.TextBox("model.Name", null, new { @class = "form-control", style = "width:200px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\" type=\"submit\">\r\n        Find\r\n    </button>\r\n");
#nullable restore
#line 12 "C:\Users\Stefan\Desktop\kurs\CV\MVC\Teams\TeamsApp\Views\Team\Search.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FindTeamByNameViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
