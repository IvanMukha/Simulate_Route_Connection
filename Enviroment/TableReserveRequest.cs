using System;

namespace CourseWork.Enviroment
{
    public class TableReserveRequest : IComparable<TableReserveRequest>
    {
        public TableReserveRequest(ushort TableNumber, ushort countPeople, DateTime From, DateTime Until,
            string usernameOwner, bool status)
        {
            UsernameOwner = usernameOwner;
            Status = status;
            ReservedTableNumber = TableNumber;
            CountPeople = countPeople;
            TimeInterval = Tuple.Create<DateTime, DateTime>(From, Until);
        }

        public int CompareTo(TableReserveRequest other)
        {
            if (Status == other.Status)
                return DateTime.Compare(TimeInterval.Item1, other.TimeInterval.Item1);
            else if (Status) return -1;
            else return 1;
        }

        public bool Equal(TableReserveRequest other)
        {
            return Status == other.Status &&
                   ContactPhone == other.ContactPhone &&
                   CountPeople == other.CountPeople &&
                   ReservedTableNumber == other.ReservedTableNumber &&
                   TimeInterval.Item1.CompareTo(other.TimeInterval.Item1.AddMinutes(2)) == -1 &&
                   TimeInterval.Item1.AddMinutes(2).CompareTo(other.TimeInterval.Item1) == 1 &&
                   TimeInterval.Item2.CompareTo(other.TimeInterval.Item2) == 0;
        }

        public string ContactPhone;
        public string UsernameOwner { get; }
        public bool Status;
        public ushort CountPeople;
        public ushort ReservedTableNumber;
        public Tuple<DateTime, DateTime> TimeInterval;
    }
}