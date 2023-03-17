
namespace WindowsFormsApplication3
{
	partial class Manage_Trips
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ArrivalLabel2 = new Guna.UI.WinForms.GunaLabel();
			this.DepartureLabel2 = new Guna.UI.WinForms.GunaLabel();
			this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
			this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
			this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
			this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
			this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
			this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
			this.OneWayRB = new System.Windows.Forms.RadioButton();
			this.ReturnRB = new System.Windows.Forms.RadioButton();
			this.DeleteTripBTN = new Guna.UI.WinForms.GunaButton();
			this.UpdateTripBTN = new Guna.UI.WinForms.GunaButton();
			this.AddFlightBTN = new Guna.UI.WinForms.GunaButton();
			this.FlightNamesCB = new Guna.UI.WinForms.GunaComboBox();
			this.ToAirportCB = new Guna.UI.WinForms.GunaComboBox();
			this.RemarkCB = new Guna.UI.WinForms.GunaComboBox();
			this.FromAirportCB = new Guna.UI.WinForms.GunaComboBox();
			this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
			this.DepartureDTP2 = new Guna.UI.WinForms.GunaDateTimePicker();
			this.DepartureDTP1 = new Guna.UI.WinForms.GunaDateTimePicker();
			this.ArrivalDTP1 = new Guna.UI.WinForms.GunaDateTimePicker();
			this.ArrivalDTP2 = new Guna.UI.WinForms.GunaDateTimePicker();
			this.TripPriceTB = new Guna.UI.WinForms.GunaTextBox();
			this.TripsidCB = new Guna.UI.WinForms.GunaComboBox();
			this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1096, 832);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.gunaLabel8);
			this.panel2.Controls.Add(this.TripsidCB);
			this.panel2.Controls.Add(this.ArrivalLabel2);
			this.panel2.Controls.Add(this.DepartureLabel2);
			this.panel2.Controls.Add(this.gunaLabel7);
			this.panel2.Controls.Add(this.gunaLabel6);
			this.panel2.Controls.Add(this.gunaLabel5);
			this.panel2.Controls.Add(this.gunaLabel4);
			this.panel2.Controls.Add(this.gunaLabel3);
			this.panel2.Controls.Add(this.gunaLabel2);
			this.panel2.Controls.Add(this.OneWayRB);
			this.panel2.Controls.Add(this.ReturnRB);
			this.panel2.Controls.Add(this.DeleteTripBTN);
			this.panel2.Controls.Add(this.UpdateTripBTN);
			this.panel2.Controls.Add(this.AddFlightBTN);
			this.panel2.Controls.Add(this.FlightNamesCB);
			this.panel2.Controls.Add(this.ToAirportCB);
			this.panel2.Controls.Add(this.RemarkCB);
			this.panel2.Controls.Add(this.FromAirportCB);
			this.panel2.Controls.Add(this.gunaLabel1);
			this.panel2.Controls.Add(this.DepartureDTP2);
			this.panel2.Controls.Add(this.DepartureDTP1);
			this.panel2.Controls.Add(this.ArrivalDTP1);
			this.panel2.Controls.Add(this.ArrivalDTP2);
			this.panel2.Controls.Add(this.TripPriceTB);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1096, 832);
			this.panel2.TabIndex = 10;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// ArrivalLabel2
			// 
			this.ArrivalLabel2.AutoSize = true;
			this.ArrivalLabel2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.ArrivalLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.ArrivalLabel2.Location = new System.Drawing.Point(588, 489);
			this.ArrivalLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ArrivalLabel2.Name = "ArrivalLabel2";
			this.ArrivalLabel2.Size = new System.Drawing.Size(105, 23);
			this.ArrivalLabel2.TabIndex = 27;
			this.ArrivalLabel2.Text = "Arrival Date";
			this.ArrivalLabel2.Visible = false;
			// 
			// DepartureLabel2
			// 
			this.DepartureLabel2.AutoSize = true;
			this.DepartureLabel2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.DepartureLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.DepartureLabel2.Location = new System.Drawing.Point(183, 489);
			this.DepartureLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.DepartureLabel2.Name = "DepartureLabel2";
			this.DepartureLabel2.Size = new System.Drawing.Size(133, 23);
			this.DepartureLabel2.TabIndex = 26;
			this.DepartureLabel2.Text = "Departure Date";
			this.DepartureLabel2.Visible = false;
			// 
			// gunaLabel7
			// 
			this.gunaLabel7.AutoSize = true;
			this.gunaLabel7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.gunaLabel7.Location = new System.Drawing.Point(588, 388);
			this.gunaLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.gunaLabel7.Name = "gunaLabel7";
			this.gunaLabel7.Size = new System.Drawing.Size(105, 23);
			this.gunaLabel7.TabIndex = 25;
			this.gunaLabel7.Text = "Arrival Date";
			// 
			// gunaLabel6
			// 
			this.gunaLabel6.AutoSize = true;
			this.gunaLabel6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.gunaLabel6.Location = new System.Drawing.Point(183, 388);
			this.gunaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.gunaLabel6.Name = "gunaLabel6";
			this.gunaLabel6.Size = new System.Drawing.Size(133, 23);
			this.gunaLabel6.TabIndex = 24;
			this.gunaLabel6.Text = "Departure Date";
			// 
			// gunaLabel5
			// 
			this.gunaLabel5.AutoSize = true;
			this.gunaLabel5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.gunaLabel5.Location = new System.Drawing.Point(719, 274);
			this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.gunaLabel5.Name = "gunaLabel5";
			this.gunaLabel5.Size = new System.Drawing.Size(51, 23);
			this.gunaLabel5.TabIndex = 23;
			this.gunaLabel5.Text = "Price";
			// 
			// gunaLabel4
			// 
			this.gunaLabel4.AutoSize = true;
			this.gunaLabel4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.gunaLabel4.Location = new System.Drawing.Point(710, 142);
			this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.gunaLabel4.Name = "gunaLabel4";
			this.gunaLabel4.Size = new System.Drawing.Size(70, 23);
			this.gunaLabel4.TabIndex = 22;
			this.gunaLabel4.Text = "Remark";
			// 
			// gunaLabel3
			// 
			this.gunaLabel3.AutoSize = true;
			this.gunaLabel3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.gunaLabel3.Location = new System.Drawing.Point(416, 142);
			this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.gunaLabel3.Name = "gunaLabel3";
			this.gunaLabel3.Size = new System.Drawing.Size(56, 23);
			this.gunaLabel3.TabIndex = 21;
			this.gunaLabel3.Text = "Flight";
			// 
			// gunaLabel2
			// 
			this.gunaLabel2.AutoSize = true;
			this.gunaLabel2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.gunaLabel2.Location = new System.Drawing.Point(416, 274);
			this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.gunaLabel2.Name = "gunaLabel2";
			this.gunaLabel2.Size = new System.Drawing.Size(28, 23);
			this.gunaLabel2.TabIndex = 20;
			this.gunaLabel2.Text = "To";
			// 
			// OneWayRB
			// 
			this.OneWayRB.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.OneWayRB.AutoSize = true;
			this.OneWayRB.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
			this.OneWayRB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.OneWayRB.Location = new System.Drawing.Point(601, 48);
			this.OneWayRB.Margin = new System.Windows.Forms.Padding(4);
			this.OneWayRB.Name = "OneWayRB";
			this.OneWayRB.Size = new System.Drawing.Size(92, 24);
			this.OneWayRB.TabIndex = 19;
			this.OneWayRB.TabStop = true;
			this.OneWayRB.Text = "One way";
			this.OneWayRB.UseVisualStyleBackColor = true;
			this.OneWayRB.CheckedChanged += new System.EventHandler(this.OneWayRB_CheckedChanged);
			// 
			// ReturnRB
			// 
			this.ReturnRB.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ReturnRB.AutoSize = true;
			this.ReturnRB.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
			this.ReturnRB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.ReturnRB.Location = new System.Drawing.Point(309, 48);
			this.ReturnRB.Margin = new System.Windows.Forms.Padding(4);
			this.ReturnRB.Name = "ReturnRB";
			this.ReturnRB.Size = new System.Drawing.Size(78, 24);
			this.ReturnRB.TabIndex = 18;
			this.ReturnRB.TabStop = true;
			this.ReturnRB.Text = "Rerurn";
			this.ReturnRB.UseVisualStyleBackColor = true;
			this.ReturnRB.CheckedChanged += new System.EventHandler(this.ReturnRB_CheckedChanged);
			// 
			// DeleteTripBTN
			// 
			this.DeleteTripBTN.AnimationHoverSpeed = 0.07F;
			this.DeleteTripBTN.AnimationSpeed = 0.03F;
			this.DeleteTripBTN.BackColor = System.Drawing.Color.Transparent;
			this.DeleteTripBTN.BaseColor = System.Drawing.Color.White;
			this.DeleteTripBTN.BorderColor = System.Drawing.Color.Black;
			this.DeleteTripBTN.BorderSize = 2;
			this.DeleteTripBTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DeleteTripBTN.DialogResult = System.Windows.Forms.DialogResult.None;
			this.DeleteTripBTN.FocusedColor = System.Drawing.Color.Empty;
			this.DeleteTripBTN.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.DeleteTripBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.DeleteTripBTN.Image = null;
			this.DeleteTripBTN.ImageSize = new System.Drawing.Size(20, 20);
			this.DeleteTripBTN.Location = new System.Drawing.Point(723, 686);
			this.DeleteTripBTN.Margin = new System.Windows.Forms.Padding(4);
			this.DeleteTripBTN.Name = "DeleteTripBTN";
			this.DeleteTripBTN.OnHoverBaseColor = System.Drawing.Color.White;
			this.DeleteTripBTN.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.DeleteTripBTN.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.DeleteTripBTN.OnHoverImage = null;
			this.DeleteTripBTN.OnPressedColor = System.Drawing.Color.Black;
			this.DeleteTripBTN.Radius = 20;
			this.DeleteTripBTN.Size = new System.Drawing.Size(213, 52);
			this.DeleteTripBTN.TabIndex = 17;
			this.DeleteTripBTN.Text = "Delete";
			this.DeleteTripBTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.DeleteTripBTN.Click += new System.EventHandler(this.DeleteTripBTN_Click);
			// 
			// UpdateTripBTN
			// 
			this.UpdateTripBTN.AnimationHoverSpeed = 0.07F;
			this.UpdateTripBTN.AnimationSpeed = 0.03F;
			this.UpdateTripBTN.BackColor = System.Drawing.Color.Transparent;
			this.UpdateTripBTN.BaseColor = System.Drawing.Color.White;
			this.UpdateTripBTN.BorderColor = System.Drawing.Color.Black;
			this.UpdateTripBTN.BorderSize = 2;
			this.UpdateTripBTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UpdateTripBTN.DialogResult = System.Windows.Forms.DialogResult.None;
			this.UpdateTripBTN.FocusedColor = System.Drawing.Color.Empty;
			this.UpdateTripBTN.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.UpdateTripBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.UpdateTripBTN.Image = null;
			this.UpdateTripBTN.ImageSize = new System.Drawing.Size(20, 20);
			this.UpdateTripBTN.Location = new System.Drawing.Point(448, 686);
			this.UpdateTripBTN.Margin = new System.Windows.Forms.Padding(4);
			this.UpdateTripBTN.Name = "UpdateTripBTN";
			this.UpdateTripBTN.OnHoverBaseColor = System.Drawing.Color.White;
			this.UpdateTripBTN.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.UpdateTripBTN.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.UpdateTripBTN.OnHoverImage = null;
			this.UpdateTripBTN.OnPressedColor = System.Drawing.Color.Black;
			this.UpdateTripBTN.Radius = 20;
			this.UpdateTripBTN.Size = new System.Drawing.Size(213, 52);
			this.UpdateTripBTN.TabIndex = 16;
			this.UpdateTripBTN.Text = "Update";
			this.UpdateTripBTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.UpdateTripBTN.Click += new System.EventHandler(this.UpdateTripBTN_Click);
			// 
			// AddFlightBTN
			// 
			this.AddFlightBTN.AnimationHoverSpeed = 0.07F;
			this.AddFlightBTN.AnimationSpeed = 0.03F;
			this.AddFlightBTN.BackColor = System.Drawing.Color.Transparent;
			this.AddFlightBTN.BaseColor = System.Drawing.Color.White;
			this.AddFlightBTN.BorderColor = System.Drawing.Color.Black;
			this.AddFlightBTN.BorderSize = 2;
			this.AddFlightBTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AddFlightBTN.DialogResult = System.Windows.Forms.DialogResult.None;
			this.AddFlightBTN.FocusedColor = System.Drawing.Color.Empty;
			this.AddFlightBTN.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.AddFlightBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.AddFlightBTN.Image = null;
			this.AddFlightBTN.ImageSize = new System.Drawing.Size(20, 20);
			this.AddFlightBTN.Location = new System.Drawing.Point(163, 686);
			this.AddFlightBTN.Margin = new System.Windows.Forms.Padding(4);
			this.AddFlightBTN.Name = "AddFlightBTN";
			this.AddFlightBTN.OnHoverBaseColor = System.Drawing.Color.White;
			this.AddFlightBTN.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.AddFlightBTN.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.AddFlightBTN.OnHoverImage = null;
			this.AddFlightBTN.OnPressedColor = System.Drawing.Color.Black;
			this.AddFlightBTN.Radius = 20;
			this.AddFlightBTN.Size = new System.Drawing.Size(213, 52);
			this.AddFlightBTN.TabIndex = 15;
			this.AddFlightBTN.Text = "Add";
			this.AddFlightBTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.AddFlightBTN.Click += new System.EventHandler(this.AddFlightBTN_Click);
			// 
			// FlightNamesCB
			// 
			this.FlightNamesCB.BackColor = System.Drawing.Color.Transparent;
			this.FlightNamesCB.BaseColor = System.Drawing.Color.White;
			this.FlightNamesCB.BorderColor = System.Drawing.Color.Silver;
			this.FlightNamesCB.BorderSize = 1;
			this.FlightNamesCB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FlightNamesCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.FlightNamesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FlightNamesCB.FocusedColor = System.Drawing.Color.Empty;
			this.FlightNamesCB.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FlightNamesCB.ForeColor = System.Drawing.Color.Black;
			this.FlightNamesCB.FormattingEnabled = true;
			this.FlightNamesCB.Location = new System.Drawing.Point(409, 169);
			this.FlightNamesCB.Margin = new System.Windows.Forms.Padding(4);
			this.FlightNamesCB.Name = "FlightNamesCB";
			this.FlightNamesCB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.FlightNamesCB.OnHoverItemForeColor = System.Drawing.Color.White;
			this.FlightNamesCB.Radius = 10;
			this.FlightNamesCB.Size = new System.Drawing.Size(252, 28);
			this.FlightNamesCB.TabIndex = 14;
			this.FlightNamesCB.SelectedIndexChanged += new System.EventHandler(this.FlightNamesCB_SelectedIndexChanged);
			// 
			// ToAirportCB
			// 
			this.ToAirportCB.BackColor = System.Drawing.Color.Transparent;
			this.ToAirportCB.BaseColor = System.Drawing.Color.White;
			this.ToAirportCB.BorderColor = System.Drawing.Color.Silver;
			this.ToAirportCB.BorderSize = 1;
			this.ToAirportCB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ToAirportCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.ToAirportCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ToAirportCB.FocusedColor = System.Drawing.Color.Empty;
			this.ToAirportCB.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ToAirportCB.ForeColor = System.Drawing.Color.Black;
			this.ToAirportCB.FormattingEnabled = true;
			this.ToAirportCB.Location = new System.Drawing.Point(409, 301);
			this.ToAirportCB.Margin = new System.Windows.Forms.Padding(4);
			this.ToAirportCB.Name = "ToAirportCB";
			this.ToAirportCB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.ToAirportCB.OnHoverItemForeColor = System.Drawing.Color.White;
			this.ToAirportCB.Radius = 10;
			this.ToAirportCB.Size = new System.Drawing.Size(252, 28);
			this.ToAirportCB.TabIndex = 13;
			this.ToAirportCB.SelectedIndexChanged += new System.EventHandler(this.ToAirportCB_SelectedIndexChanged);
			// 
			// RemarkCB
			// 
			this.RemarkCB.BackColor = System.Drawing.Color.Transparent;
			this.RemarkCB.BaseColor = System.Drawing.Color.White;
			this.RemarkCB.BorderColor = System.Drawing.Color.Silver;
			this.RemarkCB.BorderSize = 1;
			this.RemarkCB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RemarkCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.RemarkCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.RemarkCB.FocusedColor = System.Drawing.Color.Empty;
			this.RemarkCB.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RemarkCB.ForeColor = System.Drawing.Color.Black;
			this.RemarkCB.FormattingEnabled = true;
			this.RemarkCB.Items.AddRange(new object[] {
            "Not Yet",
            "Delayed",
            "Arrived",
            "On Air"});
			this.RemarkCB.Location = new System.Drawing.Point(714, 169);
			this.RemarkCB.Margin = new System.Windows.Forms.Padding(4);
			this.RemarkCB.Name = "RemarkCB";
			this.RemarkCB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.RemarkCB.OnHoverItemForeColor = System.Drawing.Color.White;
			this.RemarkCB.Radius = 10;
			this.RemarkCB.Size = new System.Drawing.Size(296, 28);
			this.RemarkCB.TabIndex = 12;
			this.RemarkCB.SelectedIndexChanged += new System.EventHandler(this.RemarkCB_SelectedIndexChanged);
			// 
			// FromAirportCB
			// 
			this.FromAirportCB.BackColor = System.Drawing.Color.Transparent;
			this.FromAirportCB.BaseColor = System.Drawing.Color.White;
			this.FromAirportCB.BorderColor = System.Drawing.Color.Silver;
			this.FromAirportCB.BorderSize = 1;
			this.FromAirportCB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FromAirportCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.FromAirportCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FromAirportCB.FocusedColor = System.Drawing.Color.Empty;
			this.FromAirportCB.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FromAirportCB.ForeColor = System.Drawing.Color.Black;
			this.FromAirportCB.FormattingEnabled = true;
			this.FromAirportCB.Location = new System.Drawing.Point(101, 301);
			this.FromAirportCB.Margin = new System.Windows.Forms.Padding(4);
			this.FromAirportCB.Name = "FromAirportCB";
			this.FromAirportCB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.FromAirportCB.OnHoverItemForeColor = System.Drawing.Color.White;
			this.FromAirportCB.Radius = 10;
			this.FromAirportCB.Size = new System.Drawing.Size(252, 28);
			this.FromAirportCB.TabIndex = 11;
			this.FromAirportCB.SelectedIndexChanged += new System.EventHandler(this.FromAirportCB_SelectedIndexChanged);
			// 
			// gunaLabel1
			// 
			this.gunaLabel1.AutoSize = true;
			this.gunaLabel1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.gunaLabel1.Location = new System.Drawing.Point(106, 274);
			this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.gunaLabel1.Name = "gunaLabel1";
			this.gunaLabel1.Size = new System.Drawing.Size(52, 23);
			this.gunaLabel1.TabIndex = 10;
			this.gunaLabel1.Text = "From";
			// 
			// DepartureDTP2
			// 
			this.DepartureDTP2.BackColor = System.Drawing.Color.Transparent;
			this.DepartureDTP2.BaseColor = System.Drawing.Color.White;
			this.DepartureDTP2.BorderColor = System.Drawing.Color.Silver;
			this.DepartureDTP2.BorderSize = 1;
			this.DepartureDTP2.CustomFormat = null;
			this.DepartureDTP2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.DepartureDTP2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.DepartureDTP2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.DepartureDTP2.ForeColor = System.Drawing.Color.Black;
			this.DepartureDTP2.Location = new System.Drawing.Point(188, 521);
			this.DepartureDTP2.Margin = new System.Windows.Forms.Padding(4);
			this.DepartureDTP2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.DepartureDTP2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.DepartureDTP2.Name = "DepartureDTP2";
			this.DepartureDTP2.OnHoverBaseColor = System.Drawing.Color.White;
			this.DepartureDTP2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.DepartureDTP2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.DepartureDTP2.OnPressedColor = System.Drawing.Color.Black;
			this.DepartureDTP2.Radius = 10;
			this.DepartureDTP2.Size = new System.Drawing.Size(297, 37);
			this.DepartureDTP2.TabIndex = 8;
			this.DepartureDTP2.Text = "Sunday, May 30, 2021";
			this.DepartureDTP2.Value = new System.DateTime(2021, 5, 30, 13, 12, 57, 98);
			this.DepartureDTP2.Visible = false;
			// 
			// DepartureDTP1
			// 
			this.DepartureDTP1.BackColor = System.Drawing.Color.Transparent;
			this.DepartureDTP1.BaseColor = System.Drawing.Color.White;
			this.DepartureDTP1.BorderColor = System.Drawing.Color.Silver;
			this.DepartureDTP1.BorderSize = 1;
			this.DepartureDTP1.CustomFormat = null;
			this.DepartureDTP1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.DepartureDTP1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.DepartureDTP1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.DepartureDTP1.ForeColor = System.Drawing.Color.Black;
			this.DepartureDTP1.Location = new System.Drawing.Point(188, 420);
			this.DepartureDTP1.Margin = new System.Windows.Forms.Padding(4);
			this.DepartureDTP1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.DepartureDTP1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.DepartureDTP1.Name = "DepartureDTP1";
			this.DepartureDTP1.OnHoverBaseColor = System.Drawing.Color.White;
			this.DepartureDTP1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.DepartureDTP1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.DepartureDTP1.OnPressedColor = System.Drawing.Color.Black;
			this.DepartureDTP1.Radius = 10;
			this.DepartureDTP1.Size = new System.Drawing.Size(297, 37);
			this.DepartureDTP1.TabIndex = 9;
			this.DepartureDTP1.Text = "Sunday, May 30, 2021";
			this.DepartureDTP1.Value = new System.DateTime(2021, 5, 30, 13, 12, 57, 98);
			// 
			// ArrivalDTP1
			// 
			this.ArrivalDTP1.BackColor = System.Drawing.Color.Transparent;
			this.ArrivalDTP1.BaseColor = System.Drawing.Color.White;
			this.ArrivalDTP1.BorderColor = System.Drawing.Color.Silver;
			this.ArrivalDTP1.BorderSize = 1;
			this.ArrivalDTP1.CustomFormat = null;
			this.ArrivalDTP1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.ArrivalDTP1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.ArrivalDTP1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ArrivalDTP1.ForeColor = System.Drawing.Color.Black;
			this.ArrivalDTP1.Location = new System.Drawing.Point(593, 420);
			this.ArrivalDTP1.Margin = new System.Windows.Forms.Padding(4);
			this.ArrivalDTP1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.ArrivalDTP1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.ArrivalDTP1.Name = "ArrivalDTP1";
			this.ArrivalDTP1.OnHoverBaseColor = System.Drawing.Color.White;
			this.ArrivalDTP1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.ArrivalDTP1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.ArrivalDTP1.OnPressedColor = System.Drawing.Color.Black;
			this.ArrivalDTP1.Radius = 10;
			this.ArrivalDTP1.Size = new System.Drawing.Size(297, 37);
			this.ArrivalDTP1.TabIndex = 7;
			this.ArrivalDTP1.Text = "Sunday, May 30, 2021";
			this.ArrivalDTP1.Value = new System.DateTime(2021, 5, 30, 13, 12, 57, 98);
			// 
			// ArrivalDTP2
			// 
			this.ArrivalDTP2.BackColor = System.Drawing.Color.Transparent;
			this.ArrivalDTP2.BaseColor = System.Drawing.Color.White;
			this.ArrivalDTP2.BorderColor = System.Drawing.Color.Silver;
			this.ArrivalDTP2.BorderSize = 1;
			this.ArrivalDTP2.CustomFormat = null;
			this.ArrivalDTP2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.ArrivalDTP2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.ArrivalDTP2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ArrivalDTP2.ForeColor = System.Drawing.Color.Black;
			this.ArrivalDTP2.Location = new System.Drawing.Point(593, 521);
			this.ArrivalDTP2.Margin = new System.Windows.Forms.Padding(4);
			this.ArrivalDTP2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.ArrivalDTP2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.ArrivalDTP2.Name = "ArrivalDTP2";
			this.ArrivalDTP2.OnHoverBaseColor = System.Drawing.Color.White;
			this.ArrivalDTP2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.ArrivalDTP2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.ArrivalDTP2.OnPressedColor = System.Drawing.Color.Black;
			this.ArrivalDTP2.Radius = 10;
			this.ArrivalDTP2.Size = new System.Drawing.Size(297, 37);
			this.ArrivalDTP2.TabIndex = 6;
			this.ArrivalDTP2.Text = "Sunday, May 30, 2021";
			this.ArrivalDTP2.Value = new System.DateTime(2021, 5, 30, 13, 12, 57, 98);
			this.ArrivalDTP2.Visible = false;
			// 
			// TripPriceTB
			// 
			this.TripPriceTB.BackColor = System.Drawing.Color.Transparent;
			this.TripPriceTB.BaseColor = System.Drawing.Color.White;
			this.TripPriceTB.BorderColor = System.Drawing.Color.Silver;
			this.TripPriceTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.TripPriceTB.FocusedBaseColor = System.Drawing.Color.White;
			this.TripPriceTB.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.TripPriceTB.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.TripPriceTB.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.TripPriceTB.Location = new System.Drawing.Point(714, 301);
			this.TripPriceTB.Margin = new System.Windows.Forms.Padding(4);
			this.TripPriceTB.Name = "TripPriceTB";
			this.TripPriceTB.PasswordChar = '\0';
			this.TripPriceTB.Radius = 10;
			this.TripPriceTB.SelectedText = "";
			this.TripPriceTB.Size = new System.Drawing.Size(297, 30);
			this.TripPriceTB.TabIndex = 5;
			// 
			// TripsidCB
			// 
			this.TripsidCB.BackColor = System.Drawing.Color.Transparent;
			this.TripsidCB.BaseColor = System.Drawing.Color.White;
			this.TripsidCB.BorderColor = System.Drawing.Color.Silver;
			this.TripsidCB.BorderSize = 1;
			this.TripsidCB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.TripsidCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.TripsidCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TripsidCB.FocusedColor = System.Drawing.Color.Empty;
			this.TripsidCB.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TripsidCB.ForeColor = System.Drawing.Color.Black;
			this.TripsidCB.FormattingEnabled = true;
			this.TripsidCB.Location = new System.Drawing.Point(101, 169);
			this.TripsidCB.Margin = new System.Windows.Forms.Padding(4);
			this.TripsidCB.Name = "TripsidCB";
			this.TripsidCB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.TripsidCB.OnHoverItemForeColor = System.Drawing.Color.White;
			this.TripsidCB.Radius = 10;
			this.TripsidCB.Size = new System.Drawing.Size(252, 28);
			this.TripsidCB.TabIndex = 28;
			// 
			// gunaLabel8
			// 
			this.gunaLabel8.AutoSize = true;
			this.gunaLabel8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.gunaLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.gunaLabel8.Location = new System.Drawing.Point(106, 142);
			this.gunaLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.gunaLabel8.Name = "gunaLabel8";
			this.gunaLabel8.Size = new System.Drawing.Size(40, 23);
			this.gunaLabel8.TabIndex = 29;
			this.gunaLabel8.Text = "Trip";
			// 
			// Manage_Trips
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1096, 832);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Manage_Trips";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manage_Trips";
			this.Load += new System.EventHandler(this.Manage_Trips_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private Guna.UI.WinForms.GunaLabel gunaLabel1;
		private Guna.UI.WinForms.GunaDateTimePicker DepartureDTP2;
		private Guna.UI.WinForms.GunaDateTimePicker DepartureDTP1;
		private Guna.UI.WinForms.GunaDateTimePicker ArrivalDTP1;
		private Guna.UI.WinForms.GunaDateTimePicker ArrivalDTP2;
		private Guna.UI.WinForms.GunaTextBox TripPriceTB;
		private Guna.UI.WinForms.GunaComboBox FromAirportCB;
		private Guna.UI.WinForms.GunaComboBox FlightNamesCB;
		private Guna.UI.WinForms.GunaComboBox ToAirportCB;
		private Guna.UI.WinForms.GunaComboBox RemarkCB;
		private Guna.UI.WinForms.GunaButton AddFlightBTN;
		private Guna.UI.WinForms.GunaButton DeleteTripBTN;
		private Guna.UI.WinForms.GunaButton UpdateTripBTN;
		private System.Windows.Forms.RadioButton OneWayRB;
		private System.Windows.Forms.RadioButton ReturnRB;
		private Guna.UI.WinForms.GunaLabel ArrivalLabel2;
		private Guna.UI.WinForms.GunaLabel DepartureLabel2;
		private Guna.UI.WinForms.GunaLabel gunaLabel7;
		private Guna.UI.WinForms.GunaLabel gunaLabel6;
		private Guna.UI.WinForms.GunaLabel gunaLabel5;
		private Guna.UI.WinForms.GunaLabel gunaLabel4;
		private Guna.UI.WinForms.GunaLabel gunaLabel3;
		private Guna.UI.WinForms.GunaLabel gunaLabel2;
		private Guna.UI.WinForms.GunaLabel gunaLabel8;
		private Guna.UI.WinForms.GunaComboBox TripsidCB;
	}
}