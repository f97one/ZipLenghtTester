using System;
using System.Windows.Forms;

namespace ZipLengthTester
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string filepath = "";
            if (args != null && args.Length > 0)
            {
                filepath = args[0];
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(filepath));
        }
    }
}
