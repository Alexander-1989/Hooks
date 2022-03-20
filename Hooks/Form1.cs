using System;
using System.Windows.Forms;

namespace Hooks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            VisibleChanged += (s, e) => Visible = false;
        }

        HotKeys _hotKeys = null;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.HOTKEY)
            {
                System.Diagnostics.Process.Start("https://github.com/");
            }
            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _hotKeys = new HotKeys(Handle, Constants.NOMOD, (int)Keys.NumPad5);

            if (!_hotKeys.Register())
            {
                MessageBox.Show("Register Hot Key failed");
                Application.Exit();
            }
        }
    }
}