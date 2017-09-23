using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace XamarinSignalR.Server.Hubs
{
    public class OpenHub : Hub
    {
        public override Task OnConnected()
        {
            return base.OnConnected();
        }
        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }
        public override Task OnReconnected()
        {
            return base.OnReconnected();
        }
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}