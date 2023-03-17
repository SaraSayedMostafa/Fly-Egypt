using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using CrystalDecisions.Shared;

namespace WindowsFormsApplication3
{
	public partial class Admin : Form
	{

		string odb = "Data source=orcl;User Id=scott; Password=tiger;";
		OracleConnection conn;
		OracleDataAdapter oda;
		OracleCommandBuilder ocb;
		DataSet ds = new DataSet();
		DataSet DS = new DataSet();
		int STimer = 0;
		int tickedid;
		Form PF;
		TripsReport TR;
		public Admin()
		{
			InitializeComponent();
			TripsPanel.Visible = false;
		}


		private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			OracleCommand oc = new OracleCommand();
			oc.Connection = conn;
			oc.CommandText = "select t.flightid, t.fromairport, t.toairport, t.departurdate, t.arrivaldate, t.remark, t.tripduration, t.triptype,  t.availableseats,t.tripprice,t.returndeparturedate,t.returnarrivaldate from trips t, flight f  where t.flightid = f.flightid and f.flightid = (select flight.flightid from flight where flight.flightname = :fn)";
			oc.CommandType = CommandType.Text;
			oc.Parameters.Add("fn", gunaComboBox1.SelectedItem.ToString());
			oda = new OracleDataAdapter(oc);
			OracleCommandBuilder ocb = new OracleCommandBuilder(oda);
			DataSet DS = new DataSet();
			oda.Fill(DS);
			OneWayDGV.Rows.Clear();
			ReturnDGV.Rows.Clear();
			try
			{
				for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
				{
					if (DS.Tables[0].Rows[i][7].ToString().Equals("One Way"))
					{
						OneWayDGV.Rows.Clear();
						OneWayDGV.Rows.Add(new object[] { DS.Tables[0].Rows[i][0], DS.Tables[0].Rows[i][1], DS.Tables[0].Rows[i][2], DS.Tables[0].Rows[i][3], DS.Tables[0].Rows[i][4], DS.Tables[0].Rows[i][5], DS.Tables[0].Rows[i][6], DS.Tables[0].Rows[i][7], DS.Tables[0].Rows[i][8], DS.Tables[0].Rows[i][9] });
						
					}
					else
					{
						ReturnDGV.Rows.Clear();
						ReturnDGV.Rows.Add(new object[] { DS.Tables[0].Rows[i][0], DS.Tables[0].Rows[i][1], DS.Tables[0].Rows[i][2], DS.Tables[0].Rows[i][3], DS.Tables[0].Rows[i][4], DS.Tables[0].Rows[i][10], DS.Tables[0].Rows[i][11], DS.Tables[0].Rows[i][5], DS.Tables[0].Rows[i][6], DS.Tables[0].Rows[i][7], DS.Tables[0].Rows[i][8], DS.Tables[0].Rows[i][9] });
					}
				}
			}
			catch { MessageBox.Show("This Flight Has No Trips"); }
		}

		private void Admin_Load(object sender, EventArgs e)
		{


			TR = new TripsReport();

			foreach (ParameterDiscreteValue FN in TR.ParameterFields[0].DefaultValues)
				FlightsFilterTR.Items.Add(FN.Value);

			NameValue.Text = "";
			SSNValue.Text = "";
			TripIDValue.Text = "";
			FromValue.Text = "";
			ToValue.Text = "";
			SeatNumberValue.Text = "";
			NationalityValue.Text = "";
			TripTypeValue.Text = "";

			conn = new OracleConnection(odb);
			conn.Open();
			OracleCommand oc = new OracleCommand();
			oc.Connection = conn;
			oc.CommandText = "select FlightName from Flight";
			oc.CommandType = CommandType.Text;


			OracleDataReader odr = oc.ExecuteReader();
			while (odr.Read())
			{ gunaComboBox1.Items.Add(odr["FlightName"]); }

			DataTable dataTable = new DataTable();
			oc.CommandText = "select flightid,flightname,numberofseats from flight";
			oc.CommandType = CommandType.Text;
			oda = new OracleDataAdapter(oc);
			ds = new DataSet();
			oda.Fill(dataTable);
			ds.Tables.Add(dataTable);
			FlightsDGV.DataSource = ds.Tables[0];

			oc.CommandText = "select ssn,tname,gender,jop,dob,age,email,street,city,aptnumber,postalcode,Nationality,passport from Traveller";
			oc.CommandType = CommandType.Text;
			oda = new OracleDataAdapter(oc);
			dataTable = new DataTable();
			oda.Fill(dataTable);
			ds.Tables.Add(dataTable);
			TravellerDGV.DataSource = ds.Tables[1];

			oda = new OracleDataAdapter("select ticketid,reserveddate,tripid,ticketprice,seattype,seatprice,status from ticket", conn);
		    dataTable  = new DataTable();
			oda.Fill(dataTable);
			ds.Tables.Add(dataTable);
			TicketsDGV.DataSource = ds.Tables[2];
		}

		private void TripsBtn_Click(object sender, EventArgs e)
		{
			TripsPanel.Dock = DockStyle.Fill;
			TripsPanel.Visible = true;
			FlightsPanel.Visible = false;
			TravellersPanel.Visible = false;
			TicketsPanel.Visible = false;
			TitleforCurrntState.Text = TripsBtn.Text;

		}


		

		private void ManageBTN_Click(object sender, EventArgs e)
		{
			new Manage_Trips().Show();
		}

		private void gunaCircleButton3_Click(object sender, EventArgs e)
		{
			SuccessUpdateTimer.Start();
			STimer = 0;
			try
			{
				ocb = new OracleCommandBuilder(oda);
				oda.Update(ds.Tables[0]);
				SuccessfulBTN.Visible = true;
			}
			catch { FailedBTN.Visible = true; MessageBox.Show("Key is Already Added Begore"); }

		}

		private void SuccessUpdateTimer_Tick(object sender, EventArgs e)
		{
			STimer++;
			if(STimer > 15)
			{
				SuccessfulBTN.Visible = false;
				FailedBTN.Visible = false;
				SuccessUpdateTimer.Stop();
				
			}
		}

		private void Admin_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.PF.Close();
		}
		public void ParentForm(Form PF,string AN) 
		{
			this.PF = PF;
			AdminName.Text = AN;
		}

		private void FlightBTN_Click(object sender, EventArgs e)
		{
			FlightsPanel.Dock = DockStyle.Fill;
			FlightsPanel.Visible = true;
			TripsPanel.Visible = false;
			TravellersPanel.Visible = false;
			TicketsPanel.Visible = false;
			TitleforCurrntState.Text = FlightBTN.Text;


		}

		private void LogOutBTN_Click(object sender, EventArgs e)
		{
			this.PF.Show();
			this.Close();
		}

		private void TravellersBTN_Click(object sender, EventArgs e)
		{
			TravellersPanel.Dock = DockStyle.Fill;
			TravellersPanel.Visible = true;
			FlightsPanel.Visible = false;
			TripsPanel.Visible = false;
			TicketsPanel.Visible = false;
			TitleforCurrntState.Text = TravellersBTN.Text;

		}

		private void UpdateTravellersBTN_Click(object sender, EventArgs e)
		{

						SuccUpdateTimerTP.Start();
						STimer = 0;
						try
						{
			                ocb = new OracleCommandBuilder(oda);
							oda.Update(ds.Tables[1]);
							SuccTimerTP.Visible = true;
						}
						catch { FailTimerTP.Visible = true; MessageBox.Show("Key is Already Added Begore"); }
		}

		private void SuccUpdateTimerTP_Tick(object sender, EventArgs e)
		{
			STimer++;
			if (STimer > 15)
			{
				SuccTimerTP.Visible = false;
				FailTimerTP.Visible = false;
				SuccUpdateTimerTP.Stop();

			}
		}

		private void RefreshFlightsBTN_Click(object sender, EventArgs e)
		{
			FlightsDGV.Refresh();
		}

		private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			TicketsDGV.CurrentRow.Selected = true;
			OracleCommand oc = new OracleCommand();
			oc.Connection = conn;
			oc.CommandText = "ShowTicketInfo";
			oc.CommandType = CommandType.StoredProcedure;
			tickedid = Convert.ToInt32(TicketsDGV.Rows[e.RowIndex].Cells["TICKETID"].Value.ToString());
			oc.Parameters.Add("tid",TicketsDGV.Rows[e.RowIndex].Cells["TICKETID"].Value.ToString());
			oc.Parameters.Add("TInfo",OracleDbType.RefCursor,ParameterDirection.Output);
			OracleDataReader odr = oc.ExecuteReader();

			while (odr.Read())
			{
				NameValue.Text = "";
				SSNValue.Text = "";
				TripIDValue.Text = "";
				FromValue.Text = "";
				ToValue.Text = "";
				SeatNumberValue.Text = "";
				NationalityValue.Text = "";
				TripTypeValue.Text = "";
				NameValue.Text = odr["TNAME"].ToString();
				SSNValue.Text = odr["TSSN"].ToString();
				TripIDValue.Text = odr["TRIPID"].ToString();
				FromValue.Text = odr["FROMAIRPORT"].ToString();
				ToValue.Text = odr["TOAIRPORT"].ToString();
				SeatNumberValue.Text = odr["SEATNUMBER"].ToString();
				NationalityValue.Text = odr["NATIONALITY"].ToString();
				TripTypeValue.Text = odr["TRIPTYPE"].ToString();
			}			
			odr.Close();
		}

		private void TicketsBTN_Click(object sender, EventArgs e)
		{
			TicketsPanel.Dock = DockStyle.Fill;
			TicketsPanel.Visible = true;
			TripsPanel.Visible = false;
			FlightsPanel.Visible = false;
			TravellersPanel.Visible = false;
			TitleforCurrntState.Text = TicketsBTN.Text;

		}

		private void CancelTicketBTN_Click(object sender, EventArgs e)
		{
			if(TripIDValue.Text.Equals(""))
			{
				MessageBox.Show("Its Already Free");
			}
			else
			{
				OracleCommand oc = new OracleCommand();
				oc.Connection = conn;
				oc.CommandText = "CancelTicket";
				oc.CommandType = CommandType.StoredProcedure;
				oc.Parameters.Add("tid",Convert.ToInt32(tickedid));
				oc.Parameters.Add("trid", Convert.ToInt32(TripIDValue.Text));
				oc.ExecuteNonQuery();
				NameValue.Text = "";
				SSNValue.Text = "";
				TripIDValue.Text = "";
				FromValue.Text = "";
				ToValue.Text = "";
				SeatNumberValue.Text = "";
				NationalityValue.Text = "";
				TripTypeValue.Text = "";
				oda = new OracleDataAdapter("select ticketid,reserveddate,tripid,ticketprice,seattype,seatprice,status from ticket", conn);
				DataSet NewDS = new DataSet();
				oda.Fill(NewDS);
				TicketsDGV.DataSource = NewDS.Tables[0];
			}
		}
		
		private void LoadTicketsBTN_Click(object sender, EventArgs e)
		{
		    
		}

        private void iconButton2_Click(object sender, EventArgs e)
        {
			this.Hide();
			PF.Show();
			
		}

		private void LoadTripsBTN_Click(object sender, EventArgs e)
		{
			OracleCommand oc = new OracleCommand();
			oc.Connection = conn;
			oc.CommandText = "select t.tripid,t.flightid, t.fromairport, t.toairport, t.departurdate, t.arrivaldate, t.remark, t.tripduration, t.triptype,  t.availableseats,t.tripprice from trips t, flight f  where t.flightid = f.flightid and t.triptype = 'One Way' order by t.flightid";
			oc.CommandType = CommandType.Text;
			oda = new OracleDataAdapter(oc);
			OracleCommandBuilder ocb = new OracleCommandBuilder(oda);
			DS = new DataSet();
			oda.Fill(DS);
			OneWayDGV.Rows.Clear();
			for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
			{
				OneWayDGV.Rows.Add(new object[] { DS.Tables[0].Rows[i][0], DS.Tables[0].Rows[i][1], DS.Tables[0].Rows[i][2], DS.Tables[0].Rows[i][3], DS.Tables[0].Rows[i][4], DS.Tables[0].Rows[i][5], DS.Tables[0].Rows[i][6], DS.Tables[0].Rows[i][7], DS.Tables[0].Rows[i][8], DS.Tables[0].Rows[i][9], DS.Tables[0].Rows[i][10] });
			}
			oc.CommandText = "select t.tripid,t.flightid, t.fromairport, t.toairport, t.departurdate, t.arrivaldate, t.remark, t.tripduration, t.triptype,  t.availableseats,t.tripprice,t.RETURNDEPARTUREDATE,t.RETURNARRIVALDATE from trips t, flight f  where t.flightid = f.flightid and t.triptype = 'Return' order by t.flightid";
			oc.CommandType = CommandType.Text;
			oda = new OracleDataAdapter(oc);
			ocb = new OracleCommandBuilder(oda);
			DS = new DataSet();
			oda.Fill(DS);
			ReturnDGV.Rows.Clear();
			for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
			{
				ReturnDGV.Rows.Add(new object[] { DS.Tables[0].Rows[i][0], DS.Tables[0].Rows[i][1], DS.Tables[0].Rows[i][2], DS.Tables[0].Rows[i][3], DS.Tables[0].Rows[i][4], DS.Tables[0].Rows[i][11], DS.Tables[0].Rows[i][12], DS.Tables[0].Rows[i][5], DS.Tables[0].Rows[i][6], DS.Tables[0].Rows[i][7], DS.Tables[0].Rows[i][8], DS.Tables[0].Rows[i][9], DS.Tables[0].Rows[i][10] });
			}
		}

		private void TripsReportBTN_Click(object sender, EventArgs e)
		{
			TripsReportPanel.Dock = DockStyle.Fill;
			TripsReportPanel.Visible = true;
			TicketsPanel.Visible = false;
			TripsPanel.Visible = false;
			FlightsPanel.Visible = false;
			TravellersPanel.Visible = false;
			TitleforCurrntState.Text = TripsReportBTN.Text;
		}

		private void LoadTripsReportBTN_Click(object sender, EventArgs e)
		{
			TR.SetParameterValue(0, FlightsFilterTR.Text);
			TripsReportViewer.ReportSource = TR;
		}
	}
}
