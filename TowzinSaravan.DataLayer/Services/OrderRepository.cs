using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowzinSaravan.DataLayer.Repositories;
using TowzinSaravan.Utility.Convertor;
using TowzinSaravan.ViewModel.Orders;
using TowzinSaravan.DataLayer.Context;

namespace TowzinSaravan.DataLayer.Services
{
    public class OrderRepository : IOrderRepository
    {

        private TowzinSaravan_DBEntities db;

        public OrderRepository(TowzinSaravan_DBEntities context)
        {
            db = context;
        }

        public List<Orders> GetAllOrders()
        {
            return db.Orders.OrderByDescending(c => c.OrderNumber).ToList();
        }

        public Orders GetOrderById(int orderId)
        {
            return db.Orders.Find(orderId);
        }

        public bool InsertOrder(Orders order)
        {
            try
            {
                db.Orders.Add(order);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateOrder(Orders order)
        {
            try
            {
                db.Entry(order).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteOrder(Orders order)
        {
            try
            {
                db.Entry(order).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteOrder(int orderId)
        {
            try
            {
                var order = GetOrderById(orderId);
                DeleteOrder(order);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public Orders GetOrderByOrderNumberAndOrderDate(int orderNumber, string year)
        {
            return db.Orders.Where(o => o.OrderNumber == orderNumber && o.OrderDate.Year.ToString().Contains(year)).SingleOrDefault();
        }

        public Orders CheckOrderForUpdate(int id, int orderNumber, string year)
        {
            return db.Orders.Where(o => o.OrderNumber == orderNumber && o.OrderDate.Year.ToString().Contains(year) && o.Id != id).SingleOrDefault();
        }

        //public List<ListOrderViewModel> GetAllOrdersView()
        //{
        //    return db.Orders.Select(o => new ListOrderViewModel()
        //    {
        //        Id = o.Id,
        //        OrderDate = o.OrderDate,
        //        CustomerId = o.CustomerId,
        //        ProductTypeId = o.ProductTypeId,
        //        OrderNumber = o.OrderNumber,
        //        Amount = o.Amount,
        //        IsSpecial = o.IsSpecial,
        //        IsDust = o.IsDust

        //    }).OrderByDescending(o => o.OrderNumber).ToList();

        //}


        public List<Orders> GetOrdersByNumber(int number, bool isDust)
        {
            return db.Orders.Where(o => o.OrderNumber == number && o.IsDust == isDust).OrderByDescending(o => o.OrderDate).ThenByDescending(o => o.OrderNumber).ToList();
        }

        public List<Orders> GetWheatOrders()
        {
            return db.Orders.Where(o => o.IsDust == false).OrderByDescending(o => o.OrderDate).ThenByDescending(o => o.OrderNumber).ToList();
        }

        public List<Orders> GetDustOrders()
        {
            return db.Orders.Where(o => o.IsDust == true).OrderByDescending(o => o.OrderDate).ThenByDescending(o=>o.OrderNumber).ToList();
        }

        List<Orders> IOrderRepository.GetOrderByProductTypeId(int productTypeId)
        {
            return db.Orders.Where(o => o.ProductTypeId == productTypeId).OrderBy(o => o.OrderDate).ThenBy(o => o.OrderNumber).ToList();
        }
    }
}
