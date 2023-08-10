using System;
using System.Windows.Forms;
using CourseWork.Interfaces.Views;

namespace CourseWork.Views
{
    public partial class RouterSimulatorImpl : Form, RouterSimulator
    {
        public event Action createNode;
        public event Action deleteNode;
        public event Action getSwitchProperties;
        public event Action setSwitchProperties;
        public event Action displaySwitchProperties;
        public event Action displayRouterProperties;
        public event Action displayRoutingTable;
        public event Action getSetRecordTable;
        public event Action addRecordTable;
        

        public int numberOfDevice { get; set; }

        public RouterSimulatorImpl()
        {
            InitializeComponent();
        }

        public void show()
        {
            Application.Run(this);
        }

        public void initToolMenus()
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem addNodeTsm = new ToolStripMenuItem("Create node");
            ToolStripMenuItem deleteNodeTsm = new ToolStripMenuItem("Delete node");
            ToolStripMenuItem propertiesTsm = new ToolStripMenuItem("Display properties");
            ToolStripMenuItem routingTableTsm = new ToolStripMenuItem("Routing table");
            ToolStripMenuItem addSubmenu;
            ToolStripMenuItem deleteSubmenu;
            ToolStripMenuItem routingSubmenu;
            contextMenuStrip.Items.Add(addNodeTsm);
            contextMenuStrip.Items.Add(deleteNodeTsm);
            contextMenuStrip.Items.Add(propertiesTsm);
            contextMenuStrip.Items.Add(routingTableTsm);
            routingSubmenu = new ToolStripMenuItem("Display");
            routingSubmenu.Click += (sender, args) =>
            {
                numberOfDevice = 0;
                displayRoutingTable?.Invoke();
            };
            routingTableTsm.DropDownItems.Add(routingSubmenu);
            routingSubmenu = new ToolStripMenuItem("Add record");
            routingSubmenu.Click += (sender, args) =>
            {
                numberOfDevice = 0;
                getSetRecordTable?.Invoke();
            };
            routingTableTsm.DropDownItems.Add(routingSubmenu);
            propertiesTsm.Click += (sender, args) =>
            {
                numberOfDevice = 0;
                displayRouterProperties?.Invoke();
            };
            firstRouter.ContextMenuStrip = contextMenuStrip;
            for (int i = 0; i < 3; i++)
            {
                addSubmenu = new ToolStripMenuItem("Port " + (i + 1));
                deleteSubmenu = new ToolStripMenuItem("Port " + (i + 1));
                var index = i;
                addSubmenu.Click += (sender, args) =>
                {
                    numberOfDevice = index;
                    createNode?.Invoke();
                };
                deleteSubmenu.Click += (sender, args) =>
                {
                    numberOfDevice = index;
                    deleteNode?.Invoke();
                };
                addNodeTsm.DropDownItems.Add(addSubmenu);
                deleteNodeTsm.DropDownItems.Add(deleteSubmenu);
            }

            contextMenuStrip = new ContextMenuStrip();
            addNodeTsm = new ToolStripMenuItem("Create node");
            deleteNodeTsm = new ToolStripMenuItem("Delete node");
            propertiesTsm = new ToolStripMenuItem("Display properties");
            routingTableTsm = new ToolStripMenuItem("Routing table");
            contextMenuStrip.Items.Add(addNodeTsm);
            contextMenuStrip.Items.Add(deleteNodeTsm);
            contextMenuStrip.Items.Add(propertiesTsm);
            contextMenuStrip.Items.Add(routingTableTsm);
            routingSubmenu = new ToolStripMenuItem("Display");
            routingSubmenu.Click += (sender, args) =>
            {
                numberOfDevice = 1;
                displayRoutingTable?.Invoke();
            };
            routingTableTsm.DropDownItems.Add(routingSubmenu);
            routingSubmenu = new ToolStripMenuItem("Add record");
            routingSubmenu.Click += (sender, args) =>
            {
                numberOfDevice = 1;
                getSetRecordTable?.Invoke();
            };
            routingTableTsm.DropDownItems.Add(routingSubmenu);
            propertiesTsm.Click += (sender, args) =>
            {
                numberOfDevice = 1;
                displayRouterProperties?.Invoke();
            };
            secondRouter.ContextMenuStrip = contextMenuStrip;
            for (int i = 0; i < 3; i++)
            {
                addSubmenu = new ToolStripMenuItem("Port " + (i + 2));
                deleteSubmenu = new ToolStripMenuItem("Port " + (i + 2));
                var index = i + 3;
                addSubmenu.Click += (sender, args) =>
                {
                    numberOfDevice = index;
                    createNode?.Invoke();
                };
                deleteSubmenu.Click += (sender, args) =>
                {
                    numberOfDevice = index;
                    deleteNode?.Invoke();
                };
                addNodeTsm.DropDownItems.Add(addSubmenu);
                deleteNodeTsm.DropDownItems.Add(deleteSubmenu);
            }

            for (int i = 0; i < 6; i++)
            {
                contextMenuStrip = new ContextMenuStrip();
                addNodeTsm = new ToolStripMenuItem("Set properties");
                deleteNodeTsm = new ToolStripMenuItem("Display properties");
                contextMenuStrip.Items.Add(addNodeTsm);
                contextMenuStrip.Items.Add(deleteNodeTsm);
                switch (i)
                {
                    case 0:
                        firstSwitch.ContextMenuStrip = contextMenuStrip;
                        addNodeTsm.Click += (sender, args) =>
                        {
                            numberOfDevice = 0;
                            getSwitchProperties?.Invoke();
                        };
                        deleteNodeTsm.Click += (sender, args) =>
                        {
                            numberOfDevice = 0;
                            displaySwitchProperties?.Invoke();
                        };
                        break;
                    case 1:
                        secondSwitch.ContextMenuStrip = contextMenuStrip;
                        addNodeTsm.Click += (sender, args) =>
                        {
                            numberOfDevice = 1;
                            getSwitchProperties?.Invoke();
                        };
                        deleteNodeTsm.Click += (sender, args) =>
                        {
                            numberOfDevice = 1;
                            displaySwitchProperties?.Invoke();
                        };
                        break;
                    case 2:
                        thirdSwitch.ContextMenuStrip = contextMenuStrip;
                        addNodeTsm.Click += (sender, args) =>
                        {
                            numberOfDevice = 2;
                            getSwitchProperties?.Invoke();
                        };
                        deleteNodeTsm.Click += (sender, args) =>
                        {
                            numberOfDevice = 2;
                            displaySwitchProperties?.Invoke();
                        };
                        break;
                    case 3:
                        fourthSwitch.ContextMenuStrip = contextMenuStrip;
                        addNodeTsm.Click += (sender, args) =>
                        {
                            numberOfDevice = 3;
                            getSwitchProperties?.Invoke();
                        };
                        deleteNodeTsm.Click += (sender, args) =>
                        {
                            numberOfDevice = 3;
                            displaySwitchProperties?.Invoke();
                        };
                        break;
                    case 4:
                        fifthSwitch.ContextMenuStrip = contextMenuStrip;
                        addNodeTsm.Click += (sender, args) =>
                        {
                            numberOfDevice = 4;
                            getSwitchProperties?.Invoke();
                        };
                        deleteNodeTsm.Click += (sender, args) =>
                        {
                            numberOfDevice = 4;
                            displaySwitchProperties?.Invoke();
                        };
                        break;
                    case 5:
                        sixthSwitch.ContextMenuStrip = contextMenuStrip;
                        addNodeTsm.Click += (sender, args) =>
                        {
                            numberOfDevice = 5;
                            getSwitchProperties?.Invoke();
                        };
                        deleteNodeTsm.Click += (sender, args) =>
                        {
                            numberOfDevice = 5;
                            displaySwitchProperties?.Invoke();
                        };
                        break;
                }
            }
        }

        public bool displaySwitch()
        {
            switch (numberOfDevice)
            {
                case 0:
                    return isBusy(firstSwitch, firstCable, firstName);
                case 1:
                    return isBusy(secondSwitch, secondCable, secondName);
                case 2:
                    return isBusy(thirdSwitch, thirdCable, thirdName);
                case 3:
                    return isBusy(fourthSwitch, fourthCable, fourthName);
                case 4:
                    return isBusy(fifthSwitch, fifthCable, fifthName);
                case 5:
                    return isBusy(sixthSwitch, sixthCable, sixthName);
            }

            return false;
        }

        public bool hideSwitch()
        {
            switch (numberOfDevice)
            {
                case 0:
                    return isExist(firstSwitch, firstCable, firstName);
                case 1:
                    return isExist(secondSwitch, secondCable, secondName);
                case 2:
                    return isExist(thirdSwitch, thirdCable, thirdName);
                case 3:
                    return isExist(fourthSwitch, fourthCable, fourthName);
                case 4:
                    return isExist(fifthSwitch, fifthCable, fifthName);
                case 5:
                    return isExist(sixthSwitch, sixthCable, sixthName);
            }

            return false;
        }


        private bool isBusy(PictureBox switchPB, PictureBox cable, Label name)
        {
            if (switchPB.Visible)
            {
                MessageBox.Show("The port is already busy!");
                return false;
            }

            switchPB.Visible = true;
            cable.Visible = true;
            name.Visible = true;
            return true;
        }

        private bool isExist(PictureBox switchPB, PictureBox cable, Label name)
        {
            if (!switchPB.Visible)
            {
                MessageBox.Show("Port has no connection!");
                return false;
            }

            switchPB.Visible = false;
            cable.Visible = false;
            name.Visible = false;
            return true;
        }

        public void displaySetProperties()
        {
            netmaskLabel.Visible = true;
            networkAddressLabel.Visible = true;
            netmaskTextBox.Visible = true;
            networkAddressTextBox.Visible = true;
            confirmButton.Visible = true;
        }

        public void hideSetProperties()
        {
            netmaskLabel.Visible = false;
            networkAddressLabel.Visible = false;
            netmaskTextBox.Visible = false;
            networkAddressTextBox.Visible = false;
            confirmButton.Visible = false;
        }

        public void displaySetRecord()
        {
            routingNetmaskLabel.Visible = true;
            routingNetworkAddressLabel.Visible = true;
            routingGatewayLabel.Visible = true;
            routingNetmaskTB.Visible = true;
            routingNetworkAddressTB.Visible = true;
            routingGatewayTB.Visible = true;
            routingConfirmButton.Visible = true;
        }

        public void hideSetRecord()
        {
            routingNetmaskLabel.Visible = false;
            routingNetworkAddressLabel.Visible = false;
            routingGatewayLabel.Visible = false;
            routingNetmaskTB.Visible = false;
            routingNetworkAddressTB.Visible = false;
            routingGatewayTB.Visible = false;
            routingConfirmButton.Visible = false;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            setSwitchProperties?.Invoke();
        }


        public string[] getMaskAndAddress()
        {
            return new[] {netmaskTextBox.Text, networkAddressTextBox.Text};
        }

        private void routingConfirmButton_Click(object sender, EventArgs e)
        {
            addRecordTable?.Invoke();
        }
        
        public string[] getRecordInfo()
        {
            return new[] {routingNetworkAddressTB.Text, routingNetmaskTB.Text, routingGatewayTB.Text};
        }
    }
}