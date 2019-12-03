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
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void button_regist_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=МарафонV1.1;Integrated Security=True";
                SqlConnection Conn = new SqlConnection(strConn);
                Conn.Open();

                var cmd = new SqlCommand("INSERT INTO [Users] ([ID],[Login], [Password], [Role],[StatusReg]) VALUES (@id, @login, @password,@role,@statusreg)", Conn);
                cmd.Parameters.Add("@id", Class1.countUsers + 1);
                cmd.Parameters.Add("@login", textBox1.Text);
                cmd.Parameters.Add("@password", textBox2.Text);
                cmd.Parameters.Add("@role", comboBox1.SelectedItem);
                cmd.Parameters.Add("@statusreg", "neok");
                cmd.ExecuteNonQuery();
                Conn.Close();

                string role = comboBox1.SelectedItem.ToString();

                switch(role)
                {
                    case "Бегун":
                        Conn.Open();
                        var cmd1 = new SqlCommand("INSERT INTO [Бегуны] ([ID],[Фамилия], [Спонсор], [Км]) VALUES (@id, @fio,@sponsor,@km)", Conn);
                        cmd1.Parameters.Add("@id", Class1.countUsers + 1);
                        cmd1.Parameters.Add("@fio", textBox3.Text);
                        cmd1.Parameters.Add("@sponsor", comboBox2.SelectedItem.ToString());
                        cmd1.Parameters.Add("@km", comboBox3.SelectedItem);
                        cmd1.ExecuteNonQuery();
                        Conn.Close();

                        string temp,id = "";
                        int numb = 0;

                        for (int i = 0; i < dataGridView3.RowCount; i++)
                        {
                            temp = dataGridView3.Rows[i].Cells[1].Value.ToString();
                            if (temp == comboBox2.SelectedItem.ToString())
                            {
                                numb = i;
                                id = dataGridView3.Rows[i].Cells[0].Value.ToString();
                                break;
                            }
                        }

                        
                        try
                        {
                            Conn.Open();
                        }
                        catch (SqlException se)
                        {
                            return;
                        }

                        SqlCommand cmd1_1 = new SqlCommand("Update Спонсоры" + " Set [Кого спонсирует] = @namerun where ID = @ID", Conn);

                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@ID";
                        param.Value = id;
                        param.SqlDbType = SqlDbType.VarChar;
                        cmd1_1.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@namerun";
                        param.Value = textBox3.Text.ToString();
                        param.SqlDbType = SqlDbType.VarChar;
                        cmd1_1.Parameters.Add(param);

                        try
                        {
                            cmd1_1.ExecuteNonQuery();
                        }
                        catch
                        {
                            return;
                        }

                        //закрвываем соединение
                        Conn.Close();
                        Conn.Dispose();

                        this.спонсорыTableAdapter.Fill(this._МарафонV1_1DataSet.Спонсоры);

                        

                        break;
                    case "Спонсор":
                        Conn.Open();
                        var cmd2 = new SqlCommand("INSERT INTO [Спонсоры] ([ID],[Название], [Кого спонсирует]) VALUES (@id, @name, @namerun)", Conn);
                        cmd2.Parameters.Add("@id", Class1.countUsers + 1);
                        cmd2.Parameters.Add("@name", textBox3.Text);
                        cmd2.Parameters.Add("@namerun", "");
                        cmd2.ExecuteNonQuery();
                        Conn.Close();
                        break;
                    case "Волонтер":
                        Conn.Open();
                        var cmd3 = new SqlCommand("INSERT INTO [Волонтеры] ([ID],[Фамилия]) VALUES (@id, @fio)", Conn);
                        cmd3.Parameters.Add("@id", Class1.countUsers + 1);
                        cmd3.Parameters.Add("@fio", textBox3.Text);
                        cmd3.ExecuteNonQuery();
                        Conn.Close();
                        break;
                }

                MessageBox.Show("Регистрация завершена");
            }
            catch
            {
                MessageBox.Show("Не получилось");
            }
        }

        private void FormReg_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_МарафонV1_1DataSet.Волонтеры". При необходимости она может быть перемещена или удалена.
            this.волонтерыTableAdapter.Fill(this._МарафонV1_1DataSet.Волонтеры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_МарафонV1_1DataSet.Спонсоры". При необходимости она может быть перемещена или удалена.
            this.спонсорыTableAdapter.Fill(this._МарафонV1_1DataSet.Спонсоры);

            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox3.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;

            int f = dataGridView3.RowCount;

            if (f != 0)
            {
                for (int i = 0; i < dataGridView3.RowCount-1; i++)
                {
                    comboBox2.Items.Add(dataGridView3.Rows[i].Cells[1].Value.ToString());
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Бегун")
            {
                label4.Visible = true; label4.Text = "Фамилия:";
                label5.Visible = true;
                label6.Visible = true;
                textBox3.Visible = true; 
                comboBox2.Visible = true;
                comboBox3.Visible = true;
            }
            else if (comboBox1.SelectedItem == "Спонсор")
            {
                label4.Visible = true; label4.Text = "Название:";
                label5.Visible = false;
                label6.Visible = false;
                textBox3.Visible = true; 
                comboBox2.Visible = false;
                comboBox3.Visible = false;
            }
            else if(comboBox1.SelectedItem == "Волонтер")
            {
                label4.Visible = true; label4.Text = "Фамилия:";
                label5.Visible = false;
                label6.Visible = false;
                textBox3.Visible = true; 
                comboBox2.Visible = false;
                comboBox3.Visible = false;
            }
        }
    }
}
