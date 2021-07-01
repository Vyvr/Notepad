using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class FormMain : Form
    {
        private string CurrentFileName;
        private string CurrentFilePath;
        private bool Written = false;
        public FormMain()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(!Written)
            {
                Written = true;
                this.Text += "*";
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Czy chcesz zapisać zmiany przed zamknięciem?", "UWAGA!",  MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                saveAsToolStripMenuItem_Click(null, null);
            }
            this.Close(); // zamyka okno (zamyka okno, potem aplikacje)
            // Application.Exit(); // to samo tylko bardziej wymuszone (zamknięcie aplikacji) 
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentFileName = "Nowy plik";
            this.Text = CurrentFileName;
            richTextBoxEdit.Clear(); // Czyści text boxa
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Pliki tekstowe | *.txt";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                CurrentFileName = Path.GetFileName(ofd.FileName);
                this.Text = CurrentFileName;
                CurrentFilePath = ofd.FileName;
                richTextBoxEdit.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)  // do dokończenia
        {
            if(CurrentFileName == null)
            {
                saveAsToolStripMenuItem_Click(null, null);
            }
            else
            {
                File.WriteAllText(CurrentFilePath, richTextBoxEdit.Text);
                this.Text = CurrentFileName;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Pliki tekstowe | *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, richTextBoxEdit.Text);
                CurrentFileName = Path.GetFileName(sfd.FileName);
                this.Text = CurrentFileName;
            }
            this.Text = CurrentFileName;
            CurrentFilePath = sfd.FileName;
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfig fc = new FormConfig();

            fc.ConfigTextColor = richTextBoxEdit.ForeColor;
            fc.ConfigBackgroundColor = richTextBoxEdit.BackColor;
            fc.ConfigFont = richTextBoxEdit.Font;

            if(fc.ShowDialog() == DialogResult.OK)
            {
                richTextBoxEdit.ForeColor = fc.ConfigTextColor;
                richTextBoxEdit.BackColor = fc.ConfigBackgroundColor;
                richTextBoxEdit.Font = fc.ConfigFont;
            }
        }
    }
}
