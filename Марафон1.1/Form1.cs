using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Марафон1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            FormReg f = new FormReg();
            f.Show();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string login, password, role, status;
            bool flag = false;


            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                Class1.ID = dataGridView1.Rows[i].Cells[0].Value.ToString();
                login = dataGridView1.Rows[i].Cells[1].Value.ToString();
                password = dataGridView1.Rows[i].Cells[2].Value.ToString();
                role = dataGridView1.Rows[i].Cells[3].Value.ToString();
                status = dataGridView1.Rows[i].Cells[4].Value.ToString();

                if (login == textBox1.Text && password == textBox2.Text)
                {
                    if (status == "ok")
                    {
                        Class1.NowID = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        dataGridView1.Rows[i].Selected = true;
                        switch (role)
                        {
                            case "Бегун":
                                flag = !flag;
                                Form_runner a = new Form_runner();
                                a.Show();
                                break;
                            case "Admin":
                                flag = !flag;
                                Form_admin b = new Form_admin();
                                b.Show();
                                break;
                            case "Спонсор":
                                flag = !flag;
                                Form_sponsor c = new Form_sponsor();
                                c.Show();
                                break;
                            case "Волонтер":
                                flag = !flag;
                                Волонтер d = new Волонтер();
                                d.Show();
                                break;
                        }
                    }
                    else if (status == "ne ok")
                    {
                        MessageBox.Show("Регистрация не подтверждена");
                        flag = !flag;
                    }
                    if (flag)
                    {
                        break;
                    }
                }
                else if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Заполните все поля!");
                    flag = !flag;
                }
                else if (flag != false)
                {
                    MessageBox.Show("Неправильный логин или пароль!");
                    flag = !flag;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_МарафонV1_1DataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this._МарафонV1_1DataSet.Users);
            Class1.countUsers = dataGridView1.RowCount - 1;
            // Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=МарафонV1.1;Integrated Security=True
        }
    }
}
