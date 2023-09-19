
using Microsoft.AspNetCore.SignalR;

namespace signalr
{
	public class ChatHub : Hub
	{
		public async Task Send(string message)
		{
			await this.Clients.All.SendAsync("receive", message);
		}
	}
}
