namespace Lab04
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button buttonKey;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSaveFile = new System.Windows.Forms.TextBox();
            this.textBoxInputFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxKeyFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonSaveFile1 = new System.Windows.Forms.Button();
            this.buttonKeyFile = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonInputFile = new System.Windows.Forms.Button();
            this.labelFIleKeyLength = new System.Windows.Forms.Label();
            this.labelKeyLength = new System.Windows.Forms.Label();
            buttonKey = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSaveFile);
            this.groupBox1.Controls.Add(this.textBoxInputFile);
            this.groupBox1.Controls.Add(this.buttonSaveFile);
            this.groupBox1.Controls.Add(this.buttonInputFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(61, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файли";
            // 
            // textBoxSaveFile
            // 
            this.textBoxSaveFile.Location = new System.Drawing.Point(145, 71);
            this.textBoxSaveFile.Name = "textBoxSaveFile";
            this.textBoxSaveFile.Size = new System.Drawing.Size(413, 22);
            this.textBoxSaveFile.TabIndex = 5;
            // 
            // textBoxInputFile
            // 
            this.textBoxInputFile.Location = new System.Drawing.Point(145, 22);
            this.textBoxInputFile.Name = "textBoxInputFile";
            this.textBoxInputFile.Size = new System.Drawing.Size(413, 22);
            this.textBoxInputFile.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зберегти у файл";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Відкрити файл";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelKeyLength);
            this.groupBox2.Controls.Add(buttonKey);
            this.groupBox2.Controls.Add(this.textBoxKeyFile);
            this.groupBox2.Controls.Add(this.buttonSaveFile1);
            this.groupBox2.Controls.Add(this.buttonKeyFile);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(61, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 142);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключ";
            // 
            // textBoxKeyFile
            // 
            this.textBoxKeyFile.Location = new System.Drawing.Point(145, 42);
            this.textBoxKeyFile.Name = "textBoxKeyFile";
            this.textBoxKeyFile.Size = new System.Drawing.Size(332, 22);
            this.textBoxKeyFile.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Файл з ключем";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Тривалість шифрування (мін, сек, мс):";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(561, 391);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(91, 37);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(361, 401);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(64, 17);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "00:00.00";
            // 
            // buttonKey
            // 
            buttonKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            buttonKey.ForeColor = System.Drawing.SystemColors.ControlText;
            buttonKey.Image = global::Lab04.Properties.Resources.key_;
            buttonKey.Location = new System.Drawing.Point(268, 85);
            buttonKey.Name = "buttonKey";
            buttonKey.Size = new System.Drawing.Size(125, 41);
            buttonKey.TabIndex = 4;
            buttonKey.UseVisualStyleBackColor = true;
            buttonKey.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // buttonSaveFile1
            // 
            this.buttonSaveFile1.Image = global::Lab04.Properties.Resources.save;
            this.buttonSaveFile1.Location = new System.Drawing.Point(548, 42);
            this.buttonSaveFile1.Name = "buttonSaveFile1";
            this.buttonSaveFile1.Size = new System.Drawing.Size(58, 58);
            this.buttonSaveFile1.TabIndex = 2;
            this.buttonSaveFile1.UseVisualStyleBackColor = true;
            this.buttonSaveFile1.Click += new System.EventHandler(this.buttonSaveFile1_Click);
            // 
            // buttonKeyFile
            // 
            this.buttonKeyFile.Image = global::Lab04.Properties.Resources.file_open;
            this.buttonKeyFile.Location = new System.Drawing.Point(483, 42);
            this.buttonKeyFile.Name = "buttonKeyFile";
            this.buttonKeyFile.Size = new System.Drawing.Size(59, 57);
            this.buttonKeyFile.TabIndex = 1;
            this.buttonKeyFile.UseVisualStyleBackColor = true;
            this.buttonKeyFile.Click += new System.EventHandler(this.buttonKeyFile_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSaveFile.Image = global::Lab04.Properties.Resources._3tochku;
            this.buttonSaveFile.Location = new System.Drawing.Point(577, 71);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(37, 23);
            this.buttonSaveFile.TabIndex = 3;
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonInputFile
            // 
            this.buttonInputFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonInputFile.Image = global::Lab04.Properties.Resources._3tochku;
            this.buttonInputFile.Location = new System.Drawing.Point(577, 22);
            this.buttonInputFile.Name = "buttonInputFile";
            this.buttonInputFile.Size = new System.Drawing.Size(37, 23);
            this.buttonInputFile.TabIndex = 2;
            this.buttonInputFile.UseVisualStyleBackColor = true;
            this.buttonInputFile.Click += new System.EventHandler(this.buttonInputFile_Click);
            // 
            // labelFIleKeyLength
            // 
            this.labelFIleKeyLength.AutoSize = true;
            this.labelFIleKeyLength.Location = new System.Drawing.Point(74, 431);
            this.labelFIleKeyLength.Name = "labelFIleKeyLength";
            this.labelFIleKeyLength.Size = new System.Drawing.Size(167, 17);
            this.labelFIleKeyLength.TabIndex = 5;
            this.labelFIleKeyLength.Text = "Розмір файлу з ключем:";
            // 
            // labelKeyLength
            // 
            this.labelKeyLength.AutoSize = true;
            this.labelKeyLength.Location = new System.Drawing.Point(37, 85);
            this.labelKeyLength.Name = "labelKeyLength";
            this.labelKeyLength.Size = new System.Drawing.Size(101, 17);
            this.labelKeyLength.TabIndex = 5;
            this.labelKeyLength.Text = "Розмір ключа:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.labelFIleKeyLength);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(719, 497);
            this.MinimumSize = new System.Drawing.Size(719, 497);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSaveFile;
        private System.Windows.Forms.TextBox textBoxInputFile;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonInputFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxKeyFile;
        private System.Windows.Forms.Button buttonSaveFile1;
        private System.Windows.Forms.Button buttonKeyFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelKeyLength;
        private System.Windows.Forms.Label labelFIleKeyLength;
    }
}

