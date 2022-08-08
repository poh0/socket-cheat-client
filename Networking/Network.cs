using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZBase;
using SocketIOClient;
using System.Net.Http;

namespace ZBase.Networking
{
    public class Network
    {
        public static readonly string API_URL = "http://localhost:3000";
        public static string token = "";
        public static readonly HttpClient client = new HttpClient();
    }
}
