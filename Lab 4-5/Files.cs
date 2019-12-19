using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Files
{
    public partial class Files : Form
    {
        public Files()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Text files|*.txt";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stopwatch t = new Stopwatch();
                t.Start();
                string text = File.ReadAllText(fd.FileName);
                char[] separators = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' };
                string[] textArray = text.Split(separators);
                foreach (string strTemp in textArray)
                {
                    string str = strTemp.Trim();

                    if (!list.Contains(str)) list.Add(str);
                }

                t.Stop();
                this.textBox1ReadTime.Text = t.Elapsed.ToString();
                this.textBox1FileReadCount.Text = list.Count.ToString();
            }
            else
            {
                MessageBox.Show("You must select a file");
            }

        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonExact_Click(object sender, EventArgs e)
        {
            string word = this.textBoxFind.Text.Trim();
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                string wordUpper = word.ToUpper();
                List<string> tempList = new List<string>();
                Stopwatch t = new Stopwatch();
                t.Start();
                foreach (string str in list)
                {
                    if (str.ToUpper().Contains(wordUpper))
                    {
                        tempList.Add(str);
                    }
                }
                t.Stop();
                this.textBoxExactTime.Text = t.Elapsed.ToString();
                this.listBoxResult.BeginUpdate();
                this.listBoxResult.Items.Clear();
                foreach (string str in tempList)
                {
                    this.listBoxResult.Items.Add(str);
                }
                this.listBoxResult.EndUpdate();
            }
            else
            {
                MessageBox.Show("You must select a file and enter a word to search");
            }

        }

        private void buttonApprox_Click(object sender, EventArgs e)
        {
            string word = this.textBoxFind.Text.Trim();
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                int maxDist;
                if (!int.TryParse(this.textBoxMaxDist.Text.Trim(), out maxDist))
                {
                    MessageBox.Show("Maximum distance required");
                    return;
                }
                if (maxDist < 1 || maxDist > 5)
                {
                    MessageBox.Show("The maximum distance must be between 1 and 5");
                    return;
                }
                string wordUpper = word.ToUpper();
                List<Tuple<string, int>> tempList = new List<Tuple<string, int>>();
                Stopwatch t = new Stopwatch();
                t.Start();
                foreach (string str in list)
                {
                    int dist = EditDistance.Distance(str.ToUpper(), wordUpper);
                    if (dist <= maxDist)
                    {
                        tempList.Add(new Tuple<string, int>(str, dist));
                    }
                }
                t.Stop();
                this.textBoxApproxTime.Text = t.Elapsed.ToString();
                this.listBoxResult.BeginUpdate();
                this.listBoxResult.Items.Clear();
                foreach (var x in tempList)
                {
                    string temp = x.Item1 + "(distance =" + x.Item2.ToString() + ")";
                    this.listBoxResult.Items.Add(temp);
                }
                this.listBoxResult.EndUpdate();
            }
            else
            {
                MessageBox.Show("You must select a file and enter a word to search");
            }
        }

        private void Files_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }

}