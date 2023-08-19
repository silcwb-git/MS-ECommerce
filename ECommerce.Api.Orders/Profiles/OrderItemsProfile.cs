using System;
namespace ECommerce.Api.Orders.Profiles
{
    public class OrderItemsProfile : AutoMapper.Profile
    {
        public OrderItemsProfile()
        {
            CreateMap<Db.OrderItem, Models.OrderItem>();
        }
    }
}

