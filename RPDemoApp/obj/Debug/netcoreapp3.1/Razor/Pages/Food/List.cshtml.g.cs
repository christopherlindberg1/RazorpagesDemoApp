#pragma checksum "C:\Users\Christopher\OneDrive\Utveckling\udemy\which-asp-core\WhichAspNetCore\CompleteApps\RPDemo\RPDemoApp\Pages\Food\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd48fa06f1b2d81bfec2f7e710da27cf3201a4d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RPDemoApp.Pages.Food.Pages_Food_List), @"mvc.1.0.razor-page", @"/Pages/Food/List.cshtml")]
namespace RPDemoApp.Pages.Food
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
#line 1 "C:\Users\Christopher\OneDrive\Utveckling\udemy\which-asp-core\WhichAspNetCore\CompleteApps\RPDemo\RPDemoApp\Pages\_ViewImports.cshtml"
using RPDemoApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd48fa06f1b2d81bfec2f7e710da27cf3201a4d9", @"/Pages/Food/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d6da786e6850f6567fa7cf4da72be5e1d75e1de", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Food_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Christopher\OneDrive\Utveckling\udemy\which-asp-core\WhichAspNetCore\CompleteApps\RPDemo\RPDemoApp\Pages\Food\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List</h1>\r\n\r\n<table class=\"table table-striped\">\r\n    <thead class=\"thead-light\">\r\n        <tr>\r\n            <th>Title</th>\r\n            <th>Description</th>\r\n            <th>Price</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 18 "C:\Users\Christopher\OneDrive\Utveckling\udemy\which-asp-core\WhichAspNetCore\CompleteApps\RPDemo\RPDemoApp\Pages\Food\List.cshtml"
         foreach (var food in Model.Food)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Christopher\OneDrive\Utveckling\udemy\which-asp-core\WhichAspNetCore\CompleteApps\RPDemo\RPDemoApp\Pages\Food\List.cshtml"
           Write(food.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Christopher\OneDrive\Utveckling\udemy\which-asp-core\WhichAspNetCore\CompleteApps\RPDemo\RPDemoApp\Pages\Food\List.cshtml"
           Write(food.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Christopher\OneDrive\Utveckling\udemy\which-asp-core\WhichAspNetCore\CompleteApps\RPDemo\RPDemoApp\Pages\Food\List.cshtml"
           Write(String.Format("{0:C}", food.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Christopher\OneDrive\Utveckling\udemy\which-asp-core\WhichAspNetCore\CompleteApps\RPDemo\RPDemoApp\Pages\Food\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RPDemoApp.Pages.Food.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RPDemoApp.Pages.Food.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RPDemoApp.Pages.Food.ListModel>)PageContext?.ViewData;
        public RPDemoApp.Pages.Food.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
