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

namespace animation_sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            season_combobox.Items.Add("Spring");
            season_combobox.Items.Add("Summer");
            season_combobox.Items.Add("Fall");
            season_combobox.Items.Add("Winter");

            for (int i = 2000; i < 2019; ++i)
                year_combobox.Items.Add(i.ToString());

            gender_combobox.Items.Add("Female");
            gender_combobox.Items.Add("Male");
            gender_combobox.Items.Add("Both");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                "Integrated Security=True";

            try
            {
                db = new SqlConnection(cn);
                db.Open();
                //MessageBox.Show(db.Database, "database");
                //MessageBox.Show("connection success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Close();
        }

        private void season_btn_Click(object sender, EventArgs e)
        {
            if (db == null)
                return;

            string sql_cmd = "Select anime_id, title, premiered FROM anime WHERE premiered = '" +
                season_combobox.SelectedItem.ToString() + " " +
                year_combobox.SelectedItem.ToString() + "'";

            ds = new DataSet();
            SqlDataAdapter sql_da = new SqlDataAdapter(sql_cmd, db);
            sql_da.Fill(ds, "anime_premier");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "anime_premier";
        }

        private void how_many_btn_Click(object sender, EventArgs e)
        {
            if (db == null || dataGridView1.SelectedCells == null)
                return;

            string sql_cmd = "";
            
            if (gender_combobox.SelectedItem != null)
            {
                //sql_cmd = "Select COUNT(a.username) FROM animelist AS a, userdata AS b WHERE a.anime_id = " +
                //    dataGridView1.SelectedCells[0].Value.ToString();

                //string gender = gender_combobox.SelectedItem.ToString();

                // relation
                sql_cmd = "Select COUNT(a.username) FROM animelist AS a, userdata AS b WHERE a.anime_id = " +
                    dataGridView1.SelectedCells[0].Value.ToString() + " AND (a.username = b.username) ";

                string gender = gender_combobox.SelectedItem.ToString();

                if (gender != "Both")
                    sql_cmd += " AND b.gender = '" + gender + "'";

                // join
                //sql_cmd = "Select COUNT(a.username) FROM animelist AS a INNER JOIN userdata AS b ON (a.username = b.username AND a.anime_id = " +
                //        dataGridView1.SelectedCells[0].Value.ToString();

                //string gender = gender_combobox.SelectedItem.ToString();

                //if (gender != "Both")
                //    sql_cmd += " AND b.gender = '" + gender + "'";

                //sql_cmd += ")";
            }
            else
            {
                sql_cmd = "Select COUNT(username) FROM animelist WHERE anime_id = " + 
                    dataGridView1.SelectedCells[0].Value.ToString();
            }

            ds = new DataSet();
            SqlDataAdapter sql_da = new SqlDataAdapter(sql_cmd, db);
            sql_da.Fill(ds, "how_many_people");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "how_many_people";
        }

        SqlConnection db = null;
        DataSet ds;
    }
}
