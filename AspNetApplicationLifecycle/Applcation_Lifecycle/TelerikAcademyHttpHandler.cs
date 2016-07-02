namespace Applcation_Lifecycle
{
    using System;
    using System.Web;


    public class TelerikAcademyHttpHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return true;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            context.Response.Write("I am telerik academy http handler");
            context.Response.Write("Request URL : " + context.Request.Url);
            context.Response.Write("Response Date " + DateTime.Now);
        }
    }
}