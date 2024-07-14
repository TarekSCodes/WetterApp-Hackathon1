namespace WetterApp
{
    partial class WeatherUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherUI));
            picBoxWeather = new PictureBox();
            txtBoxCity = new TextBox();
            lblTemperature = new Label();
            lblWeatherTxt = new Label();
            btnCityGo = new Button();
            lblCity = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxWeather).BeginInit();
            SuspendLayout();
            // 
            // picBoxWeather
            // 
            picBoxWeather.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picBoxWeather.BackgroundImageLayout = ImageLayout.Zoom;
            picBoxWeather.Location = new Point(12, 54);
            picBoxWeather.Name = "picBoxWeather";
            picBoxWeather.Padding = new Padding(0, 30, 0, 0);
            picBoxWeather.Size = new Size(472, 312);
            picBoxWeather.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxWeather.TabIndex = 0;
            picBoxWeather.TabStop = false;
            // 
            // txtBoxCity
            // 
            txtBoxCity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxCity.BackColor = Color.White;
            txtBoxCity.Font = new Font("Segoe UI", 16F);
            txtBoxCity.Location = new Point(12, 12);
            txtBoxCity.Name = "txtBoxCity";
            txtBoxCity.Size = new Size(413, 36);
            txtBoxCity.TabIndex = 1;
            txtBoxCity.TextAlign = HorizontalAlignment.Center;
            txtBoxCity.KeyDown += txtBoxCity_KeyDown;
            // 
            // lblTemperature
            // 
            lblTemperature.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTemperature.Font = new Font("Segoe UI", 20F);
            lblTemperature.Location = new Point(12, 452);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(475, 39);
            lblTemperature.TabIndex = 4;
            lblTemperature.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWeatherTxt
            // 
            lblWeatherTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWeatherTxt.Font = new Font("Segoe UI", 20F);
            lblWeatherTxt.Location = new Point(12, 413);
            lblWeatherTxt.Name = "lblWeatherTxt";
            lblWeatherTxt.Size = new Size(475, 39);
            lblWeatherTxt.TabIndex = 3;
            lblWeatherTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCityGo
            // 
            btnCityGo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCityGo.BackgroundImage = (Image)resources.GetObject("btnCityGo.BackgroundImage");
            btnCityGo.BackgroundImageLayout = ImageLayout.Center;
            btnCityGo.Cursor = Cursors.Hand;
            btnCityGo.Location = new Point(431, 12);
            btnCityGo.Name = "btnCityGo";
            btnCityGo.Size = new Size(53, 36);
            btnCityGo.TabIndex = 2;
            btnCityGo.UseVisualStyleBackColor = true;
            btnCityGo.Click += btnCityGo_Click;
            // 
            // lblCity
            // 
            lblCity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCity.Font = new Font("Segoe UI", 20F);
            lblCity.Location = new Point(12, 369);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(472, 39);
            lblCity.TabIndex = 5;
            lblCity.Text = "Bitte gib einen Ort ein";
            lblCity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WeatherUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(496, 527);
            Controls.Add(lblCity);
            Controls.Add(btnCityGo);
            Controls.Add(lblWeatherTxt);
            Controls.Add(lblTemperature);
            Controls.Add(txtBoxCity);
            Controls.Add(picBoxWeather);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "WeatherUI";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WeatherApp";
            ((System.ComponentModel.ISupportInitialize)picBoxWeather).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxWeather;
        private TextBox txtBoxCity;
        private Label lblTemperature;
        private Label lblWeatherTxt;
        private Button btnCityGo;
        private Label lblCity;
    }
}
