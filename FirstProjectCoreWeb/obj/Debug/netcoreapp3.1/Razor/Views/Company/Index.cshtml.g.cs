#pragma checksum "C:\Users\Przemek\source\repos\FirstProjectCoreWeb\FirstProjectCoreWeb\Views\Company\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82ecfb01cf55030b5f56b58fb88b9bcb8f9a991f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Index), @"mvc.1.0.view", @"/Views/Company/Index.cshtml")]
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
#line 1 "C:\Users\Przemek\source\repos\FirstProjectCoreWeb\FirstProjectCoreWeb\Views\_ViewImports.cshtml"
using FirstProjectCoreWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Przemek\source\repos\FirstProjectCoreWeb\FirstProjectCoreWeb\Views\_ViewImports.cshtml"
using FirstProjectCoreWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82ecfb01cf55030b5f56b58fb88b9bcb8f9a991f", @"/Views/Company/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f541766f92a6ec5f3e2c4d69dd18cb87f0aa7fd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Company managment</h1>\r\n\r\n<h2>Add new company</h2>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Przemek\source\repos\FirstProjectCoreWeb\FirstProjectCoreWeb\Views\Company\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 11 "C:\Users\Przemek\source\repos\FirstProjectCoreWeb\FirstProjectCoreWeb\Views\Company\Index.cshtml"
   Write(Html.LabelFor(x => x.Name, "Company Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\Przemek\source\repos\FirstProjectCoreWeb\FirstProjectCoreWeb\Views\Company\Index.cshtml"
   Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 16 "C:\Users\Przemek\source\repos\FirstProjectCoreWeb\FirstProjectCoreWeb\Views\Company\Index.cshtml"
   Write(Html.LabelFor(x => x.Description, "Company Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\Przemek\source\repos\FirstProjectCoreWeb\FirstProjectCoreWeb\Views\Company\Index.cshtml"
   Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 21 "C:\Users\Przemek\source\repos\FirstProjectCoreWeb\FirstProjectCoreWeb\Views\Company\Index.cshtml"
   Write(Html.CheckBoxFor(x => x.IsVisible, "Company Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 22 "C:\Users\Przemek\source\repos\FirstProjectCoreWeb\FirstProjectCoreWeb\Views\Company\Index.cshtml"
   Write(Html.LabelFor(x => x.IsVisible, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <button type=\"submit\" class=\"btn btn-primary\">Add Company</button>\r\n    </div>\r\n");
#nullable restore
#line 28 "C:\Users\Przemek\source\repos\FirstProjectCoreWeb\FirstProjectCoreWeb\Views\Company\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
