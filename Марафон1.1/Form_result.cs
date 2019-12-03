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
    public partial class Form_result : Form
    {
        public Form_result()
        {
            InitializeComponent();
        }

        private void Form_result_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_МарафонV1_1DataSet.Результатыы_забега". При необходимости она может быть перемещена или удалена.
            this.результатыы_забегаTableAdapter.Fill(this._МарафонV1_1DataSet.Результатыы_забега);

        }
    }
}
