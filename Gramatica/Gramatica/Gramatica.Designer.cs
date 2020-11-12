namespace Gramatica
{
    partial class Gramatica
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
            this.label1 = new System.Windows.Forms.Label();
            this.cadena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.variable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.producciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.agregar = new System.Windows.Forms.Button();
            this.evaluar = new System.Windows.Forms.Button();
            this.respuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadena a leer:";
            // 
            // cadena
            // 
            this.cadena.Location = new System.Drawing.Point(16, 191);
            this.cadena.Name = "cadena";
            this.cadena.Size = new System.Drawing.Size(238, 20);
            this.cadena.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gramatica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Variable";
            // 
            // variable
            // 
            this.variable.Location = new System.Drawing.Point(100, 38);
            this.variable.Name = "variable";
            this.variable.Size = new System.Drawing.Size(100, 20);
            this.variable.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Producciones";
            // 
            // producciones
            // 
            this.producciones.Location = new System.Drawing.Point(100, 71);
            this.producciones.Name = "producciones";
            this.producciones.Size = new System.Drawing.Size(100, 20);
            this.producciones.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(206, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ej: S";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(206, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ej: AA ó aa ó aA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(260, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ej: aaabbbccc";
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(209, 118);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(127, 30);
            this.agregar.TabIndex = 10;
            this.agregar.Text = "Agregar variable";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // evaluar
            // 
            this.evaluar.Location = new System.Drawing.Point(19, 252);
            this.evaluar.Name = "evaluar";
            this.evaluar.Size = new System.Drawing.Size(119, 36);
            this.evaluar.TabIndex = 11;
            this.evaluar.Text = "Evaluar Gramatica";
            this.evaluar.UseVisualStyleBackColor = true;
            this.evaluar.Click += new System.EventHandler(this.evaluar_Click);
            // 
            // respuesta
            // 
            this.respuesta.AutoSize = true;
            this.respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta.ForeColor = System.Drawing.Color.Red;
            this.respuesta.Location = new System.Drawing.Point(156, 256);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(0, 24);
            this.respuesta.TabIndex = 12;
            // 
            // Gramatica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 306);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.evaluar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.producciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.variable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cadena);
            this.Controls.Add(this.label1);
            this.Name = "Gramatica";
            this.Text = "Gramatica Independiente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cadena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox variable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox producciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button evaluar;
        private System.Windows.Forms.Label respuesta;
    }
}

