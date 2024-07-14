using Tenders.Api.Contracts.Models;

namespace Tenders.Api.Application.Queries
{
    public class Ordering
    {
        public OrderBy? OrderByDate { get; set; }
        public OrderBy? OrderByPriceEuro { get; set; }

        public static Ordering NoOrdering()
        {
            return new Ordering();
        }
    }
}
