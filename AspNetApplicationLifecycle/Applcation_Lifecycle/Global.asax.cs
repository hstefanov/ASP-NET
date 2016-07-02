using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Applcation_Lifecycle
{
    public class Global : System.Web.HttpApplication
    {
        private string LogFilePath = Path.GetTempFileName();

        protected void Application_Start(object sender, EventArgs e)
        {
            this.Log("Application_Start Called");
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            this.Log("Session_Start Called");
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            this.Log("Application_BeginnRequest Called");
        }

        //protected void Application_AuthenticateRequest(object sender, EventArgs e)
        //{
        //    this.Log("Application_AuthenticateRequest Called");
        //}

        protected void Application_Error(object sender, EventArgs e)
        {
            this.Log("Application_Error Called");
        }

        protected void Session_End(object sender, EventArgs e)
        {
            this.Log("Session_End Called");
        }

        protected void Application_End(object sender, EventArgs e)
        {
            this.Log("Application_End Called");
            this.Response.Write(string.Format("<pre>{0}</pre>", File.ReadAllText(LogFilePath)));
        }

        private void Log(string line)
        {
            if (!File.Exists(LogFilePath))
            {
                File.Create(LogFilePath);
            }

            var debugLine = string.Format("[{0}] {1}", DateTime.Now, line);

            File.AppendAllLines(LogFilePath, new[] { debugLine });
            Trace.WriteLine(debugLine);
        }
    }
}