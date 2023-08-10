using System;

namespace CourseWork.Interfaces.Views
{
    public interface  RouterSimulator
    {
        int numberOfDevice { get; set; }

        void show();
        void initToolMenus();
        bool displaySwitch();
        bool hideSwitch();
        void displaySetProperties();
        void hideSetProperties();
        string[] getMaskAndAddress();
        void displaySetRecord();
        void hideSetRecord();
        string[] getRecordInfo();

        event Action createNode;
        event Action deleteNode;
        event Action getSwitchProperties;
        event Action setSwitchProperties;
        event Action displaySwitchProperties;
        event Action displayRouterProperties;
        event Action displayRoutingTable;
        event Action getSetRecordTable;
        event Action addRecordTable;
    }
}