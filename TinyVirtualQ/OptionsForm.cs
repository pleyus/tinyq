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
            ListRounds.Items.Clear();

            //  Recorremos todas las rondas para agregarlas a la lista
            for (int i = 0; i < C.Rounds.Length; i++)
            {
                ListViewItem IT = new ListViewItem();

                string ronda = "Ronda #" + (i + 1);
                if (C.Rounds.Length > 2 && i == C.Rounds.Length - 1)
                    ronda = "Final";
                if (C.Rounds.Length > 2 && i == C.Rounds.Length - 2)
                    ronda = "Semifinal";

                IT.Text = ronda;

                IT.SubItems.Add(C.Rounds[i].RequiredPlayers.ToString());
                IT.SubItems.Add(C.Rounds[i].QuestionsByPlayer.ToString());
                IT.Tag = C.Rounds[i];

                //  Agregamos el item
                ListRounds.Items.Add(IT);
            }
        }
        
        private void ContestSelection(object sender = null, EventArgs e = null)
        {
            //  Deshabilitamos y limpiamos la ronda
            ListRounds.Items.Clear();
            GRounds.Enabled =
                ButtonRoundDelete.Enabled =
                ButtonRoundSave.Enabled = false;

            //  Si se seleccionó algo
            if ( ListContest.SelectedItems.Count > 0)
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
                GRounds.Enabled = true;

                //  Mantenemos deshabilitados los botones de save y delete...
            }
        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            Main.onLoad();
        }

        private void RoundSelection(object sender = null, EventArgs e = null)
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
            int CId = ((Contest)ListContest.SelectedItems[0].Tag).Id;

            // Si es es el boton de agregar...
            if (sender == ButtonRoundAdd)    
            {
                Round R = new Round(0, (int)NumberRoundPlayers.Value, (int)NumberRoundQuestions.Value);
                if(DataBase.CreateNew(R, CId))
                {
                    MessageBox.Show("Se creó correctamente la ronda", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ContestSelection();
                }
            }
            //  Si no, es el boton de Save o Delete
            else if( ListRounds.SelectedItems.Count > 0 )
            {
                //  Preparamos la ronda a modificar
                Round R = (Round)ListRounds.SelectedItems[0].Tag;
                R.RequiredPlayers = (int)NumberRoundPlayers.Value;
                R.QuestionsByPlayer = (int)NumberRoundQuestions.Value;

                //  Si es el boton de borrar
                if (sender == ButtonRoundDelete)
                {
                    //  Si no se puede borrar mandamos un mensaje y fuera
                    if (!DataBase.Delete(R))
                    {
                        MessageBox.Show("No se pudo borrar la ronda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                //  Si no, es el de Guardar
                else
                {
                    if (!DataBase.Update(R))
                    {
                        MessageBox.Show("No se pudo actualizar la ronda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                //  Si no hubo pedo, continuamos
                MessageBox.Show("Se aplicaron los cambios correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ContestSelection();

                //  Deshabilitamos los botones... Esque al llenar la lista se deselecciona el elemento
                ButtonRoundDelete.Enabled = ButtonRoundSave.Enabled = false;
            }
        }
    }
}
