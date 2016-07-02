namespace Applcation_Lifecycle
{
    using System;
    using System.Web;

    public class TelerikHttpModule : IHttpModule
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += Application_BeginRequest;
            context.EndRequest += Application_EndRequest;
        }

        private void Application_BeginRequest(object sender,EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            string filePath = context.Request.FilePath;
            string fileExtension = VirtualPathUtility.GetExtension(filePath);
            
            if(fileExtension.Equals(".aspx"))
            {
                context.Response.Write("<hr>SampleHttpModule : Begin Request</hr>");
            }
        }

        private void Application_EndRequest(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            string filePath = context.Request.FilePath;
            string fileExtension = VirtualPathUtility.GetExtension(filePath);

            if (fileExtension.Equals(".aspx"))
            {
                context.Response.Write("<hr>SampleHttpModule : End Request</hr>");
            }
        }
    }
}