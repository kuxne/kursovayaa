namespace kursovaya
{
    partial class Form8
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
            this.номерОтчётаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказчикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.исполнительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.услугаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчётBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рекламDataSet3 = new kursovaya.РекламDataSet3();
            this.button1 = new System.Windows.Forms.Button();
            this.отчётTableAdapter = new kursovaya.РекламDataSet3TableAdapters.ОтчётTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчётBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рекламDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерОтчётаDataGridViewTextBoxColumn,
            this.заказчикDataGridViewTextBoxColumn,
            this.исполнительDataGridViewTextBoxColumn,
            this.услугаDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn,
            this.номерЗаказаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.отчётBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(594, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // номерОтчётаDataGridViewTextBoxColumn
            // 
            this.номерОтчётаDataGridViewTextBoxColumn.DataPropertyName = "Номер отчёта";
            this.номерОтчётаDataGridViewTextBoxColumn.HeaderText = "Номер отчёта";
            this.номерОтчётаDataGridViewTextBoxColumn.Name = "номерОтчётаDataGridViewTextBoxColumn";
            this.номерОтчётаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // заказчикDataGridViewTextBoxColumn
            // 
            this.заказчикDataGridViewTextBoxColumn.DataPropertyName = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn.HeaderText = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn.Name = "заказчикDataGridViewTextBoxColumn";
            this.заказчикDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // исполнительDataGridViewTextBoxColumn
            // 
            this.исполнительDataGridViewTextBoxColumn.DataPropertyName = "Исполнитель";
            this.исполнительDataGridViewTextBoxColumn.HeaderText = "Исполнитель";
            this.исполнительDataGridViewTextBoxColumn.Name = "исполнительDataGridViewTextBoxColumn";
            this.исполнительDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // услугаDataGridViewTextBoxColumn
            // 
            this.услугаDataGridViewTextBoxColumn.DataPropertyName = "Услуга";
            this.услугаDataGridViewTextBoxColumn.HeaderText = "Услуга";
            this.услугаDataGridViewTextBoxColumn.Name = "услугаDataGridViewTextBoxColumn";
            this.услугаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            this.суммаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерЗаказаDataGridViewTextBoxColumn
            // 
            this.номерЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер заказа";
            this.номерЗаказаDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.номерЗаказаDataGridViewTextBoxColumn.Name = "номерЗаказаDataGridViewTextBoxColumn";
            this.номерЗаказаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отчётBindingSource
            // 
            this.отчётBindingSource.DataMember = "Отчёт";
            this.отчётBindingSource.DataSource = this.рекламDataSet3;
            // 
            // рекламDataSet3
            // 
            this.рекламDataSet3.DataSetName = "РекламDataSet3";
            this.рекламDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::kursovaya.Properties.Resources.oNd0dIZUoUOWWqtmbryLup7WQkAQ2GSXATLiUfx2_VQokPLrPISdkVBnbZHQpy7QxXAGYbbi5hVFv10UHhHYttW_;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // отчётTableAdapter
            // 
            this.отчётTableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kursovaya.Properties.Resources.oNd0dIZUoUOWWqtmbryLup7WQkAQ2GSXATLiUfx2_VQokPLrPISdkVBnbZHQpy7QxXAGYbbi5hVFv10UHhHYttW_;
            this.ClientSize = new System.Drawing.Size(593, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчётBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рекламDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private РекламDataSet3 рекламDataSet3;
        private System.Windows.Forms.BindingSource отчётBindingSource;
        private РекламDataSet3TableAdapters.ОтчётTableAdapter отчётTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерОтчётаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказчикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn исполнительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn услугаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗаказаDataGridViewTextBoxColumn;
    }
}