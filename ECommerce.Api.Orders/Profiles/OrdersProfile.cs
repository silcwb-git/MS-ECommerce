using System;
namespace ECommerce.Api.Orders.Profiles
{
    public class OrdersProfile : AutoMapper.Profile
    {
        public OrdersProfile()
        {
            CreateMap<Db.Order, Models.Order>();
        }
    }
}

