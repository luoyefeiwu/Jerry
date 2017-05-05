using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocket4Net;

namespace MonitorService
{
    public class WebSocketHelper
    {
        private WebSocket websocket;

        private string message = string.Empty;
        private AutoResetEvent _messageReceivedEvent = new AutoResetEvent(false);
        private string url = string.Empty;
       

        public WebSocketHelper(string url)
        {
            this.url = url;
        }

        public void Connection()
        {
            websocket = new WebSocket4Net.WebSocket(url, "basic", WebSocketVersion.Rfc6455);
            websocket.Opened += websocket_Opened;
            websocket.Error += websocket_Error;
            websocket.Closed += websocket_Closed;
            websocket.MessageReceived += websocket_MessageReceived;
            //websocket.Open();
        }

        public string Send(string msg)
        {

            switch (websocket.State)
            {
                case WebSocketState.Closed:
                    Connection();
                    websocket.Open();
                    _messageReceivedEvent.WaitOne();
                    break;
                case WebSocketState.Closing:
                    //Connection();
                    //websocket.Open();
                    //_messageReceivedEvent.WaitOne();
                    break;
                case WebSocketState.Connecting:
                    break;
                case WebSocketState.None:
                    websocket.Open();
                    _messageReceivedEvent.WaitOne();
                    break;
                case WebSocketState.Open:
                    break;
                default:
                    break;
            }

            websocket.Send(msg);
            _messageReceivedEvent.WaitOne();
            return message;
        }

        void websocket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            message = e.Message;
            this._messageReceivedEvent.Set();
        }

        void websocket_Closed(object sender, EventArgs e)
        {
            message = "cloased";
            this._messageReceivedEvent.Set();
        }

        void websocket_Error(object sender, SuperSocket.ClientEngine.ErrorEventArgs e)
        {
            message = "error";
            this._messageReceivedEvent.Set();
        }

        void websocket_Opened(object sender, EventArgs e)
        {
            this._messageReceivedEvent.Set();
        }

    }
}
