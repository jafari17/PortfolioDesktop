using System.Data;

namespace PortfolioDesktop
{
    public partial class Form1 : Form
    {
        private IPortfolioRepository repository;

        public Form1()
        {
            InitializeComponent();
            repository = new PortfolioRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();
  
        }

        private void BindGrid()
        {
            //dgPortfolio.Columns[0].Visible = false;
            dgPortfolio.DataSource = repository.SelectAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
            CalculateBalanceSheet();
        }

        private void btnNewTrade_Click(object sender, EventArgs e)
        {
            frmAddOrEdite frm = new frmAddOrEdite();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgPortfolio.CurrentRow != null)
            {
                //string name = dgPortfolio.CurrentRow.Cells[1].Value.ToString();
                //string family = dgPortfolio.CurrentRow.Cells[2].Value.ToString();
                //string fullName = name + " " + family;
                if (MessageBox.Show("delete row", "Warnig", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int Id = int.Parse(dgPortfolio.CurrentRow.Cells[0].Value.ToString());
                    repository.Delete(Id);
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("select row");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgPortfolio.CurrentRow != null)
            {
                int Id = int.Parse(dgPortfolio.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEdite frm = new frmAddOrEdite();
                frm.Id = Id;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        public void CalculateBalanceSheet()
        {
            DataTable dataTable = repository.SelectAll();

            int c = dataTable.Columns.Count;

            string xx = dataTable.Rows[0][0].ToString();

            foreach (DataRow row in dataTable.Columns)
            {
                Console.WriteLine("{0} - {1}", row["Id"], row["EntryDate"]);
            }

        }




    }
}