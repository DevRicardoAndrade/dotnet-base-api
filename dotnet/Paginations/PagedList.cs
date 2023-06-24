namespace dotnet.Paginations
{
    public class PagedList<T> : List<T> where T : class
    {
        public int CurrentPage { get; set; }    
        public int PageSize { get; set; }
        public int TotalPages { get; set; } 
        public int TotalCount { get; set; }

        public bool HasPrevoius => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;

        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            TotalCount = count; 
            PageSize = pageSize;    
            CurrentPage = pageNumber;   
            AddRange(items);
        }

        public static PagedList<T> ToPagedList(IQueryable<T> source, PagesParameters parameters)
        {
            var count = source.Count();
            var items = source.Skip((parameters.PageNumber - 1) * parameters.PageSize).Take(parameters.PageSize).ToList();
            return new PagedList<T>(items, count, parameters.PageNumber, parameters.PageSize);
        }
    }
}
