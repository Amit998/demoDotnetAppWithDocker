#pragma checksum "D:\nagarro\devOps\YML_DevOps\Terraform_Ang_Dotnet\Temperature\Temperature\Views\Home\TemperatureCalculator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fa9e81ed6d02662e72279a20c276fd7bfb9a42c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TemperatureCalculator), @"mvc.1.0.view", @"/Views/Home/TemperatureCalculator.cshtml")]
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
#line 1 "D:\nagarro\devOps\YML_DevOps\Terraform_Ang_Dotnet\Temperature\Temperature\Views\_ViewImports.cshtml"
using Temperature;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\nagarro\devOps\YML_DevOps\Terraform_Ang_Dotnet\Temperature\Temperature\Views\_ViewImports.cshtml"
using Temperature.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fa9e81ed6d02662e72279a20c276fd7bfb9a42c", @"/Views/Home/TemperatureCalculator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cd911c8e743aeaef4454e9e92f8e6b72d23ed2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TemperatureCalculator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Temperature.Models.TemperatureModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\nagarro\devOps\YML_DevOps\Terraform_Ang_Dotnet\Temperature\Temperature\Views\Home\TemperatureCalculator.cshtml"
  
    ViewData["Title"] = "TemperatureCalculator";
    var result = ViewBag.result;
    var type = ViewBag.type;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Temperature Calculator</h1>\r\n\r\n<hr />\r\n\r\n         \r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-8\">\r\n\r\n");
#nullable restore
#line 19 "D:\nagarro\devOps\YML_DevOps\Terraform_Ang_Dotnet\Temperature\Temperature\Views\Home\TemperatureCalculator.cshtml"
             using (Html.BeginForm("calculate", "Home", FormMethod.Post))
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fa9e81ed6d02662e72279a20c276fd7bfb9a42c4568", async() => {
                WriteLiteral("\r\n                    <div class=\"mb-3\">\r\n                        <label for=\"degree\" class=\"form-label\">Celsius </label>\r\n                        ");
#nullable restore
#line 25 "D:\nagarro\devOps\YML_DevOps\Terraform_Ang_Dotnet\Temperature\Temperature\Views\Home\TemperatureCalculator.cshtml"
                   Write(Html.EditorFor(model => model.celsius, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                    </div>\r\n                    <div class=\"mb-3\">\r\n                        <label for=\"fahrenheit\" class=\"form-label\">Fahrenheit </label>\r\n                        ");
#nullable restore
#line 31 "D:\nagarro\devOps\YML_DevOps\Terraform_Ang_Dotnet\Temperature\Temperature\Views\Home\TemperatureCalculator.cshtml"
                   Write(Html.EditorFor(model => model.fahrenheit, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    </div>\r\n\r\n                    <button type=\"submit\" class=\"btn btn-primary\" value=\"calculate\">Calculate</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 37 "D:\nagarro\devOps\YML_DevOps\Terraform_Ang_Dotnet\Temperature\Temperature\Views\Home\TemperatureCalculator.cshtml"


            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 44 "D:\nagarro\devOps\YML_DevOps\Terraform_Ang_Dotnet\Temperature\Temperature\Views\Home\TemperatureCalculator.cshtml"
     if (TempData["success"] != null)
    {
        

        if (TempData["success"].Equals(true))
        {
               

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h1>");
#nullable restore
#line 51 "D:\nagarro\devOps\YML_DevOps\Terraform_Ang_Dotnet\Temperature\Temperature\Views\Home\TemperatureCalculator.cshtml"
               Write(type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is ");
#nullable restore
#line 51 "D:\nagarro\devOps\YML_DevOps\Terraform_Ang_Dotnet\Temperature\Temperature\Views\Home\TemperatureCalculator.cshtml"
                        Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 52 "D:\nagarro\devOps\YML_DevOps\Terraform_Ang_Dotnet\Temperature\Temperature\Views\Home\TemperatureCalculator.cshtml"
           
        }
        else
        {

        }


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Temperature.Models.TemperatureModel> Html { get; private set; }
    }
}
#pragma warning restore 1591