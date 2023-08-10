
using System.Collections.Generic;
using CourseWork.Entities;

namespace CourseWork.Interfaces.Models
{
    public interface Routing
    {
        void init();

        Switch getSwitch(int index);
        Router getRouter(int index);
        void setSwitch(int index, Switch @switch);
        List<RoutingTable> getRoutingTables(int index);
        void addRecord(int index, RoutingTable record);
    }
}