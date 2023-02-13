using MagazinExpo.Data.Configurations;
using MagazinExpo.Data.IRepositories;
using MagazinExpo.Domain.Entities;

namespace MagazinExpo.Data.Repositories
{
    public class MarketRepository : IMarketRepository
    {
        private string path = DatabasePath.PRODUCT_PATH;
        public void Add(Market product)
        {
            string s = $"{product.Id}|{product.Name}|{product.Description}|{product.Price}|{product.Count}\n";

            File.AppendAllText(path, s);
        }

        public void Delete(string name)
        {
            var product = GetAll();

            File.WriteAllText(path, "");

            foreach (var item in product)
            {
                if (item.Name == name)
                    continue;
                Add(item);
            }
        }

        public Market Get(string name)
        {
            return GetAll().FirstOrDefault(d => d.Name.ToLower().Equals(name.ToLower()));
            
        }

        public List<Market> GetAll()
        {
            string[] lines = File.ReadAllText(path).Split('\n');

            List<Market> list = new List<Market>();
            foreach (var line in lines)
            {
                if (line != "")
                {
                    string[] parts = line.Split('|');
                    Market market1 = new Market()
                    {
                        Id = int.Parse(parts[0]),
                        Name = parts[1],
                        Description = parts[2],
                        Price = int.Parse(parts[3]),
                        Count = int.Parse(parts[4])
                    };
                    list.Add(market1);
                }
            }
            return list;

        }

        public void Update(string name, Market product)
        {
            var products = GetAll();

            File.WriteAllText(path, "");

            foreach (var pr in products)
            {
                if (pr.Name == name)
                {
                    pr.Name = product.Name;
                    pr.Description = product.Description;
                    pr.Price = product.Price;
                    pr.Count = product.Count;
                }
                Add(pr);
            }
        }
    }
}
