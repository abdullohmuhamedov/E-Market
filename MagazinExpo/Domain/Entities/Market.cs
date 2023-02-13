using MagazinExpo.Domain.Enums;

namespace MagazinExpo.Domain.Entities
{
    public class Market
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public StatusType Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
