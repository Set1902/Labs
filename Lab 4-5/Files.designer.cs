namespace Files
{
    partial class Files
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Files));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1ReadTime = new System.Windows.Forms.TextBox();
            this.textBox1FileReadCount = new System.Windows.Forms.TextBox();
            this.buttonExact = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonApprox = new System.Windows.Forms.Button();
            this.textBoxMaxDist = new System.Windows.Forms.TextBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.textBoxApproxTime = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSaveReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxExactTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(32, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выбор файла";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1ReadTime
            // 
            this.textBox1ReadTime.Location = new System.Drawing.Point(705, 36);
            this.textBox1ReadTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1ReadTime.Name = "textBox1ReadTime";
            this.textBox1ReadTime.Size = new System.Drawing.Size(178, 31);
            this.textBox1ReadTime.TabIndex = 1;
            // 
            // textBox1FileReadCount
            // 
            this.textBox1FileReadCount.Location = new System.Drawing.Point(705, 89);
            this.textBox1FileReadCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1FileReadCount.Name = "textBox1FileReadCount";
            this.textBox1FileReadCount.Size = new System.Drawing.Size(178, 31);
            this.textBox1FileReadCount.TabIndex = 2;
            // 
            // buttonExact
            // 
            this.buttonExact.BackColor = System.Drawing.Color.Red;
            this.buttonExact.Location = new System.Drawing.Point(32, 227);
            this.buttonExact.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExact.Name = "buttonExact";
            this.buttonExact.Size = new System.Drawing.Size(183, 72);
            this.buttonExact.TabIndex = 3;
            this.buttonExact.Text = "Поиск";
            this.buttonExact.UseVisualStyleBackColor = false;
            this.buttonExact.Click += new System.EventHandler(this.buttonExact_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(627, 171);
            this.textBoxFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(256, 31);
            this.textBoxFind.TabIndex = 4;
            // 
            // buttonApprox
            // 
            this.buttonApprox.BackColor = System.Drawing.Color.Red;
            this.buttonApprox.Location = new System.Drawing.Point(32, 325);
            this.buttonApprox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonApprox.Name = "buttonApprox";
            this.buttonApprox.Size = new System.Drawing.Size(183, 92);
            this.buttonApprox.TabIndex = 5;
            this.buttonApprox.Text = "Расстояние Левенштейна";
            this.buttonApprox.UseVisualStyleBackColor = false;
            this.buttonApprox.Click += new System.EventHandler(this.buttonApprox_Click);
            // 
            // textBoxMaxDist
            // 
            this.textBoxMaxDist.Location = new System.Drawing.Point(705, 270);
            this.textBoxMaxDist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMaxDist.Name = "textBoxMaxDist";
            this.textBoxMaxDist.Size = new System.Drawing.Size(178, 31);
            this.textBoxMaxDist.TabIndex = 6;
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 25;
            this.listBoxResult.Location = new System.Drawing.Point(32, 441);
            this.listBoxResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(948, 229);
            this.listBoxResult.TabIndex = 8;
            // 
            // textBoxApproxTime
            // 
            this.textBoxApproxTime.Location = new System.Drawing.Point(705, 320);
            this.textBoxApproxTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxApproxTime.Name = "textBoxApproxTime";
            this.textBoxApproxTime.Size = new System.Drawing.Size(178, 31);
            this.textBoxApproxTime.TabIndex = 9;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(776, 703);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(206, 44);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSaveReport
            // 
            this.buttonSaveReport.Location = new System.Drawing.Point(0, 0);
            this.buttonSaveReport.Name = "buttonSaveReport";
            this.buttonSaveReport.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveReport.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Время";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Количество уникальных слов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Слово";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Время поиска";
            // 
            // textBoxExactTime
            // 
            this.textBoxExactTime.Location = new System.Drawing.Point(705, 219);
            this.textBoxExactTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxExactTime.Name = "textBoxExactTime";
            this.textBoxExactTime.Size = new System.Drawing.Size(178, 31);
            this.textBoxExactTime.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Дистанция";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 326);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Время";
            // 
            // Files
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1040, 759);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxExactTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveReport);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxApproxTime);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.textBoxMaxDist);
            this.Controls.Add(this.buttonApprox);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.buttonExact);
            this.Controls.Add(this.textBox1FileReadCount);
            this.Controls.Add(this.textBox1ReadTime);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Files";
            this.Text = "Ковалев Сергей ИУ:-32Б";
            this.Load += new System.EventHandler(this.Files_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1ReadTime;
        private System.Windows.Forms.TextBox textBox1FileReadCount;
        private System.Windows.Forms.Button buttonExact;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonApprox;
        private System.Windows.Forms.TextBox textBoxMaxDist;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.TextBox textBoxApproxTime;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSaveReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxExactTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
