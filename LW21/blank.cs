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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace LW21
{
    public partial class blank : Form
    {
        public string docName = "";
        private string bufferText = "";
        public bool isSaved = false;

        public blank()
        {
            InitializeComponent();
            statusBarTime.Text = Convert.ToString(System.DateTime.Now.ToLongTimeString());
            statusBarTime.ToolTipText = Convert.ToString(System.DateTime.Now.ToLongTimeString());
        }

        public void Cut()
        {
            this.bufferText = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";
        }

        public void Copy()
        {
            this.bufferText = richTextBox1.SelectedText;
        }

        public void Paste()
        {
            richTextBox1.SelectedText = bufferText;
        }

        public void SelectAll()
        {
            richTextBox1.SelectAll();
        }

        public void Delete()
        {
            richTextBox1.SelectedText = "";
            this.bufferText = "";
        }

        private void cmenuCut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void cmenuCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void cmenuPaste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void cmenuDelete_Click(object sender, EventArgs e)
        {
            Delete();

        }

        private void cmenuSelectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }


        public void Open(string openFileName)
        {
            if (openFileName == "")
            {
                return;
            }
            else
            {
                StreamReader sr = new StreamReader(openFileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                docName = openFileName;


            }
        }

        public void Save(string saveFileName)
        {

            if (saveFileName == "")
            {
                return;
            }
            else
            {

                StreamWriter sw = new StreamWriter(saveFileName);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
                docName = saveFileName;
            }
        }

        private void blank_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (isSaved == true)
                if (MessageBox.Show("Do you want to save changes in " + this.docName + "?",
                    "Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Save(this.docName);
                }
        }

        private void blank_Load(object sender, EventArgs e)
        {
            statusBarAmount.Text = "Аmount of symbols: " + richTextBox1.Text.Length.ToString();
        }

        private void richTextBox1_TextChanged(object sender, System.EventArgs e)
        {

            statusBarAmount.Text = "Аmount of symbols: " + richTextBox1.Text.Length.ToString();
        }
    }
}