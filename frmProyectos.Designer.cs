namespace pryRecuperatorio
{
    partial class frmProyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProyectos));
            this.btnSP1 = new System.Windows.Forms.Button();
            this.btnSP2 = new System.Windows.Forms.Button();
            this.btnSP3 = new System.Windows.Forms.Button();
            this.btnSP4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSP1
            // 
            this.btnSP1.Location = new System.Drawing.Point(80, 33);
            this.btnSP1.Name = "btnSP1";
            this.btnSP1.Size = new System.Drawing.Size(101, 30);
            this.btnSP1.TabIndex = 0;
            this.btnSP1.Text = "SP1";
            this.btnSP1.UseVisualStyleBackColor = true;
            this.btnSP1.Click += new System.EventHandler(this.btnSP1_Click);
            // 
            // btnSP2
            // 
            this.btnSP2.Location = new System.Drawing.Point(80, 82);
            this.btnSP2.Name = "btnSP2";
            this.btnSP2.Size = new System.Drawing.Size(101, 30);
            this.btnSP2.TabIndex = 1;
            this.btnSP2.Text = "SP2";
            this.btnSP2.UseVisualStyleBackColor = true;
            this.btnSP2.Click += new System.EventHandler(this.btnSP2_Click);
            // 
            // btnSP3
            // 
            this.btnSP3.Location = new System.Drawing.Point(80, 131);
            this.btnSP3.Name = "btnSP3";
            this.btnSP3.Size = new System.Drawing.Size(101, 30);
            this.btnSP3.TabIndex = 2;
            this.btnSP3.Text = "SP3";
            this.btnSP3.UseVisualStyleBackColor = true;
            this.btnSP3.Click += new System.EventHandler(this.btnSP3_Click);
            // 
            // btnSP4
            // 
            this.btnSP4.Location = new System.Drawing.Point(80, 180);
            this.btnSP4.Name = "btnSP4";
            this.btnSP4.Size = new System.Drawing.Size(101, 30);
            this.btnSP4.TabIndex = 3;
            this.btnSP4.Text = "SP4";
            this.btnSP4.UseVisualStyleBackColor = true;
            this.btnSP4.Click += new System.EventHandler(this.btnSP4_Click);
            // 
            // frmProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 250);
            this.Controls.Add(this.btnSP4);
            this.Controls.Add(this.btnSP3);
            this.Controls.Add(this.btnSP2);
            this.Controls.Add(this.btnSP1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProyectos";
            this.Text = "Unificación de proyectos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSP1;
        private System.Windows.Forms.Button btnSP2;
        private System.Windows.Forms.Button btnSP3;
        private System.Windows.Forms.Button btnSP4;
    }
}

