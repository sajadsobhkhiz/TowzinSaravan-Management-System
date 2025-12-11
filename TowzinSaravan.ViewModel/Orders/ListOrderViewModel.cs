using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowzinSaravan.ViewModel.Orders
{
    public class ListOrderViewModel
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public int ProductTypeId { get; set; }
        public int OrderNumber { get; set; }
        public int Amount { get; set; }
        public bool IsSpecial { get; set; }
        public bool IsDust { get; set; }
    }
}
