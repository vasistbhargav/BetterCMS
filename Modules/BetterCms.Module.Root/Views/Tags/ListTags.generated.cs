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
    
    #line 1 "..\..\Views\Tags\ListTags.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Tags\ListTags.cshtml"
    using BetterCms.Module.Root.Controllers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Tags\ListTags.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.Extensions;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Tags\ListTags.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.TableRenderers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Tags\ListTags.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Tags\ListTags.cshtml"
    using BetterCms.Module.Root.ViewModels.Tags;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\Tags\ListTags.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Views\Tags\ListTags.cshtml"
    using MvcContrib.UI.Grid;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tags/ListTags.cshtml")]
    public partial class _Views_Tags_ListTags_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.SiteSettings.SearchableGridViewModel<BetterCms.Module.Root.ViewModels.Tags.TagItemViewModel>>
    {
        public _Views_Tags_ListTags_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("    ");

            
            #line 11 "..\..\Views\Tags\ListTags.cshtml"
      
        Action<ColumnBuilder<TagItemViewModel>> columns;
    
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 14 "..\..\Views\Tags\ListTags.cshtml"
    
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Tags\ListTags.cshtml"
     using (Html.BeginForm<TagsController>(f => f.ListTags(null), FormMethod.Post, new { @id = "bcms-tags-form", @class = "bcms-ajax-form" }))
    {
        columns = column =>
        {
            column.EditButtonColumn();

            column.For(model => Html.InlineEditColumnWithNamePattern(m => model.Name, "bcms-tag-name", "bcms-tag-old-name", "TagName_{0}"))
                .Named(RootGlobalization.SiteSettings_Tags_TagColumn)
                .SortColumnName("Name")
                .Encode(false);

            column.InlineEditControlsColumn();
        };

        
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Tags\ListTags.cshtml"
   Write(Html.SiteSettingsMessagesBox());

            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Tags\ListTags.cshtml"
                                       
        
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\Tags\ListTags.cshtml"
   Write(Html.HiddenGridOptions(Model.GridOptions));

            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\Tags\ListTags.cshtml"
                                                  

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"bcms-top-block-holder\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-clearfix\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-large-titles\"");

WriteLiteral(">");

            
            #line 32 "..\..\Views\Tags\ListTags.cshtml"
                                          Write(RootGlobalization.SiteSettings_Tags_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-top-block-inner\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-search-block\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 36 "..\..\Views\Tags\ListTags.cshtml"
                   Write(Html.TextBoxFor(m => m.SearchQuery, new { @class = "bcms-search-field-box bcms-search-query", @placeholder = RootGlobalization.WaterMark_Search }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"bcms-btn-search\"");

WriteLiteral(" id=\"bcms-tags-search-btn\"");

WriteLiteral(">");

            
            #line 37 "..\..\Views\Tags\ListTags.cshtml"
                                                                          Write(RootGlobalization.SiteSettings_Tags_Search);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"bcms-btn-main\"");

WriteLiteral(" id=\"bcms-site-settings-add-tag\"");

WriteLiteral(">");

            
            #line 40 "..\..\Views\Tags\ListTags.cshtml"
                                                                          Write(RootGlobalization.SiteSettings_Tags_AddNewTag);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-top-block-pager\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 45 "..\..\Views\Tags\ListTags.cshtml"
           Write(Html.RenderPaging(Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

            
            #line 48 "..\..\Views\Tags\ListTags.cshtml"

        
            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Tags\ListTags.cshtml"
   Write(Html.Grid(Model.Items).Sort(Model.GridOptions).Columns(columns).Attributes(@class => "bcms-tables").RenderUsing(new EditableHtmlTableGridRenderer<TagItemViewModel>()));

            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Tags\ListTags.cshtml"
                                                                                                                                                                               
        
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Tags\ListTags.cshtml"
   Write(Html.HiddenSubmit());

            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Tags\ListTags.cshtml"
                            
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-editable-row-template\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 54 "..\..\Views\Tags\ListTags.cshtml"
   Write(Html.Grid(new List<TagItemViewModel> { new TagItemViewModel() }).Columns(columns).Attributes(@class => "bcms-tables").RenderUsing(new HtmlTableGridSingleRowRenderer<TagItemViewModel>()));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </script>\r\n");

        }
    }
}
#pragma warning restore 1591
