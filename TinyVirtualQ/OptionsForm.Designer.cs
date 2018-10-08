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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListContest = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonContestCreate = new System.Windows.Forms.Button();
            this.TextContestNew = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GRounds = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberRoundPlayers = new System.Windows.Forms.NumericUpDown();
            this.ButtonRoundDelete = new System.Windows.Forms.Button();
            this.NumberRoundQuestions = new System.Windows.Forms.NumericUpDown();
            this.ButtonRoundSave = new System.Windows.Forms.Button();
            this.ListRounds = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TextQuestionsCategory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonQuestionDelete = new System.Windows.Forms.Button();
            this.ButtonQuestionSave = new System.Windows.Forms.Button();
            this.TextQuestionsAnswer = new System.Windows.Forms.TextBox();
            this.TextQuestionsQuestion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ListQuestions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.GPlayer = new System.Windows.Forms.GroupBox();
            this.ButtonPlayerSelectFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonRoundAdd = new System.Windows.Forms.Button();
            this.ButtonQuestionNew = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GRounds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberRoundPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberRoundQuestions)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.GPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePlayersUserPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 407);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.GRounds);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Concursos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListContest);
            this.groupBox2.Controls.Add(this.ButtonContestCreate);
            this.groupBox2.Controls.Add(this.TextContestNew);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 355);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Concursos registrados";
            // 
            // ListContest
            // 
            this.ListContest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7});
            this.ListContest.FullRowSelect = true;
            this.ListContest.Location = new System.Drawing.Point(17, 29);
            this.ListContest.Name = "ListContest";
            this.ListContest.Size = new System.Drawing.Size(310, 271);
            this.ListContest.TabIndex = 0;
            this.ListContest.UseCompatibleStateImageBehavior = false;
            this.ListContest.View = System.Windows.Forms.View.Details;
            this.ListContest.SelectedIndexChanged += new System.EventHandler(this.ContestSelection);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Concurso";
            this.columnHeader7.Width = 280;
            // 
            // ButtonContestCreate
            // 
            this.ButtonContestCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ButtonContestCreate.Location = new System.Drawing.Point(268, 311);
            this.ButtonContestCreate.Name = "ButtonContestCreate";
            this.ButtonContestCreate.Size = new System.Drawing.Size(59, 26);
            this.ButtonContestCreate.TabIndex = 2;
            this.ButtonContestCreate.Text = "Crear";
            this.ButtonContestCreate.UseVisualStyleBackColor = true;
            this.ButtonContestCreate.Click += new System.EventHandler(this.CreateContest);
            // 
            // TextContestNew
            // 
            this.TextContestNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextContestNew.Location = new System.Drawing.Point(64, 313);
            this.TextContestNew.Margin = new System.Windows.Forms.Padding(5);
            this.TextContestNew.Name = "TextContestNew";
            this.TextContestNew.Size = new System.Drawing.Size(196, 23);
            this.TextContestNew.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nuevo";
            // 
            // GRounds
            // 
            this.GRounds.Controls.Add(this.label2);
            this.GRounds.Controls.Add(this.label3);
            this.GRounds.Controls.Add(this.NumberRoundPlayers);
            this.GRounds.Controls.Add(this.ButtonRoundDelete);
            this.GRounds.Controls.Add(this.NumberRoundQuestions);
            this.GRounds.Controls.Add(this.ButtonRoundAdd);
            this.GRounds.Controls.Add(this.ButtonRoundSave);
            this.GRounds.Controls.Add(this.ListRounds);
            this.GRounds.Enabled = false;
            this.GRounds.Location = new System.Drawing.Point(356, 6);
            this.GRounds.Name = "GRounds";
            this.GRounds.Size = new System.Drawing.Size(403, 355);
            this.GRounds.TabIndex = 13;
            this.GRounds.TabStop = false;
            this.GRounds.Text = "Rondas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jugadores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Preg. por jugador";
            // 
            // NumberRoundPlayers
            // 
            this.NumberRoundPlayers.Location = new System.Drawing.Point(21, 315);
            this.NumberRoundPlayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumberRoundPlayers.Name = "NumberRoundPlayers";
            this.NumberRoundPlayers.Size = new System.Drawing.Size(62, 21);
            this.NumberRoundPlayers.TabIndex = 2;
            this.NumberRoundPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberRoundPlayers.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ButtonRoundDelete
            // 
            this.ButtonRoundDelete.BackgroundImage = global::TinyVirtualQ.Resource1.icon_trash;
            this.ButtonRoundDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonRoundDelete.Location = new System.Drawing.Point(358, 310);
            this.ButtonRoundDelete.Name = "ButtonRoundDelete";
            this.ButtonRoundDelete.Size = new System.Drawing.Size(26, 26);
            this.ButtonRoundDelete.TabIndex = 6;
            this.ButtonRoundDelete.UseVisualStyleBackColor = true;
            this.ButtonRoundDelete.Click += new System.EventHandler(this.RoundButtonsClick);
            // 
            // NumberRoundQuestions
            // 
            this.NumberRoundQuestions.Location = new System.Drawing.Point(101, 315);
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
            this.NumberRoundQuestions.Size = new System.Drawing.Size(62, 21);
            this.NumberRoundQuestions.TabIndex = 3;
            this.NumberRoundQuestions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberRoundQuestions.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ButtonRoundSave
            // 
            this.ButtonRoundSave.Location = new System.Drawing.Point(214, 310);
            this.ButtonRoundSave.Name = "ButtonRoundSave";
            this.ButtonRoundSave.Size = new System.Drawing.Size(66, 26);
            this.ButtonRoundSave.TabIndex = 4;
            this.ButtonRoundSave.Text = "Guardar";
            this.ButtonRoundSave.UseVisualStyleBackColor = true;
            this.ButtonRoundSave.Click += new System.EventHandler(this.RoundButtonsClick);
            // 
            // ListRounds
            // 
            this.ListRounds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListRounds.FullRowSelect = true;
            this.ListRounds.Location = new System.Drawing.Point(21, 29);
            this.ListRounds.Name = "ListRounds";
            this.ListRounds.Size = new System.Drawing.Size(363, 265);
            this.ListRounds.TabIndex = 1;
            this.ListRounds.UseCompatibleStateImageBehavior = false;
            this.ListRounds.View = System.Windows.Forms.View.Details;
            this.ListRounds.SelectedIndexChanged += new System.EventHandler(this.RoundSelection);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ronda #";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Jugadores req.";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Preg. por jugador";
            this.columnHeader4.Width = 112;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TextQuestionsCategory);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.ButtonQuestionDelete);
            this.tabPage2.Controls.Add(this.ButtonQuestionNew);
            this.tabPage2.Controls.Add(this.ButtonQuestionSave);
            this.tabPage2.Controls.Add(this.TextQuestionsAnswer);
            this.tabPage2.Controls.Add(this.TextQuestionsQuestion);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.ListQuestions);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Banco de preguntas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TextQuestionsCategory
            // 
            this.TextQuestionsCategory.Location = new System.Drawing.Point(515, 31);
            this.TextQuestionsCategory.Name = "TextQuestionsCategory";
            this.TextQuestionsCategory.Size = new System.Drawing.Size(147, 21);
            this.TextQuestionsCategory.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categoria";
            // 
            // ButtonQuestionDelete
            // 
            this.ButtonQuestionDelete.Enabled = false;
            this.ButtonQuestionDelete.Location = new System.Drawing.Point(668, 77);
            this.ButtonQuestionDelete.Name = "ButtonQuestionDelete";
            this.ButtonQuestionDelete.Size = new System.Drawing.Size(89, 26);
            this.ButtonQuestionDelete.TabIndex = 6;
            this.ButtonQuestionDelete.Text = "Eliminar";
            this.ButtonQuestionDelete.UseVisualStyleBackColor = true;
            this.ButtonQuestionDelete.Click += new System.EventHandler(this.QuestionsButtonsClick);
            // 
            // ButtonQuestionSave
            // 
            this.ButtonQuestionSave.Enabled = false;
            this.ButtonQuestionSave.Location = new System.Drawing.Point(668, 13);
            this.ButtonQuestionSave.Name = "ButtonQuestionSave";
            this.ButtonQuestionSave.Size = new System.Drawing.Size(89, 26);
            this.ButtonQuestionSave.TabIndex = 4;
            this.ButtonQuestionSave.Text = "Guardar";
            this.ButtonQuestionSave.UseVisualStyleBackColor = true;
            this.ButtonQuestionSave.Click += new System.EventHandler(this.QuestionsButtonsClick);
            // 
            // TextQuestionsAnswer
            // 
            this.TextQuestionsAnswer.Location = new System.Drawing.Point(266, 31);
            this.TextQuestionsAnswer.Multiline = true;
            this.TextQuestionsAnswer.Name = "TextQuestionsAnswer";
            this.TextQuestionsAnswer.Size = new System.Drawing.Size(243, 72);
            this.TextQuestionsAnswer.TabIndex = 2;
            // 
            // TextQuestionsQuestion
            // 
            this.TextQuestionsQuestion.Location = new System.Drawing.Point(18, 31);
            this.TextQuestionsQuestion.Multiline = true;
            this.TextQuestionsQuestion.Name = "TextQuestionsQuestion";
            this.TextQuestionsQuestion.Size = new System.Drawing.Size(242, 72);
            this.TextQuestionsQuestion.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Respuesta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pregunta";
            // 
            // ListQuestions
            // 
            this.ListQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader6});
            this.ListQuestions.FullRowSelect = true;
            this.ListQuestions.Location = new System.Drawing.Point(18, 109);
            this.ListQuestions.Name = "ListQuestions";
            this.ListQuestions.Size = new System.Drawing.Size(739, 252);
            this.ListQuestions.TabIndex = 5;
            this.ListQuestions.UseCompatibleStateImageBehavior = false;
            this.ListQuestions.View = System.Windows.Forms.View.Details;
            this.ListQuestions.SelectedIndexChanged += new System.EventHandler(this.QuestionSelection);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "Pregunta";
            this.columnHeader1.Width = 379;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 0;
            this.columnHeader5.Text = "Categoria";
            this.columnHeader5.Width = 112;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Respuesta";
            this.columnHeader6.Width = 217;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.GPlayer);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(776, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Jugadores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // GPlayer
            // 
            this.GPlayer.Controls.Add(this.ButtonPlayerSelectFile);
            this.GPlayer.Controls.Add(this.button1);
            this.GPlayer.Controls.Add(this.PicturePlayersUserPic);
            this.GPlayer.Controls.Add(this.label7);
            this.GPlayer.Controls.Add(this.label10);
            this.GPlayer.Controls.Add(this.TextPlayerLastname);
            this.GPlayer.Controls.Add(this.label9);
            this.GPlayer.Controls.Add(this.TextPlayerSelectedImage);
            this.GPlayer.Controls.Add(this.TextPlayerFirstname);
            this.GPlayer.Location = new System.Drawing.Point(479, 6);
            this.GPlayer.Name = "GPlayer";
            this.GPlayer.Size = new System.Drawing.Size(281, 353);
            this.GPlayer.TabIndex = 14;
            this.GPlayer.TabStop = false;
            this.GPlayer.Text = "Crear / Editar";
            // 
            // ButtonPlayerSelectFile
            // 
            this.ButtonPlayerSelectFile.Location = new System.Drawing.Point(242, 256);
            this.ButtonPlayerSelectFile.Name = "ButtonPlayerSelectFile";
            this.ButtonPlayerSelectFile.Size = new System.Drawing.Size(24, 24);
            this.ButtonPlayerSelectFile.TabIndex = 2;
            this.ButtonPlayerSelectFile.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PicturePlayersUserPic
            // 
            this.PicturePlayersUserPic.BackColor = System.Drawing.Color.DimGray;
            this.PicturePlayersUserPic.Location = new System.Drawing.Point(84, 42);
            this.PicturePlayersUserPic.Name = "PicturePlayersUserPic";
            this.PicturePlayersUserPic.Size = new System.Drawing.Size(120, 120);
            this.PicturePlayersUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicturePlayersUserPic.TabIndex = 13;
            this.PicturePlayersUserPic.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Imagen (1:1)";
            // 
            // TextPlayerLastname
            // 
            this.TextPlayerLastname.Location = new System.Drawing.Point(156, 207);
            this.TextPlayerLastname.Name = "TextPlayerLastname";
            this.TextPlayerLastname.Size = new System.Drawing.Size(110, 21);
            this.TextPlayerLastname.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Apellido";
            // 
            // TextPlayerSelectedImage
            // 
            this.TextPlayerSelectedImage.BackColor = System.Drawing.Color.White;
            this.TextPlayerSelectedImage.Location = new System.Drawing.Point(21, 258);
            this.TextPlayerSelectedImage.Name = "TextPlayerSelectedImage";
            this.TextPlayerSelectedImage.ReadOnly = true;
            this.TextPlayerSelectedImage.Size = new System.Drawing.Size(215, 21);
            this.TextPlayerSelectedImage.TabIndex = 4;
            // 
            // TextPlayerFirstname
            // 
            this.TextPlayerFirstname.Location = new System.Drawing.Point(21, 207);
            this.TextPlayerFirstname.Name = "TextPlayerFirstname";
            this.TextPlayerFirstname.Size = new System.Drawing.Size(118, 21);
            this.TextPlayerFirstname.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListPlayers);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 353);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jugadores registrados";
            // 
            // ListPlayers
            // 
            this.ListPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.ListPlayers.FullRowSelect = true;
            this.ListPlayers.Location = new System.Drawing.Point(17, 29);
            this.ListPlayers.Name = "ListPlayers";
            this.ListPlayers.Size = new System.Drawing.Size(430, 300);
            this.ListPlayers.TabIndex = 1;
            this.ListPlayers.UseCompatibleStateImageBehavior = false;
            this.ListPlayers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Nombre";
            this.columnHeader9.Width = 116;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Apellido";
            this.columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Imagen";
            this.columnHeader11.Width = 164;
            // 
            // ButtonRoundAdd
            // 
            this.ButtonRoundAdd.Location = new System.Drawing.Point(286, 310);
            this.ButtonRoundAdd.Name = "ButtonRoundAdd";
            this.ButtonRoundAdd.Size = new System.Drawing.Size(66, 26);
            this.ButtonRoundAdd.TabIndex = 5;
            this.ButtonRoundAdd.Text = "Nueva...";
            this.ButtonRoundAdd.UseVisualStyleBackColor = true;
            this.ButtonRoundAdd.Click += new System.EventHandler(this.RoundButtonsClick);
            // 
            // ButtonQuestionNew
            // 
            this.ButtonQuestionNew.Location = new System.Drawing.Point(668, 45);
            this.ButtonQuestionNew.Name = "ButtonQuestionNew";
            this.ButtonQuestionNew.Size = new System.Drawing.Size(89, 26);
            this.ButtonQuestionNew.TabIndex = 4;
            this.ButtonQuestionNew.Text = "Nueva";
            this.ButtonQuestionNew.UseVisualStyleBackColor = true;
            this.ButtonQuestionNew.Click += new System.EventHandler(this.QuestionsButtonsClick);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(808, 429);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Configuración";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GRounds.ResumeLayout(false);
            this.GRounds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberRoundPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberRoundQuestions)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.GPlayer.ResumeLayout(false);
            this.GPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePlayersUserPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox GRounds;
        private System.Windows.Forms.ListView ListPlayers;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.GroupBox GPlayer;
        private System.Windows.Forms.Button button1;
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
    }
}