using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registoclientes
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=11111");
                string querry = "select  * from  registoclientes.login where usuario =  '" + txtusuario + "' and  senha='" + txtsenha + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(querry, connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    Form1 F3 = new Form1();
                    F3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Dados incorrectos!");
                }
            }
        }
    }
}
