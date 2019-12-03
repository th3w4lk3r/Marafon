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
    public partial class Form_runnerview : Form
    {
        public Form_runnerview()
        {
            InitializeComponent();
        }

        private void Form_runnerview_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_МарафонV1_1DataSet.Бегуны". При необходимости она может быть перемещена или удалена.
            this.бегуныTableAdapter.Fill(this._МарафонV1_1DataSet.Бегуны);

            textBox1.Text = dataGridView1.Rows[Class1.IDuser].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[Class1.IDuser].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[Class1.IDuser].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=МарафонV1.1;Integrated Security=True";
            SqlConnection Conn = new SqlConnection(strConn);
            Conn.Open();

            var cmd = new SqlCommand("INSERT INTO [Результатыы забега] ([ID],[Фамилия], [Спонсор], [Км],[Время],[Место]) VALUES (@id, @fio, @sponsor,@km,@time, @place)", Conn);
            cmd.Parameters.Add("@id", dataGridView1.Rows[Class1.IDuser].Cells[0].Value.ToString());
            cmd.Parameters.Add("@fio", textBox1.Text);
            cmd.Parameters.Add("@sponsor", textBox2.Text);
            cmd.Parameters.Add("@km", textBox3.Text);
            cmd.Parameters.Add("@time", textBox4.Text);
            cmd.Parameters.Add("@place", textBox5.Text);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
