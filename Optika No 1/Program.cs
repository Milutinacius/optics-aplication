using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Optika_No_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static void ChangeConnectionString(string path, string provider)
        {
            Properties.Settings.Default.path = path;
            Properties.Settings.Default.provider = provider;
            Properties.Settings.Default.Save();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();
                builder.Add("Provider", Properties.Settings.Default.provider);
                builder.Add("Data Source", Properties.Settings.Default.path);

                string connString = builder.ConnectionString;
                OleDbConnection conn = new OleDbConnection(connString);

                conn.Open();
                conn.Close();

                LoadingScreen splashy = new LoadingScreen();
                splashy.Show();

                Application.Run(new Form1(splashy));

                /*Form1 f = new Form1();
                f.Show();*/
                
            }
            catch
            {
                Application.Run(new ConnectionDefinition());
                /*ConnectionDefinition c = new ConnectionDefinition();
                c.Show();*/
            }

            //Application.Run(/*new ConnectionDefinition()*/);
        }
    }
}
