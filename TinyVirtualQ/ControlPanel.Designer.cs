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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.GMaster = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MasterTextMessage = new System.Windows.Forms.TextBox();
            this.MasterPictureScreen = new System.Windows.Forms.PictureBox();
            this.MasterButtonGame = new System.Windows.Forms.Button();
            this.MasterButtonLogo = new System.Windows.Forms.Button();
            this.MasterButtonStatus = new System.Windows.Forms.Button();
            this.MasterButtonClear = new System.Windows.Forms.Button();
            this.MasterButtonMessage = new System.Windows.Forms.Button();
            this.MasterButtonUpdate = new System.Windows.Forms.Button();
            this.MasterComboScreens = new System.Windows.Forms.ComboBox();
            this.GSlave = new System.Windows.Forms.GroupBox();
            this.SlavePictureScreen = new System.Windows.Forms.PictureBox();
            this.SlaveButtonGame = new System.Windows.Forms.Button();
            this.SlaveButtonLogo = new System.Windows.Forms.Button();
            this.SlaveButtonBlack = new System.Windows.Forms.Button();
            this.SlaveButtonUpdate = new System.Windows.Forms.Button();
            this.SlaveComboScreens = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabContest = new System.Windows.Forms.TabPage();
            this.tabScreens = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.PanelContest = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.GMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterPictureScreen)).BeginInit();
            this.GSlave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlavePictureScreen)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabContest.SuspendLayout();
            this.tabScreens.SuspendLayout();
            this.PanelContest.SuspendLayout();
            this.SuspendLayout();
            // 
            // GMaster
            // 
            this.GMaster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.GMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.GMaster.Location = new System.Drawing.Point(6, 6);
            this.GMaster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GMaster.Name = "GMaster";
            this.GMaster.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GMaster.Size = new System.Drawing.Size(258, 1091);
            this.GMaster.TabIndex = 2;
            this.GMaster.TabStop = false;
            this.GMaster.Text = "Master";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label2.Location = new System.Drawing.Point(15, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enviar mensaje al master";
            // 
            // MasterTextMessage
            // 
            this.MasterTextMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MasterTextMessage.Location = new System.Drawing.Point(21, 395);
            this.MasterTextMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MasterTextMessage.Multiline = true;
            this.MasterTextMessage.Name = "MasterTextMessage";
            this.MasterTextMessage.Size = new System.Drawing.Size(212, 59);
            this.MasterTextMessage.TabIndex = 3;
            // 
            // MasterPictureScreen
            // 
            this.MasterPictureScreen.BackColor = System.Drawing.Color.DimGray;
            this.MasterPictureScreen.Location = new System.Drawing.Point(19, 36);
            this.MasterPictureScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MasterPictureScreen.Name = "MasterPictureScreen";
            this.MasterPictureScreen.Size = new System.Drawing.Size(215, 146);
            this.MasterPictureScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MasterPictureScreen.TabIndex = 2;
            this.MasterPictureScreen.TabStop = false;
            this.MasterPictureScreen.Tag = "picture";
            // 
            // MasterButtonGame
            // 
            this.MasterButtonGame.BackgroundImage = global::TinyVirtualQ.Res.icon_game_tiny;
            this.MasterButtonGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MasterButtonGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MasterButtonGame.Location = new System.Drawing.Point(19, 322);
            this.MasterButtonGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MasterButtonGame.Name = "MasterButtonGame";
            this.MasterButtonGame.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.MasterButtonGame.Size = new System.Drawing.Size(215, 46);
            this.MasterButtonGame.TabIndex = 1;
            this.MasterButtonGame.Tag = "";
            this.MasterButtonGame.Text = "Concurso";
            this.MasterButtonGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MasterButtonGame.UseVisualStyleBackColor = true;
            // 
            // MasterButtonLogo
            // 
            this.MasterButtonLogo.BackgroundImage = global::TinyVirtualQ.Res.icon_home_tiny;
            this.MasterButtonLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MasterButtonLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MasterButtonLogo.Location = new System.Drawing.Point(19, 271);
            this.MasterButtonLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MasterButtonLogo.Name = "MasterButtonLogo";
            this.MasterButtonLogo.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.MasterButtonLogo.Size = new System.Drawing.Size(215, 46);
            this.MasterButtonLogo.TabIndex = 1;
            this.MasterButtonLogo.Tag = "";
            this.MasterButtonLogo.Text = "Logo";
            this.MasterButtonLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MasterButtonLogo.UseVisualStyleBackColor = true;
            // 
            // MasterButtonStatus
            // 
            this.MasterButtonStatus.BackgroundImage = global::TinyVirtualQ.Res.icon_stats_tiny;
            this.MasterButtonStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MasterButtonStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MasterButtonStatus.Location = new System.Drawing.Point(19, 221);
            this.MasterButtonStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MasterButtonStatus.Name = "MasterButtonStatus";
            this.MasterButtonStatus.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.MasterButtonStatus.Size = new System.Drawing.Size(215, 46);
            this.MasterButtonStatus.TabIndex = 1;
            this.MasterButtonStatus.Tag = "";
            this.MasterButtonStatus.Text = "Estado";
            this.MasterButtonStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MasterButtonStatus.UseVisualStyleBackColor = true;
            // 
            // MasterButtonClear
            // 
            this.MasterButtonClear.BackgroundImage = global::TinyVirtualQ.Res.icon_trash;
            this.MasterButtonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MasterButtonClear.Location = new System.Drawing.Point(64, 460);
            this.MasterButtonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MasterButtonClear.Name = "MasterButtonClear";
            this.MasterButtonClear.Size = new System.Drawing.Size(39, 36);
            this.MasterButtonClear.TabIndex = 1;
            this.MasterButtonClear.Tag = "update";
            this.MasterButtonClear.UseVisualStyleBackColor = true;
            // 
            // MasterButtonMessage
            // 
            this.MasterButtonMessage.BackgroundImage = global::TinyVirtualQ.Res.icon_send;
            this.MasterButtonMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MasterButtonMessage.Location = new System.Drawing.Point(21, 460);
            this.MasterButtonMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MasterButtonMessage.Name = "MasterButtonMessage";
            this.MasterButtonMessage.Size = new System.Drawing.Size(39, 36);
            this.MasterButtonMessage.TabIndex = 1;
            this.MasterButtonMessage.Tag = "update";
            this.MasterButtonMessage.UseVisualStyleBackColor = true;
            // 
            // MasterButtonUpdate
            // 
            this.MasterButtonUpdate.BackgroundImage = global::TinyVirtualQ.Res.icon_update;
            this.MasterButtonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MasterButtonUpdate.Location = new System.Drawing.Point(204, 187);
            this.MasterButtonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MasterButtonUpdate.Name = "MasterButtonUpdate";
            this.MasterButtonUpdate.Size = new System.Drawing.Size(32, 30);
            this.MasterButtonUpdate.TabIndex = 1;
            this.MasterButtonUpdate.Tag = "";
            this.MasterButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // MasterComboScreens
            // 
            this.MasterComboScreens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MasterComboScreens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MasterComboScreens.FormattingEnabled = true;
            this.MasterComboScreens.Location = new System.Drawing.Point(19, 188);
            this.MasterComboScreens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MasterComboScreens.Name = "MasterComboScreens";
            this.MasterComboScreens.Size = new System.Drawing.Size(179, 23);
            this.MasterComboScreens.TabIndex = 0;
            this.MasterComboScreens.Tag = "";
            // 
            // GSlave
            // 
            this.GSlave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GSlave.Controls.Add(this.SlavePictureScreen);
            this.GSlave.Controls.Add(this.SlaveButtonGame);
            this.GSlave.Controls.Add(this.SlaveButtonLogo);
            this.GSlave.Controls.Add(this.SlaveButtonBlack);
            this.GSlave.Controls.Add(this.SlaveButtonUpdate);
            this.GSlave.Controls.Add(this.SlaveComboScreens);
            this.GSlave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.GSlave.Location = new System.Drawing.Point(361, 6);
            this.GSlave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GSlave.Name = "GSlave";
            this.GSlave.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GSlave.Size = new System.Drawing.Size(258, 887);
            this.GSlave.TabIndex = 2;
            this.GSlave.TabStop = false;
            this.GSlave.Text = "Slave";
            // 
            // SlavePictureScreen
            // 
            this.SlavePictureScreen.BackColor = System.Drawing.Color.DimGray;
            this.SlavePictureScreen.Location = new System.Drawing.Point(21, 36);
            this.SlavePictureScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SlavePictureScreen.Name = "SlavePictureScreen";
            this.SlavePictureScreen.Size = new System.Drawing.Size(215, 146);
            this.SlavePictureScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SlavePictureScreen.TabIndex = 2;
            this.SlavePictureScreen.TabStop = false;
            this.SlavePictureScreen.Tag = "picture";
            // 
            // SlaveButtonGame
            // 
            this.SlaveButtonGame.BackgroundImage = global::TinyVirtualQ.Res.icon_game_tiny;
            this.SlaveButtonGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SlaveButtonGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlaveButtonGame.Location = new System.Drawing.Point(22, 319);
            this.SlaveButtonGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SlaveButtonGame.Name = "SlaveButtonGame";
            this.SlaveButtonGame.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.SlaveButtonGame.Size = new System.Drawing.Size(215, 46);
            this.SlaveButtonGame.TabIndex = 1;
            this.SlaveButtonGame.Tag = "";
            this.SlaveButtonGame.Text = "Concurso";
            this.SlaveButtonGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlaveButtonGame.UseVisualStyleBackColor = true;
            // 
            // SlaveButtonLogo
            // 
            this.SlaveButtonLogo.BackgroundImage = global::TinyVirtualQ.Res.icon_home_tiny;
            this.SlaveButtonLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SlaveButtonLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlaveButtonLogo.Location = new System.Drawing.Point(22, 270);
            this.SlaveButtonLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SlaveButtonLogo.Name = "SlaveButtonLogo";
            this.SlaveButtonLogo.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.SlaveButtonLogo.Size = new System.Drawing.Size(215, 46);
            this.SlaveButtonLogo.TabIndex = 1;
            this.SlaveButtonLogo.Tag = "";
            this.SlaveButtonLogo.Text = "Logo";
            this.SlaveButtonLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlaveButtonLogo.UseVisualStyleBackColor = true;
            // 
            // SlaveButtonBlack
            // 
            this.SlaveButtonBlack.BackgroundImage = global::TinyVirtualQ.Res.icon_stats_tiny;
            this.SlaveButtonBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SlaveButtonBlack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlaveButtonBlack.Location = new System.Drawing.Point(22, 220);
            this.SlaveButtonBlack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SlaveButtonBlack.Name = "SlaveButtonBlack";
            this.SlaveButtonBlack.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.SlaveButtonBlack.Size = new System.Drawing.Size(215, 46);
            this.SlaveButtonBlack.TabIndex = 1;
            this.SlaveButtonBlack.Tag = "";
            this.SlaveButtonBlack.Text = "Pantalla oscura";
            this.SlaveButtonBlack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlaveButtonBlack.UseVisualStyleBackColor = true;
            // 
            // SlaveButtonUpdate
            // 
            this.SlaveButtonUpdate.BackgroundImage = global::TinyVirtualQ.Res.icon_update;
            this.SlaveButtonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlaveButtonUpdate.Location = new System.Drawing.Point(206, 186);
            this.SlaveButtonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SlaveButtonUpdate.Name = "SlaveButtonUpdate";
            this.SlaveButtonUpdate.Size = new System.Drawing.Size(32, 30);
            this.SlaveButtonUpdate.TabIndex = 1;
            this.SlaveButtonUpdate.Tag = "";
            this.SlaveButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // SlaveComboScreens
            // 
            this.SlaveComboScreens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SlaveComboScreens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SlaveComboScreens.FormattingEnabled = true;
            this.SlaveComboScreens.Location = new System.Drawing.Point(21, 187);
            this.SlaveComboScreens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SlaveComboScreens.Name = "SlaveComboScreens";
            this.SlaveComboScreens.Size = new System.Drawing.Size(179, 23);
            this.SlaveComboScreens.TabIndex = 0;
            this.SlaveComboScreens.Tag = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabContest);
            this.tabControl1.Controls.Add(this.tabScreens);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 50);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 708);
            this.tabControl1.TabIndex = 4;
            // 
            // tabContest
            // 
            this.tabContest.Controls.Add(this.PanelContest);
            this.tabContest.Location = new System.Drawing.Point(4, 54);
            this.tabContest.Margin = new System.Windows.Forms.Padding(0);
            this.tabContest.Name = "tabContest";
            this.tabContest.Size = new System.Drawing.Size(800, 650);
            this.tabContest.TabIndex = 0;
            this.tabContest.Text = "Concurso";
            this.tabContest.UseVisualStyleBackColor = true;
            // 
            // tabScreens
            // 
            this.tabScreens.Controls.Add(this.GMaster);
            this.tabScreens.Controls.Add(this.GSlave);
            this.tabScreens.Location = new System.Drawing.Point(4, 54);
            this.tabScreens.Margin = new System.Windows.Forms.Padding(4);
            this.tabScreens.Name = "tabScreens";
            this.tabScreens.Padding = new System.Windows.Forms.Padding(4);
            this.tabScreens.Size = new System.Drawing.Size(800, 650);
            this.tabScreens.TabIndex = 1;
            this.tabScreens.Text = "Pantallas";
            this.tabScreens.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabSettings.Location = new System.Drawing.Point(4, 54);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(4);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(800, 650);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Configuración";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // PanelContest
            // 
            this.PanelContest.Controls.Add(this.button1);
            this.PanelContest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContest.Location = new System.Drawing.Point(0, 0);
            this.PanelContest.Margin = new System.Windows.Forms.Padding(0);
            this.PanelContest.Name = "PanelContest";
            this.PanelContest.Size = new System.Drawing.Size(800, 650);
            this.PanelContest.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(808, 708);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questy-ON";
            this.Load += new System.EventHandler(this.onLoad);
            this.GMaster.ResumeLayout(false);
            this.GMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterPictureScreen)).EndInit();
            this.GSlave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SlavePictureScreen)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabContest.ResumeLayout(false);
            this.tabScreens.ResumeLayout(false);
            this.PanelContest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.GroupBox GSlave;
        private System.Windows.Forms.PictureBox SlavePictureScreen;
        private System.Windows.Forms.Button SlaveButtonGame;
        private System.Windows.Forms.Button SlaveButtonLogo;
        private System.Windows.Forms.Button SlaveButtonBlack;
        private System.Windows.Forms.Button SlaveButtonUpdate;
        private System.Windows.Forms.ComboBox SlaveComboScreens;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabContest;
        private System.Windows.Forms.TabPage tabScreens;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Panel PanelContest;
        private System.Windows.Forms.Button button1;
    }
}