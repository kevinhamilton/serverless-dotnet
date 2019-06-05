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
      public ResponseBody Body {get; set;}
      public int StatusCode {get; set;}
      public Dictionary<string, string> Headers {get; set;}
      public bool isBase64Encoded {get; set;}
      
      public Response(string message, Request request, int status)
      {
        Body = new ResponseBody(message, request);
        StatusCode = status;
        isBase64Encoded = false;
        Headers = new Dictionary<string, string>
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

      public Request(string key1, string key2, string key3){
        Key1 = key1;
        Key2 = key2;
        Key3 = key3;
      }
    }
}
