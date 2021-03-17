namespace WendingMachine
{
    partial class dkForm1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.waluta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.zlpol = new System.Windows.Forms.Button();
            this.zl = new System.Windows.Forms.Button();
            this.zl2 = new System.Windows.Forms.Button();
            this.zl5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.opl_mon = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cSprite = new System.Windows.Forms.Label();
            this.cCola = new System.Windows.Forms.Label();
            this.cPepsi = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.Mars = new System.Windows.Forms.Button();
            this.Snickers = new System.Windows.Forms.Button();
            this.Pepsi = new System.Windows.Forms.Button();
            this.Cola = new System.Windows.Forms.Button();
            this.Sprite = new System.Windows.Forms.Button();
            this.wrz_cash = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cSnickers = new System.Windows.Forms.Label();
            this.cMars = new System.Windows.Forms.Label();
            this.resztalabel = new System.Windows.Forms.Label();
            this.fullreszta = new System.Windows.Forms.Label();
            this.kol05 = new System.Windows.Forms.Label();
            this.kol1 = new System.Windows.Forms.Label();
            this.kol2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.kwota = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maszyna Vendingowa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor: Dmytro Kruhlov";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Karta studencka: 48720";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wybierz walute:";
            // 
            // waluta
            // 
            this.waluta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.waluta.FormattingEnabled = true;
            this.waluta.Items.AddRange(new object[] {
            "PLN",
            "EUR",
            "USD"});
            this.waluta.Location = new System.Drawing.Point(665, 40);
            this.waluta.Name = "waluta";
            this.waluta.Size = new System.Drawing.Size(79, 21);
            this.waluta.TabIndex = 4;
            this.waluta.SelectedIndexChanged += new System.EventHandler(this.waluta_SelectedIndexChanged);
            this.waluta.SelectionChangeCommitted += new System.EventHandler(this.waluta_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(662, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Wybierz rodzaj platnosci:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Karta",
            "Gotowka"});
            this.comboBox2.Location = new System.Drawing.Point(665, 125);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(79, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(662, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "WRZUC MONETE";
            // 
            // zlpol
            // 
            this.zlpol.Location = new System.Drawing.Point(665, 219);
            this.zlpol.Name = "zlpol";
            this.zlpol.Size = new System.Drawing.Size(36, 23);
            this.zlpol.TabIndex = 8;
            this.zlpol.Text = "0.50";
            this.zlpol.UseVisualStyleBackColor = true;
            this.zlpol.Click += new System.EventHandler(this.zlpol_Click);
            // 
            // zl
            // 
            this.zl.Location = new System.Drawing.Point(724, 219);
            this.zl.Name = "zl";
            this.zl.Size = new System.Drawing.Size(35, 23);
            this.zl.TabIndex = 9;
            this.zl.Text = "1.00";
            this.zl.UseVisualStyleBackColor = true;
            this.zl.Click += new System.EventHandler(this.zl_Click);
            // 
            // zl2
            // 
            this.zl2.Location = new System.Drawing.Point(665, 257);
            this.zl2.Name = "zl2";
            this.zl2.Size = new System.Drawing.Size(36, 23);
            this.zl2.TabIndex = 10;
            this.zl2.Text = "2.00";
            this.zl2.UseVisualStyleBackColor = true;
            this.zl2.Click += new System.EventHandler(this.zl2_Click);
            // 
            // zl5
            // 
            this.zl5.Location = new System.Drawing.Point(724, 257);
            this.zl5.Name = "zl5";
            this.zl5.Size = new System.Drawing.Size(35, 23);
            this.zl5.TabIndex = 11;
            this.zl5.Text = "5.00";
            this.zl5.UseVisualStyleBackColor = true;
            this.zl5.Click += new System.EventHandler(this.zl5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(662, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "WRZUCONA ILOSC PIENIEDZY";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // opl_mon
            // 
            this.opl_mon.Location = new System.Drawing.Point(665, 368);
            this.opl_mon.Name = "opl_mon";
            this.opl_mon.Size = new System.Drawing.Size(121, 23);
            this.opl_mon.TabIndex = 13;
            this.opl_mon.Text = "ZAPLAC MONETAMI";
            this.opl_mon.UseVisualStyleBackColor = true;
            this.opl_mon.Click += new System.EventHandler(this.opl_mon_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "NAPOJE";
            // 
            // cSprite
            // 
            this.cSprite.AutoSize = true;
            this.cSprite.Location = new System.Drawing.Point(311, 219);
            this.cSprite.Name = "cSprite";
            this.cSprite.Size = new System.Drawing.Size(28, 13);
            this.cSprite.TabIndex = 19;
            this.cSprite.Text = "2.50";
            this.cSprite.Click += new System.EventHandler(this.cSprite_Click);
            // 
            // cCola
            // 
            this.cCola.AutoSize = true;
            this.cCola.Location = new System.Drawing.Point(393, 219);
            this.cCola.Name = "cCola";
            this.cCola.Size = new System.Drawing.Size(28, 13);
            this.cCola.TabIndex = 20;
            this.cCola.Text = "5.00";
            this.cCola.Click += new System.EventHandler(this.cCola_Click);
            // 
            // cPepsi
            // 
            this.cPepsi.AutoSize = true;
            this.cPepsi.Location = new System.Drawing.Point(472, 219);
            this.cPepsi.Name = "cPepsi";
            this.cPepsi.Size = new System.Drawing.Size(28, 13);
            this.cPepsi.TabIndex = 21;
            this.cPepsi.Text = "7.50";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(384, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "BATONY";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Nominalow o wartosci 2 jest:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Nominalow o wartosci 1 jest:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Nominalow o wartosci 0.5 jest:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "12";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(31, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "9";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(31, 188);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "7";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(31, 262);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 13);
            this.label20.TabIndex = 31;
            this.label20.Text = "Dostepna kwota to:";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(31, 331);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(168, 13);
            this.label21.TabIndex = 32;
            this.label21.Text = "Po wybraniu oriduktu przyloz karte";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(40, 348);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(132, 13);
            this.label22.TabIndex = 33;
            this.label22.Text = "(Wczysnij przycisk ponizej)";
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::WendingMachine.Properties.Resources.karta;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.Location = new System.Drawing.Point(71, 368);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 63);
            this.button11.TabIndex = 34;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Mars
            // 
            this.Mars.BackgroundImage = global::WendingMachine.Properties.Resources.mars;
            this.Mars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Mars.Location = new System.Drawing.Point(425, 348);
            this.Mars.Name = "Mars";
            this.Mars.Size = new System.Drawing.Size(75, 63);
            this.Mars.TabIndex = 24;
            this.Mars.UseVisualStyleBackColor = true;
            this.Mars.Click += new System.EventHandler(this.Mars_Click);
            // 
            // Snickers
            // 
            this.Snickers.BackgroundImage = global::WendingMachine.Properties.Resources.snickers;
            this.Snickers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Snickers.Location = new System.Drawing.Point(314, 348);
            this.Snickers.Name = "Snickers";
            this.Snickers.Size = new System.Drawing.Size(75, 63);
            this.Snickers.TabIndex = 23;
            this.Snickers.UseVisualStyleBackColor = true;
            this.Snickers.Click += new System.EventHandler(this.Snickers_Click);
            // 
            // Pepsi
            // 
            this.Pepsi.BackgroundImage = global::WendingMachine.Properties.Resources.pepsi;
            this.Pepsi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pepsi.Location = new System.Drawing.Point(450, 138);
            this.Pepsi.Name = "Pepsi";
            this.Pepsi.Size = new System.Drawing.Size(75, 63);
            this.Pepsi.TabIndex = 18;
            this.Pepsi.UseVisualStyleBackColor = true;
            this.Pepsi.Click += new System.EventHandler(this.Pepsi_Click);
            // 
            // Cola
            // 
            this.Cola.BackgroundImage = global::WendingMachine.Properties.Resources.cola;
            this.Cola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cola.Location = new System.Drawing.Point(369, 138);
            this.Cola.Name = "Cola";
            this.Cola.Size = new System.Drawing.Size(75, 63);
            this.Cola.TabIndex = 17;
            this.Cola.UseVisualStyleBackColor = true;
            this.Cola.Click += new System.EventHandler(this.Cola_Click);
            // 
            // Sprite
            // 
            this.Sprite.BackgroundImage = global::WendingMachine.Properties.Resources.sprite;
            this.Sprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sprite.Location = new System.Drawing.Point(288, 138);
            this.Sprite.Name = "Sprite";
            this.Sprite.Size = new System.Drawing.Size(75, 63);
            this.Sprite.TabIndex = 16;
            this.Sprite.UseVisualStyleBackColor = true;
            this.Sprite.Click += new System.EventHandler(this.Sprite_Click);
            // 
            // wrz_cash
            // 
            this.wrz_cash.AutoSize = true;
            this.wrz_cash.Location = new System.Drawing.Point(662, 331);
            this.wrz_cash.Name = "wrz_cash";
            this.wrz_cash.Size = new System.Drawing.Size(22, 13);
            this.wrz_cash.TabIndex = 36;
            this.wrz_cash.Text = "0.0";
            this.wrz_cash.Click += new System.EventHandler(this.wrz_cash_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "36.5";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cSnickers
            // 
            this.cSnickers.AutoSize = true;
            this.cSnickers.Location = new System.Drawing.Point(335, 428);
            this.cSnickers.Name = "cSnickers";
            this.cSnickers.Size = new System.Drawing.Size(28, 13);
            this.cSnickers.TabIndex = 38;
            this.cSnickers.Text = "5.00";
            this.cSnickers.Click += new System.EventHandler(this.cSnickers_Click);
            // 
            // cMars
            // 
            this.cMars.AutoSize = true;
            this.cMars.Location = new System.Drawing.Point(447, 428);
            this.cMars.Name = "cMars";
            this.cMars.Size = new System.Drawing.Size(28, 13);
            this.cMars.TabIndex = 39;
            this.cMars.Text = "2.50";
            // 
            // resztalabel
            // 
            this.resztalabel.AutoSize = true;
            this.resztalabel.Location = new System.Drawing.Point(794, 448);
            this.resztalabel.Name = "resztalabel";
            this.resztalabel.Size = new System.Drawing.Size(0, 13);
            this.resztalabel.TabIndex = 40;
            // 
            // fullreszta
            // 
            this.fullreszta.AutoSize = true;
            this.fullreszta.Location = new System.Drawing.Point(794, 461);
            this.fullreszta.Name = "fullreszta";
            this.fullreszta.Size = new System.Drawing.Size(0, 13);
            this.fullreszta.TabIndex = 41;
            this.fullreszta.Click += new System.EventHandler(this.fullreszta_Click);
            // 
            // kol05
            // 
            this.kol05.AutoSize = true;
            this.kol05.Location = new System.Drawing.Point(734, 489);
            this.kol05.Name = "kol05";
            this.kol05.Size = new System.Drawing.Size(0, 13);
            this.kol05.TabIndex = 42;
            // 
            // kol1
            // 
            this.kol1.AutoSize = true;
            this.kol1.Location = new System.Drawing.Point(801, 489);
            this.kol1.Name = "kol1";
            this.kol1.Size = new System.Drawing.Size(0, 13);
            this.kol1.TabIndex = 43;
            // 
            // kol2
            // 
            this.kol2.AutoSize = true;
            this.kol2.Location = new System.Drawing.Point(866, 489);
            this.kol2.Name = "kol2";
            this.kol2.Size = new System.Drawing.Size(0, 13);
            this.kol2.TabIndex = 44;
            this.kol2.Click += new System.EventHandler(this.kol2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "KWOTA DO ZAPLATY:";
            // 
            // kwota
            // 
            this.kwota.AutoSize = true;
            this.kwota.Location = new System.Drawing.Point(467, 477);
            this.kwota.Name = "kwota";
            this.kwota.Size = new System.Drawing.Size(13, 13);
            this.kwota.TabIndex = 46;
            this.kwota.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(734, 524);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "50gr";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(801, 524);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "1zl";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(866, 524);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 13);
            this.label23.TabIndex = 49;
            this.label23.Text = "2zl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 576);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.kwota);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.kol2);
            this.Controls.Add(this.kol1);
            this.Controls.Add(this.kol05);
            this.Controls.Add(this.fullreszta);
            this.Controls.Add(this.resztalabel);
            this.Controls.Add(this.cMars);
            this.Controls.Add(this.cSnickers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.wrz_cash);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Mars);
            this.Controls.Add(this.Snickers);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cPepsi);
            this.Controls.Add(this.cCola);
            this.Controls.Add(this.cSprite);
            this.Controls.Add(this.Pepsi);
            this.Controls.Add(this.Cola);
            this.Controls.Add(this.Sprite);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.opl_mon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.zl5);
            this.Controls.Add(this.zl2);
            this.Controls.Add(this.zl);
            this.Controls.Add(this.zlpol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.waluta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Wending Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox waluta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button zlpol;
        private System.Windows.Forms.Button zl;
        private System.Windows.Forms.Button zl2;
        private System.Windows.Forms.Button zl5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button opl_mon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Sprite;
        private System.Windows.Forms.Button Cola;
        private System.Windows.Forms.Button Pepsi;
        private System.Windows.Forms.Label cSprite;
        private System.Windows.Forms.Label cCola;
        private System.Windows.Forms.Label cPepsi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Snickers;
        private System.Windows.Forms.Button Mars;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label wrz_cash;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label cSnickers;
        private System.Windows.Forms.Label cMars;
        private System.Windows.Forms.Label resztalabel;
        private System.Windows.Forms.Label fullreszta;
        private System.Windows.Forms.Label kol05;
        private System.Windows.Forms.Label kol1;
        private System.Windows.Forms.Label kol2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label kwota;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label23;
    }
}

