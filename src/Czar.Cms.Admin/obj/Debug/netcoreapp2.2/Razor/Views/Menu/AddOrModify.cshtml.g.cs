#pragma checksum "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Menu\AddOrModify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49d6e26e80f0b993c073b6f632ff48b693ee7149"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_AddOrModify), @"mvc.1.0.view", @"/Views/Menu/AddOrModify.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Menu/AddOrModify.cshtml", typeof(AspNetCore.Views_Menu_AddOrModify))]
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
#line 1 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\_ViewImports.cshtml"
using Czar.Cms.Admin;

#line default
#line hidden
#line 2 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\_ViewImports.cshtml"
using Czar.Cms.Admin.Models;

#line default
#line hidden
#line 1 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Menu\AddOrModify.cshtml"
using Czar.Cms.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49d6e26e80f0b993c073b6f632ff48b693ee7149", @"/Views/Menu/AddOrModify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12ac5d09335c7f224d6c7cc7745c338d8f15159c", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_AddOrModify : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Menu>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form layui-form-pane"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:90%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Menu\AddOrModify.cshtml"
  
    ViewData["Title"] = "后台菜单管理";

#line default
#line hidden
            BeginContext(80, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(81, 3057, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49d6e26e80f0b993c073b6f632ff48b693ee71495607", async() => {
                BeginContext(141, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(147, 23, false);
#line 8 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Menu\AddOrModify.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(170, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(176, 17, false);
#line 9 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Menu\AddOrModify.cshtml"
Write(Html.Hidden("Id"));

#line default
#line hidden
                EndContext();
                BeginContext(193, 853, true);
                WriteLiteral(@"
    <div class=""layui-form-item layui-row layui-col-xs12"">
        <label class=""layui-form-label"">调用别名</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""Name"" class=""layui-input Name"" lay-verify=""required|userName"" placeholder=""只允许字母数字下划线"">
        </div>
    </div>
    <div class=""layui-form-item layui-row layui-col-xs12"">
        <label class=""layui-form-label"">显示名称</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""DisplayName"" class=""layui-input DisplayName"" lay-verify=""required"" placeholder=""请输入显示名称"">
        </div>
    </div>
    <div class=""layui-form-item layui-row layui-col-xs12"">
        <label class=""layui-form-label"">上级菜单</label>
        <div class=""layui-input-block"">
            <select name=""ParentId"" class=""ParentId"" lay-filter=""ParentId"">
                ");
                EndContext();
                BeginContext(1046, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49d6e26e80f0b993c073b6f632ff48b693ee71497555", async() => {
                    BeginContext(1064, 5, true);
                    WriteLiteral("无上级菜单");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1078, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 27 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Menu\AddOrModify.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
                BeginContext(1142, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1162, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49d6e26e80f0b993c073b6f632ff48b693ee71499323", async() => {
                    BeginContext(1188, 16, false);
#line 29 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Menu\AddOrModify.cshtml"
                                        Write(item.DisplayName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 29 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Menu\AddOrModify.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1213, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 30 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Menu\AddOrModify.cshtml"

                }

#line default
#line hidden
                BeginContext(1233, 1898, true);
                WriteLiteral(@"            </select>
        </div>
    </div>
    <div class=""layui-form-item layui-row layui-col-xs12"">
        <label class=""layui-form-label"">菜单图标</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""IconUrl"" class=""layui-input IconUrl"" placeholder=""请输入菜单图标"">
        </div>
    </div>
    <div class=""layui-form-item layui-row layui-col-xs12"">
        <label class=""layui-form-label"">链接地址</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""LinkUrl"" class=""layui-input LinkUrl"" placeholder=""请输入链接地址"">
        </div>

    </div>
    <div class=""layui-form-item layui-row layui-col-xs12"" pane>
        <label class=""layui-form-label"">系统默认</label>
        <div class=""layui-input-block IsSystem"">
            <input type=""radio"" name=""IsSystem"" value=""0"" title=""否"">
            <input type=""radio"" name=""IsSystem"" value=""1"" title=""是"" checked>
        </div>
    </div>
    <div class=""layui-form-item layui-row layui-col-xs12"" pane>
        <label class=""l");
                WriteLiteral(@"ayui-form-label"">是否显示</label>
        <div class=""layui-input-block IsDisplay"">
            <input type=""radio"" name=""IsDisplay"" value=""0"" title=""否"">
            <input type=""radio"" name=""IsDisplay"" value=""1"" title=""是"" checked>
        </div>
    </div>
    <div class=""layui-form-item layui-row layui-col-xs12"">
        <label class=""layui-form-label"">排序数字</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""Sort"" class=""layui-input Sort"" value=""99"" lay-verify=""required"" placeholder=""请输入排序数字"">
        </div>
    </div>

    <div class=""layui-form-item layui-row layui-col-xs12"">
        <div class=""layui-input-block"">
            <button class=""layui-btn layui-btn-sm"" lay-submit="""" lay-filter=""addMenu"">确定</button>
            <button type=""reset"" class=""layui-btn layui-btn-sm layui-btn-primary"">重置</button>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3138, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3156, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(3161, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49d6e26e80f0b993c073b6f632ff48b693ee714915016", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3224, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(3229, 110, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49d6e26e80f0b993c073b6f632ff48b693ee714916358", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3265, "~/js/menu/menuAdd.js?_=", 3265, 23, true);
#line 78 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Menu\AddOrModify.cshtml"
AddHtmlAttributeValue("", 3288, DateTime.Now.ToString("yyyyMMddHHmmss"), 3288, 40, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3339, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(3342, 3, true);
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Menu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
