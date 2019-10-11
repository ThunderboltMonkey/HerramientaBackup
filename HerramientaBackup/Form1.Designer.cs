namespace HerramientaBackup
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFeatures = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnRespaldar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(535, 74);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "BIENVENIDO A LA HERRAMIENTA \r\nDE RESPALDOS: READY, SET, BACKUP!";
            // 
            // lblFeatures
            // 
            this.lblFeatures.AutoSize = true;
            this.lblFeatures.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeatures.ForeColor = System.Drawing.Color.Black;
            this.lblFeatures.Location = new System.Drawing.Point(368, 105);
            this.lblFeatures.Name = "lblFeatures";
            this.lblFeatures.Size = new System.Drawing.Size(370, 23);
            this.lblFeatures.TabIndex = 4;
            this.lblFeatures.Text = "Esta herramienta le permitirá:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(185)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(372, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 222);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(185)))), ((int)(((byte)(91)))));
            this.label2.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 43);
            this.label2.TabIndex = 8;
            this.label2.Text = "RESPALDAR";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(185)))), ((int)(((byte)(91)))));
            this.label3.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 43);
            this.label3.TabIndex = 9;
            this.label3.Text = "RESTAURAR";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(-2, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(807, 40);
            this.label4.TabIndex = 12;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackgroundImage = global::HerramientaBackup.Properties.Resources.bkp;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.Location = new System.Drawing.Point(580, 241);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(86, 82);
            this.btnRestaurar.TabIndex = 11;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRespaldar
            // 
            this.btnRespaldar.BackgroundImage = global::HerramientaBackup.Properties.Resources.resp;
            this.btnRespaldar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRespaldar.ForeColor = System.Drawing.Color.Transparent;
            this.btnRespaldar.Location = new System.Drawing.Point(580, 144);
            this.btnRespaldar.Name = "btnRespaldar";
            this.btnRespaldar.Size = new System.Drawing.Size(86, 82);
            this.btnRespaldar.TabIndex = 10;
            this.btnRespaldar.UseVisualStyleBackColor = true;
            this.btnRespaldar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HerramientaBackup.Properties.Resources.img;
            this.pictureBox1.Location = new System.Drawing.Point(19, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 440);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnRespaldar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFeatures);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ready, Set, Backup!";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFeatures;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRespaldar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Label label4;
    }
}

