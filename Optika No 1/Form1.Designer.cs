namespace Optika_No_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbOsnovniPodaci = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridPacijenti = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPacijenti = new System.Windows.Forms.TabPage();
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbPretragaBroj = new System.Windows.Forms.TextBox();
            this.rbBrojTelefona = new System.Windows.Forms.RadioButton();
            this.tbPretragaAdresa = new System.Windows.Forms.TextBox();
            this.rbAdresa = new System.Windows.Forms.RadioButton();
            this.rbImePrezime = new System.Windows.Forms.RadioButton();
            this.tbPretragaImePrezime = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.tabDioptrije = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteDioptrija = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnSaveDioptrija = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridDioptrija = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btNav_First = new System.Windows.Forms.Button();
            this.btnNavRight = new System.Windows.Forms.Button();
            this.btNav_Last = new System.Windows.Forms.Button();
            this.btnNavLeft = new System.Windows.Forms.Button();
            this.gbOsnovniPodaci.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacijenti)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPacijenti.SuspendLayout();
            this.gbPretraga.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabDioptrije.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDioptrija)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOsnovniPodaci
            // 
            this.gbOsnovniPodaci.Controls.Add(this.btnAdd);
            this.gbOsnovniPodaci.Controls.Add(this.btnRefresh);
            this.gbOsnovniPodaci.Controls.Add(this.btnDelete);
            this.gbOsnovniPodaci.Controls.Add(this.btnSave);
            this.gbOsnovniPodaci.Controls.Add(this.dtpDatum);
            this.gbOsnovniPodaci.Controls.Add(this.tbTelefon);
            this.gbOsnovniPodaci.Controls.Add(this.tbAdresa);
            this.gbOsnovniPodaci.Controls.Add(this.tbPrezime);
            this.gbOsnovniPodaci.Controls.Add(this.tbIme);
            this.gbOsnovniPodaci.Controls.Add(this.label5);
            this.gbOsnovniPodaci.Controls.Add(this.label4);
            this.gbOsnovniPodaci.Controls.Add(this.label3);
            this.gbOsnovniPodaci.Controls.Add(this.label2);
            this.gbOsnovniPodaci.Controls.Add(this.label1);
            this.gbOsnovniPodaci.Location = new System.Drawing.Point(7, 7);
            this.gbOsnovniPodaci.Margin = new System.Windows.Forms.Padding(4);
            this.gbOsnovniPodaci.Name = "gbOsnovniPodaci";
            this.gbOsnovniPodaci.Padding = new System.Windows.Forms.Padding(4);
            this.gbOsnovniPodaci.Size = new System.Drawing.Size(484, 256);
            this.gbOsnovniPodaci.TabIndex = 1;
            this.gbOsnovniPodaci.TabStop = false;
            this.gbOsnovniPodaci.Text = "Osnovni podaci o pacijentu";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Optika_No_1.Properties.Resources.edit_add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(422, 42);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Optika_No_1.Properties.Resources.gtk_refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(422, 129);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(52, 32);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnRefresh.MouseHover += new System.EventHandler(this.btnRefresh_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Optika_No_1.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Location = new System.Drawing.Point(422, 176);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 32);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Optika_No_1.Properties.Resources.save1;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(422, 85);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 32);
            this.btnSave.TabIndex = 4;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(205, 129);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(208, 26);
            this.dtpDatum.TabIndex = 9;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(205, 220);
            this.tbTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(208, 26);
            this.tbTelefon.TabIndex = 8;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(205, 179);
            this.tbAdresa.Margin = new System.Windows.Forms.Padding(4);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(208, 26);
            this.tbAdresa.TabIndex = 7;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(205, 88);
            this.tbPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(208, 26);
            this.tbPrezime.TabIndex = 6;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(205, 45);
            this.tbIme.Margin = new System.Windows.Forms.Padding(4);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(208, 26);
            this.tbIme.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum rođenja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridPacijenti);
            this.groupBox1.Location = new System.Drawing.Point(18, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 207);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pacijenti";
            // 
            // gridPacijenti
            // 
            this.gridPacijenti.AllowUserToAddRows = false;
            this.gridPacijenti.AllowUserToDeleteRows = false;
            this.gridPacijenti.AllowUserToResizeRows = false;
            this.gridPacijenti.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacijenti.GridColor = System.Drawing.Color.White;
            this.gridPacijenti.Location = new System.Drawing.Point(6, 28);
            this.gridPacijenti.MultiSelect = false;
            this.gridPacijenti.Name = "gridPacijenti";
            this.gridPacijenti.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridPacijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPacijenti.Size = new System.Drawing.Size(935, 173);
            this.gridPacijenti.TabIndex = 3;
            this.gridPacijenti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPacijenti_CellClick);
            this.gridPacijenti.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPacijenti_CellValueChanged);
            this.gridPacijenti.SelectionChanged += new System.EventHandler(this.gridPacijenti_SelectionChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPacijenti);
            this.tabControl1.Controls.Add(this.tabDioptrije);
            this.tabControl1.Location = new System.Drawing.Point(24, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(941, 304);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPacijenti
            // 
            this.tabPacijenti.Controls.Add(this.gbPretraga);
            this.tabPacijenti.Controls.Add(this.gbOsnovniPodaci);
            this.tabPacijenti.Location = new System.Drawing.Point(4, 29);
            this.tabPacijenti.Name = "tabPacijenti";
            this.tabPacijenti.Padding = new System.Windows.Forms.Padding(3);
            this.tabPacijenti.Size = new System.Drawing.Size(933, 271);
            this.tabPacijenti.TabIndex = 0;
            this.tabPacijenti.Text = "Pacijent";
            this.tabPacijenti.UseVisualStyleBackColor = true;
            // 
            // gbPretraga
            // 
            this.gbPretraga.Controls.Add(this.btnOcisti);
            this.gbPretraga.Controls.Add(this.groupBox4);
            this.gbPretraga.Controls.Add(this.btnPretraga);
            this.gbPretraga.Location = new System.Drawing.Point(532, 7);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(395, 257);
            this.gbPretraga.TabIndex = 15;
            this.gbPretraga.TabStop = false;
            this.gbPretraga.Text = "Pretraga";
            // 
            // btnOcisti
            // 
            this.btnOcisti.BackColor = System.Drawing.SystemColors.Control;
            this.btnOcisti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOcisti.Image = global::Optika_No_1.Properties.Resources.Eraser;
            this.btnOcisti.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOcisti.Location = new System.Drawing.Point(145, 219);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(81, 32);
            this.btnOcisti.TabIndex = 19;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOcisti.UseVisualStyleBackColor = false;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbPretragaBroj);
            this.groupBox4.Controls.Add(this.rbBrojTelefona);
            this.groupBox4.Controls.Add(this.tbPretragaAdresa);
            this.groupBox4.Controls.Add(this.rbAdresa);
            this.groupBox4.Controls.Add(this.rbImePrezime);
            this.groupBox4.Controls.Add(this.tbPretragaImePrezime);
            this.groupBox4.Location = new System.Drawing.Point(22, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(357, 146);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // tbPretragaBroj
            // 
            this.tbPretragaBroj.Location = new System.Drawing.Point(135, 101);
            this.tbPretragaBroj.Margin = new System.Windows.Forms.Padding(4);
            this.tbPretragaBroj.Name = "tbPretragaBroj";
            this.tbPretragaBroj.Size = new System.Drawing.Size(208, 26);
            this.tbPretragaBroj.TabIndex = 18;
            // 
            // rbBrojTelefona
            // 
            this.rbBrojTelefona.AutoSize = true;
            this.rbBrojTelefona.Location = new System.Drawing.Point(6, 102);
            this.rbBrojTelefona.Name = "rbBrojTelefona";
            this.rbBrojTelefona.Size = new System.Drawing.Size(117, 24);
            this.rbBrojTelefona.TabIndex = 17;
            this.rbBrojTelefona.TabStop = true;
            this.rbBrojTelefona.Text = "Broj telefona";
            this.rbBrojTelefona.UseVisualStyleBackColor = true;
            this.rbBrojTelefona.CheckedChanged += new System.EventHandler(this.rbBrojTelefona_CheckedChanged);
            // 
            // tbPretragaAdresa
            // 
            this.tbPretragaAdresa.Location = new System.Drawing.Point(135, 64);
            this.tbPretragaAdresa.Margin = new System.Windows.Forms.Padding(4);
            this.tbPretragaAdresa.Name = "tbPretragaAdresa";
            this.tbPretragaAdresa.Size = new System.Drawing.Size(208, 26);
            this.tbPretragaAdresa.TabIndex = 16;
            // 
            // rbAdresa
            // 
            this.rbAdresa.AutoSize = true;
            this.rbAdresa.Location = new System.Drawing.Point(6, 65);
            this.rbAdresa.Name = "rbAdresa";
            this.rbAdresa.Size = new System.Drawing.Size(78, 24);
            this.rbAdresa.TabIndex = 1;
            this.rbAdresa.TabStop = true;
            this.rbAdresa.Text = "Adresa";
            this.rbAdresa.UseVisualStyleBackColor = true;
            this.rbAdresa.CheckedChanged += new System.EventHandler(this.rbAdresa_CheckedChanged);
            // 
            // rbImePrezime
            // 
            this.rbImePrezime.AutoSize = true;
            this.rbImePrezime.Location = new System.Drawing.Point(6, 28);
            this.rbImePrezime.Name = "rbImePrezime";
            this.rbImePrezime.Size = new System.Drawing.Size(121, 24);
            this.rbImePrezime.TabIndex = 0;
            this.rbImePrezime.TabStop = true;
            this.rbImePrezime.Text = "Ime i prezime";
            this.rbImePrezime.UseVisualStyleBackColor = true;
            this.rbImePrezime.CheckedChanged += new System.EventHandler(this.rbImePrezime_CheckedChanged);
            // 
            // tbPretragaImePrezime
            // 
            this.tbPretragaImePrezime.Location = new System.Drawing.Point(135, 27);
            this.tbPretragaImePrezime.Margin = new System.Windows.Forms.Padding(4);
            this.tbPretragaImePrezime.Name = "tbPretragaImePrezime";
            this.tbPretragaImePrezime.Size = new System.Drawing.Size(208, 26);
            this.tbPretragaImePrezime.TabIndex = 15;
            // 
            // btnPretraga
            // 
            this.btnPretraga.BackColor = System.Drawing.SystemColors.Control;
            this.btnPretraga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPretraga.Image = global::Optika_No_1.Properties.Resources.xmag;
            this.btnPretraga.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPretraga.Location = new System.Drawing.Point(22, 219);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(100, 32);
            this.btnPretraga.TabIndex = 17;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPretraga.UseVisualStyleBackColor = false;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // tabDioptrije
            // 
            this.tabDioptrije.Controls.Add(this.groupBox5);
            this.tabDioptrije.Controls.Add(this.groupBox3);
            this.tabDioptrije.Location = new System.Drawing.Point(4, 29);
            this.tabDioptrije.Name = "tabDioptrije";
            this.tabDioptrije.Size = new System.Drawing.Size(933, 271);
            this.tabDioptrije.TabIndex = 1;
            this.tabDioptrije.Text = "Dioptrija";
            this.tabDioptrije.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.btnDeleteDioptrija);
            this.groupBox5.Controls.Add(this.btnAdd2);
            this.groupBox5.Controls.Add(this.btnSaveDioptrija);
            this.groupBox5.Location = new System.Drawing.Point(348, 203);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(242, 60);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Optika_No_1.Properties.Resources.latest;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(183, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 32);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // btnDeleteDioptrija
            // 
            this.btnDeleteDioptrija.BackgroundImage = global::Optika_No_1.Properties.Resources.delete;
            this.btnDeleteDioptrija.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteDioptrija.Location = new System.Drawing.Point(124, 21);
            this.btnDeleteDioptrija.Name = "btnDeleteDioptrija";
            this.btnDeleteDioptrija.Size = new System.Drawing.Size(52, 32);
            this.btnDeleteDioptrija.TabIndex = 14;
            this.btnDeleteDioptrija.UseVisualStyleBackColor = true;
            this.btnDeleteDioptrija.Click += new System.EventHandler(this.btnDeleteDioptrija_Click);
            this.btnDeleteDioptrija.MouseLeave += new System.EventHandler(this.btnDeleteDioptrija_MouseLeave);
            this.btnDeleteDioptrija.MouseHover += new System.EventHandler(this.btnDeleteDioptrija_MouseHover);
            // 
            // btnAdd2
            // 
            this.btnAdd2.BackgroundImage = global::Optika_No_1.Properties.Resources.edit_add;
            this.btnAdd2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd2.Location = new System.Drawing.Point(7, 21);
            this.btnAdd2.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(52, 32);
            this.btnAdd2.TabIndex = 15;
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            this.btnAdd2.MouseLeave += new System.EventHandler(this.btnAdd2_MouseLeave);
            this.btnAdd2.MouseHover += new System.EventHandler(this.btnAdd2_MouseHover);
            // 
            // btnSaveDioptrija
            // 
            this.btnSaveDioptrija.BackgroundImage = global::Optika_No_1.Properties.Resources.save1;
            this.btnSaveDioptrija.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveDioptrija.Location = new System.Drawing.Point(66, 21);
            this.btnSaveDioptrija.Name = "btnSaveDioptrija";
            this.btnSaveDioptrija.Size = new System.Drawing.Size(52, 32);
            this.btnSaveDioptrija.TabIndex = 5;
            this.btnSaveDioptrija.UseVisualStyleBackColor = true;
            this.btnSaveDioptrija.Click += new System.EventHandler(this.btnSaveDioptrija_Click);
            this.btnSaveDioptrija.MouseLeave += new System.EventHandler(this.btnSaveDioptrija_MouseLeave);
            this.btnSaveDioptrija.MouseHover += new System.EventHandler(this.btnSaveDioptrija_MouseHover);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridDioptrija);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(927, 194);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dioptrija";
            // 
            // gridDioptrija
            // 
            this.gridDioptrija.AllowUserToAddRows = false;
            this.gridDioptrija.AllowUserToDeleteRows = false;
            this.gridDioptrija.AllowUserToResizeRows = false;
            this.gridDioptrija.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridDioptrija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDioptrija.Location = new System.Drawing.Point(6, 28);
            this.gridDioptrija.MultiSelect = false;
            this.gridDioptrija.Name = "gridDioptrija";
            this.gridDioptrija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDioptrija.Size = new System.Drawing.Size(915, 160);
            this.gridDioptrija.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btNav_First);
            this.groupBox2.Controls.Add(this.btnNavRight);
            this.groupBox2.Controls.Add(this.btNav_Last);
            this.groupBox2.Controls.Add(this.btnNavLeft);
            this.groupBox2.Location = new System.Drawing.Point(380, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 60);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // btNav_First
            // 
            this.btNav_First.BackColor = System.Drawing.SystemColors.Control;
            this.btNav_First.BackgroundImage = global::Optika_No_1.Properties.Resources.toFirst;
            this.btNav_First.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btNav_First.Location = new System.Drawing.Point(10, 20);
            this.btNav_First.Name = "btNav_First";
            this.btNav_First.Size = new System.Drawing.Size(64, 32);
            this.btNav_First.TabIndex = 12;
            this.btNav_First.UseVisualStyleBackColor = false;
            this.btNav_First.Click += new System.EventHandler(this.btNav_First_Click);
            // 
            // btnNavRight
            // 
            this.btnNavRight.BackgroundImage = global::Optika_No_1.Properties.Resources.nav_right;
            this.btnNavRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNavRight.Location = new System.Drawing.Point(118, 20);
            this.btnNavRight.Name = "btnNavRight";
            this.btnNavRight.Size = new System.Drawing.Size(32, 32);
            this.btnNavRight.TabIndex = 10;
            this.btnNavRight.UseVisualStyleBackColor = true;
            this.btnNavRight.Click += new System.EventHandler(this.btnNavRight_Click);
            // 
            // btNav_Last
            // 
            this.btNav_Last.BackColor = System.Drawing.SystemColors.Control;
            this.btNav_Last.BackgroundImage = global::Optika_No_1.Properties.Resources.toLast;
            this.btNav_Last.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btNav_Last.Location = new System.Drawing.Point(156, 20);
            this.btNav_Last.Name = "btNav_Last";
            this.btNav_Last.Size = new System.Drawing.Size(64, 32);
            this.btNav_Last.TabIndex = 11;
            this.btNav_Last.UseVisualStyleBackColor = false;
            this.btNav_Last.Click += new System.EventHandler(this.btNav_Last_Click);
            // 
            // btnNavLeft
            // 
            this.btnNavLeft.BackgroundImage = global::Optika_No_1.Properties.Resources.nav_left;
            this.btnNavLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNavLeft.Location = new System.Drawing.Point(80, 20);
            this.btnNavLeft.Name = "btnNavLeft";
            this.btnNavLeft.Size = new System.Drawing.Size(32, 32);
            this.btnNavLeft.TabIndex = 2;
            this.btnNavLeft.UseVisualStyleBackColor = true;
            this.btnNavLeft.Click += new System.EventHandler(this.btnNavLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 599);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optika Vanja";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOsnovniPodaci.ResumeLayout(false);
            this.gbOsnovniPodaci.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPacijenti)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPacijenti.ResumeLayout(false);
            this.gbPretraga.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabDioptrije.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDioptrija)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbOsnovniPodaci;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNavLeft;
        private System.Windows.Forms.Button btnNavRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btNav_Last;
        private System.Windows.Forms.Button btNav_First;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPacijenti;
        private System.Windows.Forms.TabPage tabDioptrije;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridDioptrija;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbPretraga;
        private System.Windows.Forms.TextBox tbPretragaImePrezime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbAdresa;
        private System.Windows.Forms.RadioButton rbImePrezime;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.TextBox tbPretragaBroj;
        private System.Windows.Forms.RadioButton rbBrojTelefona;
        private System.Windows.Forms.TextBox tbPretragaAdresa;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Button btnSaveDioptrija;
        private System.Windows.Forms.Button btnDeleteDioptrija;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView gridPacijenti;

    }
}

