﻿To use this template with Windows Azure authentication, refer to http://go.microsoft.com/fwlink/?LinkID=267940.

Otherwise, to use this template with Windows authentication, refer to the instructions below:

First Things First:
1. Please follow instructions on this link: http://www.asp.net/mvc/overview/releases/how-to-upgrade-an-aspnet-mvc-4-and-web-api-project-to-aspnet-mvc-5-and-web-api-2

2. Windows Authentication Fix:
http://stackoverflow.com/questions/20078482/mvc5-redirects-to-login-aspx-when-using-windows-authentication

Hosting on IIS Express:
1. Click on your project in the Solution Explorer to select the project.
2. If the Properties pane is not open, open it (F4).
3. In the Properties pane for your project:
   a) Set "Anonymous Authentication" to "Disabled".
   b) Set "Windows Authentication" to "Enabled".

Hosting on IIS 7 or later:
1. Open IIS Manager and navigate to your website.
2. In Features View, double-click Authentication.
3. On the Authentication page, select Windows authentication. If Windows
   authentication is not an option, you'll need to make sure Windows authentication
   is installed on the server.

      To enable Windows authentication on Windows:
      a) In Control Panel open "Programs and Features".
      b) Select "Turn Windows features on or off".
      c) Navigate to Internet Information Services > World Wide Web Services > Security
         and make sure the Windows authentication node is checked.

      To enable Windows authentication on Windows Server:
      a) In Server Manager, select Web Server (IIS) and click Add Role Services.
      b) Navigate to Web Server > Security
         and make sure the Windows authentication node is checked.

4. In the Actions pane, click Enable to use Windows authentication.
5. On the Authentication page, select Anonymous authentication.
6. In the Actions pane, click Disable to disable anonymous authentication.



Id                             Version              Description/Release Notes                                                                                                                                                                                   
--                             -------              -------------------------                                                                                                                                                                                   
Antlr                          3.4.1.9004           ANother Tool for Language Recognition, is a language tool that provides a framework for constructing recognizers, interpreters, compilers, and translators from grammatical descriptions containing actio...
EntityFramework                6.1.3                Entity Framework is Microsoft's recommended data access technology for new applications.                                                                                                                    
jQuery                         2.1.4                jQuery is a new kind of JavaScript Library....                                                                                                                                                              
jQuery.UI.Combined             1.11.4               jQuery UI is an open source library of interface components — interactions, full-featured widgets, and animation effects — based on the stellar jQuery javascript library . Each component is built accor...
jQuery.Validation              1.14.0               This jQuery plugin makes simple clientside form validation trivial, while offering lots of option for customization. That makes a good choice if you’re building something new from scratch, but also whe...
knockoutjs                     3.4.0                A JavaScript MVVM library to help you create rich, dynamic user interfaces with clean maintainable code                                                                                                     
Microsoft.AspNet.Mvc           5.2.3                This package contains the runtime assemblies for ASP.NET MVC. ASP.NET MVC gives you a powerful, patterns-based way to build dynamic websites that enables a clean separation of concerns and that gives y...
Microsoft.AspNet.Mvc.FixedD... 5.0.0                The previous version of this package contained a workaround for a bug affecting mobile view caching in ASP.NET MVC 4. As of ASP.NET MVC 5 this workaround is no longer needed. This package can be safely...
Microsoft.AspNet.Razor         3.2.3                This package contains the runtime assemblies for ASP.NET Web Pages. ASP.NET Web Pages and the new Razor syntax provide a fast, terse, clean and lightweight way to combine server code with HTML to creat...
Microsoft.AspNet.Web.Optimi... 1.1.3                ASP.NET Optimization introduces a way to bundle and optimize CSS and JavaScript files.                                                                                                                      
Microsoft.AspNet.WebApi        5.2.3                This package contains everything you need to host ASP.NET Web API on IIS. ASP.NET Web API is a framework that makes it easy to build HTTP services that reach a broad range of clients, including browser...
Microsoft.AspNet.WebApi.Client 5.2.3                This package adds support for formatting and content negotiation to System.Net.Http. It includes support for JSON, XML, and form URL encoded data.                                                          
Microsoft.AspNet.WebApi.Core   5.2.3                This package contains the core runtime assemblies for ASP.NET Web API. This package is used by hosts of the ASP.NET Web API runtime. To host a Web API in IIS use the Microsoft.AspNet.WebApi.WebHost pac...
Microsoft.AspNet.WebApi.OData  5.7.0                This package contains everything you need to create OData endpoints using ASP.NET Web API and to support OData query syntax for your web APIs.                                                              
Microsoft.AspNet.WebApi.Web... 5.2.3                This package contains everything you need to host ASP.NET Web API on IIS. ASP.NET Web API is a framework that makes it easy to build HTTP services that reach a broad range of clients, including browser...
Microsoft.AspNet.WebHelpers    3.2.3                This package contains web helpers to easily add functionality to your site such as Captcha validation, Twitter profile and search boxes, Gravatars, Video, Bing search, site analytics or themes.           
Microsoft.AspNet.WebPages      3.2.3                This package contains core runtime assemblies shared between ASP.NET MVC and ASP.NET Web Pages.                                                                                                             
Microsoft.AspNet.WebPages.Data 3.2.3                This package contains the runtime assemblies for ASP.NET Web Pages. ASP.NET Web Pages and the new Razor syntax provide a fast, terse, clean and lightweight way to combine server code with HTML to creat...
Microsoft.AspNet.WebPages.W... 3.2.3                This package contains the runtime assemblies for ASP.NET Web Pages. ASP.NET Web Pages and the new Razor syntax provide a fast, terse, clean and lightweight way to combine server code with HTML to creat...
Microsoft.Data.Edm             5.7.0                Classes to represent, construct, parse, serialize and validate entity data models. Targets .NET 4.0, Silverlight 4.0, or .NET Portable Lib with support for .NET 4.0, SL 5.0, Win Phone 8, Win Phone 8.1,...
Microsoft.Data.OData           5.7.0                Classes to serialize, deserialize and validate OData payloads. Enables construction of OData producers and consumers. Targets .NET 4.0, Silverlight 4.0 or .NET Portable Lib with support for .NET 4.0, S...
Microsoft.jQuery.Unobtrusiv... 3.2.3                jQuery plugin that unobtrusively sets up jQuery Ajax.                                                                                                                                                       
Microsoft.jQuery.Unobtrusiv... 3.2.3                jQuery plugin that unobtrusively sets up jQuery.Validation.                                                                                                                                                 
Microsoft.Web.Infrastructure   1.0.0.0              This package contains the Microsoft.Web.Infrastructure assembly that lets you dynamically register HTTP modules at run time.                                                                                
Modernizr                      2.8.3                Modernizr adds classes to the <html> element which allow you to target specific browser functionality in your stylesheet. You don't actually need to write any Javascript to use it....                     
Newtonsoft.Json                8.0.1                Json.NET is a popular high-performance JSON framework for .NET                                                                                                                                              
System.Spatial                 5.7.0                Contains classes and methods that facilitate geography and geometry spatial operations. Targets .NET 4.0, Silverlight 4.0 or .NET Portable Lib with support for .NET 4.0, SL 5.0, Win Phone 8, Win Phone ...
WebGrease                      1.6.0                Web Grease is a suite of tools for optimizing javascript, css files and images.   