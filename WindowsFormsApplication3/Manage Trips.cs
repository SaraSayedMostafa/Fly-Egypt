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

namespace WindowsFormsApplication3
{
	public partial class Manage_Trips : Form
	{
		string odb = "Data source=orcl;User Id=scott; Password=tiger;";
		OracleConnection conn;
		public Manage_Trips()
		{
			InitializeComponent();
		}

		private void FromAirportCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void ToAirportCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void FlightNamesCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void RemarkCB_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Manage_Trips_Load(object sender, EventArgs e)
		{
			conn = new OracleConnection(odb);
			conn.Open();
			OracleCommand oc = new OracleCommand();
			oc.Connection = conn;
			oc.CommandText = "select AirportName from Airport";
			oc.CommandType = CommandType.Text;



			OracleDataReader odr = oc.ExecuteReader();
			while (odr.Read())
			{
				FromAirportCB.Items.Add(odr["AIRPORTNAME"]);
				ToAirportCB.Items.Add(odr["AIRPORTNAME"]);
			}
			oc.CommandText = "select Flightid from Flight";
			oc.CommandType = CommandType.Text;



			odr = oc.ExecuteReader();
			while (odr.Read())
			{ FlightNamesCB.Items.Add(odr["Flightid"]); }

			oc.CommandText = "select tripid from trips";
			oc.CommandType = CommandType.Text;



			odr = oc.ExecuteReader();
			while (odr.Read())
			{ TripsidCB.Items.Add(odr["tripid"]); }

		}

		private void ReturnRB_CheckedChanged(object sender, EventArgs e)
		{
			DepartureDTP2.Visible = true;
			ArrivalDTP2.Visible = true;
			DepartureLabel2.Visible = true;
			ArrivalLabel2.Visible = true;
		}

		private void OneWayRB_CheckedChanged(object sender, EventArgs e)
		{
			DepartureDTP2.Visible = false;
			ArrivalDTP2.Visible = false;
			DepartureLabel2.Visible = false ;
			ArrivalLabel2.Visible = false;
		}

		private void AddFlightBTN_Click(object sender, EventArgs e)
		{
			OracleCommand oc = new OracleCommand();
			oc.Connection = conn;
			oc.CommandText = "CreatTrip";
			oc.CommandType = CommandType.StoredProcedure;
			oc.Parameters.Add("fid",Convert.ToInt32(FlightNamesCB.SelectedItem.ToString()));
			oc.Parameters.Add("From", FromAirportCB.SelectedItem.ToString());
			oc.Parameters.Add("To", ToAirportCB.SelectedItem.ToString());
			oc.Parameters.Add("Dep", DepartureDTP1.Value);
			oc.Parameters.Add("Arr", ArrivalDTP1.Value);
			oc.Parameters.Add("Rem", RemarkCB.SelectedItem.ToString());
			if (OneWayRB.Checked == true)
			{oc.Parameters.Add("Ty", "One Way");}
			else if(ReturnRB.Checked ==  true)
			{oc.Parameters.Add("Ty", "Return");}
			oc.Parameters.Add("Pri", Convert.ToInt32(TripPriceTB.Text));
			oc.Parameters.Add("RDep", DepartureDTP2.Value);
			oc.Parameters.Add("RARR", DepartureDTP2.Value);
			oc.Parameters.Add("tripid", OracleDbType.Int32, ParameterDirection.Output);
			oc.ExecuteNonQuery();
			int ti = Convert.ToInt32(oc.Parameters["tripid"].Value);
			Manage_Seats manage_Seats = new Manage_Seats(ti);
			manage_Seats.Show();
		}

		private void UpdateTripBTN_Click(object sender, EventArgs e)
		{
			try
			{
				OracleCommand oc = new OracleCommand();
				oc.Connection = conn;
				oc.CommandText = "UpdateTrip";
				oc.CommandType = CommandType.StoredProcedure;
				oc.Parameters.Add("tid", TripsidCB.SelectedItem.ToString());
				oc.Parameters.Add("From", FromAirportCB.SelectedItem.ToString());
				oc.Parameters.Add("To", ToAirportCB.SelectedItem.ToString());
				oc.Parameters.Add("Dep", DepartureDTP1.Value);
				oc.Parameters.Add("Arr", ArrivalDTP1.Value);
				oc.Parameters.Add("Rem", RemarkCB.SelectedItem.ToString());
				if (OneWayRB.Checked == true)
				{ oc.Parameters.Add("Ty", "One Way"); }
				else if (ReturnRB.Checked == true)
				{ oc.Parameters.Add("Ty", "Return"); }
				oc.Parameters.Add("Pri", Convert.ToInt32(TripPriceTB.Text));
				oc.Parameters.Add("RDep", DepartureDTP2.Value);
				oc.Parameters.Add("RARR", DepartureDTP2.Value);
				oc.ExecuteNonQuery();
			}
			catch { MessageBox.Show("Error"); }
		}

		private void DeleteTripBTN_Click(object sender, EventArgs e)
		{
			OracleCommand oc = new OracleCommand();
			oc.Connection = conn;
			oc.CommandText = "DeleteTrip";
			oc.CommandType = CommandType.StoredProcedure;
			oc.Parameters.Add("tid", Convert.ToInt32(TripsidCB.SelectedItem));
			TripsidCB.Items.Remove(TripsidCB.SelectedItem);
			oc.ExecuteNonQuery();
		}
	}
}
