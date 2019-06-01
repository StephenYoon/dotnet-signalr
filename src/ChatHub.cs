using DotNetSignalR.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetSignalR
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string name, string text)
        {
            var message = new ChatMessage
            {
                SenderName = name,
                Text = text,
                SentAt = DateTimeOffset.UtcNow
            };

            // Broadcast to all clients.
            // Invokes receive message function on every client.
            // Effectively a single large group chat.
            await Clients.All.SendAsync(
                "ReceiveMessage", 
                message.SenderName, 
                message.SentAt, 
                message.Text);
        }
    }
}
