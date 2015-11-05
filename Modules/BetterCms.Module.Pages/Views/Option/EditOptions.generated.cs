﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
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
    
    #line 1 "..\..\Views\Option\EditOptions.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Option\EditOptions.cshtml"
    using BetterCms.Module.Pages.Mvc.EditableGrid;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Option\EditOptions.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Option\EditOptions.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Option\EditOptions.cshtml"
    using BetterCms.Module.Root.Mvc.Grids;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Option\EditOptions.cshtml"
    using BetterCms.Module.Root.ViewModels.Shared;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Option/EditOptions.cshtml")]
    public partial class _Views_Option_EditOptions_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Option_EditOptions_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 8 "..\..\Views\Option\EditOptions.cshtml"
  
    var model = new EditableGridViewModel();

    model.ShowSearch = false;
    model.TopBlockClass = "bcms-top-block-holder";
    model.SaveButtonTitle = RootGlobalization.Button_Ok;
    model.AddHiddenFields = true;
    model.ShowMessages = false;
    model.TopBlockAddItemView = "~/Areas/bcms-pages/Views/Option/Partial/TopBlockAddItem.cshtml";
    model.Columns = new List<EditableGridColumn>
            {
                new EditableGridColumn(PagesGlobalization.Options_OptionKeyColumn, null, "key")
                    {
                        HeaderAttributes = "style=\"width: 200px;\"",
                        AutoFocus = true,
                        HiddenFieldName = "Options[{0}].OptionKey",
                        FocusIdentifier = "hasFocus"
                    },

                new EditableGridDropDownColumn(PagesGlobalization.Options_OptionTypeColumn, null, "calcType")
                    {
                        HeaderAttributes = "style=\"width: 100px;\"",
                        OptionsBind = "optionTypes",
                        ValueTextBind = "typeName",
                        CanBeEdited = false
                    },
                                        
                new OptionValueEditableGridColumn(PagesGlobalization.Options_OptionDefaultValueColumn, "defaultValueBinding", "customOptionDefaultTitle")
                    {
                        HiddenFieldName = "Options[{0}].OptionDefaultValue",
                        FocusIdentifier = "valueHasFocus"
                    },
                    
                new EditableGridHiddenField("type", "Options[{0}].Type"),
                new EditableGridHiddenField("customType", "Options[{0}].CustomType")
            };

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 46 "..\..\Views\Option\EditOptions.cshtml"
Write(Html.Partial(RootModuleConstants.EditableGridTemplate, model));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
