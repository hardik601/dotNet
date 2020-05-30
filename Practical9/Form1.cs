using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            float size = lblFont.Font.Size;
            string font = lblFont.Font.OriginalFontName;
            lblFont.Font = new Font(font,size + 5);
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            float size = lblFont.Font.Size;
            string font = lblFont.Font.OriginalFontName;
            if(size>6)
                lblFont.Font = new Font(font, size - 5);
        }
    }
}
