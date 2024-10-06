using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prueba_skins2
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Purple200, MaterialSkin.TextShade.WHITE);
        }

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {
            //materialLabel1.Visible = false;
            //materialLabel1.Enabled = false;
        }

        private void materialMaskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            // Oculta el label si el textbox tiene texto
            materialLabel1.Visible = string.IsNullOrEmpty(materialMaskedTextBox2.Text);
        }

        private void materialMaskedTextBox2_Enter(object sender, EventArgs e)
        {
            // Oculta el label cuando el textbox recibe el foco
            materialLabel1.Visible = false;
        }

        private void materialMaskedTextBox2_Leave(object sender, EventArgs e)
        {
            // Muestra el label si el textbox está vacío al perder el foco
            materialLabel1.Visible = string.IsNullOrEmpty(materialMaskedTextBox2.Text);
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void f2_Click(object sender, EventArgs e)
        {
            APP app = new APP();
            app.ShowDialog();
        }
    }
}
