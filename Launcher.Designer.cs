
namespace CSGO_Server_Launcher
{
    partial class Launcher
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
            this.Collections = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.Button();
            this.Tickrate = new System.Windows.Forms.ComboBox();
            this.Gamemode = new System.Windows.Forms.ComboBox();
            this.ConfigStatus = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddToFavorite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Collections
            // 
            this.Collections.Font = new System.Drawing.Font("宋体", 14F);
            this.Collections.FormattingEnabled = true;
            this.Collections.IntegralHeight = false;
            this.Collections.Location = new System.Drawing.Point(431, 339);
            this.Collections.Name = "Collections";
            this.Collections.Size = new System.Drawing.Size(130, 27);
            this.Collections.TabIndex = 0;
            this.Collections.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("宋体", 15F);
            this.Start.Location = new System.Drawing.Point(612, 374);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(190, 67);
            this.Start.TabIndex = 1;
            this.Start.Text = "启动";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tickrate
            // 
            this.Tickrate.Font = new System.Drawing.Font("宋体", 14F);
            this.Tickrate.FormattingEnabled = true;
            this.Tickrate.IntegralHeight = false;
            this.Tickrate.Location = new System.Drawing.Point(12, 339);
            this.Tickrate.Name = "Tickrate";
            this.Tickrate.Size = new System.Drawing.Size(130, 27);
            this.Tickrate.TabIndex = 2;
            // 
            // Gamemode
            // 
            this.Gamemode.Font = new System.Drawing.Font("宋体", 14F);
            this.Gamemode.FormattingEnabled = true;
            this.Gamemode.IntegralHeight = false;
            this.Gamemode.Location = new System.Drawing.Point(209, 339);
            this.Gamemode.Name = "Gamemode";
            this.Gamemode.Size = new System.Drawing.Size(130, 27);
            this.Gamemode.TabIndex = 3;
            // 
            // ConfigStatus
            // 
            this.ConfigStatus.AutoSize = true;
            this.ConfigStatus.Font = new System.Drawing.Font("宋体", 18F);
            this.ConfigStatus.Location = new System.Drawing.Point(427, 9);
            this.ConfigStatus.Name = "ConfigStatus";
            this.ConfigStatus.Size = new System.Drawing.Size(154, 24);
            this.ConfigStatus.TabIndex = 4;
            this.ConfigStatus.Text = "Config状态：";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("宋体", 18F);
            this.Status.LinkColor = System.Drawing.Color.Black;
            this.Status.Location = new System.Drawing.Point(568, 9);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(250, 24);
            this.Status.TabIndex = 5;
            this.Status.TabStop = true;
            this.Status.Text = "error loading status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "合集链接：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "首选地图：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 21);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 21);
            this.textBox2.TabIndex = 9;
            // 
            // AddToFavorite
            // 
            this.AddToFavorite.Font = new System.Drawing.Font("宋体", 15F);
            this.AddToFavorite.Location = new System.Drawing.Point(614, 277);
            this.AddToFavorite.Name = "AddToFavorite";
            this.AddToFavorite.Size = new System.Drawing.Size(187, 62);
            this.AddToFavorite.TabIndex = 10;
            this.AddToFavorite.Text = "添加到收藏夹";
            this.AddToFavorite.UseVisualStyleBackColor = true;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 453);
            this.Controls.Add(this.AddToFavorite);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.ConfigStatus);
            this.Controls.Add(this.Gamemode);
            this.Controls.Add(this.Tickrate);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Collections);
            this.Name = "Launcher";
            this.Text = "CSGO服务器启动器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Collections;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.ComboBox Tickrate;
        private System.Windows.Forms.ComboBox Gamemode;
        private System.Windows.Forms.Label ConfigStatus;
        private System.Windows.Forms.LinkLabel Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AddToFavorite;
    }
}

