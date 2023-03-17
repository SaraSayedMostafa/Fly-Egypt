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
	public partial class Manage_Seats : Form
	{
		string odb = "Data source=orcl;User Id=scott; Password=tiger;";
		OracleConnection conn;
		int tripid;
		public Manage_Seats(int tripid)
		{
			InitializeComponent();
			this.tripid = tripid;
		}

		private void Manage_Seats_Load(object sender, EventArgs e)
		{
			conn = new OracleConnection(odb);
			conn.Open();
			OracleCommand oc = new OracleCommand();
			oc.Connection = conn;
			oc.CommandText = "select seatnumber from ticket where tripid = :trid";
			oc.CommandType = CommandType.Text;
			oc.Parameters.Add("trid", tripid);
			OracleDataReader odr = oc.ExecuteReader();
			while (odr.Read())
			{
				FromSeatCB.Items.Add(odr["seatnumber"]);
				ToSeatCB.Items.Add(odr["seatnumber"]);
			}
		}

		private void SetSeatsBTN_Click(object sender, EventArgs e)
		{
			try
			{
				OracleCommand oc = new OracleCommand();
				oc.Connection = conn;
				oc.CommandText = "ManageTicekts";
				oc.CommandType = CommandType.StoredProcedure;
				oc.Parameters.Add("Tripid", tripid);
				oc.Parameters.Add("FromSeat", Convert.ToInt32(FromSeatCB.SelectedItem.ToString()));
				oc.Parameters.Add("ToSeat", Convert.ToInt32(ToSeatCB.SelectedItem.ToString()));
				oc.Parameters.Add("SeatPrice", Convert.ToInt32(SeatPriceTB.Text));
				oc.Parameters.Add("SeatType", SeatTypeCB.SelectedItem.ToString());
			}
			catch { MessageBox.Show("There Might be Error Values"); }
		}
	}
}
