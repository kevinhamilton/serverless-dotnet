using Amazon.Lambda.Core;
using System;
using System.Collections.Generic;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AwsDotnetCsharp
{
    public class Handler
    {
       public Response Hello(Request request)
       {
           return new Response("Go Serverless v1.0! Your function executed successfully!", request, 200);
       }
    }

    public class Response
    {
        public string body {get; set;}
        public int statusCode {get; set;}
        public Dictionary<string, string> headers {get; set;}
        public bool isBase64Encoded {get; set;}

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

    public class ResponseBody
    {
        public string Message {get; set;}
        public Request Request {get; set;}

        public ResponseBody(string message, Request request) {
            Message = message;
            Request = request;
        }
    }

    public class Request
    {
        public string Key1 {get; set;}
        public string Key2 {get; set;}
        public string Key3 {get; set;}

        public Request(string key1, string key2, string key3)
        {
            Key1 = key1;
            Key2 = key2;
            Key3 = key3;
        }
    }
}
