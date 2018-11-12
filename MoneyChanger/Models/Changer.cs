using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoneyChanger.Models
{
    public static class Changer
    {
        public static List<Change> MakeChange(decimal moneyIn) {
            return new List<Change>();
        }
    }

    public struct MoneyType
    {
        public static decimal halfDollar = .5M;
        public static decimal quarter = .25M;
        public static decimal dime = .1M;
        public static decimal nickel = .05M;
        public static decimal penny = .01M;
    }

    public class Change
    {
        public int quantity { get; set; }
        public decimal amount { get; set; }
    }
}