using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowzinSaravan.ViewModel.Orders;

namespace TowzinSaravan.DataLayer.Repositories
{
    public interface IOrderRepository
    {
        List<Orders> GetAllOrders();
        List<Orders> GetWheatOrders();
        List<Orders> GetDustOrders();
        //List<ListOrderViewModel> GetAllOrdersView();
        List<Orders> GetOrdersByNumber(int number, bool isDust);
        List<Orders> GetOrderByProductTypeId(int productTypeId);
        Orders GetOrderById(int orderId);
        Orders GetOrderByOrderNumberAndOrderDate(int orderNumber, string year);
        Orders CheckOrderForUpdate(int id, int orderNumber, string year);
        bool InsertOrder(Orders order);
        bool UpdateOrder(Orders order);
        bool DeleteOrder(Orders order);
        bool DeleteOrder(int orderId);
    }
}
