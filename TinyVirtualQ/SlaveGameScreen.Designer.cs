namespace TinyVirtualQ
{
    partial class SlaveGameScreen
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
            this.LabelQuestion = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.PictureProgressContainer = new System.Windows.Forms.PictureBox();
            this.PictureProgressBar = new System.Windows.Forms.PictureBox();
            this.PictureUser = new System.Windows.Forms.PictureBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.PictureState = new System.Windows.Forms.PictureBox();
            this.LabelQuestionN = new System.Windows.Forms.Label();
            this.LabelRoundName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProgressContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProgressBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureState)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelQuestion
            // 
            this.LabelQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.LabelQuestion.ForeColor = System.Drawing.Color.White;
            this.LabelQuestion.Location = new System.Drawing.Point(48, 266);
            this.LabelQuestion.Name = "LabelQuestion";
            this.LabelQuestion.Size = new System.Drawing.Size(758, 185);
            this.LabelQuestion.TabIndex = 0;
            this.LabelQuestion.Text = "¿Es una pregunta lo que se esta haciendo aqui? De no ser asi, que puede ser:";
            this.LabelQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelCategory
            // 
            this.LabelCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LabelCategory.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelCategory.Location = new System.Drawing.Point(343, 202);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(151, 35);
            this.LabelCategory.TabIndex = 0;
            this.LabelCategory.Text = "CATEGORÍA";
            this.LabelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureProgressContainer
            // 
            this.PictureProgressContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureProgressContainer.BackColor = System.Drawing.Color.DarkGray;
            this.PictureProgressContainer.Location = new System.Drawing.Point(157, 474);
            this.PictureProgressContainer.Name = "PictureProgressContainer";
            this.PictureProgressContainer.Size = new System.Drawing.Size(600, 40);
            this.PictureProgressContainer.TabIndex = 1;
            this.PictureProgressContainer.TabStop = false;
            // 
            // PictureProgressBar
            // 
            this.PictureProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureProgressBar.BackColor = System.Drawing.Color.White;
            this.PictureProgressBar.Location = new System.Drawing.Point(162, 479);
            this.PictureProgressBar.Name = "PictureProgressBar";
            this.PictureProgressBar.Size = new System.Drawing.Size(590, 30);
            this.PictureProgressBar.TabIndex = 1;
            this.PictureProgressBar.TabStop = false;
            // 
            // PictureUser
            // 
            this.PictureUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureUser.BackgroundImage = global::TinyVirtualQ.Res.user_base_icon;
            this.PictureUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureUser.Image = global::TinyVirtualQ.Res.round_picture;
            this.PictureUser.Location = new System.Drawing.Point(222, 94);
            this.PictureUser.Name = "PictureUser";
            this.PictureUser.Size = new System.Drawing.Size(100, 100);
            this.PictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureUser.TabIndex = 2;
            this.PictureUser.TabStop = false;
            // 
            // LabelName
            // 
            this.LabelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LabelName.ForeColor = System.Drawing.Color.White;
            this.LabelName.Location = new System.Drawing.Point(342, 109);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(410, 35);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Nombre";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictureState
            // 
            this.PictureState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureState.Image = global::TinyVirtualQ.Res.white_clock;
            this.PictureState.Location = new System.Drawing.Point(101, 469);
            this.PictureState.Name = "PictureState";
            this.PictureState.Size = new System.Drawing.Size(50, 50);
            this.PictureState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureState.TabIndex = 2;
            this.PictureState.TabStop = false;
            // 
            // LabelQuestionN
            // 
            this.LabelQuestionN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelQuestionN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LabelQuestionN.ForeColor = System.Drawing.Color.Silver;
            this.LabelQuestionN.Location = new System.Drawing.Point(347, 144);
            this.LabelQuestionN.Name = "LabelQuestionN";
            this.LabelQuestionN.Size = new System.Drawing.Size(410, 35);
            this.LabelQuestionN.TabIndex = 0;
            this.LabelQuestionN.Text = "Nº pregunta";
            this.LabelQuestionN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelRoundName
            // 
            this.LabelRoundName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelRoundName.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.LabelRoundName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LabelRoundName.Location = new System.Drawing.Point(48, 17);
            this.LabelRoundName.Name = "LabelRoundName";
            this.LabelRoundName.Size = new System.Drawing.Size(758, 62);
            this.LabelRoundName.TabIndex = 0;
            this.LabelRoundName.Text = "Ronda #N";
            this.LabelRoundName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SlaveGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(853, 545);
            this.Controls.Add(this.PictureState);
            this.Controls.Add(this.PictureUser);
            this.Controls.Add(this.PictureProgressBar);
            this.Controls.Add(this.PictureProgressContainer);
            this.Controls.Add(this.LabelQuestionN);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.LabelRoundName);
            this.Controls.Add(this.LabelQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SlaveGameScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SlaveGameScreen";
            this.Load += new System.EventHandler(this.Init);
            ((System.ComponentModel.ISupportInitialize)(this.PictureProgressContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProgressBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelQuestion;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.PictureBox PictureProgressContainer;
        private System.Windows.Forms.PictureBox PictureProgressBar;
        private System.Windows.Forms.PictureBox PictureUser;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.PictureBox PictureState;
        private System.Windows.Forms.Label LabelQuestionN;
        private System.Windows.Forms.Label LabelRoundName;
    }
}