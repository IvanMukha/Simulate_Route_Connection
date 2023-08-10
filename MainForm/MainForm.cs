using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Timers;
using System.Windows.Forms;
using CourseWork.Enviroment;

namespace CourseWork.MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            while (BusinessLogic.UpdateReadInfoFromXml() == false) ;
            //ReservGroupBox.BringToFront();
            foreach (var table in BusinessLogic.Restik.Tables)
                if (table.Number == 0)
                {
                    pictureBox1.Image = table.imag;
                    break;
                }

            if (BusinessLogic.CurrentUsername == "Admin")
                CartButton.Image = Image.FromFile(Environment.CurrentDirectory + "\\Resource\\TimeMoney.png");
            ZoomOutButton.Enabled = false;
            ZoomInButton.Enabled = true;
            while (BusinessLogic.UpdateReadInfoFromXml() == false) ;
            BusinessLogic.UpdateTablePanels();
            Update_timer.Start();
            Update_Timer2.Start();

            //BusinessLogic.Restik;
        }

        private void MouseEnterTables(object sender, EventArgs e)
        {
            var i = 1;
            foreach (var tablesPanel in BusinessLogic.TablesPanels)
            {
                if (tablesPanel.Bounds.Contains(TableList.PointToClient(Cursor.Position)))
                {
                    pictureBox1.Image = BusinessLogic.Restik.Tables[i].imag;
                    break;
                }

                i++;
            }
        }

        private void MouseLeaveTables(object sender, EventArgs e)
        {
            foreach (var table in BusinessLogic.Restik.Tables)
                if (table.Number == 0)
                {
                    pictureBox1.Image = table.imag;
                    break;
                }
        }


        private int leftLimit, rightLimit;
        private bool isMovedPanel = false;
        private Panel ActivePanel;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ActivePanel = panel1;
            rightLimit = LineBar.Left + LineBar.Width - ActivePanel.Width + 2;
            leftLimit = LineBar.Left - panel1.Width + 2;
            isMovedPanel = true;
            timer1.Start();
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (isMovedPanel == false)
            {
                timer1.Stop();
            }
            else
            {
                var lA = ActivePanel.Left;

                if (ActivePanel == panel1)
                    lA = Math.Min(
                        Math.Max(leftLimit, ReservGroupBox.PointToClient(Cursor.Position).X - panel1.Width / 2),
                        rightLimit);
                else if (ActivePanel == panel2)
                    lA = Math.Min(
                        Math.Max(leftLimit, ReservGroupBox.PointToClient(Cursor.Position).X - panel2.Width / 2),
                        rightLimit);

                if (ActivePanel == panel1 && lA + ActivePanel.Width > panel2.Left &&
                    panel2.Left < FreeIntervalThisDay[CurrentFreeInterval].Item2)
                    panel2.Left = panel1.Left + panel1.Width;
                else if (ActivePanel == panel2 && lA < panel1.Left + panel1.Width &&
                         panel1.Left + panel1.Width > FreeIntervalThisDay[CurrentFreeInterval].Item1)
                    panel1.Left = panel2.Left - panel1.Width;

                if (ActivePanel == panel1 &&
                    lA + panel1.Width >= FreeIntervalThisDay[CurrentFreeInterval].Item2)
                    lA = FreeIntervalThisDay[CurrentFreeInterval].Item2 - panel1.Width;
                else if (ActivePanel == panel1 &&
                         lA + panel1.Width < FreeIntervalThisDay[CurrentFreeInterval].Item1)
                    lA = FreeIntervalThisDay[CurrentFreeInterval].Item1 - panel1.Width;
                else if (ActivePanel == panel2 &&
                         lA > FreeIntervalThisDay[CurrentFreeInterval].Item2)
                    lA = FreeIntervalThisDay[CurrentFreeInterval].Item2;
                else if (ActivePanel == panel2 &&
                         lA <= FreeIntervalThisDay[CurrentFreeInterval].Item1)
                    lA = FreeIntervalThisDay[CurrentFreeInterval].Item1;

                var i = 0;
                foreach (var interval in FreeIntervalThisDay)
                {
                    if (interval.Item1 < ReservGroupBox.PointToClient(Cursor.Position).X &&
                        interval.Item2 > ReservGroupBox.PointToClient(Cursor.Position).X)
                        if (interval.Item1 != FreeIntervalThisDay[CurrentFreeInterval].Item1 &&
                            interval.Item2 != FreeIntervalThisDay[CurrentFreeInterval].Item2)
                        {
                            CurrentFreeInterval = i;

                            panel1.Left = FreeIntervalThisDay[CurrentFreeInterval].Item1 - panel1.Width;
                            panel2.Left = FreeIntervalThisDay[CurrentFreeInterval].Item2;
                            break;
                            ;
                        }

                    i++;
                }

                DateTime FromTime = new DateTime(ChooseReserveDateFrom.Value.Year,
                            ChooseReserveDateFrom.Value.Month,
                            ChooseReserveDateFrom.Value.Day, 12, 0, 0)
                        .AddMinutes((panel1.Left + panel1.Width - LineBar.Left) * 840.0 / LineBar.Width),
                    UntilTime = new DateTime(ChooseReserveDateFrom.Value.Year,
                            ChooseReserveDateFrom.Value.Month,
                            ChooseReserveDateFrom.Value.Day, 12, 0, 0)
                        .AddMinutes((panel2.Left + -LineBar.Left) * 840.0 / LineBar.Width);
                var LFT = "From " + FromTime.ToShortTimeString();
                if (LabelFromTime.Text != LFT)
                    LabelFromTime.Text = LFT;
                var LUT = "Until " + UntilTime.ToShortTimeString();
                if (LabelUntilTime.Text != LUT)
                    LabelUntilTime.Text = LUT;
                var PRT =
                    $"Price: {string.Format("{0:0.00}", UntilTime.Subtract(FromTime).TotalSeconds * 2.5 / 3600)}$";
                if (PriceRequestLabel.Text != PRT) PriceRequestLabel.Text = PRT;

                if (lA != ActivePanel.Left) ActivePanel.Left = lA;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMovedPanel = false;
            timer1.Stop();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ActivePanel = panel2;
            rightLimit = LineBar.Left + LineBar.Width;
            leftLimit = LineBar.Left;
            isMovedPanel = true;
            timer1.Start();
        }


        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isMovedPanel = false;
            timer1.Stop();
        }


        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminAdding.Show();
            AdminAdding.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Error;
            //adminAddTableCompletebut
            try
            {
                var Im = Image.FromFile(Environment.CurrentDirectory + "\\Resource\\" + FileName_source.Text);
            }
            catch
            {
                Error = $"File don't find \"{Environment.CurrentDirectory + "\\Resource\\" + FileName_source.Text}\"";
                goto Err;
            }

            foreach (var table in BusinessLogic.Restik.Tables)
                if (table.Number == ChooseNumber.Value)
                {
                    Error = "Current Number already used";
                    goto Err;
                }

            while (BusinessLogic.TryAddNewTable((uint) ChooseNumber.Value, (uint) ChooseCapacity.Value,
                FileName_source.Text) == false) ;
            while (BusinessLogic.UpdateReadInfoFromXml() == false) ;
            BusinessLogic.UpdateTablePanels();

            AdminAdding.Hide();
            goto End;
            Err:
            {
            }
            MessageBox.Show(Error, "Error!");
            End:
            {
            }
        }

        private void AdminAdding_VisibleChanged(object sender, EventArgs e)
        {
            uint Ost = 0;
            foreach (var table in BusinessLogic.Restik.Tables)
                if (table.Number == 0) Ost += table.MaxCapacity;
                else Ost -= table.MaxCapacity;

            FileName_source.Text = "";
            ChooseCapacity.Maximum = Math.Max(Ost, 0);
            ChooseCapacity.Minimum = 1;
            ChooseNumber.Minimum = 1;
            ChooseNumber.Value = ChooseNumber.Minimum;
            ChooseCapacity.Value = ChooseCapacity.Minimum;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            AdminAdding.Hide();
        }

        private void Update_timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (!ReservGroupBox.Visible && !Update_Timer2.Enabled) Update_Timer2.Start();
            else if (ReservGroupBox.Visible && Update_Timer2.Enabled) Update_Timer2.Stop();
            if (FreeIntervalThisDay.Count > 0)
            {
                DateTime FromTime = new DateTime(ChooseReserveDateFrom.Value.Year,
                            ChooseReserveDateFrom.Value.Month,
                            ChooseReserveDateFrom.Value.Day, 12, 0, 0)
                        .AddMinutes((panel1.Left + panel1.Width - LineBar.Left) * 840.0 / LineBar.Width),
                    UntilTime = new DateTime(ChooseReserveDateFrom.Value.Year,
                            ChooseReserveDateFrom.Value.Month,
                            ChooseReserveDateFrom.Value.Day, 12, 0, 0)
                        .AddMinutes((panel2.Left + -LineBar.Left) * 840.0 / LineBar.Width);
                var LFT = "From " + FromTime.ToShortTimeString();
                if (LabelFromTime.Text != LFT)
                    LabelFromTime.Text = LFT;
                var LUT = "Until " + UntilTime.ToShortTimeString();
                if (LabelUntilTime.Text != LUT)
                    LabelUntilTime.Text = LUT;
                var PRT =
                    $"Price: {string.Format("{0:0.00}", UntilTime.Subtract(FromTime).TotalSeconds * 2.5 / 3600)}$";
                if (PriceRequestLabel.Text != PRT) PriceRequestLabel.Text = PRT;
            }

            if (BusinessLogic.UpdatedTablePanels)
            {
                BusinessLogic.UpdatedTablePanels = false;
                var i = 0;
                TableList.Controls.Clear();
                TableList.Controls.Add(AdminButton);
                foreach (var tablesPanel in BusinessLogic.TablesPanels)
                {
                    foreach (var obj in tablesPanel.Controls)
                        if (obj.GetType() == typeof(Label))
                        {
                            (obj as Label).MouseEnter += new EventHandler(MouseEnterTables);

                            (obj as Label).Click += new EventHandler(ClickTablesElement);
                        }
                        else if (obj.GetType() == typeof(PictureBox))
                        {
                            (obj as PictureBox).MouseEnter += new EventHandler(MouseEnterTables);

                            (obj as PictureBox).Click += new EventHandler(ClickTablesElement);
                        }

                    tablesPanel.MouseEnter += new EventHandler(MouseEnterTables);
                    tablesPanel.MouseLeave += new EventHandler(MouseLeaveTables);
                    tablesPanel.Click += new EventHandler(ClickTablesElement);
                    TableList.Controls.Add(tablesPanel);
                    tablesPanel.Location = new Point(2, 5 * i + tablesPanel.Height * i + 6);
                    i++;
                }

                if (BusinessLogic.CurrentUsername == "Admin")
                {
                    AdminButton.Show();
                    AdminButton.Top = BusinessLogic.TablesPanels[BusinessLogic.TablesPanels.Count - 1].Top +
                                      BusinessLogic.TablesPanels[0].Height + 5;
                    //MessageBox.Show(AdminButton.Bounds.ToString(), AdminButton.Visible.ToString()+AdminButton.Parent.GetType().ToString());
                }
                else
                {
                    AdminButton.Top = 5;
                    AdminButton.Hide();
                }
            }
        }

        private void ClickTablesElement(object sender, EventArgs e)
        {
            var i = 1;
            foreach (var tablesPanel in BusinessLogic.TablesPanels)
            {
                if (tablesPanel.Bounds.Contains(TableList.PointToClient(Cursor.Position)))
                {
                    if (BusinessLogic.CurrentUsername != "Admin")
                    {
                        BusinessLogic.SelectedTable = BusinessLogic.Restik.Tables[i];
                        ReservGroupBox.Show();
                        ReservGroupBox.BringToFront();
                        BusinessLogic.SelectedTable = BusinessLogic.Restik.Tables[i];
                    }
                    else
                    {
                        BusinessLogic.SelectedTable = BusinessLogic.Restik.Tables[i];
                        EditTable.Show();
                        EditTable.BringToFront();
                        BusinessLogic.SelectedTable = BusinessLogic.Restik.Tables[i];
                    }

                    break;
                }

                i++;
            }
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size((int) (pictureBox1.Width * 1.5), (int) (pictureBox1.Height * 1.5));
            ZoomInButton.Enabled = false;
            ZoomOutButton.Enabled = true;
        }

        private void ZoomOutButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size((int) (pictureBox1.Width / 1.5), (int) (pictureBox1.Height / 1.5));
            ZoomOutButton.Enabled = false;
            ZoomInButton.Enabled = true;
        }

        private List<Panel> BusyTimes = new List<Panel>();
        private List<Tuple<int, int>> FreeIntervalThisDay = new List<Tuple<int, int>>();
        private int CurrentFreeInterval = -1;

        private void ReservGroupBox_VisibleChanged(object sender, EventArgs e) //Появление окна резервации
        {
            CurrentFreeInterval = 0;
            FreeIntervalThisDay.Clear();
            BusyTimes.Clear();
            LineBar.BringToFront();
            CountPerson.Value = 1;
            CountPerson.Maximum = BusinessLogic.SelectedTable.MaxCapacity;
            ChooseReserveDateFrom.MinDate = DateTime.Now;
            ChooseReserveDateFrom.MaxDate = DateTime.Now.AddDays(31);
            ChooseReserveDateFrom.Value = DateTime.Now;
        }

        //840 all 
        private void ChooseReserveDateFrom_ValueChanged(object sender, EventArgs e) //При выборе новой даты резервации
        {
            ReservGroupBox.Controls.Clear();
            ReservGroupBox.Controls.Add(CancelTableReservButton);
            ReservGroupBox.Controls.Add(ChooseReserveDateFrom);
            ReservGroupBox.Controls.Add(LineBar);
            ReservGroupBox.Controls.Add(panel1);
            ReservGroupBox.Controls.Add(panel2);
            ReservGroupBox.Controls.Add(AddRequestReservButton);
            ReservGroupBox.Controls.Add(CountPerson);
            ReservGroupBox.Controls.Add(label6);
            ReservGroupBox.Controls.Add(label5);
            ReservGroupBox.Controls.Add(TimePanel);
            ReservGroupBox.Controls.Add(PriceRequestLabel);


            CurrentFreeInterval = 0;
            BusyTimes.Clear();
            FreeIntervalThisDay.Clear();
            
            
        }

        private void
            AddRequestReservButton_Click(object sender, EventArgs e) //Нажатие на кнопку добавления запроса о резервации
        {
            var FromReservTime = new DateTime(ChooseReserveDateFrom.Value.Year,
                    ChooseReserveDateFrom.Value.Month,
                    ChooseReserveDateFrom.Value.Day, 12, 0, 0)
                .AddMinutes((int) ((panel1.Left + panel1.Width - LineBar.Left) * 840.0 / LineBar.Width - 1));
            var UntilReservTime = new DateTime(ChooseReserveDateFrom.Value.Year,
                    ChooseReserveDateFrom.Value.Month,
                    ChooseReserveDateFrom.Value.Day, 12, 0, 0)
                .AddMinutes((int) ((panel2.Left + -LineBar.Left) * 840.0 / LineBar.Width + 1));
            foreach (var VARIABLE in BusinessLogic.Restik.Tables)
                if (VARIABLE == BusinessLogic.SelectedTable)
                {
                    if (VARIABLE.TryAddRezerv(new TableReserveRequest(BusinessLogic.SelectedTable.Number,
                        (ushort) CountPerson.Value, FromReservTime, UntilReservTime, BusinessLogic.CurrentUsername,
                        false)))
                    {
                        goto Ok;
                    }
                    else
                    {
                        MessageBox.Show("It's day already reserved", "Error!");
                        goto End;
                    }
                }

            goto End;
            Ok:
            {
            }
            while (BusinessLogic.TryAddNewReserveRequest(FromReservTime, UntilReservTime, (int) CountPerson.Value) ==
                   false) ;
            MessageBox.Show("Succes adding", "Notification");
            End:
            {
            }
            ReservGroupBox.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            EditTable.Hide();
        }

        private void EditDeleteButton_Click(object sender, EventArgs e)
        {
            while (BusinessLogic.TryDeleteTable() == false) ;
            while (BusinessLogic.UpdateReadInfoFromXml() == false) ;
            BusinessLogic.UpdateTablePanels();
            EditTable.Hide();
        }

        private void RequestsButton_Click(object sender, EventArgs e)
        {
            PanelRequests.Show();
            ReservGroupBox.Hide();
            EditTable.Hide();
            AdminAdding.Hide();
            PanelResevation.Hide();
            AccountPanel.Hide();
        }

        private void TablesButton_Click(object sender, EventArgs e)
        {
            PanelResevation.Show();
            PanelRequests.Hide();
            AccountPanel.Hide();
        }

        public int k = 0;

        private void Update_Timer2_Elapsed(object sender, ElapsedEventArgs e)
        {
            BusinessLogic.UpdateReadInfoFromXml();

            if (BusinessLogic.UpdatedRequestPanels)
            {
                var x = BusinessLogic.NeedUpdateData;
                BusinessLogic.UpdatedRequestPanels = false;
                BusinessLogic.UpdateRequestPanels();
                var i = 0;
                PanelRequests.Controls.Clear();
                float newTotalCost = 0;
                foreach (var requestPanel in BusinessLogic.RequestPanels)
                {
                    if (requestPanel.TabIndex == 1)
                        newTotalCost += (float) requestPanel.Tag;
                    foreach (var obj in requestPanel.Controls)
                        if (obj.GetType() == typeof(Button))
                        {
                            if ((obj as Button).TabIndex == 12)
                                (obj as Button).Click += new EventHandler(AcceptRequestElement);
                            else if ((obj as Button).TabIndex == 11)
                                (obj as Button).Click += new EventHandler(DeleteRequestElement);
                        }

                    PanelRequests.Controls.Add(requestPanel);
                    requestPanel.Location = new Point(2, 10 + requestPanel.Height * i + 15 * i);
                    i++;
                }

                if ($"{string.Format("{0:0.00}", newTotalCost)}$" != CartButton.Text)
                    CartButton.Text = $"{string.Format("{0:0.00}", newTotalCost)}$";
            }
        }

        private void AcceptRequestElement(object sender, EventArgs e)
        {
            var i = 0;
            foreach (var requestPanel in BusinessLogic.RequestPanels)
            {
                if (requestPanel.Bounds.Contains(PanelRequests.PointToClient(Cursor.Position)))
                {
                    while (BusinessLogic.TryAcceptRequest(BusinessLogic.Requests[i].UsernameOwner,
                               BusinessLogic.Requests[i].ReservedTableNumber,
                               BusinessLogic.Requests[i].TimeInterval.Item1) ==
                           false) ;
                    BusinessLogic.UpdateReadInfoFromXml();
                }

                i++;
            }
        }

        private void DeleteRequestElement(object sender, EventArgs e)
        {
            var i = 0;
            foreach (var requestPanel in BusinessLogic.RequestPanels)
            {
                if (requestPanel.Bounds.Contains(PanelRequests.PointToClient(Cursor.Position)))
                {
                    while (BusinessLogic.TryDeleteRequest(BusinessLogic.Requests[i].UsernameOwner,
                               BusinessLogic.Requests[i].ReservedTableNumber,
                               BusinessLogic.Requests[i].TimeInterval.Item1) ==
                           false) ;
                    BusinessLogic.UpdateReadInfoFromXml();
                }

                i++;
            }
        }

        private void CancelTableReservButton_Click(object sender, EventArgs e)
        {
            ReservGroupBox.Hide();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            PanelEditUser.Hide();
            EnterRepitPassword.Text = "";
            AccountPanel.Show();
            PanelRequests.Hide();
            ReservGroupBox.Hide();
            EditTable.Hide();
            AdminAdding.Hide();
            PanelResevation.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var oldText = EnterRepitPassword.Text;
            EnterRepitPassword.Text = Regex.Replace(EnterRepitPassword.Text, @"[^A-Za-z01-9_]", "");
            if (EnterRepitPassword.Text != oldText)
            {
                EnterRepitPassword.SelectionStart = EnterRepitPassword.Text.Length;
                EnterRepitPassword.SelectionLength = 0;
            }
        }

        private void EditCheakButton_Click(object sender, EventArgs e)
        {
            foreach (var user in BusinessLogic.Users)
                if (user.IsThisUsername(BusinessLogic.CurrentUsername))
                {
                    if (!user.IsThisPassword(EnterRepitPassword.Text))
                    {
                        MessageBox.Show("Wrong password!!!", "Error!");
                        Close();
                    }
                    else
                    {
                        PanelEditUser.Show();
                        EditEnterPassword.Text = BusinessLogic.CurrentPassword;
                        EditEnterPhone.Text = user.getPhoneNumber(BusinessLogic.CurrentPassword);
                        EditEnterEmail.Text = user.getEmail(BusinessLogic.CurrentPassword);
                        EditEnterRealName.Text = user.getRealName(BusinessLogic.CurrentPassword);
                    }
                }
        }

        private void EditEnterPassword_TextChanged(object sender, EventArgs e)
        {
            var oldText = EditEnterPassword.Text;
            EditEnterPassword.Text = Regex.Replace(EditEnterPassword.Text, @"[^A-Za-z01-9_]", "");
            if (EditEnterPassword.Text != oldText)
            {
                EditEnterPassword.SelectionStart = EditEnterPassword.Text.Length;
                EditEnterPassword.SelectionLength = 0;
            }
        }

        private void EditUserSaveButton_Click(object sender, EventArgs e)
        {
            string curPhone = "", curEmail = "", curRealName = "";
            foreach (var user in BusinessLogic.Users)
                if (user.IsThisUsername(BusinessLogic.CurrentUsername))
                {
                    if (EditEnterPassword.Text == "")
                    {
                        EditLabelPassword.ForeColor = Color.Red;
                        MessageBox.Show("you left the \"Username\" field empty", "Error!");
                        EditEnterPassword.Text = BusinessLogic.CurrentPassword;
                        goto End;
                    }
                    else if (EditEnterPhone.Text == "")
                    {
                        EditLabelPhone.ForeColor = Color.Red;
                        MessageBox.Show("you left the \"Phone number\" field empty", "Error!");
                        EditEnterPhone.Text = curPhone;
                        goto End;
                    }
                    else if (EditEnterEmail.Text == "")
                    {
                        EditLabelEmail.ForeColor = Color.Red;
                        MessageBox.Show("you left the \"E-Mail\" field empty", "Error!");
                        EditEnterEmail.Text = curEmail;
                        goto End;
                    }
                    else if (EditEnterRealName.Text == "")
                    {
                        EditLabelRealName.ForeColor = Color.Red;
                        MessageBox.Show("you left the \"Real Name\" field empty", "Error!");
                        EditEnterRealName.Text = curRealName;
                        goto End;
                    }
                    else if (!BusinessLogic.ValidatePhone(EditEnterPhone.Text))
                    {
                        EditLabelPhone.ForeColor = Color.Red;
                        MessageBox.Show("Incorrect mobile phone number", "Error!");
                        EditEnterPhone.Text = curPhone;

                        goto End;
                    }
                    else if (!BusinessLogic.ValidateEmail(EditEnterEmail.Text))
                    {
                        EditLabelEmail.ForeColor = Color.Red;
                        MessageBox.Show("Incorrect E-mail", "Error!");
                        EditEnterEmail.Text = curEmail;

                        goto End;
                    }

                    BusinessLogic.CurrentPassword = EditEnterPassword.Text;
                    while (BusinessLogic.TryUpdateUser(BusinessLogic.CurrentUsername, EditEnterPhone.Text,
                        BusinessLogic.CurrentPassword, EditEnterEmail.Text, EditEnterRealName.Text) == false) ;
                    while (BusinessLogic.UpdateReadInfoFromXml() == false) ;
                    MessageBox.Show("Success!!", "Notification");
                    AccountPanel.Hide();
                    break;
                }


            End:
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}