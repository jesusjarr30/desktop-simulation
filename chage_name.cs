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
    public partial class chage_name : Form
    {
        public chage_name()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Dato.valor= txb_cadena.Text;
            this.Close();
        }

        private void txb_cadena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
