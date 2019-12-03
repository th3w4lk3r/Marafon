using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Марафон1._1
{
    public partial class Form_admin : Form
    {
        public Form_admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=МарафонV1.1;Integrated Security=True";

            SqlConnection conn = new SqlConnection(strConn);
            try
            {
                conn.Open();
            }
            catch (SqlException se)
            {
                return;
            }

            SqlCommand cmd = new SqlCommand("Update Users" + " Set StatusReg = @StatusReg where ID = @id", conn);

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ID";
            param.Value = dataGridView1.CurrentRow.Index + 1;
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@StatusReg";
            param.Value = "ok";
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return;
            }

            //закрвываем соединение
            conn.Close();
            conn.Dispose();

            this.usersTableAdapter.Fill(this._МарафонV1_1DataSet.Users);
        }

        private void Form_admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_МарафонV1_1DataSet.Бегуны". При необходимости она может быть перемещена или удалена.
            this.бегуныTableAdapter.Fill(this._МарафонV1_1DataSet.Бегуны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_МарафонV1_1DataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this._МарафонV1_1DataSet.Users);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.IDuser = dataGridView1.CurrentRow.Index;
            Form_runnerview f = new Form_runnerview();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_result f = new Form_result();
            f.Show();
        }
    }
}

