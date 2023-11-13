namespace CD.STORE.Utility.Response
{
    public class SearchPaginatedResponse<T> where T : class
    {
        public int TotalRecords { get; set; }
        public IEnumerable<T> Data { get; set; }
    }
}
