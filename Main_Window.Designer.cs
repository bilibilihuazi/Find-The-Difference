namespace Find_The_Difference
{
    partial class Main_Window
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
            this.pageHeader = new AntdUI.PageHeader();
            this.button_EULA = new AntdUI.Button();
            this.button_Header_About = new AntdUI.Button();
            this.tooltipComponent = new AntdUI.TooltipComponent();
            this.input_Text = new AntdUI.Input();
            this.radio_Mode1 = new AntdUI.Radio();
            this.radio_Mode2 = new AntdUI.Radio();
            this.label_dfText = new AntdUI.Label();
            this.input_dfText = new AntdUI.Input();
            this.button_Start = new AntdUI.Button();
            this.input_undfText = new AntdUI.Input();
            this.label_undfText = new AntdUI.Label();
            this.radio_Mode3 = new AntdUI.Radio();
            this.pageHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.Add(this.button_EULA);
            this.pageHeader.Controls.Add(this.button_Header_About);
            this.pageHeader.HandCursor = System.Windows.Forms.Cursors.Default;
            this.pageHeader.Location = new System.Drawing.Point(0, 0);
            this.pageHeader.MaximizeBox = false;
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.ShowButton = true;
            this.pageHeader.ShowIcon = true;
            this.pageHeader.Size = new System.Drawing.Size(371, 30);
            this.pageHeader.TabIndex = 0;
            this.pageHeader.Text = "Main_Window";
            // 
            // button_EULA
            // 
            this.button_EULA.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_EULA.Icon = global::Find_The_Difference.Properties.Resources.MaterialSymbolsContractRounded;
            this.button_EULA.Location = new System.Drawing.Point(206, 0);
            this.button_EULA.Name = "button_EULA";
            this.button_EULA.Radius = 4;
            this.button_EULA.Size = new System.Drawing.Size(30, 30);
            this.button_EULA.TabIndex = 1;
            this.button_EULA.Click += new System.EventHandler(this.button_EULA_Click);
            // 
            // button_Header_About
            // 
            this.button_Header_About.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_Header_About.Icon = global::Find_The_Difference.Properties.Resources.IxAbout;
            this.button_Header_About.Location = new System.Drawing.Point(242, 0);
            this.button_Header_About.Name = "button_Header_About";
            this.button_Header_About.Radius = 4;
            this.button_Header_About.Size = new System.Drawing.Size(30, 30);
            this.button_Header_About.TabIndex = 0;
            this.button_Header_About.Click += new System.EventHandler(this.button_Header_About_Click);
            // 
            // tooltipComponent
            // 
            this.tooltipComponent.ArrowSize = 4;
            this.tooltipComponent.Radius = 4;
            // 
            // input_Text
            // 
            this.input_Text.HandCursor = System.Windows.Forms.Cursors.Default;
            this.input_Text.Location = new System.Drawing.Point(12, 36);
            this.input_Text.MaxLength = 2147483647;
            this.input_Text.Multiline = true;
            this.input_Text.Name = "input_Text";
            this.input_Text.Radius = 4;
            this.input_Text.Size = new System.Drawing.Size(347, 147);
            this.input_Text.TabIndex = 1;
            // 
            // radio_Mode1
            // 
            this.radio_Mode1.Checked = true;
            this.radio_Mode1.HandCursor = System.Windows.Forms.Cursors.Default;
            this.radio_Mode1.Location = new System.Drawing.Point(12, 189);
            this.radio_Mode1.Name = "radio_Mode1";
            this.radio_Mode1.Size = new System.Drawing.Size(108, 23);
            this.radio_Mode1.TabIndex = 2;
            this.radio_Mode1.Text = "已知不同文字";
            this.radio_Mode1.CheckedChanged += new AntdUI.BoolEventHandler(this.radio_Mode1_CheckedChanged);
            // 
            // radio_Mode2
            // 
            this.radio_Mode2.HandCursor = System.Windows.Forms.Cursors.Default;
            this.radio_Mode2.Location = new System.Drawing.Point(12, 218);
            this.radio_Mode2.Name = "radio_Mode2";
            this.radio_Mode2.Size = new System.Drawing.Size(108, 23);
            this.radio_Mode2.TabIndex = 3;
            this.radio_Mode2.Text = "已知相同文字";
            this.radio_Mode2.CheckedChanged += new AntdUI.BoolEventHandler(this.radio_Mode2_CheckedChanged);
            // 
            // label_dfText
            // 
            this.label_dfText.HandCursor = System.Windows.Forms.Cursors.Default;
            this.label_dfText.Location = new System.Drawing.Point(126, 189);
            this.label_dfText.Name = "label_dfText";
            this.label_dfText.Size = new System.Drawing.Size(75, 23);
            this.label_dfText.TabIndex = 4;
            this.label_dfText.Text = "不同文字：";
            // 
            // input_dfText
            // 
            this.input_dfText.HandCursor = System.Windows.Forms.Cursors.Default;
            this.input_dfText.Location = new System.Drawing.Point(191, 187);
            this.input_dfText.MaxLength = 1;
            this.input_dfText.Name = "input_dfText";
            this.input_dfText.Radius = 4;
            this.input_dfText.Size = new System.Drawing.Size(168, 30);
            this.input_dfText.TabIndex = 5;
            // 
            // button_Start
            // 
            this.button_Start.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_Start.Location = new System.Drawing.Point(126, 247);
            this.button_Start.Name = "button_Start";
            this.button_Start.Radius = 4;
            this.button_Start.Size = new System.Drawing.Size(233, 41);
            this.button_Start.TabIndex = 6;
            this.button_Start.Text = "开始搜寻";
            this.button_Start.Type = AntdUI.TTypeMini.Primary;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // input_undfText
            // 
            this.input_undfText.Enabled = false;
            this.input_undfText.HandCursor = System.Windows.Forms.Cursors.Default;
            this.input_undfText.Location = new System.Drawing.Point(191, 216);
            this.input_undfText.MaxLength = 1;
            this.input_undfText.Name = "input_undfText";
            this.input_undfText.Radius = 4;
            this.input_undfText.Size = new System.Drawing.Size(168, 30);
            this.input_undfText.TabIndex = 8;
            // 
            // label_undfText
            // 
            this.label_undfText.HandCursor = System.Windows.Forms.Cursors.Default;
            this.label_undfText.Location = new System.Drawing.Point(126, 218);
            this.label_undfText.Name = "label_undfText";
            this.label_undfText.Size = new System.Drawing.Size(75, 23);
            this.label_undfText.TabIndex = 7;
            this.label_undfText.Text = "相同文字：";
            // 
            // radio_Mode3
            // 
            this.radio_Mode3.HandCursor = System.Windows.Forms.Cursors.Default;
            this.radio_Mode3.Location = new System.Drawing.Point(12, 247);
            this.radio_Mode3.Name = "radio_Mode3";
            this.radio_Mode3.Size = new System.Drawing.Size(108, 23);
            this.radio_Mode3.TabIndex = 9;
            this.radio_Mode3.Text = "不同计数模式";
            this.radio_Mode3.CheckedChanged += new AntdUI.BoolEventHandler(this.radio_Mode3_CheckedChanged);
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 300);
            this.Controls.Add(this.radio_Mode3);
            this.Controls.Add(this.input_undfText);
            this.Controls.Add(this.label_undfText);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.input_dfText);
            this.Controls.Add(this.label_dfText);
            this.Controls.Add(this.radio_Mode2);
            this.Controls.Add(this.radio_Mode1);
            this.Controls.Add(this.input_Text);
            this.Controls.Add(this.pageHeader);
            this.EnableHitTest = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main_Window";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Window";
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.pageHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader pageHeader;
        private AntdUI.Button button_Header_About;
        private AntdUI.Button button_EULA;
        private AntdUI.TooltipComponent tooltipComponent;
        private AntdUI.Input input_Text;
        private AntdUI.Radio radio_Mode1;
        private AntdUI.Radio radio_Mode2;
        private AntdUI.Label label_dfText;
        private AntdUI.Input input_dfText;
        private AntdUI.Button button_Start;
        private AntdUI.Input input_undfText;
        private AntdUI.Label label_undfText;
        private AntdUI.Radio radio_Mode3;
    }
}

