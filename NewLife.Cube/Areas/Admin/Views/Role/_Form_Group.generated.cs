﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
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
    
    #line 1 "..\..\Areas\Admin\Views\Role\_Form_Group.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    
    #line 2 "..\..\Areas\Admin\Views\Role\_Form_Group.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Areas\Admin\Views\Role\_Form_Group.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Role/_Form_Group.cshtml")]
    public partial class _Areas_Admin_Views_Role__Form_Group_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_Role__Form_Group_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Areas\Admin\Views\Role\_Form_Group.cshtml"
  
    var pair = Model as Pair;
    var entity = pair.First as IEntity;
    var item = pair.Second as FieldItem;

    var bs = this.Bootstrap();
    bs.Set(item);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 12 "..\..\Areas\Admin\Views\Role\_Form_Group.cshtml"
 if (item.Name == "Permission")
{
    if (!entity.IsNullKey)
    {
        
            
            #line default
            #line hidden
            
            #line 16 "..\..\Areas\Admin\Views\Role\_Form_Group.cshtml"
   Write(Html.Partial("SetPermission", new { Role = entity }));

            
            #line default
            #line hidden
            
            #line 16 "..\..\Areas\Admin\Views\Role\_Form_Group.cshtml"
                                                             
    }
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 396), Tuple.Create("\"", 451)
, Tuple.Create(Tuple.Create("", 404), Tuple.Create("form-group", 404), true)
, Tuple.Create(Tuple.Create(" ", 414), Tuple.Create("col-sm-12", 415), true)
, Tuple.Create(Tuple.Create(" ", 424), Tuple.Create("col-md-", 425), true)
            
            #line 21 "..\..\Areas\Admin\Views\Role\_Form_Group.cshtml"
, Tuple.Create(Tuple.Create("", 432), Tuple.Create<System.Object, System.Int32>(bs.GetGroupWidth()
            
            #line default
            #line hidden
, 432), false)
);

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 22 "..\..\Areas\Admin\Views\Role\_Form_Group.cshtml"
   Write(Html.Partial("_Form_Item", new Pair(entity, item)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 24 "..\..\Areas\Admin\Views\Role\_Form_Group.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
