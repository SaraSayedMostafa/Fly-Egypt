
namespace WindowsFormsApplication3
{
	partial class Manage_Seats
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
			this.FromSeatCB = new Guna.UI.WinForms.GunaComboBox();
			this.OneWayRB = new System.Windows.Forms.RadioButton();
			this.ReturnRB = new System.Windows.Forms.RadioButton();
			this.DeleteTripBTN = new Guna.UI.WinForms.GunaButton();
			this.UpdateTripBTN = new Guna.UI.WinForms.GunaButton();
			this.AddFlightBTN = new Guna.UI.WinForms.GunaButton();
			this.ToSeatCB = new Guna.UI.WinForms.GunaComboBox();
			this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
			this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
			this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
			this.SeatTypeCB = new Guna.UI.WinForms.GunaComboBox();
			this.SeatPriceTB = new Guna.UI.WinForms.GunaTextBox();
			this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
			this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
			this.SetSeatsBTN = new Guna.UI.WinForms.GunaButton();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.panel2.Controls.Add(this.SetSeatsBTN);
			this.panel2.Controls.Add(this.gunaLinePanel1);
			this.panel2.Controls.Add(this.gunaLabel4);
			this.panel2.Controls.Add(this.SeatPriceTB);
			this.panel2.Controls.Add(this.SeatTypeCB);
			this.panel2.Controls.Add(this.gunaLabel3);
			this.panel2.Controls.Add(this.gunaLabel2);
			this.panel2.Controls.Add(this.gunaLabel1);
			this.panel2.Controls.Add(this.ToSeatCB);
			this.panel2.Controls.Add(this.gunaLabel8);
			this.panel2.Controls.Add(this.FromSeatCB);
			this.panel2.Controls.Add(this.OneWayRB);
			this.panel2.Controls.Add(this.ReturnRB);
			this.panel2.Controls.Add(this.DeleteTripBTN);
			this.panel2.Controls.Add(this.UpdateTripBTN);
			this.panel2.Controls.Add(this.AddFlightBTN);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(772, 583);
			this.panel2.TabIndex = 11;
			// 
			// gunaLabel8
			// 
			this.gunaLabel8.AutoSize = true;
			this.gunaLabel8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.gunaLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.gunaLabel8.Location = new System.Drawing.Point(91, 185);
			this.gunaLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.gunaLabel8.Name = "gunaLabel8";
			this.gunaLabel8.Size = new System.Drawing.Size(92, 23);
			this.gunaLabel8.TabIndex = 29;
			this.gunaLabel8.Text = "From Seat";
			// 
			// FromSeatCB
			// 
			this.FromSeatCB.BackColor = System.Drawing.Color.Transparent;
			this.FromSeatCB.BaseColor = System.Drawing.Color.White;
			this.FromSeatCB.BorderColor = System.Drawing.Color.Silver;
			this.FromSeatCB.BorderSize = 1;
			this.FromSeatCB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FromSeatCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.FromSeatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FromSeatCB.FocusedColor = System.Drawing.Color.Empty;
			this.FromSeatCB.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FromSeatCB.ForeColor = System.Drawing.Color.Black;
			this.FromSeatCB.FormattingEnabled = true;
			this.FromSeatCB.Location = new System.Drawing.Point(95, 212);
			this.FromSeatCB.Margin = new System.Windows.Forms.Padding(4);
			this.FromSeatCB.Name = "FromSeatCB";
			this.FromSeatCB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.FromSeatCB.OnHoverItemForeColor = System.Drawing.Color.White;
			this.FromSeatCB.Radius = 10;
			this.FromSeatCB.Size = new System.Drawing.Size(252, 28);
			this.FromSeatCB.TabIndex = 28;
			// 
			// OneWayRB
			// 
			this.OneWayRB.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.OneWayRB.AutoSize = true;
			this.OneWayRB.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
			this.OneWayRB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.OneWayRB.Location = new System.Drawing.Point(439, -77);
			this.OneWayRB.Margin = new System.Windows.Forms.Padding(4);
			this.OneWayRB.Name = "OneWayRB";
			this.OneWayRB.Size = new System.Drawing.Size(92, 24);
			this.OneWayRB.TabIndex = 19;
			this.OneWayRB.TabStop = true;
			this.OneWayRB.Text = "One way";
			this.OneWayRB.UseVisualStyleBackColor = true;
			// 
			// ReturnRB
			// 
			this.ReturnRB.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ReturnRB.AutoSize = true;
			this.ReturnRB.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
			this.ReturnRB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.ReturnRB.Location = new System.Drawing.Point(147, -77);
			this.ReturnRB.Margin = new System.Windows.Forms.Padding(4);
			this.ReturnRB.Name = "ReturnRB";
			this.ReturnRB.Size = new System.Drawing.Size(78, 24);
			this.ReturnRB.TabIndex = 18;
			this.ReturnRB.TabStop = true;
			this.ReturnRB.Text = "Rerurn";
			this.ReturnRB.UseVisualStyleBackColor = true;
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
			// 
			// ToSeatCB
			// 
			this.ToSeatCB.BackColor = System.Drawing.Color.Transparent;
			this.ToSeatCB.BaseColor = System.Drawing.Color.White;
			this.ToSeatCB.BorderColor = System.Drawing.Color.Silver;
			this.ToSeatCB.BorderSize = 1;
			this.ToSeatCB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ToSeatCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.ToSeatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ToSeatCB.FocusedColor = System.Drawing.Color.Empty;
			this.ToSeatCB.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ToSeatCB.ForeColor = System.Drawing.Color.Black;
			this.ToSeatCB.FormattingEnabled = true;
			this.ToSeatCB.Location = new System.Drawing.Point(384, 212);
			this.ToSeatCB.Margin = new System.Windows.Forms.Padding(4);
			this.ToSeatCB.Name = "ToSeatCB";
			this.ToSeatCB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.ToSeatCB.OnHoverItemForeColor = System.Drawing.Color.White;
			this.ToSeatCB.Radius = 10;
			this.ToSeatCB.Size = new System.Drawing.Size(252, 28);
			this.ToSeatCB.TabIndex = 30;
			// 
			// gunaLabel1
			// 
			this.gunaLabel1.AutoSize = true;
			this.gunaLabel1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.gunaLabel1.Location = new System.Drawing.Point(380, 185);
			this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.gunaLabel1.Name = "gunaLabel1";
			this.gunaLabel1.Size = new System.Drawing.Size(68, 23);
			this.gunaLabel1.TabIndex = 31;
			this.gunaLabel1.Text = "To Seat";
			// 
			// gunaLabel2
			// 
			this.gunaLabel2.AutoSize = true;
			this.gunaLabel2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.gunaLabel2.Location = new System.Drawing.Point(91, 303);
			this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.gunaLabel2.Name = "gunaLabel2";
			this.gunaLabel2.Size = new System.Drawing.Size(88, 23);
			this.gunaLabel2.TabIndex = 32;
			this.gunaLabel2.Text = "Seat Type";
			// 
			// gunaLabel3
			// 
			this.gunaLabel3.AutoSize = true;
			this.gunaLabel3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.gunaLabel3.Location = new System.Drawing.Point(389, 303);
			this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.gunaLabel3.Name = "gunaLabel3";
			this.gunaLabel3.Size = new System.Drawing.Size(91, 23);
			this.gunaLabel3.TabIndex = 33;
			this.gunaLabel3.Text = "Seat Price";
			// 
			// SeatTypeCB
			// 
			this.SeatTypeCB.BackColor = System.Drawing.Color.Transparent;
			this.SeatTypeCB.BaseColor = System.Drawing.Color.White;
			this.SeatTypeCB.BorderColor = System.Drawing.Color.Silver;
			this.SeatTypeCB.BorderSize = 1;
			this.SeatTypeCB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SeatTypeCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.SeatTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SeatTypeCB.FocusedColor = System.Drawing.Color.Empty;
			this.SeatTypeCB.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SeatTypeCB.ForeColor = System.Drawing.Color.Black;
			this.SeatTypeCB.FormattingEnabled = true;
			this.SeatTypeCB.Items.AddRange(new object[] {
            "Economic",
            "Business",
            "First Class"});
			this.SeatTypeCB.Location = new System.Drawing.Point(95, 330);
			this.SeatTypeCB.Margin = new System.Windows.Forms.Padding(4);
			this.SeatTypeCB.Name = "SeatTypeCB";
			this.SeatTypeCB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.SeatTypeCB.OnHoverItemForeColor = System.Drawing.Color.White;
			this.SeatTypeCB.Radius = 10;
			this.SeatTypeCB.Size = new System.Drawing.Size(252, 28);
			this.SeatTypeCB.TabIndex = 34;
			// 
			// SeatPriceTB
			// 
			this.SeatPriceTB.BackColor = System.Drawing.Color.Transparent;
			this.SeatPriceTB.BaseColor = System.Drawing.Color.White;
			this.SeatPriceTB.BorderColor = System.Drawing.Color.Silver;
			this.SeatPriceTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.SeatPriceTB.FocusedBaseColor = System.Drawing.Color.White;
			this.SeatPriceTB.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.SeatPriceTB.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.SeatPriceTB.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.SeatPriceTB.Location = new System.Drawing.Point(384, 330);
			this.SeatPriceTB.Margin = new System.Windows.Forms.Padding(4);
			this.SeatPriceTB.Name = "SeatPriceTB";
			this.SeatPriceTB.PasswordChar = '\0';
			this.SeatPriceTB.Radius = 10;
			this.SeatPriceTB.SelectedText = "";
			this.SeatPriceTB.Size = new System.Drawing.Size(252, 30);
			this.SeatPriceTB.TabIndex = 35;
			// 
			// gunaLinePanel1
			// 
			this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
			this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
			this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
			this.gunaLinePanel1.Location = new System.Drawing.Point(95, 107);
			this.gunaLinePanel1.Name = "gunaLinePanel1";
			this.gunaLinePanel1.Size = new System.Drawing.Size(541, 5);
			this.gunaLinePanel1.TabIndex = 37;
			// 
			// gunaLabel4
			// 
			this.gunaLabel4.AutoSize = true;
			this.gunaLabel4.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.gunaLabel4.Location = new System.Drawing.Point(91, 78);
			this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.gunaLabel4.Name = "gunaLabel4";
			this.gunaLabel4.Size = new System.Drawing.Size(175, 24);
			this.gunaLabel4.TabIndex = 36;
			this.gunaLabel4.Text = "Seats Management";
			// 
			// SetSeatsBTN
			// 
			this.SetSeatsBTN.AnimationHoverSpeed = 0.07F;
			this.SetSeatsBTN.AnimationSpeed = 0.03F;
			this.SetSeatsBTN.BackColor = System.Drawing.Color.Transparent;
			this.SetSeatsBTN.BaseColor = System.Drawing.Color.White;
			this.SetSeatsBTN.BorderColor = System.Drawing.Color.Black;
			this.SetSeatsBTN.BorderSize = 2;
			this.SetSeatsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SetSeatsBTN.DialogResult = System.Windows.Forms.DialogResult.None;
			this.SetSeatsBTN.FocusedColor = System.Drawing.Color.Empty;
			this.SetSeatsBTN.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
			this.SetSeatsBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.SetSeatsBTN.Image = null;
			this.SetSeatsBTN.ImageSize = new System.Drawing.Size(20, 20);
			this.SetSeatsBTN.Location = new System.Drawing.Point(274, 453);
			this.SetSeatsBTN.Margin = new System.Windows.Forms.Padding(4);
			this.SetSeatsBTN.Name = "SetSeatsBTN";
			this.SetSeatsBTN.OnHoverBaseColor = System.Drawing.Color.White;
			this.SetSeatsBTN.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.SetSeatsBTN.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.SetSeatsBTN.OnHoverImage = null;
			this.SetSeatsBTN.OnPressedColor = System.Drawing.Color.Black;
			this.SetSeatsBTN.Radius = 20;
			this.SetSeatsBTN.Size = new System.Drawing.Size(174, 42);
			this.SetSeatsBTN.TabIndex = 38;
			this.SetSeatsBTN.Text = "Set ";
			this.SetSeatsBTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.SetSeatsBTN.Click += new System.EventHandler(this.SetSeatsBTN_Click);
			// 
			// Manage_Seats
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(772, 583);
			this.Controls.Add(this.panel2);
			this.Name = "Manage_Seats";
			this.Text = "Manage_Seats";
			this.Load += new System.EventHandler(this.Manage_Seats_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private Guna.UI.WinForms.GunaLabel gunaLabel8;
		private Guna.UI.WinForms.GunaComboBox FromSeatCB;
		private System.Windows.Forms.RadioButton OneWayRB;
		private System.Windows.Forms.RadioButton ReturnRB;
		private Guna.UI.WinForms.GunaButton DeleteTripBTN;
		private Guna.UI.WinForms.GunaButton UpdateTripBTN;
		private Guna.UI.WinForms.GunaButton AddFlightBTN;
		private Guna.UI.WinForms.GunaLabel gunaLabel1;
		private Guna.UI.WinForms.GunaComboBox ToSeatCB;
		private Guna.UI.WinForms.GunaComboBox SeatTypeCB;
		private Guna.UI.WinForms.GunaLabel gunaLabel3;
		private Guna.UI.WinForms.GunaLabel gunaLabel2;
		private Guna.UI.WinForms.GunaTextBox SeatPriceTB;
		private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
		private Guna.UI.WinForms.GunaLabel gunaLabel4;
		private Guna.UI.WinForms.GunaButton SetSeatsBTN;
	}
}