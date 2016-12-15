using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Web; 
namespace M50TollCharges.Models
{
    public class M50TollModel
    {
        const double electronicDiscount = 0.2;

        //Dropdown list for eTag
        public static String[] electronicTag
        {
            get
            {
                return new String[] {  "Not Present", "Present" };
            }
        }
        [Required(ErrorMessage = "Required field!")]
        public String eTag { get; set; }

        //Dropdown list for vehicles
        public static String[] vehicleType
        {
            get
            {
                return new String[] { "Car", "Public Service Vehicle", "Bus", "Goods" };
            }
        }
        [Required(ErrorMessage = "Required field!")]
        public String vType { get; set; }

        //Calculating logic - handles eTags
        [DisplayName("Toll Charge")]
        public double calculateToll
        {
            get
            {
                if(vType == "Car")
                {
                    double tollRate = Double.Parse(ConfigurationManager.AppSettings["Car"]);
                    if (eTag == "Present")
                    {
                        return tollRate-(tollRate * electronicDiscount);
                    }
                    else
                    {
                        return tollRate;
                    }
                }
                else if (vType == "Public Service Vehicle")
                {
                    double tollRate = Double.Parse(ConfigurationManager.AppSettings["Public Service Vehicle"]);
                    if (eTag == "Present")
                    {
                        return tollRate - (tollRate * electronicDiscount);
                    }
                    else
                    {
                        return tollRate;
                    }
                }
                else if (vType == "Bus")
                {
                    double tollRate = Double.Parse(ConfigurationManager.AppSettings["Bus"]);
                    if (eTag == "Present")
                    {
                        return tollRate - (tollRate * electronicDiscount);
                    }
                    else
                    {
                        return tollRate;
                    }
                }
                else if (vType == "Goods")
                {
                    double tollRate = Double.Parse(ConfigurationManager.AppSettings["Goods"]);
                    if (eTag == "Present")
                    {
                        return tollRate - (tollRate * electronicDiscount);
                    }
                    else
                    {
                        return tollRate;
                    }
                }else
                {
                    //only to return something if all else fails
                    return 0;
                }
            }
        }
    }
}