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
    public partial class UserControlVinyls : UserControl
    {
        ProjektDbContext _context = new ProjektDbContext();
        public UserControlVinyls()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void UserControlVinyls_Load(object sender, EventArgs e)
        {
            vinylBindingSource.DataSource = _context.Vinyls.ToList();
        }
    }
}
