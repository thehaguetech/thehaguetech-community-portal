#pragma checksum "C:\Users\furka\Documents\GitHub\thehaguetech-community-portal\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c808a894843c95188dc0539219c456961870be81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
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
#line 1 "C:\Users\furka\Documents\GitHub\thehaguetech-community-portal\Views\_ViewImports.cshtml"
using thehaguetech_community_portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\furka\Documents\GitHub\thehaguetech-community-portal\Views\_ViewImports.cshtml"
using thehaguetech_community_portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c808a894843c95188dc0539219c456961870be81", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"624213e097076258c8f51f4a0c24e1495cc877ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/sharedStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\furka\Documents\GitHub\thehaguetech-community-portal\Views\Home\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c808a894843c95188dc0539219c456961870be814320", async() => {
                WriteLiteral("\r\n    \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c808a894843c95188dc0539219c456961870be814590", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <style>

        .tab {
            overflow: hidden;
            border: 1px solid #ccc;
            background-color: #0F2247;
            border:green solid 1px;
        }

        .tab button {
            background-color: inherit;
            color: white;
            font-weight: bold;
            float: left;
            border: none;
            outline: none;
            cursor: pointer;
            padding: 14px 16px;
            transition: 0.3s;
            font-size: 17px;
        }

        .tab button:hover {
            background-color: #ddd;
            font-weight: bold;
        }

        .tab button.active {
            background-color: #ccc;
            font-weight: bold;
            color: #0F2247;
        }

        .tabcontent {
            display: none;
            padding: 6px 12px;
            border: 1px solid #ccc;
            border-top: none;
        }

        .chipLabel {
            border: none;
            color: white;");
                WriteLiteral(@"
            background-color: #5361BC;
            padding: auto;
            cursor: pointer;
            border: 2px solid #808080;
            -moz-border-radius: 16px;
            -webkit-border-radius: 16px;
            border-radius: 16px;
        }
        
        .chipLabel:hover {
            color: black;
            background-color: #fff;
            border: 2px solid #808080;
        }

        .profileContainer{
            border: 3px solid yellow;
        }

        .card {
            box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
            transition: 0.3s;
            width: 180px;
            height: 250px;
            border-radius: 5px;
        }

        .card:hover {
            box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
        }


        .nameCard {
            margin: 5px 5px;
            padding: 2px 16px;
        }

        .jobCard {
            margin:-12px 5px;
            padding: 2px 16px;
        }
        
        .companyLogo {
    ");
                WriteLiteral(@"        background-color: black;
            width: 150px;
            height: 150px;
            border-radius: 50%;
            margin: 10px;
            border:blue solid 5px;
        }

        .companyInfo{
            width: 150px;
            height: 150px;
            margin-right: 10px;
            border:red solid 1px;
            
        }

    </style>

");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c808a894843c95188dc0539219c456961870be818981", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-3 profileContainer"">
            <div class=""companyLogo"">
                <img src=""https://bordersessions.org/wp-content/uploads/2019/03/the-hague-tech-final.png"" alt=""Company Logo"" style=""padding: 15px;max-width: 100%;"">
            </div> <br>

            <div class=""col-6 companyInfo"">
                <h1>The Hague Tech</h1>
            </div>
            <div class=""col-3"">
                dadawd
            </div>
        </div>
    </div>


    <div class=""tab"">
        <button class=""tablinks"" onclick=""openTab(event, 'About')"">About</button>
        <button class=""tablinks"" onclick=""openTab(event, 'Activity')"">Activity</button>
        <button class=""tablinks"" onclick=""openTab(event, 'Connections')"">Connections</button>
    </div>

    <div id=""About"" class=""tabcontent"">
        <div class=""aboutCompany"">
            <br>
            <h3>About the Company</h3>
            <p>Lorem ipsum dolor amet brooklyn commodo laborum labo");
                WriteLiteral(@"ris air plant in chartreuse ut nulla normcore id non hashtag kombucha ipsum. Quis poutine farm-to-table literally, woke neutra gluten-free. Gastropub green juice jianbing ramps umami dolore. Slow-carb hammock deserunt pitchfork affogato eiusmod everyday carry wolf tempor mlkshk umami swag iPhone green juice.</p> 
        </div> <br><hr><br>
        <div class=""skills"">
            <h3>Skills and Expertises</h3> 
            <div class=""chips"">
                <button class=""chipLabel"">Chip Label</button>
            </div>
        </div> <br><hr><br>
        <div class=""teamMember"">
            <br>
            <h3>Team</h3> <br>
            <div class=""card"">
	            <img src=""https://byuc.files.wordpress.com/2012/07/avat-2.jpg"" alt=""Avatar"" style=""border-radius: 5px 5px 0 0;width:100%;height:74%;"">
	            <div class=""nameCard"">
	        	    <h6><b>Joe Smith</b></h6> 
                </div>
	            <div class=""jobCard"">
    	            <p>Interior Designer</p> 
  	        ");
                WriteLiteral(@"    </div>
            </div>
        </div> 
        
        <br><hr><br>
        
        <div class=""project"">
            <h3>Project</h3>
            
        </div>
    </div>

    <div id=""Activity"" class=""tabcontent"">
        <br>
        <h3>Activity inside the community</h3>
        <div>

        </div>
    </div>

    <div id=""Connections"" class=""tabcontent"">
        <h3>new profile activities </h3>
        <p>Lorem ipsum dolor amet brooklyn commodo laborum laboris air plant in chartreuse ut nulla normcore id non hashtag kombucha ipsum. Quis poutine farm-to-table literally, woke neutra gluten-free. Gastropub green juice jianbing ramps umami dolore. Slow-carb hammock deserunt pitchfork affogato eiusmod everyday carry wolf tempor mlkshk umami swag iPhone green juice.</p>
    </div>
    </div>
    <script>
        function openTab(evt, tabName) {
            var i, tabcontent, tablinks;
            tabcontent = document.getElementsByClassName(""tabcontent"");
            f");
                WriteLiteral(@"or (i = 0; i < tabcontent.length; i++) {
                tabcontent[i].style.display = ""none"";
            }
            tablinks = document.getElementsByClassName(""tablinks"");
            for (i = 0; i < tablinks.length; i++) {
                tablinks[i].className = tablinks[i].className.replace("" active"", """");
             }
            document.getElementById(tabName).style.display = ""block"";
            evt.currentTarget.className += "" active"";
        }
    </script>
   
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
