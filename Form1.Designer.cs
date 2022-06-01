namespace Vsphereparse
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SizeToGB = new System.Windows.Forms.Button();
            this.AnotherFile = new System.Windows.Forms.Button();
            this.ExcellExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(25, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 470);
            this.dataGridView1.TabIndex = 0;
            // 
            // SizeToGB
            // 
            this.SizeToGB.Location = new System.Drawing.Point(1184, 12);
            this.SizeToGB.Name = "SizeToGB";
            this.SizeToGB.Size = new System.Drawing.Size(106, 50);
            this.SizeToGB.TabIndex = 1;
            this.SizeToGB.Text = "Перевести в GB";
            this.SizeToGB.UseVisualStyleBackColor = true;
            this.SizeToGB.Click += new System.EventHandler(this.SizeToGB_Click);
            // 
            // AnotherFile
            // 
            this.AnotherFile.Location = new System.Drawing.Point(1184, 432);
            this.AnotherFile.Name = "AnotherFile";
            this.AnotherFile.Size = new System.Drawing.Size(106, 50);
            this.AnotherFile.TabIndex = 2;
            this.AnotherFile.Text = "выбрать другой файл";
            this.AnotherFile.UseVisualStyleBackColor = true;
            this.AnotherFile.Click += new System.EventHandler(this.AnotherFile_Click);
            // 
            // ExcellExport
            // 
            this.ExcellExport.Location = new System.Drawing.Point(1184, 376);
            this.ExcellExport.Name = "ExcellExport";
            this.ExcellExport.Size = new System.Drawing.Size(106, 50);
            this.ExcellExport.TabIndex = 3;
            this.ExcellExport.Text = "экспорт в excel";
            this.ExcellExport.UseVisualStyleBackColor = true;
            this.ExcellExport.Click += new System.EventHandler(this.ExcellExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 494);
            this.Controls.Add(this.ExcellExport);
            this.Controls.Add(this.AnotherFile);
            this.Controls.Add(this.SizeToGB);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SizeToGB;
        private System.Windows.Forms.Button AnotherFile;
        private System.Windows.Forms.Button ExcellExport;
    }
}

