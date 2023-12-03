using AutoMapper;
using Shopkart.Services.CouponAPI.Models;
using Shopkart.Services.CouponAPI.Models.Dto;

namespace Shopkart.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });

            return mappingConfig;
        }
    }
}
