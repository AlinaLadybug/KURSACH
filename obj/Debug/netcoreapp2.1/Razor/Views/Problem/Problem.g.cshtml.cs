#pragma checksum "D:\KPI\БД\КУРСАЧ\Views\Problem\Problem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f67952f556bd74c1a07eb21d6a4fc728208b08c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Problem_Problem), @"mvc.1.0.view", @"/Views/Problem/Problem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Problem/Problem.cshtml", typeof(AspNetCore.Views_Problem_Problem))]
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
#line 1 "D:\KPI\БД\КУРСАЧ\Views\_ViewImports.cshtml"
using KR;

#line default
#line hidden
#line 2 "D:\KPI\БД\КУРСАЧ\Views\_ViewImports.cshtml"
using KR.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f67952f556bd74c1a07eb21d6a4fc728208b08c", @"/Views/Problem/Problem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"065d96277c0a028319d299de00fb15e28c1bffbb", @"/Views/_ViewImports.cshtml")]
    public class Views_Problem_Problem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KR.Models.Database.Problem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/wwwroot/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/api/problem/add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "put", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Problem/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\KPI\БД\КУРСАЧ\Views\Problem\Problem.cshtml"
    
  ViewData["Title"] = "Тестування ПЗ";
  

#line default
#line hidden
            BeginContext(101, 23, true);
            WriteLiteral("  <!DOCTYPE html>\r\n\r\n  ");
            EndContext();
            BeginContext(124, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f1bbb5ada6e4e2086297cd73d673b24", async() => {
                BeginContext(130, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(136, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09b8f620ab654fceb5f9a1b389a42628", async() => {
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
                EndContext();
                BeginContext(200, 4, true);
                WriteLiteral("\r\n  ");
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
            BeginContext(211, 6, true);
            WriteLiteral("\r\n\r\n  ");
            EndContext();
            BeginContext(217, 4256, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f49be0ccbccf47dda57440e4b645306a", async() => {
                BeginContext(223, 907, true);
                WriteLiteral(@"

    <h2>Проблеми</h2>



    <p>
      <!-- Button trigger modal -->
      <button type=""button"" class=""btn  btn-danger"" data-toggle=""modal"" data-target=""#addProblemModal"">
        Додати проблему
      </button>

      <!-- Modals -->
      <div class=""modal fade"" id=""addProblemModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addProblemModalTitle""
        aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
          <div class=""modal-content"">
            <div class=""modal-header"">
              <h5 class=""modal-title"" id=""exampleModalLongTitle"">Додати проблему
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                  <span aria-hidden=""true"">&times;</span>
                </button>
              </h5>
            </div>
            <div class=""modal-body"">
              ");
                EndContext();
                BeginContext(1130, 593, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec1d0ae0d4494085a934c1a77adfbe5f", async() => {
                    BeginContext(1177, 539, true);
                    WriteLiteral(@"
                <div class=""form-group"">
                  <label for=""exampleInputEmail1"">Введіть назву проблеми</label>
                  <input type=""text"" class=""form-control"" name=""Title"">
                </div>
                <div class=""form-group"">
                  <label for=""exampleInputEmail1"">Введіть статус проблеми</label>
                  <input type=""text"" class=""form-control"" name=""Status"">
                </div>
                <button type=""submit"" class=""btn btn-primary"">Додати</button>
              ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1723, 728, true);
                WriteLiteral(@"
            </div>

          </div>
        </div>
      </div>


      <div class=""modal fade"" id=""editProblem"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addProblemModalTitle""
        aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
          <div class=""modal-content"">
            <div class=""modal-header"">
              <h5 class=""modal-title"" id=""exampleModalLongTitle"">Додати проблему
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                  <span aria-hidden=""true"">&times;</span>
                </button>
              </h5>
            </div>
            <div class=""modal-body"">
              ");
                EndContext();
                BeginContext(2451, 602, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06fd52198a2d49bd82203ee089f8defd", async() => {
                    BeginContext(2494, 552, true);
                    WriteLiteral(@"
                <div class=""form-group"">
                  <label for=""exampleInputEmail1"">Введіть нову назву проблеми</label>
                  <input type=""text"" class=""form-control"" name=""Title"">
                </div>
                <div class=""form-group"">
                  <label for=""exampleInputEmail1"">Введіть новий статус проблеми</label>
                  <input type=""text"" class=""form-control"" name=""Status"">
                </div>
                <button type=""submit"" class=""btn btn-primary"">Зберегти</button>
              ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3053, 306, true);
                WriteLiteral(@"
            </div>

          </div>
        </div>
      </div>
    </p>
    <table id=""problems"" class=""table table-bordered table-hover"">
      <thead>
        <tr>
          <th>Назва</th>
          <th>Дата створення</th>
          <th>Статус</th>
          <th>Дія</th>
        </tr>
");
                EndContext();
#line 92 "D:\KPI\БД\КУРСАЧ\Views\Problem\Problem.cshtml"
         foreach ( var problem in Model)
        {

#line default
#line hidden
                BeginContext(3412, 30, true);
                WriteLiteral("        <tr>\r\n          <td>\r\n");
                EndContext();
#line 96 "D:\KPI\БД\КУРСАЧ\Views\Problem\Problem.cshtml"
              var link = "info/"+problem.Id;

#line default
#line hidden
                BeginContext(3489, 14, true);
                WriteLiteral("            <a");
                EndContext();
                BeginWriteAttribute("href", " href=", 3503, "", 3514, 1);
#line 97 "D:\KPI\БД\КУРСАЧ\Views\Problem\Problem.cshtml"
WriteAttributeValue("", 3509, link, 3509, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3514, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(3516, 13, false);
#line 97 "D:\KPI\БД\КУРСАЧ\Views\Problem\Problem.cshtml"
                     Write(problem.Title);

#line default
#line hidden
                EndContext();
                BeginContext(3529, 51, true);
                WriteLiteral("</a>\r\n          </td>\r\n          <td>\r\n            ");
                EndContext();
                BeginContext(3581, 20, false);
#line 100 "D:\KPI\БД\КУРСАЧ\Views\Problem\Problem.cshtml"
       Write(problem.CreationDate);

#line default
#line hidden
                EndContext();
                BeginContext(3601, 47, true);
                WriteLiteral("\r\n          </td>\r\n          <td>\r\n            ");
                EndContext();
                BeginContext(3649, 14, false);
#line 103 "D:\KPI\БД\КУРСАЧ\Views\Problem\Problem.cshtml"
       Write(problem.Status);

#line default
#line hidden
                EndContext();
                BeginContext(3663, 253, true);
                WriteLiteral("\r\n          </td>\r\n          <td>\r\n            <button type=\"button\" class=\"btn btn-outline-info\" data-toggle=\"modal\" data-target=\"#editProblem\">\r\n              <span class=\"glyphicon glyphicon-pencil\" aria-hidden=\"true\"></span>\r\n            </button>\r\n");
                EndContext();
#line 109 "D:\KPI\БД\КУРСАЧ\Views\Problem\Problem.cshtml"
              var deleteLink = "delete/"+problem.Id;

#line default
#line hidden
                BeginContext(3971, 14, true);
                WriteLiteral("            <a");
                EndContext();
                BeginWriteAttribute("href", " href=", 3985, "", 4002, 1);
#line 110 "D:\KPI\БД\КУРСАЧ\Views\Problem\Problem.cshtml"
WriteAttributeValue("", 3991, deleteLink, 3991, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4002, 210, true);
                WriteLiteral("><button type=\"button\" class=\"btn  btn-danger\">\r\n                <span class=\"glyphicon glyphicon-trash\" aria-hidden=\"true\"></span>\r\n              </button>\r\n            </a>\r\n\r\n          </td>\r\n        </tr>\r\n");
                EndContext();
#line 117 "D:\KPI\БД\КУРСАЧ\Views\Problem\Problem.cshtml"
        }

#line default
#line hidden
                BeginContext(4223, 144, true);
                WriteLiteral("      </thead>\r\n      <tbody>\r\n      </tbody>\r\n    </table>\r\n    <nav aria-label=\"...\">\r\n      <ul class=\"pager\">\r\n        <li class=\"previous\">");
                EndContext();
                BeginContext(4367, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55d374bd8af3456c94e2ebbfc6add15f", async() => {
                    BeginContext(4384, 44, true);
                    WriteLiteral("<span aria-hidden=\"true\">&larr;</span> Назад");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4432, 34, true);
                WriteLiteral("</li>\r\n      </ul>\r\n    </nav>\r\n  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KR.Models.Database.Problem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
