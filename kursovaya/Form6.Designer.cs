namespace kursovaya
{
    partial class Form6
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
            this.номерЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказчикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.общаяСтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рекламDataSet1 = new kursovaya.РекламDataSet1();
            this.рекламDataSet = new kursovaya.РекламDataSet();
            this.рекламDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new kursovaya.РекламDataSet1TableAdapters.заказTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рекламDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рекламDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рекламDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерЗаказаDataGridViewTextBoxColumn,
            this.заказчикDataGridViewTextBoxColumn,
            this.датаЗаказаDataGridViewTextBoxColumn,
            this.общаяСтоимостьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заказBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, -5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // номерЗаказаDataGridViewTextBoxColumn
            // 
            this.номерЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер заказа";
            this.номерЗаказаDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.номерЗаказаDataGridViewTextBoxColumn.Name = "номерЗаказаDataGridViewTextBoxColumn";
            this.номерЗаказаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // заказчикDataGridViewTextBoxColumn
            // 
            this.заказчикDataGridViewTextBoxColumn.DataPropertyName = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn.HeaderText = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn.Name = "заказчикDataGridViewTextBoxColumn";
            // 
            // датаЗаказаDataGridViewTextBoxColumn
            // 
            this.датаЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата заказа";
            this.датаЗаказаDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.датаЗаказаDataGridViewTextBoxColumn.Name = "датаЗаказаDataGridViewTextBoxColumn";
            // 
            // общаяСтоимостьDataGridViewTextBoxColumn
            // 
            this.общаяСтоимостьDataGridViewTextBoxColumn.DataPropertyName = "Общая стоимость";
            this.общаяСтоимостьDataGridViewTextBoxColumn.HeaderText = "Общая стоимость";
            this.общаяСтоимостьDataGridViewTextBoxColumn.Name = "общаяСтоимостьDataGridViewTextBoxColumn";
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "заказ";
            this.заказBindingSource.DataSource = this.рекламDataSet1;
            // 
            // рекламDataSet1
            // 
            this.рекламDataSet1.DataSetName = "РекламDataSet1";
            this.рекламDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рекламDataSet
            // 
            this.рекламDataSet.DataSetName = "РекламDataSet";
            this.рекламDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рекламDataSetBindingSource
            // 
            this.рекламDataSetBindingSource.DataSource = this.рекламDataSet;
            this.рекламDataSetBindingSource.Position = 0;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::kursovaya.Properties.Resources.oNd0dIZUoUOWWqtmbryLup7WQkAQ2GSXATLiUfx2_VQokPLrPISdkVBnbZHQpy7QxXAGYbbi5hVFv10UHhHYttW_;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::kursovaya.Properties.Resources.oNd0dIZUoUOWWqtmbryLup7WQkAQ2GSXATLiUfx2_VQokPLrPISdkVBnbZHQpy7QxXAGYbbi5hVFv10UHhHYttW_;
            this.ClientSize = new System.Drawing.Size(435, 245);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рекламDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рекламDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рекламDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource рекламDataSetBindingSource;
        private РекламDataSet рекламDataSet;
        private РекламDataSet1 рекламDataSet1;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private РекламDataSet1TableAdapters.заказTableAdapter заказTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказчикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn общаяСтоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}