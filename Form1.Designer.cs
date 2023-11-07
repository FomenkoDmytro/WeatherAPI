namespace WeatherAPI
{
    partial class Form1
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
            textBox_Weather = new TextBox();
            buttom_GetWeatherWithCityName = new Button();
            textBox_CityName = new TextBox();
            label_CityName = new Label();
            buttom_GetWeatherWithCityCoord = new Button();
            textBox_lat = new TextBox();
            textBox_lon = new TextBox();
            label_lat = new Label();
            label_lon = new Label();
            SuspendLayout();
            // 
            // textBox_Weather
            // 
            textBox_Weather.Location = new Point(23, 196);
            textBox_Weather.Multiline = true;
            textBox_Weather.Name = "textBox_Weather";
            textBox_Weather.Size = new Size(746, 168);
            textBox_Weather.TabIndex = 2;
            // 
            // buttom_GetWeatherWithCityName
            // 
            buttom_GetWeatherWithCityName.Location = new Point(27, 109);
            buttom_GetWeatherWithCityName.Name = "buttom_GetWeatherWithCityName";
            buttom_GetWeatherWithCityName.Size = new Size(198, 56);
            buttom_GetWeatherWithCityName.TabIndex = 3;
            buttom_GetWeatherWithCityName.Text = "Get Weather using city name";
            buttom_GetWeatherWithCityName.UseVisualStyleBackColor = true;
            buttom_GetWeatherWithCityName.Click += button1_Click;
            // 
            // textBox_CityName
            // 
            textBox_CityName.Location = new Point(27, 42);
            textBox_CityName.Multiline = true;
            textBox_CityName.Name = "textBox_CityName";
            textBox_CityName.Size = new Size(198, 26);
            textBox_CityName.TabIndex = 4;
            // 
            // label_CityName
            // 
            label_CityName.AutoSize = true;
            label_CityName.Location = new Point(23, 9);
            label_CityName.Name = "label_CityName";
            label_CityName.Size = new Size(111, 20);
            label_CityName.TabIndex = 5;
            label_CityName.Text = "Enter city name";
            // 
            // buttom_GetWeatherWithCityCoord
            // 
            buttom_GetWeatherWithCityCoord.Location = new Point(554, 109);
            buttom_GetWeatherWithCityCoord.Name = "buttom_GetWeatherWithCityCoord";
            buttom_GetWeatherWithCityCoord.Size = new Size(185, 56);
            buttom_GetWeatherWithCityCoord.TabIndex = 6;
            buttom_GetWeatherWithCityCoord.Text = "Get Weather using coordinates";
            buttom_GetWeatherWithCityCoord.UseVisualStyleBackColor = true;
            buttom_GetWeatherWithCityCoord.Click += button1_Click_1;
            // 
            // textBox_lat
            // 
            textBox_lat.Location = new Point(520, 42);
            textBox_lat.Multiline = true;
            textBox_lat.Name = "textBox_lat";
            textBox_lat.Size = new Size(111, 26);
            textBox_lat.TabIndex = 7;
            textBox_lat.Validating += textBox_lat_Validating;
            // 
            // textBox_lon
            // 
            textBox_lon.Location = new Point(683, 42);
            textBox_lon.Multiline = true;
            textBox_lon.Name = "textBox_lon";
            textBox_lon.Size = new Size(111, 26);
            textBox_lon.TabIndex = 8;
            textBox_lon.Validating += textBox_lon_Validating;
            // 
            // label_lat
            // 
            label_lat.AutoSize = true;
            label_lat.Location = new Point(520, 9);
            label_lat.Name = "label_lat";
            label_lat.Size = new Size(98, 20);
            label_lat.TabIndex = 9;
            label_lat.Text = "Enter latitude";
            // 
            // label_lon
            // 
            label_lon.AutoSize = true;
            label_lon.Location = new Point(683, 9);
            label_lon.Name = "label_lon";
            label_lon.Size = new Size(116, 20);
            label_lon.TabIndex = 10;
            label_lon.Text = "Enter longtitude";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_lon);
            Controls.Add(label_lat);
            Controls.Add(textBox_lon);
            Controls.Add(textBox_lat);
            Controls.Add(buttom_GetWeatherWithCityCoord);
            Controls.Add(label_CityName);
            Controls.Add(textBox_CityName);
            Controls.Add(buttom_GetWeatherWithCityName);
            Controls.Add(textBox_Weather);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_Weather;
        private Button buttom_GetWeatherWithCityName;
        private TextBox textBox_CityName;
        private Label label_CityName;
        private Button buttom_GetWeatherWithCityCoord;
        private TextBox textBox_lat;
        private TextBox textBox_lon;
        private Label label_lat;
        private Label label_lon;
    }
}