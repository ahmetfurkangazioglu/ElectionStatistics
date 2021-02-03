using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ElectionStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-GME4UDL\;Initial Catalog=DbElectionStatistics;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("insert into TblElection (Sehir,Akparti,ChpParti,IyiParti,MhpParti,GelecekParti,AfgPARTİ) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connect);
            command.Parameters.AddWithValue("@p1", comboBox1.Text);
            command.Parameters.AddWithValue("@p2", txtAkp.Text);
            command.Parameters.AddWithValue("@p3", txtChp.Text);
            command.Parameters.AddWithValue("@p4", txtIyi.Text);
            command.Parameters.AddWithValue("@p5", txtMhp.Text);
            command.Parameters.AddWithValue("@p6", txtGelecek.Text);
            command.Parameters.AddWithValue("@p7", txtAfg.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Election Added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGraphics frm = new FrmGraphics();
            frm.Show();

        }
    }
}
