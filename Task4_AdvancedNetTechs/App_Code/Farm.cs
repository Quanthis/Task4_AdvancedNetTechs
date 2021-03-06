﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Farm
{
    public const decimal cost = 0.9M;
    public const int limit = 500;
    public const decimal incrementPerMinute = 0.5M;

    private DateTime lastActionDate;
    private decimal money;
    private int actualProduction;

    private SQLHandler sqlHandler;


    public Farm(DateTime lastActionDate, decimal money, int actualProduction, SQLHandler sqlHandler)
    {
        this.lastActionDate = lastActionDate;
        this.money = money;
        this.actualProduction = actualProduction;
        this.sqlHandler = sqlHandler;
    }

    public string Sow(int howMany)
    {
        if((howMany + actualProduction) > limit)
        {
            actualProduction += howMany;
            decimal totalCost = cost * howMany;
            money -= totalCost;
            sqlHandler.Update_DB(howMany);

            return $"You have sown {howMany} fields. Cost of action: {totalCost}. You now have {money} money.";
        }
        else
        {
            int possibleToSow = limit - actualProduction;
            decimal totalCost = possibleToSow * cost;
            money -= totalCost;
            sqlHandler.Update_DB(howMany);

            return $"You tried to exceed maximum limit. Amount that was sown: {possibleToSow}. Actual cost: {totalCost}. Your money after action: {money}.";
        }
    }

    public decimal Collect()
    {
        DateTime now = DateTime.Now;
        TimeSpan timeSpan = now.Subtract(lastActionDate);
        int intSpan = (int)timeSpan.TotalMinutes;

        decimal totalGrown = intSpan * incrementPerMinute;

        if(totalGrown > limit)
        {
            sqlHandler.Update_DB((int)limit);
            return limit;
        }
        else
        {
            sqlHandler.Update_DB((int)totalGrown);
            return totalGrown;
        }
    }

    public int GetActualProduction()
    {
        return actualProduction;
    }

    public decimal GetMoney()
    {
        return money;
    }

    public DateTime GetLastActionDate()
    {
        return lastActionDate;
    }
}