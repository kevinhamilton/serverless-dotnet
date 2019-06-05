using Amazon.Lambda.Core;
using AwsDotnetCsharp.Utilities;


[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AwsDotnetCsharp.Handlers
{
    public class Handler
    {
       public Response Hello(Request request)
       {
           return new Response("Go Serverless v1.0! Your function executed successfully!", request, 200);
       }
    }
}
