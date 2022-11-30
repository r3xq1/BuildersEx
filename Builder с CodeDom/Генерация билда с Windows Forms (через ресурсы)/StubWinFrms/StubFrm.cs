namespace StubWinFrms
{
    using System;
    using System.Windows.Forms;

    public partial class StubFrm : Form
    {
        public StubFrm()
        {
            InitializeComponent();
        }

        private void ShowConsoleBtn_Click(object sender, EventArgs e)
        {
            NativeMethods.AllocConsole();
            Console.WriteLine("[CONSOLE]");
        }

        private void ShowMessageBoxBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("[TEST]", "#Title#", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
