using CuoreUI.Controls;
using JH_Manager.ComponentUC;
using JH_Manager.ComponentUC.SousComponents;
using JH_Manager.DataManager;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JH_Manager
{
    public partial class Form1 : Form
    {
        private cuiButton currentButton;
        public static UserControl usc;
        private LoadingUC loadUC;
        private readonly Timer timer;

        public static int IndexActive;
        public static UserControl[] uscActive;

        public Form1()
        {
            DoubleBuffered = true;

            Bigdata.Init();
            IndexActive = 0;

            InitializeComponent();

            usc = new ComponentUC.LoginUC(this)
            {
                Location = new Point(0, 49)
            };
            Controls.Add(usc);
            usc.BringToFront();
            currentButton = null;

            this.Load += PaintForm;

            this.Load += PaintLoadNow;

            timer = new Timer()
            {
                Interval = 10,
                Enabled = true,
            };

            timer.Tick += AnimationLoadingForm;
            this.Opacity = 0;
            timer.Start();

            // Notification
            notifBox.MouseLeave += LeaveNotifMouse;
            notifBox.Visible = false;
            notifBox.Location = new Point(429, 45);
            btnRupture.Visible = true;

            uscActive = new UserControl[7] {
                new ComponentUC.HomeUC(), // 0
                new ComponentUC.ShopUC(), // 1
                new ComponentUC.StockG(), // 2
                new ComponentUC.NewUC(), // 3
                new ComponentUC.EditUC(), // 4
                new ComponentUC.ManagerUserUC(), // 5
                new ComponentUC.CategorUC(), // 6
            };

            foreach (UserControl uc in uscActive)
            {
                uc.Size = panelContainer.Size;
                uc.Location = new Point(0, 0);
            }

        }

        private void LeaveNotifMouse(object sender, EventArgs e)
        {
            if (!notifBox.ClientRectangle.Contains(notifBox.PointToClient(MousePosition)))
            {
                notifBox.Visible = false;
                btnNotif.Rounding = new Padding(8);
            }
        }

        private void AnimationLoadingForm(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                Opacity += 0.1;
            else
            {
                timer.Stop();
                timer.Dispose();
            }
        }

        private void CheckedOutOfStock()
        {
            Bigdata.CheckedOutOfStock();
            btnRupture.Content = $"{Bigdata.OutOfStock.Count} Produit en rupture";

            if (Bigdata.OutOfStock.Count > 0)
            {
                btnAlert.Visible = true;
                btnAlert.BringToFront();
            }
            else
            {
                btnAlert.Visible = false;
                btnNotif.Rounding = new Padding(8);
                notifBox.Visible = false;
            }
        }

        private void PaintLoadNow(object sender, EventArgs e)
        {
            this.Padding = new Padding(100);
            AddShadow(this.Handle);
        }

        private void PaintForm(object sender, EventArgs e)
        {
            int borderRadius = 37;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(this.Width - borderRadius - 1, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(this.Width - borderRadius - 1, this.Height - borderRadius - 1, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, this.Height - borderRadius - 1, borderRadius, borderRadius, 90, 90);

            this.Region = new Region(path);
        }

        private void PanelExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        public bool ActiveButton(object sender)
        {
            if (currentButton == (cuiButton)sender || loadUC?.isRun == true) return true;

            DisableAllButton();

            currentButton = (cuiButton)sender;
            currentButton.BackColor = Color.Transparent;
            currentButton.ForeColor = Color.White;
            currentButton.HoverBackground = Color.FromArgb(64, 64, 64);
            currentButton.HoveredImageTint = Color.White;
            currentButton.ImageTint = Color.White;
            if ((string)currentButton.Tag == "Dec") return false;
            currentButton.NormalBackground = Color.FromArgb(32, 32, 32);
            currentButton.PressedBackground = Color.FromArgb(32, 32, 32);
            currentButton.PressedImageTint = Color.White;
            return false;
        }

        private void DisableAllButton()
        {
            foreach (Control ctrl in panelNAV.Controls)
            {
                if (ctrl.GetType() == typeof(cuiButton))
                {
                    if (ctrl.Tag.Equals("Dec")) continue;
                    cuiButton b = (cuiButton)ctrl;
                    b.BackColor = Color.Transparent;
                    b.NormalBackground = Color.Transparent;
                    b.ForeColor = Color.Black;
                    b.HoverBackground = Color.Transparent;
                    b.PressedBackground = Color.Transparent;
                    b.CheckedBackground = Color.Transparent;
                    b.CheckedImageTint = Color.White;
                    if (ctrl.Tag.Equals("adminBtn")) continue;
                    b.ImageTint = Color.Black;
                    b.HoveredImageTint = Color.Black;

                }
            }
        }


        // changement de fenetre
        public static void GlobalReturn(UserControl c)
        {
            c.Parent.Controls.Add(usc = uscActive[IndexActive]);
            c.Parent.Controls.Remove(c);
            c.Dispose();
        }

        private void FirstTransition()
        {
            loadUC = new ComponentUC.SousComponents.LoadingUC();
            loadUC.Parent?.Controls.Remove(this);
            Controls.Add(loadUC);
            loadUC.ToResize(usc.Size, usc.Location);

            loadUC.Play(panelNAV, panelContainer);
            panelContainer.Controls.Remove(usc);
            usc.Dispose();

            loadUC?.SetTimeInterval(1);
        }

        private void TransitionPanel(int i)
        {
            panelContainer.Controls.Remove(usc);
            IndexActive = i; // Index du home
            switch (i)
            {
                case 0:
                    HomeUC c = (HomeUC)uscActive[0];
                    c.RefreshUC();
                    break;
                case 1:
                    ShopUC a = (ShopUC)uscActive[1];
                    a.RefreshUC();
                    break;
                case 4:
                    EditUC b = (EditUC)uscActive[4];
                    b.RefreshUC();
                    break;
                case 6:
                    CategorUC d = (CategorUC)uscActive[6];
                    d.RefreshUC();
                    break;

            }
            usc = uscActive[i];

            CheckedOutOfStock();
            panelContainer.Controls.Add(usc);
            usc.SendToBack();
        }

        // Fonctions des bouttons
        private void BtnHome_Click(object sender, EventArgs e)
        {
            if (ActiveButton(sender)) return;
            TransitionPanel(0);
        }

        private void BtnShop_Click(object sender, EventArgs e)
        {
            if (ActiveButton(sender)) return;
            TransitionPanel(1);
        }
        private void BtnStock_Click(object sender, EventArgs e)
        {
            if (ActiveButton(sender)) return;
            TransitionPanel(2);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (ActiveButton(sender)) return;
            TransitionPanel(3);
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            if (ActiveButton(sender)) return;
            TransitionPanel(4);
        }
        private void BtnUser_Click(object sender, EventArgs e)
        {
            if (ActiveButton(sender)) return;
            TransitionPanel(5);
        }
        private void BtnCat_Click(object sender, EventArgs e)
        {
            if (ActiveButton(sender)) return;
            TransitionPanel(6);
        }
        private void BtnRupture_Click(object sender, EventArgs e)
        {
            BtnNotif_Click(sender, e); // referme

            // Actualisation
            panelContainer.Controls.Remove(usc);
            usc = new ComponentUC.RuptureUC();
            panelContainer.Controls.Add(usc);
            usc.SendToBack();

        }
        // Fin des bouttons

        private void BtnLogOut_Click(object sender, EventArgs e)
        {

            loadUC.SetTimeInterval(1);
            panelNAV.Visible = false;

            panelContainer.Controls.Remove(usc);
            usc = new ComponentUC.LoginUC(this)
            {
                Location = new Point(0, 49)
            };
            Controls.Add(usc);
            usc.BringToFront();

            // Desactive la notification
            btnNotif.Visible = false;
            btnAlert.Visible = false;
        }
        //Connection success
        public void ConnectUser()
        {
            // Cleaner le panel entier
            FirstTransition();

            // Affiche le boutton de notification
            btnNotif.Visible = true;
            // Charger les composants
            usc = uscActive[IndexActive];
        }

        // Control fenetres

        private bool dragging = false;
        private Point dragginCursor;
        private Point dragginForm;
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnReduce_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DownDrag(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragginCursor = Cursor.Position; // recuperer la position du curseur
            dragginForm = this.Location;
        }

        private void MoveDrag(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragginCursor));
                this.Location = Point.Add(dragginForm, new Size(diff));
            }
        }

        private void UpDrag(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            this.Padding = new Padding(20);
            AddShadow(this.Handle);
        }

        // Utiliser les API Windows pour ajouter une ombre
        private const int CS_DROPSHADOW = 0x00020000;
        private const int GCL_STYLE = -26;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SetClassLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetClassLong(IntPtr hWnd, int nIndex);

        private void AddShadow(IntPtr handle)
        {
            SetClassLong(handle, GCL_STYLE, GetClassLong(handle, GCL_STYLE) | CS_DROPSHADOW);
        }

        // Boutton de notification
        private void BtnNotif_Click(object sender, EventArgs e)
        {
            // ... Logique du ruptage de stock
            CheckedOutOfStock();

            if (Bigdata.OutOfStock.Count <= 0) return;

            if (!notifBox.Visible)
            {
                // Modification du boutton
                btnNotif.Rounding = new Padding(8, 8, 0, 8);

                // Debut de l'animation
                notifBox.Visible = true;
                notifBox.BringToFront();
            }
            else
            {
                btnNotif.Rounding = new Padding(8);
                notifBox.Visible = false;
            }
        }

        private void BtnAlert_Click(object sender, EventArgs e)
        {
            BtnNotif_Click(sender, e);
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            Database.Save();
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            Database.Load();
        }

        private void btnInfoBuy_Click(object sender, EventArgs e)
        {
            BtnNotif_Click(sender, e); // referme

            // Actualisation
            panelContainer.Controls.Remove(usc);
            usc = new InfoDemoUC(); 
            panelContainer.Controls.Add(usc);
            usc.SendToBack();
        }
    }
}



















