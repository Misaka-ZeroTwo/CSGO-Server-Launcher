
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
            this.CollectionsComboBox = new System.Windows.Forms.ComboBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.TickrateComboBox = new System.Windows.Forms.ComboBox();
            this.GamemodeComboBox = new System.Windows.Forms.ComboBox();
            this.CollectionLinkLabel = new System.Windows.Forms.Label();
            this.DefaultMapLabel = new System.Windows.Forms.Label();
            this.CollectionLinkTextbox = new System.Windows.Forms.TextBox();
            this.DefaultMapTextbox = new System.Windows.Forms.TextBox();
            this.AddToFavoriteButton = new System.Windows.Forms.Button();
            this.TickrateLabel = new System.Windows.Forms.Label();
            this.GamemodeLabel = new System.Windows.Forms.Label();
            this.CollectionsLabel = new System.Windows.Forms.Label();
            this.PortComboBox = new System.Windows.Forms.ComboBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.CollectionNameTextBox = new System.Windows.Forms.TextBox();
            this.CollectionName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CollectionsComboBox
            // 
            this.CollectionsComboBox.DropDownHeight = 200;
            this.CollectionsComboBox.Font = new System.Drawing.Font("宋体", 14F);
            this.CollectionsComboBox.FormattingEnabled = true;
            this.CollectionsComboBox.IntegralHeight = false;
            this.CollectionsComboBox.Location = new System.Drawing.Point(385, 177);
            this.CollectionsComboBox.Name = "CollectionsComboBox";
            this.CollectionsComboBox.Size = new System.Drawing.Size(198, 27);
            this.CollectionsComboBox.TabIndex = 0;
            this.CollectionsComboBox.Text = "沙2";
            this.CollectionsComboBox.Click += new System.EventHandler(this.CollectionsComboBox_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("宋体", 15F);
            this.StartButton.Location = new System.Drawing.Point(612, 374);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(190, 67);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "启动";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TickrateComboBox
            // 
            this.TickrateComboBox.DropDownHeight = 50;
            this.TickrateComboBox.Font = new System.Drawing.Font("宋体", 14F);
            this.TickrateComboBox.FormattingEnabled = true;
            this.TickrateComboBox.IntegralHeight = false;
            this.TickrateComboBox.Location = new System.Drawing.Point(33, 177);
            this.TickrateComboBox.Name = "TickrateComboBox";
            this.TickrateComboBox.Size = new System.Drawing.Size(130, 27);
            this.TickrateComboBox.TabIndex = 2;
            this.TickrateComboBox.Text = "128";
            this.TickrateComboBox.Click += new System.EventHandler(this.TickrateComboBox_Click);
            // 
            // GamemodeComboBox
            // 
            this.GamemodeComboBox.DropDownHeight = 200;
            this.GamemodeComboBox.Font = new System.Drawing.Font("宋体", 14F);
            this.GamemodeComboBox.FormattingEnabled = true;
            this.GamemodeComboBox.IntegralHeight = false;
            this.GamemodeComboBox.Location = new System.Drawing.Point(208, 177);
            this.GamemodeComboBox.Name = "GamemodeComboBox";
            this.GamemodeComboBox.Size = new System.Drawing.Size(130, 27);
            this.GamemodeComboBox.TabIndex = 3;
            this.GamemodeComboBox.Text = "休闲模式";
            this.GamemodeComboBox.Click += new System.EventHandler(this.GamemodeComboBox_Click);
            // 
            // CollectionLinkLabel
            // 
            this.CollectionLinkLabel.AutoSize = true;
            this.CollectionLinkLabel.Font = new System.Drawing.Font("宋体", 14F);
            this.CollectionLinkLabel.Location = new System.Drawing.Point(23, 50);
            this.CollectionLinkLabel.Name = "CollectionLinkLabel";
            this.CollectionLinkLabel.Size = new System.Drawing.Size(104, 19);
            this.CollectionLinkLabel.TabIndex = 6;
            this.CollectionLinkLabel.Text = "合集链接：";
            // 
            // DefaultMapLabel
            // 
            this.DefaultMapLabel.AutoSize = true;
            this.DefaultMapLabel.Font = new System.Drawing.Font("宋体", 14F);
            this.DefaultMapLabel.Location = new System.Drawing.Point(23, 83);
            this.DefaultMapLabel.Name = "DefaultMapLabel";
            this.DefaultMapLabel.Size = new System.Drawing.Size(104, 19);
            this.DefaultMapLabel.TabIndex = 7;
            this.DefaultMapLabel.Text = "首选地图：";
            // 
            // CollectionLinkTextbox
            // 
            this.CollectionLinkTextbox.Location = new System.Drawing.Point(129, 51);
            this.CollectionLinkTextbox.Name = "CollectionLinkTextbox";
            this.CollectionLinkTextbox.Size = new System.Drawing.Size(173, 21);
            this.CollectionLinkTextbox.TabIndex = 8;
            // 
            // DefaultMapTextbox
            // 
            this.DefaultMapTextbox.Location = new System.Drawing.Point(129, 86);
            this.DefaultMapTextbox.Name = "DefaultMapTextbox";
            this.DefaultMapTextbox.Size = new System.Drawing.Size(173, 21);
            this.DefaultMapTextbox.TabIndex = 9;
            // 
            // AddToFavoriteButton
            // 
            this.AddToFavoriteButton.Font = new System.Drawing.Font("宋体", 15F);
            this.AddToFavoriteButton.Location = new System.Drawing.Point(615, 20);
            this.AddToFavoriteButton.Name = "AddToFavoriteButton";
            this.AddToFavoriteButton.Size = new System.Drawing.Size(187, 62);
            this.AddToFavoriteButton.TabIndex = 10;
            this.AddToFavoriteButton.Text = "添加到收藏夹";
            this.AddToFavoriteButton.UseVisualStyleBackColor = true;
            this.AddToFavoriteButton.Click += new System.EventHandler(this.AddToFavoriteButton_Click);
            // 
            // TickrateLabel
            // 
            this.TickrateLabel.AutoSize = true;
            this.TickrateLabel.Font = new System.Drawing.Font("宋体", 15F);
            this.TickrateLabel.Location = new System.Drawing.Point(29, 142);
            this.TickrateLabel.Name = "TickrateLabel";
            this.TickrateLabel.Size = new System.Drawing.Size(89, 20);
            this.TickrateLabel.TabIndex = 11;
            this.TickrateLabel.Text = "Tickrate";
            // 
            // GamemodeLabel
            // 
            this.GamemodeLabel.AutoSize = true;
            this.GamemodeLabel.Font = new System.Drawing.Font("宋体", 15F);
            this.GamemodeLabel.Location = new System.Drawing.Point(204, 142);
            this.GamemodeLabel.Name = "GamemodeLabel";
            this.GamemodeLabel.Size = new System.Drawing.Size(89, 20);
            this.GamemodeLabel.TabIndex = 12;
            this.GamemodeLabel.Text = "游戏模式";
            // 
            // CollectionsLabel
            // 
            this.CollectionsLabel.AutoSize = true;
            this.CollectionsLabel.Font = new System.Drawing.Font("宋体", 15F);
            this.CollectionsLabel.Location = new System.Drawing.Point(381, 142);
            this.CollectionsLabel.Name = "CollectionsLabel";
            this.CollectionsLabel.Size = new System.Drawing.Size(89, 20);
            this.CollectionsLabel.TabIndex = 13;
            this.CollectionsLabel.Text = "地图合集";
            // 
            // PortComboBox
            // 
            this.PortComboBox.Font = new System.Drawing.Font("宋体", 14F);
            this.PortComboBox.FormattingEnabled = true;
            this.PortComboBox.IntegralHeight = false;
            this.PortComboBox.Location = new System.Drawing.Point(632, 177);
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(130, 27);
            this.PortComboBox.TabIndex = 14;
            this.PortComboBox.Text = "27015";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("宋体", 15F);
            this.PortLabel.Location = new System.Drawing.Point(628, 142);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(49, 20);
            this.PortLabel.TabIndex = 15;
            this.PortLabel.Text = "端口";
            // 
            // CollectionNameTextBox
            // 
            this.CollectionNameTextBox.Location = new System.Drawing.Point(129, 20);
            this.CollectionNameTextBox.Name = "CollectionNameTextBox";
            this.CollectionNameTextBox.Size = new System.Drawing.Size(173, 21);
            this.CollectionNameTextBox.TabIndex = 17;
            // 
            // CollectionName
            // 
            this.CollectionName.AutoSize = true;
            this.CollectionName.Font = new System.Drawing.Font("宋体", 14F);
            this.CollectionName.Location = new System.Drawing.Point(23, 20);
            this.CollectionName.Name = "CollectionName";
            this.CollectionName.Size = new System.Drawing.Size(104, 19);
            this.CollectionName.TabIndex = 16;
            this.CollectionName.Text = "合集名称：";
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 453);
            this.Controls.Add(this.CollectionNameTextBox);
            this.Controls.Add(this.CollectionName);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.PortComboBox);
            this.Controls.Add(this.CollectionsLabel);
            this.Controls.Add(this.GamemodeLabel);
            this.Controls.Add(this.TickrateLabel);
            this.Controls.Add(this.AddToFavoriteButton);
            this.Controls.Add(this.DefaultMapTextbox);
            this.Controls.Add(this.CollectionLinkTextbox);
            this.Controls.Add(this.DefaultMapLabel);
            this.Controls.Add(this.CollectionLinkLabel);
            this.Controls.Add(this.GamemodeComboBox);
            this.Controls.Add(this.TickrateComboBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CollectionsComboBox);
            this.Name = "Launcher";
            this.Text = "CSGO服务器启动器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        public System.Windows.Forms.ComboBox CollectionsComboBox;
        private System.Windows.Forms.Button StartButton;
        public System.Windows.Forms.ComboBox TickrateComboBox;
        private System.Windows.Forms.ComboBox GamemodeComboBox;
        private System.Windows.Forms.Label CollectionLinkLabel;
        private System.Windows.Forms.Label DefaultMapLabel;
        private System.Windows.Forms.TextBox CollectionLinkTextbox;
        private System.Windows.Forms.TextBox DefaultMapTextbox;
        private System.Windows.Forms.Button AddToFavoriteButton;
        private System.Windows.Forms.Label TickrateLabel;
        private System.Windows.Forms.Label GamemodeLabel;
        private System.Windows.Forms.Label CollectionsLabel;
        private System.Windows.Forms.ComboBox PortComboBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox CollectionNameTextBox;
        private System.Windows.Forms.Label CollectionName;
    }
}

