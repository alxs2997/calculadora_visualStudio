namespace Visual_Calcu
{
    partial class Form1
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
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.multiplica = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.operador1 = new System.Windows.Forms.TextBox();
            this.operador2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.operador3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(21, 118);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(54, 23);
            this.suma.TabIndex = 0;
            this.suma.Text = "sumar (+)";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(100, 118);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(51, 23);
            this.resta.TabIndex = 1;
            this.resta.Text = "resta";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // multiplica
            // 
            this.multiplica.Location = new System.Drawing.Point(157, 118);
            this.multiplica.Name = "multiplica";
            this.multiplica.Size = new System.Drawing.Size(52, 23);
            this.multiplica.TabIndex = 2;
            this.multiplica.Text = "multiplicar";
            this.multiplica.UseVisualStyleBackColor = true;
            this.multiplica.Click += new System.EventHandler(this.multiplica_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(227, 118);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(61, 23);
            this.divide.TabIndex = 3;
            this.divide.Text = "dividir";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // operador1
            // 
            this.operador1.Location = new System.Drawing.Point(67, 57);
            this.operador1.Name = "operador1";
            this.operador1.Size = new System.Drawing.Size(184, 20);
            this.operador1.TabIndex = 4;
            // 
            // operador2
            // 
            this.operador2.Location = new System.Drawing.Point(67, 92);
            this.operador2.Name = "operador2";
            this.operador2.Size = new System.Drawing.Size(184, 20);
            this.operador2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "operar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "resultado:";
            // 
            // operador3
            // 
            this.operador3.Location = new System.Drawing.Point(67, 203);
            this.operador3.Name = "operador3";
            this.operador3.Size = new System.Drawing.Size(184, 20);
            this.operador3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 286);
            this.Controls.Add(this.operador3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operador2);
            this.Controls.Add(this.operador1);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiplica);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Name = "Form1";
            this.Text = "calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button multiplica;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.TextBox operador1;
        private System.Windows.Forms.TextBox operador2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox operador3;
    }
}

