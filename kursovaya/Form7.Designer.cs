namespace kursovaya
{
    partial class Form7
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
            this.кодПланаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.услугаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНачалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОкончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.медиапланBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рекламDataSet2 = new kursovaya.РекламDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.медиапланTableAdapter = new kursovaya.РекламDataSet2TableAdapters.медиапланTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.медиапланBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рекламDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПланаDataGridViewTextBoxColumn,
            this.услугаDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.номерЗаказаDataGridViewTextBoxColumn,
            this.датаНачалаDataGridViewTextBoxColumn,
            this.датаОкончанияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.медиапланBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // кодПланаDataGridViewTextBoxColumn
            // 
            this.кодПланаDataGridViewTextBoxColumn.DataPropertyName = "Код плана";
            this.кодПланаDataGridViewTextBoxColumn.HeaderText = "Код плана";
            this.кодПланаDataGridViewTextBoxColumn.Name = "кодПланаDataGridViewTextBoxColumn";
            // 
            // услугаDataGridViewTextBoxColumn
            // 
            this.услугаDataGridViewTextBoxColumn.DataPropertyName = "Услуга";
            this.услугаDataGridViewTextBoxColumn.HeaderText = "Услуга";
            this.услугаDataGridViewTextBoxColumn.Name = "услугаDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // номерЗаказаDataGridViewTextBoxColumn
            // 
            this.номерЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер заказа";
            this.номерЗаказаDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.номерЗаказаDataGridViewTextBoxColumn.Name = "номерЗаказаDataGridViewTextBoxColumn";
            // 
            // датаНачалаDataGridViewTextBoxColumn
            // 
            this.датаНачалаDataGridViewTextBoxColumn.DataPropertyName = "Дата начала";
            this.датаНачалаDataGridViewTextBoxColumn.HeaderText = "Дата начала";
            this.датаНачалаDataGridViewTextBoxColumn.Name = "датаНачалаDataGridViewTextBoxColumn";
            // 
            // датаОкончанияDataGridViewTextBoxColumn
            // 
            this.датаОкончанияDataGridViewTextBoxColumn.DataPropertyName = "Дата окончания";
            this.датаОкончанияDataGridViewTextBoxColumn.HeaderText = "Дата окончания";
            this.датаОкончанияDataGridViewTextBoxColumn.Name = "датаОкончанияDataGridViewTextBoxColumn";
            // 
            // медиапланBindingSource
            // 
            this.медиапланBindingSource.DataMember = "медиаплан";
            this.медиапланBindingSource.DataSource = this.рекламDataSet2;
            // 
            // рекламDataSet2
            // 
            this.рекламDataSet2.DataSetName = "РекламDataSet2";
            this.рекламDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::kursovaya.Properties.Resources.oNd0dIZUoUOWWqtmbryLup7WQkAQ2GSXATLiUfx2_VQokPLrPISdkVBnbZHQpy7QxXAGYbbi5hVFv10UHhHYttW_;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(23, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // медиапланTableAdapter
            // 
            this.медиапланTableAdapter.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kursovaya.Properties.Resources.oNd0dIZUoUOWWqtmbryLup7WQkAQ2GSXATLiUfx2_VQokPLrPISdkVBnbZHQpy7QxXAGYbbi5hVFv10UHhHYttW_;
            this.ClientSize = new System.Drawing.Size(644, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.медиапланBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рекламDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private РекламDataSet2 рекламDataSet2;
        private System.Windows.Forms.BindingSource медиапланBindingSource;
        private РекламDataSet2TableAdapters.медиапланTableAdapter медиапланTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПланаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn услугаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОкончанияDataGridViewTextBoxColumn;
    }
}