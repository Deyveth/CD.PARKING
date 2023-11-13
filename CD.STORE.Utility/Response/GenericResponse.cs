namespace CD.STORE.Utility.Response
{
    public class GenericResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
    public class GenericResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
    public class PaginatorResponse<T> : SearchPaginatedResponse<T> where T : class
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
