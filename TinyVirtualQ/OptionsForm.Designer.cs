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
            this.ListContest = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonContestCreate = new System.Windows.Forms.Button();
            this.TextContestNew = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OptionsFormTab = new System.Windows.Forms.TabControl();
            this.config_contest = new System.Windows.Forms.TabPage();
            this.config_questions = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonQuestionDelete = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.TextQuestionsCategory = new System.Windows.Forms.TextBox();
            this.ButtonQuestionNew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonQuestionSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ListQuestions = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.TextQuestionsQuestion = new System.Windows.Forms.TextBox();
            this.TextQuestionsAnswer = new System.Windows.Forms.TextBox();
            this.config_players = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlayerSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ButtonPlayerDelete = new System.Windows.Forms.Button();
            this.ListPlayers = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonPlayerNew = new System.Windows.Forms.Button();
            this.PicturePlayersUserPic = new System.Windows.Forms.PictureBox();
            this.ButtonPlayerSave = new System.Windows.Forms.Button();
            this.ButtonPlayerSelectFile = new System.Windows.Forms.Button();
            this.TextPlayerFirstname = new System.Windows.Forms.TextBox();
            this.TextPlayerSelectedImage = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TextPlayerLastname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumberRoundPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberRoundQuestions)).BeginInit();
            this.OptionsFormTab.SuspendLayout();
            this.config_contest.SuspendLayout();
            this.config_questions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.config_players.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePlayersUserPic)).BeginInit();
            this.SuspendLayout();
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
            this.ListContest.Location = new System.Drawing.Point(14, 67);
            this.ListContest.Margin = new System.Windows.Forms.Padding(4);
            this.ListContest.MultiSelect = false;
            this.ListContest.Name = "ListContest";
            this.ListContest.Size = new System.Drawing.Size(758, 259);
            this.ListContest.TabIndex = 0;
            this.ListContest.UseCompatibleStateImageBehavior = false;
            this.ListContest.View = System.Windows.Forms.View.Details;
            this.ListContest.SelectedIndexChanged += new System.EventHandler(this.ContestSelection);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Concurso";
            this.columnHeader7.Width = 722;
            // 
            // ButtonContestCreate
            // 
            this.ButtonContestCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonContestCreate.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonContestCreate.Location = new System.Drawing.Point(684, 23);
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
            this.TextContestNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextContestNew.Font = new System.Drawing.Font("Arial", 12F);
            this.TextContestNew.Location = new System.Drawing.Point(14, 29);
            this.TextContestNew.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TextContestNew.Name = "TextContestNew";
            this.TextContestNew.Size = new System.Drawing.Size(658, 26);
            this.TextContestNew.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8F);
            this.label8.Location = new System.Drawing.Point(11, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Agregar concurso";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(524, 345);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jugadores requeridos";
            this.toolTip1.SetToolTip(this.label2, "Jugadores requeridos para esta ronda");
            // 
            // NumberRoundPlayers
            // 
            this.NumberRoundPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberRoundPlayers.Font = new System.Drawing.Font("Arial", 12F);
            this.NumberRoundPlayers.Location = new System.Drawing.Point(527, 367);
            this.NumberRoundPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.NumberRoundPlayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumberRoundPlayers.Name = "NumberRoundPlayers";
            this.NumberRoundPlayers.Size = new System.Drawing.Size(96, 26);
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
            this.ButtonRoundDelete.Location = new System.Drawing.Point(733, 553);
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
            this.ButtonRoundAdd.Location = new System.Drawing.Point(621, 553);
            this.ButtonRoundAdd.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRoundAdd.Name = "ButtonRoundAdd";
            this.ButtonRoundAdd.Size = new System.Drawing.Size(113, 36);
            this.ButtonRoundAdd.TabIndex = 5;
            this.ButtonRoundAdd.Text = "Nueva ronda";
            this.ButtonRoundAdd.UseVisualStyleBackColor = true;
            this.ButtonRoundAdd.Click += new System.EventHandler(this.RoundButtonsClick);
            // 
            // ButtonRoundSave
            // 
            this.ButtonRoundSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRoundSave.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonRoundSave.Location = new System.Drawing.Point(527, 553);
            this.ButtonRoundSave.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRoundSave.Name = "ButtonRoundSave";
            this.ButtonRoundSave.Size = new System.Drawing.Size(96, 36);
            this.ButtonRoundSave.TabIndex = 4;
            this.ButtonRoundSave.Text = "Guardar";
            this.ButtonRoundSave.UseVisualStyleBackColor = true;
            this.ButtonRoundSave.Click += new System.EventHandler(this.RoundButtonsClick);
            // 
            // ListRounds
            // 
            this.ListRounds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListRounds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListRounds.Font = new System.Drawing.Font("Arial", 12F);
            this.ListRounds.FullRowSelect = true;
            this.ListRounds.Location = new System.Drawing.Point(14, 345);
            this.ListRounds.Margin = new System.Windows.Forms.Padding(4);
            this.ListRounds.MultiSelect = false;
            this.ListRounds.Name = "ListRounds";
            this.ListRounds.Size = new System.Drawing.Size(489, 244);
            this.ListRounds.TabIndex = 1;
            this.ListRounds.UseCompatibleStateImageBehavior = false;
            this.ListRounds.View = System.Windows.Forms.View.Details;
            this.ListRounds.SelectedIndexChanged += new System.EventHandler(this.RoundSelection);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ronda";
            this.columnHeader2.Width = 174;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Jugadores";
            this.columnHeader3.Width = 148;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Preguntas";
            this.columnHeader4.Width = 133;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(524, 421);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Preguntas por jugador";
            this.toolTip1.SetToolTip(this.label3, "Maximo de preguntas por cada jugador en la ronda");
            // 
            // NumberRoundQuestions
            // 
            this.NumberRoundQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberRoundQuestions.Font = new System.Drawing.Font("Arial", 12F);
            this.NumberRoundQuestions.Location = new System.Drawing.Point(527, 443);
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
            this.NumberRoundQuestions.Size = new System.Drawing.Size(94, 26);
            this.NumberRoundQuestions.TabIndex = 3;
            this.NumberRoundQuestions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.NumberRoundQuestions, "Preguntas por jugador");
            this.NumberRoundQuestions.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // OptionsFormTab
            // 
            this.OptionsFormTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsFormTab.Controls.Add(this.config_contest);
            this.OptionsFormTab.Controls.Add(this.config_questions);
            this.OptionsFormTab.Controls.Add(this.config_players);
            this.OptionsFormTab.ItemSize = new System.Drawing.Size(79, 35);
            this.OptionsFormTab.Location = new System.Drawing.Point(0, 0);
            this.OptionsFormTab.Name = "OptionsFormTab";
            this.OptionsFormTab.SelectedIndex = 0;
            this.OptionsFormTab.Size = new System.Drawing.Size(800, 650);
            this.OptionsFormTab.TabIndex = 16;
            // 
            // config_contest
            // 
            this.config_contest.Controls.Add(this.label2);
            this.config_contest.Controls.Add(this.ButtonContestCreate);
            this.config_contest.Controls.Add(this.ListRounds);
            this.config_contest.Controls.Add(this.NumberRoundQuestions);
            this.config_contest.Controls.Add(this.NumberRoundPlayers);
            this.config_contest.Controls.Add(this.ListContest);
            this.config_contest.Controls.Add(this.label3);
            this.config_contest.Controls.Add(this.TextContestNew);
            this.config_contest.Controls.Add(this.ButtonRoundSave);
            this.config_contest.Controls.Add(this.label8);
            this.config_contest.Controls.Add(this.ButtonRoundDelete);
            this.config_contest.Controls.Add(this.ButtonRoundAdd);
            this.config_contest.Location = new System.Drawing.Point(4, 39);
            this.config_contest.Name = "config_contest";
            this.config_contest.Padding = new System.Windows.Forms.Padding(3);
            this.config_contest.Size = new System.Drawing.Size(792, 607);
            this.config_contest.TabIndex = 0;
            this.config_contest.Text = "Concurso";
            this.config_contest.UseVisualStyleBackColor = true;
            // 
            // config_questions
            // 
            this.config_questions.Controls.Add(this.groupBox2);
            this.config_questions.Location = new System.Drawing.Point(4, 39);
            this.config_questions.Name = "config_questions";
            this.config_questions.Padding = new System.Windows.Forms.Padding(3);
            this.config_questions.Size = new System.Drawing.Size(792, 607);
            this.config_questions.TabIndex = 1;
            this.config_questions.Text = "Preguntas";
            this.config_questions.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ButtonQuestionDelete);
            this.groupBox2.Controls.Add(this.SearchBox);
            this.groupBox2.Controls.Add(this.TextQuestionsCategory);
            this.groupBox2.Controls.Add(this.ButtonQuestionNew);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ButtonQuestionSave);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ListQuestions);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TextQuestionsQuestion);
            this.groupBox2.Controls.Add(this.TextQuestionsAnswer);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 593);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preguntas";
            // 
            // ButtonQuestionDelete
            // 
            this.ButtonQuestionDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonQuestionDelete.BackgroundImage = global::TinyVirtualQ.Res.icon_trash;
            this.ButtonQuestionDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonQuestionDelete.Enabled = false;
            this.ButtonQuestionDelete.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonQuestionDelete.Location = new System.Drawing.Point(717, 545);
            this.ButtonQuestionDelete.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonQuestionDelete.Name = "ButtonQuestionDelete";
            this.ButtonQuestionDelete.Size = new System.Drawing.Size(39, 36);
            this.ButtonQuestionDelete.TabIndex = 6;
            this.ButtonQuestionDelete.UseVisualStyleBackColor = true;
            this.ButtonQuestionDelete.Click += new System.EventHandler(this.QuestionsButtonsClick);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Font = new System.Drawing.Font("Arial", 12F);
            this.SearchBox.Location = new System.Drawing.Point(465, 26);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(298, 26);
            this.SearchBox.TabIndex = 3;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchQuestion);
            // 
            // TextQuestionsCategory
            // 
            this.TextQuestionsCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextQuestionsCategory.Font = new System.Drawing.Font("Arial", 12F);
            this.TextQuestionsCategory.Location = new System.Drawing.Point(96, 551);
            this.TextQuestionsCategory.Margin = new System.Windows.Forms.Padding(4);
            this.TextQuestionsCategory.Name = "TextQuestionsCategory";
            this.TextQuestionsCategory.Size = new System.Drawing.Size(298, 26);
            this.TextQuestionsCategory.TabIndex = 3;
            // 
            // ButtonQuestionNew
            // 
            this.ButtonQuestionNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonQuestionNew.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonQuestionNew.Location = new System.Drawing.Point(609, 545);
            this.ButtonQuestionNew.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonQuestionNew.Name = "ButtonQuestionNew";
            this.ButtonQuestionNew.Size = new System.Drawing.Size(109, 36);
            this.ButtonQuestionNew.TabIndex = 4;
            this.ButtonQuestionNew.Text = "Nueva";
            this.ButtonQuestionNew.UseVisualStyleBackColor = true;
            this.ButtonQuestionNew.Click += new System.EventHandler(this.QuestionsButtonsClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(4, 457);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pregunta";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(397, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar";
            // 
            // ButtonQuestionSave
            // 
            this.ButtonQuestionSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonQuestionSave.Enabled = false;
            this.ButtonQuestionSave.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonQuestionSave.Location = new System.Drawing.Point(501, 545);
            this.ButtonQuestionSave.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonQuestionSave.Name = "ButtonQuestionSave";
            this.ButtonQuestionSave.Size = new System.Drawing.Size(109, 36);
            this.ButtonQuestionSave.TabIndex = 4;
            this.ButtonQuestionSave.Text = "Guardar";
            this.ButtonQuestionSave.UseVisualStyleBackColor = true;
            this.ButtonQuestionSave.Click += new System.EventHandler(this.QuestionsButtonsClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(5, 554);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categoria";
            // 
            // ListQuestions
            // 
            this.ListQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader6});
            this.ListQuestions.Font = new System.Drawing.Font("Arial", 12F);
            this.ListQuestions.FullRowSelect = true;
            this.ListQuestions.Location = new System.Drawing.Point(7, 64);
            this.ListQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.ListQuestions.MultiSelect = false;
            this.ListQuestions.Name = "ListQuestions";
            this.ListQuestions.Size = new System.Drawing.Size(756, 380);
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
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(397, 457);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Respuesta";
            // 
            // TextQuestionsQuestion
            // 
            this.TextQuestionsQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextQuestionsQuestion.Font = new System.Drawing.Font("Arial", 12F);
            this.TextQuestionsQuestion.Location = new System.Drawing.Point(12, 482);
            this.TextQuestionsQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.TextQuestionsQuestion.Multiline = true;
            this.TextQuestionsQuestion.Name = "TextQuestionsQuestion";
            this.TextQuestionsQuestion.Size = new System.Drawing.Size(382, 55);
            this.TextQuestionsQuestion.TabIndex = 1;
            // 
            // TextQuestionsAnswer
            // 
            this.TextQuestionsAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TextQuestionsAnswer.Font = new System.Drawing.Font("Arial", 12F);
            this.TextQuestionsAnswer.Location = new System.Drawing.Point(402, 482);
            this.TextQuestionsAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.TextQuestionsAnswer.Multiline = true;
            this.TextQuestionsAnswer.Name = "TextQuestionsAnswer";
            this.TextQuestionsAnswer.Size = new System.Drawing.Size(354, 55);
            this.TextQuestionsAnswer.TabIndex = 2;
            // 
            // config_players
            // 
            this.config_players.Controls.Add(this.groupBox1);
            this.config_players.Location = new System.Drawing.Point(4, 39);
            this.config_players.Name = "config_players";
            this.config_players.Size = new System.Drawing.Size(792, 607);
            this.config_players.TabIndex = 2;
            this.config_players.Text = "Jugadores";
            this.config_players.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.PlayerSearch);
            this.groupBox1.Controls.Add(this.label11);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(770, 594);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jugadores registrados";
            // 
            // PlayerSearch
            // 
            this.PlayerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerSearch.Font = new System.Drawing.Font("Arial", 12F);
            this.PlayerSearch.Location = new System.Drawing.Point(73, 27);
            this.PlayerSearch.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerSearch.Name = "PlayerSearch";
            this.PlayerSearch.Size = new System.Drawing.Size(337, 26);
            this.PlayerSearch.TabIndex = 17;
            this.PlayerSearch.TextChanged += new System.EventHandler(this.OnPlayerSearch);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F);
            this.label11.Location = new System.Drawing.Point(5, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Buscar";
            // 
            // ButtonPlayerDelete
            // 
            this.ButtonPlayerDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPlayerDelete.BackgroundImage = global::TinyVirtualQ.Res.icon_trash;
            this.ButtonPlayerDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonPlayerDelete.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonPlayerDelete.Location = new System.Drawing.Point(716, 327);
            this.ButtonPlayerDelete.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPlayerDelete.Name = "ButtonPlayerDelete";
            this.ButtonPlayerDelete.Size = new System.Drawing.Size(39, 36);
            this.ButtonPlayerDelete.TabIndex = 16;
            this.ButtonPlayerDelete.UseVisualStyleBackColor = true;
            this.ButtonPlayerDelete.Click += new System.EventHandler(this.PlayersButtonsClick);
            // 
            // ListPlayers
            // 
            this.ListPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9});
            this.ListPlayers.Font = new System.Drawing.Font("Arial", 12F);
            this.ListPlayers.FullRowSelect = true;
            this.ListPlayers.Location = new System.Drawing.Point(7, 61);
            this.ListPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.ListPlayers.MultiSelect = false;
            this.ListPlayers.Name = "ListPlayers";
            this.ListPlayers.Size = new System.Drawing.Size(403, 525);
            this.ListPlayers.TabIndex = 1;
            this.ListPlayers.UseCompatibleStateImageBehavior = false;
            this.ListPlayers.View = System.Windows.Forms.View.Details;
            this.ListPlayers.SelectedIndexChanged += new System.EventHandler(this.PlayerSelection);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Nombre";
            this.columnHeader9.Width = 363;
            // 
            // ButtonPlayerNew
            // 
            this.ButtonPlayerNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPlayerNew.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonPlayerNew.Location = new System.Drawing.Point(608, 327);
            this.ButtonPlayerNew.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPlayerNew.Name = "ButtonPlayerNew";
            this.ButtonPlayerNew.Size = new System.Drawing.Size(99, 36);
            this.ButtonPlayerNew.TabIndex = 15;
            this.ButtonPlayerNew.Text = "Nuevo...";
            this.ButtonPlayerNew.UseVisualStyleBackColor = true;
            this.ButtonPlayerNew.Click += new System.EventHandler(this.PlayersButtonsClick);
            // 
            // PicturePlayersUserPic
            // 
            this.PicturePlayersUserPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicturePlayersUserPic.BackColor = System.Drawing.Color.DimGray;
            this.PicturePlayersUserPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicturePlayersUserPic.Image = global::TinyVirtualQ.Res.round_picture_white;
            this.PicturePlayersUserPic.Location = new System.Drawing.Point(526, 27);
            this.PicturePlayersUserPic.Margin = new System.Windows.Forms.Padding(4);
            this.PicturePlayersUserPic.Name = "PicturePlayersUserPic";
            this.PicturePlayersUserPic.Size = new System.Drawing.Size(150, 150);
            this.PicturePlayersUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicturePlayersUserPic.TabIndex = 13;
            this.PicturePlayersUserPic.TabStop = false;
            // 
            // ButtonPlayerSave
            // 
            this.ButtonPlayerSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPlayerSave.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonPlayerSave.Location = new System.Drawing.Point(500, 327);
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
            this.ButtonPlayerSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPlayerSelectFile.Font = new System.Drawing.Font("Arial", 12F);
            this.ButtonPlayerSelectFile.Location = new System.Drawing.Point(719, 273);
            this.ButtonPlayerSelectFile.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPlayerSelectFile.Name = "ButtonPlayerSelectFile";
            this.ButtonPlayerSelectFile.Size = new System.Drawing.Size(36, 33);
            this.ButtonPlayerSelectFile.TabIndex = 2;
            this.ButtonPlayerSelectFile.UseVisualStyleBackColor = true;
            this.ButtonPlayerSelectFile.Click += new System.EventHandler(this.PlayersButtonsClick);
            // 
            // TextPlayerFirstname
            // 
            this.TextPlayerFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlayerFirstname.Font = new System.Drawing.Font("Arial", 12F);
            this.TextPlayerFirstname.Location = new System.Drawing.Point(421, 222);
            this.TextPlayerFirstname.Margin = new System.Windows.Forms.Padding(4);
            this.TextPlayerFirstname.Name = "TextPlayerFirstname";
            this.TextPlayerFirstname.Size = new System.Drawing.Size(161, 26);
            this.TextPlayerFirstname.TabIndex = 0;
            // 
            // TextPlayerSelectedImage
            // 
            this.TextPlayerSelectedImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlayerSelectedImage.BackColor = System.Drawing.Color.White;
            this.TextPlayerSelectedImage.Font = new System.Drawing.Font("Arial", 12F);
            this.TextPlayerSelectedImage.Location = new System.Drawing.Point(421, 277);
            this.TextPlayerSelectedImage.Margin = new System.Windows.Forms.Padding(4);
            this.TextPlayerSelectedImage.Name = "TextPlayerSelectedImage";
            this.TextPlayerSelectedImage.ReadOnly = true;
            this.TextPlayerSelectedImage.Size = new System.Drawing.Size(290, 26);
            this.TextPlayerSelectedImage.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8F);
            this.label10.Location = new System.Drawing.Point(418, 262);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 14);
            this.label10.TabIndex = 11;
            this.label10.Text = "Imagen (1:1)";
            // 
            // TextPlayerLastname
            // 
            this.TextPlayerLastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPlayerLastname.Font = new System.Drawing.Font("Arial", 12F);
            this.TextPlayerLastname.Location = new System.Drawing.Point(589, 222);
            this.TextPlayerLastname.Margin = new System.Windows.Forms.Padding(4);
            this.TextPlayerLastname.Name = "TextPlayerLastname";
            this.TextPlayerLastname.Size = new System.Drawing.Size(166, 26);
            this.TextPlayerLastname.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8F);
            this.label7.Location = new System.Drawing.Point(418, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8F);
            this.label9.Location = new System.Drawing.Point(586, 208);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "Apellido";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.OptionsFormTab);
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
            ((System.ComponentModel.ISupportInitialize)(this.NumberRoundPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberRoundQuestions)).EndInit();
            this.OptionsFormTab.ResumeLayout(false);
            this.config_contest.ResumeLayout(false);
            this.config_contest.PerformLayout();
            this.config_questions.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.config_players.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePlayersUserPic)).EndInit();
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
        private System.Windows.Forms.TextBox TextContestNew;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonContestCreate;
        private System.Windows.Forms.ListView ListContest;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button ButtonRoundAdd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl OptionsFormTab;
        private System.Windows.Forms.TabPage config_contest;
        private System.Windows.Forms.TabPage config_questions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonQuestionDelete;
        private System.Windows.Forms.TextBox TextQuestionsCategory;
        private System.Windows.Forms.Button ButtonQuestionNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonQuestionSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView ListQuestions;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextQuestionsQuestion;
        private System.Windows.Forms.TextBox TextQuestionsAnswer;
        private System.Windows.Forms.TabPage config_players;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonPlayerDelete;
        private System.Windows.Forms.ListView ListPlayers;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button ButtonPlayerNew;
        private System.Windows.Forms.PictureBox PicturePlayersUserPic;
        private System.Windows.Forms.Button ButtonPlayerSave;
        private System.Windows.Forms.Button ButtonPlayerSelectFile;
        private System.Windows.Forms.TextBox TextPlayerFirstname;
        private System.Windows.Forms.TextBox TextPlayerSelectedImage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextPlayerLastname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PlayerSearch;
        private System.Windows.Forms.Label label11;
    }
}
