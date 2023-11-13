namespace CD.STORE.Utility.Response
{
    public class CustomResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }

    public class CustomResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
