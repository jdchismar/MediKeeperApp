#pragma checksum "C:\Projects\MediKeeperApp\MediKeeperApp\Views\Item\Items.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d26d59587616dbee5878231370f4dc267f524d44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Items), @"mvc.1.0.view", @"/Views/Item/Items.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Item/Items.cshtml", typeof(AspNetCore.Views_Item_Items))]
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
#line 1 "C:\Projects\MediKeeperApp\MediKeeperApp\Views\_ViewImports.cshtml"
using MediKeeperApp;

#line default
#line hidden
#line 2 "C:\Projects\MediKeeperApp\MediKeeperApp\Views\_ViewImports.cshtml"
using MediKeeperApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d26d59587616dbee5878231370f4dc267f524d44", @"/Views/Item/Items.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38fbded2f6041bc45602be91263a2aa0adbcd92f", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Items : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manager.Models.ItemCollection>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projects\MediKeeperApp\MediKeeperApp\Views\Item\Items.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(67, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(96, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ee5e5e2344a46a9834ae4d9d5df89ea", async() => {
                BeginContext(102, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Items</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(196, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(198, 911, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74ec88133462421ea2c91bb95caaf1eb", async() => {
                BeginContext(204, 77, true);
                WriteLiteral("\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(282, 41, false);
#line 18 "C:\Projects\MediKeeperApp\MediKeeperApp\Views\Item\Items.cshtml"
           Write(Html.DisplayNameFor(m => m.ItemCol[0].ID));

#line default
#line hidden
                EndContext();
                BeginContext(323, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(379, 47, false);
#line 21 "C:\Projects\MediKeeperApp\MediKeeperApp\Views\Item\Items.cshtml"
           Write(Html.DisplayNameFor(m => m.ItemCol[0].ItemName));

#line default
#line hidden
                EndContext();
                BeginContext(426, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(482, 43, false);
#line 24 "C:\Projects\MediKeeperApp\MediKeeperApp\Views\Item\Items.cshtml"
           Write(Html.DisplayNameFor(m => m.ItemCol[0].Cost));

#line default
#line hidden
                EndContext();
                BeginContext(525, 36, true);
                WriteLiteral("\r\n            </th>\r\n        </tr>\r\n");
                EndContext();
#line 27 "C:\Projects\MediKeeperApp\MediKeeperApp\Views\Item\Items.cshtml"
         foreach (var item in Model.ItemCol)
        {

#line default
#line hidden
                BeginContext(618, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(667, 29, false);
#line 31 "C:\Projects\MediKeeperApp\MediKeeperApp\Views\Item\Items.cshtml"
           Write(Html.DisplayFor(m => item.ID));

#line default
#line hidden
                EndContext();
                BeginContext(696, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(752, 35, false);
#line 34 "C:\Projects\MediKeeperApp\MediKeeperApp\Views\Item\Items.cshtml"
           Write(Html.DisplayFor(m => item.ItemName));

#line default
#line hidden
                EndContext();
                BeginContext(787, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(843, 31, false);
#line 37 "C:\Projects\MediKeeperApp\MediKeeperApp\Views\Item\Items.cshtml"
           Write(Html.DisplayFor(m => item.Cost));

#line default
#line hidden
                EndContext();
                BeginContext(874, 36, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 40 "C:\Projects\MediKeeperApp\MediKeeperApp\Views\Item\Items.cshtml"
        }

#line default
#line hidden
                BeginContext(921, 110, true);
                WriteLiteral("    </table>\r\n    <br />\r\n    <div>\r\n        <input type=\"submit\" value=\"Back To home\" class=\"btn btn-default\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1031, "\"", 1084, 3);
                WriteAttributeValue("", 1041, "location.href=\'", 1041, 15, true);
#line 44 "C:\Projects\MediKeeperApp\MediKeeperApp\Views\Item\Items.cshtml"
WriteAttributeValue("", 1056, Url.Action("Index","Item"), 1056, 27, false);

#line default
#line hidden
                WriteAttributeValue("", 1083, "\'", 1083, 1, true);
                EndWriteAttribute();
                BeginContext(1085, 17, true);
                WriteLiteral(" />\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1109, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manager.Models.ItemCollection> Html { get; private set; }
    }
}
#pragma warning restore 1591
