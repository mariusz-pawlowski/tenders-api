namespace Tenders.Api.Application.Queries
{
    public class Paging
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 100;

        public static Paging Default()
        {
            return new Paging() { 
                PageNumber = 1,
                PageSize = 100
            };
        }
    }
}
