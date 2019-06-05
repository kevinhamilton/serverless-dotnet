using AwsDotnetCsharp.Utilities;

namespace AwsDotnetCsharp.Handlers
{
    public class Example
    {
        public Response Hello(Request request)
        {
            return new Response("Your second function executed successfully!", request, 200);
        }
    }
}