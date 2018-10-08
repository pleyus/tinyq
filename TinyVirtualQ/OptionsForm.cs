using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace TinyVirtualQ
{
    public partial class OptionsForm : Form
    {
        Contest[] RegistredContests { get; set; }   // Todos los certamenes
        Question[] QuestionBank { get; set; }       // Todas las preguntas
        Player[] RegistredPlayers { get; set; }     // Todos los vatos

        ControlPanel Main;

        public OptionsForm(ControlPanel Main)
        {
            InitializeComponent();

            this.Main = Main;

            RegistredContests = DataBase.LoadContests();
            FillContests();

            QuestionBank = DataBase.LoadQuestions();
            FillQuestions();

            RegistredPlayers = DataBase.LoadPlayers();
            FillPlayers();
        }
        void FillContests()
        {
            ListContest.Items.Clear();
            foreach (Contest C in RegistredContests)
            {
                ListViewItem IT = new ListViewItem(C.Name);
                IT.Tag = C;
                ListContest.Items.Add(IT);
            }
        }

        void FillQuestions()
        {
            ListQuestions.Items.Clear();
            foreach (Question Q in QuestionBank)
            {
                ListViewItem IT = new ListViewItem( new string[] {
                    Q.Category,
                    Q.Text,
                    Q.Answer
                } );
                IT.Tag = Q;
                ListQuestions.Items.Add( IT );
            }
        }
        void FillPlayers()
        {
            ListPlayers.Items.Clear();
            foreach (Player P in RegistredPlayers)
            {
                ListViewItem IT = new ListViewItem(new string[] {
                    P.Firstname,
                    P.Lastname,
                    P.PictureFilename
                });
                IT.Tag = P;
                ListPlayers.Items.Add(IT);
            }
        }
        
        private void ContestSelection(object sender, EventArgs e)
        {
            
        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            Main.onLoad();
        }
    }
}
