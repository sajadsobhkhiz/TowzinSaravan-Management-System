using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using TowzinSaravan.DataLayer.Repositories;
using TowzinSaravan.Utility.Convertor;

namespace TowzinSaravan.DataLayer.Services
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private TowzinSaravan_DBEntities db;

        public InvoiceRepository(TowzinSaravan_DBEntities context)
        {
            db = context;
        }

        public Invoices GetInvoiceById(int invoiceId)
        {
            return db.Invoices.Find(invoiceId);
        }
        public List<Invoices> GetAllInvoices()
        {
            return db.Invoices.OrderByDescending(i => i.InvoiceNumber).ToList();
        }


        public int GetSumOfOrder(int orderId)
        {

            //return db.Invoices.GroupBy(i=> i.OrderId).Select(g=> g.Sum(i=>i.DestinationNetWeight)).ToList();
            return db.Invoices.Where(a => a.OrderId == orderId && a.Done)
                         .GroupBy(a => a.OrderId)
                         .Select(g => g.Sum(a => a.NetWeight)).SingleOrDefault();

        }

        public List<InvoiceTotal> GetTotalInvoices()
        {
            return db.InvoiceTotal.ToList();
        }

        public bool InsertInvoice(Invoices invoice)
        {
            try
            {
                db.Invoices.Add(invoice);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateInvoice(Invoices invoice)
        {
            try
            {
                db.Entry(invoice).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteInvoice(Invoices invoice)
        {
            try
            {
                db.Entry(invoice).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteInvoice(int invoiceId)
        {
            try
            {
                var invoice = GetInvoiceById(invoiceId);
                DeleteInvoice(invoice);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int MakeNewInvoiceNumber()
        {
            return db.Invoices.OrderByDescending(i => i.FirstScaleDate).ThenByDescending(i => i.FirstScaleTime).ThenByDescending(i => i.InvoiceNumber).Select(i => i.InvoiceNumber).FirstOrDefault();
            
         }
    }
}
