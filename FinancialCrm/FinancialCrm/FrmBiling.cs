
using FinancialCrm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;
namespace FinancialCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();

       
        }


        FinancialCrmDbEntities1 dataBase= new FinancialCrmDbEntities1();

        public int userId;

     


        private void FrmBilling_Load(object sender, EventArgs e)
        {

            var values =dataBase.Bills.ToList();
            dataGridView1.DataSource = values;
        
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = dataBase.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title =txtTitle.Text;
            decimal amount=decimal.Parse(txtAmount.Text);
            string period=txtPeriod.Text;

            Bills bills = new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;
            dataBase.Bills.Add(bills);
            dataBase.SaveChanges();

            MessageBox.Show("Ödeme ekleme işlemi başarılı.", "Bilgilendirme", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            var values = dataBase.Bills.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedValue = dataBase.Bills.Find(id);
            dataBase.Bills.Remove(deletedValue);
            dataBase.SaveChanges();

            MessageBox.Show("Ödeme silme işlemi başarılı.", "Bilgilendirme", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            var values = dataBase.Bills.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            decimal amount = decimal.Parse(txtAmount.Text);
            string period = txtPeriod.Text;

            int id = int.Parse(txtId.Text);
            var values = dataBase.Bills.Find(id);

            values.BillTitle =title;
            values.BillAmount = amount;
            values.BillPeriod = period;
           
            dataBase.SaveChanges();

            MessageBox.Show("Ödeme güncelleme işlemi başarılı.", "Bilgilendirme", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

      

        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboardForm = Application.OpenForms["FrmDashboard"] as FrmDashboard;
            if (dashboardForm != null)
            {
                dashboardForm.Show();
                this.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPeriod.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
          
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şu an zaten Faturalar formundasınız.", "Bilgilendirme", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
     
        }

        private void btnBankProcesses_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}