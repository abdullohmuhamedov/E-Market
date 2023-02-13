using MagazinExpo.Data.Repositories;
using MagazinExpo.Domain.Entities;

namespace MagazinExpo.Data.IRepositories
{
    public interface IMarketRepository
    {
        void Add(Market product);
        void Delete(string name);
        Market Get(string name);
        List<Market> GetAll();
        void Update(string name, Market product);
    }
}
