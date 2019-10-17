using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        /// <summary>
        /// open_Click_1 är kopplad till Öppna i Arkiv och användingen är att öppna en txt fil till programmet
        /// </summary>
        /// <param name="args"></param>
        private void open_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                richTextBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
            }

        }

        /// <summary>
        /// saveAs_Click är kopplad till Spara som i Arkiv och den används till att spara vad du har skrivit till en txt fil
        /// </summary>
        /// <param name="args"></param>
        private void saveAs_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = saveFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }

        /// <summary>
        /// close_Click är kopplad till Stäng i Arkiv och används till att stänga ner Editor när man är klar med programmet
        /// </summary>
        /// <param name="args"></param>
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
