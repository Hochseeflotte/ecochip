using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecochip_4._0
{
    public interface IForm
    {
        string FilePath { get; }
        event EventHandler FileOpenClick;

    }
    public partial class Form1 : Form, IForm
    {
        public string FilePath
        {
            get { return bFilePath.Text; }
        }

        public EventHandler FileOpenClick;

        public Form1()
        {
            InitializeComponent();
            bFileOpen.Click += bFileOpen_Click;
        }
        #region обработка кнопочек и проверка

        private void bProv_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Автомобиль :" + listBox1.Text + " сажевый фильтр включен";
        }

        private void bClean_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private void bFileOpen_Click(object sender, EventArgs e)
        {
            if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
        }

        event EventHandler IForm.FileOpenClick
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }
            private void bSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = " Бинарный файл |*.bin |Все файлы|*.*";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                bFilePath.Text = dlg.FileName;
            }
            if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
        }

        private void bFilePath_Click(object sender, EventArgs e)
        {

        }

        
    }
   
    }

