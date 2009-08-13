using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Voltage
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
            Application.Run(new TestForm());
            return;
            if (new LoginSystem().ShowDialog() == DialogResult.OK)
            {
                Program.mainForm = new MainForm();
                Application.Run(Program.mainForm);
            }
            //Application.Run(new UC_zendChart());
        }
        public static MainForm mainForm;
    }
}
