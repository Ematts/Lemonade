using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonAidStand
{
    class Weather
    {
        double temp;
        double condition;
        string weatherCondition;
        double sunnyAddition = 1.5;
        double cloudyNeutral = 1;
        double rainySubtraction = 0.5;
        Random rndTemp = new Random();
        Random rndCondition = new Random();
    
        public Weather()
        {

            
            

        }

        public string getWeatherCondition()

        {
            condition = rndCondition.Next(1, 10);


            if (condition <= 3)

            {

                weatherCondition = ("Sunny");

            }

            else if (condition <= 6 && condition > 3)

            {

                weatherCondition = ("Cloudy");

            }

            else

            {

                weatherCondition = ("Rainy");

            }

            return weatherCondition;

        }

        public double getTemp()

               {

                temp = rndTemp.Next(60, 100);
                return temp;

               }

       public double getWeatherDemand()

            {



            if (weatherCondition == "Sunny")


            {

                double weatherDemand = sunnyAddition * temp;

                return weatherDemand;

            }


            else if (weatherCondition == "Cloudy")

            {

                double weatherDemand = cloudyNeutral * temp;
                return weatherDemand;


            }

            else

            {
                double weatherDemand = rainySubtraction * temp;
                return weatherDemand;

            }
        }
    }
}

