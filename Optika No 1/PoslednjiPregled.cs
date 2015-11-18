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
using System.Drawing.Printing;

namespace Optika_No_1
{
    public partial class PoslednjiPregled : Form
    {
        public PoslednjiPregled()
        {
            InitializeComponent();

            OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();
            builder.Add("Provider", Properties.Settings.Default.provider);
            builder.Add("Data Source", Properties.Settings.Default.path);
            connString = builder.ConnectionString;

            panelTabela1.Left = (this.ClientSize.Width - panelTabela1.Width) / 2;
            panelTabela2.Left = (this.ClientSize.Width - panelTabela2.Width) / 2;

            lblText.Text = "Kralja Petra I br. 36 \nKragujevac, Srbija \ntel./. :+381 34 344-832\nfax./.:+381 34 301-909 \ne-mail: optikavanja@hotmail.com";

            //ucitavanje poslednjeg pacijenta
            try
            {
                double vod = 0;
                double vos = 0;
                int arg = Form1.maxValue;
                string query = String.Format("SELECT Dijagnoza, DsphDaljinaOD, DsphDaljinaOS, DsphBlizinaOD, DsphBlizinaOS, DcylDaljinaOD, DcylDaljinaOS, DcylBlizinaOD, DcylBlizinaOS, OsDaljinaOD, OsDaljinaOS, OsBlizinaOD, OsBlizinaOS, DeltaDaljinaOD, DeltaDaljinaOS, DeltaBlizinaOD, DeltaBlizinaOS, PDDaljinaOD, PDDaljinaOS, PDBlizinaOD, PDBlizinaOS, OstrinaVODCC, OstrinaVOSCC, VrstaStakla, PreporukaPomagala, Napomena, DatumIzdavanja, Pregledao FROM Dioptrija WHERE SifraPregleda = {0}", arg);
                OleDbConnection conn = new OleDbConnection(connString);
                OleDbCommand cmd = new OleDbCommand(query, conn);

                OleDbDataReader reader;

                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tbDijagnoza.Text = reader.GetString(0);
                    tbDaljinaDsphOD.Text = reader.GetDouble(1).ToString();
                    tbDaljinaDsphOS.Text = reader.GetDouble(2).ToString();
                    tbBlizinaDsphOD.Text = reader.GetDouble(3).ToString();
                    tbBlizinaDsphOS.Text = reader.GetDouble(4).ToString();
                    tbDaljinaDcylOD.Text = reader.GetDouble(5).ToString();
                    tbDaljinaDcylOS.Text = reader.GetDouble(6).ToString();
                    tbBlizinaDcylOD.Text = reader.GetDouble(7).ToString();
                    tbBlizinaDcylOS.Text = reader.GetDouble(8).ToString();
                    tbDaljinaOsOD.Text = reader.GetDouble(9).ToString();
                    tbDaljinaOsOS.Text = reader.GetDouble(10).ToString();
                    tbBlizinaOsOD.Text = reader.GetDouble(11).ToString();
                    tbBlizinaOsOS.Text = reader.GetDouble(12).ToString();
                    tbDaljinaDeltaOD.Text = reader.GetDouble(13).ToString();
                    tbDaljinaDeltaOS.Text = reader.GetDouble(14).ToString();
                    tbBlizinaDeltaOD.Text = reader.GetDouble(15).ToString();
                    tbBlizinaDeltaOS.Text = reader.GetDouble(16).ToString();
                    tbDaljinaPDOD.Text = reader.GetDouble(17).ToString();
                    tbDaljinaPDOS.Text = reader.GetDouble(18).ToString();
                    tbBlizinaPDOD.Text = reader.GetDouble(19).ToString();
                    tbBlizinaPDOS.Text = reader.GetDouble(20).ToString();
                    vod = reader.GetDouble(21);
                    vos = reader.GetDouble(22);

                    //checking vod
                    if (vod == 0.1)
                        lblVOD01.Image = Properties.Resources.circleBlue;
                    else if (vod == 0.2)
                        lblVOD02.Image = Properties.Resources.circleBlue;
                    else if (vod == 0.3)
                        lblVOD03.Image = Properties.Resources.circleBlue;
                    else if (vod == 0.4)
                        lblVOD04.Image = Properties.Resources.circleBlue;
                    else if (vod == 0.5)
                        lblVOD05.Image = Properties.Resources.circleBlue;
                    else if (vod == 0.6)
                        lblVOD06.Image = Properties.Resources.circleBlue;
                    else if (vod == 0.7)
                        lblVOD07.Image = Properties.Resources.circleBlue;
                    else if (vod == 0.8)
                        lblVOD08.Image = Properties.Resources.circleBlue;
                    else if (vod == 0.9)
                        lblVOD09.Image = Properties.Resources.circleBlue;
                    else if (vod == 1)
                        lblVOD10.Image = Properties.Resources.circleBlue;
                    //checking vos
                    if (vos == 0.1)
                        lblVOS01.Image = Properties.Resources.circleBlue;
                    else if (vos == 0.2)
                        lblVOS02.Image = Properties.Resources.circleBlue;
                    else if (vos == 0.3)
                        lblVOS03.Image = Properties.Resources.circleBlue;
                    else if (vos == 0.4)
                        lblVOS04.Image = Properties.Resources.circleBlue;
                    else if (vos == 0.5)
                        lblVOS05.Image = Properties.Resources.circleBlue;
                    else if (vos == 0.6)
                        lblVOS06.Image = Properties.Resources.circleBlue;
                    else if (vos == 0.7)
                        lblVOS07.Image = Properties.Resources.circleBlue;
                    else if (vos == 0.8)
                        lblVOS08.Image = Properties.Resources.circleBlue;
                    else if (vos == 0.9)
                        lblVOS09.Image = Properties.Resources.circleBlue;
                    else if (vos == 1)
                        lblVOS10.Image = Properties.Resources.circleBlue;

                    tbVrstaStakla.Text = reader.GetString(23);
                    tbPreporuka.Text = reader.GetString(24);
                    rtbNapomena.Text = reader.GetString(25);
                    tbDatum.Text = reader.GetDateTime(26).ToShortDateString();
                    tbPregledao.Text = reader.GetString(27);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        string connString;

        private PrintDocument printDocument1 = new PrintDocument();


        private void printButton_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            CaptureScreen();
            printDocument1.Print();
            this.Hide();
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            btnNazad.Visible = false;
            printButton.Visible = false;
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(Object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
