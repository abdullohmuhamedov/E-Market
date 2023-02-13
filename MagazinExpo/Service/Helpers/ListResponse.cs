using MagazinExpo.Domain.Entities;

namespace MagazinExpo.Service.Helpers
{
    public class ListResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public List<Market> Markets { get; set; }
    }
}
