namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVinyls_Click(object sender, EventArgs e)
        {
            UserControlVinyls ucv = new UserControlVinyls();
            panel1.Controls.Clear();
            panel1.Controls.Add(ucv);
        }

        private void buttonusers_Click(object sender, EventArgs e)
        {
            UserControlUsers ucu = new UserControlUsers();
            panel1.Controls.Clear();
            panel1.Controls.Add(ucu);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Biztosan bezárod?", "Megerõsítés",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                e.Cancel = true;
            }
        }
    }
}