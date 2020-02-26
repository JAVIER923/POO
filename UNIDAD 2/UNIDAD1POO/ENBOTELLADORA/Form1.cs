using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENBOTELLADORA
{
    public partial class FrmEmbotelladora : Form
    {
        public FrmEmbotelladora()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            ClassBotella objbotella = new ClassBotella();

            objbotella.nivelLlenado = Convert .ToInt32 (  txtNivelLlenado.Text);
            MessageBox .Show ( objbotella.verificarLlenado());
        }
    }
}
