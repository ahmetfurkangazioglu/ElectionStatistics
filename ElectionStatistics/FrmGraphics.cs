using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionStatistics
{
    public partial class FrmGraphics : Form
    {
        public FrmGraphics()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-GME4UDL\;Initial Catalog=DbElectionStatistics;Integrated Security=True");
        private void FrmGraphics_Load(object sender, EventArgs e)
        {
            //City cekme
            SqlCommand command1 = new SqlCommand("select Sehir from tblelection", connect);
            connect.Open();
            SqlDataReader dr1 = command1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1[0]);
            }
            connect.Close();


            // Grafik Cekme
            SqlCommand command = new SqlCommand("select sum(AkParti),sum(ChpParti),sum(IyiParti),sum(MhpParti),sum(GelecekParti),sum(AfgParti) from tblelection", connect);
            connect.Open();
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Party"].Points.AddXY("AKP", dr[0]);
                chart1.Series["Party"].Points.AddXY("CHP", dr[1]);
                chart1.Series["Party"].Points.AddXY("iyi", dr[2]);
                chart1.Series["Party"].Points.AddXY("MHP", dr[3]);
                chart1.Series["Party"].Points.AddXY("GELECEK", dr[4]);
                chart1.Series["Party"].Points.AddXY("AFG", dr[5]);               
            }
            connect.Close();

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from tblelection where Sehir=@p1", connect);
            connect.Open();
            command.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());
                progressBar6.Value = int.Parse(dr[7].ToString());

                lblAkp.Text = dr[2].ToString();
                lblChp.Text = dr[3].ToString();
                lblIyi.Text = dr[4].ToString();
                lblMhp.Text = dr[5].ToString();
                lblGelecek.Text = dr[6].ToString();
                lblAfg.Text = dr[7].ToString();
            }
            connect.Close();
        }
    }
}
