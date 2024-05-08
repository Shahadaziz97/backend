
using AutoMapper;
using Hanan_csharp_backend_teamwork.src.Abstractions;
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
    private IUserService _userService;
    private IPaymentService _paymentService;
    private IAddressService _addressService;


    public OrderService(IOrderRepository orderRepository, IAddressService addressService, IMapper mapper, IStockService stockService, IOrderItemService orderItemService, IUserService userService, IPaymentService paymentService)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
        _stockService = stockService;
        _orderItemService = orderItemService;
        _userService = userService;
        _paymentService = paymentService;
        _addressService = addressService;



    }


    public Order CreateOne(OrderCreateDTO newCreatOrder)
    {

        Order newOrder = _mapper.Map<Order>(newCreatOrder);


        return _orderRepository.CreateOne(newOrder);
    }

    public void Checkout(List<CheckoutDto> checkedoutItems, string userId)
    {

        var haveAddress = _addressService.FindOne(new Guid(userId));
        if (haveAddress is null)
        {
            Console.WriteLine("Add your address first");
        }
        else
        {
            // create order
            Order order = new()
            {
                AddressId = haveAddress.Id,
                OrderDate = DateTime.Now,
                UserId = new Guid(userId),
                PaymentId = Guid.NewGuid(),
                Status = Enums.Status.InProgress,

            };
            _orderRepository.CreateOne(order);

            Console.WriteLine($"BEFORE LOOP");

            foreach (var item in checkedoutItems)
            {

                IEnumerable<Stock>? stocks = _stockService.FindByProductId(item.ProductId);

                Stock? stock = stocks.FirstOrDefault(stock => stock.Color == item.Color && stock.Size == item.Size);
                if (stock is null) { continue; }


                if (item.Quantity > stock.StockQuantity)
                {
                    Console.WriteLine($"Sold out {stock.Id}");
                    continue;

                }
                order.TotalAmount += stock.Price;

                OrderItem OrderItem = _mapper.Map<OrderItem>(item);
                OrderItem.Id = Guid.NewGuid();
                OrderItem.OrderId = order.Id;
                OrderItem.StockId = stock.Id;

                OrderItem.Quantity = item.Quantity;
                Console.WriteLine($"BEFORE CREATE");

                _orderItemService.CreateOne(OrderItem);
                stock.StockQuantity -= item.Quantity;
                _stockService.UpdateOne(stock);
            }



            // save order in order database 
            // _stockService.FindByProductId(newOrder);

        }
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
