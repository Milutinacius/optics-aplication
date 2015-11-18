using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Optika_No_1
{
    public partial class ConnectionDefinition : Form
    {
        public ConnectionDefinition()
        {
            InitializeComponent();
        }

        OpenFileDialog op = new OpenFileDialog();

        private void btLokacija_Click(object sender, EventArgs e)
        {
            op.Filter = "Access 2013 (*.accdb) |*.accdb";
            op.Title = "Izaberite bazu";
            op.FileName = "";
            op.FilterIndex = 2;
            op.CheckFileExists = true;
            op.CheckPathExists = true;

            if (op.ShowDialog() == DialogResult.OK)
            {
                tbPutanja.Text = op.FileName;
            }
        }

        private void btPotvrdi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbPutanja.Text) || (op.CheckPathExists == false || op.CheckFileExists == false))
            {
                MessageBox.Show("Proverite da li ste uneli sve podatke kako treba!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string newConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + tbPutanja.Text;

            OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();

            builder.Add("Provider", "Microsoft.ACE.OLEDB.12.0");
            builder.Add("Data source", tbPutanja.Text);

            Program.ChangeConnectionString(builder.DataSource, builder.Provider);
            Properties.Settings.Default.Save();


            try
            {
                OleDbConnection dbConn = new OleDbConnection(builder.ConnectionString);
                dbConn.Open();
                dbConn.Close();
            }
            catch
            {
                MessageBox.Show("Lokacija baze ili naziv fajla nije ispravan! Moraćete ponovo da je definišete.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            LoadingScreen s = new LoadingScreen();
            Form1 f = new Form1(s);
            this.Hide();
            f.Show();
        }

        private void ConnectionDefinition_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
