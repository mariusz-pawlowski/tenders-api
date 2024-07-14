using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Tenders.Api.Contracts.Endpoints
{
    public class GetTenderParameters
    {
        [Required]
        [FromRoute(Name = "id")]
        public string TenderId { get; set; } = default!;
    }
}
