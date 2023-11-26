using Microsoft.VisualBasic.Logging;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
using System.Text.Json;

namespace WeatherAPI
{


    public partial class Form1 : Form
    {
        const string APIKey = "a43996562e731571de416260380f9bdf";
        public double Latitude { get; set; }
        public double Longtitude { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox_CityName.Text == null || textBox_CityName.Text == "")
            {
                MessageBox.Show("Enter city name and try once more");
                return;
            }
            try
            {
                GetCityCoordinates(textBox_CityName.Text);
            }
            catch (Exception ex)
            {
                textBox_Weather.Text = ex.Message;
                return;
            }

            GetWeatherDetails();
        }

        public string LinkCoord(double lat, double lon)
        {
            return "https://api.openweathermap.org/data/2.5/weather?lat=" + lat + "&lon=" + lon + "&appid=" + APIKey + "&units=metric";
        }
        public string LinkCity(string cityName)
        {

            return "http://api.openweathermap.org/geo/1.0/direct?q=" + cityName + "&appid=" + APIKey;
        }

        public string TextRespose(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string data = reader.ReadToEnd();
            response.Close();
            return data;
        }

        public void GetCityCoordinates(string _cityName)
        {
            string data = TextRespose(LinkCity(_cityName));

            List<GetCityCoordinates> coord = JsonSerializer.Deserialize<List<GetCityCoordinates>>(data);
            if (coord.Count < 1)
            {
                throw new Exception("Can't find this city");
            }

            Latitude = coord[0].lat;
            Longtitude = coord[0].lon;
        }

        public void GetWeatherDetails()
        {

            try
            {
                string data = TextRespose(LinkCoord(Latitude, Longtitude));
                GetWeather weatherForecast = JsonSerializer.Deserialize<GetWeather>(data);
                OutputWeaherDetails(weatherForecast);
            }
            catch (Exception ex)
            {
                textBox_Weather.Text = "Can't find this city";
                return;
            }
        }

        public void OutputWeaherDetails(GetWeather forecast)
        {
            textBox_Weather.Text = "Country: " + forecast.sys.country + "\r\n" +
            "City: " + forecast.name + "\r\n" +
            "Weather: " + forecast.weather[0].main + "\r\n" +
            "Average Temp,把: " + forecast.main.temp + "\r\n" +
            "Max Temp,把: " + forecast.main.temp_max + "\r\n" +
            "Min Temp,把: " + forecast.main.temp_min + "\r\n" +
            "Temp feel,把: " + forecast.main.feels_like + "\r\n" +
            "Wind speed, metr/sec: " + forecast.wind.speed;
        }

        private void textBox_lat_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox_lat.Text == null || textBox_lat.Text == "")
            {
                return;
            }
            if (!double.TryParse(textBox_lat.Text, out double result))
            {
                MessageBox.Show("Enter lat as double");
                e.Cancel = true;
            }
        }

        private void textBox_lon_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox_lon.Text == null || textBox_lon.Text == "")
            {
                return;
            }
            if (!double.TryParse(textBox_lon.Text, out double result))
            {
                MessageBox.Show("Enter lon as double");
                e.Cancel = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox_lat.Text == null || textBox_lat.Text == "" ||
                textBox_lon.Text == null || textBox_lon.Text == "")
            {
                MessageBox.Show("Enter latitude and longtitude and try once more");
                return;
            }
            Latitude = double.Parse(textBox_lat.Text);
            Longtitude = double.Parse(textBox_lon.Text);
            GetWeatherDetails();
        }
    }


    public class GetCityCoordinates
    {
        public double lat { get; set; }
        public double lon { get; set; }

    }
    public class GetWeather
    {
        public List<Weatherdetails> weather { get; set; }
        public MainDetails main { get; set; }
        public WindDetails wind { get; set; }

        public string name { get; set; }
        public SysDetails sys { get; set; }

    }


    public class Weatherdetails
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }

        public string icon { get; set; }

    }
    public class MainDetails
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
    }

    public class WindDetails
    {
        public double speed { get; set; }
    }

    public class SysDetails
    {
        public string country { get; set; }
    }


}
