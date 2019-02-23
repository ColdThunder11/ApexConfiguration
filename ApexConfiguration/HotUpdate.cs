using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.IO;
using System.Windows.Forms;

namespace ApexConfiguration
{
    class HotUpdate
    {
        readonly string VersionFilePath = Environment.CurrentDirectory + @"\Version.txt";
        const string VersionFileUrl = "https://coldthunder11.com/ApexConfiguration/HotUpdate/Version.txt";
        const string DllFileUrl = "https://coldthunder11.com/ApexConfiguration/HotUpdate/MainForm.dll";
        const string PreConfigListUrl = "https://coldthunder11.com/ApexConfiguration/HotUpdate/PreConfigList.txt";
        string Version;

        public HotUpdate()
        {
            if (!File.Exists(VersionFilePath))
            {
                File.Create(VersionFilePath);
            }
            Version = File.ReadAllText(VersionFilePath);
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;// SecurityProtocolType.Tls1.2，被这个地方坑惨了......
        }
        //true-> have new version
        public bool CheckUpdate()
        {

            try
            {
                var request = WebRequest.Create(VersionFileUrl) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version10;
                var response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string versionString = reader.ReadToEnd();
                versionString = versionString.Trim('\n');
                responseStream.Close();
                if (versionString != Version)
                {
                    File.WriteAllText(VersionFilePath, versionString);
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("检查更新失败，请检查网络连接", "ApexConfiguration");
                return false;
            }
        }
        public void UpdateFormDll()
        {
            string dllPath = Environment.CurrentDirectory + @"\MainForm.dll";
            string tempFile = Environment.CurrentDirectory+ @"\HotUpdate.temp"; //临时文件
            //try
            //{
                FileStream fs = new FileStream(tempFile, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                HttpWebRequest request = WebRequest.Create(DllFileUrl) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream responseStream = response.GetResponseStream();
                byte[] bArr = new byte[1024];
                int size = responseStream.Read(bArr, 0, (int)bArr.Length);
                while (size > 0)
                {
                    fs.Write(bArr, 0, size);
                    size = responseStream.Read(bArr, 0, (int)bArr.Length);
                }
                fs.Close();
                responseStream.Close();
                File.Copy(tempFile, dllPath, true);
                File.Delete(tempFile);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("下载更新失败，请检查网络连接", "ApexConfiguration");
            //}
        }
        public void CheckPreConfigUpdate()
        {
            var request = WebRequest.Create(VersionFileUrl) as HttpWebRequest;
            request.ProtocolVersion = HttpVersion.Version10;
            var response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string versionString = reader.ReadToEnd();
        }
    }
}
