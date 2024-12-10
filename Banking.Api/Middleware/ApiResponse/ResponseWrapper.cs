namespace Banking.Api.Middleware.ApiResponse
{
    public class ResponseWrapper
    {
        public string Status { get; set; }
        public string Error { get; set; }
        public object Data { get; set; }
    }
}
