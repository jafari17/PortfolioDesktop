using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace PortfolioDesktop
{

    internal class PortfolioRepository : IPortfolioRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=Portfolio_DB;Integrated Security=true";

        public bool Delete(int Id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Delete From Portfolio_T where Id=@Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Insert(DateTime EntryDate, string TypePosition, string Currency, decimal EntryPrice, decimal DollarValue, decimal CoinValue, string Notes, DateTime CreatedFild, DateTime UpdatedFild)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Insert Into Portfolio_T (EntryDate,TypePosition,Currency,EntryPrice,DollarValue,CoinValue,Notes,CreatedFild,UpdatedFild) values (@EntryDate,@TypePosition,@Currency,@EntryPrice,@DollarValue,@CoinValue,@Notes,@CreatedFild,@UpdatedFild)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EntryDate", EntryDate.Date);
                command.Parameters.AddWithValue("@TypePosition", TypePosition);
                command.Parameters.AddWithValue("@Currency", Currency);
                command.Parameters.AddWithValue("@EntryPrice", EntryPrice);
                command.Parameters.AddWithValue("@DollarValue", DollarValue);
                command.Parameters.AddWithValue("@CoinValue", CoinValue);
                command.Parameters.AddWithValue("@Notes", Notes);
                command.Parameters.AddWithValue("@CreatedFild", CreatedFild);
                command.Parameters.AddWithValue("@UpdatedFild", UpdatedFild);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable Search(string parameter)
        {
            throw new NotImplementedException();
        }

        public DataTable SelcetRow(int Id)
        {
            string query = "Select * From Portfolio_T where Id="+Id;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectAll()
        {
            string query = "Select * From Portfolio_T";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool Update(int Id, DateTime EntryDate, string TypePosition, string Currency, decimal EntryPrice, decimal DollarValue, decimal CoinValue, string Notes, DateTime CreatedFild, DateTime UpdatedFild)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Update Portfolio_T Set EntryDate=@EntryDate,TypePosition=@TypePosition,Currency=@Currency,EntryPrice=@EntryPrice,DollarValue=@DollarValue,CoinValue=@CoinValue,Notes=@Notes,CreatedFild=@CreatedFild,UpdatedFild=@UpdatedFild Where ID=@Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@EntryDate", EntryDate.Date);
                command.Parameters.AddWithValue("@TypePosition", TypePosition);
                command.Parameters.AddWithValue("@Currency", Currency);
                command.Parameters.AddWithValue("@EntryPrice", EntryPrice);
                command.Parameters.AddWithValue("@DollarValue", DollarValue);
                command.Parameters.AddWithValue("@CoinValue", CoinValue);
                command.Parameters.AddWithValue("@Notes", Notes);
                command.Parameters.AddWithValue("@CreatedFild", CreatedFild);
                command.Parameters.AddWithValue("@UpdatedFild", UpdatedFild);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
