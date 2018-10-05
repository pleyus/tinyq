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
            this.GMaster = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MasterTextMessage = new System.Windows.Forms.TextBox();
            this.MasterPictureScreen = new System.Windows.Forms.PictureBox();
            this.MasterButtonGame = new System.Windows.Forms.Button();
            this.MasterButtonLogo = new System.Windows.Forms.Button();
            this.MasterButtonStatus = new System.Windows.Forms.Button();
            this.MasterButtonMessage = new System.Windows.Forms.Button();
            this.MasterButtonUpdate = new System.Windows.Forms.Button();
            this.MasterComboScreens = new System.Windows.Forms.ComboBox();
            this.MasterButtonClear = new System.Windows.Forms.Button();
            this.GMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterPictureScreen)).BeginInit();
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
            // GMaster
            // 
            this.GMaster.Controls.Add(this.label2);
            this.GMaster.Controls.Add(this.MasterTextMessage);
            this.GMaster.Controls.Add(this.MasterPictureScreen);
            this.GMaster.Controls.Add(this.MasterButtonGame);
            this.GMaster.Controls.Add(this.MasterButtonLogo);
            this.GMaster.Controls.Add(this.MasterButtonStatus);
            this.GMaster.Controls.Add(this.MasterButtonClear);
            this.GMaster.Controls.Add(this.MasterButtonMessage);
            this.GMaster.Controls.Add(this.MasterButtonUpdate);
            this.GMaster.Controls.Add(this.MasterComboScreens);
            this.GMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GMaster.Location = new System.Drawing.Point(17, 46);
            this.GMaster.Name = "GMaster";
            this.GMaster.Size = new System.Drawing.Size(258, 437);
            this.GMaster.TabIndex = 2;
            this.GMaster.TabStop = false;
            this.GMaster.Text = "Master";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(19, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enviar mensaje al master";
            // 
            // MasterTextMessage
            // 
            this.MasterTextMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MasterTextMessage.Location = new System.Drawing.Point(20, 357);
            this.MasterTextMessage.Multiline = true;
            this.MasterTextMessage.Name = "MasterTextMessage";
            this.MasterTextMessage.Size = new System.Drawing.Size(179, 66);
            this.MasterTextMessage.TabIndex = 3;
            // 
            // MasterPictureScreen
            // 
            this.MasterPictureScreen.BackColor = System.Drawing.Color.DimGray;
            this.MasterPictureScreen.Location = new System.Drawing.Point(20, 40);
            this.MasterPictureScreen.Name = "MasterPictureScreen";
            this.MasterPictureScreen.Size = new System.Drawing.Size(215, 127);
            this.MasterPictureScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MasterPictureScreen.TabIndex = 2;
            this.MasterPictureScreen.TabStop = false;
            this.MasterPictureScreen.Tag = "picture";
            // 
            // MasterButtonGame
            // 
            this.MasterButtonGame.Location = new System.Drawing.Point(20, 292);
            this.MasterButtonGame.Name = "MasterButtonGame";
            this.MasterButtonGame.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.MasterButtonGame.Size = new System.Drawing.Size(215, 36);
            this.MasterButtonGame.TabIndex = 1;
            this.MasterButtonGame.Tag = "";
            this.MasterButtonGame.Text = "Concurso";
            this.MasterButtonGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MasterButtonGame.UseVisualStyleBackColor = true;
            // 
            // MasterButtonLogo
            // 
            this.MasterButtonLogo.Location = new System.Drawing.Point(20, 250);
            this.MasterButtonLogo.Name = "MasterButtonLogo";
            this.MasterButtonLogo.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.MasterButtonLogo.Size = new System.Drawing.Size(215, 36);
            this.MasterButtonLogo.TabIndex = 1;
            this.MasterButtonLogo.Tag = "";
            this.MasterButtonLogo.Text = "Logo";
            this.MasterButtonLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MasterButtonLogo.UseVisualStyleBackColor = true;
            // 
            // MasterButtonStatus
            // 
            this.MasterButtonStatus.Location = new System.Drawing.Point(20, 208);
            this.MasterButtonStatus.Name = "MasterButtonStatus";
            this.MasterButtonStatus.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.MasterButtonStatus.Size = new System.Drawing.Size(215, 36);
            this.MasterButtonStatus.TabIndex = 1;
            this.MasterButtonStatus.Tag = "";
            this.MasterButtonStatus.Text = "Estado";
            this.MasterButtonStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MasterButtonStatus.UseVisualStyleBackColor = true;
            // 
            // MasterButtonMessage
            // 
            this.MasterButtonMessage.BackgroundImage = global::TinyVirtualQ.Resource1.update;
            this.MasterButtonMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MasterButtonMessage.Location = new System.Drawing.Point(205, 357);
            this.MasterButtonMessage.Name = "MasterButtonMessage";
            this.MasterButtonMessage.Size = new System.Drawing.Size(30, 30);
            this.MasterButtonMessage.TabIndex = 1;
            this.MasterButtonMessage.Tag = "update";
            this.MasterButtonMessage.UseVisualStyleBackColor = true;
            // 
            // MasterButtonUpdate
            // 
            this.MasterButtonUpdate.BackgroundImage = global::TinyVirtualQ.Resource1.update;
            this.MasterButtonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MasterButtonUpdate.Location = new System.Drawing.Point(205, 172);
            this.MasterButtonUpdate.Name = "MasterButtonUpdate";
            this.MasterButtonUpdate.Size = new System.Drawing.Size(30, 30);
            this.MasterButtonUpdate.TabIndex = 1;
            this.MasterButtonUpdate.Tag = "";
            this.MasterButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // MasterComboScreens
            // 
            this.MasterComboScreens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MasterComboScreens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MasterComboScreens.FormattingEnabled = true;
            this.MasterComboScreens.Location = new System.Drawing.Point(20, 173);
            this.MasterComboScreens.Name = "MasterComboScreens";
            this.MasterComboScreens.Size = new System.Drawing.Size(179, 28);
            this.MasterComboScreens.TabIndex = 0;
            this.MasterComboScreens.Tag = "";
            // 
            // MasterButtonClear
            // 
            this.MasterButtonClear.BackgroundImage = global::TinyVirtualQ.Resource1.update;
            this.MasterButtonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MasterButtonClear.Location = new System.Drawing.Point(205, 393);
            this.MasterButtonClear.Name = "MasterButtonClear";
            this.MasterButtonClear.Size = new System.Drawing.Size(30, 30);
            this.MasterButtonClear.TabIndex = 1;
            this.MasterButtonClear.Tag = "update";
            this.MasterButtonClear.UseVisualStyleBackColor = true;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(841, 495);
            this.Controls.Add(this.GMaster);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ControlPanel";
            this.Text = "TinyQ";
            this.Load += new System.EventHandler(this.onLoad);
            this.GMaster.ResumeLayout(false);
            this.GMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterPictureScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GMaster;
        private System.Windows.Forms.ComboBox MasterComboScreens;
        private System.Windows.Forms.Button MasterButtonUpdate;
        private System.Windows.Forms.Button MasterButtonStatus;
        private System.Windows.Forms.PictureBox MasterPictureScreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MasterTextMessage;
        private System.Windows.Forms.Button MasterButtonGame;
        private System.Windows.Forms.Button MasterButtonLogo;
        private System.Windows.Forms.Button MasterButtonMessage;
        private System.Windows.Forms.Button MasterButtonClear;
    }
}