using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowzinSaravan.ViewModel.ProductTypes;

namespace TowzinSaravan.DataLayer.Repositories
{
    public interface IProductTypeRepository
    {
        List<ProductTypes> GetAllProductTypes();
        List<ListProductTypeViewModel> GetProductType(string filter = "");
        //IEnumerable<ProductTypes> GetOrdersByFilter(string parameter);
        string GetProductTypeById(int ProductTypeId);
        //bool InsertOrder(Orders order);
        //bool UpdateOrder(Orders order);
        //bool DeleteOrder(Orders order);
        //bool DeleteOrder(int orderId);
    }
}
