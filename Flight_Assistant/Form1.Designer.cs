namespace Flight_Assistant
{
    partial class Form1
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
            this.departuredate = new System.Windows.Forms.DateTimePicker();
            this.arrivaldate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.arrivalairport = new System.Windows.Forms.TextBox();
            this.departureairport = new System.Windows.Forms.TextBox();
            this.airlinecheck = new System.Windows.Forms.CheckBox();
            this.arrivaldatecheck = new System.Windows.Forms.CheckBox();
            this.arrivalairportcheck = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cheapestflight = new System.Windows.Forms.CheckBox();
            this.departuredatecheck = new System.Windows.Forms.CheckBox();
            this.departureairportcheck = new System.Windows.Forms.CheckBox();
            this.findflights = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // departuredate
            // 
            this.departuredate.Location = new System.Drawing.Point(966, 274);
            this.departuredate.Name = "departuredate";
            this.departuredate.Size = new System.Drawing.Size(281, 26);
            this.departuredate.TabIndex = 0;
            // 
            // arrivaldate
            // 
            this.arrivaldate.Location = new System.Drawing.Point(315, 274);
            this.arrivaldate.Name = "arrivaldate";
            this.arrivaldate.Size = new System.Drawing.Size(293, 26);
            this.arrivaldate.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            // 
            // arrivalairport
            // 
            this.arrivalairport.Location = new System.Drawing.Point(315, 370);
            this.arrivalairport.Name = "arrivalairport";
            this.arrivalairport.Size = new System.Drawing.Size(100, 26);
            this.arrivalairport.TabIndex = 4;
            // 
            // departureairport
            // 
            this.departureairport.Location = new System.Drawing.Point(966, 372);
            this.departureairport.Name = "departureairport";
            this.departureairport.Size = new System.Drawing.Size(100, 26);
            this.departureairport.TabIndex = 5;
            // 
            // airlinecheck
            // 
            this.airlinecheck.AutoSize = true;
            this.airlinecheck.Location = new System.Drawing.Point(45, 163);
            this.airlinecheck.Name = "airlinecheck";
            this.airlinecheck.Size = new System.Drawing.Size(147, 24);
            this.airlinecheck.TabIndex = 6;
            this.airlinecheck.Text = "Select by Airline";
            this.airlinecheck.UseVisualStyleBackColor = true;
            // 
            // arrivaldatecheck
            // 
            this.arrivaldatecheck.AutoSize = true;
            this.arrivaldatecheck.Location = new System.Drawing.Point(45, 272);
            this.arrivaldatecheck.Name = "arrivaldatecheck";
            this.arrivaldatecheck.Size = new System.Drawing.Size(186, 24);
            this.arrivaldatecheck.TabIndex = 7;
            this.arrivaldatecheck.Text = "Select by Arrival Date";
            this.arrivaldatecheck.UseVisualStyleBackColor = true;
            // 
            // arrivalairportcheck
            // 
            this.arrivalairportcheck.AutoSize = true;
            this.arrivalairportcheck.Location = new System.Drawing.Point(45, 370);
            this.arrivalairportcheck.Name = "arrivalairportcheck";
            this.arrivalairportcheck.Size = new System.Drawing.Size(198, 24);
            this.arrivalairportcheck.TabIndex = 8;
            this.arrivalairportcheck.Text = "Select by Arrival Airport";
            this.arrivalairportcheck.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1306, 662);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cheapestflight);
            this.tabPage1.Controls.Add(this.departuredatecheck);
            this.tabPage1.Controls.Add(this.departureairportcheck);
            this.tabPage1.Controls.Add(this.findflights);
            this.tabPage1.Controls.Add(this.arrivalairport);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.arrivalairportcheck);
            this.tabPage1.Controls.Add(this.departureairport);
            this.tabPage1.Controls.Add(this.airlinecheck);
            this.tabPage1.Controls.Add(this.arrivaldatecheck);
            this.tabPage1.Controls.Add(this.departuredate);
            this.tabPage1.Controls.Add(this.arrivaldate);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1298, 629);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Flight Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cheapestflight
            // 
            this.cheapestflight.AutoSize = true;
            this.cheapestflight.Location = new System.Drawing.Point(676, 165);
            this.cheapestflight.Name = "cheapestflight";
            this.cheapestflight.Size = new System.Drawing.Size(226, 24);
            this.cheapestflight.TabIndex = 13;
            this.cheapestflight.Text = "Order by the Cheaper Price";
            this.cheapestflight.UseVisualStyleBackColor = true;
            // 
            // departuredatecheck
            // 
            this.departuredatecheck.AutoSize = true;
            this.departuredatecheck.Location = new System.Drawing.Point(676, 272);
            this.departuredatecheck.Name = "departuredatecheck";
            this.departuredatecheck.Size = new System.Drawing.Size(215, 24);
            this.departuredatecheck.TabIndex = 12;
            this.departuredatecheck.Text = "Select by Departure Date";
            this.departuredatecheck.UseVisualStyleBackColor = true;
            // 
            // departureairportcheck
            // 
            this.departureairportcheck.AutoSize = true;
            this.departureairportcheck.Location = new System.Drawing.Point(676, 372);
            this.departureairportcheck.Name = "departureairportcheck";
            this.departureairportcheck.Size = new System.Drawing.Size(227, 24);
            this.departureairportcheck.TabIndex = 11;
            this.departureairportcheck.Text = "Select by Departure Airport";
            this.departureairportcheck.UseVisualStyleBackColor = true;
            // 
            // findflights
            // 
            this.findflights.Location = new System.Drawing.Point(513, 513);
            this.findflights.Name = "findflights";
            this.findflights.Size = new System.Drawing.Size(213, 37);
            this.findflights.TabIndex = 10;
            this.findflights.Text = "Find Flights";
            this.findflights.UseVisualStyleBackColor = true;
            this.findflights.Click += new System.EventHandler(this.findflights_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1298, 629);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Flight Results";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1289, 603);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 677);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Flight Assistant";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        

        private System.Windows.Forms.DateTimePicker departuredate;
        private System.Windows.Forms.DateTimePicker arrivaldate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox arrivalairport;
        private System.Windows.Forms.TextBox departureairport;
        private System.Windows.Forms.CheckBox airlinecheck;
        private System.Windows.Forms.CheckBox arrivaldatecheck;
        private System.Windows.Forms.CheckBox arrivalairportcheck;
    

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button findflights;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox departureairportcheck;
        private System.Windows.Forms.CheckBox departuredatecheck;
        private System.Windows.Forms.CheckBox cheapestflight;
    }
}

