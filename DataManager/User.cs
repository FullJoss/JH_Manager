using System;
using System.Windows.Forms;


namespace JH_Manager.DataManager
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }

        private Timer timer;
        public DateTime time { get; set; }
        public DateTime timeBegin { get; set; }
        public long NMod { get; set; }

        public User(string name, string password, DateTime timeBegin, long nMod)
        {
            Name = name;
            Password = password;
            timer = new Timer()
            {
                Interval = 5000,
                Enabled = true,
            };
            timer.Tick += IncrementTime;
            this.timeBegin = timeBegin;
            NMod = nMod;
        }

        private void IncrementTime(object sender, EventArgs e)
        {
            time = time.AddSeconds(5);
        }

        public void Connect()
        {
            timer.Enabled = true;
            timer.Start();
        }

        public void Deconnect()
        {
            timer.Enabled = false;
            timer.Stop();
        }
    }
}
