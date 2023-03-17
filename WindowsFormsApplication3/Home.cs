using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApplication3
{
    public partial class Home : Form
    {
        OracleConnection con;
        string ordb = "data source = orcl; user id =scott; password=tiger;";
        Admin Admin;

        string ssn;
        int tripid;
        int totalticketnum;
        int ticketprice;
        int PassengersCounter;

        DataTable table;
        public object senderPupBook;
        private IconButton curruntBtn;
        private Panel leftBorderBtn;
        public Panel CurrntChildPanel;

        public Home()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelManue.Controls.Add(leftBorderBtn);
            this.label1.Parent = this.pictureBox1;
            this.label1.BackColor = Color.Transparent;

            this.label2.Parent = this.pictureBox1;
            this.label2.BackColor = Color.Transparent;

            this.label3.Parent = this.pictureBox1;
            this.label3.BackColor = Color.Transparent;

            this.label4.Parent = this.pictureBox1;
            this.label4.BackColor = Color.Transparent;






            RegisterPanel.Visible = false;
            LoginPanel.Visible = false;
            BookingPanel.Visible = false;
            paneltripsearch.Visible = false;
            panelinformation.Visible = false;
            BookingPanel.BackColor = Color.Transparent;

        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(253,168,0);
            public static Color color6 = Color.FromArgb(255, 215, 0);
        }


        private void ActivateButton(object senderBtn,Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                curruntBtn = (IconButton)senderBtn;
                curruntBtn.BackColor = Color.FromArgb(37, 36, 81);
                curruntBtn.ForeColor = color;
                curruntBtn.TextAlign = ContentAlignment.MiddleCenter;
                curruntBtn.IconColor = color;
                curruntBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                curruntBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, curruntBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                CurrntState.IconChar = curruntBtn.IconChar;
                TitleforCurrntState.Text = curruntBtn.Text;
            }
        }


        private void DisableButton()
        {
            if(curruntBtn != null)
            {
                curruntBtn.BackColor = Color.FromArgb(31, 30, 68);
                curruntBtn.ForeColor = Color.Gainsboro;
                curruntBtn.TextAlign = ContentAlignment.MiddleLeft;
                curruntBtn.IconColor = Color.Gainsboro;
                curruntBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                curruntBtn.ImageAlign = ContentAlignment.MiddleLeft;



            }
        }
        public void OpenchildForm(Panel childPanel) 
        {
            //if (CurrntChildPanel != null)
            //{
            //  CurrntChildPanel.Close();
            //}
            CurrntChildPanel = childPanel;
            //childform.TopLevel = false;
            //childform.FormBorderStyle = FormBorderStyle.None;
            panelDesktop.Controls.Add(childPanel);
            panelDesktop.Tag = childPanel;
            childPanel.BringToFront();
            childPanel.Show();
            //TitleforCurrntState.Text = childform.Text;
        }

        private void BookBTN_Click(object sender, EventArgs e)
        {
            senderPupBook = sender;
            ActivateButton(sender, RGBColors.color5);
            OpenchildForm(BookingPanel);
            this.BookingPanel.Parent = this.pictureBox1;
            BookingPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            BookingPanel.Dock = DockStyle.Fill;




            this.label10.Parent = this.BookingPanel;
            this.label10.BackColor = Color.Transparent;
            this.label11.Parent = this.BookingPanel;
            this.label11.BackColor = Color.Transparent;
            this.label12.Parent = this.BookingPanel;
            this.label12.BackColor = Color.Transparent;
            this.label13.Parent = this.BookingPanel;
            this.label13.BackColor = Color.Transparent;
            this.label14.Parent = this.BookingPanel;
            this.label14.BackColor = Color.Transparent;
            this.radioButton1.Parent = this.BookingPanel;
            this.radioButton1.BackColor = Color.Transparent;
            this.radioButton3.Parent = this.BookingPanel;
            this.radioButton3.BackColor = Color.Transparent;


            BookingPanel.Visible = true;
            RegisterPanel.Visible = false;
            LoginPanel.Visible = false;
            paneltripsearch.Visible = false;
            panelinformation.Visible = false;
            panellogonAsadmin.Visible = false;
            gunaLinePanelThnk.Visible = false;
            
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;


        }

        private void SignUpBTN_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenchildForm(RegisterPanel);
            this.RegisterPanel.Parent = this.pictureBox1;
            RegisterPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            RegisterPanel.Dock = DockStyle.Fill;


            this.Female.Parent = this.RegisterPanel;
            Female.BackColor = Color.Transparent;
            this.Male.Parent = this.RegisterPanel;
            Male.BackColor = Color.Transparent;
            this.label9.Parent = this.RegisterPanel;
            label9.BackColor = Color.Transparent;
            this.label8.Parent = this.RegisterPanel;
            label8.BackColor = Color.Transparent;


            BookingPanel.Visible = false;
            RegisterPanel.Visible = true;
            LoginPanel.Visible = false;
            paneltripsearch.Visible = false;
            panelinformation.Visible = false;
            panellogonAsadmin.Visible = false;
            gunaLinePanelThnk.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void SigninBTN_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenchildForm(LoginPanel);
            this.LoginPanel.Parent = this.pictureBox1;
            LoginPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.label5.Parent = this.LoginPanel;
            this.label5.BackColor = Color.Transparent;

            

            BookingPanel.Visible = false;
            RegisterPanel.Visible = false;
            LoginPanel.Visible = true;
            paneltripsearch.Visible = false;
            panelinformation.Visible = false;
            panellogonAsadmin.Visible = false;
            gunaLinePanelThnk.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void Btnhome_Click(object sender, EventArgs e)
        {
            CurrntChildPanel.Visible = false;
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            CurrntState.IconChar = IconChar.Home;
            TitleforCurrntState.Text = "Home";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

		private void Form1_Load(object sender, EventArgs e)
		{
            con = new OracleConnection(ordb);
            con.Open();

            //OracleCommand cmd2 = new OracleCommand();
            //cmd2.Connection = con;
            //cmd2.CommandText = "BookTrip";
            //cmd2.CommandType = CommandType.StoredProcedure;

            //cmd2.Parameters.Add("ProcSSN", "1");
            //cmd2.Parameters.Add("ProcTripid", 12);
            //cmd2.ExecuteNonQuery();


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "GetAirports";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("AirportName", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
                comboBox2.Items.Add(dr[0]);
            }
            dr.Close();

            Admin = new Admin();
        }

		private void iconButton4_Click(object sender, EventArgs e)
		{
            ActivateButton(sender, RGBColors.color5);
            OpenchildForm(panellogonAsadmin);
            this.panellogonAsadmin.Parent = this.pictureBox1;
            panellogonAsadmin.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.label15.Parent = this.panellogonAsadmin;
            this.label15.BackColor = Color.Transparent;
            this.label18.Parent = this.panellogonAsadmin;
            this.label18.BackColor = Color.Transparent;



            BookingPanel.Visible = false;
            RegisterPanel.Visible = false;
            LoginPanel.Visible = false;
            paneltripsearch.Visible = false;
            panelinformation.Visible = false;
            panellogonAsadmin.Visible = true;
            gunaLinePanelThnk.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;




		}

        private void SigninBTNform_Click(object sender, EventArgs e)
        {

            //check first in data on his entered information
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select ssn from traveller where email = :email " +
            "and password = :password";
            //cmd.CommandText = "USERLOGIN";
            //cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("email", Uusername.Text);
            cmd.Parameters.Add("password", Upassword.Text);

            //OracleParameter res = new OracleParameter("ProcSSN", OracleDbType.Varchar2, 15);
            //res.Direction = ParameterDirection.Output;
            //cmd.Parameters.Add(new OracleParameter("ProcSSN", OracleDbType.Int32, ParameterDirection.Output));

            OracleDataReader dr = cmd.ExecuteReader();
            //cmd.ExecuteNonQuery();

            if (dr.Read())
                ssn = dr[0].ToString();
            else
                ssn = "-1";
            dr.Close();

            if (ssn == "-1")
            {
                MessageBox.Show("Invalid Username/Password !");
                return;
            }

            //move to book page if his information corrct
            ActivateButton(senderPupBook, RGBColors.color5);
            OpenchildForm(BookingPanel);
            this.BookingPanel.Parent = this.pictureBox1;
            BookingPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            BookingPanel.Dock = DockStyle.Fill;
            this.label10.Parent = this.BookingPanel;
            this.label10.BackColor = Color.Transparent;
            this.label11.Parent = this.BookingPanel;
            this.label11.BackColor = Color.Transparent;
            this.label12.Parent = this.BookingPanel;
            this.label12.BackColor = Color.Transparent;
            this.label13.Parent = this.BookingPanel;
            this.label13.BackColor = Color.Transparent;
            this.label14.Parent = this.BookingPanel;
            this.label14.BackColor = Color.Transparent;
            this.radioButton1.Parent = this.BookingPanel;
            this.radioButton1.BackColor = Color.Transparent;
            this.radioButton3.Parent = this.BookingPanel;
            this.radioButton3.BackColor = Color.Transparent;


            BookingPanel.Visible = true;
            RegisterPanel.Visible = false;
            LoginPanel.Visible = false;
            paneltripsearch.Visible = false;
            panelinformation.Visible = false;
            panellogonAsadmin.Visible = false;
            gunaLinePanelThnk.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;


        }

        private void SignupBTNform_Click(object sender, EventArgs e)
        {
            //check first in data on his entered information
            /*
             create or replace PROCEDURE SignUp
             (ssn VARCHAR2, name VARCHAR2, gender VARCHAR2, job VARCHAR2, dob date,
             age number, email VARCHAR2, street VARCHAR2, city VARCHAR2, aptnumber NUMBER,
             postalcode NUMBER, nationality VARCHAR2, password VARCHAR2)
                as
                begin
                    insert into traveller(ssn, tname, gender, jop, dob, age, 
                    email, street, city, aptnumber, postalcode, nationality, password) 
                    values(ssn, name, gender, job, dob, age, email, 
                    street, city, aptnumber, postalcode, nationality, password);
                end;
             */

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "SIGNUP";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("ProcSSN", SNNtext.Text);
            cmd.Parameters.Add("ProcName", Username.Text);

            OracleParameter gend;
            if (Female.Checked)
                gend = new OracleParameter("ProcGender", "F");
            else
                gend = new OracleParameter("ProcGender", "M");
            cmd.Parameters.Add(gend);

            cmd.Parameters.Add("ProcJob", Job.Text);
            //           cmd.Parameters.Add("ProcDob"
            //cmd.Parameters.Add("ProcAge", age
            cmd.Parameters.Add("ProcEmail", Email.Text);
            cmd.Parameters.Add("ProcStrt", Street.Text);
            cmd.Parameters.Add("ProcCity", City.Text);
            cmd.Parameters.Add("ProcAptNum", AptNumber.Text);
            cmd.Parameters.Add("ProcPostal", PostalCode.Text);
            cmd.Parameters.Add("ProcNationality", Nationality.Text);
            cmd.Parameters.Add("ProcPassword", Password.Text);

            try
            {
                cmd.ExecuteNonQuery();
                ssn = SNNtext.Text;
            }
            catch
            {
                ssn = "-1";
                MessageBox.Show("Invalid Data !");
                return;
            }

            //move to book page if his information corrct
            ActivateButton(senderPupBook, RGBColors.color5);
            OpenchildForm(BookingPanel);
            this.BookingPanel.Parent = this.pictureBox1;
            BookingPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            BookingPanel.Dock = DockStyle.Fill;
            this.label10.Parent = this.BookingPanel;
            this.label10.BackColor = Color.Transparent;
            this.label11.Parent = this.BookingPanel;
            this.label11.BackColor = Color.Transparent;
            this.label12.Parent = this.BookingPanel;
            this.label12.BackColor = Color.Transparent;
            this.label13.Parent = this.BookingPanel;
            this.label13.BackColor = Color.Transparent;
            this.label14.Parent = this.BookingPanel;
            this.label14.BackColor = Color.Transparent;
            this.radioButton1.Parent = this.BookingPanel;
            this.radioButton1.BackColor = Color.Transparent;
            this.radioButton3.Parent = this.BookingPanel;
            this.radioButton3.BackColor = Color.Transparent;


            BookingPanel.Visible = true;
            RegisterPanel.Visible = false;
            LoginPanel.Visible = false;
            paneltripsearch.Visible = false;
            panelinformation.Visible = false;
            panellogonAsadmin.Visible = false;
            gunaLinePanelThnk.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox7.Visible = true;
            gunaDateTimePicker2.Visible = true;
            comboBox2.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox7.Visible = false;
            gunaDateTimePicker2.Visible = false;
        }

        private void SearchBTNform_Click(object sender, EventArgs e)
        {

            try
            {
                totalticketnum = int.Parse(numadultCOM.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Data !");
                return;
            }
            if (totalticketnum < 1)
            {
                MessageBox.Show("At Least 1 Passenger !");
                return;
            }

            string FromAirport = comboBox1.Text;
            string ToAirport = comboBox2.Text;
            string date = gunaDateTimePicker1.Text.Trim();
            string cmdstr = "select * from trips " +
                            "where fromairport = :FromAir and " +
                            "toairport = :ToAir and " +
                            "departurdate >= :DateDep and " +
                            "availableseats >= :SeatsNum";

            PassengersCounter = 0;

            OracleDataAdapter adp = new OracleDataAdapter(cmdstr, ordb);
            adp.SelectCommand.Parameters.Add("FromAir", FromAirport);
            adp.SelectCommand.Parameters.Add("ToAir", ToAirport);
            adp.SelectCommand.Parameters.Add("DateDep", date);
            adp.SelectCommand.Parameters.Add("SeatsNum", totalticketnum);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            //var tem = ds.Tables[0].Rows[12];
            table = ds.Tables[0];
            
            if(table.Rows.Count == 0)
            {
                MessageBox.Show("No Trips With The Specified Information !");
                return;
            }
            OneWayDGV.DataSource = table;

            gunaComboBox1.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
                gunaComboBox1.Items.Add(table.Rows[i]["TRIPID"]);

            OpenchildForm(paneltripsearch);
            this.paneltripsearch.Parent = this.pictureBox1;
            paneltripsearch.BackColor = Color.FromArgb(100, 0, 0, 0);
            paneltripsearch.Dock = DockStyle.Fill;
            this.gunaLabel1.Parent = this.paneltripsearch;
            this.gunaLabel1.BackColor = Color.Transparent;
            this.gunaLabel4.Parent = this.paneltripsearch;
            this.gunaLabel4.BackColor = Color.Transparent;
            this.gunaComboBox1.Parent = this.paneltripsearch;
            this.gunaComboBox1.BackColor = Color.Transparent;
           


            BookingPanel.Visible = false;
            RegisterPanel.Visible = false;
            LoginPanel.Visible = false;
            paneltripsearch.Visible = true;
            panelinformation.Visible = false;
            panellogonAsadmin.Visible = false;
            gunaLinePanelThnk.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }



        private void NextBTNform_Click(object sender, EventArgs e)
        {
            try
            {
                tripid = int.Parse(gunaComboBox1.Text);
            }
            catch
            {
                MessageBox.Show("Select A Trip !!!");
                return;
            }

            int ind = gunaComboBox1.SelectedIndex;
            ticketprice = int.Parse(table.Rows[ind]["TRIPPRICE"].ToString());
            iconButton6.Text = "Passenger #" + (PassengersCounter + 1);
            gunaLinePanel9.Visible = true;
            OpenchildForm(panelinformation);
            this.panelinformation.Parent = this.pictureBox1;
            panelinformation.BackColor = Color.FromArgb(100, 0, 0, 0);
            panelinformation.Dock = DockStyle.Fill;
            this.gunaLinePanel9.Parent = this.panelinformation;
            this.gunaLinePanel9.BackColor = Color.Transparent;
            this.P_Female.Parent = this.gunaLinePanel9;
            this.P_Female.BackColor = Color.Transparent;
            this.P_Male.Parent = this.gunaLinePanel9;
            this.P_Male.BackColor = Color.Transparent;

            BookingPanel.Visible = false;
            RegisterPanel.Visible = false;
            LoginPanel.Visible = false;
            paneltripsearch.Visible = false;
            panelinformation.Visible = true;
            panellogonAsadmin.Visible = false;
            gunaLinePanelThnk.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            MessageBox.Show("Please Enter Passenger #" + (PassengersCounter + 1) + "Data");


        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConfirmBTN_Click(object sender, EventArgs e)
        {
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = con;
            cmd1.CommandText = "CreateTraveller";
            cmd1.CommandType = CommandType.StoredProcedure;

            cmd1.Parameters.Add("ProcSSN", P_SSN.Text);
            cmd1.Parameters.Add("ProcName", P_Name.Text);

            OracleParameter gend;
            if (P_Female.Checked)
                gend = new OracleParameter("ProcGender", "F");
            else
                gend = new OracleParameter("ProcGender", "M");
            cmd1.Parameters.Add(gend);

            cmd1.Parameters.Add("ProcJob", P_Job.Text);
            //           cmd.Parameters.Add("ProcDob"
            //cmd.Parameters.Add("ProcAge", age
            cmd1.Parameters.Add("ProcEmail", P_Email.Text);
            cmd1.Parameters.Add("ProcStrt", P_Street.Text);
            cmd1.Parameters.Add("ProcCity", P_City.Text);
            cmd1.Parameters.Add("ProcAptNum", P_AptNumber.Text);
            cmd1.Parameters.Add("ProcPostal", P_PostalCode.Text);
            cmd1.Parameters.Add("ProcNationality", P_Nationality.Text);
            cmd1.Parameters.Add("ProcDOB", P_DOB.Text);

            try
            {
                cmd1.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Invalid Data !");
                return;

            }

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = con;
            cmd2.CommandText = "BookTrip";
            cmd2.CommandType = CommandType.StoredProcedure;

            cmd2.Parameters.Add("ProcSSN", P_SSN.Text);
            cmd2.Parameters.Add("ProcTripid", tripid);
            
            try
            {
                
            cmd2.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Invalid Trip !");
                return;

            }

            PassengersCounter++;
            if (PassengersCounter < totalticketnum)
            {
                iconButton6.Text = "Passenger #" + (PassengersCounter + 1);
                P_SSN.Text = "SSN";
                P_Name.Text = "Name";
                P_Email.Text = "Email";
                P_Job.Text = "Job";
                P_Nationality.Text = "Nationality";
                P_City.Text = "City";
                P_Street.Text = "Street";
                P_AptNumber.Text = "Apartement Number";
                P_PostalCode.Text = "Postal Code";
                P_Male.Checked = true;
                MessageBox.Show("Please Enter Passenger #" + (PassengersCounter + 1) + "Data");
                return;
            }

            MessageBox.Show("Done ! Total Price = " + (totalticketnum * ticketprice));
            OpenchildForm(gunaLinePanelThnk);
            this.gunaLinePanelThnk.Parent = this.pictureBox1;
            gunaLinePanelThnk.BackColor = Color.FromArgb(100, 0, 0, 0);
            gunaLinePanelThnk.Dock = DockStyle.Fill;

            this.txt.Parent = this.gunaLinePanelThnk;
            this.txt.BackColor = Color.Transparent;
            this.gunaLabel2.Parent = this.gunaLinePanelThnk;
            this.gunaLabel2.BackColor = Color.Transparent;
            this.gunaLabel3.Parent = this.gunaLinePanelThnk;
            this.gunaLabel3.BackColor = Color.Transparent;


            BookingPanel.Visible = false;
            RegisterPanel.Visible = false;
            LoginPanel.Visible = false;
            paneltripsearch.Visible = false;
            panelinformation.Visible = false;
            panellogonAsadmin.Visible = false;
            gunaLinePanelThnk.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            panel1.Visible = false;
            /*
                OpenchildForm(panel1);
            this.panel1.Parent = this.pictureBox1;
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel1.Dock = DockStyle.Fill;

            this.txt.Parent = this.panel1;
            this.txt.BackColor = Color.Transparent;
            this.gunaLabel2.Parent = this.panel1;
            this.gunaLabel2.BackColor = Color.Transparent;
            this.gunaLabel3.Parent = this.panel1;
            this.gunaLabel3.BackColor = Color.Transparent;


            BookingPanel.Visible = false;
            RegisterPanel.Visible = false;
            LoginPanel.Visible = false;
            paneltripsearch.Visible = false;
            panelinformation.Visible = false;
            panellogonAsadmin.Visible = false;
            gunaLinePanelThnk.Visible = false;
            panel1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            */

            ////////////

        }

        private void signinBTNadmin_Click(object sender, EventArgs e)
        {
            //check first in data on his entered information
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select ID,Username from ADMIN where username = :AdminUsername " +
            "and password = :password";
            cmd.Parameters.Add("AdminUsername", Ausername.Text);
            cmd.Parameters.Add("password", Apassword.Text);

            OracleDataReader dr = cmd.ExecuteReader();
            string AN="";
            if (dr.Read())
            {
                ssn = dr[0].ToString();
                AN = dr[1].ToString();
            }
            else
                ssn = "-1";
            dr.Close();

            if (ssn == "-1")
            {
                MessageBox.Show("Invalid Username/Password !");
                return;
            }
            
             this.Hide();
             Admin.Show();
             Admin.ParentForm(this,AN);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            
            CurrntChildPanel.Visible = false;
            Reset();
            ActivateButton(sender, RGBColors.color5);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ssn = "-1";
            ActivateButton(sender, RGBColors.color5);
            OpenchildForm(LoginPanel);
            this.LoginPanel.Parent = this.pictureBox1;
            LoginPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.label5.Parent = this.LoginPanel;
            this.label5.BackColor = Color.Transparent;



            BookingPanel.Visible = false;
            RegisterPanel.Visible = false;
            LoginPanel.Visible = true;
            paneltripsearch.Visible = false;
            panelinformation.Visible = false;
            panellogonAsadmin.Visible = false;
            gunaLinePanelThnk.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void OneWayDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenchildForm(gunaLinePanelThnk);
            this.gunaLinePanelThnk.Parent = this.pictureBox1;
            gunaLinePanelThnk.BackColor = Color.FromArgb(100, 0, 0, 0);
            gunaLinePanelThnk.Dock = DockStyle.Fill;

            this.txt.Parent = this.gunaLinePanelThnk;
            this.txt.BackColor = Color.Transparent;
            this.gunaLabel2.Parent = this.gunaLinePanelThnk;
            this.gunaLabel2.BackColor = Color.Transparent;
            this.gunaLabel3.Parent = this.gunaLinePanelThnk;
            this.gunaLabel3.BackColor = Color.Transparent;


            BookingPanel.Visible = false;
            RegisterPanel.Visible = false;
            LoginPanel.Visible = false;
            paneltripsearch.Visible = false;
            panelinformation.Visible = false;
            panellogonAsadmin.Visible = false;
            gunaLinePanelThnk.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            panel1.Visible = false;
        }
    }
}
