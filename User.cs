using System.Collections.Generic;
using System.Diagnostics;
using CourseWork.Enviroment;

namespace CourseWork
{
    public class User
    {
        public User(string username, string password, List<TableReserveRequest> reserveRequests, string phoneNumber,
            string realName, string email)
        {
            PhoneNumber = phoneNumber;
            RealName = realName;
            Email = email;
            Username = username;
            Password = password;
            ReserveRequests = reserveRequests;
            if (Username == "Admin") //если имя пользователя, то
                AdminPassword = Password; //устанавливаем для всех пользователей текущий пароль администратора
        }

        private string PhoneNumber = "<None>";
        private string RealName = "<None>";
        private string Email = "<None>";
        private string Username = "<None>", Password = "<None>";
        private List<TableReserveRequest> ReserveRequests = new List<TableReserveRequest>();

        private static string
            AdminPassword =
                "<None>"; //пароль админа который обновиться для всех пользователей при изменении в этом пользователе

        public int NotEqualRequests(List<TableReserveRequest> other)
        {
            if (ReserveRequests.Count != other.Count) return -1;
            for (var i = 0; i < ReserveRequests.Count; i++)
                if (!ReserveRequests[i].Equal(other[i]))
                    return i;

            return other.Count;
        }

        public bool IsThisUsername(string meybeUsername)
        {
            return Username == meybeUsername;
        }

        public bool IsThisPassword(string meybePassword)
        {
            return Password == meybePassword;
        }

        public List<TableReserveRequest> GetReqests()
        {
            return ReserveRequests; //получаем список запросов на резервирование столиков
        }

        public string getPhoneNumber(string maybePassword)
        {
            if (maybePassword == Password || maybePassword == AdminPassword)
                return PhoneNumber;
            return "";
        }

        public string getEmail(string maybePassword)
        {
            if (maybePassword == Password || maybePassword == AdminPassword)
                return Email;
            return "";
        }

        public string getRealName(string maybePassword)
        {
            if (maybePassword == Password || maybePassword == AdminPassword)
                return RealName;
            return "";
        }
    }
}