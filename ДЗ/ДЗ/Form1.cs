﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DistanceLibrary;
using System.Threading.Tasks;
using System.Text;

namespace DZ
{
    public partial class DZ : Form
    {
        public DZ()
        {
            InitializeComponent();
        }

        public class ParallelSearchResult
        {
            public string word;
            public int dist;
            public int threadNum;
            public ParallelSearchResult(string w, int d, int t)
            {
                word = w;
                dist = d;
                threadNum = t;
            }
        }

        public class ParallelSearchThreadParam
        {
            public List<string> wordsList;
            public string wordToFind;
            public int maxDist;
            public int threadNum;
            public ParallelSearchThreadParam(List<string> wl, string wf, int m, int t)
            {
                wordsList = wl;
                wordToFind = wf;
                maxDist = m;
                threadNum = t;
            }
        }

        public class MinMax
        {
            public int min;
            public int max;
            public MinMax(int i, int j)
            {
                min = i;
                max = j;
            }
        }

        public List<MinMax> divideSubArrays(int wordsCount, int ThreadCount)
        {
            List<MinMax> result = new List<MinMax>();
            int countInThread = (int)Math.Ceiling(wordsCount / (double)ThreadCount);
            int i = 0;
            while (i < wordsCount)
            {
                MinMax mt = new MinMax(i, i + countInThread);
                if (mt.max > wordsCount)
                {
                    mt.max = wordsCount;
                }
                i += countInThread;
                result.Add(mt);
            }
            return result;
        }

        public static List<ParallelSearchResult> arrayThreadTask(object p)
        {
            ParallelSearchThreadParam param = (ParallelSearchThreadParam)p;
            string wordUpper = param.wordToFind.Trim().ToUpper();
            List<ParallelSearchResult> result = new List<ParallelSearchResult>();
            foreach (string str in param.wordsList)
            {
                int dist = Distance.CalculateDistance(str.ToUpper(), wordUpper);
                if (dist <= param.maxDist)
                {
                    ParallelSearchResult t = new ParallelSearchResult(str, dist, param.threadNum);
                    result.Add(t);
                }
            }
            return result;
        }

        List<string> words = new List<string>();
        private void Button_fileLoad1(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text files|*.txt";
            if (file.ShowDialog() == DialogResult.OK)
            {
                Stopwatch time = new Stopwatch();
                time.Start();

                string text = File.ReadAllText(file.FileName, Encoding.GetEncoding(1251));
                textBox1.Text = text;
                char[] seps = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n', '(', ')' };
                string[] textArray = text.Split(seps);
                foreach (string word in textArray)
                {
                    string trimmedWord = word.Trim();
                    if (!words.Contains(trimmedWord))
                    {
                        words.Add(trimmedWord);
                    }
                }
                time.Stop();
                label_time.Text = time.Elapsed.ToString();
            }
            else
            {
                MessageBox.Show("You must select a file!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_findWord_Click(object sender, EventArgs e)
        {
            string wordToFind = textBox_wordToFind.Text.Trim();
            textBox_wordToFind.Text = wordToFind;
            int maxDistance = Convert.ToInt32(textBox_maxDistance.Text);
            if (!string.IsNullOrEmpty(wordToFind) && words.Count > 0)
            {
                string wordToFindUpper = wordToFind.ToUpper();
                List<string> tempList = new List<string>();

                int threadCount;
                if (!int.TryParse(textBox2.Text.Trim(), out threadCount))
                {
                    threadCount = -1;
                }

                Stopwatch time = new Stopwatch();
                time.Start();

                List<ParallelSearchResult> results = new List<ParallelSearchResult>();
                List<MinMax> arrayDivList = divideSubArrays(words.Count, threadCount);
                Task<List<ParallelSearchResult>>[] tasks = new Task<List<ParallelSearchResult>>[threadCount];
                for (int i = 0; i < threadCount; i++)
                {
                    List<string> tempTaskList = words.GetRange(arrayDivList[i].min, arrayDivList[i].max - arrayDivList[i].min);
                    tasks[i] = new Task<List<ParallelSearchResult>>(arrayThreadTask, new ParallelSearchThreadParam(tempTaskList, wordToFindUpper, maxDistance, i));
                    tasks[i].Start();
                }

                Task.WaitAll(tasks);

                for (int i = 0; i < threadCount; i++)
                {
                    results.AddRange(tasks[i].Result);
                }

                time.Stop();
                labelTimeFind.Text = time.Elapsed.ToString();
                listBox.BeginUpdate();
                listBox.Items.Clear();

                foreach (var x in results)
                {
                    string temp = x.word + " (distance = " + x.dist + ", thread - " + x.threadNum + ")";
                    listBox.Items.Add(temp);
                }
                listBox.EndUpdate();
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DZ_Load(object sender, EventArgs e)
        {

        }
    }
}
