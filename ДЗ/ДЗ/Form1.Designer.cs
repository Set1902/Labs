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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_time = new System.Windows.Forms.Label();
            this.labelTimeFind = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox_wordToFind = new System.Windows.Forms.TextBox();
            this.textBox_maxDistance = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 258);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(559, 354);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 39);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 31);
            this.textBox2.TabIndex = 1;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(792, 627);
            this.label_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 25);
            this.label_time.TabIndex = 3;
            // 
            // labelTimeFind
            // 
            this.labelTimeFind.AutoSize = true;
            this.labelTimeFind.Location = new System.Drawing.Point(792, 662);
            this.labelTimeFind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeFind.Name = "labelTimeFind";
            this.labelTimeFind.Size = new System.Drawing.Size(0, 25);
            this.labelTimeFind.TabIndex = 4;
            // 
            // textBox_wordToFind
            // 
            this.textBox_wordToFind.Location = new System.Drawing.Point(180, 118);
            this.textBox_wordToFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_wordToFind.Name = "textBox_wordToFind";
            this.textBox_wordToFind.Size = new System.Drawing.Size(148, 31);
            this.textBox_wordToFind.TabIndex = 5;
            // 
            // textBox_maxDistance
            // 
            this.textBox_maxDistance.Location = new System.Drawing.Point(180, 80);
            this.textBox_maxDistance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_maxDistance.Name = "textBox_maxDistance";
            this.textBox_maxDistance.Size = new System.Drawing.Size(148, 31);
            this.textBox_maxDistance.TabIndex = 6;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(588, 258);
            this.listBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(572, 354);
            this.listBox.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LemonChiffon;
            this.button2.Location = new System.Drawing.Point(336, 115);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_findWord_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LemonChiffon;
            this.button3.Location = new System.Drawing.Point(904, 42);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 109);
            this.button3.TabIndex = 10;
            this.button3.Text = "Выберите файл";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button_fileLoad1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(1048, 662);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 44);
            this.button4.TabIndex = 11;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Слово";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Дистанция";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Потоки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Время чтения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Время поиска";
            // 
            // DZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBox_maxDistance);
            this.Controls.Add(this.textBox_wordToFind);
            this.Controls.Add(this.labelTimeFind);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DZ";
            this.Text = "Ковалев Сергей ИУ5-32Б";
            this.Load += new System.EventHandler(this.DZ_Load);
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

