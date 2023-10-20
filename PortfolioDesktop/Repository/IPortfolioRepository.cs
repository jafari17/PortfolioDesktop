using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioDesktop
{
    internal interface IPortfolioRepository
    {
        DataTable SelectAll();
        DataTable SelcetRow(int Id);
        DataTable Search(string parameter);
        bool Insert(DateTime EntryDate, string TypePosition, string Currency, decimal EntryPrice, decimal DollarValue, decimal CoinValue, string Notes, DateTime CreatedFild, DateTime UpdatedFild);
        bool Update(int Id, DateTime EntryDate, string TypePosition, string Currency, decimal EntryPrice, decimal DollarValue, decimal CoinValue, string Notes, DateTime CreatedFild, DateTime UpdatedFild);
        bool Delete(int Id);
    }
}
