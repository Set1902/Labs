namespace DZ
{
    partial class DZ
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DZ));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_time = new System.Windows.Forms.Label();
            this.labelTimeFind = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox_wordToFind = new System.Windows.Forms.TextBox();
            this.textBox_maxDistance = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.textBox1.Location = new System.Drawing.Point(12, 165);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 228);
            this.textBox1.TabIndex = 0;
            this.textBox2.Location = new System.Drawing.Point(169, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;

            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(528, 401);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 17);
            this.label_time.TabIndex = 3;

            this.labelTimeFind.AutoSize = true;
            this.labelTimeFind.Location = new System.Drawing.Point(528, 424);
            this.labelTimeFind.Name = "labelTimeFind";
            this.labelTimeFind.Size = new System.Drawing.Size(0, 17);
            this.labelTimeFind.TabIndex = 4;

            this.textBox_wordToFind.Location = new System.Drawing.Point(317, 104);
            this.textBox_wordToFind.Name = "textBox_wordToFind";
            this.textBox_wordToFind.Size = new System.Drawing.Size(100, 22);
            this.textBox_wordToFind.TabIndex = 5;

            this.textBox_maxDistance.Location = new System.Drawing.Point(452, 25);
            this.textBox_maxDistance.Name = "textBox_maxDistance";
            this.textBox_maxDistance.Size = new System.Drawing.Size(100, 22);
            this.textBox_maxDistance.TabIndex = 6;

            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(392, 165);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(383, 228);
            this.listBox.TabIndex = 7;

            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(54, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            this.button2.BackColor = System.Drawing.Color.LemonChiffon;
            this.button2.Location = new System.Drawing.Point(423, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_findWord_Click);

            this.button3.BackColor = System.Drawing.Color.LemonChiffon;
            this.button3.Location = new System.Drawing.Point(618, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 70);
            this.button3.TabIndex = 10;
            this.button3.Text = "Select file";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button_fileLoad1);

            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(289, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 28);
            this.button4.TabIndex = 11;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonExit_Click);

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Key word:";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Maximum distance:";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Thread count:";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Read time:";

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Search time:";

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBox_maxDistance);
            this.Controls.Add(this.textBox_wordToFind);
            this.Controls.Add(this.labelTimeFind);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Schaschurin Andrej IU5-32b";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label labelTimeFind;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox_wordToFind;
        private System.Windows.Forms.TextBox textBox_maxDistance;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

