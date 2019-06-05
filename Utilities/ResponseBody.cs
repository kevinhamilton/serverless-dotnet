namespace AwsDotnetCsharp.Utilities
{
    public class ResponseBody
    {
        public string Message {get; set;}
        public Request Request {get; set;}

        public ResponseBody(string message, Request request) {
            Message = message;
            Request = request;
        }
    }
}