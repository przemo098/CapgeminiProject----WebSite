using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ZpiCapgeminiProduction5.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // for all users
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}