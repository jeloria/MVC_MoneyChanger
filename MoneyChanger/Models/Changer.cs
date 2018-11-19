using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoneyChanger.Models
{
    public static class Changer
    {
        public static List<Change> MakeChange(decimal moneyIn) {
            List<Change> changeList = new List<Change>();
            var remainder = moneyIn;

            while (remainder > 0)
            {
                // check divisibility 
                if(remainder / MoneyType.halfDollar >= 1)
                {
                    var calc = remainder / MoneyType.halfDollar;

                    // create new change object based on calculation
                    var change = new Change();
                    change.amount = MoneyType.halfDollar;
                    change.quantity = Convert.ToInt32(Math.Floor(calc));

                    // add change value for return
                    changeList.Add(change);

                    // adjust remainder
                    remainder -= change.quantity * MoneyType.halfDollar;
                } else if (remainder / MoneyType.quarter >= 1)
                {
                    var calc = remainder / MoneyType.quarter;

                    // create new change object based on calculation
                    var change = new Change();
                    change.amount = MoneyType.quarter;
                    change.quantity = Convert.ToInt32(Math.Floor(calc));

                    // add change value for return
                    changeList.Add(change);

                    // adjust remainder
                    remainder -= change.quantity * MoneyType.quarter;
                } else if (remainder / MoneyType.dime >= 1)
                {
                    var calc = remainder / MoneyType.dime;

                    // create new change object based on calculation
                    var change = new Change();
                    change.amount = MoneyType.dime;
                    change.quantity = Convert.ToInt32(Math.Floor(calc));

                    // add change value for return
                    changeList.Add(change);

                    // adjust remainder
                    remainder -= change.quantity * MoneyType.dime;
                } else if (remainder / MoneyType.nickel >= 1)
                {
                    var calc = remainder / MoneyType.nickel;

                    // create new change object based on calculation
                    var change = new Change();
                    change.amount = MoneyType.nickel;
                    change.quantity = Convert.ToInt32(Math.Floor(calc));

                    // add change value for return
                    changeList.Add(change);

                    // adjust remainder
                    remainder -= change.quantity * MoneyType.nickel;
                } else if (remainder / MoneyType.penny >= 1)
                {
                    var calc = remainder / MoneyType.penny;

                    // create new change object based on calculation
                    var change = new Change();
                    change.amount = MoneyType.penny;
                    change.quantity = Convert.ToInt32(Math.Floor(calc));

                    // add change value for return
                    changeList.Add(change);

                    // adjust remainder
                    remainder -= change.quantity * MoneyType.penny;
                }
            }
            return changeList;
        }

        public static string GetName(decimal moneyAmount)
        {
            switch (moneyAmount)
            {
                case MoneyType.halfDollar:
                    return "Half Dollar";
                case MoneyType.quarter:
                    return "Quarter";
                case MoneyType.dime:
                    return "Dime";
                case MoneyType.nickel:
                    return "Nickel";
                case MoneyType.penny:
                    return "Penny";
                default:
                    return "";
            }
        }
    }

    public struct MoneyType
    {
        public const decimal halfDollar = .5M;
        public const decimal quarter = .25M;
        public const decimal dime = .1M;
        public const decimal nickel = .05M;
        public const decimal penny = .01M;
    }

    public class Change
    {
        public int quantity { get; set; }
        public decimal amount { get; set; }
    }
}