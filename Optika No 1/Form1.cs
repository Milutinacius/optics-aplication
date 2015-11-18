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
    public partial class Form1 : Form
    {
        private LoadingScreen _splashy;
        public Form1(LoadingScreen splashy)
        {
            _splashy = splashy;
            InitializeComponent();

            OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();
            builder.Add("Provider", Properties.Settings.Default.provider);
            builder.Add("Data Source", Properties.Settings.Default.path);
            connString = builder.ConnectionString;
            try
            {
                dbConn = new OleDbConnection(connString);
                dbConn.Open();
                loadDataGrid(query);
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            gridPacijenti.Columns[0].ReadOnly = true;
            gridPacijenti.Columns[0].DefaultCellStyle.ForeColor = Color.Gray;
        }
        string query = "SELECT SifraPacijenta, Ime, Prezime, DatumRodjenja, Adresa, Telefon FROM Pacijenti ORDER BY SifraPacijenta";
        string queryDioptrija;

        string connString;

        OleDbConnection dbConn;
        DataSet ds = new DataSet();
        OleDbDataAdapter da;

        DataTable data = null;
        //function to load dataGridView(Pacijenti)
        public void loadDataGrid(string sqlQuery)
        {
            OleDbCommand cmd = new OleDbCommand();
            
            gridPacijenti.DataSource = null;
            cmd.Connection = null;
            gridPacijenti.Columns.Clear();

            cmd.CommandText = sqlQuery;
            cmd.Connection = dbConn;
            data = new DataTable();
            da = new OleDbDataAdapter(cmd);
            OleDbCommandBuilder cmdBldr = new OleDbCommandBuilder(da);
            da.Fill(data);
            gridPacijenti.DataSource = data;
            gridPacijenti.AllowUserToAddRows = false;

            gridPacijenti.Columns[0].ReadOnly = true;
            gridPacijenti.Columns[0].DefaultCellStyle.ForeColor = Color.Gray;


            int i = gridPacijenti.Columns.Count;

            for (int j = 0; j < i; j++)
            {
                gridPacijenti.Columns[j].Width = Convert.ToInt32(148.4);
            }
        }
        DataTable dataDioptrija = null;
        public void loadDataDioptrija(string sqlQuery)
        {
            OleDbCommand cmd = new OleDbCommand();
            
            gridDioptrija.DataSource = null;
            cmd.Connection = null;
            gridDioptrija.Columns.Clear();

            cmd.CommandText = sqlQuery;
            cmd.Connection = dbConn;
            dataDioptrija = new DataTable();
            da = new OleDbDataAdapter(cmd);
            da.Fill(dataDioptrija);
            gridDioptrija.DataSource = dataDioptrija;
            
            gridDioptrija.AllowUserToAddRows = false;

            int i = gridDioptrija.Columns.Count;

            for (int j = 0; j < i; j++)
            {
                gridDioptrija.Columns[j].Width = Convert.ToInt32(148.4);
            }
            gridDioptrija.Columns[0].ReadOnly = true;
            gridDioptrija.Columns[0].DefaultCellStyle.ForeColor = Color.Gray;
            gridDioptrija.Columns[1].ReadOnly = true;
            gridDioptrija.Columns[1].DefaultCellStyle.ForeColor = Color.Gray;
        }
        
        //Previous record
        private void btnNavLeft_Click(object sender, EventArgs e)
        {
            int numOfRows = gridPacijenti.Rows.Count - 1;
            index = gridPacijenti.SelectedRows[0].Index;

            if (index != 0)
            {
                gridPacijenti.CurrentCell = gridPacijenti[0, index - 1];
            }
            else
            {
                gridPacijenti.CurrentCell = gridPacijenti[0, numOfRows];
                selectionLoadLast();
            }
            gridPacijenti_CellClick(gridPacijenti, new DataGridViewCellEventArgs(0, index - 1));
        }

        //First selection
        public void selectionLoad()
        {
            int numOfRows = gridPacijenti.Rows.Count - 1;
            index = gridPacijenti.SelectedRows[0].Index;
            gridPacijenti_CellClick(gridPacijenti, new DataGridViewCellEventArgs(0, index));
        }

        //Last selection
        public void selectionLoadLast()
        {
            int numOfRows = gridPacijenti.Rows.Count - 1;
            int lastRow = gridPacijenti.Rows.Count - 1;
            gridPacijenti_CellClick(gridPacijenti, new DataGridViewCellEventArgs(0, lastRow));
        }

        //Next record
        private void btnNavRight_Click(object sender, EventArgs e)
        {
            int numOfRows = gridPacijenti.Rows.Count - 1;
            index = gridPacijenti.SelectedRows[0].Index;

            if (index < numOfRows)
            {
                gridPacijenti.CurrentCell = gridPacijenti[0, index + 1];
                
            }
            else
            {
                gridPacijenti.CurrentCell = gridPacijenti[0, 0];
            }
            
            gridPacijenti_CellClick(gridPacijenti, new DataGridViewCellEventArgs(0, index + 1));
        }

        //First record
        private void btNav_First_Click(object sender, EventArgs e)
        {
            int numOfRows = gridPacijenti.Rows.Count - 1;
            gridPacijenti.CurrentCell = gridPacijenti[0, 0];
            selectionLoad();
        }

        //Last record
        private void btNav_Last_Click(object sender, EventArgs e)
        {
            int numOfRows = gridPacijenti.Rows.Count - 1;
            gridPacijenti.CurrentCell = gridPacijenti[0, numOfRows];
            selectionLoadLast();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {   
            int sifraPacijenta = int.Parse(gridPacijenti.SelectedRows[0].Cells[0].Value.ToString());

            OleDbConnection conn = new OleDbConnection(connString);

            conn.Open();

            OleDbCommand cmd = new OleDbCommand();

            if (isValueChanged == false)
            {
                try
                {
                    OleDbCommand cmdFill = new OleDbCommand();
                    cmdFill.Connection = conn;
                    cmdFill.CommandText = query;

                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds);

                    cmd.Connection = conn;

                    cmd.CommandText = String.Format("UPDATE Pacijenti SET Ime = '{0}', Prezime = '{1}', DatumRodjenja = '{2}', Adresa = '{3}', Telefon = '{4}' WHERE SifraPacijenta = {5}", tbIme.Text, tbPrezime.Text, dtpDatum.Text, tbAdresa.Text, tbTelefon.Text, sifraPacijenta);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Sve izmene su uspešno sačuvane!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isValueChanged = true;
                }
                catch
                {
                    MessageBox.Show("Proverite da li ste uneli sve podatke kako treba.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                /*Code for datagridview update based on changed value*/
                try
                {
                    using (var con = new OleDbConnection(connString))
                    {
                        using (var adapter = new OleDbDataAdapter(queryPacijenti, con))
                        {
                            using (new OleDbCommandBuilder(adapter))
                            {
                                adapter.Update(data);
                                conn.Close();
                            }
                        }
                    }
                    MessageBox.Show("Sve izmene su uspešno sačuvane!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isValueChanged = false;
                }
               catch
                {
                    MessageBox.Show("Proverite da li ste uneli sve podatke kako treba!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void brisanjePacijenta()
        {
            int sifraPacijenta = int.Parse(gridPacijenti.SelectedRows[0].Cells[0].Value.ToString());

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                using (da = new OleDbDataAdapter(queryPacijenti, conn))
                {
                    using (new OleDbCommandBuilder(da))
                    {
                        conn.Open();

                        OleDbCommand cmd = new OleDbCommand();

                        cmd.Connection = conn;
                        cmd.CommandText = String.Format("DELETE * FROM Pacijenti WHERE SifraPacijenta = {0}", sifraPacijenta);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Pacijent obrisan!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
        }

        private void brisanjeDioptrije()
        {
            int sifraPacijenta = int.Parse(gridPacijenti.SelectedRows[0].Cells[0].Value.ToString());

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                using (da = new OleDbDataAdapter(queryDioptrija, conn))
                {
                    using (new OleDbCommandBuilder(da))
                    {
                        conn.Open();

                        OleDbCommand cmd = new OleDbCommand();

                        cmd.Connection = conn;
                        cmd.CommandText = String.Format("DELETE * FROM Dioptrija WHERE SifraPacijenta = {0}", sifraPacijenta);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
        }

        string queryPacijenti = "SELECT * FROM Pacijenti";
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete selektovanog pacijenta?", "Brisanje pacijenta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Da li želite da obrišete i podatke svih pregleda?", "Brisanje pacijenta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    brisanjePacijenta();
                }
                else //brisanje pacijenta i svih njegovih dioptrija
                {
                    brisanjePacijenta();
                    brisanjeDioptrije();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                dbConn = new OleDbConnection(connString);
                dbConn.Open();
                loadDataGrid(query);
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            gridPacijenti_CellClick(gridPacijenti, new DataGridViewCellEventArgs(0, 0));
        }
       // public DataGridViewRow row;
        public void gridPacijenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int lastRow = gridPacijenti.Rows.Count - 1;
                DataGridViewRow row;

                if (e.RowIndex == lastRow + 1)
                {
                    gridPacijenti.CurrentCell = gridPacijenti[0, 0];
                    row = this.gridPacijenti.Rows[0];
                    tbIme.Text = row.Cells["Ime"].Value.ToString();
                    tbPrezime.Text = row.Cells["Prezime"].Value.ToString();
                    dtpDatum.Value = Convert.ToDateTime(row.Cells["DatumRodjenja"].Value.ToString());
                    tbAdresa.Text = row.Cells["Adresa"].Value.ToString();
                    tbTelefon.Text = row.Cells["Telefon"].Value.ToString();
                }
                else
                {
                    row = this.gridPacijenti.Rows[e.RowIndex];
                    tbIme.Text = row.Cells["Ime"].Value.ToString();
                    tbPrezime.Text = row.Cells["Prezime"].Value.ToString();
                    dtpDatum.Value = Convert.ToDateTime(row.Cells["DatumRodjenja"].Value.ToString());
                    tbAdresa.Text = row.Cells["Adresa"].Value.ToString();
                    tbTelefon.Text = row.Cells["Telefon"].Value.ToString();
                }
            }
        }

        int index;

        private void Form1_Load(object sender, EventArgs e)
        {
            selectionLoad();
            _splashy.Close();
            _splashy.Dispose();
        }

        bool isValueChanged = false;
        private void gridPacijenti_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            isValueChanged = true;
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipAdd = new ToolTip();
            this.Cursor = Cursors.Hand;
            tipAdd.SetToolTip(btnAdd, "Dodaj novog pacijenta/dioptriju");
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipSave = new ToolTip();
            this.Cursor = Cursors.Hand;
            tipSave.SetToolTip(btnSave, "Sačuvaj izmene");
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void btnRefresh_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipRefresh = new ToolTip();
            this.Cursor = Cursors.Hand;
            tipRefresh.SetToolTip(btnRefresh, "Osveži tabelu");
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipDelete = new ToolTip();
            this.Cursor = Cursors.Hand;
            tipDelete.SetToolTip(btnDelete, "Obriši");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NoviPacijent n = new NoviPacijent();
            n.ShowDialog();
        }

        static string a;
        private void gridPacijenti_SelectionChanged(object sender, EventArgs e)
        {
            if (gridPacijenti.SelectedCells.Count > 0)
            {
                int selectedRowIndex = gridPacijenti.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = gridPacijenti.Rows[selectedRowIndex];
                
                a = Convert.ToString(selectedRow.Cells[0].Value);

                queryDioptrija = String.Format("SELECT * FROM Dioptrija WHERE {0} = Dioptrija.SifraPacijenta ORDER BY SifraPregleda", Convert.ToInt32(a));

                loadDataDioptrija(queryDioptrija);
            }
        }

        public void clearAll()
        {
            tbPretragaImePrezime.Clear();
            tbPretragaImePrezime.Enabled = true;
            tbPretragaAdresa.Clear();
            tbPretragaAdresa.Enabled = true;
            tbPretragaBroj.Clear();
            tbPretragaBroj.Enabled = true;
            tbPretragaImePrezime.Focus();
            rbAdresa.Checked = false;
            rbBrojTelefona.Checked = false;
            rbImePrezime.Checked = false;
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void rbImePrezime_CheckedChanged(object sender, EventArgs e)
        {
            if (rbImePrezime.Checked)
            {
                tbPretragaAdresa.Enabled = false;
                tbPretragaBroj.Enabled = false;
                tbPretragaImePrezime.Enabled = true;
                tbPretragaAdresa.Clear();
                tbPretragaBroj.Clear();
                tbPretragaImePrezime.Focus();
            }
        }

        private void rbAdresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAdresa.Checked)
            {
                tbPretragaImePrezime.Enabled = false;
                tbPretragaBroj.Enabled = false;
                tbPretragaAdresa.Enabled = true;
                tbPretragaImePrezime.Clear();
                tbPretragaBroj.Clear();
                tbPretragaAdresa.Focus();
            }
        }

        private void rbBrojTelefona_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBrojTelefona.Checked)
            {
                tbPretragaImePrezime.Enabled = false;
                tbPretragaAdresa.Enabled = false;
                tbPretragaBroj.Enabled = true;
                tbPretragaImePrezime.Clear();
                tbPretragaAdresa.Clear();
                tbPretragaBroj.Focus();
            }
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand();
            DataTable table = null;
            cmd.Connection = conn;

            conn.Open();

            if (rbAdresa.Checked)
            {
                if (String.IsNullOrEmpty(tbPretragaAdresa.Text))
                {
                    MessageBox.Show("Proverite da li ste uneli podatke, pa potom kliknite na 'Pretraga'!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                table = new DataTable();
                cmd.CommandText = String.Format("SELECT SifraPacijenta, Ime, Prezime, DatumRodjenja, Adresa, Telefon FROM Pacijenti WHERE Adresa LIKE '%{0}%' ORDER BY SifraPacijenta", tbPretragaAdresa.Text);
                da = new OleDbDataAdapter(cmd);
                da.Fill(table);
            }
            else if (rbBrojTelefona.Checked)
            {
                if (String.IsNullOrEmpty(tbPretragaBroj.Text))
                {
                    MessageBox.Show("Proverite da li ste uneli podatke, pa potom kliknite na 'Pretraga'!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                table = new DataTable();
                cmd.CommandText = String.Format("SELECT SifraPacijenta, Ime, Prezime, DatumRodjenja, Adresa, Telefon FROM Pacijenti WHERE Telefon LIKE '%{0}%' ORDER BY SifraPacijenta", tbPretragaBroj.Text);
                da = new OleDbDataAdapter(cmd);
                da.Fill(table);
            }
            else if (rbImePrezime.Checked)
            {
                if (String.IsNullOrEmpty(tbPretragaImePrezime.Text))
                {
                    MessageBox.Show("Proverite da li ste uneli podatke, pa potom kliknite na 'Pretraga'!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                table = new DataTable();
                cmd.CommandText = String.Format("SELECT SifraPacijenta, Ime, Prezime, DatumRodjenja, Adresa, Telefon FROM Pacijenti WHERE Ime + ' ' + Prezime LIKE '%{0}%' ORDER BY SifraPacijenta", tbPretragaImePrezime.Text);
                da = new OleDbDataAdapter(cmd);
                da.Fill(table);
            }
            else
            {
                MessageBox.Show("Čekirajte jednu od opcija, unesite podatke, pa potom kliknite na 'Pretraga'!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            conn.Close();
            gridPacijenti.DataSource = table;
        }

        private void btnSaveDioptrija_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new OleDbConnection(connString))
                {
                    using (var adapter = new OleDbDataAdapter(queryDioptrija, con))
                    {
                        using (new OleDbCommandBuilder(adapter))
                        {
                            con.Open();
                            adapter.Update(dataDioptrija);
                            con.Close();
                        }
                    }
                }
                MessageBox.Show("Sve izmene su uspešno sačuvane!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isValueChanged = false;
            }
            catch
            {
                MessageBox.Show("Proverite da li ste uneli sve podatke kako treba!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDeleteDioptrija_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete selektovanu dioptriju?", "Brisanje pacijenta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                return;
            }
            else
            {
                int sifraPregleda = int.Parse(gridDioptrija.SelectedRows[0].Cells[0].Value.ToString());

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    using (da = new OleDbDataAdapter(queryDioptrija, conn))
                    {
                        using (new OleDbCommandBuilder(da))
                        {
                            conn.Open();

                            OleDbCommand cmd = new OleDbCommand();

                            cmd.Connection = conn;
                            cmd.CommandText = String.Format("DELETE * FROM Dioptrija WHERE SifraPregleda = {0}", sifraPregleda);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Dioptrija obrisana!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
            }
        }

        private void btnAdd2_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipAdd = new ToolTip();
            this.Cursor = Cursors.Hand;
            tipAdd.SetToolTip(btnAdd2, "Dodaj novog pacijenta/dioptriju");
        }

        private void btnAdd2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void btnSaveDioptrija_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipSave = new ToolTip();
            this.Cursor = Cursors.Hand;
            tipSave.SetToolTip(btnSaveDioptrija, "Sačuvaj izmene");
        }

        private void btnSaveDioptrija_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            NoviPacijent n = new NoviPacijent();
            n.ShowDialog();
        }

        private void btnDeleteDioptrija_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipDelete = new ToolTip();
            this.Cursor = Cursors.Hand;
            tipDelete.SetToolTip(btnDeleteDioptrija, "Obriši dioptriju");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipShowLatest = new ToolTip();
            this.Cursor = Cursors.Hand;
            tipShowLatest.SetToolTip(button1, "Prikaži podatke poslednjeg pregleda");
        }

        private void btnDeleteDioptrija_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        public string queryData = null;

        //prikaz poslednjeg pregleda selektovanog pacijenta
        private void button1_Click(object sender, EventArgs e)
        {
            int sifraPacijenta = int.Parse(gridPacijenti.SelectedRows[0].Cells[0].Value.ToString());

            string query = String.Format("SELECT MAX(SifraPregleda) FROM Dioptrija WHERE {0} = Dioptrija.SifraPacijenta", sifraPacijenta);

            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        try
                        {
                            maxValue = reader.GetInt32(0);
                        }
                        catch
                        {
                            MessageBox.Show("Nema unetih zapisa o selektovanom pacijentu!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            reader.Close();
                            connection.Close();
                            return;
                        }
                    }
                    reader.Close();
                }
                connection.Close();
            }
            PoslednjiPregled p = new PoslednjiPregled();
            p.ShowDialog();
        }

        public static int maxValue;

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}