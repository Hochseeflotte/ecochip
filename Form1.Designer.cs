using System;

namespace ecochip_4._0
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
            this.ToolStripMenyItem1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bFilePath = new System.Windows.Forms.Button();
            this.bFileOpen = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bProv = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bClean = new System.Windows.Forms.Button();
            this.ToolStripMenyItem1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripMenyItem1
            // 
            this.ToolStripMenyItem1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.файлToolStripMenuItem});
            this.ToolStripMenyItem1.Location = new System.Drawing.Point(0, 0);
            this.ToolStripMenyItem1.Name = "ToolStripMenyItem1";
            this.ToolStripMenyItem1.Size = new System.Drawing.Size(790, 24);
            this.ToolStripMenyItem1.TabIndex = 0;
            this.ToolStripMenyItem1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItem1.Text = "О программе";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь к файлу: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(424, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Автомобиль";
            // 
            // bFilePath
            // 
            this.bFilePath.Location = new System.Drawing.Point(583, 33);
            this.bFilePath.Name = "bFilePath";
            this.bFilePath.Size = new System.Drawing.Size(75, 23);
            this.bFilePath.TabIndex = 8;
            this.bFilePath.Text = "Выбрать";
            this.bFilePath.UseVisualStyleBackColor = true;
            this.bFilePath.Click += new System.EventHandler(this.bFilePath_Click);
            // 
            // bFileOpen
            // 
            this.bFileOpen.Location = new System.Drawing.Point(673, 33);
            this.bFileOpen.Name = "bFileOpen";
            this.bFileOpen.Size = new System.Drawing.Size(75, 23);
            this.bFileOpen.TabIndex = 9;
            this.bFileOpen.Text = "Открыть";
            this.bFileOpen.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Renaut Traffic",
            "Volkswagen Transporter T5"});
            this.listBox1.Location = new System.Drawing.Point(141, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(423, 30);
            this.listBox1.TabIndex = 10;
            // 
            // bProv
            // 
            this.bProv.Location = new System.Drawing.Point(327, 122);
            this.bProv.Name = "bProv";
            this.bProv.Size = new System.Drawing.Size(140, 39);
            this.bProv.TabIndex = 11;
            this.bProv.Text = "проверка";
            this.bProv.UseVisualStyleBackColor = true;
            this.bProv.Click += new System.EventHandler(this.bProv_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(141, 201);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(424, 100);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // bClean
            // 
            this.bClean.Location = new System.Drawing.Point(327, 326);
            this.bClean.Name = "bClean";
            this.bClean.Size = new System.Drawing.Size(139, 41);
            this.bClean.TabIndex = 13;
            this.bClean.Text = "Очистка";
            this.bClean.UseVisualStyleBackColor = true;
            this.bClean.Click += new System.EventHandler(this.bClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 426);
            this.Controls.Add(this.bClean);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bProv);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bFileOpen);
            this.Controls.Add(this.bFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToolStripMenyItem1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ToolStripMenyItem1;
            this.Name = "Form1";
            this.Text = "ecochip";
            this.ToolStripMenyItem1.ResumeLayout(false);
            this.ToolStripMenyItem1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip ToolStripMenyItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bFilePath;
        private System.Windows.Forms.Button bFileOpen;
        private EventHandler файлToolStripMenuItem_Click;
        private EventHandler button2_Click;
        private readonly EventHandler ListBox1_SelectedIndexChanged;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bProv;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bClean;
    }
}

