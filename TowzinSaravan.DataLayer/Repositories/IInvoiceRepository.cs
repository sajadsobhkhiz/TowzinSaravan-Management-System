using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowzinSaravan.DataLayer.Repositories
{
    public interface IInvoiceRepository
    {
        List<Invoices> GetAllInvoices();
        List<InvoiceTotal> GetTotalInvoices();
        Invoices GetInvoiceById(int invoiceId);
        int GetSumOfOrder(int id);
        bool InsertInvoice(Invoices invoice);
        bool UpdateInvoice(Invoices invoice);
        bool DeleteInvoice(Invoices invoice);
        bool DeleteInvoice(int invoiceId);
        int MakeNewInvoiceNumber();

    }
}
