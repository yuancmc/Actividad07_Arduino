
namespace Actividad07_Arduino
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
            this.Encender = new System.Windows.Forms.Button();
            this.Apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Encender
            // 
            this.Encender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Encender.Location = new System.Drawing.Point(266, 73);
            this.Encender.Name = "Encender";
            this.Encender.Size = new System.Drawing.Size(254, 116);
            this.Encender.TabIndex = 0;
            this.Encender.Text = "Encender";
            this.Encender.UseVisualStyleBackColor = true;
            this.Encender.Click += new System.EventHandler(this.button1_Click);
            // 
            // Apagar
            // 
            this.Apagar.ForeColor = System.Drawing.Color.Maroon;
            this.Apagar.Location = new System.Drawing.Point(266, 240);
            this.Apagar.Name = "Apagar";
            this.Apagar.Size = new System.Drawing.Size(254, 116);
            this.Apagar.TabIndex = 1;
            this.Apagar.Text = "Apagar";
            this.Apagar.UseVisualStyleBackColor = true;
            this.Apagar.Click += new System.EventHandler(this.Apagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Apagar);
            this.Controls.Add(this.Encender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Encender;
        private System.Windows.Forms.Button Apagar;
    }
}

