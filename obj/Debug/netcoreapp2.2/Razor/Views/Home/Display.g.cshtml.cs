#pragma checksum "C:\Users\Ryan\CSharpStack\FormSubmission\Views\Home\Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0b91499b744a24008da39b911160f02eb3bdc4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Display), @"mvc.1.0.view", @"/Views/Home/Display.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Display.cshtml", typeof(AspNetCore.Views_Home_Display))]
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
#line 1 "C:\Users\Ryan\CSharpStack\FormSubmission\Views\_ViewImports.cshtml"
using FormSubmission;

#line default
#line hidden
#line 2 "C:\Users\Ryan\CSharpStack\FormSubmission\Views\_ViewImports.cshtml"
using FormSubmission.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0b91499b744a24008da39b911160f02eb3bdc4a", @"/Views/Home/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eee8ebcfc15afbef5ef7fe8ba1aeeb298d01b049", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ryan\CSharpStack\FormSubmission\Views\Home\Display.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(58, 71, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Congratulations ");
            EndContext();
            BeginContext(130, 15, false);
#line 7 "C:\Users\Ryan\CSharpStack\FormSubmission\Views\Home\Display.cshtml"
                                     Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(145, 34, true);
            WriteLiteral("! You submitted it!</h1>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
