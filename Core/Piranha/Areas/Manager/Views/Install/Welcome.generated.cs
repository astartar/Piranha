﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.Install
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
    using Piranha.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Install/Welcome.cshtml")]
    public partial class Welcome : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Welcome()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Manager\Views\Install\Welcome.cshtml"
  
	ViewBag.Title = Piranha.Resources.Account.InstallTitle;
	Layout = "";

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n<head>\r\n\t<meta");

WriteLiteral(" http-equiv=\"content-type\"");

WriteLiteral(" content=\"text/html; charset=utf-8\"");

WriteLiteral(" />\r\n\t<title>Wecome to Piranha CMS</title>\r\n\r\n\t<link");

WriteAttribute("href", Tuple.Create(" href=\"", 232), Tuple.Create("\"", 284)
, Tuple.Create(Tuple.Create("", 239), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/img/icon.ico")
, 239), false)
);

WriteLiteral(" rel=\"icon\"");

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral(">\r\n\t<link");

WriteAttribute("href", Tuple.Create(" href=\"", 325), Tuple.Create("\"", 377)
, Tuple.Create(Tuple.Create("", 332), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/img/icon.ico")
, 332), false)
);

WriteLiteral(" rel=\"shortcut icon\"");

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral(">\r\n\t<link");

WriteAttribute("href", Tuple.Create(" href=\"", 427), Tuple.Create("\"", 484)
, Tuple.Create(Tuple.Create("", 434), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/css/style.min.css")
, 434), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n\r\n\t<style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(@">
		.grid_12.welcome {
			font-size: 108%;
		}

		.welcome .title {
			padding: 20px 34px;
		}
		.welcome .title h2 {
			font-size: 24px;
		}

		.welcome .inner hr {
			color: #ddd;
			background: #ddd;
			border: 0;
			height: 1px;
			margin-bottom: 14px;
		}

		.welcome .inner {
			padding: 24px 34px;
			background: url('");

            
            #line 37 "..\..\Areas\Manager\Views\Install\Welcome.cshtml"
                        Write(Href("~/res.ashx/areas/manager/content/img/logo-big.png"));

            
            #line default
            #line hidden
WriteLiteral(@"') no-repeat 190% -10%;
		}

		.welcome .inner p {
			padding-bottom: 14px;
			line-height: 1.4em;
		}

		.welcome .inner h2 {
			border-bottom: 1px solid #DDDDDD;
			font-size: 20px;
			font-weight: bold;
			margin: 10px 0;
			padding-bottom: 8px;
		}

		.welcome .inner pre {
			padding-bottom: 14px;
		}

		.welcome .inner code {
			font-size: 14px;
		}
	</style>
</head>
<body>
	<div");

WriteLiteral(" class=\"container_12\"");

WriteLiteral(">\r\n\t\t<div");

WriteLiteral(" class=\"grid_12 box welcome\"");

WriteLiteral(">\r\n\t\t\t<div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>Welcome to Piranha CMS</h2></div>\r\n\t\t\t<div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n\t\t\t\t<p>\r\n\t\t\t\t\tHi, and welcome to Piranha CMS. We\'re assuming that this is the " +
"<strong>first</strong> time\r\n\t\t\t\t\tyou start your application since there\'s no co" +
"nnection string configured with the\r\n\t\t\t\t\tname <code>piranha</code>.\r\n\t\t\t\t</p>\r\n" +
"\r\n\t\t\t\t<p>\r\n\t\t\t\t\tIf you take a look in your web.config you\'ll see that there\'s ex" +
"ample connection\r\n\t\t\t\t\tstrings included for <code>SqlCE</code>, <code>SqlExpress" +
"</code>, <code>LocalDb</code> and\r\n\t\t\t\t\t<code>SqlServer</code>.\r\n\t\t\t\t</p>\r\n\r\n\t\t\t" +
"\t<h2>SqlCE</h2>\r\n\r\n\t\t\t\t<p>\r\n\t\t\t\t\tIf you want to use SqlCE, which is a file-based" +
" database hosted in your web\r\n\t\t\t\t\tapplication you have to start by installing t" +
"he following package from NuGet:\r\n\t\t\t\t</p>\r\n\r\n\t\t\t\t<pre><code>&gt; Install-Packag" +
"e EntityFramework.SqlServerCompact</code></pre>\r\n\r\n\t\t\t\t<p>\r\n\t\t\t\t\tAfter this is d" +
"one, rename the connection string named <strong>piranha-ce</strong>\r\n\t\t\t\t\tto <st" +
"rong>piranha</strong> and if you wish, modify the name and location of\r\n\t\t\t\t\tyou" +
"r <code>.sdf</code> file.\r\n\t\t\t\t</p>\r\n\r\n\t\t\t\t<h2>SqlExpress</h2>\r\n\r\n\t\t\t\t<p>\r\n\t\t\t\t\t" +
"If you want to use SqlExpress, which is a free, out-of-process database, rename " +
"the\r\n\t\t\t\t\tconnection string named <strong>piranha-express</strong> to <strong>pi" +
"ranha</strong>\r\n\t\t\t\t\tand change the credentials to real values. Make sure you <s" +
"trong>create</strong> the database\r\n\t\t\t\t\tbefore continuing as the installer only" +
" installs the Schema and default data, it does not\r\n\t\t\t\t\tcreate the database for" +
" you.\r\n\t\t\t\t</p>\r\n\r\n\t\t\t\t<h2>LocalDb</h2>\r\n\r\n\t\t\t\t<p>\r\n\t\t\t\t\tIf you want to use Loca" +
"lDb, which is a free, in-process development database, rename the\r\n\t\t\t\t\tconnecti" +
"on string named <strong>piranha-local</strong> to <strong>piranha</strong> and\r\n" +
"\t\t\t\t\tchange the credentials to real values. Make sure you <strong>create</strong" +
"> the database\r\n\t\t\t\t\tbefore continuing as the installer only installs the Schema" +
" and default data, it does not\r\n\t\t\t\t\tcreate the database for you.\r\n\t\t\t\t</p>\r\n\r\n\t" +
"\t\t\t<h2>SqlServer</h2>\r\n\r\n\t\t\t\t<p>\r\n\t\t\t\t\tIf you want to use SqlServer, which is Mi" +
"crosofts production-line database, rename the\r\n\t\t\t\t\tconnection string named <str" +
"ong>piranha-sql</strong> to <strong>piranha</strong> and change\r\n\t\t\t\t\tthe creden" +
"tials to real values. Make sure you <strong>create</strong> the database before\r" +
"\n\t\t\t\t\tcontinuing as the installer only installs the Schema and default data, it " +
"does not create\r\n\t\t\t\t\tthe database for you.\r\n\t\t\t\t</p>\r\n\r\n\t\t\t\t<hr />\r\n\t\t\t\t<p>\r\n\t\t" +
"\t\t\tAfter you have configured your database you can <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3963), Tuple.Create("\"", 3990)
            
            #line 126 "..\..\Areas\Manager\Views\Install\Welcome.cshtml"
, Tuple.Create(Tuple.Create("", 3970), Tuple.Create<System.Object, System.Int32>(Url.Action("index")
            
            #line default
            #line hidden
, 3970), false)
);

WriteLiteral(">continue</a> to the installation.\r\n\t\t\t\t</p>\r\n\t\t\t\t<div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</body>\r\n</html>");

        }
    }
}
#pragma warning restore 1591