#pragma checksum "C:\Users\Lucas\Desktop\lucas\CustomerSystem\CustomerSystem\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e44bc2e20782a2a92b87691a66dd08bf709744ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
#line 1 "C:\Users\Lucas\Desktop\lucas\CustomerSystem\CustomerSystem\Views\_ViewImports.cshtml"
using CustomerSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lucas\Desktop\lucas\CustomerSystem\CustomerSystem\Views\_ViewImports.cshtml"
using CustomerSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e44bc2e20782a2a92b87691a66dd08bf709744ee", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc667b4340e8bb5cbd8e0305965d17cf31b4e842", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerSystem.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lucas\Desktop\lucas\CustomerSystem\CustomerSystem\Views\Login\Index.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lucas\Desktop\lucas\CustomerSystem\CustomerSystem\Views\Login\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lucas\Desktop\lucas\CustomerSystem\CustomerSystem\Views\Login\Index.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        <div class=\"col-md-2\">\r\n            ");
#nullable restore
#line 9 "C:\Users\Lucas\Desktop\lucas\CustomerSystem\CustomerSystem\Views\Login\Index.cshtml"
       Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <font color=\"red\">*</font>\r\n        </div>\r\n        <div class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 12 "C:\Users\Lucas\Desktop\lucas\CustomerSystem\CustomerSystem\Views\Login\Index.cshtml"
       Write(Html.TextBoxFor(c => c.Email, new { @class = "form-control", @maxlength = 60 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 13 "C:\Users\Lucas\Desktop\lucas\CustomerSystem\CustomerSystem\Views\Login\Index.cshtml"
       Write(Html.ValidationMessageFor(c => c.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <br />\r\n    <div class=\"form-group\">\r\n        <div class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Lucas\Desktop\lucas\CustomerSystem\CustomerSystem\Views\Login\Index.cshtml"
       Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <font color=\"red\">*</font>\r\n        </div>\r\n        <div class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Lucas\Desktop\lucas\CustomerSystem\CustomerSystem\Views\Login\Index.cshtml"
       Write(Html.PasswordFor(c => c.Password, new { @class = "form-control", @maxlength = 15 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 24 "C:\Users\Lucas\Desktop\lucas\CustomerSystem\CustomerSystem\Views\Login\Index.cshtml"
       Write(Html.ValidationMessageFor(c => c.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-sm-2\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">Login</button>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Users\Lucas\Desktop\lucas\CustomerSystem\CustomerSystem\Views\Login\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerSystem.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
