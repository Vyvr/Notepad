using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class FormConfig : Form
    {
        public Color ConfigTextColor
        {
            get
            {
                return buttonConfigTextColor.BackColor;
            }
            set
            {
                buttonConfigTextColor.BackColor = value;
                buttonConfigFontSize.ForeColor = value;
            }
        }

        public Color ConfigBackgroundColor
        {
            get
            {
                return buttonConfigBackground.BackColor;
            }
            set
            {
                buttonConfigBackground.BackColor = value;
                buttonConfigFontSize.BackColor = value;
            }
        }

        public Font ConfigFont
        {
            get
            {
                return buttonConfigFontSize.Font;
            }
            set 
            {
                buttonConfigFontSize.Font = value;
            }
        }
        public FormConfig()
        {
            InitializeComponent();
        }

        private void buttonConfigTextColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            cd.Color = ConfigTextColor;

            if(cd.ShowDialog() == DialogResult.OK)
            {
                ConfigTextColor = cd.Color;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonConfigBackground_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            cd.Color = ConfigBackgroundColor;

            if(cd.ShowDialog() == DialogResult.OK)
            {
                ConfigBackgroundColor = cd.Color;
            }
        }

        private void buttonConfigFontSize_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            fd.Font = ConfigFont;

            if(fd.ShowDialog() == DialogResult.OK)
            { 
                ConfigFont = fd.Font;
            }
        }
    }
}
