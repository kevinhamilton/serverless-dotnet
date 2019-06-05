using System.Collections.Generic;

namespace AwsDotnetCsharp.Utilities
{
    public class Response
    {
        public string body {get; set;}
        public int statusCode {get; set;}
        public bool isBase64Encoded {get; set;}
        public Dictionary<string, string> headers {get; set;}

        public Response(string message, Request request, int status)
        {
            body = message;
            // Execution failed due to configuration error: Malformed Lambda proxy response
            // body = new ResponseBody(message, request);
            statusCode = status;
            isBase64Encoded = false;
            headers = new Dictionary<string, string>
            {
                { "Content-Type", "application/json" },
                { "Access-Control-Allow-Origin", "*" }
            };
        }
    }
}