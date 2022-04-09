namespace SilverProg.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Service
    {
        public string TextDiscount
        {
            get
            {
                if (Discount == 0)
                {
                    return null;
                }

                else
                {
                    return "Скидка: " + (Discount * 100).ToString() + "%";
                }
            }
        }
        public string TextCost
        {
            get
            {
                if (TextDiscount == null)
                {
                    return " рублей";
                }
                else
                {
                    var f = (float)Cost * (1 - Discount);
                    return " Новая стоимость: " + Math.Round((decimal)f, 2).ToString() + " рублей";
                }

            }
        }

        public double DurationlnMin
        {
            get
            {
                return Math.Round((double)DurationInSeconds / 60);
            }
        }
        public string ColorService
        {
            get
            {
                if (TextDiscount == null)
                {
                    return "White";
                }
                else
                {
                    return "#FFE5FABF";
                }
            }

        }
        public string oldCostStyle
        {
            get
            {
                if (TextDiscount == null)
                {
                    return "";
                }
                else
                {
                    return "Strikethrough";
                }
            }
        }
    }
}
