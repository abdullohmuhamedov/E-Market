using MagazinExpo.Service.DTOs;
using MagazinExpo.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinExpo.Service.Interfaces
{
    public interface IMarketService
    {
        Task<MarketResponse> CreateAsync(MarketInsertionDto market);
        Task<MarketResponse> UpdateAsync(long id, MarketInsertionDto market);
        Task<MarketResponse> DeleteAsync(long id);
        Task<MarketResponse> GetByIdAsync(long id);
        Task<ListResponse> GetAllAsync();
    }
}
