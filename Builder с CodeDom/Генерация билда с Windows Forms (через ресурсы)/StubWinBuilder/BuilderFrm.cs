namespace StubWinBuilder
{
    using System;
    using System.Windows.Forms;

    public partial class BuilderFrm : Form
    {
        public BuilderFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SourceEditor.TestFunction(textBox1.Text, textBox2.Text);
        }
    }
}
