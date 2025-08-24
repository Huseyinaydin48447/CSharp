
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
using System.Windows.Forms.DataVisualization.Charting;

namespace FinancialCrm
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();

          
        }

        FinancialCrmDbEntities1 dataBase = new FinancialCrmDbEntities1();
        public int counter = 0;
        public int userId;

    

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = dataBase.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.HasValue ? totalBalance.Value.
                ToString("N2") + " ₺" : "0,00 ₺";

            var lastBankProcessAmount = dataBase.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString();

            

            // Chart 1
            var bankData = dataBase.Banks .Select(x => new
                                             {
                                                 x.BankTitle,
                                                 x.BankBalance
                                             }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Bankalar");
            foreach (var data in bankData)
            {
                series.Points.AddXY(data.BankTitle, data.BankBalance);
            }

            // Chart2
            var billData = dataBase.Bills.Select(x => new
                                             {
                                                 x.BillTitle,
                                                 x.BillAmount
                                             }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            foreach (var data in billData)
            {
                series2.Points.AddXY(data.BillTitle, data.BillAmount);
            }

         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter % 4 == 1)
            {
                var electricBill = dataBase.Bills.Where(x => x.BillTitle == "Elektrik Faturası" ).Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text = electricBill.ToString() + " ₺";
            }
            if (counter % 4 == 2)
            {
                var electricBill = dataBase.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası" ).Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = electricBill.ToString() + " ₺";
            }
            if (counter % 4 == 3)
            {
                var electricBill = dataBase.Bills.Where(x => x.BillTitle == "Su Faturası" ).Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturası";
                lblBillAmount.Text = electricBill.ToString() + " ₺";
            }
            if (counter % 4 == 0)
            {
                var electricBill = dataBase.Bills.Where(x => x.BillTitle == "İnternet Faturası" ).Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "İnternet Faturası";
                lblBillAmount.Text = electricBill.ToString() + " ₺";
            }
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şu an zaten Dashboard formundasınız.", "Bilgilendirme", MessageBoxButtons.OK,
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
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalBalance_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLastBankProcessAmount_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}