using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args, string netMask)
        {
            string subNetMask = string.Empty;
            int calSubnet = 0;
            double result = 0;
            if (!string.IsNullOrEmpty(netMask))
            {
                calSubnet = 32 - Convert.ToInt32(netMask);
                if (calSubnet >= 0 && calSubnet <= 8)
                {
                    for (int ipower = 0; ipower < calSubnet; ipower++)
                    {
                        result += Math.Pow(2, ipower);
                    }
                    double finalSubnet = 225 - result;
                    subNetMask = "255.255.255." + Convert.ToString(finalSubnet);
                }
                else if (calSubnet > 8 && calSubnet <= 16)
                {
                    int secOctet = 16 - calSubnet;
                    secOctet = 8 - secOctet;
                    for (int ipower = 0; ipower < secOctet; ipower++)
                    {
                        result += Math.Pow(2, ipower);
                    }
                    double finalSubnet = 255 - result;
                    subNetMask = " 255.255." + Convert.ToString(finalSubnet) + ".0";
                }
                else if (calSubnet > 16 && calSubnet <= 24)
                {
                    int thirdOctet = 24 - calSubnet;

                    thirdOctet = 8 - thirdOctet;

                    for (int ipower = 0; ipower < thirdOctet; ipower++)
                    {
                        result += Math.Pow(2, ipower);
                    }
                    double finalSubnet = 255 - result;
                    subNetMask = "255." + Convert.ToString(finalSubnet) + ".0.0";
                }
                else if (calSubnet > 24 && calSubnet <= 32)
                {
                    int fourthOctet = 32 - calSubnet;

                    fourthOctet = 8 - fourthOctet;

                    for (int ipower = 0; ipower < fourthOctet; ipower++)
                    {
                        result += Math.Pow(2, ipower);
                    }
                    double finalSubnet = 255 - result;
                    subNetMask = Convert.ToString(finalSubnet) + ".0.0.0";
                }

            }
            Console.WriteLine(subNetMask);
            Console.ReadLine();
        }
    }
}