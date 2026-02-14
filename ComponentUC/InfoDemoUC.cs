using System;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC
{
    public partial class InfoDemoUC : UserControl
    {
        public InfoDemoUC()
        {
            InitializeComponent();
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Index active : {Form1.IndexActive}");

            Form1.GlobalReturn(this);
        }
    }
}
