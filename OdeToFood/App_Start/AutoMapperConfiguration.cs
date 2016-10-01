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
                cfg.CreateMap<RestaurantReview, ReviewEditModel>();
                cfg.CreateMap<ReviewEditModel, RestaurantReview>()
                .ForMember(x => x.Id, opt => opt.Ignore());
            });
            return xf;
        }
    }
}