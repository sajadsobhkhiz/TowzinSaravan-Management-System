using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowzinSaravan.DataLayer.Repositories;
using TowzinSaravan.ViewModel.ProductTypes;

namespace TowzinSaravan.DataLayer.Services
{
    public class ProductTypeRepository : IProductTypeRepository
    {
        private TowzinSaravan_DBEntities db;

        public ProductTypeRepository(TowzinSaravan_DBEntities context)
        {
            db = context;
            
        }

        public List<ProductTypes> GetAllProductTypes()
        {
            throw new NotImplementedException();
        }

        public List<ListProductTypeViewModel> GetProductType(string filter = "")
        {
            if (filter == "")
            {
                return db.ProductTypes.Select(p => new ListProductTypeViewModel()
                {
                    Id = p.Id,
                    Type = p.Type
                }).ToList();
            }

            return db.ProductTypes.Where(p => p.Type.Contains(filter)).Select(c => new ListProductTypeViewModel()
            {
                Id = c.Id,
                Type = c.Type
            }).ToList();
        }

        public string GetProductTypeById(int ProductTypeId)
        {
            return db.ProductTypes.Find(ProductTypeId).Type;
        }
    }
}
