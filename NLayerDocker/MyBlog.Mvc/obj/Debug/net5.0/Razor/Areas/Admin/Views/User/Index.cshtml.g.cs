#pragma checksum "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b91bd7f8a9cfe9cbcfab049bdc5bfb4cbcae2865"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
#line 2 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using MyBlog.Mvc.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using MyBlog.Mvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using MyBlog.Entities.Dtos.CategoryDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using MyBlog.Entities.Dtos.UserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using MyBlog.Entities.Dtos.ArticleDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using MyBlog.Entities.Dtos.CommentDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using MyBlog.Entities.Dtos.RoleDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using MyBlog.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using MyBlog.Entities.ComplexTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using MyBlog.Shared.Utilities.Results.ComplexTypes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b91bd7f8a9cfe9cbcfab049bdc5bfb4cbcae2865", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0104d68e65e0a6c2f70d7d86fa018f09668fab6b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserListDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-image-table"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE/js/userIndex.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("application/ecmascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
  

    ViewBag.Title = "Kullanıcılar";

#line default
#line hidden
#nullable disable
            WriteLiteral("<ol class=\"breadcrumb mb-3 mt-2\">\r\n    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b91bd7f8a9cfe9cbcfab049bdc5bfb4cbcae28658230", async() => {
                WriteLiteral("Admin");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n    <li class=\"breadcrumb-item active\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b91bd7f8a9cfe9cbcfab049bdc5bfb4cbcae28659836", async() => {
                WriteLiteral("Kullanıcılar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n</ol>\r\n");
#nullable restore
#line 10 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
 if (Model.ResultStatus == ResultStatus.Success)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""modelPlaceHolder"" aria-hidden=""true""></div>
    <div class=""card mb-4 mt-2"">
        <div class=""card-header"">
            <i class=""fas fa-table mr-1""></i>
            Kullanıcılar
        </div>
        <div class=""card-body"">
            <div class=""spinner-border"" role=""status"" style=""display: none;"">
                <span class=""sr-only"">Yükleniyor...</span>
            </div>
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""usersTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Kullanıcı Adı</th>
                            <th>E-Posta Adresi</th>
                            <th>Adı</th>
                            <th>Soyadı</th>
                            <th>Telefon Numarası</th>
                            <th>Hakkında</th>
                            <th>Resim</th>
                            <th>İşl");
            WriteLiteral(@"emler</th>
                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>ID</th>
                            <th>Kullanıcı Adı</th>
                            <th>E-Posta Adresi</th>
                            <th>Adı</th>
                            <th>Soyadı</th>
                            <th>Telefon Numarası</th>
                            <th>Hakkında</th>
                            <th>Resim</th>
                            <th>İşlemler</th>
                        </tr>
                    </tfoot>
                    <tbody>
");
#nullable restore
#line 51 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                         foreach (var user in Model.Users)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("name", " name=\"", 2183, "\"", 2198, 1);
#nullable restore
#line 53 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 2190, user.Id, 2190, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <td>");
#nullable restore
#line 54 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                               Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 55 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                               Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 56 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                               Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 57 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                               Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 58 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                               Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 59 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                               Write(user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 60 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                                Write(user.About.Length>75 ? user.About.Substring(0,75):user.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b91bd7f8a9cfe9cbcfab049bdc5bfb4cbcae286516516", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2691, "~/img/", 2691, 6, true);
#nullable restore
#line 61 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
AddHtmlAttributeValue("", 2697, user.Picture, 2697, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 61 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
AddHtmlAttributeValue("", 2717, user.UserName, 2717, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <button class=\"btn btn-info btn-sm btn-detail\" data-id=\"");
#nullable restore
#line 63 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                                                                                       Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fas fa-newspaper\"></span></button>\r\n                                    <button class=\"btn btn-warning btn-sm btn-assign\" data-id=\"");
#nullable restore
#line 64 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                                                                                          Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fas fa-user-shield\"></span></button>\r\n                                    <button class=\"btn btn-primary btn-sm btn-update\" data-id=\"");
#nullable restore
#line 65 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                                                                                          Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fas fa-edit\"></span></button>\r\n                                    <button class=\"btn btn-danger btn-sm btn-delete\" data-id=\"");
#nullable restore
#line 66 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                                                                                         Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fas fa-minus-circle\"></span></button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 69 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 75 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
 if (Model.ResultStatus == ResultStatus.Error)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger mt-3\">\r\n        ");
#nullable restore
#line 79 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
   Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        Dashboard sayfasına geri dönmek için lütfen ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b91bd7f8a9cfe9cbcfab049bdc5bfb4cbcae286521872", async() => {
                WriteLiteral("tıklayınız.");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 82 "C:\Users\Blackerback\OneDrive\Masaüstü\NetCoreDocker\NLayerDocker\MyBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b91bd7f8a9cfe9cbcfab049bdc5bfb4cbcae286523831", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591