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

namespace Devgis.Naming
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            String DBPath=Path.Combine(Application.StartupPath+"\\name.db");
            if (File.Exists(DBPath))
            {
                tbNameList.Text = File.ReadAllText(DBPath,Encoding.Default);
            }
            else
            {
                MessageBox.Show("数据库不存在请重新下载或者EMEIL联系devgis@qq.com", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            //去除包含相关词的姓名
            Words frmWords = new Words();
            if (frmWords.ShowDialog() == DialogResult.OK)
            {
                String SOld=tbNameList.Text;
                StringBuilder sbNew=new StringBuilder();
                String[] words = frmWords.KeyWords.Split(',');
                for (int i = 0; i < tbNameList.Lines.Length; i++)
                {
                    foreach (String sword in words)
                    {
                        if (!String.IsNullOrEmpty(sword.Trim()))
                        {
                            if (!tbNameList.Lines[i].Contains(sword))
                            {
                                sbNew.AppendLine(tbNameList.Lines[i]);
                            }
                        }
                    }
                }
                tbNameList.Text = sbNew.ToString();
            }
        }

        private void btContine_Click(object sender, EventArgs e)
        {
            Words frmWords = new Words();
            if (frmWords.ShowDialog() == DialogResult.OK)
            {
                String SOld = tbNameList.Text;
                StringBuilder sbNew = new StringBuilder();
                String[] words = frmWords.KeyWords.Split(',');
                for (int i = 0; i < tbNameList.Lines.Length; i++)
                {
                    foreach (String sword in words)
                    {
                        if (!String.IsNullOrEmpty(sword.Trim()))
                        {
                            if (tbNameList.Lines[i].Contains(sword))
                            {
                                sbNew.AppendLine(tbNameList.Lines[i]);
                            }
                        }
                    }
                }
                tbNameList.Text = sbNew.ToString();
            }
        }


        private void btAbout_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.devgis.com");
        }

        private void btHelp_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("help.txt");
            }
            catch
            {
                MessageBox.Show("暂无帮助信息！");
            }
        }

        private void btRest_Click(object sender, EventArgs e)
        {
            String DBPath = Path.Combine(Application.StartupPath + "\\name.db");
            if (File.Exists(DBPath))
            {
                tbNameList.Text = File.ReadAllText(DBPath, Encoding.Default);
            }
            else
            {
                MessageBox.Show("数据库不存在请重新下载或者EMEIL联系devgis@qq.com", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfDialog = new SaveFileDialog();
            sfDialog.Filter = "文本文件|*.txt";
            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfDialog.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.Write(tbNameList.Text);
                sw.Close();
                fs.Close();
                MessageBox.Show("保存成功！");
            }
        }
    }
}
