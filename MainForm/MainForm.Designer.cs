using System.ComponentModel;

namespace CourseWork.MainForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TablesButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.CartButton = new System.Windows.Forms.Button();
            this.TableList = new System.Windows.Forms.Panel();
            this.AdminButton = new System.Windows.Forms.Button();
            this.LineBar = new System.Windows.Forms.Panel();
            this.ReservGroupBox = new System.Windows.Forms.GroupBox();
            this.PriceRequestLabel = new System.Windows.Forms.Label();
            this.TimePanel = new System.Windows.Forms.Panel();
            this.LabelUntilTime = new System.Windows.Forms.Label();
            this.LabelFromTime = new System.Windows.Forms.Label();
            this.CancelTableReservButton = new System.Windows.Forms.Button();
            this.AddRequestReservButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ChooseReserveDateFrom = new System.Windows.Forms.DateTimePicker();
            this.CountPerson = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Timers.Timer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdminAdding = new System.Windows.Forms.GroupBox();
            this.CancelAdd = new System.Windows.Forms.Button();
            this.LabelFileName = new System.Windows.Forms.Label();
            this.LabelCapacity = new System.Windows.Forms.Label();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FileName_source = new System.Windows.Forms.TextBox();
            this.ChooseCapacity = new System.Windows.Forms.NumericUpDown();
            this.ChooseNumber = new System.Windows.Forms.NumericUpDown();
            this.AddTable = new System.Windows.Forms.Button();
            this.Update_timer = new System.Timers.Timer();
            this.imageScroll = new System.Windows.Forms.Panel();
            this.ZoomOutButton = new System.Windows.Forms.Button();
            this.ZoomInButton = new System.Windows.Forms.Button();
            this.EditTable = new System.Windows.Forms.GroupBox();
            this.EditSaveButton = new System.Windows.Forms.Button();
            this.EditCancelButton = new System.Windows.Forms.Button();
            this.LabelEditFileName = new System.Windows.Forms.Label();
            this.LabelEditChooseCapacity = new System.Windows.Forms.Label();
            this.LabelEditChooseNumber = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.EditEnterFileName = new System.Windows.Forms.TextBox();
            this.EditChooseCapacity = new System.Windows.Forms.NumericUpDown();
            this.EditChooseNumber = new System.Windows.Forms.NumericUpDown();
            this.EditDeleteButton = new System.Windows.Forms.Button();
            this.RequestsButton = new System.Windows.Forms.Button();
            this.PanelRequests = new System.Windows.Forms.Panel();
            this.PanelResevation = new System.Windows.Forms.Panel();
            this.Update_Timer2 = new System.Timers.Timer();
            this.AccountPanel = new System.Windows.Forms.Panel();
            this.EditCheakButton = new System.Windows.Forms.Button();
            this.PanelEditUser = new System.Windows.Forms.Panel();
            this.EditUserSaveButton = new System.Windows.Forms.Button();
            this.EditLabelRealName = new System.Windows.Forms.Label();
            this.EditLabelEmail = new System.Windows.Forms.Label();
            this.EditLabelPhone = new System.Windows.Forms.Label();
            this.EditLabelPassword = new System.Windows.Forms.Label();
            this.EditEnterRealName = new System.Windows.Forms.TextBox();
            this.EditEnterEmail = new System.Windows.Forms.TextBox();
            this.EditEnterPhone = new System.Windows.Forms.TextBox();
            this.EditEnterPassword = new System.Windows.Forms.TextBox();
            this.EnterRepitPassword = new System.Windows.Forms.TextBox();
            this.LabelRepitPassword = new System.Windows.Forms.Label();
            this.TableList.SuspendLayout();
            this.ReservGroupBox.SuspendLayout();
            this.TimePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.CountPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.AdminAdding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.ChooseCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ChooseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Update_timer)).BeginInit();
            this.imageScroll.SuspendLayout();
            this.EditTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.EditChooseCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.EditChooseNumber)).BeginInit();
            this.PanelResevation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.Update_Timer2)).BeginInit();
            this.AccountPanel.SuspendLayout();
            this.PanelEditUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablesButton
            // 
            this.TablesButton.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold);
            this.TablesButton.Location = new System.Drawing.Point(8, 15);
            this.TablesButton.Name = "TablesButton";
            this.TablesButton.Size = new System.Drawing.Size(322, 53);
            this.TablesButton.TabIndex = 1;
            this.TablesButton.Text = "Table reservations";
            this.TablesButton.UseVisualStyleBackColor = true;
            this.TablesButton.Click += new System.EventHandler(this.TablesButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold);
            this.AccountButton.Location = new System.Drawing.Point(643, 13);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(156, 56);
            this.AccountButton.TabIndex = 2;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // CartButton
            // 
            this.CartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CartButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.CartButton.Image = ((System.Drawing.Image) (resources.GetObject("CartButton.Image")));
            this.CartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CartButton.Location = new System.Drawing.Point(805, 12);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(162, 56);
            this.CartButton.TabIndex = 3;
            this.CartButton.Text = "0$";
            this.CartButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CartButton.UseVisualStyleBackColor = true;
            // 
            // TableList
            // 
            this.TableList.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.TableList.AutoScroll = true;
            this.TableList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableList.Controls.Add(this.AdminButton);
            this.TableList.Location = new System.Drawing.Point(3, 3);
            this.TableList.Name = "TableList";
            this.TableList.Size = new System.Drawing.Size(235, 554);
            this.TableList.TabIndex = 4;
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.AdminButton.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold);
            this.AdminButton.Location = new System.Drawing.Point(3, 442);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(219, 73);
            this.AdminButton.TabIndex = 7;
            this.AdminButton.Text = "+Add new table";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Visible = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // LineBar
            // 
            this.LineBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LineBar.Location = new System.Drawing.Point(42, 219);
            this.LineBar.Name = "LineBar";
            this.LineBar.Size = new System.Drawing.Size(398, 6);
            this.LineBar.TabIndex = 6;
            // 
            // ReservGroupBox
            // 
            this.ReservGroupBox.Controls.Add(this.PriceRequestLabel);
            this.ReservGroupBox.Controls.Add(this.TimePanel);
            this.ReservGroupBox.Controls.Add(this.CancelTableReservButton);
            this.ReservGroupBox.Controls.Add(this.AddRequestReservButton);
            this.ReservGroupBox.Controls.Add(this.label6);
            this.ReservGroupBox.Controls.Add(this.label5);
            this.ReservGroupBox.Controls.Add(this.panel2);
            this.ReservGroupBox.Controls.Add(this.panel1);
            this.ReservGroupBox.Controls.Add(this.ChooseReserveDateFrom);
            this.ReservGroupBox.Controls.Add(this.LineBar);
            this.ReservGroupBox.Controls.Add(this.CountPerson);
            this.ReservGroupBox.Controls.Add(this.label1);
            this.ReservGroupBox.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ReservGroupBox.Location = new System.Drawing.Point(258, 161);
            this.ReservGroupBox.Name = "ReservGroupBox";
            this.ReservGroupBox.Size = new System.Drawing.Size(493, 322);
            this.ReservGroupBox.TabIndex = 9;
            this.ReservGroupBox.TabStop = false;
            this.ReservGroupBox.Text = "Table Reservation";
            this.ReservGroupBox.Visible = false;
            this.ReservGroupBox.VisibleChanged += new System.EventHandler(this.ReservGroupBox_VisibleChanged);
            // 
            // PriceRequestLabel
            // 
            this.PriceRequestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceRequestLabel.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.PriceRequestLabel.Location = new System.Drawing.Point(364, 36);
            this.PriceRequestLabel.Name = "PriceRequestLabel";
            this.PriceRequestLabel.Size = new System.Drawing.Size(115, 60);
            this.PriceRequestLabel.TabIndex = 19;
            this.PriceRequestLabel.Text = "Price: ";
            this.PriceRequestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimePanel
            // 
            this.TimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimePanel.Controls.Add(this.LabelUntilTime);
            this.TimePanel.Controls.Add(this.LabelFromTime);
            this.TimePanel.Location = new System.Drawing.Point(24, 36);
            this.TimePanel.Name = "TimePanel";
            this.TimePanel.Size = new System.Drawing.Size(334, 61);
            this.TimePanel.TabIndex = 18;
            // 
            // LabelUntilTime
            // 
            this.LabelUntilTime.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LabelUntilTime.Location = new System.Drawing.Point(169, -1);
            this.LabelUntilTime.Name = "LabelUntilTime";
            this.LabelUntilTime.Size = new System.Drawing.Size(164, 61);
            this.LabelUntilTime.TabIndex = 19;
            this.LabelUntilTime.Text = "Until";
            this.LabelUntilTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelFromTime
            // 
            this.LabelFromTime.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LabelFromTime.Location = new System.Drawing.Point(-1, -1);
            this.LabelFromTime.Name = "LabelFromTime";
            this.LabelFromTime.Size = new System.Drawing.Size(164, 60);
            this.LabelFromTime.TabIndex = 18;
            this.LabelFromTime.Text = "From";
            this.LabelFromTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CancelTableReservButton
            // 
            this.CancelTableReservButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (128)))));
            this.CancelTableReservButton.Location = new System.Drawing.Point(24, 266);
            this.CancelTableReservButton.Name = "CancelTableReservButton";
            this.CancelTableReservButton.Size = new System.Drawing.Size(175, 45);
            this.CancelTableReservButton.TabIndex = 17;
            this.CancelTableReservButton.Text = "Cancel";
            this.CancelTableReservButton.UseVisualStyleBackColor = false;
            this.CancelTableReservButton.Click += new System.EventHandler(this.CancelTableReservButton_Click);
            // 
            // AddRequestReservButton
            // 
            this.AddRequestReservButton.Location = new System.Drawing.Point(205, 266);
            this.AddRequestReservButton.Name = "AddRequestReservButton";
            this.AddRequestReservButton.Size = new System.Drawing.Size(256, 45);
            this.AddRequestReservButton.TabIndex = 16;
            this.AddRequestReservButton.Text = "Send Reserve Request";
            this.AddRequestReservButton.UseVisualStyleBackColor = true;
            this.AddRequestReservButton.Click += new System.EventHandler(this.AddRequestReservButton_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(157, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "<-- Date of reservation";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(321, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Count of Person";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(256, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(42, 59);
            this.panel2.TabIndex = 13;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(1, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 56);
            this.panel4.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)), true);
            this.label8.Location = new System.Drawing.Point(1, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "end";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(80, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(41, 59);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(37, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 56);
            this.panel3.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)), true);
            this.label7.Location = new System.Drawing.Point(5, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "begin";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChooseReserveDateFrom
            // 
            this.ChooseReserveDateFrom.CustomFormat = " MM.ddd.yyyy";
            this.ChooseReserveDateFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.ChooseReserveDateFrom.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold);
            this.ChooseReserveDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ChooseReserveDateFrom.Location = new System.Drawing.Point(24, 125);
            this.ChooseReserveDateFrom.MaxDate = new System.DateTime(2022, 12, 20, 0, 0, 0, 0);
            this.ChooseReserveDateFrom.MinDate = new System.DateTime(2021, 12, 16, 0, 0, 0, 0);
            this.ChooseReserveDateFrom.Name = "ChooseReserveDateFrom";
            this.ChooseReserveDateFrom.Size = new System.Drawing.Size(127, 29);
            this.ChooseReserveDateFrom.TabIndex = 11;
            this.ChooseReserveDateFrom.ValueChanged += new System.EventHandler(this.ChooseReserveDateFrom_ValueChanged);
            // 
            // CountPerson
            // 
            this.CountPerson.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold);
            this.CountPerson.Location = new System.Drawing.Point(374, 125);
            this.CountPerson.Maximum = new decimal(new int[] {12, 0, 0, 0});
            this.CountPerson.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.CountPerson.Name = "CountPerson";
            this.CountPerson.Size = new System.Drawing.Size(51, 29);
            this.CountPerson.TabIndex = 10;
            this.CountPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CountPerson.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 9;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 20D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(688, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // AdminAdding
            // 
            this.AdminAdding.Controls.Add(this.CancelAdd);
            this.AdminAdding.Controls.Add(this.LabelFileName);
            this.AdminAdding.Controls.Add(this.LabelCapacity);
            this.AdminAdding.Controls.Add(this.LabelNumber);
            this.AdminAdding.Controls.Add(this.label4);
            this.AdminAdding.Controls.Add(this.label3);
            this.AdminAdding.Controls.Add(this.label2);
            this.AdminAdding.Controls.Add(this.FileName_source);
            this.AdminAdding.Controls.Add(this.ChooseCapacity);
            this.AdminAdding.Controls.Add(this.ChooseNumber);
            this.AdminAdding.Controls.Add(this.AddTable);
            this.AdminAdding.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.AdminAdding.Location = new System.Drawing.Point(351, 115);
            this.AdminAdding.Name = "AdminAdding";
            this.AdminAdding.Size = new System.Drawing.Size(450, 265);
            this.AdminAdding.TabIndex = 11;
            this.AdminAdding.TabStop = false;
            this.AdminAdding.Text = "Adding Table";
            this.AdminAdding.Visible = false;
            this.AdminAdding.VisibleChanged += new System.EventHandler(this.AdminAdding_VisibleChanged);
            // 
            // CancelAdd
            // 
            this.CancelAdd.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (128)))));
            this.CancelAdd.Location = new System.Drawing.Point(59, 191);
            this.CancelAdd.Name = "CancelAdd";
            this.CancelAdd.Size = new System.Drawing.Size(135, 58);
            this.CancelAdd.TabIndex = 10;
            this.CancelAdd.Text = "Cancel";
            this.CancelAdd.UseVisualStyleBackColor = false;
            this.CancelAdd.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // LabelFileName
            // 
            this.LabelFileName.Location = new System.Drawing.Point(64, 102);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(354, 28);
            this.LabelFileName.TabIndex = 9;
            this.LabelFileName.Text = "FileName image in Resource folder";
            this.LabelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCapacity
            // 
            this.LabelCapacity.Location = new System.Drawing.Point(256, 31);
            this.LabelCapacity.Name = "LabelCapacity";
            this.LabelCapacity.Size = new System.Drawing.Size(201, 28);
            this.LabelCapacity.TabIndex = 8;
            this.LabelCapacity.Text = "Capacity Persons";
            this.LabelCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelNumber
            // 
            this.LabelNumber.Location = new System.Drawing.Point(50, 31);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(132, 28);
            this.LabelNumber.TabIndex = 7;
            this.LabelNumber.Text = "Number";
            this.LabelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(50, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 34);
            this.label4.TabIndex = 6;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(269, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 34);
            this.label3.TabIndex = 5;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(53, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 34);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileName_source
            // 
            this.FileName_source.Location = new System.Drawing.Point(59, 133);
            this.FileName_source.Name = "FileName_source";
            this.FileName_source.Size = new System.Drawing.Size(354, 33);
            this.FileName_source.TabIndex = 3;
            // 
            // ChooseCapacity
            // 
            this.ChooseCapacity.Location = new System.Drawing.Point(297, 59);
            this.ChooseCapacity.Name = "ChooseCapacity";
            this.ChooseCapacity.Size = new System.Drawing.Size(116, 33);
            this.ChooseCapacity.TabIndex = 2;
            // 
            // ChooseNumber
            // 
            this.ChooseNumber.Location = new System.Drawing.Point(59, 59);
            this.ChooseNumber.Name = "ChooseNumber";
            this.ChooseNumber.Size = new System.Drawing.Size(116, 33);
            this.ChooseNumber.TabIndex = 1;
            // 
            // AddTable
            // 
            this.AddTable.Location = new System.Drawing.Point(200, 191);
            this.AddTable.Name = "AddTable";
            this.AddTable.Size = new System.Drawing.Size(213, 58);
            this.AddTable.TabIndex = 0;
            this.AddTable.Text = "Cheak data and add";
            this.AddTable.UseVisualStyleBackColor = true;
            this.AddTable.Click += new System.EventHandler(this.button5_Click);
            // 
            // Update_timer
            // 
            this.Update_timer.Interval = 300D;
            this.Update_timer.SynchronizingObject = this;
            this.Update_timer.Elapsed += new System.Timers.ElapsedEventHandler(this.Update_timer_Elapsed);
            // 
            // imageScroll
            // 
            this.imageScroll.AutoScroll = true;
            this.imageScroll.Controls.Add(this.pictureBox1);
            this.imageScroll.Location = new System.Drawing.Point(246, 3);
            this.imageScroll.Name = "imageScroll";
            this.imageScroll.Size = new System.Drawing.Size(710, 503);
            this.imageScroll.TabIndex = 12;
            // 
            // ZoomOutButton
            // 
            this.ZoomOutButton.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold);
            this.ZoomOutButton.Location = new System.Drawing.Point(246, 512);
            this.ZoomOutButton.Name = "ZoomOutButton";
            this.ZoomOutButton.Size = new System.Drawing.Size(239, 45);
            this.ZoomOutButton.TabIndex = 13;
            this.ZoomOutButton.Text = "-Zoom out";
            this.ZoomOutButton.UseVisualStyleBackColor = true;
            this.ZoomOutButton.Click += new System.EventHandler(this.ZoomOutButton_Click);
            // 
            // ZoomInButton
            // 
            this.ZoomInButton.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold);
            this.ZoomInButton.Location = new System.Drawing.Point(687, 512);
            this.ZoomInButton.Name = "ZoomInButton";
            this.ZoomInButton.Size = new System.Drawing.Size(239, 45);
            this.ZoomInButton.TabIndex = 14;
            this.ZoomInButton.Text = "Zoom in+";
            this.ZoomInButton.UseVisualStyleBackColor = true;
            this.ZoomInButton.Click += new System.EventHandler(this.button6_Click_2);
            // 
            // EditTable
            // 
            this.EditTable.Controls.Add(this.EditSaveButton);
            this.EditTable.Controls.Add(this.EditCancelButton);
            this.EditTable.Controls.Add(this.LabelEditFileName);
            this.EditTable.Controls.Add(this.LabelEditChooseCapacity);
            this.EditTable.Controls.Add(this.LabelEditChooseNumber);
            this.EditTable.Controls.Add(this.label12);
            this.EditTable.Controls.Add(this.label13);
            this.EditTable.Controls.Add(this.label14);
            this.EditTable.Controls.Add(this.EditEnterFileName);
            this.EditTable.Controls.Add(this.EditChooseCapacity);
            this.EditTable.Controls.Add(this.EditChooseNumber);
            this.EditTable.Controls.Add(this.EditDeleteButton);
            this.EditTable.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.EditTable.Location = new System.Drawing.Point(338, 99);
            this.EditTable.Name = "EditTable";
            this.EditTable.Size = new System.Drawing.Size(450, 265);
            this.EditTable.TabIndex = 12;
            this.EditTable.TabStop = false;
            this.EditTable.Text = "Edit Table";
            this.EditTable.Visible = false;
            // 
            // EditSaveButton
            // 
            this.EditSaveButton.Location = new System.Drawing.Point(277, 190);
            this.EditSaveButton.Name = "EditSaveButton";
            this.EditSaveButton.Size = new System.Drawing.Size(167, 58);
            this.EditSaveButton.TabIndex = 11;
            this.EditSaveButton.Text = "Save edit";
            this.EditSaveButton.UseVisualStyleBackColor = true;
            // 
            // EditCancelButton
            // 
            this.EditCancelButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (128)))));
            this.EditCancelButton.Location = new System.Drawing.Point(7, 190);
            this.EditCancelButton.Name = "EditCancelButton";
            this.EditCancelButton.Size = new System.Drawing.Size(135, 58);
            this.EditCancelButton.TabIndex = 10;
            this.EditCancelButton.Text = "Cancel";
            this.EditCancelButton.UseVisualStyleBackColor = false;
            this.EditCancelButton.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // LabelEditFileName
            // 
            this.LabelEditFileName.Location = new System.Drawing.Point(64, 102);
            this.LabelEditFileName.Name = "LabelEditFileName";
            this.LabelEditFileName.Size = new System.Drawing.Size(354, 28);
            this.LabelEditFileName.TabIndex = 9;
            this.LabelEditFileName.Text = "FileName image in Resource folder*";
            this.LabelEditFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelEditChooseCapacity
            // 
            this.LabelEditChooseCapacity.Location = new System.Drawing.Point(256, 31);
            this.LabelEditChooseCapacity.Name = "LabelEditChooseCapacity";
            this.LabelEditChooseCapacity.Size = new System.Drawing.Size(201, 28);
            this.LabelEditChooseCapacity.TabIndex = 8;
            this.LabelEditChooseCapacity.Text = "Capacity Persons";
            this.LabelEditChooseCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelEditChooseNumber
            // 
            this.LabelEditChooseNumber.Location = new System.Drawing.Point(50, 31);
            this.LabelEditChooseNumber.Name = "LabelEditChooseNumber";
            this.LabelEditChooseNumber.Size = new System.Drawing.Size(132, 28);
            this.LabelEditChooseNumber.TabIndex = 7;
            this.LabelEditChooseNumber.Text = "Number*";
            this.LabelEditChooseNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(50, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(354, 34);
            this.label12.TabIndex = 6;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(269, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 34);
            this.label13.TabIndex = 5;
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(53, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 34);
            this.label14.TabIndex = 4;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditEnterFileName
            // 
            this.EditEnterFileName.Location = new System.Drawing.Point(59, 133);
            this.EditEnterFileName.Name = "EditEnterFileName";
            this.EditEnterFileName.Size = new System.Drawing.Size(354, 33);
            this.EditEnterFileName.TabIndex = 3;
            // 
            // EditChooseCapacity
            // 
            this.EditChooseCapacity.Location = new System.Drawing.Point(297, 59);
            this.EditChooseCapacity.Name = "EditChooseCapacity";
            this.EditChooseCapacity.Size = new System.Drawing.Size(116, 33);
            this.EditChooseCapacity.TabIndex = 2;
            // 
            // EditChooseNumber
            // 
            this.EditChooseNumber.Location = new System.Drawing.Point(59, 59);
            this.EditChooseNumber.Name = "EditChooseNumber";
            this.EditChooseNumber.Size = new System.Drawing.Size(116, 33);
            this.EditChooseNumber.TabIndex = 1;
            // 
            // EditDeleteButton
            // 
            this.EditDeleteButton.Location = new System.Drawing.Point(148, 190);
            this.EditDeleteButton.Name = "EditDeleteButton";
            this.EditDeleteButton.Size = new System.Drawing.Size(123, 58);
            this.EditDeleteButton.TabIndex = 0;
            this.EditDeleteButton.Text = "Delete";
            this.EditDeleteButton.UseVisualStyleBackColor = true;
            this.EditDeleteButton.Click += new System.EventHandler(this.EditDeleteButton_Click);
            // 
            // RequestsButton
            // 
            this.RequestsButton.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold);
            this.RequestsButton.Location = new System.Drawing.Point(336, 15);
            this.RequestsButton.Name = "RequestsButton";
            this.RequestsButton.Size = new System.Drawing.Size(200, 54);
            this.RequestsButton.TabIndex = 15;
            this.RequestsButton.Text = "Requests";
            this.RequestsButton.UseVisualStyleBackColor = true;
            this.RequestsButton.Click += new System.EventHandler(this.RequestsButton_Click);
            // 
            // PanelRequests
            // 
            this.PanelRequests.AutoScroll = true;
            this.PanelRequests.Location = new System.Drawing.Point(98, 70);
            this.PanelRequests.Name = "PanelRequests";
            this.PanelRequests.Size = new System.Drawing.Size(774, 580);
            this.PanelRequests.TabIndex = 16;
            this.PanelRequests.Visible = false;
            // 
            // PanelResevation
            // 
            this.PanelResevation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelResevation.Controls.Add(this.TableList);
            this.PanelResevation.Controls.Add(this.ReservGroupBox);
            this.PanelResevation.Controls.Add(this.EditTable);
            this.PanelResevation.Controls.Add(this.imageScroll);
            this.PanelResevation.Controls.Add(this.ZoomOutButton);
            this.PanelResevation.Controls.Add(this.ZoomInButton);
            this.PanelResevation.Controls.Add(this.AdminAdding);
            this.PanelResevation.Location = new System.Drawing.Point(8, 75);
            this.PanelResevation.Name = "PanelResevation";
            this.PanelResevation.Size = new System.Drawing.Size(959, 572);
            this.PanelResevation.TabIndex = 17;
            this.PanelResevation.Visible = false;
            // 
            // Update_Timer2
            // 
            this.Update_Timer2.Interval = 500D;
            this.Update_Timer2.SynchronizingObject = this;
            this.Update_Timer2.Elapsed += new System.Timers.ElapsedEventHandler(this.Update_Timer2_Elapsed);
            // 
            // AccountPanel
            // 
            this.AccountPanel.AutoScroll = true;
            this.AccountPanel.BackColor = System.Drawing.Color.White;
            this.AccountPanel.Controls.Add(this.EditCheakButton);
            this.AccountPanel.Controls.Add(this.PanelEditUser);
            this.AccountPanel.Controls.Add(this.EnterRepitPassword);
            this.AccountPanel.Controls.Add(this.LabelRepitPassword);
            this.AccountPanel.Location = new System.Drawing.Point(89, 70);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Size = new System.Drawing.Size(800, 580);
            this.AccountPanel.TabIndex = 16;
            this.AccountPanel.Visible = false;
            // 
            // EditCheakButton
            // 
            this.EditCheakButton.Font = new System.Drawing.Font("MV Boli", 17F, System.Drawing.FontStyle.Bold);
            this.EditCheakButton.Location = new System.Drawing.Point(644, 70);
            this.EditCheakButton.Name = "EditCheakButton";
            this.EditCheakButton.Size = new System.Drawing.Size(119, 47);
            this.EditCheakButton.TabIndex = 4;
            this.EditCheakButton.Text = "Check";
            this.EditCheakButton.UseVisualStyleBackColor = true;
            this.EditCheakButton.Click += new System.EventHandler(this.EditCheakButton_Click);
            // 
            // PanelEditUser
            // 
            this.PanelEditUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelEditUser.Controls.Add(this.EditUserSaveButton);
            this.PanelEditUser.Controls.Add(this.EditLabelRealName);
            this.PanelEditUser.Controls.Add(this.EditLabelEmail);
            this.PanelEditUser.Controls.Add(this.EditLabelPhone);
            this.PanelEditUser.Controls.Add(this.EditLabelPassword);
            this.PanelEditUser.Controls.Add(this.EditEnterRealName);
            this.PanelEditUser.Controls.Add(this.EditEnterEmail);
            this.PanelEditUser.Controls.Add(this.EditEnterPhone);
            this.PanelEditUser.Controls.Add(this.EditEnterPassword);
            this.PanelEditUser.Location = new System.Drawing.Point(56, 124);
            this.PanelEditUser.Name = "PanelEditUser";
            this.PanelEditUser.Size = new System.Drawing.Size(708, 438);
            this.PanelEditUser.TabIndex = 3;
            this.PanelEditUser.Visible = false;
            // 
            // EditUserSaveButton
            // 
            this.EditUserSaveButton.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Bold);
            this.EditUserSaveButton.Location = new System.Drawing.Point(236, 357);
            this.EditUserSaveButton.Name = "EditUserSaveButton";
            this.EditUserSaveButton.Size = new System.Drawing.Size(196, 63);
            this.EditUserSaveButton.TabIndex = 12;
            this.EditUserSaveButton.Text = "Save";
            this.EditUserSaveButton.UseVisualStyleBackColor = true;
            this.EditUserSaveButton.Click += new System.EventHandler(this.EditUserSaveButton_Click);
            // 
            // EditLabelRealName
            // 
            this.EditLabelRealName.Font = new System.Drawing.Font("MV Boli", 17F, System.Drawing.FontStyle.Bold);
            this.EditLabelRealName.Location = new System.Drawing.Point(109, 267);
            this.EditLabelRealName.Name = "EditLabelRealName";
            this.EditLabelRealName.Size = new System.Drawing.Size(471, 27);
            this.EditLabelRealName.TabIndex = 11;
            this.EditLabelRealName.Text = "Real Name";
            this.EditLabelRealName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditLabelEmail
            // 
            this.EditLabelEmail.Font = new System.Drawing.Font("MV Boli", 17F, System.Drawing.FontStyle.Bold);
            this.EditLabelEmail.Location = new System.Drawing.Point(112, 180);
            this.EditLabelEmail.Name = "EditLabelEmail";
            this.EditLabelEmail.Size = new System.Drawing.Size(471, 36);
            this.EditLabelEmail.TabIndex = 10;
            this.EditLabelEmail.Text = "E-Mail";
            this.EditLabelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditLabelPhone
            // 
            this.EditLabelPhone.Font = new System.Drawing.Font("MV Boli", 17F, System.Drawing.FontStyle.Bold);
            this.EditLabelPhone.Location = new System.Drawing.Point(110, 93);
            this.EditLabelPhone.Name = "EditLabelPhone";
            this.EditLabelPhone.Size = new System.Drawing.Size(471, 36);
            this.EditLabelPhone.TabIndex = 9;
            this.EditLabelPhone.Text = "Phone Number";
            this.EditLabelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditLabelPassword
            // 
            this.EditLabelPassword.Font = new System.Drawing.Font("MV Boli", 17F, System.Drawing.FontStyle.Bold);
            this.EditLabelPassword.Location = new System.Drawing.Point(109, 3);
            this.EditLabelPassword.Name = "EditLabelPassword";
            this.EditLabelPassword.Size = new System.Drawing.Size(471, 36);
            this.EditLabelPassword.TabIndex = 8;
            this.EditLabelPassword.Text = "Password";
            this.EditLabelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditEnterRealName
            // 
            this.EditEnterRealName.Font = new System.Drawing.Font("MV Boli", 19F, System.Drawing.FontStyle.Bold);
            this.EditEnterRealName.Location = new System.Drawing.Point(109, 297);
            this.EditEnterRealName.MaxLength = 15;
            this.EditEnterRealName.Name = "EditEnterRealName";
            this.EditEnterRealName.Size = new System.Drawing.Size(472, 48);
            this.EditEnterRealName.TabIndex = 7;
            this.EditEnterRealName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditEnterEmail
            // 
            this.EditEnterEmail.Font = new System.Drawing.Font("MV Boli", 19F, System.Drawing.FontStyle.Bold);
            this.EditEnterEmail.Location = new System.Drawing.Point(109, 216);
            this.EditEnterEmail.MaxLength = 15;
            this.EditEnterEmail.Name = "EditEnterEmail";
            this.EditEnterEmail.Size = new System.Drawing.Size(472, 48);
            this.EditEnterEmail.TabIndex = 6;
            this.EditEnterEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditEnterPhone
            // 
            this.EditEnterPhone.Font = new System.Drawing.Font("MV Boli", 19F, System.Drawing.FontStyle.Bold);
            this.EditEnterPhone.Location = new System.Drawing.Point(109, 129);
            this.EditEnterPhone.MaxLength = 15;
            this.EditEnterPhone.Name = "EditEnterPhone";
            this.EditEnterPhone.Size = new System.Drawing.Size(472, 48);
            this.EditEnterPhone.TabIndex = 5;
            this.EditEnterPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditEnterPassword
            // 
            this.EditEnterPassword.Font = new System.Drawing.Font("MV Boli", 19F, System.Drawing.FontStyle.Bold);
            this.EditEnterPassword.Location = new System.Drawing.Point(109, 40);
            this.EditEnterPassword.MaxLength = 15;
            this.EditEnterPassword.Name = "EditEnterPassword";
            this.EditEnterPassword.Size = new System.Drawing.Size(472, 48);
            this.EditEnterPassword.TabIndex = 4;
            this.EditEnterPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EditEnterPassword.TextChanged += new System.EventHandler(this.EditEnterPassword_TextChanged);
            // 
            // EnterRepitPassword
            // 
            this.EnterRepitPassword.Font = new System.Drawing.Font("MV Boli", 19F, System.Drawing.FontStyle.Bold);
            this.EnterRepitPassword.Location = new System.Drawing.Point(166, 70);
            this.EnterRepitPassword.MaxLength = 15;
            this.EnterRepitPassword.Name = "EnterRepitPassword";
            this.EnterRepitPassword.PasswordChar = '*';
            this.EnterRepitPassword.Size = new System.Drawing.Size(472, 48);
            this.EnterRepitPassword.TabIndex = 2;
            this.EnterRepitPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EnterRepitPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelRepitPassword
            // 
            this.LabelRepitPassword.Font = new System.Drawing.Font("MV Boli", 17F, System.Drawing.FontStyle.Bold);
            this.LabelRepitPassword.Location = new System.Drawing.Point(71, 5);
            this.LabelRepitPassword.Name = "LabelRepitPassword";
            this.LabelRepitPassword.Size = new System.Drawing.Size(656, 82);
            this.LabelRepitPassword.TabIndex = 1;
            this.LabelRepitPassword.Text = "Enter the password to change your personal data";
            this.LabelRepitPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CourseWork.Properties.Resources.Sirocco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(979, 681);
            this.Controls.Add(this.PanelResevation);
            this.Controls.Add(this.AccountPanel);
            this.Controls.Add(this.PanelRequests);
            this.Controls.Add(this.RequestsButton);
            this.Controls.Add(this.CartButton);
            this.Controls.Add(this.AccountButton);
            this.Controls.Add(this.TablesButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TableList.ResumeLayout(false);
            this.ReservGroupBox.ResumeLayout(false);
            this.TimePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.CountPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.AdminAdding.ResumeLayout(false);
            this.AdminAdding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.ChooseCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ChooseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Update_timer)).EndInit();
            this.imageScroll.ResumeLayout(false);
            this.EditTable.ResumeLayout(false);
            this.EditTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.EditChooseCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.EditChooseNumber)).EndInit();
            this.PanelResevation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.Update_Timer2)).EndInit();
            this.AccountPanel.ResumeLayout(false);
            this.AccountPanel.PerformLayout();
            this.PanelEditUser.ResumeLayout(false);
            this.PanelEditUser.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label PriceRequestLabel;

        private System.Windows.Forms.Button EditCheakButton;

        private System.Windows.Forms.Button EditUserSaveButton;

        private System.Windows.Forms.TextBox EditEnterEmail;
        private System.Windows.Forms.TextBox EditEnterPassword;
        private System.Windows.Forms.TextBox EditEnterPhone;
        private System.Windows.Forms.TextBox EditEnterRealName;
        private System.Windows.Forms.Label EditLabelEmail;
        private System.Windows.Forms.Label EditLabelPassword;
        private System.Windows.Forms.Label EditLabelPhone;
        private System.Windows.Forms.Label EditLabelRealName;
        private System.Windows.Forms.Panel PanelEditUser;

        private System.Windows.Forms.TextBox EnterRepitPassword;
        private System.Windows.Forms.Label LabelRepitPassword;

        private System.Windows.Forms.Panel AccountPanel;

        private System.Timers.Timer Update_Timer2;

        private System.Windows.Forms.Panel PanelResevation;

        private System.Windows.Forms.Panel PanelRequests;

        private System.Windows.Forms.Button RequestsButton;

        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button CartButton;
        private System.Windows.Forms.Button TablesButton;

        private System.Windows.Forms.Panel TimePanel;

        private System.Windows.Forms.Button EditCancelButton;
        private System.Windows.Forms.Button EditDeleteButton;
        private System.Windows.Forms.Button EditSaveButton;

        private System.Windows.Forms.NumericUpDown EditChooseCapacity;
        private System.Windows.Forms.NumericUpDown EditChooseNumber;
        private System.Windows.Forms.TextBox EditEnterFileName;
        private System.Windows.Forms.GroupBox EditTable;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LabelEditChooseCapacity;
        private System.Windows.Forms.Label LabelEditChooseNumber;
        private System.Windows.Forms.Label LabelEditFileName;

        private System.Windows.Forms.Label LabelFromTime;
        private System.Windows.Forms.Label LabelUntilTime;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Button AddRequestReservButton;
        private System.Windows.Forms.Button CancelTableReservButton;

        private System.Windows.Forms.NumericUpDown CountPerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Button ZoomInButton;
        private System.Windows.Forms.Button ZoomOutButton;

        private System.Windows.Forms.Panel imageScroll;

        private System.Timers.Timer Update_timer;

        private System.Windows.Forms.Button AddTable;
        private System.Windows.Forms.Button CancelAdd;
        private System.Windows.Forms.NumericUpDown ChooseCapacity;
        private System.Windows.Forms.NumericUpDown ChooseNumber;
        private System.Windows.Forms.TextBox FileName_source;
        private System.Windows.Forms.Label LabelCapacity;
        private System.Windows.Forms.Label LabelFileName;
        private System.Windows.Forms.Label LabelNumber;

        private System.Windows.Forms.Button AdminButton;

        private System.Windows.Forms.GroupBox AdminAdding;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel LineBar;

        private System.Timers.Timer timer1;

        private System.Windows.Forms.GroupBox ReservGroupBox;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Panel TableList;

        private System.Windows.Forms.DateTimePicker ChooseReserveDateFrom;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}