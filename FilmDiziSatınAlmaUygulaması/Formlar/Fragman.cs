using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmDiziSatınAlmaUygulaması.Formlar
{
    public partial class Fragman : MaterialForm
    {
        public Fragman()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Red800, MaterialSkin.Primary.Red900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }

        private void Fragman_Load(object sender, EventArgs e)
        {
          
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
