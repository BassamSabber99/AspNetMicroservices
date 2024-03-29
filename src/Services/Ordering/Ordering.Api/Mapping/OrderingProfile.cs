﻿using AutoMapper;
using EventBus.Messages.Events;
using Ordering.Application.Features.Commands.CheckoutOrder;

namespace Ordering.Api.Mapping
{
    public class OrderingProfile : Profile
    {
        public OrderingProfile()
        {
            CreateMap<CheckoutOrderCommand, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
