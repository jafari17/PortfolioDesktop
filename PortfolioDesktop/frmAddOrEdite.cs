using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PortfolioDesktop
{
    public partial class frmAddOrEdite : Form
    {
        private IPortfolioRepository repository;
        public int Id = 0;
        
        public frmAddOrEdite()
        {
            InitializeComponent();
            repository = new PortfolioRepository();
        }

        private void frmAddOrEdite_Load(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                this.Text = "add tarde";

            }
            else
            {
                this.Text = "Edit trade";
                DataTable dt = repository.SelcetRow(Id);
                txtEntryDate.Text = dt.Rows[0][1].ToString();
                txtTypePosition.Text = dt.Rows[0][2].ToString();
                txtCurrency.Text = dt.Rows[0][3].ToString();
                txtEntryPrice.Text = dt.Rows[0][4].ToString();
                txtDollarValue.Text = dt.Rows[0][5].ToString();
                txtCoinValue.Text = dt.Rows[0][6].ToString();
                txtNotes.Text = dt.Rows[0][7].ToString();
                btnSabmit.Text = "Edit";
            }


        }

        private void btnSabmit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                bool isSuccess; 

                if (Id == 0)
                {
                    isSuccess = repository.Insert(txtEntryDate.Value, txtTypePosition.Text, txtCurrency.Text, txtEntryPrice.Value, txtDollarValue.Value, txtCoinValue.Value, txtNotes.Text, DateTime.Now, DateTime.Now);

                }
                else
                {
                    isSuccess = repository.Update(Id,txtEntryDate.Value, txtTypePosition.Text, txtCurrency.Text, txtEntryPrice.Value, txtDollarValue.Value, txtCoinValue.Value, txtNotes.Text, DateTime.Now, DateTime.Now);
                }


                if (isSuccess == true)
                {
                    MessageBox.Show("The operation was successful", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("The operation failed333", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        bool ValidateInputs()
        {


            if (txtEntryDate.Text == "")
            {

                MessageBox.Show("EntryDate null", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTypePosition.Text == "")
            {
                MessageBox.Show(" TypePosition null", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtCurrency.Text == "")
            {
                MessageBox.Show(" Currency null", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtEntryPrice.Value == 0)
            {
                MessageBox.Show(" EntryPrice null", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtDollarValue.Text == "")
            {
                MessageBox.Show(" DollarValue null", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtCoinValue.Value == 0)
            {
                MessageBox.Show("CoinValue null ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        decimal handleRatio(decimal DollarValue, decimal EntryPrice)
        {
            if (DollarValue != 0 && EntryPrice != 0)
            {
                decimal CoinValue = (DollarValue / EntryPrice);
                return CoinValue;
            }
            return 0;
        }

        private void btnHandelCoin_Click(object sender, EventArgs e)
        {
            txtCoinValue.Value = handleRatio(txtDollarValue.Value, txtEntryPrice.Value);

        }
    }
}