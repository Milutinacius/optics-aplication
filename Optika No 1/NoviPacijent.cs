using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Drawing2D;

namespace Optika_No_1
{
    public partial class NoviPacijent : Form
    {
        public NoviPacijent()
        {
            InitializeComponent();

            OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();
            builder.Add("Provider", Properties.Settings.Default.provider);
            builder.Add("Data Source", Properties.Settings.Default.path);
            connString = builder.ConnectionString;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void clearPacient()
        {
            tbAdresa.Clear();
            tbIme.Clear();
            tbPrezime.Clear();
            tbTelefon.Clear();
        }

        public void clearDioptrija()
        {
            tbDijagnoza.Clear();

            tbDsphDaljinaOD.Clear();
            tbDsphDaljinaOS.Clear();
            tbDsphBlizinaOD.Clear();
            tbDsphBlizinaOS.Clear();
            tbDcylDaljinaOD.Clear();
            tbDcylDaljinaOS.Clear();
            tbDcylBlizinaOD.Clear();
            tbDcylBlizinaOS.Clear();
            tbOsDaljinaOD.Clear();
            tbOsDaljinaOS.Clear();
            tbOsBlizinaOD.Clear();
            tbOsBlizinaOS.Clear();
            tbDeltaDaljinaOD.Clear();
            tbDeltaDaljinaOS.Clear();
            tbDeltaBlizinaOD.Clear();
            tbDeltaBlizinaOS.Clear();
            tbPDDaljinaOD.Clear();
            tbPDDaljinaOS.Clear();
            tbPDBlizinaOD.Clear();
            tbPDBlizinaOS.Clear();
            tbVrstaStakla.Clear();
            tbPreporuka.Clear();
            rtbNapomena.Clear();
            tbPregledao.Clear();
        }

        public void clearAll()
        {
            if (rbPacijent.Checked)
            {
                clearDioptrija();
                clearPacient();
            }
            else if (rbDioptrija.Checked)
            {
                clearDioptrija();
            }
            resetTable();
            resetTableRow2();
        }

        //Method enables and disables desired tab of a tab control
        public static void EnableTab(TabPage page, bool enable)
        {
            foreach (Control ctl in page.Controls)
            {
                ctl.Enabled = enable;
            }
        }

        private void rbDioptrija_CheckedChanged(object sender, EventArgs e)
        {
            EnableTab(tabPacijent, false);
            clearPacient();
            lblPacijenti.Visible = true;
            cmbPacijent.Visible = true;
            tbPretragaPacijenata.Visible = true;
            gbPacijent.Text = "Nova dioptrija";
        }

        private void rbPacijent_CheckedChanged(object sender, EventArgs e)
        {
            EnableTab(tabPacijent, true);
            lblPacijenti.Visible = false;
            cmbPacijent.Visible = false;
            tbPretragaPacijenata.Visible = false;
            gbPacijent.Text = "Novi pacijent";
        }

        private void btOcisti_Click(object sender, EventArgs e)
        {
            clearAll();
            resetTable();
            resetTableRow2();
        }

        private void NoviPacijent_Load(object sender, EventArgs e)
        {
            readData();

            this.cmbPacijent.DataSource = itemsList;
            this.cmbPacijent.DisplayMember = "Text";
            this.cmbPacijent.ValueMember = "Value";

            pictureBox2.Image = Properties.Resources.Tabela;
            readMax();

            cmbPacijent.DropDownWidth = DropDownWidth(cmbPacijent);
        }

        string connString;
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();

        //List for combobox items
        List<ComboBoxItem> itemsList = new List<ComboBoxItem>();

        public void readData()
        {
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand("SELECT SifraPacijenta, Ime + ' ' + Prezime AS Pacijent FROM Pacijenti", connection))
                {
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int sifra = reader.GetInt32(0);
                        string imePrezime = reader.GetString(1);

                        ComboBoxItem item = new ComboBoxItem();
                        item.Text = imePrezime;
                        item.Value = sifra.ToString();

                        itemsList.Add(item);
                        
                        cmbPacijent.Items.Add(item);
                        cmbPacijent.SelectedIndex = 0;
                    }
                    reader.Close();
                }
                connection.Close();
            }
        }

        int maxValue;
        
        public void readMax()
        {
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand("SELECT MAX(SifraPacijenta) FROM Pacijenti", connection))
                {
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        maxValue = reader.GetInt32(0);
                    }
                    reader.Close();
                }
                connection.Close();
            }
        }
        int pacijentSifra;
        public void insertD()
        {
            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open();
            OleDbCommand cmd2 = new OleDbCommand();
            cmd2.Connection = conn;
            double vodDouble = 0, vosDouble = 0;

            if (rbDioptrija.Checked)
            {
                if (((vod01 == false && vod02 == false && vod03 == false && vod04 == false && vod05 == false && vod06 == false && vod07 == false && vod08 == false && vod09 == false && vod10 == false) || (vos01 == false && vos02 == false && vos03 == false && vos04 == false && vos05 == false && vos06 == false && vos07 == false && vos08 == false && vos09 == false && vos10 == false)) || String.IsNullOrEmpty(rtbNapomena.Text) || String.IsNullOrEmpty(tbDijagnoza.Text) || String.IsNullOrEmpty(tbPreporuka.Text))
                {
                    /*tbDijagnoza.Text = "/";
                    tbPreporuka.Text = "/";
                    rtbNapomena.Text = "/";*/
                    cmd2.CommandText = String.Format("INSERT INTO Dioptrija(SifraPacijenta, Dijagnoza, DsphDaljinaOD, DsphDaljinaOS, DsphBlizinaOD, DsphBlizinaOS, DcylDaljinaOD, DcylDaljinaOS, DcylBlizinaOD, DcylBlizinaOS, OsDaljinaOD, OsDaljinaOS, OsBlizinaOD, OsBlizinaOS, DeltaDaljinaOD, DeltaDaljinaOS, DeltaBlizinaOD, DeltaBlizinaOS, PDDaljinaOD, PDDaljinaOS, PDBlizinaOD, PDBlizinaOS, OstrinaVODCC, OstrinaVOSCC, VrstaStakla, PreporukaPomagala, Napomena, DatumIzdavanja, Pregledao) VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}')", Convert.ToInt32(cmbPacijent.SelectedValue), tbDijagnoza.Text, Convert.ToDouble(tbDsphDaljinaOD.Text), Convert.ToDouble(tbDsphDaljinaOS.Text), Convert.ToDouble(tbDsphBlizinaOD.Text), Convert.ToDouble(tbDsphBlizinaOS.Text), Convert.ToDouble(tbDcylDaljinaOD.Text), Convert.ToDouble(tbDcylDaljinaOS.Text), Convert.ToDouble(tbDcylBlizinaOD.Text), Convert.ToDouble(tbDcylBlizinaOS.Text), Convert.ToDouble(tbOsDaljinaOD.Text), Convert.ToDouble(tbOsDaljinaOS.Text), Convert.ToDouble(tbOsBlizinaOD.Text), Convert.ToDouble(tbOsBlizinaOS.Text), Convert.ToDouble(tbDeltaDaljinaOD.Text), Convert.ToDouble(tbDeltaDaljinaOS.Text), Convert.ToDouble(tbDeltaBlizinaOD.Text), Convert.ToDouble(tbDeltaBlizinaOS.Text), Convert.ToDouble(tbPDDaljinaOD.Text), Convert.ToDouble(tbPDDaljinaOS.Text), Convert.ToDouble(tbPDBlizinaOD.Text), Convert.ToDouble(tbPDBlizinaOS.Text), vodDouble, vosDouble, tbVrstaStakla.Text, tbPreporuka.Text, rtbNapomena.Text, dtpDatumIzdavanja.Text, tbPregledao.Text);
                }

                else cmd2.CommandText = String.Format("INSERT INTO Dioptrija(SifraPacijenta, Dijagnoza, DsphDaljinaOD, DsphDaljinaOS, DsphBlizinaOD, DsphBlizinaOS, DcylDaljinaOD, DcylDaljinaOS, DcylBlizinaOD, DcylBlizinaOS, OsDaljinaOD, OsDaljinaOS, OsBlizinaOD, OsBlizinaOS, DeltaDaljinaOD, DeltaDaljinaOS, DeltaBlizinaOD, DeltaBlizinaOS, PDDaljinaOD, PDDaljinaOS, PDBlizinaOD, PDBlizinaOS, OstrinaVODCC, OstrinaVOSCC, VrstaStakla, PreporukaPomagala, Napomena, DatumIzdavanja, Pregledao) VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}')", Convert.ToInt32(cmbPacijent.SelectedValue), tbDijagnoza.Text, Convert.ToDouble(tbDsphDaljinaOD.Text), Convert.ToDouble(tbDsphDaljinaOS.Text), Convert.ToDouble(tbDsphBlizinaOD.Text), Convert.ToDouble(tbDsphBlizinaOS.Text), Convert.ToDouble(tbDcylDaljinaOD.Text), Convert.ToDouble(tbDcylDaljinaOS.Text), Convert.ToDouble(tbDcylBlizinaOD.Text), Convert.ToDouble(tbDcylBlizinaOS.Text), Convert.ToDouble(tbOsDaljinaOD.Text), Convert.ToDouble(tbOsDaljinaOS.Text), Convert.ToDouble(tbOsBlizinaOD.Text), Convert.ToDouble(tbOsBlizinaOS.Text), Convert.ToDouble(tbDeltaDaljinaOD.Text), Convert.ToDouble(tbDeltaDaljinaOS.Text), Convert.ToDouble(tbDeltaBlizinaOD.Text), Convert.ToDouble(tbDeltaBlizinaOS.Text), Convert.ToDouble(tbPDDaljinaOD.Text), Convert.ToDouble(tbPDDaljinaOS.Text), Convert.ToDouble(tbPDBlizinaOD.Text), Convert.ToDouble(tbPDBlizinaOS.Text), vod, vos, tbVrstaStakla.Text, tbPreporuka.Text, rtbNapomena.Text, dtpDatumIzdavanja.Text, tbPregledao.Text);
            }
            else
            {
                if (((vod01 == false && vod02 == false && vod03 == false && vod04 == false && vod05 == false && vod06 == false && vod07 == false && vod08 == false && vod09 == false && vod10 == false) || (vos01 == false && vos02 == false && vos03 == false && vos04 == false && vos05 == false && vos06 == false && vos07 == false && vos08 == false && vos09 == false && vos10 == false)) || String.IsNullOrEmpty(rtbNapomena.Text) || String.IsNullOrEmpty(tbDijagnoza.Text) || String.IsNullOrEmpty(tbPreporuka.Text))
                {
                    /*tbDijagnoza.Text = "/";
                    tbPreporuka.Text = "/";
                    rtbNapomena.Text = "/";*/
                    cmd2.CommandText = String.Format("INSERT INTO Dioptrija(SifraPacijenta, Dijagnoza, DsphDaljinaOD, DsphDaljinaOS, DsphBlizinaOD, DsphBlizinaOS, DcylDaljinaOD, DcylDaljinaOS, DcylBlizinaOD, DcylBlizinaOS, OsDaljinaOD, OsDaljinaOS, OsBlizinaOD, OsBlizinaOS, DeltaDaljinaOD, DeltaDaljinaOS, DeltaBlizinaOD, DeltaBlizinaOS, PDDaljinaOD, PDDaljinaOS, PDBlizinaOD, PDBlizinaOS, OstrinaVODCC, OstrinaVOSCC, VrstaStakla, PreporukaPomagala, Napomena, DatumIzdavanja, Pregledao) VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}')", Convert.ToInt32(cmbPacijent.SelectedValue), tbDijagnoza.Text, Convert.ToDouble(tbDsphDaljinaOD.Text), Convert.ToDouble(tbDsphDaljinaOS.Text), Convert.ToDouble(tbDsphBlizinaOD.Text), Convert.ToDouble(tbDsphBlizinaOS.Text), Convert.ToDouble(tbDcylDaljinaOD.Text), Convert.ToDouble(tbDcylDaljinaOS.Text), Convert.ToDouble(tbDcylBlizinaOD.Text), Convert.ToDouble(tbDcylBlizinaOS.Text), Convert.ToDouble(tbOsDaljinaOD.Text), Convert.ToDouble(tbOsDaljinaOS.Text), Convert.ToDouble(tbOsBlizinaOD.Text), Convert.ToDouble(tbOsBlizinaOS.Text), Convert.ToDouble(tbDeltaDaljinaOD.Text), Convert.ToDouble(tbDeltaDaljinaOS.Text), Convert.ToDouble(tbDeltaBlizinaOD.Text), Convert.ToDouble(tbDeltaBlizinaOS.Text), Convert.ToDouble(tbPDDaljinaOD.Text), Convert.ToDouble(tbPDDaljinaOS.Text), Convert.ToDouble(tbPDBlizinaOD.Text), Convert.ToDouble(tbPDBlizinaOS.Text), vodDouble, vosDouble, tbVrstaStakla.Text, tbPreporuka.Text, rtbNapomena.Text, dtpDatumIzdavanja.Text, tbPregledao.Text);
                }
                cmd2.CommandText = String.Format("INSERT INTO Dioptrija(SifraPacijenta, Dijagnoza, DsphDaljinaOD, DsphDaljinaOS, DsphBlizinaOD, DsphBlizinaOS, DcylDaljinaOD, DcylDaljinaOS, DcylBlizinaOD, DcylBlizinaOS, OsDaljinaOD, OsDaljinaOS, OsBlizinaOD, OsBlizinaOS, DeltaDaljinaOD, DeltaDaljinaOS, DeltaBlizinaOD, DeltaBlizinaOS, PDDaljinaOD, PDDaljinaOS, PDBlizinaOD, PDBlizinaOS, OstrinaVODCC, OstrinaVOSCC, VrstaStakla, PreporukaPomagala, Napomena, DatumIzdavanja, Pregledao) VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}')", pacijentSifra, tbDijagnoza.Text, Convert.ToDouble(tbDsphDaljinaOD.Text), Convert.ToDouble(tbDsphDaljinaOS.Text), Convert.ToDouble(tbDsphBlizinaOD.Text), Convert.ToDouble(tbDsphBlizinaOS.Text), Convert.ToDouble(tbDcylDaljinaOD.Text), Convert.ToDouble(tbDcylDaljinaOS.Text), Convert.ToDouble(tbDcylBlizinaOD.Text), Convert.ToDouble(tbDcylBlizinaOS.Text), Convert.ToDouble(tbOsDaljinaOD.Text), Convert.ToDouble(tbOsDaljinaOS.Text), Convert.ToDouble(tbOsBlizinaOD.Text), Convert.ToDouble(tbOsBlizinaOS.Text), Convert.ToDouble(tbDeltaDaljinaOD.Text), Convert.ToDouble(tbDeltaDaljinaOS.Text), Convert.ToDouble(tbDeltaBlizinaOD.Text), Convert.ToDouble(tbDeltaBlizinaOS.Text), Convert.ToDouble(tbPDDaljinaOD.Text), Convert.ToDouble(tbPDDaljinaOS.Text), Convert.ToDouble(tbPDBlizinaOD.Text), Convert.ToDouble(tbPDBlizinaOS.Text), vod, vos, tbVrstaStakla.Text, tbPreporuka.Text, rtbNapomena.Text, dtpDatumIzdavanja.Text, tbPregledao.Text);
            }
            cmd2.ExecuteNonQuery();
            conn.Close();
        }

        //function that returns max width of combobox item and resizes the dropdown
        int DropDownWidth(ComboBox myCombo)
        {
            int maxWidth = 0;
            int temp = 0;
            Label label1 = new Label();

            foreach (var obj in myCombo.Items)
            {
                label1.Text = obj.ToString();
                temp = label1.PreferredWidth;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            label1.Dispose();
            return maxWidth;
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (rbPacijent.Checked)
            {
                if ( String.IsNullOrEmpty(tbAdresa.Text) || String.IsNullOrEmpty(tbIme.Text) || String.IsNullOrEmpty(tbPregledao.Text) || String.IsNullOrEmpty(tbPrezime.Text) || String.IsNullOrEmpty(tbTelefon.Text))
                {
                    MessageBox.Show("Proverite da li ste uneli sve podatke!)", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                OleDbConnection conn = new OleDbConnection(connString);
                OleDbCommand cmd = new OleDbCommand();
                
                try
                {

                    conn.Open();

                    
                    cmd.Connection = conn;
                    cmd.CommandText = String.Format("INSERT INTO Pacijenti(Ime, Prezime, DatumRodjenja, Adresa, Telefon) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", tbIme.Text, tbPrezime.Text, dtpDatum.Text, tbAdresa.Text, tbTelefon.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    readMax();
                    pacijentSifra = maxValue;

                    insertD();

                    ds = new DataSet();
                    ds.Clear();

                    MessageBox.Show("Pacijent uspešno dodat!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                }
                catch
                {
                    MessageBox.Show("Proverite da li ste uneli sve podatke kako treba.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (rbDioptrija.Checked)
            {
                if ( String.IsNullOrEmpty(tbPregledao.Text))
                {
                    MessageBox.Show("Proverite da li ste uneli sve podatke!)", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    insertD();
                    MessageBox.Show("Nova dioptrija uspešno uneta za pacijenta " + ">>" + cmbPacijent.Text + "<<", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                }
                catch
                {
                    MessageBox.Show("Proverite da li ste uneli sve podatke kako treba.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        public void resetTable()
        {
            vod = 0;
            vod01 = false;
            lblVOD01.Image = null;
            vod02 = false;
            lblVOD02.Image = null;
            vod03 = false;
            lblVOD03.Image = null;
            vod04 = false;
            lblVOD04.Image = null;
            vod05 = false;
            lblVOD05.Image = null;
            vod06 = false;
            lblVOD06.Image = null;
            vod07 = false;
            lblVOD07.Image = null;
            vod08 = false;
            lblVOD08.Image = null;
            vod09 = false;
            lblVOD09.Image = null;
            vod10 = false;
            lblVOD10.Image = null;
        }

        private void resetTableRow2()
        {
            vos = 0;
            vos01 = false;
            lblVOS01.Image = null;
            vos02 = false;
            lblVOS02.Image = null;
            vos03 = false;
            lblVOS03.Image = null;
            vos04 = false;
            lblVOS04.Image = null;
            vos05 = false;
            lblVOS05.Image = null;
            vos06 = false;
            lblVOS06.Image = null;
            vos07 = false;
            lblVOS07.Image = null;
            vos08 = false;
            lblVOS08.Image = null;
            vos09 = false;
            lblVOS09.Image = null;
            vos10 = false;
            lblVOS10.Image = null;
        }

        double vod = 0;
        double vos = 0;
        //Kolona VOD CC
        bool vod01 = false;
        bool vod02 = false;
        bool vod03 = false;
        bool vod04 = false;
        bool vod05 = false;
        bool vod06 = false;
        bool vod07 = false;
        bool vod08 = false;
        bool vod09 = false;
        bool vod10 = false;
        //Kolona VOS CC
        bool vos01 = false;
        bool vos02 = false;
        bool vos03 = false;
        bool vos04 = false;
        bool vos05 = false;
        bool vos06 = false;
        bool vos07 = false;
        bool vos08 = false;
        bool vos09 = false;
        bool vos10 = false;

        private void lblVOD01_Click(object sender, EventArgs e)
        {
            if (vod02 || vod03 || vod04 || vod05 || vod06 || vod07 || vod08 || vod09 || vod10)
            {
                resetTable();
            }
            lblVOD01.Image = Properties.Resources.circleBlue;
            vod01 = true;
            vod = 0.1;
        }

        private void lblVOD02_Click(object sender, EventArgs e)
        {
            if (vod01 || vod03 || vod04 || vod05 || vod06 || vod07 || vod08 || vod09 || vod10)
            {
                resetTable();
            }
            lblVOD02.Image = Properties.Resources.circleBlue;
            vod02 = true;
            vod = 0.2;
        }

        private void lblVOD03_Click(object sender, EventArgs e)
        {
            if (vod01 || vod02 || vod04 || vod05 || vod06 || vod07 || vod08 || vod09 || vod10)
            {
                resetTable();
            }
            lblVOD03.Image = Properties.Resources.circleBlue;
            vod03 = true;
            vod = 0.3;
        }

        private void lblVOD04_Click(object sender, EventArgs e)
        {
            if (vod01 || vod02 || vod03 || vod05 || vod06 || vod07 || vod08 || vod09 || vod10)
            {
                resetTable();
            }
            lblVOD04.Image = Properties.Resources.circleBlue;
            vod04 = true;
            vod = 0.4;
        }

        private void lblVOD05_Click(object sender, EventArgs e)
        {
            if (vod01 || vod02 || vod03 || vod04 || vod06 || vod07 || vod08 || vod09 || vod10)
            {
                resetTable();
            }
            lblVOD05.Image = Properties.Resources.circleBlue;
            vod05 = true;
            vod = 0.5;
        }

        private void lblVOD06_Click(object sender, EventArgs e)
        {
            if (vod01 || vod02 || vod03 || vod04 || vod05 || vod07 || vod08 || vod09 || vod10)
            {
                resetTable();
            }
            lblVOD06.Image = Properties.Resources.circleBlue;
            vod06 = true;
            vod = 0.6;
        }

        private void lblVOD07_Click(object sender, EventArgs e)
        {
            if (vod01 || vod02 || vod03 || vod04 || vod05 || vod06 || vod08 || vod09 || vod10)
            {
                resetTable();
            }
            lblVOD07.Image = Properties.Resources.circleBlue;
            vod07 = true;
            vod = 0.7;
        }

        private void lblVOD08_Click(object sender, EventArgs e)
        {
            if (vod01 || vod02 || vod03 || vod04 || vod05 || vod06 || vod07 || vod09 || vod10)
            {
                resetTable();
            }
            lblVOD08.Image = Properties.Resources.circleBlue;
            vod08 = true;
            vod = 0.8;
        }

        private void lblVOD09_Click(object sender, EventArgs e)
        {
            if (vod01 || vod02 || vod03 || vod04 || vod05 || vod06 || vod07 || vod08 || vod10)
            {
                resetTable();
            }
            lblVOD09.Image = Properties.Resources.circleBlue;
            vod09 = true;
            vod = 0.9;
        }

        private void lblVOD10_Click(object sender, EventArgs e)
        {
            if (vod01 || vod02 || vod03 || vod04 || vod05 || vod06 || vod07 || vod08 || vod09)
            {
                resetTable();
            }
            lblVOD10.Image = Properties.Resources.circleBlue;
            vod10 = true;
            vod = 1.0;
        }

        private void lblVOS01_Click(object sender, EventArgs e)
        {
            if (vos02 || vos03 || vos04 || vos05 || vos06 || vos07 || vos08 || vos09 || vos10)
            {
                resetTableRow2();
            }
            lblVOS01.Image = Properties.Resources.circleBlue;
            vos01 = true;
            vos = 0.1;
        }

        private void lblVOS02_Click(object sender, EventArgs e)
        {
            if (vos01 || vos03 || vos04 || vos05 || vos06 || vos07 || vos08 || vos09 || vos10)
            {
                resetTableRow2();
            }
            lblVOS02.Image = Properties.Resources.circleBlue;
            vos02 = true;
            vos = 0.2;
        }

        private void lblVOS03_Click(object sender, EventArgs e)
        {
            if (vos01 || vos02 || vos04 || vos05 || vos06 || vos07 || vos08 || vos09 || vos10)
            {
                resetTableRow2();
            }
            lblVOS03.Image = Properties.Resources.circleBlue;
            vos03 = true;
            vos = 0.3;
        }

        private void lblVOS04_Click(object sender, EventArgs e)
        {
            if (vos01 || vos02 || vos03 || vos05 || vos06 || vos07 || vos08 || vos09 || vos10)
            {
                resetTableRow2();
            }
            lblVOS04.Image = Properties.Resources.circleBlue;
            vos04 = true;
            vos = 0.4;
        }

        private void lblVOS05_Click(object sender, EventArgs e)
        {
            if (vos01 || vos02 || vos03 || vos04 || vos06 || vos07 || vos08 || vos09 || vos10)
            {
                resetTableRow2();
            }
            lblVOS05.Image = Properties.Resources.circleBlue;
            vos05 = true;
            vos = 0.5;
        }

        private void lblVOS06_Click(object sender, EventArgs e)
        {
            if (vos01 || vos02 || vos03 || vos04 || vos05 || vos07 || vos08 || vos09 || vos10)
            {
                resetTableRow2();
            }
            lblVOS06.Image = Properties.Resources.circleBlue;
            vos06 = true;
            vos = 0.6;
        }

        private void lblVOS07_Click(object sender, EventArgs e)
        {
            if (vos01 || vos02 || vos03 || vos04 || vos05 || vos06 || vos08 || vos09 || vos10)
            {
                resetTableRow2();
            }
            lblVOS07.Image = Properties.Resources.circleBlue;
            vos07 = true;
            vos = 0.7;
        }

        private void lblVOS08_Click(object sender, EventArgs e)
        {
            if (vos01 || vos02 || vos03 || vos04 || vos05 || vos06 || vos07 || vos09 || vos10)
            {
                resetTableRow2();
            }
            lblVOS08.Image = Properties.Resources.circleBlue;
            vos08 = true;
            vos = 0.8;
        }

        private void lblVOS09_Click(object sender, EventArgs e)
        {
            if (vos01 || vos02 || vos03 || vos04 || vos05 || vos06 || vos07 || vos08 || vos10)
            {
                resetTableRow2();
            }
            lblVOS09.Image = Properties.Resources.circleBlue;
            vos09 = true;
            vos = 0.9;
        }

        private void lblVOS10_Click(object sender, EventArgs e)
        {
            if (vos01 || vos02 || vos03 || vos04 || vos05 || vos06 || vos07 || vos08 || vos09)
            {
                resetTableRow2();
            }
            lblVOS10.Image = Properties.Resources.circleBlue;
            vos10 = true;
            vos = 1.0;
        }

        private void tbPretragaPacijenata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int index = cmbPacijent.FindString(tbPretragaPacijenata.Text);
                cmbPacijent.SelectedIndex = index;
            }
        }
    }
}
