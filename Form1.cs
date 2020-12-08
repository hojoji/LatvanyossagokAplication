using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokAplication
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;


        void tableCreate()
        {
            string createVaros = @"CREATE TABLE IF NOT EXISTS `varosok` (
                    `id` INT(6) AUTO_INCREMENT PRIMARY KEY,
                    `nev` VARCHAR(30) UNIQUE NOT NULL,
                    `lakossag` INT(30) NOT NULL
                    )";
            string createLatvany = @"CREATE TABLE IF NOT EXISTS latvanyossagok (
                    id INT(6) AUTO_INCREMENT PRIMARY KEY,
                    nev VARCHAR(30) NOT NULL,
                    leiras VARCHAR(80) NOT NULL,
                    ar INT(30) DEFAULT 0 NOT NULL,
                    varos_id INT(5) NOT NULL,
                    FOREIGN KEY(varos_id) REFERENCES varosok(id)
                    )";

            var comm = this.conn.CreateCommand();
            comm.CommandText = createVaros;
            comm.ExecuteNonQuery();
            var comm2 = this.conn.CreateCommand();
            comm2.CommandText = createLatvany;
            comm2.ExecuteNonQuery();


        }
        void varosBetoltes()
        {
            string sql = @"
            SELECT id, nev, lakossag
            FROM varosok
            ";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nev = reader.GetString("nev");
                    int lakossag = reader.GetInt32("lakossag");
                    int id = reader.GetInt32("id");
                    Varos v = new Varos(id, nev, lakossag);
                    varosokLb.Items.Add(v);

                }
                reader.Close();
            }

        }
        void latvanyossagBetoltes()
        {
            int vId=varosID(Convert.ToString(varosokLb.SelectedItem).Split('-')[0]);
            if (vId != -1)
            {
                string sql = @"
            SELECT id, nev, leiras, ar, varos_id
            FROM latvanyossagok
            WHERE varos_id=" + vId + "";
                var comm = this.conn.CreateCommand();
                comm.CommandText = sql;
                using (var reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nev = reader.GetString("nev");
                        string leiras = reader.GetString("leiras");
                        int id = reader.GetInt32("id");
                        int varosId = reader.GetInt32("varos_id");
                        int ar = reader.GetInt32("ar");
                        if (ar == 0)
                        {
                            latvanyossagLb.Items.Add(nev + " " + "Ingyenes");
                        }
                        else
                        {
                            latvanyossagLb.Items.Add(nev + " " + ar + "Ft");
                        }





                    }
                    reader.Close();
                }
            }
            

        }
        bool varosEllenorzes(string nevTxt)
        {
            bool van = false;
            string sql = @"SELECT id, nev, lakossag FROM varosok";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nev = reader.GetString("nev");
                    int lakossag = reader.GetInt32("lakossag");
                    if (nevTxt == nev)
                    {
                        van = true;
                    }

                }
                reader.Close();
            }
            return van;
        }
        int varosID(string nev)
        {
            int ki = -1;
            string sql = @"SELECT id FROM varosok WHERE nev LIKE '" + nev + "'";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            var reader = comm.ExecuteReader();
            while (reader.Read())
            {
                ki = reader.GetInt32("id");
            }
            reader.Close();

            return ki;
        }

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=latvanyossagokdb; Uid=root; Pwd=''");
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem sikerült csatlakozni");
            }

            this.FormClosed += (sender, args) =>
            {
                if (conn != null)
                {
                    conn.Close();
                }
            };

            tableCreate();
            varosBetoltes();
            latvanyossagBetoltes();


        }

        private void VarosFelveszBtn_Click(object sender, EventArgs e)
        {
            string nev = varosNevTxt.Text;
            string lakossag = varosLakossagTxt.Text;
            if (nev != "" && lakossag != "")
            {
                if (!varosEllenorzes(varosNevTxt.Text))
                {
                    string sql = @"
                     INSERT INTO `varosok`(`nev`, `lakossag`)
                        VALUES
                     ('" + nev + "','" + lakossag + "')";
                    var comm = this.conn.CreateCommand();
                    comm.CommandText = sql;
                    comm.ExecuteNonQuery();
                    varosokLb.Items.Clear();
                    varosBetoltes();
                }
                else
                {
                    MessageBox.Show("Már van ilyen város!");
                }
            }
            else
            {
                MessageBox.Show("Töltse ki a mezőket");
            }
        }

        private void LatvFelveszBtn_Click(object sender, EventArgs e)
        {
            string nev = latvNevTxt.Text;
            string ar = latvArTxt.Text;
            string leir = latvLeirTxt.Text;
            int varosId = varosID(Convert.ToString(varosokLb.SelectedItem).Split('-')[0]);
            if (nev != "" && ar != "" && leir != "")
            {
                if (varosId!=-1)
                {


                    string sql = @"INSERT INTO `latvanyossagok`(`nev`, `leiras`, `ar`, `varos_id`) VALUES ('" + nev + "','" + leir + "'," + ar + "," + varosId + ")";
                    var comm = this.conn.CreateCommand();
                    comm.CommandText = sql;
                    comm.ExecuteNonQuery();
                    varosokLb.Items.Clear();
                    varosBetoltes();
                }
                else
                {
                    MessageBox.Show("Válasszon ki várost!");
                }
            }
            else
            {
                MessageBox.Show("Töltse ki a mezőket");
            }
        }

        private void TorolBtn_Click(object sender, EventArgs e)
        {
           int id= varosID(Convert.ToString(varosokLb.SelectedItem).Split('-')[0]);
            if (!vanEVaros(id))
            {
                torolVaros(id);
                varosokLb.Items.Clear();
                varosBetoltes();
            }
            else
            {
                MessageBox.Show("A várost nem lehet törölni, mert vannak benne látványosságok");
            }
        }


        void torolVaros(int id)
        {
            string sql = @"DELETE FROM `varosok` WHERE id = " + id + "";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.ExecuteNonQuery();
        }
        bool vanEVaros(int id)
        {
            bool van = false;
            string sql = "SELECT `varos_id` FROM `latvanyossagok` WHERE varos_id = "+id+"";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            var reader = comm.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                van = true;
            }
            reader.Close();

            return van;
        }


        private void ModositBtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE `varosok` SET `nev`='"+modositNev.Text+"',`lakossag`='"+modositLakossag.Text+"' WHERE id="+varosID(Convert.ToString(varosokLb.SelectedItem).Split('-')[0]) +"";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.ExecuteNonQuery();
            panel2.Visible = false;
            varosokLb.Items.Clear();
            varosBetoltes();
        }

        private void VarosokLb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LatvListBtn_Click(object sender, EventArgs e)
        {
            latvanyossagLb.Items.Clear();
            latvanyossagBetoltes();
        }
    }

}
