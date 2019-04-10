namespace Forecast
{
    partial class Search_City
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
            this.bindingSourceForecast = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSearchCity = new MetroFramework.Controls.MetroTextBox();
            this.grdCityForecast = new System.Windows.Forms.DataGridView();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.trkRange = new MetroFramework.Controls.MetroTrackBar();
            this.txtRange = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceForecast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCityForecast)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(500, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 33);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Go Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 130);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Forecast";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(31, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "City";
            // 
            // txtSearchCity
            // 
            this.txtSearchCity.Location = new System.Drawing.Point(83, 79);
            this.txtSearchCity.Name = "txtSearchCity";
            this.txtSearchCity.Size = new System.Drawing.Size(186, 23);
            this.txtSearchCity.TabIndex = 1;
            this.txtSearchCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchCity_KeyPress);
            // 
            // grdCityForecast
            // 
            this.grdCityForecast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCityForecast.Location = new System.Drawing.Point(83, 126);
            this.grdCityForecast.Name = "grdCityForecast";
            this.grdCityForecast.Size = new System.Drawing.Size(516, 251);
            this.grdCityForecast.TabIndex = 4;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(328, 79);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Range";
            // 
            // trkRange
            // 
            this.trkRange.BackColor = System.Drawing.Color.Transparent;
            this.trkRange.LargeChange = 3;
            this.trkRange.Location = new System.Drawing.Point(380, 79);
            this.trkRange.Maximum = 15;
            this.trkRange.Name = "trkRange";
            this.trkRange.Size = new System.Drawing.Size(177, 23);
            this.trkRange.TabIndex = 5;
            this.trkRange.Text = "metroTrackBar1";
            this.trkRange.Value = 15;
            this.trkRange.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trkRange_Scroll);
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(578, 79);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(21, 23);
            this.txtRange.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "🔍";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search_City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRange);
            this.Controls.Add(this.trkRange);
            this.Controls.Add(this.grdCityForecast);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtSearchCity);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Search_City";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Text = "Search City Forecast";
            this.Load += new System.EventHandler(this.Search_City_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceForecast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCityForecast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceForecast;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSearchCity;
        private System.Windows.Forms.DataGridView grdCityForecast;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTrackBar trkRange;
        private MetroFramework.Controls.MetroTextBox txtRange;
        private System.Windows.Forms.Button button1;
    }
}