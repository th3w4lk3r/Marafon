namespace Марафон1._1
{
    partial class Form_result
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.результатыыЗабегаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._МарафонV1_1DataSet = new Марафон1._1._МарафонV1_1DataSet();
            this.результатыы_забегаTableAdapter = new Марафон1._1._МарафонV1_1DataSetTableAdapters.Результатыы_забегаTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.спонсорDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.результатыыЗабегаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._МарафонV1_1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.спонсорDataGridViewTextBoxColumn,
            this.кмDataGridViewTextBoxColumn,
            this.времяDataGridViewTextBoxColumn,
            this.местоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.результатыыЗабегаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // результатыыЗабегаBindingSource
            // 
            this.результатыыЗабегаBindingSource.DataMember = "Результатыы забега";
            this.результатыыЗабегаBindingSource.DataSource = this._МарафонV1_1DataSet;
            // 
            // _МарафонV1_1DataSet
            // 
            this._МарафонV1_1DataSet.DataSetName = "_МарафонV1_1DataSet";
            this._МарафонV1_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // результатыы_забегаTableAdapter
            // 
            this.результатыы_забегаTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // спонсорDataGridViewTextBoxColumn
            // 
            this.спонсорDataGridViewTextBoxColumn.DataPropertyName = "Спонсор";
            this.спонсорDataGridViewTextBoxColumn.HeaderText = "Спонсор";
            this.спонсорDataGridViewTextBoxColumn.Name = "спонсорDataGridViewTextBoxColumn";
            // 
            // кмDataGridViewTextBoxColumn
            // 
            this.кмDataGridViewTextBoxColumn.DataPropertyName = "Км";
            this.кмDataGridViewTextBoxColumn.HeaderText = "Км";
            this.кмDataGridViewTextBoxColumn.Name = "кмDataGridViewTextBoxColumn";
            // 
            // времяDataGridViewTextBoxColumn
            // 
            this.времяDataGridViewTextBoxColumn.DataPropertyName = "Время";
            this.времяDataGridViewTextBoxColumn.HeaderText = "Время";
            this.времяDataGridViewTextBoxColumn.Name = "времяDataGridViewTextBoxColumn";
            // 
            // местоDataGridViewTextBoxColumn
            // 
            this.местоDataGridViewTextBoxColumn.DataPropertyName = "Место";
            this.местоDataGridViewTextBoxColumn.HeaderText = "Место";
            this.местоDataGridViewTextBoxColumn.Name = "местоDataGridViewTextBoxColumn";
            // 
            // Form_result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 384);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_result";
            this.Text = "Результаты забега";
            this.Load += new System.EventHandler(this.Form_result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.результатыыЗабегаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._МарафонV1_1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _МарафонV1_1DataSet _МарафонV1_1DataSet;
        private System.Windows.Forms.BindingSource результатыыЗабегаBindingSource;
        private _МарафонV1_1DataSetTableAdapters.Результатыы_забегаTableAdapter результатыы_забегаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn спонсорDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоDataGridViewTextBoxColumn;
    }
}