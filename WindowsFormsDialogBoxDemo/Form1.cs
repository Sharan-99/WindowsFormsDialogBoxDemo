using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsDialogBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            var fonts = new FontDialog();
            var result = fonts.ShowDialog();
            if(result==DialogResult.OK)
            {
                lblFont.Font = fonts.Font;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            var color = new ColorDialog();
            var result = color.ShowDialog();
            if(result==DialogResult.OK)
            {
                lblFont.ForeColor = color.Color;
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            var result = open.ShowDialog();
            if(result==DialogResult.OK)
            {
                var filepath = open.FileName;
                MessageBox.Show(filepath);
            }
        }

        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            var savefiledialog = new SaveFileDialog();
            var result = savefiledialog.ShowDialog();
            if(result==DialogResult.OK)
            {
                var filepath = savefiledialog.FileName;

                using(var fs=new FileStream(filepath,FileMode.CreateNew,FileAccess.Write))
                {
                    using(var sw=new StreamWriter(fs))
                    {
                        sw.WriteLine("Hello Sharan");
                        sw.Close();
                    }
                    fs.Close();
                }
                MessageBox.Show(filepath);
            }
        }
    }
}
