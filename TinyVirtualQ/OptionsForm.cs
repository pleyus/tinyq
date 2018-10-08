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
        void FillRounds(Contest C)
        {
            //  Limpiamos la lista
            ListContest.Items.Clear();

            //  Recorremos todas las rondas para agregarlas a la lista
            for (int i = 0; i < C.Rounds.Length; i++)
            {
                ListViewItem IT = new ListViewItem();
                IT.Text = (i > 2 && i == C.Rounds.Length - 1) ? "Final" : "Ronda #" + (i + 1);
                IT.SubItems.Add(C.Rounds[i].RequiredPlayers.ToString());
                IT.SubItems.Add(C.Rounds[i].QuestionsByPlayer.ToString());
                IT.Tag = C.Rounds[i];

                //  Agregamos el item
                ListContest.Items.Add(IT);
            }
        }
        
        private void ContestSelection(object sender, EventArgs e)
        {

            //  Si se seleccionó algo
            if( ListContest.SelectedItems.Count > 0)
            {
                //  Sacamos el objeto y lo parseamos a Contest
                Contest C = (Contest)ListContest.SelectedItems[0].Tag;

                //  Sacamos las rondas del Contest
                C.Rounds = DataBase.LoadRounds(C.Id);

                //  Regresamos el Contest a la lista
                ListContest.SelectedItems[0].Tag = C;

                //  Llenamos la lista de Rondas
                FillRounds(C);

                //  Habilitamos
                GRounds.Enabled =
                    ButtonRoundDelete.Enabled =
                    ButtonRoundSave.Enabled = false;
            }
            else
            {
                //  Deshabilitamos y limpiamos la ronda
                ListContest.Items.Clear();
                GRounds.Enabled = 
                    ButtonRoundDelete.Enabled = 
                    ButtonRoundSave.Enabled = false;
            }
        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            Main.onLoad();
        }

        private void RoundSelection(object sender, EventArgs e)
        {
            if(ListRounds.SelectedItems.Count > 0)
            {
                Round R = (Round)ListRounds.SelectedItems[0].Tag;

                NumberRoundPlayers.Value = R.RequiredPlayers;
                NumberRoundQuestions.Value = R.QuestionsByPlayer;

                ButtonRoundDelete.Enabled = ButtonRoundSave.Enabled = true;
            }
            else
                ButtonRoundDelete.Enabled = ButtonRoundSave.Enabled = false;
        }

        private void RoundButtonsClick(object sender, EventArgs e)
        {
            // Si es es el boton de agregar...
            if (sender == ButtonRoundAdd)    
            {
                //  TODO: Agregar nuevo
            }
            //  Si no, es el boton de Save o Delete
            else
            {
                if(sender == ButtonRoundDelete)
                {
                    //  TODO: Eliminar (Round)ListRounds.SelectedItems[0].Tag
                }
                else
                {
                    //  TODO: Guardamos cambios (Round)ListRounds.SelectedItems[0].Tag > Id
                }
            }
        }
    }
}
