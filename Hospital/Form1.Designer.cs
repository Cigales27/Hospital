namespace Est
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
            this.btnimagen = new System.Windows.Forms.Button();
            this.btnimagen2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnimagen
            // 
            this.btnimagen.Location = new System.Drawing.Point(53, 59);
            this.btnimagen.Name = "btnimagen";
            this.btnimagen.Size = new System.Drawing.Size(295, 313);
            this.btnimagen.TabIndex = 0;
            this.btnimagen.UseVisualStyleBackColor = true;
            this.btnimagen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnimagen2
            // 
            this.btnimagen2.BackColor = System.Drawing.SystemColors.Control;
            this.btnimagen2.Location = new System.Drawing.Point(422, 59);
            this.btnimagen2.Name = "btnimagen2";
            this.btnimagen2.Size = new System.Drawing.Size(302, 313);
            this.btnimagen2.TabIndex = 1;
            this.btnimagen2.UseVisualStyleBackColor = false;
            this.btnimagen2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ESTACIONAMIENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ENTRADA PEATONAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnimagen2);
            this.Controls.Add(this.btnimagen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnimagen;
        private System.Windows.Forms.Button btnimagen2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

