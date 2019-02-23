using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ApexConfiguration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string preConfigPath;
        string videoConfigpath;
        Dictionary<string, string> videoConfig;
        bool hasStartUp = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left -= this.Size.Width / 2;
            preConfigPath = Environment.CurrentDirectory + @"\PresetConfig\";
            videoConfigpath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            videoConfigpath = videoConfigpath.Remove(videoConfigpath.Length - 9) + @"Saved Games\Respawn\Apex\local\videoconfig.txt";
            string[] vidoeConfigStr = File.ReadAllLines(videoConfigpath);
            videoConfig = ApexConfig.Read2Dict(vidoeConfigStr);
            if (videoConfig["setting.configversion"] != "7")
            {
                MessageBox.Show("配置文件版本不匹配，请下载更新！");
                File.SetAttributes(videoConfigpath, FileAttributes.Normal);
                System.Diagnostics.Process.Start(@"https://coldthunder11.com/ApexConfiguration/Download");
                Application.Exit();
            }
            #region UISet
            if ((File.GetAttributes(videoConfigpath) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                ConfigReadonlyCheckBox.Checked = true;
            }
            if (videoConfig["setting.fullscreen"] == "1") DisplayModeComboBox.Text = "全屏";
            if (videoConfig["setting.fullscreen"] == "0" && videoConfig["setting.nowindowborder"] == "1") DisplayModeComboBox.Text = "无边框窗口化";
            if (videoConfig["setting.fullscreen"] == "0" && videoConfig["setting.nowindowborder"] == "0") DisplayModeComboBox.Text = "窗口化";
            RevolutionComboBox.Text = videoConfig["setting.defaultres"] + "*" + videoConfig["setting.defaultresheight"];
            DvsMinTextBox.Text = videoConfig["setting.dvs_gpuframetime_min"];
            DvsMaxTextBox.Text = videoConfig["setting.dvs_gpuframetime_max"];
            if (videoConfig["setting.dvs_supersample_enable"] == "1") DvsSpuersampleCheckBox1.Checked = true;
            LODTextBox.Text = videoConfig["setting.r_lod_switch_scale"];
            if (videoConfig["setting.cl_ragdoll_self_collision"] == "1") RagdollCheckBox.Checked = true;
            RagdollTextBox.Text = videoConfig["setting.cl_ragdoll_maxcount"];
            if (videoConfig["setting.r_decals"] == "1") DecalsCheckBox.Checked = true;
            if (!(videoConfig["setting.cl_particle_fallback_base"] == "0"&&videoConfig["setting.cl_particle_fallback_multiplier"] == "0")) ParticleCheckBox.Checked = true;
            if (videoConfig["setting.mat_antialias_mode"] == "12") AntialiasCheckBox.Checked = true;
            if (videoConfig["setting.dvs_enable"] == "1") DvsCheckBox.Checked = true;
            if (videoConfig["setting.ssao_enabled"] == "1") SSAOCheckBox.Checked = true;
            if (videoConfig["setting.shadow_enable"] == "1") ShadowCheckBox.Checked = true;
            GammaTextBox.Text = videoConfig["setting.gamma"];
            #endregion
            hasStartUp = true;
        }

        private void WriteFile()
        {
            //WriteFile
            if ((File.GetAttributes(videoConfigpath) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                File.SetAttributes(videoConfigpath, FileAttributes.Normal);
                ApexConfig.WriteDict2File(videoConfig, videoConfigpath);
                File.SetAttributes(videoConfigpath, FileAttributes.ReadOnly);
            }
            else
            {
                ApexConfig.WriteDict2File(videoConfig, videoConfigpath);
            }
        }

        private void LoadPresetConfig()
        {

        }

        private void CopyCLInfoButton_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            if (FSCheckBox.Checked == true)
            {
                sb.Append("-fullscreen ");
            }
            if (ShowFPSCheckBox.Checked == true)
            {
                sb.Append("+cl_showfps 2 ");
            }
            if (ShowPosCheckBox.Checked == true)
            {
                sb.Append("+cl_showpos 1 ");
            }
            if (UnlockFPSCheckBox.Checked == true)
            {
                sb.Append("+fps_max unlimited ");
            }
            if (PreloadCheckBox.Checked == true)
            {
                sb.Append("-preload ");
            }
            if (HighCheckBox.Checked == true)
            {
                sb.Append("-high ");
            }
            Clipboard.SetText(sb.ToString());
            MessageBox.Show("成功复制命令行参数到剪贴板");
        }

        private void DisplayModeComboBox_TextChanged(object sender, EventArgs e)
        {
            if (hasStartUp == true)
            {
                switch (DisplayModeComboBox.Text)
                {
                    case "全屏":
                        videoConfig["setting.fullscreen"] = "1";
                        break;
                    case "无边框窗口化":
                        videoConfig["setting.fullscreen"] = "0";
                        videoConfig["setting.nowindowborder"] = "1";
                        break;
                    case "窗口化":
                        videoConfig["setting.fullscreen"] = "0";
                        videoConfig["setting.nowindowborder"] = "0";
                        break;
                    default:
                        break;
                }
                WriteFile();
            }
        }

        private void ConfigReadonlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hasStartUp == true)
            {
                if (ConfigReadonlyCheckBox.Checked == true)
                {
                    File.SetAttributes(videoConfigpath, FileAttributes.ReadOnly);
                }
                else
                {
                    File.SetAttributes(videoConfigpath, FileAttributes.Normal);
                }
            }
        }

        private void PreConfigComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(PreConfigComboBox.Text== "最高性能")
            {
                string[] perConfigStr = File.ReadAllLines(preConfigPath + PreConfigComboBox.Text+".txt");
                var preConfig = ApexConfig.Read2Dict(perConfigStr);
                preConfig["setting.stream_memory"] = videoConfig["setting.stream_memory"];
                preConfig["setting.gamma"] = videoConfig["setting.gamma"];
                preConfig["setting.fullscreen"] = videoConfig["setting.fullscreen"];
                preConfig["setting.nowindowborder"] = videoConfig["setting.nowindowborder"];
                preConfig["setting.defaultres"] = videoConfig["setting.defaultres"];
                preConfig["setting.defaultresheight"] = videoConfig["setting.defaultresheight"];
                File.SetAttributes(videoConfigpath, FileAttributes.Normal);
                File.Copy(videoConfigpath, videoConfigpath + ".bak",true);
                ApexConfig.WriteDict2File(preConfig, videoConfigpath);
                File.SetAttributes(videoConfigpath, FileAttributes.ReadOnly);
                ConfigReadonlyCheckBox.Checked = true;
                MessageBox.Show("成功替换配置文件，原文件以.bak后缀备份");
                Form1_Load(this, null);
                this.Left += this.Size.Width / 2;
            }
        }

        private void RevolutionComboBox_TextChanged(object sender, EventArgs e)
        {
            if (hasStartUp == true)
            {
                if (RevolutionComboBox.Text.Contains("*"))
                {
                    string[] revolution = RevolutionComboBox.Text.Split('*');
                    if (int.TryParse(revolution[0], out int intTest) && int.TryParse(revolution[1], out intTest))
                    {
                        videoConfig["setting.defaultres"] = revolution[0];
                        videoConfig["setting.defaultresheight"] = revolution[1];
                    }
                    WriteFile();
                }
            }
        }

        private void AboutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://space.bilibili.com/11988933");
        }

        private void DvsMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (hasStartUp)
            {
                if (DvsMinTextBox.Text != string.Empty)
                {
                    videoConfig["setting.dvs_gpuframetime_min"] = DvsMinTextBox.Text;
                    WriteFile();
                }
            }
        }

        private void DvsMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (hasStartUp)
            {
                if (DvsMaxTextBox.Text != string.Empty)
                {
                    videoConfig["setting.dvs_gpuframetime_max"] = DvsMaxTextBox.Text;
                    WriteFile();
                }
            }
        }

        private void DvsSpuersampleCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (hasStartUp)
            {
                if (DvsSpuersampleCheckBox1.Checked == true) videoConfig["setting.dvs_supersample_enable"] = "1";
                else videoConfig["setting.dvs_supersample_enable"] = "0";
                WriteFile();
            }
        }

        private void LODTextBox_TextChanged(object sender, EventArgs e)
        {
            if (hasStartUp)
            {
                videoConfig["setting.r_lod_switch_scale"] = LODTextBox.Text;
                WriteFile();
            }
        }

        private void RagdollCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hasStartUp)
            {
                if(RagdollCheckBox.Checked)
                    videoConfig["setting.cl_ragdoll_self_collision"] = "1";
                else
                    videoConfig["setting.cl_ragdoll_self_collision"] = "0";
                WriteFile();
            }
        }

        private void RagdollTextBox_TextChanged(object sender, EventArgs e)
        {
            if (hasStartUp)
            {
                videoConfig["setting.cl_ragdoll_maxcount"] = RagdollTextBox.Text;
                WriteFile();
            }
        }

        private void DecalsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hasStartUp)
            {
                if (DecalsCheckBox.Checked)
                    videoConfig["setting.r_decals"] = "1";
                else
                    videoConfig["setting.r_decals"] = "0";
                WriteFile();
            }
        }

        private void ParticleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hasStartUp)
            {
                if (ParticleCheckBox.Checked)
                {
                    videoConfig["setting.cl_particle_fallback_base"] = "3";
                    videoConfig["setting.cl_particle_fallback_multiplier"] = "2";
                }
                else
                {
                    videoConfig["setting.cl_particle_fallback_base"] = "0";
                    videoConfig["setting.cl_particle_fallback_multiplier"] = "0";
                }
                WriteFile();
            }
        }

        private void AntialiasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hasStartUp)
            {
                if (AntialiasCheckBox.Checked)
                    videoConfig["etting.mat_antialias_mode"] = "12";
                else
                    videoConfig["etting.mat_antialias_mode"] = "0";
                WriteFile();
            }
        }

        private void DvsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hasStartUp)
            {
                if (DvsCheckBox.Checked)
                    videoConfig["setting.dvs_enable"] = "1";
                else
                    videoConfig["setting.dvs_enable"] = "0";
                WriteFile();
            }
        }

        private void SSAOCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hasStartUp)
            {
                if (SSAOCheckBox.Checked)
                    videoConfig["setting.ssao_enabled"] = "1";
                else
                    videoConfig["setting.ssao_enabled"] = "0";
                WriteFile();
            }
        }

        private void ShadowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hasStartUp)
            {
                if (ShadowCheckBox.Checked)
                    videoConfig["setting.shadow_enable"] = "1";
                else
                    videoConfig["setting.shadow_enable"] = "0";
                WriteFile();
            }
        }

        private void GammaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (hasStartUp)
            {
                videoConfig["setting.gamma"] = GammaTextBox.Text;
                WriteFile();
            }
        }

        private void RecoveryBakButton_Click(object sender, EventArgs e)
        {
            if(File.Exists(videoConfigpath + ".bak"))
            {
                File.SetAttributes(videoConfigpath, FileAttributes.Normal);
                File.SetAttributes(videoConfigpath + ".bak", FileAttributes.Normal);
                File.Copy(videoConfigpath + ".bak", videoConfigpath, true);
                File.Delete(videoConfigpath + ".bak");
                File.SetAttributes(videoConfigpath, FileAttributes.ReadOnly);
                MessageBox.Show("成功还原备份的配置文件");
            }
            else MessageBox.Show("未找到备份的配置文件");
        }
    }
}
