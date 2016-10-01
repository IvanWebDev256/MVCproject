using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using OdeToFood.Models;

namespace OdeToFood.App_Start
{
    public static class AutoMapperConfiguration
    {
        public static MapperConfiguration Configure()
        {
            var xf = new MapperConfiguration((cfg) =>
            {
                cfg.CreateMap<RestaurantReviewModels, ReviewEditModel>();
                cfg.CreateMap<ReviewEditModel, RestaurantReviewModels>()
                .ForMember(x => x.Id, opt => opt.Ignore());
            });
            return xf;
        }
    }
}