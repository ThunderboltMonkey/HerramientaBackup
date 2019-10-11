namespace HerramientaBackup
{
    partial class FormaRespaldo
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
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnRespaldo = new System.Windows.Forms.Button();
            this.btnRespTablas = new System.Windows.Forms.Button();
            this.btnRespTabla = new System.Windows.Forms.Button();
            this.btnRespaldos = new System.Windows.Forms.Button();
            this.btnRuta = new System.Windows.Forms.Button();
            this.lblRuta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(55, 32);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(413, 20);
            this.txtRuta.TabIndex = 3;
            // 
            // btnRespaldo
            // 
            this.btnRespaldo.Location = new System.Drawing.Point(263, 75);
            this.btnRespaldo.Name = "btnRespaldo";
            this.btnRespaldo.Size = new System.Drawing.Size(225, 70);
            this.btnRespaldo.TabIndex = 2;
            this.btnRespaldo.Text = "Respaldar Base de Datos";
            this.btnRespaldo.UseVisualStyleBackColor = true;
            this.btnRespaldo.Click += new System.EventHandler(this.btnRespaldo_Click);
            // 
            // btnRespTablas
            // 
            this.btnRespTablas.Location = new System.Drawing.Point(32, 151);
            this.btnRespTablas.Name = "btnRespTablas";
            this.btnRespTablas.Size = new System.Drawing.Size(225, 70);
            this.btnRespTablas.TabIndex = 4;
            this.btnRespTablas.Text = "Respaldar varias tablas";
            this.btnRespTablas.UseVisualStyleBackColor = true;
            this.btnRespTablas.Click += new System.EventHandler(this.btnRespTablas_Click);
            // 
            // btnRespTabla
            // 
            this.btnRespTabla.Location = new System.Drawing.Point(263, 151);
            this.btnRespTabla.Name = "btnRespTabla";
            this.btnRespTabla.Size = new System.Drawing.Size(225, 70);
            this.btnRespTabla.TabIndex = 5;
            this.btnRespTabla.Text = "Respaldar una tabla";
            this.btnRespTabla.UseVisualStyleBackColor = true;
            this.btnRespTabla.Click += new System.EventHandler(this.btnRespTabla_Click);
            // 
            // btnRespaldos
            // 
            this.btnRespaldos.Location = new System.Drawing.Point(32, 75);
            this.btnRespaldos.Name = "btnRespaldos";
            this.btnRespaldos.Size = new System.Drawing.Size(225, 70);
            this.btnRespaldos.TabIndex = 6;
            this.btnRespaldos.Text = "Respaldar Todas las Bases de Datos";
            this.btnRespaldos.UseVisualStyleBackColor = true;
            this.btnRespaldos.Click += new System.EventHandler(this.btnRespaldos_Click);
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(474, 30);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(37, 23);
            this.btnRuta.TabIndex = 7;
            this.btnRuta.Text = "...";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(8, 30);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(48, 20);
            this.lblRuta.TabIndex = 8;
            this.lblRuta.Text = "Ruta:";
            // 
            // FormaRespaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(523, 240);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.btnRespaldos);
            this.Controls.Add(this.btnRespTabla);
            this.Controls.Add(this.btnRespTablas);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnRespaldo);
            this.Name = "FormaRespaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaRespaldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnRespaldo;
        private System.Windows.Forms.Button btnRespTablas;
        private System.Windows.Forms.Button btnRespTabla;
        private System.Windows.Forms.Button btnRespaldos;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Label lblRuta;
    }
}