using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using CourseWork.Enviroment;

namespace CourseWork
{
    public static class BusinessLogic
    {
        public static bool UpdateReadInfoFromXml()
        {
            try
            {
                var xDoc = new XmlDocument();
                xDoc.Load("userBase.xml");
                var Root = xDoc.DocumentElement;
                if (Root != null)
                    foreach (XmlNode bases in Root)
                        if (bases.Name == "users")
                        {
                            foreach (XmlNode userElem in bases)
                            {
                                var Username = userElem.Attributes.GetNamedItem("name").Value;
                                ;
                                var passwordUser =
                                    "0LvQsNC70LDQu9Cw0YHQtdGA0LbRgdCy0LDQu9C40LvRgdGP0YHQvtGB0YLQvtC70LA=";
                                var phoneNumber = "<None>";
                                var email = "<None>";
                                var realName = "<None>";
                                foreach (XmlNode attrUser in userElem.ChildNodes)
                                    if (attrUser.Name == "password")
                                    {
                                        passwordUser = attrUser.InnerText;
                                    }
                                    else if (attrUser.Name == "phone")
                                    {
                                        phoneNumber = attrUser.InnerText;
                                    }
                                    else if (attrUser.Name == "realName")
                                    {
                                        realName = attrUser.InnerText;
                                    }
                                    else if (attrUser.Name == "Email")
                                    {
                                        email = attrUser.InnerText;
                                    }
                                    else if (attrUser.Name == "RezervedTables")
                                    {
                                        var FileUsersRequests = new List<TableReserveRequest>();
                                        foreach (XmlNode reserveTableElem in attrUser)
                                        {
                                            var sNumberTable = reserveTableElem.Attributes.GetNamedItem("name").Value;
                                            ushort NumberTable;
                                            if (ushort.TryParse(sNumberTable, out NumberTable) == false) goto Next;
                                            foreach (var T in Restik.Tables)
                                                if (T.Number == NumberTable)
                                                    goto Ok;
                                            goto Next;
                                            Ok:
                                            {
                                            }
                                            DateTime From = DateTime.Now, Until = DateTime.Now;
                                            ushort CountPeople = 0;
                                            var ContactPhone = "<None>";
                                            var Status = false;
                                            foreach (XmlNode attrTable in reserveTableElem.ChildNodes)
                                                if (attrTable.Name == "countPeople")
                                                {
                                                    if (ushort.TryParse(attrTable.InnerText, out CountPeople) == false)
                                                        CountPeople = 0;
                                                }
                                                else if (attrTable.Name == "ReservedFrom")
                                                {
                                                    if (DateTime.TryParse(attrTable.InnerText, out From) == false)
                                                        From = DateTime.Now;
                                                }
                                                else if (attrTable.Name == "ReservedUntil")
                                                {
                                                    if (DateTime.TryParse(attrTable.InnerText, out Until) == false)
                                                        Until = DateTime.Now;
                                                }
                                                else if (attrTable.Name == "Status")
                                                {
                                                    if (bool.TryParse(attrTable.InnerText, out Status) == false) ;
                                                }

                                            if (Until > DateTime.Now)
                                            {
                                                if (From < DateTime.Now)
                                                {
                                                    while (TryUpdateRequest(Username, NumberTable, From, Until,
                                                        DateTime.Now.AddMinutes(2), Until) == false) ;
                                                    while (UpdateReadInfoFromXml() == false) ;
                                                    return true;
                                                }

                                                FileUsersRequests.Add(new TableReserveRequest(NumberTable, CountPeople,
                                                    From, Until, Username, Status));
                                            }
                                            else
                                            {
                                                while (TryDeleteRequest(Username, NumberTable, From) == false) ;
                                            }

                                            Next:
                                            {
                                            }
                                        }

                                        foreach (var user in Users)
                                            if (user.IsThisUsername(Username))
                                            {
                                                var ind = user.NotEqualRequests(FileUsersRequests);
                                                if (ind == FileUsersRequests.Count &&
                                                    user.IsThisPassword(passwordUser) &&
                                                    phoneNumber == user.getPhoneNumber(passwordUser) &&
                                                    realName == user.getRealName(passwordUser) &&
                                                    email == user.getEmail(passwordUser)) goto N;
                                                Users.Remove(user);

                                                NeedUpdateData = true;

                                                Users.Add(new User(Username, passwordUser, FileUsersRequests,
                                                    phoneNumber, realName, email));
                                                goto N;
                                            }

                                        if (FileUsersRequests.Count != 0)
                                            NeedUpdateData = true;
                                        Users.Add(new User(Username, passwordUser, FileUsersRequests, phoneNumber,
                                            realName, email));
                                        N:
                                        {
                                        }
                                        break;
                                    }
                            }
                        }
                        else if (bases.Name == "tables")
                        {
                            var tables = new List<Table>();
                            foreach (XmlNode table in bases)
                            {
                                var sTableNumber = table.Attributes.GetNamedItem("name").Value;
                                ushort TableNumber = 0, MaxCount = 0;
                                var sourceImage = "";
                                if (ushort.TryParse(sTableNumber, out TableNumber) == false)
                                    goto NextTable;
                                foreach (XmlNode attrTable in table)
                                    if (attrTable.Name == "maxCount")
                                    {
                                        if (ushort.TryParse(attrTable.InnerText, out MaxCount) == false)
                                            goto NextTable;
                                    }
                                    else if (attrTable.Name == "image")
                                    {
                                        sourceImage = attrTable.InnerText;
                                    }

                                tables.Add(new Table(TableNumber, MaxCount, sourceImage));

                                NextTable:
                                {
                                }
                            }

                            if (Restik.Tables.Count != tables.Count)
                            {
                                Restik.Tables.Clear();
                                foreach (var table in tables) Restik.AddTable(table);
                                UpdateTablePanels();
                            }
                        }
            }
            catch
            {
                return false;
            }

            if (NeedUpdateData)
            {
                NeedUpdateData = false;
                var size = Restik.Tables.Count;
                /*
                for (int i=0; i<size; i++)
                {
                    BusinessLogic.Restik.AddTable(new Table(BusinessLogic.Restik.Tables[i].Number, BusinessLogic.Restik.Tables[i].MaxCapacity,BusinessLogic.Restik.Tables[i].ImagSources));
                }
                for (int i=0; i<size; i++)
                {
                    BusinessLogic.Restik.Tables.RemoveAt(0);
                }
                */
                foreach (var user in Users)
                foreach (var request in user.GetReqests())
                {
                    int number = request.ReservedTableNumber;
                    foreach (var table in Restik.Tables)
                        if (table.Number == number)
                        {
                            var Stat = table.TryAddRezerv(request);
                            break;
                        }
                }

                UpdatedRequestPanels = true;
            }

            return true;
        }

        public static bool TryAcceptRequest(string Username, ushort tableNumber, DateTime From)
        {
            var xDoc = new XmlDocument();
            xDoc.Load("userBase.xml");
            var Root = xDoc.DocumentElement;
            if (Root != null)
            {
                foreach (XmlNode bases in Root)
                    if (bases.Name == "users")
                        foreach (XmlNode user in bases)
                            if (user.Attributes.GetNamedItem("name").Value == Username)
                                foreach (XmlNode userAttr in user)
                                    if (userAttr.Name == "RezervedTables")
                                        foreach (XmlNode tables in userAttr)
                                            if (tables.Attributes.GetNamedItem("name").Value == tableNumber.ToString())
                                            {
                                                DateTime ThisFrom = new DateTime(), ThisUntil = new DateTime();
                                                foreach (XmlNode tableAttr in tables)

                                                    if (tableAttr.Name == "ReservedFrom")
                                                        ThisFrom = DateTime.Parse(tableAttr.InnerText);

                                                if (ThisFrom == From)
                                                {
                                                    foreach (XmlNode tableAttr in tables)

                                                        if (tableAttr.Name == "Status")
                                                            tableAttr.InnerText = "true";

                                                    xDoc.Save("userBase.xml");
                                                    goto End;
                                                }
                                            }
            }
            else
            {
                return false;
            }

            End:
            {
            }
            return true;
        }

        public static bool TryUpdateRequest(string Username, ushort tableNumber, DateTime From, DateTime Until,
            DateTime NewFrom,
            DateTime NewUntil)
        {
            var xDoc = new XmlDocument();
            xDoc.Load("userBase.xml");
            var Root = xDoc.DocumentElement;
            if (Root != null)
            {
                foreach (XmlNode bases in Root)
                    if (bases.Name == "users")
                        foreach (XmlNode user in bases)
                            if (user.Attributes.GetNamedItem("name").Value == Username)
                                foreach (XmlNode userAttr in user)
                                    if (userAttr.Name == "RezervedTables")
                                        foreach (XmlNode tables in userAttr)
                                            if (tables.Attributes.GetNamedItem("name").Value == tableNumber.ToString())
                                            {
                                                DateTime ThisFrom = new DateTime(), ThisUntil = new DateTime();
                                                foreach (XmlNode tableAttr in tables)

                                                    if (tableAttr.Name == "ReservedFrom")
                                                        ThisFrom = DateTime.Parse(tableAttr.InnerText);
                                                    else if (tableAttr.Name == "ReservedUntil")
                                                        ThisUntil = DateTime.Parse(tableAttr.InnerText);

                                                if (ThisFrom == From && ThisUntil == Until)
                                                {
                                                    foreach (XmlNode tableAttr in tables)

                                                        if (tableAttr.Name == "ReservedFrom")
                                                            tableAttr.InnerText = NewFrom.ToString();
                                                        else if (tableAttr.Name == "ReservedUntil")
                                                            tableAttr.InnerText = NewUntil.ToString();

                                                    xDoc.Save("userBase.xml");
                                                    goto End;
                                                }
                                            }
            }
            else
            {
                return false;
            }

            End:
            {
            }
            return true;
        }

        public static bool TryUpdateUser(string Username, string PhoneNumber, string Password, string Email,
            string RealName)
        {
            var xDoc = new XmlDocument();
            xDoc.Load("userBase.xml");
            var Root = xDoc.DocumentElement;
            if (Root != null)
            {
                foreach (XmlNode bases in Root)
                    if (bases.Name == "users")
                        foreach (XmlNode user in bases)

                            if (user.Attributes.GetNamedItem("name").Value == Username)
                            {
                                foreach (XmlNode userAttr in user)
                                    if (userAttr.Name == "password")
                                        userAttr.InnerText = Password;
                                    else if (userAttr.Name == "phone")
                                        userAttr.InnerText = PhoneNumber;
                                    else if (userAttr.Name == "realName")
                                        userAttr.InnerText = RealName;
                                    else if (userAttr.Name == "Email")
                                        userAttr.InnerText = Email;
                                xDoc.Save("userBase.xml");
                                goto End;
                            }
            }
            else
            {
                return false;
            }

            End:
            {
            }
            return true;
        }

        public static bool ValidatePhone(string LineText)
        {
            return Regex.IsMatch(LineText, @"^[+]375\d{9}$");
        }

        public static bool ValidateEmail(string LineText)
        {
            return Regex.IsMatch(LineText, @"^[A-Za-z][A-Za-z._\d]*@\w+[.]\w+$");
        }

        public static bool TryRegisterNewUser(string Username, string Password, string Phone, string Email,
            string realName)
        {
            try
            {
                var xDoc = new XmlDocument();
                xDoc.Load("userBase.xml");
                var Root = xDoc.DocumentElement;
                if (Root != null)
                    foreach (XmlNode bases in Root)
                        if (bases.Name == "users")
                        {
                            var userElem = xDoc.CreateElement("user");
                            var nameAttr = xDoc.CreateAttribute("name");
                            var passwordElem = xDoc.CreateElement("password");
                            var phoneElem = xDoc.CreateElement("phone");
                            var emailElem = xDoc.CreateElement("Email");
                            var realNameElem = xDoc.CreateElement("realName");
                            var EmptyMenuElem = xDoc.CreateElement("MenuCart");
                            var EmptyReservedElem = xDoc.CreateElement("RezervedTables");

                            var nameText = xDoc.CreateTextNode(Username);
                            var passwordText = xDoc.CreateTextNode(Password);
                            var phoneText = xDoc.CreateTextNode(Phone);
                            var emailText = xDoc.CreateTextNode(Email);
                            var realNameText = xDoc.CreateTextNode(realName);

                            nameAttr.AppendChild(nameText);
                            passwordElem.AppendChild(passwordText);
                            phoneElem.AppendChild(phoneText);
                            emailElem.AppendChild(emailText);
                            realNameElem.AppendChild(realNameText);
                            userElem.Attributes.Append(nameAttr);
                            userElem.AppendChild(passwordElem);
                            userElem.AppendChild(phoneElem);
                            userElem.AppendChild(emailElem);
                            userElem.AppendChild(realNameElem);
                            userElem.AppendChild(EmptyMenuElem);
                            userElem.AppendChild(EmptyReservedElem);

                            bases.AppendChild(userElem);
                            xDoc.Save("userBase.xml");
                            while (UpdateReadInfoFromXml() == false) ;
                            break;
                        }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static bool TryAddNewTable(uint Number, uint Capacity, string imagSource)
        {
            try
            {
                var xDoc = new XmlDocument();
                xDoc.Load("userBase.xml");
                var Root = xDoc.DocumentElement;
                if (Root != null)
                    foreach (XmlNode bases in Root)
                        if (bases.Name == "tables")
                        {
                            var userElem = xDoc.CreateElement("table");
                            var nameAttr = xDoc.CreateAttribute("name");
                            var imageElem = xDoc.CreateElement("image");
                            var capacityElem = xDoc.CreateElement("maxCount");

                            var nameText = xDoc.CreateTextNode(Number.ToString());
                            var imageText = xDoc.CreateTextNode(imagSource);
                            var capacityText = xDoc.CreateTextNode(Capacity.ToString());

                            nameAttr.AppendChild(nameText);
                            imageElem.AppendChild(imageText);
                            capacityElem.AppendChild(capacityText);
                            userElem.Attributes.Append(nameAttr);
                            userElem.AppendChild(imageElem);
                            userElem.AppendChild(capacityElem);

                            bases.AppendChild(userElem);
                            xDoc.Save("userBase.xml");
                            while (UpdateReadInfoFromXml() == false) ;
                            break;
                        }
            }
            catch
            {
                return false;
            }

            return true;
        }


        public static void UpdateRequestPanels()
        {
            var newRequests = new List<Panel>();
            var i = 0;
            Requests.Clear();
            var InfosByRequest = new Dictionary<TableReserveRequest, Tuple<string, string, string>>();
            foreach (var user in Users)
                if (!user.IsThisUsername("Admin"))
                    if (user.IsThisUsername(CurrentUsername) || CurrentUsername == "Admin")
                        foreach (var request in user.GetReqests())
                        {
                            Requests.Add(request);
                            InfosByRequest[request] = new Tuple<string, string, string>(
                                user.getPhoneNumber(CurrentPassword), user.getEmail(CurrentPassword),
                                user.getRealName(CurrentPassword));
                        }

            Requests.Sort();
            foreach (var request in Requests)
            {
                var newPanel = new Panel();
                var RequestButton1 = new Button();
                var RequestButton2 = new Button();
                var MessageRequest = new Label();
                var TableNumberRequest = new Label();
                var RequestUntil = new Label();
                var RequestFrom = new Label();
                var PersonCountRequest = new Label();
                var LabelRequestContactPhone = new Label();
                var LabelEmail = new Label();
                var LabelRealName = new Label();
                // 
                // RequestButton2
                // 
                RequestButton2.BackColor = Color.FromArgb((int) (byte) 192, (int) (byte) 255, (int) (byte) 192);
                RequestButton2.Font = new Font("MV Boli", 16F, FontStyle.Bold);
                RequestButton2.Location = new Point(626, 57);
                RequestButton2.Name = "RequestButton2" + i.ToString();
                RequestButton2.Size = new Size(106, 71);
                RequestButton2.TabIndex = 12;
                RequestButton2.Text = "Accept";
                RequestButton2.UseVisualStyleBackColor = false;
                // 
                // RequestButton1
                // 
                RequestButton1.BackColor = Color.FromArgb((int) (byte) 255, (int) (byte) 192, (int) (byte) 192);
                RequestButton1.Font = new Font("MV Boli", 16F, FontStyle.Bold);
                RequestButton1.Location = new Point(515, 57);
                RequestButton1.Name = "RequestButton1" + i.ToString();
                RequestButton1.Size = new Size(105, 71);
                RequestButton1.TabIndex = 11;
                if (CurrentUsername == "Admin")
                {
                    RequestButton1.Text = "Decline";
                }
                else if (!request.Status)
                {
                    RequestButton1.Text = "Delete";
                }
                else
                {
                    RequestButton1.Text = "Phone to delete";
                    RequestButton1.Size = new Size(212, 46);
                    RequestButton1.Enabled = false;
                }

                RequestButton1.UseVisualStyleBackColor = false;
                // 
                // PersonCountRequest
                // 
                PersonCountRequest.BackColor = Color.White;
                PersonCountRequest.BorderStyle = BorderStyle.Fixed3D;
                PersonCountRequest.Font = new Font("MV Boli", 15F, FontStyle.Bold);
                PersonCountRequest.Image = Image.FromFile(Environment.CurrentDirectory + "\\Resource\\Person.png");
                PersonCountRequest.ImageAlign = ContentAlignment.MiddleRight;
                PersonCountRequest.Location = new Point(418, 70);
                PersonCountRequest.Name = "PersonCountRequest" + i.ToString();
                PersonCountRequest.Size = new Size(91, 44);
                PersonCountRequest.TabIndex = 5;
                PersonCountRequest.Text = request.CountPeople.ToString();
                PersonCountRequest.TextAlign = ContentAlignment.MiddleLeft;
                // 
                // TableNumberRequest
                // 
                TableNumberRequest.BackColor = Color.White;
                TableNumberRequest.BorderStyle = BorderStyle.Fixed3D;
                TableNumberRequest.Font = new Font("MV Boli", 15F, FontStyle.Bold);
                TableNumberRequest.Image = Image.FromFile(Environment.CurrentDirectory + "\\Resource\\Table.png");
                TableNumberRequest.ImageAlign = ContentAlignment.BottomRight;
                TableNumberRequest.Location = new Point(325, 70);
                TableNumberRequest.Name = "TableNumberRequest" + i.ToString();
                TableNumberRequest.Size = new Size(87, 44);
                TableNumberRequest.TabIndex = 4;
                TableNumberRequest.Text = request.ReservedTableNumber.ToString();
                TableNumberRequest.TextAlign = ContentAlignment.MiddleLeft;
                // 
                // RequestUntil
                // 
                RequestUntil.Font = new Font("MV Boli", 12F, FontStyle.Bold);
                RequestUntil.Location = new Point(314, 30);
                RequestUntil.Name = "RequestUntil" + i.ToString();
                RequestUntil.Size = new Size(427, 25);
                RequestUntil.TabIndex = 3;
                RequestUntil.Text = "Until: " + request.TimeInterval.Item2.ToString("t");
                RequestUntil.TextAlign = ContentAlignment.MiddleRight;
                // 
                // RequestFrom
                // 
                RequestFrom.Font = new Font("MV Boli", 12F, FontStyle.Bold);
                RequestFrom.Location = new Point(313, 5);
                RequestFrom.Name = "RequestFrom" + i.ToString();
                RequestFrom.Size = new Size(427, 25);
                RequestFrom.TabIndex = 2;
                RequestFrom.Text = "From: " + request.TimeInterval.Item1.ToString("g");
                RequestFrom.TextAlign = ContentAlignment.MiddleRight;
                // 
                // LabelRequestContactPhone
                // 
                LabelRequestContactPhone.Font = new Font("MV Boli", 15F);
                LabelRequestContactPhone.Location = new Point(-1, 53);
                LabelRequestContactPhone.Name = "LabelRequestContactPhone" + i.ToString();
                LabelRequestContactPhone.Size = new Size(325, 30);
                LabelRequestContactPhone.TabIndex = 1;
                LabelRequestContactPhone.Text = "contact phone: " + InfosByRequest[request].Item1; // 
                // LabelEmail
                // 
                LabelEmail.Font = new Font("MV Boli", 15F);
                LabelEmail.Location = new Point(-1, 78);
                LabelEmail.Name = "LabelRequestContactPhone" + i.ToString();
                LabelEmail.Size = new Size(325, 30);
                LabelEmail.TabIndex = 1;
                LabelEmail.Text = "e-mail: " + InfosByRequest[request].Item2;
                // 
                // LabelRealName
                // 
                LabelRealName.Font = new Font("MV Boli", 15F);
                LabelRealName.Location = new Point(-1, 106);
                LabelRealName.Name = "LabelRequestContactPhone" + i.ToString();
                LabelRealName.Size = new Size(325, 30);
                LabelRealName.TabIndex = 1;
                LabelRealName.Text = "real name: " + InfosByRequest[request].Item3;

                // 
                // MessageRequest
                // 
                MessageRequest.Font = new Font("MV Boli", 21F, FontStyle.Bold);
                MessageRequest.Location = new Point(-2, 11);
                MessageRequest.Name = "MessageRequest" + i.ToString();
                MessageRequest.AutoSize = true;
                MessageRequest.TabIndex = 0;
                if (!request.Status)
                    MessageRequest.Text = $"User \"{request.UsernameOwner}\" requests a reservation";
                else
                    MessageRequest.Text = $"User \"{request.UsernameOwner}\" - owner reservation";
                // 
                // PanelRequest
                // 
                newPanel.BackColor = Color.FromArgb((int) (byte) 224, (int) (byte) 224, (int) (byte) 224);
                newPanel.BorderStyle = BorderStyle.FixedSingle;
                newPanel.Controls.Add(RequestButton1);
                newPanel.Controls.Add(MessageRequest);
                if (CurrentUsername == "Admin" && !request.Status)
                    newPanel.Controls.Add(RequestButton2);
                newPanel.Controls.Add(LabelRequestContactPhone);
                newPanel.Controls.Add(PersonCountRequest);
                newPanel.Controls.Add(RequestFrom);
                newPanel.Controls.Add(TableNumberRequest);
                newPanel.Controls.Add(RequestUntil);
                newPanel.Tag = (float) (request.TimeInterval.Item2.Subtract(request.TimeInterval.Item1).TotalSeconds *
                                        2.5 /
                                        3600);
                newPanel.Controls.Add(LabelEmail);
                newPanel.Controls.Add(LabelRealName);
                newPanel.Location = new Point(18, 20);
                newPanel.Name = "PanelRequest" + i.ToString();
                newPanel.Size = new Size(740, 140);
                newPanel.TabIndex = 1;
                if (!request.Status)
                    newPanel.TabIndex = 0;
                newRequests.Add(newPanel);
                i++;
            }

            if (newRequests != RequestPanels) RequestPanels = newRequests;
        }

        public static void UpdateTablePanels()
        {
            var newTables = new List<Panel>();
            var i = 0;
            foreach (var table in Restik.Tables)
                if (table.Number != 0)
                {
                    var newPanel = new Panel();
                    var newImagePersons = new PictureBox();
                    Label newTitelTable = new Label(), newCapacityTable = new Label();
                    newPanel.BorderStyle = BorderStyle.Fixed3D;
                    newPanel.Controls.Add(newImagePersons);
                    newPanel.Controls.Add(newTitelTable);
                    newPanel.Controls.Add(newCapacityTable);
                    newPanel.Tag = i;
                    newPanel.Name = "panelTable" + i.ToString();
                    newPanel.Size = new Size(204, 66);
                    newPanel.TabIndex = 8;
                    // 
                    // personImage[i]
                    // 
                    newImagePersons.Image =
                        (Image)
                        Image.FromFile(Environment.CurrentDirectory + "\\Resource\\Person.png");
                    newImagePersons.Location = new Point(154, 36);
                    newImagePersons.Name = "personImage" + i.ToString();
                    newImagePersons.Size = new Size(45, 28);
                    newImagePersons.SizeMode = PictureBoxSizeMode.Zoom;
                    newImagePersons.TabIndex = i;
                    newImagePersons.TabStop = false;
                    // 
                    // newTitelTable
                    // 
                    newTitelTable.Font = new Font("MV Boli", 15F, FontStyle.Bold);
                    newTitelTable.Location = new Point(28, 14);
                    newTitelTable.Name = "TitelTable" + i.ToString();
                    newTitelTable.Size = new Size(136, 27);
                    newTitelTable.TabIndex = 0;
                    newTitelTable.Text = "Table №" + table.Number.ToString();
                    // 
                    // newCapacityTable
                    // 
                    newCapacityTable.Location = new Point(101, 41);
                    newCapacityTable.Name = "newCapacityTable" + i.ToString();
                    newCapacityTable.Size = new Size(55, 18);
                    newCapacityTable.TabIndex = 1;
                    newCapacityTable.Text = "Max " + table.MaxCapacity.ToString();
                    newCapacityTable.TextAlign = ContentAlignment.MiddleRight;

                    newTables.Add(newPanel);
                    i++;
                }

            if (newTables != TablesPanels)
            {
                TablesPanels = newTables;
                UpdatedTablePanels = true;
            }
        }

        public static bool TryAddNewReserveRequest(DateTime DateFrom, DateTime DateUntil, int countPerson)
        {
            try
            {
                var xDoc = new XmlDocument();
                xDoc.Load("userBase.xml");
                var Root = xDoc.DocumentElement;
                if (Root != null)
                    foreach (XmlNode bases in Root)
                        if (bases.Name == "users")
                        {
                            foreach (XmlNode user in bases)
                                if (user.Attributes.GetNamedItem("name").Value == CurrentUsername)
                                    foreach (XmlNode userAtr in user)
                                        if (userAtr.Name == "RezervedTables")
                                        {
                                            var tableElem = xDoc.CreateElement("table");
                                            var nameAttr = xDoc.CreateAttribute("name");
                                            var capacityElem = xDoc.CreateElement("countPeople");
                                            var TimeFromElem = xDoc.CreateElement("ReservedFrom");
                                            var TimeUntilElem = xDoc.CreateElement("ReservedUntil");
                                            var StatusElem = xDoc.CreateElement("Status");

                                            var nameText = xDoc.CreateTextNode(SelectedTable.Number.ToString());
                                            var capacityText = xDoc.CreateTextNode(countPerson.ToString());
                                            var TimeFromText = xDoc.CreateTextNode(
                                                DateFrom.ToString());
                                            var TimeUntilText = xDoc.CreateTextNode(
                                                DateUntil.ToString());
                                            var StatusText = xDoc.CreateTextNode("false");

                                            nameAttr.AppendChild(nameText);
                                            tableElem.Attributes.Append(nameAttr);
                                            capacityElem.AppendChild(capacityText);
                                            TimeFromElem.AppendChild(TimeFromText);
                                            TimeUntilElem.AppendChild(TimeUntilText);
                                            StatusElem.AppendChild(StatusText);

                                            tableElem.AppendChild(capacityElem);
                                            tableElem.AppendChild(TimeFromElem);
                                            tableElem.AppendChild(TimeUntilElem);
                                            tableElem.AppendChild(StatusElem);
                                            userAtr.AppendChild(tableElem);
                                        }

                            xDoc.Save("userBase.xml");
                            while (UpdateReadInfoFromXml() == false) ;
                            break;
                        }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static bool TryDeleteRequest(string Username, int NumberTable, DateTime FromTime)
        {
            try
            {
                var xDoc = new XmlDocument();
                xDoc.Load("userBase.xml");
                var Root = xDoc.DocumentElement;
                if (Root != null)
                    foreach (XmlNode bases in Root)
                        if (bases.Name == "users")
                            foreach (XmlNode user in bases)
                                if (user.Attributes.GetNamedItem("name").Value == Username)
                                    foreach (XmlNode userAttr in user)
                                        if (userAttr.Name == "RezervedTables")
                                            foreach (XmlNode table in userAttr)
                                                if (table.Attributes.GetNamedItem("name").Value ==
                                                    NumberTable.ToString())
                                                    foreach (XmlNode tableAttr in table)
                                                        if (tableAttr.Name == "ReservedFrom" &&
                                                            tableAttr.InnerText == FromTime.ToString())
                                                        {
                                                            userAttr.RemoveChild(table);
                                                            xDoc.Save("userBase.xml");
                                                            while (UpdateReadInfoFromXml() == false) ;
                                                            goto End;
                                                        }
            }
            catch
            {
                return false;
            }

            End:
            {
            }
            return true;
        }


        public static bool TryDeleteTable()
        {
            try
            {
                var xDoc = new XmlDocument();
                xDoc.Load("userBase.xml");
                var Root = xDoc.DocumentElement;
                if (Root != null)
                    foreach (XmlNode bases in Root)
                        if (bases.Name == "tables")
                            foreach (XmlNode table in bases)
                                if (table.Attributes.GetNamedItem("name").Value == SelectedTable.Number.ToString())
                                {
                                    bases.RemoveChild(table);
                                    xDoc.Save("userBase.xml");
                                    UpdatedTablePanels = true;
                                    while (UpdateReadInfoFromXml() == false) ;
                                    UpdateTablePanels();
                                    break;
                                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        //public static List<>

        public static Table SelectedTable;
        public static bool UpdatedTablePanels = false;
        public static List<Panel> TablesPanels = new List<Panel>();
        public static List<Panel> RequestPanels = new List<Panel>();
        public static string CurrentUsername;
        public static string CurrentPassword;
        public static List<User> Users = new List<User>();

        public static Restaurant Restik =
            new Restaurant(TimeSpan.Parse("12:00:00"), TimeSpan.Parse("02:00:00"), new List<Table>());

        public static List<TableReserveRequest> Requests = new List<TableReserveRequest>();
        public static bool NeedUpdateData = false;
        public static bool UpdatedRequestPanels;
        public static bool UpdateDish = false;
    }
}