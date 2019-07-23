using System;
using System.Net;

namespace Noti
{
    public class TimeoutWebClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri uri)
        {
            WebRequest w = base.GetWebRequest(uri);
            w.Timeout = 6000;
            return w;
        }
    }
}