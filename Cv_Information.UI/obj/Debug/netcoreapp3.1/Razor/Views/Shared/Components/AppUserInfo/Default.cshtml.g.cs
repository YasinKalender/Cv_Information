#pragma checksum "C:\Users\ysnbj\Desktop\Cv_Information\Cv_Information.UI\Views\Shared\Components\AppUserInfo\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36875919e4025ab2d64dc9175a4c4dd19d0b966a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AppUserInfo_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AppUserInfo/Default.cshtml")]
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
#line 2 "C:\Users\ysnbj\Desktop\Cv_Information\Cv_Information.UI\Views\_ViewImports.cshtml"
using Cv_Information.DTOs.Dto.AboutDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ysnbj\Desktop\Cv_Information\Cv_Information.UI\Views\_ViewImports.cshtml"
using Cv_Information.Entities.ORM.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ysnbj\Desktop\Cv_Information\Cv_Information.UI\Views\_ViewImports.cshtml"
using Cv_Information.DTOs.Dto.ExperienceDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ysnbj\Desktop\Cv_Information\Cv_Information.UI\Views\_ViewImports.cshtml"
using Cv_Information.DTOs.Dto.EducationDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ysnbj\Desktop\Cv_Information\Cv_Information.UI\Views\_ViewImports.cshtml"
using Cv_Information.DTOs.Dto.AppUserDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36875919e4025ab2d64dc9175a4c4dd19d0b966a", @"/Views/Shared/Components/AppUserInfo/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf07c79229b79aa38b53dea8533d956ba0de3cf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AppUserInfo_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cv_Information.Entities.ORM.Concrete.AppUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>");
#nullable restore
#line 7 "C:\Users\ysnbj\Desktop\Cv_Information\Cv_Information.UI\Views\Shared\Components\AppUserInfo\Default.cshtml"
Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\ysnbj\Desktop\Cv_Information\Cv_Information.UI\Views\Shared\Components\AppUserInfo\Default.cshtml"
                Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<p class=\"lead\">");
#nullable restore
#line 8 "C:\Users\ysnbj\Desktop\Cv_Information\Cv_Information.UI\Views\Shared\Components\AppUserInfo\Default.cshtml"
           Write(Model.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "C:\Users\ysnbj\Desktop\Cv_Information\Cv_Information.UI\Views\Shared\Components\AppUserInfo\Default.cshtml"
                         Write(Model.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 8 "C:\Users\ysnbj\Desktop\Cv_Information\Cv_Information.UI\Views\Shared\Components\AppUserInfo\Default.cshtml"
                                          Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cv_Information.Entities.ORM.Concrete.AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
