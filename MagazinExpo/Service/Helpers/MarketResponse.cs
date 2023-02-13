using MagazinExpo.Domain.Entities;

namespace MagazinExpo.Service.Helpers
{
    public class MarketResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }

        public Market Markets { get; set; }
    }
}
