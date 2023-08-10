using System.Collections.Generic;

namespace CourseWork.Entities
{
    public class Router
    {
        public List<RoutingTable> routingTable { get; set; } = new List<RoutingTable>();
        public Switch[] switches { get; set; } = new Switch[3];
        public string address { get; set; }
    }
}