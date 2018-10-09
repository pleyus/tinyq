namespace TinyVirtualQ
{
    partial class SelectPlayers
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
            this.ListPlayers = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.TextSearch = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ListInRound = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabelAvailable = new System.Windows.Forms.Label();
            this.LabelInRound = new System.Windows.Forms.Label();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListPlayers
            // 
            this.ListPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.ListPlayers.FullRowSelect = true;
            this.ListPlayers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListPlayers.Location = new System.Drawing.Point(12, 30);
            this.ListPlayers.Name = "ListPlayers";
            this.ListPlayers.Size = new System.Drawing.Size(257, 318);
            this.ListPlayers.TabIndex = 2;
            this.ListPlayers.UseCompatibleStateImageBehavior = false;
            this.ListPlayers.View = System.Windows.Forms.View.Details;
            this.ListPlayers.SelectedIndexChanged += new System.EventHandler(this.PlayersSelection);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Nombre";
            this.columnHeader9.Width = 102;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Apellido";
            this.columnHeader10.Width = 126;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar";
            // 
            // TextSearch
            // 
            this.TextSearch.Location = new System.Drawing.Point(58, 357);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.Size = new System.Drawing.Size(211, 20);
            this.TextSearch.TabIndex = 1;
            this.TextSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchItem);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Enabled = false;
            this.ButtonAdd.Location = new System.Drawing.Point(275, 143);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(32, 31);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = ">";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.MovePlayers);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Enabled = false;
            this.ButtonRemove.Location = new System.Drawing.Point(275, 180);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(32, 31);
            this.ButtonRemove.TabIndex = 3;
            this.ButtonRemove.Text = "<";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.MovePlayers);
            // 
            // ListInRound
            // 
            this.ListInRound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListInRound.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ListInRound.FullRowSelect = true;
            this.ListInRound.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListInRound.Location = new System.Drawing.Point(313, 30);
            this.ListInRound.Name = "ListInRound";
            this.ListInRound.Size = new System.Drawing.Size(257, 318);
            this.ListInRound.TabIndex = 2;
            this.ListInRound.UseCompatibleStateImageBehavior = false;
            this.ListInRound.View = System.Windows.Forms.View.Details;
            this.ListInRound.SelectedIndexChanged += new System.EventHandler(this.PlayersSelection);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellido";
            this.columnHeader2.Width = 126;
            // 
            // LabelAvailable
            // 
            this.LabelAvailable.AutoSize = true;
            this.LabelAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAvailable.ForeColor = System.Drawing.Color.Teal;
            this.LabelAvailable.Location = new System.Drawing.Point(12, 9);
            this.LabelAvailable.Name = "LabelAvailable";
            this.LabelAvailable.Size = new System.Drawing.Size(117, 15);
            this.LabelAvailable.TabIndex = 3;
            this.LabelAvailable.Text = "Disponibles NNN";
            // 
            // LabelInRound
            // 
            this.LabelInRound.AutoSize = true;
            this.LabelInRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInRound.ForeColor = System.Drawing.Color.Teal;
            this.LabelInRound.Location = new System.Drawing.Point(310, 9);
            this.LabelInRound.Name = "LabelInRound";
            this.LabelInRound.Size = new System.Drawing.Size(154, 15);
            this.LabelInRound.TabIndex = 3;
            this.LabelInRound.Text = "En la RONDA (NN/MM)";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(479, 354);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(91, 25);
            this.ButtonOK.TabIndex = 3;
            this.ButtonOK.Text = "Aceptar";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.SaveRoundPlayers);
            // 
            // SelectPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 391);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextSearch);
            this.Controls.Add(this.LabelInRound);
            this.Controls.Add(this.LabelAvailable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListInRound);
            this.Controls.Add(this.ListPlayers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectPlayers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jugadores para la Ronda";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListPlayers;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextSearch;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.ListView ListInRound;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label LabelAvailable;
        private System.Windows.Forms.Label LabelInRound;
        private System.Windows.Forms.Button ButtonOK;
    }
}