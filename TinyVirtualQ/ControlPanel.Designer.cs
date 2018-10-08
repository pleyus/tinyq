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
            this.GAdmin = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListPlayers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdminButtonWrong = new System.Windows.Forms.Button();
            this.AdminButtonCorrect = new System.Windows.Forms.Button();
            this.AdminButtonWait = new System.Windows.Forms.Button();
            this.AdminButtonRun = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.AdminButtonPlayers = new System.Windows.Forms.Button();
            this.AdminButtonRoundStart = new System.Windows.Forms.Button();
            this.AdminButtonContestStart = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.AdminButtonSetQuestion = new System.Windows.Forms.Button();
            this.AdminComboRounds = new System.Windows.Forms.ComboBox();
            this.AdminComboContest = new System.Windows.Forms.ComboBox();
            this.AdminButtonOptions = new System.Windows.Forms.Button();
            this.AdminButtonSetBreak = new System.Windows.Forms.Button();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterPictureScreen)).BeginInit();
            this.GSlave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlavePictureScreen)).BeginInit();
            this.GAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel de control";
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
            this.GMaster.Location = new System.Drawing.Point(11, 44);
            this.GMaster.Margin = new System.Windows.Forms.Padding(2);
            this.GMaster.Name = "GMaster";
            this.GMaster.Padding = new System.Windows.Forms.Padding(2);
            this.GMaster.Size = new System.Drawing.Size(201, 486);
            this.GMaster.TabIndex = 2;
            this.GMaster.TabStop = false;
            this.GMaster.Text = "Master";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label2.Location = new System.Drawing.Point(12, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enviar mensaje al master";
            // 
            // MasterTextMessage
            // 
            this.MasterTextMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MasterTextMessage.Location = new System.Drawing.Point(16, 302);
            this.MasterTextMessage.Margin = new System.Windows.Forms.Padding(2);
            this.MasterTextMessage.Multiline = true;
            this.MasterTextMessage.Name = "MasterTextMessage";
            this.MasterTextMessage.Size = new System.Drawing.Size(166, 50);
            this.MasterTextMessage.TabIndex = 3;
            // 
            // MasterPictureScreen
            // 
            this.MasterPictureScreen.BackColor = System.Drawing.Color.DimGray;
            this.MasterPictureScreen.Location = new System.Drawing.Point(15, 30);
            this.MasterPictureScreen.Margin = new System.Windows.Forms.Padding(2);
            this.MasterPictureScreen.Name = "MasterPictureScreen";
            this.MasterPictureScreen.Size = new System.Drawing.Size(167, 95);
            this.MasterPictureScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MasterPictureScreen.TabIndex = 2;
            this.MasterPictureScreen.TabStop = false;
            this.MasterPictureScreen.Tag = "picture";
            // 
            // MasterButtonGame
            // 
            this.MasterButtonGame.BackgroundImage = global::TinyVirtualQ.Resource1.icon_game_tiny;
            this.MasterButtonGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MasterButtonGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MasterButtonGame.Location = new System.Drawing.Point(15, 241);
            this.MasterButtonGame.Margin = new System.Windows.Forms.Padding(2);
            this.MasterButtonGame.Name = "MasterButtonGame";
            this.MasterButtonGame.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.MasterButtonGame.Size = new System.Drawing.Size(167, 38);
            this.MasterButtonGame.TabIndex = 1;
            this.MasterButtonGame.Tag = "";
            this.MasterButtonGame.Text = "Concurso";
            this.MasterButtonGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MasterButtonGame.UseVisualStyleBackColor = true;
            // 
            // MasterButtonLogo
            // 
            this.MasterButtonLogo.BackgroundImage = global::TinyVirtualQ.Resource1.icon_home_tiny;
            this.MasterButtonLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MasterButtonLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MasterButtonLogo.Location = new System.Drawing.Point(15, 199);
            this.MasterButtonLogo.Margin = new System.Windows.Forms.Padding(2);
            this.MasterButtonLogo.Name = "MasterButtonLogo";
            this.MasterButtonLogo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.MasterButtonLogo.Size = new System.Drawing.Size(167, 38);
            this.MasterButtonLogo.TabIndex = 1;
            this.MasterButtonLogo.Tag = "";
            this.MasterButtonLogo.Text = "Logo";
            this.MasterButtonLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MasterButtonLogo.UseVisualStyleBackColor = true;
            // 
            // MasterButtonStatus
            // 
            this.MasterButtonStatus.BackgroundImage = global::TinyVirtualQ.Resource1.icon_stats_tiny;
            this.MasterButtonStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MasterButtonStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MasterButtonStatus.Location = new System.Drawing.Point(15, 157);
            this.MasterButtonStatus.Margin = new System.Windows.Forms.Padding(2);
            this.MasterButtonStatus.Name = "MasterButtonStatus";
            this.MasterButtonStatus.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.MasterButtonStatus.Size = new System.Drawing.Size(167, 38);
            this.MasterButtonStatus.TabIndex = 1;
            this.MasterButtonStatus.Tag = "";
            this.MasterButtonStatus.Text = "Estado";
            this.MasterButtonStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MasterButtonStatus.UseVisualStyleBackColor = true;
            // 
            // MasterButtonClear
            // 
            this.MasterButtonClear.BackgroundImage = global::TinyVirtualQ.Resource1.icon_trash;
            this.MasterButtonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MasterButtonClear.Location = new System.Drawing.Point(50, 356);
            this.MasterButtonClear.Margin = new System.Windows.Forms.Padding(2);
            this.MasterButtonClear.Name = "MasterButtonClear";
            this.MasterButtonClear.Size = new System.Drawing.Size(30, 30);
            this.MasterButtonClear.TabIndex = 1;
            this.MasterButtonClear.Tag = "update";
            this.MasterButtonClear.UseVisualStyleBackColor = true;
            // 
            // MasterButtonMessage
            // 
            this.MasterButtonMessage.BackgroundImage = global::TinyVirtualQ.Resource1.icon_send;
            this.MasterButtonMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MasterButtonMessage.Location = new System.Drawing.Point(16, 356);
            this.MasterButtonMessage.Margin = new System.Windows.Forms.Padding(2);
            this.MasterButtonMessage.Name = "MasterButtonMessage";
            this.MasterButtonMessage.Size = new System.Drawing.Size(30, 30);
            this.MasterButtonMessage.TabIndex = 1;
            this.MasterButtonMessage.Tag = "update";
            this.MasterButtonMessage.UseVisualStyleBackColor = true;
            // 
            // MasterButtonUpdate
            // 
            this.MasterButtonUpdate.BackgroundImage = global::TinyVirtualQ.Resource1.icon_update;
            this.MasterButtonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MasterButtonUpdate.Location = new System.Drawing.Point(159, 129);
            this.MasterButtonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.MasterButtonUpdate.Name = "MasterButtonUpdate";
            this.MasterButtonUpdate.Size = new System.Drawing.Size(25, 25);
            this.MasterButtonUpdate.TabIndex = 1;
            this.MasterButtonUpdate.Tag = "";
            this.MasterButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // MasterComboScreens
            // 
            this.MasterComboScreens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MasterComboScreens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MasterComboScreens.FormattingEnabled = true;
            this.MasterComboScreens.Location = new System.Drawing.Point(15, 130);
            this.MasterComboScreens.Margin = new System.Windows.Forms.Padding(2);
            this.MasterComboScreens.Name = "MasterComboScreens";
            this.MasterComboScreens.Size = new System.Drawing.Size(140, 23);
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
            this.GSlave.Location = new System.Drawing.Point(844, 44);
            this.GSlave.Margin = new System.Windows.Forms.Padding(2);
            this.GSlave.Name = "GSlave";
            this.GSlave.Padding = new System.Windows.Forms.Padding(2);
            this.GSlave.Size = new System.Drawing.Size(201, 486);
            this.GSlave.TabIndex = 2;
            this.GSlave.TabStop = false;
            this.GSlave.Text = "Slave";
            // 
            // SlavePictureScreen
            // 
            this.SlavePictureScreen.BackColor = System.Drawing.Color.DimGray;
            this.SlavePictureScreen.Location = new System.Drawing.Point(16, 30);
            this.SlavePictureScreen.Margin = new System.Windows.Forms.Padding(2);
            this.SlavePictureScreen.Name = "SlavePictureScreen";
            this.SlavePictureScreen.Size = new System.Drawing.Size(167, 95);
            this.SlavePictureScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SlavePictureScreen.TabIndex = 2;
            this.SlavePictureScreen.TabStop = false;
            this.SlavePictureScreen.Tag = "picture";
            // 
            // SlaveButtonGame
            // 
            this.SlaveButtonGame.BackgroundImage = global::TinyVirtualQ.Resource1.icon_game_tiny;
            this.SlaveButtonGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SlaveButtonGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlaveButtonGame.Location = new System.Drawing.Point(16, 245);
            this.SlaveButtonGame.Margin = new System.Windows.Forms.Padding(2);
            this.SlaveButtonGame.Name = "SlaveButtonGame";
            this.SlaveButtonGame.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.SlaveButtonGame.Size = new System.Drawing.Size(167, 38);
            this.SlaveButtonGame.TabIndex = 1;
            this.SlaveButtonGame.Tag = "";
            this.SlaveButtonGame.Text = "Concurso";
            this.SlaveButtonGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlaveButtonGame.UseVisualStyleBackColor = true;
            // 
            // SlaveButtonLogo
            // 
            this.SlaveButtonLogo.BackgroundImage = global::TinyVirtualQ.Resource1.icon_home_tiny;
            this.SlaveButtonLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SlaveButtonLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlaveButtonLogo.Location = new System.Drawing.Point(16, 204);
            this.SlaveButtonLogo.Margin = new System.Windows.Forms.Padding(2);
            this.SlaveButtonLogo.Name = "SlaveButtonLogo";
            this.SlaveButtonLogo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.SlaveButtonLogo.Size = new System.Drawing.Size(167, 38);
            this.SlaveButtonLogo.TabIndex = 1;
            this.SlaveButtonLogo.Tag = "";
            this.SlaveButtonLogo.Text = "Logo";
            this.SlaveButtonLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlaveButtonLogo.UseVisualStyleBackColor = true;
            // 
            // SlaveButtonBlack
            // 
            this.SlaveButtonBlack.BackgroundImage = global::TinyVirtualQ.Resource1.icon_stats_tiny;
            this.SlaveButtonBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SlaveButtonBlack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlaveButtonBlack.Location = new System.Drawing.Point(16, 162);
            this.SlaveButtonBlack.Margin = new System.Windows.Forms.Padding(2);
            this.SlaveButtonBlack.Name = "SlaveButtonBlack";
            this.SlaveButtonBlack.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.SlaveButtonBlack.Size = new System.Drawing.Size(167, 38);
            this.SlaveButtonBlack.TabIndex = 1;
            this.SlaveButtonBlack.Tag = "";
            this.SlaveButtonBlack.Text = "Pantalla oscura";
            this.SlaveButtonBlack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlaveButtonBlack.UseVisualStyleBackColor = true;
            // 
            // SlaveButtonUpdate
            // 
            this.SlaveButtonUpdate.BackgroundImage = global::TinyVirtualQ.Resource1.icon_update;
            this.SlaveButtonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlaveButtonUpdate.Location = new System.Drawing.Point(159, 129);
            this.SlaveButtonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.SlaveButtonUpdate.Name = "SlaveButtonUpdate";
            this.SlaveButtonUpdate.Size = new System.Drawing.Size(25, 25);
            this.SlaveButtonUpdate.TabIndex = 1;
            this.SlaveButtonUpdate.Tag = "";
            this.SlaveButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // SlaveComboScreens
            // 
            this.SlaveComboScreens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SlaveComboScreens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SlaveComboScreens.FormattingEnabled = true;
            this.SlaveComboScreens.Location = new System.Drawing.Point(16, 130);
            this.SlaveComboScreens.Margin = new System.Windows.Forms.Padding(2);
            this.SlaveComboScreens.Name = "SlaveComboScreens";
            this.SlaveComboScreens.Size = new System.Drawing.Size(140, 28);
            this.SlaveComboScreens.TabIndex = 0;
            this.SlaveComboScreens.Tag = "";
            // 
            // GAdmin
            // 
            this.GAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GAdmin.Controls.Add(this.label4);
            this.GAdmin.Controls.Add(this.label3);
            this.GAdmin.Controls.Add(this.ListPlayers);
            this.GAdmin.Controls.Add(this.AdminButtonWrong);
            this.GAdmin.Controls.Add(this.AdminButtonCorrect);
            this.GAdmin.Controls.Add(this.AdminButtonWait);
            this.GAdmin.Controls.Add(this.AdminButtonRun);
            this.GAdmin.Controls.Add(this.button6);
            this.GAdmin.Controls.Add(this.AdminButtonPlayers);
            this.GAdmin.Controls.Add(this.AdminButtonRoundStart);
            this.GAdmin.Controls.Add(this.AdminButtonContestStart);
            this.GAdmin.Controls.Add(this.button5);
            this.GAdmin.Controls.Add(this.AdminButtonSetBreak);
            this.GAdmin.Controls.Add(this.AdminButtonSetQuestion);
            this.GAdmin.Controls.Add(this.AdminComboRounds);
            this.GAdmin.Controls.Add(this.AdminComboContest);
            this.GAdmin.Location = new System.Drawing.Point(217, 44);
            this.GAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.GAdmin.Name = "GAdmin";
            this.GAdmin.Padding = new System.Windows.Forms.Padding(2);
            this.GAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GAdmin.Size = new System.Drawing.Size(623, 486);
            this.GAdmin.TabIndex = 3;
            this.GAdmin.TabStop = false;
            this.GAdmin.Text = "Administrador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.Location = new System.Drawing.Point(13, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ronda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(13, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Concurso";
            // 
            // ListPlayers
            // 
            this.ListPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ListPlayers.Enabled = false;
            this.ListPlayers.FullRowSelect = true;
            this.ListPlayers.Location = new System.Drawing.Point(16, 111);
            this.ListPlayers.Name = "ListPlayers";
            this.ListPlayers.Size = new System.Drawing.Size(590, 208);
            this.ListPlayers.TabIndex = 2;
            this.ListPlayers.UseCompatibleStateImageBehavior = false;
            this.ListPlayers.View = System.Windows.Forms.View.Details;
            this.ListPlayers.SelectedIndexChanged += new System.EventHandler(this.PlayerClicked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Jugador";
            this.columnHeader1.Width = 291;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Preguntas";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Aciertos";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Desempate";
            this.columnHeader4.Width = 92;
            // 
            // AdminButtonWrong
            // 
            this.AdminButtonWrong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AdminButtonWrong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AdminButtonWrong.Enabled = false;
            this.AdminButtonWrong.Image = global::TinyVirtualQ.Resource1.wrong;
            this.AdminButtonWrong.Location = new System.Drawing.Point(178, 414);
            this.AdminButtonWrong.Margin = new System.Windows.Forms.Padding(2);
            this.AdminButtonWrong.Name = "AdminButtonWrong";
            this.AdminButtonWrong.Size = new System.Drawing.Size(157, 54);
            this.AdminButtonWrong.TabIndex = 1;
            this.AdminButtonWrong.Tag = "";
            this.AdminButtonWrong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminButtonWrong.UseVisualStyleBackColor = true;
            this.AdminButtonWrong.Click += new System.EventHandler(this.GameActions);
            // 
            // AdminButtonCorrect
            // 
            this.AdminButtonCorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AdminButtonCorrect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AdminButtonCorrect.Enabled = false;
            this.AdminButtonCorrect.Image = global::TinyVirtualQ.Resource1.correct;
            this.AdminButtonCorrect.Location = new System.Drawing.Point(16, 415);
            this.AdminButtonCorrect.Margin = new System.Windows.Forms.Padding(2);
            this.AdminButtonCorrect.Name = "AdminButtonCorrect";
            this.AdminButtonCorrect.Size = new System.Drawing.Size(157, 54);
            this.AdminButtonCorrect.TabIndex = 1;
            this.AdminButtonCorrect.Tag = "";
            this.AdminButtonCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminButtonCorrect.UseVisualStyleBackColor = true;
            this.AdminButtonCorrect.Click += new System.EventHandler(this.GameActions);
            // 
            // AdminButtonWait
            // 
            this.AdminButtonWait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AdminButtonWait.BackgroundImage = global::TinyVirtualQ.Resource1.icon_stats_tiny;
            this.AdminButtonWait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AdminButtonWait.Enabled = false;
            this.AdminButtonWait.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminButtonWait.Location = new System.Drawing.Point(178, 372);
            this.AdminButtonWait.Margin = new System.Windows.Forms.Padding(2);
            this.AdminButtonWait.Name = "AdminButtonWait";
            this.AdminButtonWait.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.AdminButtonWait.Size = new System.Drawing.Size(157, 38);
            this.AdminButtonWait.TabIndex = 1;
            this.AdminButtonWait.Tag = "";
            this.AdminButtonWait.Text = "Detener";
            this.AdminButtonWait.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminButtonWait.UseVisualStyleBackColor = true;
            this.AdminButtonWait.Click += new System.EventHandler(this.GameActions);
            // 
            // AdminButtonRun
            // 
            this.AdminButtonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AdminButtonRun.BackgroundImage = global::TinyVirtualQ.Resource1.icon_stats_tiny;
            this.AdminButtonRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AdminButtonRun.Enabled = false;
            this.AdminButtonRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminButtonRun.Location = new System.Drawing.Point(16, 372);
            this.AdminButtonRun.Margin = new System.Windows.Forms.Padding(2);
            this.AdminButtonRun.Name = "AdminButtonRun";
            this.AdminButtonRun.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.AdminButtonRun.Size = new System.Drawing.Size(157, 38);
            this.AdminButtonRun.TabIndex = 1;
            this.AdminButtonRun.Tag = "";
            this.AdminButtonRun.Text = "Corre tiempo";
            this.AdminButtonRun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminButtonRun.UseVisualStyleBackColor = true;
            this.AdminButtonRun.Click += new System.EventHandler(this.GameActions);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackgroundImage = global::TinyVirtualQ.Resource1.icon_stats_tiny;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Enabled = false;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(445, 372);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(161, 38);
            this.button6.TabIndex = 1;
            this.button6.Tag = "";
            this.button6.Text = "Terminar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // AdminButtonPlayers
            // 
            this.AdminButtonPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminButtonPlayers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdminButtonPlayers.Enabled = false;
            this.AdminButtonPlayers.Location = new System.Drawing.Point(514, 64);
            this.AdminButtonPlayers.Margin = new System.Windows.Forms.Padding(2);
            this.AdminButtonPlayers.Name = "AdminButtonPlayers";
            this.AdminButtonPlayers.Size = new System.Drawing.Size(92, 28);
            this.AdminButtonPlayers.TabIndex = 1;
            this.AdminButtonPlayers.Tag = "";
            this.AdminButtonPlayers.Text = "Jugadores";
            this.AdminButtonPlayers.UseVisualStyleBackColor = true;
            // 
            // AdminButtonRoundStart
            // 
            this.AdminButtonRoundStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdminButtonRoundStart.Enabled = false;
            this.AdminButtonRoundStart.Location = new System.Drawing.Point(274, 64);
            this.AdminButtonRoundStart.Margin = new System.Windows.Forms.Padding(2);
            this.AdminButtonRoundStart.Name = "AdminButtonRoundStart";
            this.AdminButtonRoundStart.Size = new System.Drawing.Size(92, 28);
            this.AdminButtonRoundStart.TabIndex = 1;
            this.AdminButtonRoundStart.Tag = "";
            this.AdminButtonRoundStart.Text = "Iniciar";
            this.AdminButtonRoundStart.UseVisualStyleBackColor = true;
            this.AdminButtonRoundStart.Click += new System.EventHandler(this.StartRound);
            // 
            // AdminButtonContestStart
            // 
            this.AdminButtonContestStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminButtonContestStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdminButtonContestStart.Location = new System.Drawing.Point(535, 24);
            this.AdminButtonContestStart.Margin = new System.Windows.Forms.Padding(2);
            this.AdminButtonContestStart.Name = "AdminButtonContestStart";
            this.AdminButtonContestStart.Size = new System.Drawing.Size(71, 28);
            this.AdminButtonContestStart.TabIndex = 1;
            this.AdminButtonContestStart.Tag = "";
            this.AdminButtonContestStart.Text = "Cargar";
            this.AdminButtonContestStart.UseVisualStyleBackColor = true;
            this.AdminButtonContestStart.Click += new System.EventHandler(this.LoadRoundsInfo);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackgroundImage = global::TinyVirtualQ.Resource1.icon_stats_tiny;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Enabled = false;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(445, 330);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(161, 38);
            this.button5.TabIndex = 1;
            this.button5.Tag = "";
            this.button5.Text = "Analizar resultados";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // AdminButtonSetQuestion
            // 
            this.AdminButtonSetQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AdminButtonSetQuestion.BackgroundImage = global::TinyVirtualQ.Resource1.icon_stats_tiny;
            this.AdminButtonSetQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AdminButtonSetQuestion.Enabled = false;
            this.AdminButtonSetQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminButtonSetQuestion.Location = new System.Drawing.Point(16, 330);
            this.AdminButtonSetQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.AdminButtonSetQuestion.Name = "AdminButtonSetQuestion";
            this.AdminButtonSetQuestion.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.AdminButtonSetQuestion.Size = new System.Drawing.Size(196, 38);
            this.AdminButtonSetQuestion.TabIndex = 1;
            this.AdminButtonSetQuestion.Tag = "";
            this.AdminButtonSetQuestion.Text = "Asignar siguiente pregunta";
            this.AdminButtonSetQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminButtonSetQuestion.UseVisualStyleBackColor = true;
            this.AdminButtonSetQuestion.Click += new System.EventHandler(this.GameActions);
            // 
            // AdminComboRounds
            // 
            this.AdminComboRounds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdminComboRounds.Enabled = false;
            this.AdminComboRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AdminComboRounds.FormattingEnabled = true;
            this.AdminComboRounds.Location = new System.Drawing.Point(69, 65);
            this.AdminComboRounds.Margin = new System.Windows.Forms.Padding(2);
            this.AdminComboRounds.Name = "AdminComboRounds";
            this.AdminComboRounds.Size = new System.Drawing.Size(201, 26);
            this.AdminComboRounds.TabIndex = 0;
            this.AdminComboRounds.Tag = "";
            // 
            // AdminComboContest
            // 
            this.AdminComboContest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminComboContest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdminComboContest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AdminComboContest.FormattingEnabled = true;
            this.AdminComboContest.Location = new System.Drawing.Point(69, 25);
            this.AdminComboContest.Margin = new System.Windows.Forms.Padding(2);
            this.AdminComboContest.Name = "AdminComboContest";
            this.AdminComboContest.Size = new System.Drawing.Size(462, 26);
            this.AdminComboContest.TabIndex = 0;
            this.AdminComboContest.Tag = "";
            // 
            // AdminButtonOptions
            // 
            this.AdminButtonOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminButtonOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdminButtonOptions.Location = new System.Drawing.Point(954, 12);
            this.AdminButtonOptions.Margin = new System.Windows.Forms.Padding(2);
            this.AdminButtonOptions.Name = "AdminButtonOptions";
            this.AdminButtonOptions.Size = new System.Drawing.Size(91, 28);
            this.AdminButtonOptions.TabIndex = 1;
            this.AdminButtonOptions.Tag = "";
            this.AdminButtonOptions.Text = "Opciones";
            this.AdminButtonOptions.UseVisualStyleBackColor = true;
            this.AdminButtonOptions.Click += new System.EventHandler(this.OptionsInit);
            // 
            // AdminButtonSetBreak
            // 
            this.AdminButtonSetBreak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AdminButtonSetBreak.BackgroundImage = global::TinyVirtualQ.Resource1.icon_stats_tiny;
            this.AdminButtonSetBreak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AdminButtonSetBreak.Enabled = false;
            this.AdminButtonSetBreak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminButtonSetBreak.Location = new System.Drawing.Point(216, 330);
            this.AdminButtonSetBreak.Margin = new System.Windows.Forms.Padding(2);
            this.AdminButtonSetBreak.Name = "AdminButtonSetBreak";
            this.AdminButtonSetBreak.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.AdminButtonSetBreak.Size = new System.Drawing.Size(119, 38);
            this.AdminButtonSetBreak.TabIndex = 1;
            this.AdminButtonSetBreak.Tag = "";
            this.AdminButtonSetBreak.Text = "Desempate";
            this.AdminButtonSetBreak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminButtonSetBreak.UseVisualStyleBackColor = true;
            this.AdminButtonSetBreak.Click += new System.EventHandler(this.GameActions);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "D. aciertos";
            this.columnHeader5.Width = 99;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1056, 541);
            this.Controls.Add(this.GAdmin);
            this.Controls.Add(this.GSlave);
            this.Controls.Add(this.GMaster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminButtonOptions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlPanel";
            this.Text = "Questy-ON";
            this.Load += new System.EventHandler(this.onLoad);
            this.GMaster.ResumeLayout(false);
            this.GMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterPictureScreen)).EndInit();
            this.GSlave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SlavePictureScreen)).EndInit();
            this.GAdmin.ResumeLayout(false);
            this.GAdmin.PerformLayout();
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
        private System.Windows.Forms.GroupBox GSlave;
        private System.Windows.Forms.PictureBox SlavePictureScreen;
        private System.Windows.Forms.Button SlaveButtonGame;
        private System.Windows.Forms.Button SlaveButtonLogo;
        private System.Windows.Forms.Button SlaveButtonBlack;
        private System.Windows.Forms.Button SlaveButtonUpdate;
        private System.Windows.Forms.ComboBox SlaveComboScreens;
        private System.Windows.Forms.GroupBox GAdmin;
        private System.Windows.Forms.ListView ListPlayers;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button AdminButtonWrong;
        private System.Windows.Forms.Button AdminButtonCorrect;
        private System.Windows.Forms.Button AdminButtonWait;
        private System.Windows.Forms.Button AdminButtonRun;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button AdminButtonSetQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AdminButtonContestStart;
        private System.Windows.Forms.ComboBox AdminComboContest;
        private System.Windows.Forms.Button AdminButtonOptions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AdminButtonPlayers;
        private System.Windows.Forms.Button AdminButtonRoundStart;
        private System.Windows.Forms.ComboBox AdminComboRounds;
        private System.Windows.Forms.Button AdminButtonSetBreak;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}