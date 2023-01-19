namespace WindowsEFDatos
{
    partial class Formulario
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
            this.txtDeno = new System.Windows.Forms.TextBox();
            this.numCap = new System.Windows.Forms.NumericUpDown();
            this.comboLineas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridAv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDeno
            // 
            this.txtDeno.Location = new System.Drawing.Point(103, 144);
            this.txtDeno.Name = "txtDeno";
            this.txtDeno.Size = new System.Drawing.Size(100, 20);
            this.txtDeno.TabIndex = 1;
            // 
            // numCap
            // 
            this.numCap.Location = new System.Drawing.Point(103, 103);
            this.numCap.Name = "numCap";
            this.numCap.Size = new System.Drawing.Size(100, 20);
            this.numCap.TabIndex = 2;

            // 
            // comboLineas
            // 
            this.comboLineas.FormattingEnabled = true;
            this.comboLineas.Location = new System.Drawing.Point(103, 188);
            this.comboLineas.Name = "comboLineas";
            this.comboLineas.Size = new System.Drawing.Size(100, 21);
            this.comboLineas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aviones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Capacidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Linea Aerea";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Denominacion";
            // 
            // dataGridAv
            // 
            this.dataGridAv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAv.Location = new System.Drawing.Point(12, 226);
            this.dataGridAv.Name = "dataGridAv";
            this.dataGridAv.Size = new System.Drawing.Size(301, 150);
            this.dataGridAv.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Insert);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = "Listar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MostrarAviones);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(246, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 25);
            this.button3.TabIndex = 12;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Eliminar);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(246, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 25);
            this.button4.TabIndex = 13;
            this.button4.Text = "Listar Uno";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ListarUno);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(246, 154);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 25);
            this.button5.TabIndex = 14;
            this.button5.Text = "Editar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Editar);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(103, 57);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridAv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboLineas);
            this.Controls.Add(this.numCap);
            this.Controls.Add(this.txtDeno);
            this.Name = "Formulario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Formulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDeno;
        private System.Windows.Forms.NumericUpDown numCap;
        private System.Windows.Forms.ComboBox comboLineas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridAv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
    }
}

