#pragma checksum "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1327bf3ff03c5fa12b56fe113426aaa0c66d2af5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
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
#line 1 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\_ViewImports.cshtml"
using HeatBalanceCalculation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\_ViewImports.cshtml"
using HeatBalanceCalculation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1327bf3ff03c5fa12b56fe113426aaa0c66d2af5", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5afa3e724f0e293ef75188246f4db96d649f5431", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/GrafHBC"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\"><b>Результат расчета</b></h1>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1327bf3ff03c5fa12b56fe113426aaa0c66d2af54334", async() => {
                WriteLiteral(@"
            <table bgcolor=""FFE57A"" border=""1"" align=""center"">
                <tr>
                    <td bgcolor=""#5FFDE8""><h4>Статься прихода тепла</h4></td>
                    <td bgcolor=""#5FFDE8""><nobr><h4>кДж/кг</h4></nobr></td>
                    <td bgcolor=""#5FFDE8""><h4>%</h4></td>
                    <td bgcolor=""#5FFDE8""><h4>Статься расхода тепла</h4></td>
                    <td bgcolor=""#5FFDE8""><nobr><h4>кДж/кг</h4></nobr></td>
                    <td bgcolor=""#5FFDE8""><h4>%</h4></td>
                </tr>
                <tr>
                    <td>Количество тепла, получающегося при горении углерода кокса</td>
                    <td bgcolor=""FFDBF2"">");
#nullable restore
#line 20 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                                    Write(ClassLibrary.GetQ_Cocs);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                   Write(ClassLibrary.GetQ_Cocs_Pers);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>Расход тепла на прямое восстановление оксидов железа</td>\r\n                    <td bgcolor=\"FFDBF2\">");
#nullable restore
#line 23 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                                    Write(ClassLibrary.GetQ_pr);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                   Write(ClassLibrary.GetQ_pr_Pers);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Приход тепла с нагретым дутьем</td>\r\n                    <td bgcolor=\"FFDBF2\">");
#nullable restore
#line 28 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                                    Write(ClassLibrary.GetQ_N_D);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                   Write(ClassLibrary.GetQ_N_D_Pers);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>Расход тепла на прямое восстановление примесей чугуна</td>\r\n                    <td bgcolor=\"FFDBF2\">");
#nullable restore
#line 31 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                                    Write(ClassLibrary.GetQ_PR);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                   Write(ClassLibrary.GetQ_PR_Pers);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Количество тепла, выделяющегося при конверсии природного газа</td>\r\n                    <td bgcolor=\"FFDBF2\">");
#nullable restore
#line 36 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                                    Write(ClassLibrary.GetQ_pg);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                   Write(ClassLibrary.GetQ_pg_Pers);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>Затраты тепла на процесс десульфурации чугуна</td>\r\n                    <td bgcolor=\"FFDBF2\">");
#nullable restore
#line 39 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                                    Write(ClassLibrary.GetQS);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                   Write(ClassLibrary.GetQS_Pers);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Количество тепла, выделяющегося при процессе шлакообразования</td>\r\n                    <td bgcolor=\"FFDBF2\">");
#nullable restore
#line 44 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                                    Write(ClassLibrary.GetQ_G_i);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                   Write(ClassLibrary.GetQ_G_i_Pers);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>Затраты тепла на компенсацию отр. тепл. эффекта восстанов. оксидов железа водородом</td>\r\n                    <td bgcolor=\"FFDBF2\">");
#nullable restore
#line 47 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                                    Write(ClassLibrary.GetQ_v_H2);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                   Write(ClassLibrary.GetQ_v_H2_Pers);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Физическое тепло шихты</td>\r\n                    <td bgcolor=\"FFDBF2\">");
#nullable restore
#line 52 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                                    Write(ClassLibrary.GetQ_jrm);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 53 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                   Write(ClassLibrary.GetQ_jrm_Pers);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>Количество тепла, уносимого из печи жидким чугуном</td>\r\n                    <td bgcolor=\"FFDBF2\">");
#nullable restore
#line 55 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                                    Write(ClassLibrary.GetQ_H);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 56 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                   Write(ClassLibrary.GetQ_H_Pers);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td>Количество тепла, уносимого из печи жидким шлаком</td>
                    <td bgcolor=""FFDBF2"">");
#nullable restore
#line 63 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                                    Write(ClassLibrary.GetQ_hl);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 64 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                   Write(ClassLibrary.GetQ_hl_Pers);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td></td>\r\n                    <td></td>\r\n                    <td></td>\r\n                    <td>Расход тепла на разложение влаги дутья</td>\r\n                    <td bgcolor=\"FFDBF2\">");
#nullable restore
#line 71 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                                    Write(ClassLibrary.GetQ_vl);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 72 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                   Write(ClassLibrary.GetQ_vl_Pers);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td></td>\r\n                    <td></td>\r\n                    <td></td>\r\n                    <td>Расход тепла на разложение известняка</td>\r\n                    <td bgcolor=\"FFDBF2\">");
#nullable restore
#line 79 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                                    Write(ClassLibrary.GetQ_I);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 80 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                   Write(ClassLibrary.GetQ_G_i_Pers);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td></td>\r\n                    <td></td>\r\n                    <td></td>\r\n                    <td>Расход тепла на испарение влаги шихты</td>\r\n                    <td bgcolor=\"FFDBF2\">");
#nullable restore
#line 87 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                                    Write(ClassLibrary.GetQ_vp_H);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 88 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                   Write(ClassLibrary.GetQ_vp_H_Pers);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td>Количество тепла, уносимого из печи колошниковым газом</td>
                    <td bgcolor=""FFDBF2"">");
#nullable restore
#line 95 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                                    Write(ClassLibrary.GetQ_KG);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 96 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                   Write(ClassLibrary.GetQ_KG_Pers);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td></td>\r\n                    <td></td>\r\n                    <td></td>\r\n                    <td>Тепловые потери печи</td>\r\n                    <td bgcolor=\"FFDBF2\">");
#nullable restore
#line 103 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                                    Write(ClassLibrary.GetQ_Poter);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 104 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                   Write(ClassLibrary.GetQ_Poter_Pers);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Суммарный приход тепла</td>\r\n                    <td bgcolor=\"FFDBF2\">");
#nullable restore
#line 108 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                                    Write(ClassLibrary.GetQ_SumPrihod);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 109 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                   Write(ClassLibrary.GetQ_SumPrihod_Pers);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>Суммарный расход тепла</td>\r\n                    <td bgcolor=\"FFDBF2\">");
#nullable restore
#line 111 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                                    Write(ClassLibrary.GetQ_SumRachod);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 112 "C:\Users\ivanescko\Desktop\HeatBalanceCalculation\Project V 1.1\WebApplication1\Views\Home\Result.cshtml"
                   Write(ClassLibrary.GetQ_SumRachod_Pers);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                </tr>
            </table>

            <div style=""text-align: right;
            margin-left: 30%;
            width: 40%;
            padding:1%"">

                <button type=""submit"" class=""btn btn-primary btn-lg btn-block"" target=""_blank"">Построить диаграммы</button>

            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>");
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
