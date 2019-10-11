namespace HerramientaBackup
{
    partial class FormaRestaura
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
            this.btnRestTabla = new System.Windows.Forms.Button();
            this.btnRestTablas = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnTodas = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblRuta = new System.Windows.Forms.Label();
            this.btnRuta = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRestTabla
            // 
            this.btnRestTabla.Location = new System.Drawing.Point(269, 147);
            this.btnRestTabla.Name = "btnRestTabla";
            this.btnRestTabla.Size = new System.Drawing.Size(225, 70);
            this.btnRestTabla.TabIndex = 8;
            this.btnRestTabla.Text = "Restaurar una tabla";
            this.btnRestTabla.UseVisualStyleBackColor = true;
            this.btnRestTabla.Click += new System.EventHandler(this.btnRestTabla_Click);
            // 
            // btnRestTablas
            // 
            this.btnRestTablas.Location = new System.Drawing.Point(269, 71);
            this.btnRestTablas.Name = "btnRestTablas";
            this.btnRestTablas.Size = new System.Drawing.Size(225, 70);
            this.btnRestTablas.TabIndex = 7;
            this.btnRestTablas.Text = "Restaurar varias tablas";
            this.btnRestTablas.UseVisualStyleBackColor = true;
            this.btnRestTablas.Click += new System.EventHandler(this.btnRestTablas_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(38, 147);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(225, 70);
            this.btnRestaurar.TabIndex = 6;
            this.btnRestaurar.Text = "Restaurar Base de Datos";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnTodas
            // 
            this.btnTodas.Location = new System.Drawing.Point(38, 71);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(225, 70);
            this.btnTodas.TabIndex = 9;
            this.btnTodas.Text = "Restaurar Todas las Bases de Datos";
            this.btnTodas.UseVisualStyleBackColor = true;
            this.btnTodas.Click += new System.EventHandler(this.btnTodas_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(7, 24);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(48, 20);
            this.lblRuta.TabIndex = 12;
            this.lblRuta.Text = "Ruta:";
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(473, 24);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(37, 23);
            this.btnRuta.TabIndex = 11;
            this.btnRuta.Text = "...";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(54, 26);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(413, 20);
            this.txtRuta.TabIndex = 10;
            // 
            // FormaRestaura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(539, 242);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnTodas);
            this.Controls.Add(this.btnRestTabla);
            this.Controls.Add(this.btnRestTablas);
            this.Controls.Add(this.btnRestaurar);
            this.Name = "FormaRestaura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaRestaura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestTabla;
        private System.Windows.Forms.Button btnRestTablas;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnTodas;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.TextBox txtRuta;
    }
}