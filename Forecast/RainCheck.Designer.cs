namespace Forecast
{
    partial class RainCheck
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
            this.components = new System.ComponentModel.Container();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabOverview = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabUpdate = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ddlCities = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.tabAdd = new MetroFramework.Controls.MetroTabPage();
            this.txtWindSpeed = new MetroFramework.Controls.MetroTextBox();
            this.txtHumidity = new MetroFramework.Controls.MetroTextBox();
            this.txtPrecip = new MetroFramework.Controls.MetroTextBox();
            this.txtMaxTemp = new MetroFramework.Controls.MetroTextBox();
            this.txtMinTemp = new MetroFramework.Controls.MetroTextBox();
            this.txtCity = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.trkPrecip = new MetroFramework.Controls.MetroTrackBar();
            this.trkMaxTemp = new MetroFramework.Controls.MetroTrackBar();
            this.trkMinTemp = new MetroFramework.Controls.MetroTrackBar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbOutput = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.tabSettings = new MetroFramework.Controls.MetroTabPage();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tabDelete = new MetroFramework.Controls.MetroTabPage();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.pnlOverview = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.pnlOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTile2
            // 
            this.metroTile2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile2.Location = new System.Drawing.Point(0, 162);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(210, 96);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Refresh";
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile3.Location = new System.Drawing.Point(0, 258);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(210, 96);
            this.metroTile3.TabIndex = 1;
            this.metroTile3.Text = "Edit Cities";
            // 
            // metroTile4
            // 
            this.metroTile4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile4.Location = new System.Drawing.Point(0, 354);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(210, 96);
            this.metroTile4.TabIndex = 1;
            this.metroTile4.Text = "Edit Cities";
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabOverview);
            this.tabControl.Controls.Add(this.tabUpdate);
            this.tabControl.Controls.Add(this.tabAdd);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Controls.Add(this.tabDelete);
            this.tabControl.Location = new System.Drawing.Point(0, 26);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 1;
            this.tabControl.Size = new System.Drawing.Size(441, 411);
            this.tabControl.TabIndex = 1;
            this.tabControl.UseStyleColors = true;
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.dataGridView1);
            this.tabOverview.HorizontalScrollbarBarColor = true;
            this.tabOverview.Location = new System.Drawing.Point(4, 35);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Size = new System.Drawing.Size(433, 372);
            this.tabOverview.TabIndex = 0;
            this.tabOverview.Text = "Overview  ";
            this.tabOverview.VerticalScrollbarBarColor = true;
            this.tabOverview.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(433, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabUpdate
            // 
            this.tabUpdate.Controls.Add(this.dataGridView2);
            this.tabUpdate.Controls.Add(this.ddlCities);
            this.tabUpdate.Controls.Add(this.metroButton1);
            this.tabUpdate.Controls.Add(this.metroLabel7);
            this.tabUpdate.Controls.Add(this.metroLabel13);
            this.tabUpdate.HorizontalScrollbarBarColor = true;
            this.tabUpdate.Location = new System.Drawing.Point(4, 35);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Size = new System.Drawing.Size(433, 372);
            this.tabUpdate.TabIndex = 2;
            this.tabUpdate.Text = "Update     ";
            this.tabUpdate.VerticalScrollbarBarColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(145, 80);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(257, 205);
            this.dataGridView2.TabIndex = 23;
            // 
            // ddlCities
            // 
            this.ddlCities.FormattingEnabled = true;
            this.ddlCities.ItemHeight = 23;
            this.ddlCities.Location = new System.Drawing.Point(145, 35);
            this.ddlCities.Name = "ddlCities";
            this.ddlCities.Size = new System.Drawing.Size(257, 29);
            this.ddlCities.TabIndex = 22;
            this.ddlCities.SelectedIndexChanged += new System.EventHandler(this.ddlCities_SelectedIndexChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Location = new System.Drawing.Point(263, 311);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(139, 32);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 21;
            this.metroButton1.Text = "Update";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(30, 80);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(55, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Schema";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(30, 35);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(31, 19);
            this.metroLabel13.TabIndex = 13;
            this.metroLabel13.Text = "City";
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.txtWindSpeed);
            this.tabAdd.Controls.Add(this.txtHumidity);
            this.tabAdd.Controls.Add(this.txtPrecip);
            this.tabAdd.Controls.Add(this.txtMaxTemp);
            this.tabAdd.Controls.Add(this.txtMinTemp);
            this.tabAdd.Controls.Add(this.txtCity);
            this.tabAdd.Controls.Add(this.btnSave);
            this.tabAdd.Controls.Add(this.trkPrecip);
            this.tabAdd.Controls.Add(this.trkMaxTemp);
            this.tabAdd.Controls.Add(this.trkMinTemp);
            this.tabAdd.Controls.Add(this.dateTimePicker1);
            this.tabAdd.Controls.Add(this.lbOutput);
            this.tabAdd.Controls.Add(this.metroLabel6);
            this.tabAdd.Controls.Add(this.metroLabel5);
            this.tabAdd.Controls.Add(this.metroLabel4);
            this.tabAdd.Controls.Add(this.metroLabel3);
            this.tabAdd.Controls.Add(this.metroLabel2);
            this.tabAdd.Controls.Add(this.metroLabel1);
            this.tabAdd.Controls.Add(this.label1);
            this.tabAdd.HorizontalScrollbarBarColor = true;
            this.tabAdd.Location = new System.Drawing.Point(4, 35);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Size = new System.Drawing.Size(433, 372);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add      ";
            this.tabAdd.VerticalScrollbarBarColor = true;
            this.tabAdd.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // txtWindSpeed
            // 
            this.txtWindSpeed.Location = new System.Drawing.Point(129, 271);
            this.txtWindSpeed.Name = "txtWindSpeed";
            this.txtWindSpeed.Size = new System.Drawing.Size(257, 23);
            this.txtWindSpeed.TabIndex = 7;
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(129, 231);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(257, 23);
            this.txtHumidity.TabIndex = 6;
            // 
            // txtPrecip
            // 
            this.txtPrecip.Location = new System.Drawing.Point(362, 190);
            this.txtPrecip.Name = "txtPrecip";
            this.txtPrecip.Size = new System.Drawing.Size(24, 23);
            this.txtPrecip.TabIndex = 7;
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Location = new System.Drawing.Point(362, 145);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Size = new System.Drawing.Size(24, 23);
            this.txtMaxTemp.TabIndex = 7;
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(362, 105);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(24, 23);
            this.txtMinTemp.TabIndex = 100;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(129, 38);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(257, 23);
            this.txtCity.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(247, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 32);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // trkPrecip
            // 
            this.trkPrecip.BackColor = System.Drawing.Color.Transparent;
            this.trkPrecip.Location = new System.Drawing.Point(129, 190);
            this.trkPrecip.Name = "trkPrecip";
            this.trkPrecip.Size = new System.Drawing.Size(224, 23);
            this.trkPrecip.TabIndex = 5;
            this.trkPrecip.Text = "metroTrackBar1";
            this.trkPrecip.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trkPrecip_Scroll);
            // 
            // trkMaxTemp
            // 
            this.trkMaxTemp.BackColor = System.Drawing.Color.Transparent;
            this.trkMaxTemp.Location = new System.Drawing.Point(129, 145);
            this.trkMaxTemp.Name = "trkMaxTemp";
            this.trkMaxTemp.Size = new System.Drawing.Size(224, 23);
            this.trkMaxTemp.TabIndex = 4;
            this.trkMaxTemp.Text = "metroTrackBar1";
            this.trkMaxTemp.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trkMaxTemp_Scroll);
            // 
            // trkMinTemp
            // 
            this.trkMinTemp.BackColor = System.Drawing.Color.Transparent;
            this.trkMinTemp.Location = new System.Drawing.Point(129, 104);
            this.trkMinTemp.Name = "trkMinTemp";
            this.trkMinTemp.Size = new System.Drawing.Size(224, 23);
            this.trkMinTemp.TabIndex = 3;
            this.trkMinTemp.Text = "metroTrackBar1";
            this.trkMinTemp.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trkMinTemp_Scroll);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(14, 313);
            this.lbOutput.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(0, 0);
            this.lbOutput.TabIndex = 2;
            this.lbOutput.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(14, 271);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(81, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Wind Speed";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(14, 231);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Humidity";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 190);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Precipitation";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 145);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Max. Temp.";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 109);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Min. Temp.";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 71);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Date";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "City";
            this.label1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.metroComboBox3);
            this.tabSettings.Controls.Add(this.metroComboBox2);
            this.tabSettings.Controls.Add(this.metroLabel8);
            this.tabSettings.Controls.Add(this.metroLabel9);
            this.tabSettings.HorizontalScrollbarBarColor = true;
            this.tabSettings.Location = new System.Drawing.Point(4, 35);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(433, 372);
            this.tabSettings.TabIndex = 4;
            this.tabSettings.Text = "Settings           ";
            this.tabSettings.VerticalScrollbarBarColor = true;
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Items.AddRange(new object[] {
            "km/h",
            "mph",
            "knot",
            "m/s"});
            this.metroComboBox3.Location = new System.Drawing.Point(172, 133);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(207, 29);
            this.metroComboBox3.TabIndex = 10;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "Celcius",
            "Farenheit"});
            this.metroComboBox2.Location = new System.Drawing.Point(172, 71);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(207, 29);
            this.metroComboBox2.TabIndex = 10;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(45, 138);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(78, 19);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Speed Units";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(45, 81);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(73, 19);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "Temp Units";
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.metroTextBox1);
            this.tabDelete.Controls.Add(this.metroLabel10);
            this.tabDelete.HorizontalScrollbarBarColor = true;
            this.tabDelete.Location = new System.Drawing.Point(4, 35);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(433, 372);
            this.tabDelete.TabIndex = 3;
            this.tabDelete.Text = "Delete           ";
            this.tabDelete.VerticalScrollbarBarColor = true;
            this.tabDelete.Click += new System.EventHandler(this.tabDelete_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(145, 35);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(195, 23);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.Text = "metroTextBox1";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(33, 35);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(88, 19);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "metroLabel10";
            // 
            // pnlOverview
            // 
            this.pnlOverview.Controls.Add(this.button1);
            this.pnlOverview.Controls.Add(this.tabControl);
            this.pnlOverview.HorizontalScrollbarBarColor = true;
            this.pnlOverview.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlOverview.HorizontalScrollbarSize = 10;
            this.pnlOverview.Location = new System.Drawing.Point(205, 8);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(593, 439);
            this.pnlOverview.TabIndex = 0;
            this.pnlOverview.VerticalScrollbarBarColor = true;
            this.pnlOverview.VerticalScrollbarHighlightOnWheel = false;
            this.pnlOverview.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(0, 66);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(210, 96);
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "Search";
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Image = global::Forecast.Properties.Resources.flash1;
            this.button1.Location = new System.Drawing.Point(413, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RainCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.pnlOverview);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RainCheck";
            this.Text = "RainCheck";
            this.Load += new System.EventHandler(this.RainCheck_Load);
            this.tabControl.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabUpdate.ResumeLayout(false);
            this.tabUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.pnlOverview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tabOverview;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTabPage tabUpdate;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroComboBox ddlCities;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTabPage tabAdd;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTrackBar trkPrecip;
        private MetroFramework.Controls.MetroTrackBar trkMaxTemp;
        private MetroFramework.Controls.MetroTrackBar trkMinTemp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroTabPage tabDelete;
        private MetroFramework.Controls.MetroTabPage tabSettings;
        private MetroFramework.Controls.MetroPanel pnlOverview;
        private MetroFramework.Controls.MetroTextBox txtWindSpeed;
        private MetroFramework.Controls.MetroTextBox txtHumidity;
        private MetroFramework.Controls.MetroTextBox txtCity;
        private MetroFramework.Controls.MetroTextBox txtPrecip;
        private MetroFramework.Controls.MetroTextBox txtMaxTemp;
        private MetroFramework.Controls.MetroTextBox txtMinTemp;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel lbOutput;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}