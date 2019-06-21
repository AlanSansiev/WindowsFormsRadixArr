namespace WindowsFormsRadixArr
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxKeyboard = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.buttonRandomoutput = new System.Windows.Forms.Button();
            this.textBoxRandCount = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.initialArr = new System.Windows.Forms.TextBox();
            this.sortedArr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxtime = new System.Windows.Forms.TextBox();
            this.textBoxmas = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxKeyboard
            // 
            this.textBoxKeyboard.Location = new System.Drawing.Point(0, 28);
            this.textBoxKeyboard.Name = "textBoxKeyboard";
            this.textBoxKeyboard.Size = new System.Drawing.Size(301, 29);
            this.textBoxKeyboard.TabIndex = 0;
            this.textBoxKeyboard.TextChanged += new System.EventHandler(this.textBoxKeyboard_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(17, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "загрузить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.textBoxKeyboard);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод чисел с клавиатуры";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.FilePath);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(13, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Из файла";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(197, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 29);
            this.button4.TabIndex = 11;
            this.button4.Text = "выбрать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-1, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "загрузить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FilePath
            // 
            this.FilePath.BackColor = System.Drawing.SystemColors.Window;
            this.FilePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FilePath.Location = new System.Drawing.Point(-1, 28);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(192, 29);
            this.FilePath.TabIndex = 9;
            this.FilePath.Text = "...";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxTo);
            this.groupBox3.Controls.Add(this.buttonRandomoutput);
            this.groupBox3.Controls.Add(this.textBoxRandCount);
            this.groupBox3.Controls.Add(this.textBoxFrom);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(13, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 147);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Случайные числа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "до";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "колво";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "от";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(157, 38);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(65, 29);
            this.textBoxTo.TabIndex = 9;
            this.textBoxTo.Text = "9";
            // 
            // buttonRandomoutput
            // 
            this.buttonRandomoutput.Location = new System.Drawing.Point(-1, 110);
            this.buttonRandomoutput.Name = "buttonRandomoutput";
            this.buttonRandomoutput.Size = new System.Drawing.Size(301, 31);
            this.buttonRandomoutput.TabIndex = 10;
            this.buttonRandomoutput.Text = "загрузить";
            this.buttonRandomoutput.UseVisualStyleBackColor = true;
            this.buttonRandomoutput.Click += new System.EventHandler(this.buttonRandomoutput_Click);
            // 
            // textBoxRandCount
            // 
            this.textBoxRandCount.Location = new System.Drawing.Point(103, 75);
            this.textBoxRandCount.Name = "textBoxRandCount";
            this.textBoxRandCount.Size = new System.Drawing.Size(64, 29);
            this.textBoxRandCount.TabIndex = 0;
            this.textBoxRandCount.Text = "10";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(37, 38);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(62, 29);
            this.textBoxFrom.TabIndex = 0;
            this.textBoxFrom.Text = "0";
            // 
            // initialArr
            // 
            this.initialArr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.initialArr.Location = new System.Drawing.Point(368, 40);
            this.initialArr.Multiline = true;
            this.initialArr.Name = "initialArr";
            this.initialArr.ReadOnly = true;
            this.initialArr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.initialArr.Size = new System.Drawing.Size(204, 123);
            this.initialArr.TabIndex = 6;
            // 
            // sortedArr
            // 
            this.sortedArr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sortedArr.Location = new System.Drawing.Point(589, 40);
            this.sortedArr.Multiline = true;
            this.sortedArr.Name = "sortedArr";
            this.sortedArr.ReadOnly = true;
            this.sortedArr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sortedArr.Size = new System.Drawing.Size(190, 123);
            this.sortedArr.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(586, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "после";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(365, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "до";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonSave);
            this.groupBox6.Controls.Add(this.buttonSort);
            this.groupBox6.Location = new System.Drawing.Point(368, 182);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(164, 79);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Сортировка";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(6, 45);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(152, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить результат";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(6, 16);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(152, 23);
            this.buttonSort.TabIndex = 0;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(791, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "размер массива:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "время сортировки(мс):";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxtime
            // 
            this.textBoxtime.Location = new System.Drawing.Point(472, 329);
            this.textBoxtime.Name = "textBoxtime";
            this.textBoxtime.ReadOnly = true;
            this.textBoxtime.Size = new System.Drawing.Size(100, 20);
            this.textBoxtime.TabIndex = 16;
            // 
            // textBoxmas
            // 
            this.textBoxmas.Location = new System.Drawing.Point(472, 306);
            this.textBoxmas.Name = "textBoxmas";
            this.textBoxmas.ReadOnly = true;
            this.textBoxmas.Size = new System.Drawing.Size(100, 20);
            this.textBoxmas.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(791, 497);
            this.Controls.Add(this.textBoxmas);
            this.Controls.Add(this.textBoxtime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sortedArr);
            this.Controls.Add(this.initialArr);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "RadixSort";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKeyboard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRandomoutput;
        private System.Windows.Forms.TextBox textBoxRandCount;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox initialArr;
        private System.Windows.Forms.TextBox sortedArr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxtime;
        private System.Windows.Forms.TextBox textBoxmas;
    }
}

