namespace TinyVirtualQ
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
            this.butStart = new System.Windows.Forms.Button();
            this.butOk = new System.Windows.Forms.Button();
            this.butError = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butNew = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.butMarco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime)).BeginInit();
            this.SuspendLayout();
            // 
            // butStart
            // 
            this.butStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStart.Image = global::TinyVirtualQ.Resource1.Crono;
            this.butStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butStart.Location = new System.Drawing.Point(13, 196);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(494, 83);
            this.butStart.TabIndex = 0;
            this.butStart.Text = "Iniciar";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // butOk
            // 
            this.butOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOk.Image = global::TinyVirtualQ.Resource1.ok1;
            this.butOk.Location = new System.Drawing.Point(13, 285);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(244, 83);
            this.butOk.TabIndex = 0;
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butError
            // 
            this.butError.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butError.Image = global::TinyVirtualQ.Resource1.incorrecto;
            this.butError.Location = new System.Drawing.Point(263, 285);
            this.butError.Name = "butError";
            this.butError.Size = new System.Drawing.Size(244, 83);
            this.butError.TabIndex = 0;
            this.butError.UseVisualStyleBackColor = true;
            this.butError.Click += new System.EventHandler(this.butError_Click);
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(163, 17);
            this.txtTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.txtTime.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(94, 45);
            this.txtTime.TabIndex = 1;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tiempo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Segundos";
            // 
            // butNew
            // 
            this.butNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNew.Location = new System.Drawing.Point(19, 74);
            this.butNew.Name = "butNew";
            this.butNew.Size = new System.Drawing.Size(494, 83);
            this.butNew.TabIndex = 0;
            this.butNew.Text = "Nuevo";
            this.butNew.UseVisualStyleBackColor = true;
            this.butNew.Click += new System.EventHandler(this.button4_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 167);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(494, 23);
            this.progressBar.TabIndex = 3;
            // 
            // butMarco
            // 
            this.butMarco.BackgroundImage = global::TinyVirtualQ.Resource1.square;
            this.butMarco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butMarco.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMarco.Location = new System.Drawing.Point(455, 17);
            this.butMarco.Name = "butMarco";
            this.butMarco.Size = new System.Drawing.Size(52, 45);
            this.butMarco.TabIndex = 0;
            this.butMarco.UseVisualStyleBackColor = true;
            this.butMarco.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 380);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.butError);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.butMarco);
            this.Controls.Add(this.butNew);
            this.Controls.Add(this.butStart);
            this.Name = "Form1";
            this.Text = "TinyVirtualQ! - Panel de Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butError;
        private System.Windows.Forms.NumericUpDown txtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butNew;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button butMarco;
    }
}

