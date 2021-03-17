namespace ProjektNr2_Kruhlov48720
{
    partial class dk_Form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dk__txt_RozmiarTabl = new System.Windows.Forms.TextBox();
            this.dk__txt_MinimalnaPróbaBadawcza = new System.Windows.Forms.TextBox();
            this.dk__txt_DolnaGranica = new System.Windows.Forms.TextBox();
            this.dk__txt_GórnaGranica = new System.Windows.Forms.TextBox();
            this.dk__btn_AkceptacjaDanych = new System.Windows.Forms.Button();
            this.dk__btn_WynikiTabelaryczne = new System.Windows.Forms.Button();
            this.dk__btn_WynikiWykres = new System.Windows.Forms.Button();
            this.dk__btn_Resetuj = new System.Windows.Forms.Button();
            this.dk__dgv_TabelaWyników = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dk_WybranyAlgorytm = new System.Windows.Forms.Label();
            this.dk_ButtonZmianaSortowania = new System.Windows.Forms.Button();
            this.dk_linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dk_linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.dk_Wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dk__label1 = new System.Windows.Forms.Label();
            this.dk__label2 = new System.Windows.Forms.Label();
            this.dk__label3 = new System.Windows.Forms.Label();
            this.dk__label4 = new System.Windows.Forms.Label();
            this.dk__label5 = new System.Windows.Forms.Label();
            this.dk__label6 = new System.Windows.Forms.Label();
            this.dk__label12 = new System.Windows.Forms.Label();
            this.dk__label8 = new System.Windows.Forms.Label();
            this.dk__label7 = new System.Windows.Forms.Label();
            this.dk_ZmianaStylu1 = new System.Windows.Forms.ComboBox();
            this.dk_ZmianaStylu3 = new System.Windows.Forms.ComboBox();
            this.dk_ZmianaStylu2 = new System.Windows.Forms.ComboBox();
            this.dk_ZmianaGrubosci1 = new System.Windows.Forms.TrackBar();
            this.dk_ZmianaGrubosci2 = new System.Windows.Forms.TrackBar();
            this.dk_ZmianaGrubosci3 = new System.Windows.Forms.TrackBar();
            this.dk_ZmianaKoloru1 = new System.Windows.Forms.Button();
            this.dk_ZmianaKoloru2 = new System.Windows.Forms.Button();
            this.dk_ZmianaKoloru3 = new System.Windows.Forms.Button();
            this.dk__colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dk__colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.dk__colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.dk__groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dk__dgv_TabelaWyników)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dk_Wykres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dk_ZmianaGrubosci1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dk_ZmianaGrubosci2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dk_ZmianaGrubosci3)).BeginInit();
            this.dk__groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dk__txt_RozmiarTabl
            // 
            this.dk__txt_RozmiarTabl.Location = new System.Drawing.Point(104, 110);
            this.dk__txt_RozmiarTabl.Margin = new System.Windows.Forms.Padding(4);
            this.dk__txt_RozmiarTabl.Name = "dk__txt_RozmiarTabl";
            this.dk__txt_RozmiarTabl.Size = new System.Drawing.Size(176, 22);
            this.dk__txt_RozmiarTabl.TabIndex = 0;
            this.dk__txt_RozmiarTabl.TextChanged += new System.EventHandler(this.dk__txt_RozmiarTabl_TextChanged);
            // 
            // dk__txt_MinimalnaPróbaBadawcza
            // 
            this.dk__txt_MinimalnaPróbaBadawcza.Location = new System.Drawing.Point(104, 38);
            this.dk__txt_MinimalnaPróbaBadawcza.Margin = new System.Windows.Forms.Padding(4);
            this.dk__txt_MinimalnaPróbaBadawcza.Name = "dk__txt_MinimalnaPróbaBadawcza";
            this.dk__txt_MinimalnaPróbaBadawcza.Size = new System.Drawing.Size(176, 22);
            this.dk__txt_MinimalnaPróbaBadawcza.TabIndex = 1;
            this.dk__txt_MinimalnaPróbaBadawcza.TextChanged += new System.EventHandler(this.dk__txt_MinimalnaPróbaBadawcza_TextChanged);
            // 
            // dk__txt_DolnaGranica
            // 
            this.dk__txt_DolnaGranica.Location = new System.Drawing.Point(104, 187);
            this.dk__txt_DolnaGranica.Margin = new System.Windows.Forms.Padding(4);
            this.dk__txt_DolnaGranica.Name = "dk__txt_DolnaGranica";
            this.dk__txt_DolnaGranica.Size = new System.Drawing.Size(176, 22);
            this.dk__txt_DolnaGranica.TabIndex = 2;
            this.dk__txt_DolnaGranica.TextChanged += new System.EventHandler(this.dk__txt_DolnaGranica_TextChanged);
            // 
            // dk__txt_GórnaGranica
            // 
            this.dk__txt_GórnaGranica.Location = new System.Drawing.Point(104, 263);
            this.dk__txt_GórnaGranica.Margin = new System.Windows.Forms.Padding(4);
            this.dk__txt_GórnaGranica.Name = "dk__txt_GórnaGranica";
            this.dk__txt_GórnaGranica.Size = new System.Drawing.Size(176, 22);
            this.dk__txt_GórnaGranica.TabIndex = 3;
            this.dk__txt_GórnaGranica.TextChanged += new System.EventHandler(this.dk__txt_GórnaGranica_TextChanged);
            // 
            // dk__btn_AkceptacjaDanych
            // 
            this.dk__btn_AkceptacjaDanych.BackColor = System.Drawing.Color.Gold;
            this.dk__btn_AkceptacjaDanych.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk__btn_AkceptacjaDanych.Location = new System.Drawing.Point(34, 317);
            this.dk__btn_AkceptacjaDanych.Margin = new System.Windows.Forms.Padding(4);
            this.dk__btn_AkceptacjaDanych.Name = "dk__btn_AkceptacjaDanych";
            this.dk__btn_AkceptacjaDanych.Size = new System.Drawing.Size(315, 63);
            this.dk__btn_AkceptacjaDanych.TabIndex = 5;
            this.dk__btn_AkceptacjaDanych.Text = "Akceptacja danych dla badania eksperymentalnego";
            this.dk__btn_AkceptacjaDanych.UseVisualStyleBackColor = false;
            this.dk__btn_AkceptacjaDanych.Click += new System.EventHandler(this.dk__btn_AkceptacjaDanych_Click);
            // 
            // dk__btn_WynikiTabelaryczne
            // 
            this.dk__btn_WynikiTabelaryczne.BackColor = System.Drawing.Color.Gold;
            this.dk__btn_WynikiTabelaryczne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk__btn_WynikiTabelaryczne.Location = new System.Drawing.Point(34, 631);
            this.dk__btn_WynikiTabelaryczne.Margin = new System.Windows.Forms.Padding(4);
            this.dk__btn_WynikiTabelaryczne.Name = "dk__btn_WynikiTabelaryczne";
            this.dk__btn_WynikiTabelaryczne.Size = new System.Drawing.Size(315, 61);
            this.dk__btn_WynikiTabelaryczne.TabIndex = 6;
            this.dk__btn_WynikiTabelaryczne.Text = "Tabelaryczna prezentacja złożoności";
            this.dk__btn_WynikiTabelaryczne.UseVisualStyleBackColor = false;
            this.dk__btn_WynikiTabelaryczne.Click += new System.EventHandler(this.dk__btn_WynikiTabelaryczne_Click);
            // 
            // dk__btn_WynikiWykres
            // 
            this.dk__btn_WynikiWykres.BackColor = System.Drawing.Color.Gold;
            this.dk__btn_WynikiWykres.Enabled = false;
            this.dk__btn_WynikiWykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk__btn_WynikiWykres.Location = new System.Drawing.Point(34, 700);
            this.dk__btn_WynikiWykres.Margin = new System.Windows.Forms.Padding(4);
            this.dk__btn_WynikiWykres.Name = "dk__btn_WynikiWykres";
            this.dk__btn_WynikiWykres.Size = new System.Drawing.Size(315, 61);
            this.dk__btn_WynikiWykres.TabIndex = 7;
            this.dk__btn_WynikiWykres.Text = "Graficzna prezentacja złożoności";
            this.dk__btn_WynikiWykres.UseVisualStyleBackColor = false;
            this.dk__btn_WynikiWykres.Click += new System.EventHandler(this.dk__btn_WynikiWykres_Click);
            // 
            // dk__btn_Resetuj
            // 
            this.dk__btn_Resetuj.BackColor = System.Drawing.Color.Gold;
            this.dk__btn_Resetuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk__btn_Resetuj.Location = new System.Drawing.Point(1232, 709);
            this.dk__btn_Resetuj.Margin = new System.Windows.Forms.Padding(4);
            this.dk__btn_Resetuj.Name = "dk__btn_Resetuj";
            this.dk__btn_Resetuj.Size = new System.Drawing.Size(132, 52);
            this.dk__btn_Resetuj.TabIndex = 8;
            this.dk__btn_Resetuj.Text = "Resetuj";
            this.dk__btn_Resetuj.UseVisualStyleBackColor = false;
            this.dk__btn_Resetuj.Click += new System.EventHandler(this.dk__btn_Resetuj_Click);
            // 
            // dk__dgv_TabelaWyników
            // 
            this.dk__dgv_TabelaWyników.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dk__dgv_TabelaWyników.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dk__dgv_TabelaWyników.Location = new System.Drawing.Point(497, 99);
            this.dk__dgv_TabelaWyników.Margin = new System.Windows.Forms.Padding(4);
            this.dk__dgv_TabelaWyników.Name = "dk__dgv_TabelaWyników";
            this.dk__dgv_TabelaWyników.RowHeadersWidth = 51;
            this.dk__dgv_TabelaWyników.Size = new System.Drawing.Size(596, 78);
            this.dk__dgv_TabelaWyników.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Rozmiar sortowanej tablicy";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Koszt czasowy pomiaru";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Wynik analityczny na podstawie wzoru";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Koszt pamięciowy";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // dk_WybranyAlgorytm
            // 
            this.dk_WybranyAlgorytm.AutoSize = true;
            this.dk_WybranyAlgorytm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk_WybranyAlgorytm.Location = new System.Drawing.Point(603, 14);
            this.dk_WybranyAlgorytm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dk_WybranyAlgorytm.Name = "dk_WybranyAlgorytm";
            this.dk_WybranyAlgorytm.Size = new System.Drawing.Size(97, 20);
            this.dk_WybranyAlgorytm.TabIndex = 11;
            this.dk_WybranyAlgorytm.Text = "Radix Sort";
            // 
            // dk_ButtonZmianaSortowania
            // 
            this.dk_ButtonZmianaSortowania.BackColor = System.Drawing.Color.Gold;
            this.dk_ButtonZmianaSortowania.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk_ButtonZmianaSortowania.Location = new System.Drawing.Point(396, 43);
            this.dk_ButtonZmianaSortowania.Margin = new System.Windows.Forms.Padding(4);
            this.dk_ButtonZmianaSortowania.Name = "dk_ButtonZmianaSortowania";
            this.dk_ButtonZmianaSortowania.Size = new System.Drawing.Size(304, 28);
            this.dk_ButtonZmianaSortowania.TabIndex = 12;
            this.dk_ButtonZmianaSortowania.Text = "Zmien";
            this.dk_ButtonZmianaSortowania.UseVisualStyleBackColor = false;
            this.dk_ButtonZmianaSortowania.Click += new System.EventHandler(this.dk_ButtonZmianaSortowania_Click);
            // 
            // dk_linkLabel1
            // 
            this.dk_linkLabel1.AutoSize = true;
            this.dk_linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk_linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.dk_linkLabel1.Location = new System.Drawing.Point(468, 770);
            this.dk_linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dk_linkLabel1.Name = "dk_linkLabel1";
            this.dk_linkLabel1.Size = new System.Drawing.Size(206, 20);
            this.dk_linkLabel1.TabIndex = 13;
            this.dk_linkLabel1.TabStop = true;
            this.dk_linkLabel1.Text = "Radix Sort wizualizacja";
            this.dk_linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dk_linkLabel1_LinkClicked);
            // 
            // dk_linkLabel2
            // 
            this.dk_linkLabel2.AutoSize = true;
            this.dk_linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk_linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.dk_linkLabel2.Location = new System.Drawing.Point(802, 770);
            this.dk_linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dk_linkLabel2.Name = "dk_linkLabel2";
            this.dk_linkLabel2.Size = new System.Drawing.Size(218, 20);
            this.dk_linkLabel2.TabIndex = 14;
            this.dk_linkLabel2.TabStop = true;
            this.dk_linkLabel2.Text = "Library Sort wizualizacja";
            this.dk_linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dk_linkLabel2_LinkClicked);
            // 
            // dk_Wykres
            // 
            chartArea3.Name = "ChartArea1";
            this.dk_Wykres.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.dk_Wykres.Legends.Add(legend3);
            this.dk_Wykres.Location = new System.Drawing.Point(396, 99);
            this.dk_Wykres.Margin = new System.Windows.Forms.Padding(4);
            this.dk_Wykres.Name = "dk_Wykres";
            this.dk_Wykres.Size = new System.Drawing.Size(697, 662);
            this.dk_Wykres.TabIndex = 15;
            this.dk_Wykres.Text = "chart1";
            this.dk_Wykres.Visible = false;
            // 
            // dk__label1
            // 
            this.dk__label1.AutoSize = true;
            this.dk__label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk__label1.Location = new System.Drawing.Point(78, 14);
            this.dk__label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dk__label1.Name = "dk__label1";
            this.dk__label1.Size = new System.Drawing.Size(242, 20);
            this.dk__label1.TabIndex = 16;
            this.dk__label1.Text = "Minimalna próba badawcza:";
            this.dk__label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dk__label2
            // 
            this.dk__label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk__label2.Location = new System.Drawing.Point(91, 64);
            this.dk__label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dk__label2.Name = "dk__label2";
            this.dk__label2.Size = new System.Drawing.Size(199, 42);
            this.dk__label2.TabIndex = 17;
            this.dk__label2.Text = "Maksymalny rozmiar sortowanych tablic:";
            this.dk__label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dk__label3
            // 
            this.dk__label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk__label3.Location = new System.Drawing.Point(62, 136);
            this.dk__label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dk__label3.Name = "dk__label3";
            this.dk__label3.Size = new System.Drawing.Size(267, 46);
            this.dk__label3.TabIndex = 19;
            this.dk__label3.Text = "Dolna granica przedziału wartości elementów w tablicy:";
            this.dk__label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dk__label4
            // 
            this.dk__label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk__label4.Location = new System.Drawing.Point(45, 213);
            this.dk__label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dk__label4.Name = "dk__label4";
            this.dk__label4.Size = new System.Drawing.Size(304, 46);
            this.dk__label4.TabIndex = 20;
            this.dk__label4.Text = "Górna granica przedziału wartości elementów w tablicy:";
            this.dk__label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dk__label5
            // 
            this.dk__label5.AutoSize = true;
            this.dk__label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk__label5.Location = new System.Drawing.Point(392, 14);
            this.dk__label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dk__label5.Name = "dk__label5";
            this.dk__label5.Size = new System.Drawing.Size(172, 20);
            this.dk__label5.TabIndex = 21;
            this.dk__label5.Text = "Algorytm sortujący:";
            // 
            // dk__label6
            // 
            this.dk__label6.AutoSize = true;
            this.dk__label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk__label6.Location = new System.Drawing.Point(8, 61);
            this.dk__label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dk__label6.Name = "dk__label6";
            this.dk__label6.Size = new System.Drawing.Size(208, 20);
            this.dk__label6.TabIndex = 22;
            this.dk__label6.Text = "Koszt czasowy pomiaru";
            // 
            // dk__label12
            // 
            this.dk__label12.AutoSize = true;
            this.dk__label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk__label12.Location = new System.Drawing.Point(8, 19);
            this.dk__label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dk__label12.Name = "dk__label12";
            this.dk__label12.Size = new System.Drawing.Size(113, 20);
            this.dk__label12.TabIndex = 23;
            this.dk__label12.Text = "Edytuj style:";
            // 
            // dk__label8
            // 
            this.dk__label8.AutoSize = true;
            this.dk__label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk__label8.Location = new System.Drawing.Point(8, 366);
            this.dk__label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dk__label8.Name = "dk__label8";
            this.dk__label8.Size = new System.Drawing.Size(160, 20);
            this.dk__label8.TabIndex = 24;
            this.dk__label8.Text = "Koszt pamięciowy";
            // 
            // dk__label7
            // 
            this.dk__label7.AutoSize = true;
            this.dk__label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk__label7.Location = new System.Drawing.Point(8, 218);
            this.dk__label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dk__label7.Name = "dk__label7";
            this.dk__label7.Size = new System.Drawing.Size(157, 20);
            this.dk__label7.TabIndex = 28;
            this.dk__label7.Text = "Koszt analityczny";
            // 
            // dk_ZmianaStylu1
            // 
            this.dk_ZmianaStylu1.FormattingEnabled = true;
            this.dk_ZmianaStylu1.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot"});
            this.dk_ZmianaStylu1.Location = new System.Drawing.Point(8, 117);
            this.dk_ZmianaStylu1.Margin = new System.Windows.Forms.Padding(4);
            this.dk_ZmianaStylu1.Name = "dk_ZmianaStylu1";
            this.dk_ZmianaStylu1.Size = new System.Drawing.Size(199, 24);
            this.dk_ZmianaStylu1.TabIndex = 29;
            this.dk_ZmianaStylu1.SelectedIndexChanged += new System.EventHandler(this.dk_ZmianaStylu1_SelectedIndexChanged);
            // 
            // dk_ZmianaStylu3
            // 
            this.dk_ZmianaStylu3.FormattingEnabled = true;
            this.dk_ZmianaStylu3.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot"});
            this.dk_ZmianaStylu3.Location = new System.Drawing.Point(12, 423);
            this.dk_ZmianaStylu3.Margin = new System.Windows.Forms.Padding(4);
            this.dk_ZmianaStylu3.Name = "dk_ZmianaStylu3";
            this.dk_ZmianaStylu3.Size = new System.Drawing.Size(199, 24);
            this.dk_ZmianaStylu3.TabIndex = 30;
            this.dk_ZmianaStylu3.SelectedIndexChanged += new System.EventHandler(this.dk_ZmianaStylu3_SelectedIndexChanged);
            // 
            // dk_ZmianaStylu2
            // 
            this.dk_ZmianaStylu2.FormattingEnabled = true;
            this.dk_ZmianaStylu2.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot"});
            this.dk_ZmianaStylu2.Location = new System.Drawing.Point(8, 274);
            this.dk_ZmianaStylu2.Margin = new System.Windows.Forms.Padding(4);
            this.dk_ZmianaStylu2.Name = "dk_ZmianaStylu2";
            this.dk_ZmianaStylu2.Size = new System.Drawing.Size(199, 24);
            this.dk_ZmianaStylu2.TabIndex = 31;
            this.dk_ZmianaStylu2.SelectedIndexChanged += new System.EventHandler(this.dk_ZmianaStylu2_SelectedIndexChanged);
            // 
            // dk_ZmianaGrubosci1
            // 
            this.dk_ZmianaGrubosci1.Location = new System.Drawing.Point(8, 149);
            this.dk_ZmianaGrubosci1.Margin = new System.Windows.Forms.Padding(4);
            this.dk_ZmianaGrubosci1.Name = "dk_ZmianaGrubosci1";
            this.dk_ZmianaGrubosci1.Size = new System.Drawing.Size(196, 56);
            this.dk_ZmianaGrubosci1.TabIndex = 32;
            this.dk_ZmianaGrubosci1.Scroll += new System.EventHandler(this.dk_ZmianaGrubosci1_Scroll);
            // 
            // dk_ZmianaGrubosci2
            // 
            this.dk_ZmianaGrubosci2.Location = new System.Drawing.Point(8, 306);
            this.dk_ZmianaGrubosci2.Margin = new System.Windows.Forms.Padding(4);
            this.dk_ZmianaGrubosci2.Name = "dk_ZmianaGrubosci2";
            this.dk_ZmianaGrubosci2.Size = new System.Drawing.Size(199, 56);
            this.dk_ZmianaGrubosci2.TabIndex = 33;
            this.dk_ZmianaGrubosci2.Scroll += new System.EventHandler(this.dk_ZmianaGrubosci2_Scroll);
            // 
            // dk_ZmianaGrubosci3
            // 
            this.dk_ZmianaGrubosci3.Location = new System.Drawing.Point(11, 454);
            this.dk_ZmianaGrubosci3.Margin = new System.Windows.Forms.Padding(4);
            this.dk_ZmianaGrubosci3.Name = "dk_ZmianaGrubosci3";
            this.dk_ZmianaGrubosci3.Size = new System.Drawing.Size(200, 56);
            this.dk_ZmianaGrubosci3.TabIndex = 34;
            this.dk_ZmianaGrubosci3.Scroll += new System.EventHandler(this.dk_ZmianaGrubosci3_Scroll);
            // 
            // dk_ZmianaKoloru1
            // 
            this.dk_ZmianaKoloru1.BackColor = System.Drawing.Color.Gold;
            this.dk_ZmianaKoloru1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk_ZmianaKoloru1.Location = new System.Drawing.Point(8, 82);
            this.dk_ZmianaKoloru1.Margin = new System.Windows.Forms.Padding(4);
            this.dk_ZmianaKoloru1.Name = "dk_ZmianaKoloru1";
            this.dk_ZmianaKoloru1.Size = new System.Drawing.Size(199, 28);
            this.dk_ZmianaKoloru1.TabIndex = 35;
            this.dk_ZmianaKoloru1.Text = "ZMIANA KOLORU";
            this.dk_ZmianaKoloru1.UseVisualStyleBackColor = false;
            this.dk_ZmianaKoloru1.Click += new System.EventHandler(this.dk_ZmianaKoloru1_Click);
            // 
            // dk_ZmianaKoloru2
            // 
            this.dk_ZmianaKoloru2.BackColor = System.Drawing.Color.Gold;
            this.dk_ZmianaKoloru2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk_ZmianaKoloru2.Location = new System.Drawing.Point(8, 239);
            this.dk_ZmianaKoloru2.Margin = new System.Windows.Forms.Padding(4);
            this.dk_ZmianaKoloru2.Name = "dk_ZmianaKoloru2";
            this.dk_ZmianaKoloru2.Size = new System.Drawing.Size(199, 27);
            this.dk_ZmianaKoloru2.TabIndex = 36;
            this.dk_ZmianaKoloru2.Text = "ZMIANA KOLORU";
            this.dk_ZmianaKoloru2.UseVisualStyleBackColor = false;
            this.dk_ZmianaKoloru2.Click += new System.EventHandler(this.dk_ZmianaKoloru2_Click);
            // 
            // dk_ZmianaKoloru3
            // 
            this.dk_ZmianaKoloru3.BackColor = System.Drawing.Color.Gold;
            this.dk_ZmianaKoloru3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dk_ZmianaKoloru3.Location = new System.Drawing.Point(11, 387);
            this.dk_ZmianaKoloru3.Margin = new System.Windows.Forms.Padding(4);
            this.dk_ZmianaKoloru3.Name = "dk_ZmianaKoloru3";
            this.dk_ZmianaKoloru3.Size = new System.Drawing.Size(200, 28);
            this.dk_ZmianaKoloru3.TabIndex = 37;
            this.dk_ZmianaKoloru3.Text = "ZMIANA KOLORU";
            this.dk_ZmianaKoloru3.UseVisualStyleBackColor = false;
            this.dk_ZmianaKoloru3.Click += new System.EventHandler(this.dk_ZmianaKoloru3_Click);
            // 
            // dk__groupBox1
            // 
            this.dk__groupBox1.Controls.Add(this.dk_ZmianaKoloru2);
            this.dk__groupBox1.Controls.Add(this.dk__label6);
            this.dk__groupBox1.Controls.Add(this.dk__label12);
            this.dk__groupBox1.Controls.Add(this.dk__label8);
            this.dk__groupBox1.Controls.Add(this.dk_ZmianaKoloru3);
            this.dk__groupBox1.Controls.Add(this.dk__label7);
            this.dk__groupBox1.Controls.Add(this.dk_ZmianaStylu1);
            this.dk__groupBox1.Controls.Add(this.dk_ZmianaKoloru1);
            this.dk__groupBox1.Controls.Add(this.dk_ZmianaStylu3);
            this.dk__groupBox1.Controls.Add(this.dk_ZmianaGrubosci3);
            this.dk__groupBox1.Controls.Add(this.dk_ZmianaStylu2);
            this.dk__groupBox1.Controls.Add(this.dk_ZmianaGrubosci2);
            this.dk__groupBox1.Controls.Add(this.dk_ZmianaGrubosci1);
            this.dk__groupBox1.Location = new System.Drawing.Point(1179, 99);
            this.dk__groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.dk__groupBox1.Name = "dk__groupBox1";
            this.dk__groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.dk__groupBox1.Size = new System.Drawing.Size(226, 518);
            this.dk__groupBox1.TabIndex = 41;
            this.dk__groupBox1.TabStop = false;
            // 
            // dk_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1408, 796);
            this.Controls.Add(this.dk__groupBox1);
            this.Controls.Add(this.dk__label5);
            this.Controls.Add(this.dk__label4);
            this.Controls.Add(this.dk__label3);
            this.Controls.Add(this.dk__label2);
            this.Controls.Add(this.dk__label1);
            this.Controls.Add(this.dk_Wykres);
            this.Controls.Add(this.dk_linkLabel2);
            this.Controls.Add(this.dk_linkLabel1);
            this.Controls.Add(this.dk_ButtonZmianaSortowania);
            this.Controls.Add(this.dk_WybranyAlgorytm);
            this.Controls.Add(this.dk__dgv_TabelaWyników);
            this.Controls.Add(this.dk__btn_Resetuj);
            this.Controls.Add(this.dk__btn_WynikiWykres);
            this.Controls.Add(this.dk__btn_WynikiTabelaryczne);
            this.Controls.Add(this.dk__btn_AkceptacjaDanych);
            this.Controls.Add(this.dk__txt_GórnaGranica);
            this.Controls.Add(this.dk__txt_DolnaGranica);
            this.Controls.Add(this.dk__txt_MinimalnaPróbaBadawcza);
            this.Controls.Add(this.dk__txt_RozmiarTabl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dk_Form";
            this.Text = "Dmytro Kruhlov 48720";
            this.Load += new System.EventHandler(this.dk_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dk__dgv_TabelaWyników)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dk_Wykres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dk_ZmianaGrubosci1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dk_ZmianaGrubosci2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dk_ZmianaGrubosci3)).EndInit();
            this.dk__groupBox1.ResumeLayout(false);
            this.dk__groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dk__txt_RozmiarTabl;
        private System.Windows.Forms.TextBox dk__txt_MinimalnaPróbaBadawcza;
        private System.Windows.Forms.TextBox dk__txt_DolnaGranica;
        private System.Windows.Forms.TextBox dk__txt_GórnaGranica;
        private System.Windows.Forms.Button dk__btn_AkceptacjaDanych;
        private System.Windows.Forms.Button dk__btn_WynikiTabelaryczne;
        private System.Windows.Forms.Button dk__btn_WynikiWykres;
        private System.Windows.Forms.Button dk__btn_Resetuj;
        private System.Windows.Forms.DataGridView dk__dgv_TabelaWyników;
        private System.Windows.Forms.Button dk_ButtonZmianaSortowania;
        private System.Windows.Forms.Label dk_WybranyAlgorytm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.LinkLabel dk_linkLabel1;
        private System.Windows.Forms.LinkLabel dk_linkLabel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart dk_Wykres;
        private System.Windows.Forms.Label dk__label1;
        private System.Windows.Forms.Label dk__label2;
        private System.Windows.Forms.Label dk__label3;
        private System.Windows.Forms.Label dk__label4;
        private System.Windows.Forms.Label dk__label5;
        private System.Windows.Forms.Label dk__label6;
        private System.Windows.Forms.Label dk__label12;
        private System.Windows.Forms.Label dk__label8;
        private System.Windows.Forms.Label dk__label7;
        private System.Windows.Forms.ComboBox dk_ZmianaStylu1;
        private System.Windows.Forms.ComboBox dk_ZmianaStylu3;
        private System.Windows.Forms.ComboBox dk_ZmianaStylu2;
        private System.Windows.Forms.TrackBar dk_ZmianaGrubosci1;
        private System.Windows.Forms.TrackBar dk_ZmianaGrubosci2;
        private System.Windows.Forms.TrackBar dk_ZmianaGrubosci3;
        private System.Windows.Forms.Button dk_ZmianaKoloru1;
        private System.Windows.Forms.Button dk_ZmianaKoloru2;
        private System.Windows.Forms.Button dk_ZmianaKoloru3;
        private System.Windows.Forms.ColorDialog dk__colorDialog1;
        private System.Windows.Forms.ColorDialog dk__colorDialog2;
        private System.Windows.Forms.ColorDialog dk__colorDialog3;
        private System.Windows.Forms.GroupBox dk__groupBox1;
    }
}

