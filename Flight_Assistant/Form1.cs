using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Flight_Assistant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findflights_Click_1(object sender, EventArgs e)
        {
            try
            {



                String orderby = "";
                if(cheapestflight.Checked)
                {
                   
                     orderby = "order by F.flight_price ASC";
                    
                    
                }
            


                string Query="";


                if (airlinecheck.Checked)
                {


                    Query = "select A.airline_name, F.flight_no,F.flight_price, AR.arrival_time, AP2.AirportName,AP2.AirportLoc,AP1.AirportName,AP1.AirportLoc from airline A, flights F, arrives AR, departs D,airport AP1,airport AP2 where A.airline_name = " + "\"" + textBox1.Text + "\"  and A.flight_no = F.flight_no and F.arrival_time = AR.arrival_time and AR.AirportName = AP1.AirportName and F.departure_time = D.departure_time and D.AirportName = AP2.AirportName" + orderby;
                }
                else if (departureairportcheck.Checked && !arrivalairportcheck.Checked)
                {

                    Query = "select  F.flight_no, F.arrival_time, F.departure_time, F.flight_price,a.AirportName,a.AirportLoc,Air.airline_name from flights F,departs d, airport a,airline Air where F.flight_no=Air.flight_no and d.flight_no=F.flight_no AND d.AirportName=a.AirportName AND d.AirportName=" + "\"" + departureairport.Text + "\"" + orderby;
                }

                else if (arrivalairportcheck.Checked && !departureairportcheck.Checked)
                {
                    Query = "select  F.flight_no, F.arrival_time, F.departure_time, F.flight_price,a.AirportName,a.AirportLoc,Air.airline_name from flights F,arrives arr, airport a,airline Air where F.flight_no=Air.flight_no and arr.flight_no=F.flight_no AND arr.AirportName=a.AirportName AND arr.AirportName=" + "\"" + arrivalairport.Text + "\"" + orderby;
                }

                else if (departuredatecheck.Checked && !arrivaldatecheck.Checked)
                {
                    DateTime d = departuredate.Value;

                    Query = "select F.flight_no, F.arrival_time,D.flight_no, D.departure_time,A.AirportName,A.AirportLoc,Air.airline_name,F.flight_price from departs D,flights F, airport A,airline Air where D.flight_no=F.flight_no AND D.AirportName=A.AirportName AND F.flight_no=Air.flight_no  AND date(D.departure_time) =" + "\"" + d.Year + "-" + d.Month + "-" + d.Day + "\"" + orderby;
                }
                else if (arrivaldatecheck.Checked && !departuredatecheck.Checked)
                {
                    DateTime d = arrivaldate.Value;

                    Query = "select   F.flight_no, F.departure_time,E.flight_no, E.arrival_time,A.AirportName,A.AirportLoc,Air.airline_name,F.flight_price from arrives E,flights F, airport A,airline Air where F.flight_no=E.flight_no and E.AirportName=A.AirportName and F.flight_no=Air.flight_no AND date(E.arrival_time) =" + "\"" + d.Year + "-" + d.Month + "-" + d.Day + "\"" + orderby;
                }
                else if (departuredatecheck.Checked && arrivaldatecheck.Checked)
                {
                    DateTime d1 = arrivaldate.Value;
                    DateTime d2 = departuredate.Value;
                    Query = "select  F.flight_no, F.departure_time, E.arrival_time,A1.AirportName,A1.AirportLoc,A2.AirportName,A2.AirportLoc,F.flight_price from arrives E, departs D,flights F, airport A1,airport A2 where E.arrival_time=F.arrival_time and D.departure_time =F.departure_time   and D.AirportName=A1.AirportName and E.AirportName=A2.AirportName and date(E.arrival_time) =" + "\"" + d1.Year + "-" + d1.Month + "-" + d1.Day + "\" and date(D.departure_time) =" + "\"" + d2.Year + "-" + d2.Month + "-" + d2.Day + "\"" + orderby;
                }
                else
                {
                    Query = "select all  F.flight_no, F.arrival_time, F.departure_time, F.flight_price from flights F";
                }
                string Connection = "server=localhost;user id=root;pwd=5050;database=flightassistant";
               
               
               
                MySqlConnection Conn = new MySqlConnection(Connection);


                
                MySqlDataAdapter adapter = new MySqlDataAdapter(Query, Conn);
                    
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
               


                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
    }
}
