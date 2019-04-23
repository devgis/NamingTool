namespace Devgis.Naming
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbNameList = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.btContine = new System.Windows.Forms.Button();
            this.btFilter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btRest = new System.Windows.Forms.Button();
            this.btHelp = new System.Windows.Forms.Button();
            this.btAbout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNameList
            // 
            this.tbNameList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNameList.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNameList.Location = new System.Drawing.Point(0, 0);
            this.tbNameList.Multiline = true;
            this.tbNameList.Name = "tbNameList";
            this.tbNameList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNameList.Size = new System.Drawing.Size(824, 222);
            this.tbNameList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btAbout);
            this.panel1.Controls.Add(this.btHelp);
            this.panel1.Controls.Add(this.btRest);
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Controls.Add(this.btContine);
            this.panel1.Controls.Add(this.btFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 40);
            this.panel1.TabIndex = 1;
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSave.Location = new System.Drawing.Point(189, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(109, 30);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "保存结果(&B)";
            this.toolTip1.SetToolTip(this.btSave, "将结果保存到txt文件中");
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btContine
            // 
            this.btContine.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btContine.Location = new System.Drawing.Point(104, 4);
            this.btContine.Name = "btContine";
            this.btContine.Size = new System.Drawing.Size(75, 30);
            this.btContine.TabIndex = 1;
            this.btContine.Text = "包含(&B)";
            this.toolTip1.SetToolTip(this.btContine, "只显示包含相关字的姓名");
            this.btContine.UseVisualStyleBackColor = true;
            this.btContine.Click += new System.EventHandler(this.btContine_Click);
            // 
            // btFilter
            // 
            this.btFilter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btFilter.Location = new System.Drawing.Point(22, 4);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(75, 30);
            this.btFilter.TabIndex = 0;
            this.btFilter.Text = "筛选(&S)";
            this.toolTip1.SetToolTip(this.btFilter, "包含关键字的姓名将被去除");
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbNameList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 222);
            this.panel2.TabIndex = 2;
            // 
            // btRest
            // 
            this.btRest.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRest.Location = new System.Drawing.Point(304, 4);
            this.btRest.Name = "btRest";
            this.btRest.Size = new System.Drawing.Size(109, 30);
            this.btRest.TabIndex = 3;
            this.btRest.Text = "恢复默认(&H)";
            this.toolTip1.SetToolTip(this.btRest, "显示默认库中所有姓名");
            this.btRest.UseVisualStyleBackColor = true;
            this.btRest.Click += new System.EventHandler(this.btRest_Click);
            // 
            // btHelp
            // 
            this.btHelp.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btHelp.Location = new System.Drawing.Point(419, 4);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(75, 30);
            this.btHelp.TabIndex = 4;
            this.btHelp.Text = "帮助(&Z)";
            this.toolTip1.SetToolTip(this.btHelp, "显示帮助信息");
            this.btHelp.UseVisualStyleBackColor = true;
            this.btHelp.Click += new System.EventHandler(this.btHelp_Click);
            // 
            // btAbout
            // 
            this.btAbout.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAbout.Location = new System.Drawing.Point(500, 4);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(75, 30);
            this.btAbout.TabIndex = 5;
            this.btAbout.Text = "关于(&G)";
            this.toolTip1.SetToolTip(this.btAbout, "显示作者相关信息");
            this.btAbout.UseVisualStyleBackColor = true;
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 262);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "起名软件";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbNameList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btContine;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btRest;
        private System.Windows.Forms.Button btAbout;
        private System.Windows.Forms.Button btHelp;
    }
}

