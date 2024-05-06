
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services;

public class OrderService : IOrderService
{
    private IOrderItemService _orderItemService;

    private IOrderRepository _orderRepository;
    private IMapper _mapper;
    private IStockService _stockService;


    public OrderService(IOrderRepository orderRepository, IMapper mapper, IStockService stockService, IOrderItemService orderItemService)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
        _stockService = stockService;
        _orderItemService = orderItemService;


    }


    public Order CreateOne(OrderCreateDTO newCreatOrder)
    {

        Order newOrder = _mapper.Map<Order>(newCreatOrder);


        return _orderRepository.CreateOne(newOrder);
    }

    public void Checkout(List<CheckoutDto> checkedoutItems)
    {
        // create order
        Order order = new Order();
        order.AddressID = Guid.NewGuid();
        order.UserId = Guid.NewGuid();
        // order.OrderDate = DateTime.Now;
        order.Payment = "False";
        order.Status = "processing";
        order.TotalAmount = 300;

        Console.WriteLine($"BEFORE LOOP");

        foreach (var item in checkedoutItems)
        {

            IEnumerable<Stock>? stocks = _stockService.FindByProductId(item.ProductId);

            Stock? stock = stocks.FirstOrDefault(stock => stock.Color == item.Color && stock.Size == item.Size);
            if (stock is null) { continue; };

            Console.WriteLine($"ORDER ID = {order.Id}");

            OrderItem OrderItem = _mapper.Map<OrderItem>(item);

            OrderItem.OrderId = order.Id;
            OrderItem.StockId = stock.Id;
            OrderItem.Quantity = item.Quantity;
            Console.WriteLine($"BEFORE CREATE");

            _orderItemService.CreateOne(OrderItem);
            // IEnumerable<OrderItem> orderItems = 
            // save order item in order item database 
        }

        _orderRepository.CreateOne(order);


        // save order in order database 
        // _stockService.FindByProductId(newOrder);

    }

    // public IEnumerable<Stock> EditeOne()
    // {
    //     throw new NotImplementedException();
    // }

    public IEnumerable<OrderCreateDTO> FindAll()
    {
        return _mapper.Map<IEnumerable<OrderCreateDTO>>(_orderRepository.FindAll());

    }

    public IEnumerable<Order> FindByUserId(Guid userId)
    {
        // 
        return _orderRepository.FindByUserId(userId);

    }
    public Order? FindById(Guid id)
    {
        // 
        return _orderRepository.FindById(id);

    }

    public bool DeleteOneById(Guid id)
    {
        Order? order = FindById(id);
        if (order is null)
        {
            return false;
        }
        else
        {
            _orderRepository.DeleteOneById(order);
        }
        return true;
    }
    public bool DeleteOrderByUserId(Guid userId)
    {
        IEnumerable<Order> unwantedUser = FindByUserId(userId);
        if (unwantedUser is not null)
        {
            return false;
        }
        _orderRepository.DeleteOrderByUserId(userId);
        return true;
    }

    // public IEnumerable<Stock> EditItem(int id)
    // {
    //     throw new NotImplementedException();
    // }

}
