namespace ElasticBot
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
            this.ConnectToDBoButtton = new System.Windows.Forms.Button();
            this.InputConnectTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExitFromBaseButton = new System.Windows.Forms.Button();
            this.RequestSQLbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectToDBoButtton
            // 
            this.ConnectToDBoButtton.Location = new System.Drawing.Point(885, 432);
            this.ConnectToDBoButtton.Name = "ConnectToDBoButtton";
            this.ConnectToDBoButtton.Size = new System.Drawing.Size(138, 40);
            this.ConnectToDBoButtton.TabIndex = 0;
            this.ConnectToDBoButtton.Text = "Подключится к базе данных";
            this.ConnectToDBoButtton.UseVisualStyleBackColor = true;
            this.ConnectToDBoButtton.Click += new System.EventHandler(this.ConnectToDBoButtton_Click);
            // 
            // InputConnectTextBox
            // 
            this.InputConnectTextBox.Location = new System.Drawing.Point(12, 12);
            this.InputConnectTextBox.Name = "InputConnectTextBox";
            this.InputConnectTextBox.Size = new System.Drawing.Size(1011, 20);
            this.InputConnectTextBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 381);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ExitFromBaseButton
            // 
            this.ExitFromBaseButton.Enabled = false;
            this.ExitFromBaseButton.Location = new System.Drawing.Point(597, 432);
            this.ExitFromBaseButton.Name = "ExitFromBaseButton";
            this.ExitFromBaseButton.Size = new System.Drawing.Size(138, 40);
            this.ExitFromBaseButton.TabIndex = 3;
            this.ExitFromBaseButton.Text = "Отключится от базы";
            this.ExitFromBaseButton.UseVisualStyleBackColor = true;
            this.ExitFromBaseButton.Visible = false;
            this.ExitFromBaseButton.Click += new System.EventHandler(this.ExitFromBaseButton_Click);
            // 
            // RequestSQLbutton
            // 
            this.RequestSQLbutton.Enabled = false;
            this.RequestSQLbutton.Location = new System.Drawing.Point(741, 432);
            this.RequestSQLbutton.Name = "RequestSQLbutton";
            this.RequestSQLbutton.Size = new System.Drawing.Size(138, 40);
            this.RequestSQLbutton.TabIndex = 4;
            this.RequestSQLbutton.Text = "Выполнить запрос";
            this.RequestSQLbutton.UseVisualStyleBackColor = true;
            this.RequestSQLbutton.Visible = false;
            this.RequestSQLbutton.Click += new System.EventHandler(this.RequestSQLbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 479);
            this.Controls.Add(this.InputConnectTextBox);
            this.Controls.Add(this.ExitFromBaseButton);
            this.Controls.Add(this.ConnectToDBoButtton);
            this.Controls.Add(this.RequestSQLbutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectToDBoButtton;
        private System.Windows.Forms.TextBox InputConnectTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ExitFromBaseButton;
        private System.Windows.Forms.Button RequestSQLbutton;
    }
}

