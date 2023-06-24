namespace dotnet.Paginations
{
    public class PagesParameters
    {
        // our max size page here
        private const int _maxPageSize = 30;

        public int PageNumber { get; set; }
        private int _pageSize;
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = (value > _maxPageSize) ? _maxPageSize : value; }
        }

        // for implement use _context.Our Entity.Skip((pagesParameter.PageNumber - 1) * pagesParameter.PageSize).Take(pagesParameter.PageSize).Method()
    }
}
