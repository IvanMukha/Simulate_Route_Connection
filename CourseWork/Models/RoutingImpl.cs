using System.Collections.Generic;
using CourseWork.DataStorage;
using CourseWork.Entities;
using CourseWork.Interfaces.Models;

namespace CourseWork.Models
{
    public class RoutingImpl : Routing
    {
        private Database database = Database.getInstance();

        public void init()
        {
            database.routers[0] = new Router {address = "192.168.1.1"};
            database.routers[0].routingTable.Add(new RoutingTable {
                networkAddress = "0.0.0.0",
                netmask = "0.0.0.0",
                gatewayAddress = "192.168.1.2"
            });
            database.routers[1] = new Router {address = "192.168.1.2"};
            database.routers[1].routingTable.Add(new RoutingTable {
                networkAddress = "0.0.0.0",
                netmask = "0.0.0.0",
                gatewayAddress = "192.168.1.1"
            });
        }

        public Switch getSwitch(int index)
        {
            return index < 3 ? database.routers[0].switches[index] : database.routers[1].switches[index - 3];
        }

        public Router getRouter(int index)
        {
            return database.routers[index];
        }

        public void setSwitch(int index, Switch @switch)
        {
            if (index < 3)
            {
                database.routers[0].switches[index] = @switch;
            }
            else
            {
                database.routers[1].switches[index - 3] = @switch;
            }
        }

        public List<RoutingTable> getRoutingTables(int index)
        {
            return database.routers[index].routingTable;
        }

        public void addRecord(int index, RoutingTable record)
        {
            database.routers[index].routingTable.Add(record);
        }
    }
}