using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsClient.WebServicesSample;

namespace WebFormsClient
{
    public partial class WeatherClientSample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnGetWeather(object sender, EventArgs e)
        {
            var req = new GetWeatherRequest();

            if(RadioButtonCelsius.Checked) {
                req.TemperatureType = TemperatureType.Celsius;
            } else {
                req.TemperatureType = TemperatureType.Fahrenheit;

            }
            if( (textCity.Text != null) || (textCity.Text != String.Empty)){
                req.City = textCity.Text;

                var client = new WebServicesSample.SampleServiceSoapClient();
                GetWeatherResponse resp = client.GetWeather(req);

               textWeatherCondition.Text = resp.Condition.ToString();
               textTemperature.Text = resp.Temperature.ToString();
           }

        }
    }
}