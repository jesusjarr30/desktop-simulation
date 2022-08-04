using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void open_new_form(Form f)
        {
            f.TopLevel = false;
            this.pan_fondo.Controls.Add(f);
            f.Show();
        }
        private void btn_explorador_Click(object sender, EventArgs e)
        {
            Explorador f = new Explorador();
            open_new_form(f);
        }
    }
}
