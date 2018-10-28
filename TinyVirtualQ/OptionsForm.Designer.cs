namespace TinyVirtualQ
{
    partial class OptionsForm
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
            this.components = new System.ComponentModel.Container();
            this.ButtonPlayerDelete = new System.Windows.Forms.Button();
            this.ButtonPlayerNew = new System.Windows.Forms.Button();
            this.ButtonPlayerSave = new System.Windows.Forms.Button();
            this.ButtonPlayerSelectFile = new System.Windows.Forms.Button();
            this.PicturePlayersUserPic = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextPlayerLastname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextPlayerSelectedImage = new System.Windows.Forms.TextBox();
            this.TextPlayerFirstname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListPlayers = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListContest = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonContestCreate = new System.Windows.Forms.Button();
            this.TextContestNew = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GRounds = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberRoundPlayers = new System.Windows.Forms.NumericUpDown();
            this.ButtonRoundDelete = new System.Windows.Forms.Button();
            this.ButtonRoundAdd = new System.Windows.Forms.Button();
            this.ButtonRoundSave = new System.Windows.Forms.Button();
            this.ListRounds = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.NumberRoundQuestions = new System.Windows.Forms.NumericUpDown();
            this.TextQuestionsCategory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonQuestionDelete = new System.Windows.Forms.Button();
            this.ButtonQuestionNew = new System.Windows.Forms.Button();
            this.ButtonQuestionSave = new System.Windows.Forms.Button();
            this.TextQuestionsAnswer = new System.Windows.Forms.TextBox();
            this.TextQuestionsQuestion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ListQuestions = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicturePlayersUserPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GRounds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberRoundPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberRoundQuestions)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPlayerDelete
            // 
            this.ButtonPlayerDelete.BackgroundImage = global::TinyVirtualQ.Res.icon_trash;
            this.ButtonPlayerDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonPlayerDelete.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonPlayerDelete.Location = new System.Drawing.Point(723, 282);
            this.ButtonPlayerDelete.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPlayerDelete.Name = "ButtonPlayerDelete";
            this.ButtonPlayerDelete.Size = new System.Drawing.Size(39, 36);
            this.ButtonPlayerDelete.TabIndex = 16;
            this.ButtonPlayerDelete.UseVisualStyleBackColor = true;
            this.ButtonPlayerDelete.Click += new System.EventHandler(this.PlayersButtonsClick);
            // 
            // ButtonPlayerNew
            // 
            this.ButtonPlayerNew.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonPlayerNew.Location = new System.Drawing.Point(615, 282);
            this.ButtonPlayerNew.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPlayerNew.Name = "ButtonPlayerNew";
            this.ButtonPlayerNew.Size = new System.Drawing.Size(99, 36);
            this.ButtonPlayerNew.TabIndex = 15;
            this.ButtonPlayerNew.Text = "Nuevo...";
            this.ButtonPlayerNew.UseVisualStyleBackColor = true;
            this.ButtonPlayerNew.Click += new System.EventHandler(this.PlayersButtonsClick);
            // 
            // ButtonPlayerSave
            // 
            this.ButtonPlayerSave.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonPlayerSave.Location = new System.Drawing.Point(507, 282);
            this.ButtonPlayerSave.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPlayerSave.Name = "ButtonPlayerSave";
            this.ButtonPlayerSave.Size = new System.Drawing.Size(99, 36);
            this.ButtonPlayerSave.TabIndex = 14;
            this.ButtonPlayerSave.Text = "Guardar";
            this.ButtonPlayerSave.UseVisualStyleBackColor = true;
            this.ButtonPlayerSave.Click += new System.EventHandler(this.PlayersButtonsClick);
            // 
            // ButtonPlayerSelectFile
            // 
            this.ButtonPlayerSelectFile.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonPlayerSelectFile.Location = new System.Drawing.Point(726, 228);
            this.ButtonPlayerSelectFile.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPlayerSelectFile.Name = "ButtonPlayerSelectFile";
            this.ButtonPlayerSelectFile.Size = new System.Drawing.Size(36, 33);
            this.ButtonPlayerSelectFile.TabIndex = 2;
            this.ButtonPlayerSelectFile.UseVisualStyleBackColor = true;
            this.ButtonPlayerSelectFile.Click += new System.EventHandler(this.PlayersButtonsClick);
            // 
            // PicturePlayersUserPic
            // 
            this.PicturePlayersUserPic.BackColor = System.Drawing.Color.DimGray;
            this.PicturePlayersUserPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicturePlayersUserPic.Image = global::TinyVirtualQ.Res.round_picture_white;
            this.PicturePlayersUserPic.Location = new System.Drawing.Point(529, 27);
            this.PicturePlayersUserPic.Margin = new System.Windows.Forms.Padding(4);
            this.PicturePlayersUserPic.Name = "PicturePlayersUserPic";
            this.PicturePlayersUserPic.Size = new System.Drawing.Size(120, 120);
            this.PicturePlayersUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicturePlayersUserPic.TabIndex = 13;
            this.PicturePlayersUserPic.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8F);
            this.label7.Location = new System.Drawing.Point(425, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8F);
            this.label10.Location = new System.Drawing.Point(425, 217);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 14);
            this.label10.TabIndex = 11;
            this.label10.Text = "Imagen (1:1)";
            // 
            // TextPlayerLastname
            // 
            this.TextPlayerLastname.Font = new System.Drawing.Font("Arial", 12F);
            this.TextPlayerLastname.Location = new System.Drawing.Point(596, 177);
            this.TextPlayerLastname.Margin = new System.Windows.Forms.Padding(4);
            this.TextPlayerLastname.Name = "TextPlayerLastname";
            this.TextPlayerLastname.Size = new System.Drawing.Size(166, 26);
            this.TextPlayerLastname.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8F);
            this.label9.Location = new System.Drawing.Point(593, 163);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "Apellido";
            // 
            // TextPlayerSelectedImage
            // 
            this.TextPlayerSelectedImage.BackColor = System.Drawing.Color.White;
            this.TextPlayerSelectedImage.Font = new System.Drawing.Font("Arial", 12F);
            this.TextPlayerSelectedImage.Location = new System.Drawing.Point(428, 232);
            this.TextPlayerSelectedImage.Margin = new System.Windows.Forms.Padding(4);
            this.TextPlayerSelectedImage.Name = "TextPlayerSelectedImage";
            this.TextPlayerSelectedImage.ReadOnly = true;
            this.TextPlayerSelectedImage.Size = new System.Drawing.Size(290, 26);
            this.TextPlayerSelectedImage.TabIndex = 4;
            // 
            // TextPlayerFirstname
            // 
            this.TextPlayerFirstname.Font = new System.Drawing.Font("Arial", 12F);
            this.TextPlayerFirstname.Location = new System.Drawing.Point(428, 177);
            this.TextPlayerFirstname.Margin = new System.Windows.Forms.Padding(4);
            this.TextPlayerFirstname.Name = "TextPlayerFirstname";
            this.TextPlayerFirstname.Size = new System.Drawing.Size(161, 26);
            this.TextPlayerFirstname.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonPlayerDelete);
            this.groupBox1.Controls.Add(this.ListPlayers);
            this.groupBox1.Controls.Add(this.ButtonPlayerNew);
            this.groupBox1.Controls.Add(this.PicturePlayersUserPic);
            this.groupBox1.Controls.Add(this.ButtonPlayerSave);
            this.groupBox1.Controls.Add(this.ButtonPlayerSelectFile);
            this.groupBox1.Controls.Add(this.TextPlayerFirstname);
            this.groupBox1.Controls.Add(this.TextPlayerSelectedImage);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TextPlayerLastname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(5, 752);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(770, 335);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jugadores registrados";
            // 
            // ListPlayers
            // 
            this.ListPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9});
            this.ListPlayers.Font = new System.Drawing.Font("Arial", 12F);
            this.ListPlayers.FullRowSelect = true;
            this.ListPlayers.Location = new System.Drawing.Point(7, 27);
            this.ListPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.ListPlayers.MultiSelect = false;
            this.ListPlayers.Name = "ListPlayers";
            this.ListPlayers.Size = new System.Drawing.Size(403, 291);
            this.ListPlayers.TabIndex = 1;
            this.ListPlayers.UseCompatibleStateImageBehavior = false;
            this.ListPlayers.View = System.Windows.Forms.View.Details;
            this.ListPlayers.SelectedIndexChanged += new System.EventHandler(this.PlayerSelection);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Nombre";
            this.columnHeader9.Width = 236;
            // 
            // ListContest
            // 
            this.ListContest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListContest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7});
            this.ListContest.Font = new System.Drawing.Font("Arial", 12F);
            this.ListContest.FullRowSelect = true;
            this.ListContest.Location = new System.Drawing.Point(14, 27);
            this.ListContest.Margin = new System.Windows.Forms.Padding(4);
            this.ListContest.MultiSelect = false;
            this.ListContest.Name = "ListContest";
            this.ListContest.Size = new System.Drawing.Size(356, 175);
            this.ListContest.TabIndex = 0;
            this.ListContest.UseCompatibleStateImageBehavior = false;
            this.ListContest.View = System.Windows.Forms.View.Details;
            this.ListContest.SelectedIndexChanged += new System.EventHandler(this.ContestSelection);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Concurso";
            this.columnHeader7.Width = 326;
            // 
            // ButtonContestCreate
            // 
            this.ButtonContestCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonContestCreate.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonContestCreate.Location = new System.Drawing.Point(282, 210);
            this.ButtonContestCreate.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonContestCreate.Name = "ButtonContestCreate";
            this.ButtonContestCreate.Size = new System.Drawing.Size(88, 36);
            this.ButtonContestCreate.TabIndex = 2;
            this.ButtonContestCreate.Text = "Crear";
            this.ButtonContestCreate.UseVisualStyleBackColor = true;
            this.ButtonContestCreate.Click += new System.EventHandler(this.CreateContest);
            // 
            // TextContestNew
            // 
            this.TextContestNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextContestNew.Font = new System.Drawing.Font("Arial", 12F);
            this.TextContestNew.Location = new System.Drawing.Point(14, 218);
            this.TextContestNew.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TextContestNew.Name = "TextContestNew";
            this.TextContestNew.Size = new System.Drawing.Size(256, 26);
            this.TextContestNew.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8F);
            this.label8.Location = new System.Drawing.Point(11, 205);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Agregar concurso";
            // 
            // GRounds
            // 
            this.GRounds.Controls.Add(this.ButtonContestCreate);
            this.GRounds.Controls.Add(this.ListContest);
            this.GRounds.Controls.Add(this.label2);
            this.GRounds.Controls.Add(this.TextContestNew);
            this.GRounds.Controls.Add(this.NumberRoundPlayers);
            this.GRounds.Controls.Add(this.label8);
            this.GRounds.Controls.Add(this.ButtonRoundDelete);
            this.GRounds.Controls.Add(this.ButtonRoundAdd);
            this.GRounds.Controls.Add(this.ButtonRoundSave);
            this.GRounds.Controls.Add(this.ListRounds);
            this.GRounds.Controls.Add(this.label3);
            this.GRounds.Controls.Add(this.NumberRoundQuestions);
            this.GRounds.Enabled = false;
            this.GRounds.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.GRounds.Location = new System.Drawing.Point(5, 13);
            this.GRounds.Margin = new System.Windows.Forms.Padding(4);
            this.GRounds.Name = "GRounds";
            this.GRounds.Padding = new System.Windows.Forms.Padding(4);
            this.GRounds.Size = new System.Drawing.Size(770, 268);
            this.GRounds.TabIndex = 13;
            this.GRounds.TabStop = false;
            this.GRounds.Text = "Concursos";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F);
            this.label2.Location = new System.Drawing.Point(379, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jugadores";
            this.toolTip1.SetToolTip(this.label2, "Jugadores requeridos para esta ronda");
            // 
            // NumberRoundPlayers
            // 
            this.NumberRoundPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberRoundPlayers.Font = new System.Drawing.Font("Arial", 12F);
            this.NumberRoundPlayers.Location = new System.Drawing.Point(382, 220);
            this.NumberRoundPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.NumberRoundPlayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumberRoundPlayers.Name = "NumberRoundPlayers";
            this.NumberRoundPlayers.Size = new System.Drawing.Size(63, 26);
            this.NumberRoundPlayers.TabIndex = 2;
            this.NumberRoundPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.NumberRoundPlayers, "Jugadores requeridos para esta ronda");
            this.NumberRoundPlayers.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ButtonRoundDelete
            // 
            this.ButtonRoundDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRoundDelete.BackgroundImage = global::TinyVirtualQ.Res.icon_trash;
            this.ButtonRoundDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonRoundDelete.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonRoundDelete.Location = new System.Drawing.Point(717, 210);
            this.ButtonRoundDelete.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRoundDelete.Name = "ButtonRoundDelete";
            this.ButtonRoundDelete.Size = new System.Drawing.Size(39, 36);
            this.ButtonRoundDelete.TabIndex = 6;
            this.ButtonRoundDelete.UseVisualStyleBackColor = true;
            this.ButtonRoundDelete.Click += new System.EventHandler(this.RoundButtonsClick);
            // 
            // ButtonRoundAdd
            // 
            this.ButtonRoundAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRoundAdd.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonRoundAdd.Location = new System.Drawing.Point(630, 210);
            this.ButtonRoundAdd.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRoundAdd.Name = "ButtonRoundAdd";
            this.ButtonRoundAdd.Size = new System.Drawing.Size(88, 36);
            this.ButtonRoundAdd.TabIndex = 5;
            this.ButtonRoundAdd.Text = "Nueva...";
            this.ButtonRoundAdd.UseVisualStyleBackColor = true;
            this.ButtonRoundAdd.Click += new System.EventHandler(this.RoundButtonsClick);
            // 
            // ButtonRoundSave
            // 
            this.ButtonRoundSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRoundSave.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonRoundSave.Location = new System.Drawing.Point(543, 210);
            this.ButtonRoundSave.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRoundSave.Name = "ButtonRoundSave";
            this.ButtonRoundSave.Size = new System.Drawing.Size(88, 36);
            this.ButtonRoundSave.TabIndex = 4;
            this.ButtonRoundSave.Text = "Guardar";
            this.ButtonRoundSave.UseVisualStyleBackColor = true;
            this.ButtonRoundSave.Click += new System.EventHandler(this.RoundButtonsClick);
            // 
            // ListRounds
            // 
            this.ListRounds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListRounds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListRounds.Font = new System.Drawing.Font("Arial", 12F);
            this.ListRounds.FullRowSelect = true;
            this.ListRounds.Location = new System.Drawing.Point(382, 27);
            this.ListRounds.Margin = new System.Windows.Forms.Padding(4);
            this.ListRounds.MultiSelect = false;
            this.ListRounds.Name = "ListRounds";
            this.ListRounds.Size = new System.Drawing.Size(374, 175);
            this.ListRounds.TabIndex = 1;
            this.ListRounds.UseCompatibleStateImageBehavior = false;
            this.ListRounds.View = System.Windows.Forms.View.Details;
            this.ListRounds.SelectedIndexChanged += new System.EventHandler(this.RoundSelection);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ronda";
            this.columnHeader2.Width = 112;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Jugadores";
            this.columnHeader3.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Preguntas";
            this.columnHeader4.Width = 115;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8F);
            this.label3.Location = new System.Drawing.Point(451, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Preguntas";
            this.toolTip1.SetToolTip(this.label3, "Preguntas por jugador");
            // 
            // NumberRoundQuestions
            // 
            this.NumberRoundQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberRoundQuestions.Font = new System.Drawing.Font("Arial", 12F);
            this.NumberRoundQuestions.Location = new System.Drawing.Point(454, 220);
            this.NumberRoundQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.NumberRoundQuestions.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumberRoundQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberRoundQuestions.Name = "NumberRoundQuestions";
            this.NumberRoundQuestions.Size = new System.Drawing.Size(63, 26);
            this.NumberRoundQuestions.TabIndex = 3;
            this.NumberRoundQuestions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.NumberRoundQuestions, "Preguntas por jugador");
            this.NumberRoundQuestions.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // TextQuestionsCategory
            // 
            this.TextQuestionsCategory.Font = new System.Drawing.Font("Arial", 12F);
            this.TextQuestionsCategory.Location = new System.Drawing.Point(96, 346);
            this.TextQuestionsCategory.Margin = new System.Windows.Forms.Padding(4);
            this.TextQuestionsCategory.Name = "TextQuestionsCategory";
            this.TextQuestionsCategory.Size = new System.Drawing.Size(298, 26);
            this.TextQuestionsCategory.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(10, 349);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categoria";
            // 
            // ButtonQuestionDelete
            // 
            this.ButtonQuestionDelete.BackgroundImage = global::TinyVirtualQ.Res.icon_trash;
            this.ButtonQuestionDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonQuestionDelete.Enabled = false;
            this.ButtonQuestionDelete.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonQuestionDelete.Location = new System.Drawing.Point(717, 340);
            this.ButtonQuestionDelete.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonQuestionDelete.Name = "ButtonQuestionDelete";
            this.ButtonQuestionDelete.Size = new System.Drawing.Size(39, 36);
            this.ButtonQuestionDelete.TabIndex = 6;
            this.ButtonQuestionDelete.UseVisualStyleBackColor = true;
            this.ButtonQuestionDelete.Click += new System.EventHandler(this.QuestionsButtonsClick);
            // 
            // ButtonQuestionNew
            // 
            this.ButtonQuestionNew.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonQuestionNew.Location = new System.Drawing.Point(609, 340);
            this.ButtonQuestionNew.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonQuestionNew.Name = "ButtonQuestionNew";
            this.ButtonQuestionNew.Size = new System.Drawing.Size(109, 36);
            this.ButtonQuestionNew.TabIndex = 4;
            this.ButtonQuestionNew.Text = "Nueva";
            this.ButtonQuestionNew.UseVisualStyleBackColor = true;
            this.ButtonQuestionNew.Click += new System.EventHandler(this.QuestionsButtonsClick);
            // 
            // ButtonQuestionSave
            // 
            this.ButtonQuestionSave.Enabled = false;
            this.ButtonQuestionSave.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonQuestionSave.Location = new System.Drawing.Point(501, 340);
            this.ButtonQuestionSave.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonQuestionSave.Name = "ButtonQuestionSave";
            this.ButtonQuestionSave.Size = new System.Drawing.Size(109, 36);
            this.ButtonQuestionSave.TabIndex = 4;
            this.ButtonQuestionSave.Text = "Guardar";
            this.ButtonQuestionSave.UseVisualStyleBackColor = true;
            this.ButtonQuestionSave.Click += new System.EventHandler(this.QuestionsButtonsClick);
            // 
            // TextQuestionsAnswer
            // 
            this.TextQuestionsAnswer.Font = new System.Drawing.Font("Arial", 12F);
            this.TextQuestionsAnswer.Location = new System.Drawing.Point(402, 277);
            this.TextQuestionsAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.TextQuestionsAnswer.Multiline = true;
            this.TextQuestionsAnswer.Name = "TextQuestionsAnswer";
            this.TextQuestionsAnswer.Size = new System.Drawing.Size(354, 55);
            this.TextQuestionsAnswer.TabIndex = 2;
            // 
            // TextQuestionsQuestion
            // 
            this.TextQuestionsQuestion.Font = new System.Drawing.Font("Arial", 12F);
            this.TextQuestionsQuestion.Location = new System.Drawing.Point(12, 277);
            this.TextQuestionsQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.TextQuestionsQuestion.Multiline = true;
            this.TextQuestionsQuestion.Name = "TextQuestionsQuestion";
            this.TextQuestionsQuestion.Size = new System.Drawing.Size(382, 55);
            this.TextQuestionsQuestion.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(397, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Respuesta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(7, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pregunta";
            // 
            // ListQuestions
            // 
            this.ListQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader6});
            this.ListQuestions.Font = new System.Drawing.Font("Arial", 12F);
            this.ListQuestions.FullRowSelect = true;
            this.ListQuestions.Location = new System.Drawing.Point(7, 26);
            this.ListQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.ListQuestions.MultiSelect = false;
            this.ListQuestions.Name = "ListQuestions";
            this.ListQuestions.Size = new System.Drawing.Size(756, 222);
            this.ListQuestions.TabIndex = 5;
            this.ListQuestions.UseCompatibleStateImageBehavior = false;
            this.ListQuestions.View = System.Windows.Forms.View.Details;
            this.ListQuestions.SelectedIndexChanged += new System.EventHandler(this.QuestionSelection);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Categoria";
            this.columnHeader5.Width = 112;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pregunta";
            this.columnHeader1.Width = 344;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Respuesta";
            this.columnHeader6.Width = 265;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonQuestionDelete);
            this.groupBox2.Controls.Add(this.TextQuestionsCategory);
            this.groupBox2.Controls.Add(this.ButtonQuestionNew);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ButtonQuestionSave);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ListQuestions);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TextQuestionsQuestion);
            this.groupBox2.Controls.Add(this.TextQuestionsAnswer);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(5, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 394);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preguntas";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(0, 1100);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.GRounds);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 650);
            this.panel1.TabIndex = 15;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Configuración";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            ((System.ComponentModel.ISupportInitialize)(this.PicturePlayersUserPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GRounds.ResumeLayout(false);
            this.GRounds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberRoundPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberRoundQuestions)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonRoundDelete;
        private System.Windows.Forms.Button ButtonRoundSave;
        private System.Windows.Forms.ListView ListRounds;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.NumericUpDown NumberRoundQuestions;
        private System.Windows.Forms.NumericUpDown NumberRoundPlayers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextQuestionsQuestion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView ListQuestions;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox TextContestNew;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonContestCreate;
        private System.Windows.Forms.ListView ListContest;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox TextQuestionsCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonQuestionDelete;
        private System.Windows.Forms.Button ButtonQuestionSave;
        private System.Windows.Forms.TextBox TextQuestionsAnswer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GRounds;
        private System.Windows.Forms.ListView ListPlayers;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.PictureBox PicturePlayersUserPic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextPlayerLastname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextPlayerSelectedImage;
        private System.Windows.Forms.TextBox TextPlayerFirstname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonPlayerSelectFile;
        private System.Windows.Forms.Button ButtonRoundAdd;
        private System.Windows.Forms.Button ButtonQuestionNew;
        private System.Windows.Forms.Button ButtonPlayerDelete;
        private System.Windows.Forms.Button ButtonPlayerNew;
        private System.Windows.Forms.Button ButtonPlayerSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
    }
}
