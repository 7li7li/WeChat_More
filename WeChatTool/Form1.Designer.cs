namespace WeChatTool
{
    partial class WeChatTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeChatTool));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.vx = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.开启一个微信ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示主页面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏主页面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于本软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "再来一个微信";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "给老子开";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "创建桌面快捷方式";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "个";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(168, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "整他喵的";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(21, 82);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 12);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "薅羊毛线报";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(176, 82);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(89, 12);
            this.linkLabel3.TabIndex = 11;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "有问题找小哥哥";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // vx
            // 
            this.vx.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.vx.ContextMenuStrip = this.contextMenuStrip1;
            this.vx.Icon = ((System.Drawing.Icon)(resources.GetObject("vx.Icon")));
            this.vx.Text = "微信多开";
            this.vx.Visible = true;
            this.vx.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开启一个微信ToolStripMenuItem,
            this.显示主页面ToolStripMenuItem,
            this.隐藏主页面ToolStripMenuItem,
            this.关于本软件ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 开启一个微信ToolStripMenuItem
            // 
            this.开启一个微信ToolStripMenuItem.Name = "开启一个微信ToolStripMenuItem";
            this.开启一个微信ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.开启一个微信ToolStripMenuItem.Text = "开启一个微信";
            this.开启一个微信ToolStripMenuItem.Click += new System.EventHandler(this.开启一个微信ToolStripMenuItem_Click);
            // 
            // 显示主页面ToolStripMenuItem
            // 
            this.显示主页面ToolStripMenuItem.Name = "显示主页面ToolStripMenuItem";
            this.显示主页面ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.显示主页面ToolStripMenuItem.Text = "显示主页面";
            this.显示主页面ToolStripMenuItem.Click += new System.EventHandler(this.显示主页面ToolStripMenuItem_Click);
            // 
            // 隐藏主页面ToolStripMenuItem
            // 
            this.隐藏主页面ToolStripMenuItem.Name = "隐藏主页面ToolStripMenuItem";
            this.隐藏主页面ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.隐藏主页面ToolStripMenuItem.Text = "隐藏主页面";
            this.隐藏主页面ToolStripMenuItem.Click += new System.EventHandler(this.隐藏主页面ToolStripMenuItem_Click);
            // 
            // 关于本软件ToolStripMenuItem
            // 
            this.关于本软件ToolStripMenuItem.Name = "关于本软件ToolStripMenuItem";
            this.关于本软件ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.关于本软件ToolStripMenuItem.Text = "关于本软件";
            this.关于本软件ToolStripMenuItem.Click += new System.EventHandler(this.关于本软件ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(92, 82);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(83, 12);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "www.7li7li.cn";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // WeChatTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 98);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeChatTool";
            this.Text = "微信多开(帅哥出品)";
            this.Deactivate += new System.EventHandler(this.WeChatTool_Deactivate);
            this.Load += new System.EventHandler(this.WeChatTool_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.NotifyIcon vx;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示主页面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开启一个微信ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于本软件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏主页面ToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

