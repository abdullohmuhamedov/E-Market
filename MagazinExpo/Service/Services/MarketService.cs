using MagazinExpo.Data.IRepositories;
using MagazinExpo.Data.Repositories;
using MagazinExpo.Domain.Entities;
using MagazinExpo.Service.DTOs;
using MagazinExpo.Service.Helpers;
using MagazinExpo.Service.Interfaces;

namespace MagazinExpo.Service.Services
{
    public class MarketService : IMarketService
    {
        private readonly IMarketService marketService;
        public MarketService(IMarketService marketService)
        {
            this.marketService = marketService;
        }
        public async Task<MarketResponse> DeleteAsync(long id)
        {
            var model = await marketService.GetByIdAsync(id);

            if (model is null)
                return new MarketResponse()
                {
                    StatusCode = 404,
                    Message = "Not found",
                    Markets = null
                };
            await marketService.DeleteAsync(id);
            return new MarketResponse()
            {
                StatusCode = 200,
                Message = "Success",
                Markets = null
            };
        }

        public async Task<ListResponse> GetAllAsync()
        {
            var marketss = await marketService.GetAllAsync();
            return new ListResponse()
            {
                StatusCode = 200,
                Message = "Success",
                Markets = null
            };
        }

        public async Task<MarketResponse> GetByIdAsync(long id)
        {
            var model = await marketService.GetByIdAsync(id);
            if (model is null)
                return new MarketResponse()
                {
                    StatusCode = 404,
                    Message = "Not found",
                    Markets = null
                };
            return new MarketResponse()
            {
                StatusCode = 200,
                Message = "Success",
                Markets = null
            };

        }

        
        public async Task<MarketResponse> UpdateAsync(long id, MarketInsertionDto market)
        {
            var model = await marketService.GetByIdAsync(id);
            if (model is null)
                return new MarketResponse()
                {
                    StatusCode = 404,
                    Message = "Not found",
                    Markets = null
                };
            var result = new Market()
            {
                Id = id,
                Name = market.Name,
                Description = market.Description,
                Count = market.Count,
                Price = market.Price
            };
            var updatedProduct = await marketService.UpdateAsync(result);
            return new MarketResponse()
            {
                StatusCode = 200,
                Message = "Success",
                Markets = null
            };
        }
        public async Task<MarketResponse> CreateAsync(long id, MarketInsertionDto market)
        {
            var model = await marketService.GetByIdAsync(id);
            if (model is null)
                return new MarketResponse()
                {
                    StatusCode = 404,
                    Message = "Product is not found",
                    Markets = null
                };
            await marketService.DeleteAsync(id);
            return new MarketResponse()
            {
                StatusCode = 200,
                Message = "Success",
                Markets = null
            };
        }

    }
}
