﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ilaro.Admin.Views.IlaroAdmin.EditorTemplates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Ilaro.Admin.Commons.Paging;
    using Ilaro.Admin.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IlaroAdmin/EditorTemplates/NumericPartial.cshtml")]
    public partial class _NumericPartial : System.Web.Mvc.WebViewPage<Ilaro.Admin.ViewModels.Property>
    {
        public _NumericPartial()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\IlaroAdmin\EditorTemplates\NumericPartial.cshtml"
  Html.ClearPrefix();
            
            #line default
            #line hidden
WriteLiteral("\r\n<label");

WriteAttribute("for", Tuple.Create(" for=\"", 72), Tuple.Create("\"", 98)
            
            #line 4 "..\..\Views\IlaroAdmin\EditorTemplates\NumericPartial.cshtml"
, Tuple.Create(Tuple.Create("", 78), Tuple.Create<System.Object, System.Int32>(Html.Id(Model.Name)
            
            #line default
            #line hidden
, 78), false)
);

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">");

            
            #line 4 "..\..\Views\IlaroAdmin\EditorTemplates\NumericPartial.cshtml"
                                                            Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 4 "..\..\Views\IlaroAdmin\EditorTemplates\NumericPartial.cshtml"
                                                                               Write(Html.Condition(Model.IsRequired, () => "<span class=\"text-danger\">*</span>"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n<div");

WriteLiteral(" class=\"controls col-md-3\"");

WriteLiteral(">\r\n\t<div");

WriteLiteral(" class=\"input-group\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t");

            
            #line 7 "..\..\Views\IlaroAdmin\EditorTemplates\NumericPartial.cshtml"
Write(Html.TextBox(Model.Name, Model.StringValue, Model, Model.ControlsAttributes.Merge(new { @class = "form-control numeric", autocomplete = "off" })));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t</div>\r\n");

WriteLiteral("\t");

            
            #line 9 "..\..\Views\IlaroAdmin\EditorTemplates\NumericPartial.cshtml"
Write(Html.Condition(!string.IsNullOrEmpty(Model.Description), () => "<span class=\"help-block\">" + Model.Description + "</span>"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

            
            #line 11 "..\..\Views\IlaroAdmin\EditorTemplates\NumericPartial.cshtml"
Write(Html.ValidationMessage(Model.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
