using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperWeb.Models;

public class FutureValue
{
    [Display (Name ="Monthly Investment")]
    public decimal MonthlyInvestment { get; set; }
    [Display (Name ="Yearly Interest Rate")]
    public decimal YearlyInterestRate { get; set; }
    [Display (Name ="Number of years")]
    public int Years { get; set; }

    public decimal CalculateFutureValue()
    {
        int months = Years * 12;
        decimal monthlyInterestRate =
        YearlyInterestRate / 12 / 100;
        decimal futureValue = 0;
        for (int i = 0; i < months; i++)
        {
            futureValue = (futureValue + MonthlyInvestment)
            * (1 + monthlyInterestRate);
        }
        return futureValue;
    }

}
