using AwsDotnetCsharp.Utilities;
using System.Collections.Generic;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Newtonsoft.Json;

namespace AwsDotnetCsharp.Handlers
{
    public class Example
    {
        public APIGatewayProxyResponse Hello(APIGatewayProxyRequest request, ILambdaContext context)       
        {
            var body = new ResponseBody()
            {
                Message = "Example Handler"
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