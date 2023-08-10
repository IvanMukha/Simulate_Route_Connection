using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using CourseWork.Entities;
using CourseWork.Interfaces.Models;
using CourseWork.Interfaces.Views;

namespace CourseWork.Presenters
{
    public class Presenter
    {
        private readonly RouterSimulator routerSimulator;
        private readonly Routing routing;

        public Presenter(RouterSimulator view, Routing model)
        {
            routerSimulator = view;
            routing = model;

            routerSimulator.createNode += createNode;
            routerSimulator.deleteNode += deleteNode;
            routerSimulator.getSwitchProperties += getSwitchProperties;
            routerSimulator.setSwitchProperties += setSwitchProperties;
            routerSimulator.displaySwitchProperties += displaySwitchProperties;
            routerSimulator.displayRouterProperties += displayRouterProperties;
            routerSimulator.displayRoutingTable += displayTable;
            routerSimulator.getSetRecordTable += setRecordInfo;
            routerSimulator.addRecordTable += addRecordTable;
        }

        public void run()
        {
            routing.init();
            routerSimulator.initToolMenus();
            routerSimulator.show();
        }

        private void createNode()
        {
            if (routerSimulator.displaySwitch())
            {
                routing.setSwitch(routerSimulator.numberOfDevice, new Switch());
            }

            routerSimulator.hideSetProperties();
            routerSimulator.hideSetRecord();
        }

        private void deleteNode()
        {
            if (routerSimulator.hideSwitch())
            {
                routing.setSwitch(routerSimulator.numberOfDevice, new Switch());
            }

            routerSimulator.hideSetProperties();
            routerSimulator.hideSetRecord();
        }

        private void getSwitchProperties()
        {
            routerSimulator.displaySetProperties();
            routerSimulator.hideSetRecord();
        }

        private void setSwitchProperties()
        {
            string[] info = routerSimulator.getMaskAndAddress();
            string[] octets1 = info[0].Split('.');
            string[] octets2 = info[1].Split('.');
            string subnet = "";
            int mask = 0;
            for (int i = 0; i < 4; i++)
            {
                if (octets1[i] != "0")
                {
                    subnet += octets2[i] + ".";
                    mask += 8;
                }
                else
                {
                    subnet += 0 + ".";
                }
            }

            subnet = subnet.Remove(subnet.Length - 1);
            subnet += "/" + mask;

            routing.setSwitch(routerSimulator.numberOfDevice, new Switch
            {
                address = info[0],
                netmask = info[1],
                subnet = subnet
            });
            if (routerSimulator.numberOfDevice < 3)
            {
                routing.addRecord(0, new RoutingTable
                {
                    netmask = info[0],
                    gatewayAddress = "On-link",
                    networkAddress = subnet.Split('/')[0]
                });
                routing.addRecord(1, new RoutingTable
                {
                    netmask = info[0],
                    gatewayAddress = "192.168.1.1",
                    networkAddress = subnet.Split('/')[0]
                });
            }
            else
            {
                routing.addRecord(1, new RoutingTable
                {
                    netmask = info[0],
                    gatewayAddress = "On-link",
                    networkAddress = subnet.Split('/')[0]
                });
                routing.addRecord(0, new RoutingTable
                {
                    netmask = info[0],
                    gatewayAddress = "192.168.1.2",
                    networkAddress = subnet.Split('/')[0]
                });
            }

            routerSimulator.hideSetProperties();
            routerSimulator.hideSetRecord();
        }

        private void setRecordInfo()
        {
            routerSimulator.displaySetRecord();
            routerSimulator.hideSetProperties();
        }

        private void displaySwitchProperties()
        {
            MessageBox.Show("Subnet: " + routing.getSwitch(routerSimulator.numberOfDevice).subnet);
            routerSimulator.hideSetProperties();
            routerSimulator.hideSetRecord();
        }

        private void displayRouterProperties()
        {
            MessageBox.Show("Router address: " + routing.getRouter(routerSimulator.numberOfDevice).address);
            routerSimulator.hideSetProperties();
            routerSimulator.hideSetRecord();
        }

        private void addRecordTable()
        {
            string[] info = routerSimulator.getRecordInfo();
            routing.addRecord(routerSimulator.numberOfDevice, new RoutingTable
            {
                networkAddress = info[0],
                netmask = info[1],
                gatewayAddress = info[2]
            });
            routerSimulator.hideSetProperties();
            routerSimulator.hideSetRecord();
        }

        private void displayTable()
        {
            StringBuilder stringBuilder = new StringBuilder();
            List<RoutingTable> routingTables = routing.getRoutingTables(routerSimulator.numberOfDevice);
            stringBuilder.Append("Network address\tNetmask\t\tGateway\n");
            foreach (var routingTable in routingTables)
            {
                if (routingTable.networkAddress.Length < 10)
                {
                    stringBuilder.Append(routingTable.networkAddress + "\t\t");
                    if (routingTable.netmask.Length < 10)
                    {
                        stringBuilder.Append(routingTable.netmask +
                                             "\t\t" + routingTable.gatewayAddress + "\n");
                    }
                    else
                    {
                        stringBuilder.Append(routingTable.netmask +
                                             "\t" + routingTable.gatewayAddress + "\n");
                    }
                }
                else
                {
                    stringBuilder.Append(routingTable.networkAddress + "\t");
                    if (routingTable.netmask.Length < 10)
                    {
                        stringBuilder.Append(routingTable.netmask +
                                             "\t\t" + routingTable.gatewayAddress + "\n");
                    }
                    else
                    {
                        stringBuilder.Append(routingTable.netmask +
                                             "\t" + routingTable.gatewayAddress + "\n");
                    }
                }
            }

            MessageBox.Show(stringBuilder.ToString());
            routerSimulator.hideSetProperties();
            routerSimulator.hideSetRecord();
        }
    }
}