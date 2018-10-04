namespace TinyVirtualQ
{
    partial class ControlPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_screen_proyectar = new System.Windows.Forms.PictureBox();
            this.button_quitar_proyectar = new System.Windows.Forms.Button();
            this.button_aplicar_proyectar = new System.Windows.Forms.Button();
            this.button_update_proyectar = new System.Windows.Forms.Button();
            this.combo_mostrar_proyectar = new System.Windows.Forms.ComboBox();
            this.combo_screens_proyectar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_screen_proyectar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel de control";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pic_screen_proyectar);
            this.groupBox1.Controls.Add(this.button_quitar_proyectar);
            this.groupBox1.Controls.Add(this.button_aplicar_proyectar);
            this.groupBox1.Controls.Add(this.button_update_proyectar);
            this.groupBox1.Controls.Add(this.combo_mostrar_proyectar);
            this.groupBox1.Controls.Add(this.combo_screens_proyectar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(17, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proyección";
            // 
            // pic_screen_proyectar
            // 
            this.pic_screen_proyectar.BackColor = System.Drawing.Color.DimGray;
            this.pic_screen_proyectar.Location = new System.Drawing.Point(19, 22);
            this.pic_screen_proyectar.Name = "pic_screen_proyectar";
            this.pic_screen_proyectar.Size = new System.Drawing.Size(120, 100);
            this.pic_screen_proyectar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_screen_proyectar.TabIndex = 2;
            this.pic_screen_proyectar.TabStop = false;
            // 
            // button_quitar_proyectar
            // 
            this.button_quitar_proyectar.Location = new System.Drawing.Point(225, 100);
            this.button_quitar_proyectar.Name = "button_quitar_proyectar";
            this.button_quitar_proyectar.Size = new System.Drawing.Size(80, 22);
            this.button_quitar_proyectar.TabIndex = 1;
            this.button_quitar_proyectar.Text = "Quitar";
            this.button_quitar_proyectar.UseVisualStyleBackColor = true;
            this.button_quitar_proyectar.Click += new System.EventHandler(this.Detener);
            // 
            // button_aplicar_proyectar
            // 
            this.button_aplicar_proyectar.Location = new System.Drawing.Point(311, 100);
            this.button_aplicar_proyectar.Name = "button_aplicar_proyectar";
            this.button_aplicar_proyectar.Size = new System.Drawing.Size(80, 22);
            this.button_aplicar_proyectar.TabIndex = 1;
            this.button_aplicar_proyectar.Text = "Aplicar";
            this.button_aplicar_proyectar.UseVisualStyleBackColor = true;
            this.button_aplicar_proyectar.Click += new System.EventHandler(this.Proyectar);
            // 
            // button_update_proyectar
            // 
            this.button_update_proyectar.BackgroundImage = global::TinyVirtualQ.Resource1.update;
            this.button_update_proyectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_update_proyectar.Location = new System.Drawing.Point(369, 22);
            this.button_update_proyectar.Name = "button_update_proyectar";
            this.button_update_proyectar.Size = new System.Drawing.Size(22, 22);
            this.button_update_proyectar.TabIndex = 1;
            this.button_update_proyectar.UseVisualStyleBackColor = true;
            this.button_update_proyectar.Click += new System.EventHandler(this.UpdateScreens);
            // 
            // combo_mostrar_proyectar
            // 
            this.combo_mostrar_proyectar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_mostrar_proyectar.FormattingEnabled = true;
            this.combo_mostrar_proyectar.Items.AddRange(new object[] {
            "(En negro)",
            "Logos",
            "Concurso",
            "Fin",
            "Espera..."});
            this.combo_mostrar_proyectar.Location = new System.Drawing.Point(198, 51);
            this.combo_mostrar_proyectar.Name = "combo_mostrar_proyectar";
            this.combo_mostrar_proyectar.Size = new System.Drawing.Size(165, 21);
            this.combo_mostrar_proyectar.TabIndex = 0;
            // 
            // combo_screens_proyectar
            // 
            this.combo_screens_proyectar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_screens_proyectar.FormattingEnabled = true;
            this.combo_screens_proyectar.Location = new System.Drawing.Point(198, 22);
            this.combo_screens_proyectar.Name = "combo_screens_proyectar";
            this.combo_screens_proyectar.Size = new System.Drawing.Size(165, 21);
            this.combo_screens_proyectar.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mostrar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pantalla";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(841, 495);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ControlPanel";
            this.Text = "TinyQ";
            this.Load += new System.EventHandler(this.onLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_screen_proyectar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combo_screens_proyectar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_update_proyectar;
        private System.Windows.Forms.Button button_aplicar_proyectar;
        private System.Windows.Forms.ComboBox combo_mostrar_proyectar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pic_screen_proyectar;
        private System.Windows.Forms.Button button_quitar_proyectar;
    }
}