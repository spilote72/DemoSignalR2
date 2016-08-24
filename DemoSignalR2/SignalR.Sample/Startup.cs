﻿using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(Microsoft.AspNet.SignalR.StockTicker.Startup), "Configuration")]

namespace Microsoft.AspNet.SignalR.StockTicker
{
    public static class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application using OWIN startup, visit http://go.microsoft.com/fwlink/?LinkID=316888

             app.MapSignalR();
        }
    }
}