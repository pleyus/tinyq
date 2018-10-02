namespace TinyVirtualQ
{
    partial class Form2
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.picClock = new System.Windows.Forms.PictureBox();
            this.picActionImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picActionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picClock
            // 
            this.picClock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picClock.BackColor = System.Drawing.Color.White;
            this.picClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClock.Image = global::TinyVirtualQ.Resource1.Crono;
            this.picClock.Location = new System.Drawing.Point(30, 14);
            this.picClock.Name = "picClock";
            this.picClock.Size = new System.Drawing.Size(74, 85);
            this.picClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClock.TabIndex = 1;
            this.picClock.TabStop = false;
            // 
            // picActionImage
            // 
            this.picActionImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picActionImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picActionImage.Image = global::TinyVirtualQ.Resource1._OK;
            this.picActionImage.Location = new System.Drawing.Point(20, 15);
            this.picActionImage.Name = "picActionImage";
            this.picActionImage.Size = new System.Drawing.Size(92, 93);
            this.picActionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picActionImage.TabIndex = 3;
            this.picActionImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::TinyVirtualQ.Resource1.Marco;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 101);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(92, 11);
            this.progressBar1.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(131, 126);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.picActionImage);
            this.Controls.Add(this.picClock);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Notificaciones Tiny VirtualQ!";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            ((System.ComponentModel.ISupportInitialize)(this.picClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picActionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picClock;
        public System.Windows.Forms.PictureBox picActionImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ProgressBar progressBar1;

    }
}