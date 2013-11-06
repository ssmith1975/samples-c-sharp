using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceSample
{
    public enum TemperatureCondition
    {
        Rainy,
        Sunny,
        Cloudy,
        Thunderstorm

    }

    public class GetWeatherResponse
    {
        public TemperatureCondition Condition { get; set; }
        public int Temperature { get; set; }
    }
}