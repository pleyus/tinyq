namespace TinyVirtualQ
{
    partial class MasterGameScreen
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
            this.PictureState = new System.Windows.Forms.PictureBox();
            this.PictureUser = new System.Windows.Forms.PictureBox();
            this.PictureProgressBar = new System.Windows.Forms.PictureBox();
            this.PictureProgressContainer = new System.Windows.Forms.PictureBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelQuestion = new System.Windows.Forms.Label();
            this.LabelQuestionsNum = new System.Windows.Forms.Label();
            this.LabelCorrectNum = new System.Windows.Forms.Label();
            this.ListQuestions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.LabelAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProgressBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProgressContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureState
            // 
            this.PictureState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureState.Image = global::TinyVirtualQ.Resource1.white_clock;
            this.PictureState.Location = new System.Drawing.Point(120, 561);
            this.PictureState.Name = "PictureState";
            this.PictureState.Size = new System.Drawing.Size(50, 50);
            this.PictureState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureState.TabIndex = 8;
            this.PictureState.TabStop = false;
            // 
            // PictureUser
            // 
            this.PictureUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureUser.BackgroundImage = global::TinyVirtualQ.Resource1.user_base_icon;
            this.PictureUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureUser.Image = global::TinyVirtualQ.Resource1.round_picture;
            this.PictureUser.Location = new System.Drawing.Point(252, 26);
            this.PictureUser.Name = "PictureUser";
            this.PictureUser.Size = new System.Drawing.Size(100, 100);
            this.PictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureUser.TabIndex = 9;
            this.PictureUser.TabStop = false;
            // 
            // PictureProgressBar
            // 
            this.PictureProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureProgressBar.BackColor = System.Drawing.Color.White;
            this.PictureProgressBar.Location = new System.Drawing.Point(183, 571);
            this.PictureProgressBar.Name = "PictureProgressBar";
            this.PictureProgressBar.Size = new System.Drawing.Size(590, 30);
            this.PictureProgressBar.TabIndex = 6;
            this.PictureProgressBar.TabStop = false;
            // 
            // PictureProgressContainer
            // 
            this.PictureProgressContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureProgressContainer.BackColor = System.Drawing.Color.DarkGray;
            this.PictureProgressContainer.Location = new System.Drawing.Point(178, 566);
            this.PictureProgressContainer.Name = "PictureProgressContainer";
            this.PictureProgressContainer.Size = new System.Drawing.Size(600, 40);
            this.PictureProgressContainer.TabIndex = 7;
            this.PictureProgressContainer.TabStop = false;
            // 
            // LabelName
            // 
            this.LabelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LabelName.ForeColor = System.Drawing.Color.White;
            this.LabelName.Location = new System.Drawing.Point(372, 26);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(346, 35);
            this.LabelName.TabIndex = 3;
            this.LabelName.Text = "Nombre";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelCategory
            // 
            this.LabelCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LabelCategory.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelCategory.Location = new System.Drawing.Point(67, 164);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(737, 35);
            this.LabelCategory.TabIndex = 4;
            this.LabelCategory.Text = "CATEGORÍA";
            this.LabelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelQuestion
            // 
            this.LabelQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.LabelQuestion.ForeColor = System.Drawing.Color.White;
            this.LabelQuestion.Location = new System.Drawing.Point(65, 199);
            this.LabelQuestion.Name = "LabelQuestion";
            this.LabelQuestion.Size = new System.Drawing.Size(758, 126);
            this.LabelQuestion.TabIndex = 5;
            this.LabelQuestion.Text = "¿Es una pregunta lo que se esta haciendo aqui? De no ser asi, que puede ser:";
            // 
            // LabelQuestionsNum
            // 
            this.LabelQuestionsNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelQuestionsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LabelQuestionsNum.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelQuestionsNum.Location = new System.Drawing.Point(372, 61);
            this.LabelQuestionsNum.Name = "LabelQuestionsNum";
            this.LabelQuestionsNum.Size = new System.Drawing.Size(289, 35);
            this.LabelQuestionsNum.TabIndex = 3;
            this.LabelQuestionsNum.Text = "Preguntas: #";
            this.LabelQuestionsNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelCorrectNum
            // 
            this.LabelCorrectNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelCorrectNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LabelCorrectNum.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelCorrectNum.Location = new System.Drawing.Point(372, 91);
            this.LabelCorrectNum.Name = "LabelCorrectNum";
            this.LabelCorrectNum.Size = new System.Drawing.Size(289, 35);
            this.LabelCorrectNum.TabIndex = 3;
            this.LabelCorrectNum.Text = "Aciertos: #";
            this.LabelCorrectNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListQuestions
            // 
            this.ListQuestions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2});
            this.ListQuestions.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListQuestions.ForeColor = System.Drawing.Color.White;
            this.ListQuestions.Location = new System.Drawing.Point(72, 404);
            this.ListQuestions.Name = "ListQuestions";
            this.ListQuestions.Size = new System.Drawing.Size(751, 151);
            this.ListQuestions.TabIndex = 10;
            this.ListQuestions.UseCompatibleStateImageBehavior = false;
            this.ListQuestions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pregunta";
            this.columnHeader1.Width = 431;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Categoria";
            this.columnHeader3.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Resultado";
            this.columnHeader2.Width = 98;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(69, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preguntas realizadas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LabelMessage
            // 
            this.LabelMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelMessage.BackColor = System.Drawing.Color.Navy;
            this.LabelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LabelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LabelMessage.Location = new System.Drawing.Point(90, 416);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(714, 125);
            this.LabelMessage.TabIndex = 5;
            this.LabelMessage.Text = "Este es un mensaje que se podrá mostrar en esta pantalla...";
            this.LabelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelAnswer
            // 
            this.LabelAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LabelAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelAnswer.Location = new System.Drawing.Point(67, 331);
            this.LabelAnswer.Name = "LabelAnswer";
            this.LabelAnswer.Size = new System.Drawing.Size(737, 52);
            this.LabelAnswer.TabIndex = 4;
            this.LabelAnswer.Text = "Respuesta";
            // 
            // MasterGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(895, 629);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.ListQuestions);
            this.Controls.Add(this.PictureState);
            this.Controls.Add(this.PictureUser);
            this.Controls.Add(this.PictureProgressBar);
            this.Controls.Add(this.PictureProgressContainer);
            this.Controls.Add(this.LabelCorrectNum);
            this.Controls.Add(this.LabelQuestionsNum);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelAnswer);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.LabelQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterGameScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MasterGameScreen";
            this.Load += new System.EventHandler(this.Init);
            ((System.ComponentModel.ISupportInitialize)(this.PictureState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProgressBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProgressContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureState;
        private System.Windows.Forms.PictureBox PictureUser;
        private System.Windows.Forms.PictureBox PictureProgressBar;
        private System.Windows.Forms.PictureBox PictureProgressContainer;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelQuestion;
        private System.Windows.Forms.Label LabelQuestionsNum;
        private System.Windows.Forms.Label LabelCorrectNum;
        private System.Windows.Forms.ListView ListQuestions;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Label LabelAnswer;
    }
}