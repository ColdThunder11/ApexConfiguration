namespace ApexConfiguration
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
            this.label3 = new System.Windows.Forms.Label();
            this.PreConfigComboBox = new System.Windows.Forms.ComboBox();
            this.ConfigReadonlyCheckBox = new System.Windows.Forms.CheckBox();
            this.AboutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.HighCheckBox = new System.Windows.Forms.CheckBox();
            this.PreloadCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowPosCheckBox = new System.Windows.Forms.CheckBox();
            this.CopyCLInfoButton = new System.Windows.Forms.Button();
            this.UnlockFPSCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowFPSCheckBox = new System.Windows.Forms.CheckBox();
            this.FSCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ParticleCheckBox = new System.Windows.Forms.CheckBox();
            this.DecalsCheckBox = new System.Windows.Forms.CheckBox();
            this.RagdollCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RagdollTextBox = new System.Windows.Forms.TextBox();
            this.DvsSpuersampleCheckBox1 = new System.Windows.Forms.CheckBox();
            this.LODTextBox = new System.Windows.Forms.TextBox();
            this.DvsMaxTextBox = new System.Windows.Forms.TextBox();
            this.DvsMinTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.GammaTextBox = new System.Windows.Forms.TextBox();
            this.gammaLabel = new System.Windows.Forms.Label();
            this.ShadowCheckBox = new System.Windows.Forms.CheckBox();
            this.SSAOCheckBox = new System.Windows.Forms.CheckBox();
            this.DvsCheckBox = new System.Windows.Forms.CheckBox();
            this.AntialiasCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RecoveryBakButton = new System.Windows.Forms.Button();
            this.DisplayModeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RevolutionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "预置配置文件";
            // 
            // PreConfigComboBox
            // 
            this.PreConfigComboBox.FormattingEnabled = true;
            this.PreConfigComboBox.Items.AddRange(new object[] {
            "最高性能"});
            this.PreConfigComboBox.Location = new System.Drawing.Point(97, 16);
            this.PreConfigComboBox.Name = "PreConfigComboBox";
            this.PreConfigComboBox.Size = new System.Drawing.Size(121, 20);
            this.PreConfigComboBox.TabIndex = 2;
            this.PreConfigComboBox.SelectedIndexChanged += new System.EventHandler(this.PreConfigComboBox_SelectedIndexChanged);
            // 
            // ConfigReadonlyCheckBox
            // 
            this.ConfigReadonlyCheckBox.AutoSize = true;
            this.ConfigReadonlyCheckBox.Location = new System.Drawing.Point(16, 42);
            this.ConfigReadonlyCheckBox.Name = "ConfigReadonlyCheckBox";
            this.ConfigReadonlyCheckBox.Size = new System.Drawing.Size(264, 16);
            this.ConfigReadonlyCheckBox.TabIndex = 3;
            this.ConfigReadonlyCheckBox.Text = "将配置文件设为只读以防止被游戏内设置修改";
            this.ConfigReadonlyCheckBox.UseVisualStyleBackColor = true;
            this.ConfigReadonlyCheckBox.CheckedChanged += new System.EventHandler(this.ConfigReadonlyCheckBox_CheckedChanged);
            // 
            // AboutLinkLabel
            // 
            this.AboutLinkLabel.AutoSize = true;
            this.AboutLinkLabel.Location = new System.Drawing.Point(209, 398);
            this.AboutLinkLabel.Name = "AboutLinkLabel";
            this.AboutLinkLabel.Size = new System.Drawing.Size(71, 12);
            this.AboutLinkLabel.TabIndex = 4;
            this.AboutLinkLabel.TabStop = true;
            this.AboutLinkLabel.Text = "by 哇咔呢呀";
            this.AboutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutLinkLabel_LinkClicked);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.HighCheckBox);
            this.tabPage3.Controls.Add(this.PreloadCheckBox);
            this.tabPage3.Controls.Add(this.ShowPosCheckBox);
            this.tabPage3.Controls.Add(this.CopyCLInfoButton);
            this.tabPage3.Controls.Add(this.UnlockFPSCheckBox);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.ShowFPSCheckBox);
            this.tabPage3.Controls.Add(this.FSCheckBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(264, 305);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "命令行参数";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // HighCheckBox
            // 
            this.HighCheckBox.AutoSize = true;
            this.HighCheckBox.Location = new System.Drawing.Point(4, 147);
            this.HighCheckBox.Name = "HighCheckBox";
            this.HighCheckBox.Size = new System.Drawing.Size(192, 16);
            this.HighCheckBox.TabIndex = 7;
            this.HighCheckBox.Text = "以“高”的进程优先级启动游戏";
            this.HighCheckBox.UseVisualStyleBackColor = true;
            // 
            // PreloadCheckBox
            // 
            this.PreloadCheckBox.AutoSize = true;
            this.PreloadCheckBox.Location = new System.Drawing.Point(4, 125);
            this.PreloadCheckBox.Name = "PreloadCheckBox";
            this.PreloadCheckBox.Size = new System.Drawing.Size(84, 16);
            this.PreloadCheckBox.TabIndex = 6;
            this.PreloadCheckBox.Text = "强制预加载";
            this.PreloadCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowPosCheckBox
            // 
            this.ShowPosCheckBox.AutoSize = true;
            this.ShowPosCheckBox.Location = new System.Drawing.Point(4, 79);
            this.ShowPosCheckBox.Name = "ShowPosCheckBox";
            this.ShowPosCheckBox.Size = new System.Drawing.Size(120, 16);
            this.ShowPosCheckBox.TabIndex = 5;
            this.ShowPosCheckBox.Text = "显示角色位置信息";
            this.ShowPosCheckBox.UseVisualStyleBackColor = true;
            // 
            // CopyCLInfoButton
            // 
            this.CopyCLInfoButton.Location = new System.Drawing.Point(6, 169);
            this.CopyCLInfoButton.Name = "CopyCLInfoButton";
            this.CopyCLInfoButton.Size = new System.Drawing.Size(147, 23);
            this.CopyCLInfoButton.TabIndex = 4;
            this.CopyCLInfoButton.Text = "复制命令行参数到剪贴板";
            this.CopyCLInfoButton.UseVisualStyleBackColor = true;
            this.CopyCLInfoButton.Click += new System.EventHandler(this.CopyCLInfoButton_Click);
            // 
            // UnlockFPSCheckBox
            // 
            this.UnlockFPSCheckBox.AutoSize = true;
            this.UnlockFPSCheckBox.Location = new System.Drawing.Point(4, 102);
            this.UnlockFPSCheckBox.Name = "UnlockFPSCheckBox";
            this.UnlockFPSCheckBox.Size = new System.Drawing.Size(96, 16);
            this.UnlockFPSCheckBox.TabIndex = 3;
            this.UnlockFPSCheckBox.Text = "解锁帧率上限";
            this.UnlockFPSCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "这里生成的参数需要复制到origin内Apex的启动\r\n命令行参数";
            // 
            // ShowFPSCheckBox
            // 
            this.ShowFPSCheckBox.AutoSize = true;
            this.ShowFPSCheckBox.Location = new System.Drawing.Point(4, 57);
            this.ShowFPSCheckBox.Name = "ShowFPSCheckBox";
            this.ShowFPSCheckBox.Size = new System.Drawing.Size(90, 16);
            this.ShowFPSCheckBox.TabIndex = 1;
            this.ShowFPSCheckBox.Text = "显示FPS信息";
            this.ShowFPSCheckBox.UseVisualStyleBackColor = true;
            // 
            // FSCheckBox
            // 
            this.FSCheckBox.AutoSize = true;
            this.FSCheckBox.Location = new System.Drawing.Point(4, 35);
            this.FSCheckBox.Name = "FSCheckBox";
            this.FSCheckBox.Size = new System.Drawing.Size(72, 16);
            this.FSCheckBox.TabIndex = 0;
            this.FSCheckBox.Text = "强制全屏";
            this.FSCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ParticleCheckBox);
            this.tabPage2.Controls.Add(this.DecalsCheckBox);
            this.tabPage2.Controls.Add(this.RagdollCheckBox);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.RagdollTextBox);
            this.tabPage2.Controls.Add(this.DvsSpuersampleCheckBox1);
            this.tabPage2.Controls.Add(this.LODTextBox);
            this.tabPage2.Controls.Add(this.DvsMaxTextBox);
            this.tabPage2.Controls.Add(this.DvsMinTextBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(264, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "视频（高级）";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ParticleCheckBox
            // 
            this.ParticleCheckBox.AutoSize = true;
            this.ParticleCheckBox.Location = new System.Drawing.Point(81, 173);
            this.ParticleCheckBox.Name = "ParticleCheckBox";
            this.ParticleCheckBox.Size = new System.Drawing.Size(72, 16);
            this.ParticleCheckBox.TabIndex = 16;
            this.ParticleCheckBox.Text = "粒子特效";
            this.ParticleCheckBox.UseVisualStyleBackColor = true;
            this.ParticleCheckBox.CheckedChanged += new System.EventHandler(this.ParticleCheckBox_CheckedChanged);
            // 
            // DecalsCheckBox
            // 
            this.DecalsCheckBox.AutoSize = true;
            this.DecalsCheckBox.Location = new System.Drawing.Point(6, 173);
            this.DecalsCheckBox.Name = "DecalsCheckBox";
            this.DecalsCheckBox.Size = new System.Drawing.Size(48, 16);
            this.DecalsCheckBox.TabIndex = 15;
            this.DecalsCheckBox.Text = "贴花";
            this.DecalsCheckBox.UseVisualStyleBackColor = true;
            this.DecalsCheckBox.CheckedChanged += new System.EventHandler(this.DecalsCheckBox_CheckedChanged);
            // 
            // RagdollCheckBox
            // 
            this.RagdollCheckBox.AutoSize = true;
            this.RagdollCheckBox.Location = new System.Drawing.Point(162, 124);
            this.RagdollCheckBox.Name = "RagdollCheckBox";
            this.RagdollCheckBox.Size = new System.Drawing.Size(96, 16);
            this.RagdollCheckBox.TabIndex = 14;
            this.RagdollCheckBox.Text = "布娃娃间碰撞";
            this.RagdollCheckBox.UseVisualStyleBackColor = true;
            this.RagdollCheckBox.CheckedChanged += new System.EventHandler(this.RagdollCheckBox_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "最大布娃娃数量";
            // 
            // RagdollTextBox
            // 
            this.RagdollTextBox.Location = new System.Drawing.Point(97, 146);
            this.RagdollTextBox.Name = "RagdollTextBox";
            this.RagdollTextBox.Size = new System.Drawing.Size(100, 21);
            this.RagdollTextBox.TabIndex = 12;
            this.RagdollTextBox.TextChanged += new System.EventHandler(this.RagdollTextBox_TextChanged);
            // 
            // DvsSpuersampleCheckBox1
            // 
            this.DvsSpuersampleCheckBox1.AutoSize = true;
            this.DvsSpuersampleCheckBox1.Location = new System.Drawing.Point(5, 100);
            this.DvsSpuersampleCheckBox1.Name = "DvsSpuersampleCheckBox1";
            this.DvsSpuersampleCheckBox1.Size = new System.Drawing.Size(168, 16);
            this.DvsSpuersampleCheckBox1.TabIndex = 11;
            this.DvsSpuersampleCheckBox1.Text = "为动态分辨率启用超级采样";
            this.DvsSpuersampleCheckBox1.UseVisualStyleBackColor = true;
            this.DvsSpuersampleCheckBox1.CheckedChanged += new System.EventHandler(this.DvsSpuersampleCheckBox1_CheckedChanged);
            // 
            // LODTextBox
            // 
            this.LODTextBox.Location = new System.Drawing.Point(51, 122);
            this.LODTextBox.Name = "LODTextBox";
            this.LODTextBox.Size = new System.Drawing.Size(100, 21);
            this.LODTextBox.TabIndex = 8;
            this.LODTextBox.TextChanged += new System.EventHandler(this.LODTextBox_TextChanged);
            // 
            // DvsMaxTextBox
            // 
            this.DvsMaxTextBox.Location = new System.Drawing.Point(157, 73);
            this.DvsMaxTextBox.Name = "DvsMaxTextBox";
            this.DvsMaxTextBox.Size = new System.Drawing.Size(100, 21);
            this.DvsMaxTextBox.TabIndex = 6;
            this.DvsMaxTextBox.TextChanged += new System.EventHandler(this.DvsMaxTextBox_TextChanged);
            // 
            // DvsMinTextBox
            // 
            this.DvsMinTextBox.Location = new System.Drawing.Point(158, 49);
            this.DvsMinTextBox.Name = "DvsMinTextBox";
            this.DvsMinTextBox.Size = new System.Drawing.Size(100, 21);
            this.DvsMinTextBox.TabIndex = 5;
            this.DvsMinTextBox.TextChanged += new System.EventHandler(this.DvsMinTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "LOD等级";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "动态分辨率最大帧生成时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "动态分辨率最小帧生成时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "注意：这些设置可能会非正常覆盖游戏内设置\r\n这里的设置被修改后，若配置文件不为只读将会\r\n在游戏内打开设置页面时失效！";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.GammaTextBox);
            this.tabPage4.Controls.Add(this.gammaLabel);
            this.tabPage4.Controls.Add(this.ShadowCheckBox);
            this.tabPage4.Controls.Add(this.SSAOCheckBox);
            this.tabPage4.Controls.Add(this.DvsCheckBox);
            this.tabPage4.Controls.Add(this.AntialiasCheckBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(264, 305);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "视频";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // GammaTextBox
            // 
            this.GammaTextBox.Location = new System.Drawing.Point(50, 92);
            this.GammaTextBox.Name = "GammaTextBox";
            this.GammaTextBox.Size = new System.Drawing.Size(100, 21);
            this.GammaTextBox.TabIndex = 12;
            this.GammaTextBox.TextChanged += new System.EventHandler(this.GammaTextBox_TextChanged);
            // 
            // gammaLabel
            // 
            this.gammaLabel.AutoSize = true;
            this.gammaLabel.Location = new System.Drawing.Point(4, 95);
            this.gammaLabel.Name = "gammaLabel";
            this.gammaLabel.Size = new System.Drawing.Size(35, 12);
            this.gammaLabel.TabIndex = 11;
            this.gammaLabel.Text = "Gamma";
            // 
            // ShadowCheckBox
            // 
            this.ShadowCheckBox.AutoSize = true;
            this.ShadowCheckBox.Location = new System.Drawing.Point(3, 70);
            this.ShadowCheckBox.Name = "ShadowCheckBox";
            this.ShadowCheckBox.Size = new System.Drawing.Size(48, 16);
            this.ShadowCheckBox.TabIndex = 5;
            this.ShadowCheckBox.Text = "阴影";
            this.ShadowCheckBox.UseVisualStyleBackColor = true;
            this.ShadowCheckBox.CheckedChanged += new System.EventHandler(this.ShadowCheckBox_CheckedChanged);
            // 
            // SSAOCheckBox
            // 
            this.SSAOCheckBox.AutoSize = true;
            this.SSAOCheckBox.Location = new System.Drawing.Point(3, 47);
            this.SSAOCheckBox.Name = "SSAOCheckBox";
            this.SSAOCheckBox.Size = new System.Drawing.Size(132, 16);
            this.SSAOCheckBox.TabIndex = 4;
            this.SSAOCheckBox.Text = "环境光遮蔽（SSAO）";
            this.SSAOCheckBox.UseVisualStyleBackColor = true;
            this.SSAOCheckBox.CheckedChanged += new System.EventHandler(this.SSAOCheckBox_CheckedChanged);
            // 
            // DvsCheckBox
            // 
            this.DvsCheckBox.AutoSize = true;
            this.DvsCheckBox.Location = new System.Drawing.Point(3, 25);
            this.DvsCheckBox.Name = "DvsCheckBox";
            this.DvsCheckBox.Size = new System.Drawing.Size(84, 16);
            this.DvsCheckBox.TabIndex = 3;
            this.DvsCheckBox.Text = "动态分辨率";
            this.DvsCheckBox.UseVisualStyleBackColor = true;
            this.DvsCheckBox.CheckedChanged += new System.EventHandler(this.DvsCheckBox_CheckedChanged);
            // 
            // AntialiasCheckBox
            // 
            this.AntialiasCheckBox.AutoSize = true;
            this.AntialiasCheckBox.Location = new System.Drawing.Point(3, 3);
            this.AntialiasCheckBox.Name = "AntialiasCheckBox";
            this.AntialiasCheckBox.Size = new System.Drawing.Size(60, 16);
            this.AntialiasCheckBox.TabIndex = 2;
            this.AntialiasCheckBox.Text = "抗锯齿";
            this.AntialiasCheckBox.UseVisualStyleBackColor = true;
            this.AntialiasCheckBox.CheckedChanged += new System.EventHandler(this.AntialiasCheckBox_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RecoveryBakButton);
            this.tabPage1.Controls.Add(this.DisplayModeComboBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.RevolutionComboBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(264, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "显示";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RecoveryBakButton
            // 
            this.RecoveryBakButton.Location = new System.Drawing.Point(3, 276);
            this.RecoveryBakButton.Name = "RecoveryBakButton";
            this.RecoveryBakButton.Size = new System.Drawing.Size(125, 23);
            this.RecoveryBakButton.TabIndex = 4;
            this.RecoveryBakButton.Text = "还原备份的配置文件";
            this.RecoveryBakButton.UseVisualStyleBackColor = true;
            this.RecoveryBakButton.Click += new System.EventHandler(this.RecoveryBakButton_Click);
            // 
            // DisplayModeComboBox
            // 
            this.DisplayModeComboBox.FormattingEnabled = true;
            this.DisplayModeComboBox.Items.AddRange(new object[] {
            "全屏",
            "无边框窗口化",
            "窗口化"});
            this.DisplayModeComboBox.Location = new System.Drawing.Point(67, 13);
            this.DisplayModeComboBox.Name = "DisplayModeComboBox";
            this.DisplayModeComboBox.Size = new System.Drawing.Size(121, 20);
            this.DisplayModeComboBox.TabIndex = 3;
            this.DisplayModeComboBox.TextChanged += new System.EventHandler(this.DisplayModeComboBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "显示模式";
            // 
            // RevolutionComboBox
            // 
            this.RevolutionComboBox.FormattingEnabled = true;
            this.RevolutionComboBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.RevolutionComboBox.Items.AddRange(new object[] {
            "1024*768",
            "1280*1024",
            "1280*720",
            "1366*768",
            "1920*1080"});
            this.RevolutionComboBox.Location = new System.Drawing.Point(67, 39);
            this.RevolutionComboBox.Name = "RevolutionComboBox";
            this.RevolutionComboBox.Size = new System.Drawing.Size(121, 20);
            this.RevolutionComboBox.TabIndex = 1;
            this.RevolutionComboBox.TextChanged += new System.EventHandler(this.RevolutionComboBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "分辨率";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(272, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 416);
            this.Controls.Add(this.AboutLinkLabel);
            this.Controls.Add(this.ConfigReadonlyCheckBox);
            this.Controls.Add(this.PreConfigComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApexConfiguration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PreConfigComboBox;
        private System.Windows.Forms.CheckBox ConfigReadonlyCheckBox;
        private System.Windows.Forms.LinkLabel AboutLinkLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox HighCheckBox;
        private System.Windows.Forms.CheckBox PreloadCheckBox;
        private System.Windows.Forms.CheckBox ShowPosCheckBox;
        private System.Windows.Forms.Button CopyCLInfoButton;
        private System.Windows.Forms.CheckBox UnlockFPSCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ShowFPSCheckBox;
        private System.Windows.Forms.CheckBox FSCheckBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox ParticleCheckBox;
        private System.Windows.Forms.CheckBox DecalsCheckBox;
        private System.Windows.Forms.CheckBox RagdollCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RagdollTextBox;
        private System.Windows.Forms.CheckBox DvsSpuersampleCheckBox1;
        private System.Windows.Forms.TextBox LODTextBox;
        private System.Windows.Forms.TextBox DvsMaxTextBox;
        private System.Windows.Forms.TextBox DvsMinTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox GammaTextBox;
        private System.Windows.Forms.Label gammaLabel;
        private System.Windows.Forms.CheckBox ShadowCheckBox;
        private System.Windows.Forms.CheckBox SSAOCheckBox;
        private System.Windows.Forms.CheckBox DvsCheckBox;
        private System.Windows.Forms.CheckBox AntialiasCheckBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox DisplayModeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RevolutionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button RecoveryBakButton;
    }
}

