#pragma checksum "C:\Users\Валерий\OneDrive\Рабочий стол\упп\Pastry\Pastry\Views\Shared\HeaderPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69c4ade5cffd4941b6c2b7c57d81e87f0fe7084d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_HeaderPartial), @"mvc.1.0.view", @"/Views/Shared/HeaderPartial.cshtml")]
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
#line 2 "C:\Users\Валерий\OneDrive\Рабочий стол\упп\Pastry\Pastry\Views\_ViewImports.cshtml"
using Pastry.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Валерий\OneDrive\Рабочий стол\упп\Pastry\Pastry\Views\_ViewImports.cshtml"
using Pastry.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Валерий\OneDrive\Рабочий стол\упп\Pastry\Pastry\Views\_ViewImports.cshtml"
using Pastry.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Валерий\OneDrive\Рабочий стол\упп\Pastry\Pastry\Views\_ViewImports.cshtml"
using Pastry.Models.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69c4ade5cffd4941b6c2b7c57d81e87f0fe7084d", @"/Views/Shared/HeaderPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2012d627112114e3bcf4a88e7dd663c885907947", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_HeaderPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div id=\"header\">\r\n\r\n    <!-- Inner -->\r\n\r\n    <div class=\"inner\">\r\n        <header>\r\n            <h1><a href=\"/\" id=\"logo\">");
#nullable restore
#line 7 "C:\Users\Валерий\OneDrive\Рабочий стол\упп\Pastry\Pastry\Views\Shared\HeaderPartial.cshtml"
                                 Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h1>\r\n        </header>\r\n    </div>\r\n\r\n");
            WriteLiteral("\r\n    <!-- Nav -->\r\n\r\n    <nav id=\"nav\">\r\n        <ul>\r\n");
            WriteLiteral(@"
            <li><a href=""/Home/Index"">Главная</a></li>
            <li><a href=""/Services/Index"">Наши услуги</a></li>
            <li><a href=""/Home/Contacts"">Контакты</a></li>
            <li><a href=""/Account/Login"">Вход</a></li>
            <li><a href=""#"">Регистрация</a></li>
");
            WriteLiteral("        </ul>\r\n    </nav>\r\n\r\n\r\n\r\n</div>");
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
