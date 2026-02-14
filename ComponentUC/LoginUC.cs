using System;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC
{
    public partial class LoginUC : UserControl
    {
        private Form1 frm;
        public LoginUC(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;

            // Optimisation
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            if (pName.Content == Bigdata.user.Name && pPswd.Content == Bigdata.user.Password)
            {
                frm.ConnectUser();

                Bigdata.user.Connect();

                frm.Controls.Remove(this);
                Dispose();
            }
            else MessageBox.Show("Mot de passe ou utilisateur incorecte");
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
