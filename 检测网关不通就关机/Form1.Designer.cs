namespace 检测网关不通就关机
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始运行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(142, 65);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(100, 21);
            this.TimeBox.TabIndex = 1;
            this.TimeBox.Text = "60";
            this.TimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "检测间隔时间（秒）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "制作：HUGO陀陀";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "检测的网关IP地址：";
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(142, 38);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(100, 21);
            this.IPBox.TabIndex = 0;
            this.IPBox.Text = "192.168.1.1";
            this.IPBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "检测网关不通就关机";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示程序ToolStripMenuItem,
            this.隐藏程序ToolStripMenuItem,
            this.关闭程序ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // 显示程序ToolStripMenuItem
            // 
            this.显示程序ToolStripMenuItem.Name = "显示程序ToolStripMenuItem";
            this.显示程序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.显示程序ToolStripMenuItem.Text = "显示程序";
            this.显示程序ToolStripMenuItem.Click += new System.EventHandler(this.显示程序ToolStripMenuItem_Click);
            // 
            // 隐藏程序ToolStripMenuItem
            // 
            this.隐藏程序ToolStripMenuItem.Name = "隐藏程序ToolStripMenuItem";
            this.隐藏程序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.隐藏程序ToolStripMenuItem.Text = "隐藏程序";
            this.隐藏程序ToolStripMenuItem.Click += new System.EventHandler(this.隐藏程序ToolStripMenuItem_Click);
            // 
            // 关闭程序ToolStripMenuItem
            // 
            this.关闭程序ToolStripMenuItem.Name = "关闭程序ToolStripMenuItem";
            this.关闭程序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关闭程序ToolStripMenuItem.Text = "关闭程序";
            this.关闭程序ToolStripMenuItem.Click += new System.EventHandler(this.关闭程序ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "检测网关不通就关机";
            this.MinimumSizeChanged += new System.EventHandler(this.Button1_Click);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭程序ToolStripMenuItem;
    }
}

