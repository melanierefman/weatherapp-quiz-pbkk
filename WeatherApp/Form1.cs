using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Net.NetworkInformation;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String APIKey = "9a96b437d661856a8941064a179afb21";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeaterInfo.root Info = JsonConvert.DeserializeObject<WeaterInfo.root>(json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/02n.png";
                labCondition.Text = Info.weather[0].main;
                labDetails.Text = Info.weather[0].description;
                labSunset.Text = Info.sys.sunset.ToString();
                labSunrise.Text = Info.sys.sunrise.ToString();

                labWindSpeed.Text = Info.wind.speed.ToString();
                labPressure.Text = Info.main.pressure.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            using (WebClient web = new WebClient())
            {

            }
        }

    }
}
