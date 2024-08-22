namespace Conversor_De_Temperatura
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbxCelcius = new System.Windows.Forms.TextBox();
            this.TbxFahrenheit = new System.Windows.Forms.TextBox();
            this.lbCelcius = new System.Windows.Forms.Label();
            this.lbFahrenheit = new System.Windows.Forms.Label();
            this.btnCelciusF = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFahrenheitC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbxCelcius
            // 
            this.TbxCelcius.Location = new System.Drawing.Point(33, 103);
            this.TbxCelcius.Name = "TbxCelcius";
            this.TbxCelcius.Size = new System.Drawing.Size(162, 22);
            this.TbxCelcius.TabIndex = 0;
            // 
            // TbxFahrenheit
            // 
            this.TbxFahrenheit.Location = new System.Drawing.Point(394, 113);
            this.TbxFahrenheit.Name = "TbxFahrenheit";
            this.TbxFahrenheit.Size = new System.Drawing.Size(173, 22);
            this.TbxFahrenheit.TabIndex = 1;
            // 
            // lbCelcius
            // 
            this.lbCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelcius.Location = new System.Drawing.Point(54, 57);
            this.lbCelcius.Name = "lbCelcius";
            this.lbCelcius.Size = new System.Drawing.Size(123, 27);
            this.lbCelcius.TabIndex = 0;
            this.lbCelcius.Text = "Grados Celcius";
            // 
            // lbFahrenheit
            // 
            this.lbFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFahrenheit.Location = new System.Drawing.Point(415, 68);
            this.lbFahrenheit.Name = "lbFahrenheit";
            this.lbFahrenheit.Size = new System.Drawing.Size(137, 16);
            this.lbFahrenheit.TabIndex = 0;
            this.lbFahrenheit.Text = "Grados Fahrenheit";
            // 
            // btnCelciusF
            // 
            this.btnCelciusF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCelciusF.ForeColor = System.Drawing.Color.Navy;
            this.btnCelciusF.Location = new System.Drawing.Point(46, 183);
            this.btnCelciusF.Name = "btnCelciusF";
            this.btnCelciusF.Size = new System.Drawing.Size(120, 45);
            this.btnCelciusF.TabIndex = 0;
            this.btnCelciusF.Text = "Celcius a Fahrenheit";
            this.btnCelciusF.UseVisualStyleBackColor = true;
            this.btnCelciusF.Click += new System.EventHandler(this.btnCelciusF_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Location = new System.Drawing.Point(262, 188);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 34);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnFahrenheitC
            // 
            this.btnFahrenheitC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFahrenheitC.ForeColor = System.Drawing.Color.Navy;
            this.btnFahrenheitC.Location = new System.Drawing.Point(438, 171);
            this.btnFahrenheitC.Name = "btnFahrenheitC";
            this.btnFahrenheitC.Size = new System.Drawing.Size(101, 51);
            this.btnFahrenheitC.TabIndex = 0;
            this.btnFahrenheitC.Text = "Fahrenheit a Celcius";
            this.btnFahrenheitC.UseVisualStyleBackColor = true;
            this.btnFahrenheitC.Click += new System.EventHandler(this.btnFahrenheitC_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(587, 270);
            this.Controls.Add(this.btnFahrenheitC);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCelciusF);
            this.Controls.Add(this.lbFahrenheit);
            this.Controls.Add(this.lbCelcius);
            this.Controls.Add(this.TbxFahrenheit);
            this.Controls.Add(this.TbxCelcius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxCelcius;
        private System.Windows.Forms.TextBox TbxFahrenheit;
        private System.Windows.Forms.Label lbCelcius;
        private System.Windows.Forms.Label lbFahrenheit;
        private System.Windows.Forms.Button btnCelciusF;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnFahrenheitC;
    }
}

