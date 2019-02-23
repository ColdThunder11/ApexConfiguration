using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;

namespace ApexConfiguration
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (Mutex mutex = new Mutex(false, "Global\\ApexConfiguration_" + Application.StartupPath.GetHashCode()))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("另一个实例已经在运行，请耐心等待");
                    Application.Exit();
                    return;
                }
            }
            HotUpdate hotUpdate = new HotUpdate();
            if (hotUpdate.CheckUpdate())
            {
                hotUpdate.UpdateFormDll();
            }
            Assembly formAssembly = Assembly.LoadFrom(Environment.CurrentDirectory + @"\MainForm.dll");
            Type formType = formAssembly.GetType("ApexConfiguration.Form1");
            Form form = (Form)Activator.CreateInstance(formType);
            Application.Run(form);
        }
    }
}
