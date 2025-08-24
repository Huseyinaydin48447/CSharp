using FinancialCrm.Models;
using System;
using System.Windows.Forms;
using System.Linq;
namespace FinancialCrm

{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();

            
        }

      
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

       

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //Banka Hesap Bakiyelerini Getirme
            var ziraatBankasiBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").
            Select(y => y.BankBalance).FirstOrDefault();

            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").
            Select(y => y.BankBalance).FirstOrDefault();

            var isBankasiBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").
            Select(y => y.BankBalance).FirstOrDefault();

            lblZiraatBankBalance.Text = ziraatBankasiBalance.ToString() + " ₺";
            lblVakifbankBalance.Text = vakifBankBalance.ToString() + " ₺";
            lblIsBankBalance.Text = isBankasiBalance.ToString() + " ₺";

           


            //// Son 5 Hesap Hareketini Getirme
            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId). Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " - " + bankProcess1.Amount + " ₺";
            lblBankProcess1DateClock.Text = bankProcess1.ProcessDate?.ToString("dd/MM/yyyy ") ?? "";
            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).
                Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " - " + bankProcess2.Amount + " ₺";
            lblBankProcess2DateClock.Text = bankProcess2.ProcessDate?.ToString("dd/MM/yyyy ") ?? "";
            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).
                Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " - " + bankProcess3.Amount + " ₺";
            lblBankProcess3DateClock.Text = bankProcess3.ProcessDate?.ToString("dd/MM/yyyy ") ?? "";
            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).
                Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " - " + bankProcess4.Amount + " ₺";
            lblBankProcess4DateClock.Text = bankProcess4.ProcessDate?.ToString("dd/MM/yyyy ") ?? "";
            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).
                Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " - " + bankProcess5.Amount + " ₺";
            lblBankProcess5DateClock.Text = bankProcess5.ProcessDate?.ToString("dd/MM/yyyy ") ?? "";

           
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

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
          
            frm.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
          
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            Close();
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDateClock_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBankProcess1DateClock_Click(object sender, EventArgs e)
        {

        }

        private void lblBankProcess5DateClock_Click(object sender, EventArgs e)
        {

        }
    }
}
