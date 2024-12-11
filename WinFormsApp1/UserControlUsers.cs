using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class UserControlUsers : UserControl
    {
        ProjektDbContext _context = new ProjektDbContext();
        public UserControlUsers()
        {
            InitializeComponent();
            userBindingSource.DataSource = _context.Users.ToList();
            this.Dock = DockStyle.Fill;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var x = (from i in _context.Users where i.Username.Contains(textBox1.Text) select i).ToList();
            userBindingSource.DataSource = x;
        }
    }
}
