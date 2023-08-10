using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Security.Policy;
using static System.DateTime;

namespace CourseWork.Enviroment
{
    public class Table
    {
        public Table(ushort tableNumber, ushort maxCapacity, string imagSources)
        {
            try
            {
                if (imagSources != "")
                    imag = Image.FromFile(Environment.CurrentDirectory + "\\Resource\\" + imagSources);
            }
            catch
            {
            }

            ImagSources = imagSources;
            MaxCapacity = maxCapacity;
            Number = tableNumber;
            var nextMonth = Now;
            nextMonth = nextMonth.AddMonths(1);
            FreeTimes.Add(Tuple.Create<DateTime, DateTime>(Now, nextMonth));
        }

        public bool TryAddRezerv(TableReserveRequest reserveRequest)
        {
            if (reserveRequest.TimeInterval.Item1 < Now)
                reserveRequest.TimeInterval = Tuple.Create(Now, reserveRequest.TimeInterval.Item2);
            if (reserveRequest.TimeInterval.Item2 <= reserveRequest.TimeInterval.Item1) return false;
            foreach (var freeTime in FreeTimes)
                if (reserveRequest.TimeInterval.Item1.AddMinutes(2) >= freeTime.Item1 &&
                    reserveRequest.TimeInterval.Item2 <= freeTime.Item2.AddMinutes(2) &&
                    reserveRequest.TimeInterval.Item2 > Now)
                {
                    if (freeTime.Item1 < reserveRequest.TimeInterval.Item1.AddMinutes(2))
                        FreeTimes.Add(Tuple.Create<DateTime, DateTime>(freeTime.Item1,
                            reserveRequest.TimeInterval.Item1));
                    if (freeTime.Item2 > reserveRequest.TimeInterval.Item2)
                        FreeTimes.Add(Tuple.Create<DateTime, DateTime>(reserveRequest.TimeInterval.Item2,
                            freeTime.Item2));
                    FreeTimes.Remove(freeTime);
                    FreeTimes.Sort();
                    RezervedTimes.Add(reserveRequest);
                    RezervedTimes.Sort();
                    return true;
                }

            return false;
        }

        //12 AM - 2 AM = 12 + 2 H = 14 H = 840 M 

        public List<Tuple<int, int, bool, string>> GetTimeForTheDay(DateTime Date)
        {
            var answer = new List<Tuple<int, int, bool, string>>();
            var lowerBound = new DateTime(Date.Year, Date.Month, Date.Day, 12, 0, 0);

            var upperBound = lowerBound.AddDays(1).Subtract(TimeSpan.Parse("10:00:00"));
            foreach (var someRange in RezervedTimes)
                if (upperBound >= someRange.TimeInterval.Item2 && lowerBound <= someRange.TimeInterval.Item1)
                    answer.Add(Tuple.Create<int, int, bool, string>(
                        (int) someRange.TimeInterval.Item1.Subtract(lowerBound).TotalMinutes,
                        (int) someRange.TimeInterval.Item2.Subtract(lowerBound).TotalMinutes, someRange.Status,
                        someRange.UsernameOwner));
                else if (upperBound >= someRange.TimeInterval.Item2 && lowerBound > someRange.TimeInterval.Item1 &&
                         someRange.TimeInterval.Item2 > lowerBound)
                    answer.Add(Tuple.Create<int, int, bool, string>(0,
                        (int) someRange.TimeInterval.Item2.Subtract(lowerBound).TotalMinutes, someRange.Status,
                        someRange.UsernameOwner));
                else if (lowerBound <= someRange.TimeInterval.Item1 && upperBound < someRange.TimeInterval.Item2 &&
                         upperBound > someRange.TimeInterval.Item1)
                    answer.Add(Tuple.Create<int, int, bool, string>(
                        (int) someRange.TimeInterval.Item1.Subtract(lowerBound).TotalMinutes, 840, someRange.Status,
                        someRange.UsernameOwner));
                else if (lowerBound > someRange.TimeInterval.Item1 && upperBound < someRange.TimeInterval.Item2)
                    answer.Add(Tuple.Create<int, int, bool, string>(0, 840, someRange.Status, someRange.UsernameOwner));
            if (answer.Count != 0 && answer[0].Item1 <= (int) Now.Subtract(lowerBound).TotalMinutes)
                answer.Add(Tuple.Create<int, int, bool, string>(0, answer[0].Item1, true, "Admin"));
            else if (answer.Count == 0 || answer[0].Item1 > (int) Now.Subtract(lowerBound).TotalMinutes)
                if ((int) Now.Subtract(lowerBound).TotalMinutes > 0)

                    answer.Add(Tuple.Create<int, int, bool, string>(0, (int) Now.Subtract(lowerBound).TotalMinutes,
                        true, "Admin"));
            return answer;
        }


        public List<Tuple<DateTime, DateTime>> GetFreeTimes()
        {
            return FreeTimes;
        }

        public ushort Number { get; }
        public string ImagSources { get; }
        public ushort MaxCapacity { get; }
        internal Image imag = new Bitmap(1, 1);
        private List<TableReserveRequest> RezervedTimes = new List<TableReserveRequest>();
        private List<Tuple<DateTime, DateTime>> FreeTimes = new List<Tuple<DateTime, DateTime>>();
    }
}