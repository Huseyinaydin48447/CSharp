using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();

           
        }

        FinancialCrmDbEntities1 dataBase=new FinancialCrmDbEntities1();
        public int userId;

        private void SharedTimer_TimerTick(object sender, EventArgs e)
        {
            lblDateClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            
            userId = 1; 

            var user = dataBase.Users.FirstOrDefault(x => x.UserId == userId);

            if (user != null)
            {
                lblUserNameSurname.Text = user.UserNameSurname;
                txtUsername.Text = user.Username;
                txtPassword.Text = user.UserPassword;
                txtUserNameSurname.Text = user.UserNameSurname;
                txtMail.Text = user.UserMail;
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı! UserId = " + userId);
            }

            lblDateClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }


        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbPassword.Text == "Göster")
            {
                cbPassword.Text = "Gizle";
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                cbPassword.Text = "Göster";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == txtNewPasswordAgain.Text)
            {
                int id = userId;
                var values = dataBase.Users.Find(id);

                if (values.UserPassword == txtOldPassword.Text)
                {
                    values.UserPassword = txtNewPassword.Text;
                    dataBase.SaveChanges();
                    MessageBox.Show("Şifreniz güncellenmiştir.\nYeni Şifreniz: " + txtNewPassword.Text + "\nLütfen uygulamayı yeniden başlatınız.", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Şifreniz yanlış!", "Hata", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Şifreler aynı değil!", "Hata", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.userId = this.userId;
            frm.Show();
            this.Hide();
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
          
        }

        private void btnBankProcesses_Click(object sender, EventArgs e)
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şu an zaten Ayarlar formundasınız.", "Bilgilendirme", MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
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

        private void lblDateClock_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblUserNameSurname_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
