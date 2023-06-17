using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Reflection;

namespace LW21
{
    public partial class frmmain : Form
    {
        private int openDocuments = 0;

        public frmmain()
        {
            InitializeComponent();
            menuSave.Enabled = false;
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            blank frm = new blank();
            frm.docName = "Untitled" + ++openDocuments;
            frm.Text = frm.docName;
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var frm = new blank();
                frm.Open(openFileDialog1.FileName);
                frm.MdiParent = this;
                frm.docName = openFileDialog1.FileName;
                frm.Text = frm.docName;
                frm.Show();
            }

            menuSave.Enabled = true;
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            var frm = (blank)this.ActiveMdiChild;

            frm.richTextBox1.SaveFile(frm.docName + ".rtf", RichTextBoxStreamType.RichText);

            frm.isSaved = true;
        }


        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            var frm = (blank)this.ActiveMdiChild;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SaveFile(frm.docName + ".rtf", RichTextBoxStreamType.RichText);
                frm.MdiParent = this;
                frm.docName = saveFileDialog1.FileName;
                frm.Text = frm.docName;
            }

            menuSave.Enabled = true;
            frm.isSaved = true;
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuCut_Click(object sender, EventArgs e)
        {
            var frm = (blank)this.ActiveMdiChild;
            frm.Cut();
        }

        private void menuCopy_Click(object sender, EventArgs e)
        {
            var frm = (blank)this.ActiveMdiChild;
            frm.Copy();
        }

        private void menuPaste_Click(object sender, EventArgs e)
        {
            var frm = (blank)this.ActiveMdiChild;
            frm.Paste();
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            var frm = (blank)this.ActiveMdiChild;
            frm.Delete();
        }

        private void menuSelectAll_Click(object sender, EventArgs e)
        {
            var frm = (blank)this.ActiveMdiChild;
            frm.SelectAll();
        }


        private void menuInsertImage_Click(object sender, EventArgs e)
        {
            var frm = (blank)this.ActiveMdiChild;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog2.FileName;

                if (File.Exists(imagePath))
                {
                    Image image = Image.FromFile(imagePath);
                    Clipboard.SetDataObject(image, true);
                    frm.richTextBox1.Paste();
                }
            }
        }

        private void menuSelectFont_Click(object sender, EventArgs e)
        {
            var frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            fontDialog1.ShowColor = true;
            fontDialog1.Font = frm.richTextBox1.SelectionFont;
            fontDialog1.Color = frm.richTextBox1.SelectionColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionFont = fontDialog1.Font;
                frm.richTextBox1.SelectionColor = fontDialog1.Color;
            }
            frm.Show();
        }

        private void menuSelectColor_Click(object sender, EventArgs e)
        {
            var frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            colorDialog1.Color = frm.richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionColor = colorDialog1.Color;
            }
            frm.Show();
        }

        private void menuArrangeIcons_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void menuCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void menuTileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuTileVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }
    }
}
