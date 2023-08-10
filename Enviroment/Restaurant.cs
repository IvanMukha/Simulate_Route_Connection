using System;
using System.Collections.Generic;


namespace CourseWork.Enviroment
{
    public class Restaurant
    {
        public Restaurant(TimeSpan openTime, TimeSpan closeTime, List<Table> tables)
        {
            OpenTime = openTime;
            CloseTime = closeTime;
            if (CloseTime < OpenTime) OpenCloseTime_isDiferentDays = true;
            foreach (var table in tables) AddTable(table);
        }

        public void AddTable(Table newTable)
        {
            var FirstFree = newTable.GetFreeTimes()[0].Item1;
            var LastFree = newTable.GetFreeTimes()[newTable.GetFreeTimes().Count - 1].Item2;
            var FirstReserv = new DateTime(FirstFree.Year, FirstFree.Month, FirstFree.Day, CloseTime.Hours,
                CloseTime.Minutes, 0);
            int added;
            if (OpenCloseTime_isDiferentDays)
                added = (int) OpenTime.Subtract(CloseTime).TotalMinutes;
            else
                added = (int) CloseTime.Subtract(OpenTime).TotalMinutes;
            while (FirstReserv < LastFree)
            {
                newTable.TryAddRezerv(new TableReserveRequest(newTable.Number, newTable.MaxCapacity, FirstReserv,
                    FirstReserv.AddMinutes(added), "Admin", true));
                FirstReserv = FirstReserv.AddDays(1);
            }

            Tables.Add(newTable);
        }

        public bool UpdateTableList;
        public List<Table> Tables = new List<Table>();
        public bool OpenCloseTime_isDiferentDays = true;
        public TimeSpan OpenTime, CloseTime;
    }
}