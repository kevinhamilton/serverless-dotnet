using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using AwsDotnetCsharp.Utilities;
using System.Collections.Generic;
using Newtonsoft.Json;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AwsDotnetCsharp.Handlers
{
    public class Handler
    {
        public APIGatewayProxyResponse Hello(APIGatewayProxyRequest request, ILambdaContext context)       
        {
            var body = new ResponseBody()
            {
                Message = "Hello Handler"
            };
            
            var resp = new APIGatewayProxyResponse()
            {
                Body = JsonConvert.SerializeObject(body),
                StatusCode = 200,
                IsBase64Encoded = false,
                Headers = new Dictionary<string, string>
                {
                    { "Content-Type", "application/json" }
                }
            };
            
            return resp;
            
        }
    }
}
