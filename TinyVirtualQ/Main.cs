using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TinyVirtualQ
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Contest[] ContestList;
        int CI = -1; // Contest Index
        int RI = -1; // Round Index

        Contest C = null;  //  Current Contest
        Round R = null;    //  Current Round
        Player P = null;   //  Current Player

        public void OnLoad(object s, EventArgs e)
        {
            ContestList = DataBase.LoadContests();
            FillContestList();  // Cargamos la info de los concursos en el modulo
        }

        /// <summary>
        /// Carga la información del concurso en su combobox
        /// </summary>
        void FillContestList()
        {
            // Limpiamos y Agregamos un elemento al combo, dependiendo de si hay o no Concursos
            ComboContest.Items.Clear();
            ComboContest.Items.Add(ContestList.Length > 0 ? "(Selecciona un concurso)" : "No hay concursos");

            foreach (Contest C in ContestList)
                ComboContest.Items.Add(C.Name);

            ComboContest.SelectedIndex = 0;

            //  Si hay contests habilitamos todo
            ComboContest.Enabled = ContestList.Length > 0;
        }

        private void ContestChanged(object sender, EventArgs e)
        {
            CI = ComboContest.SelectedIndex - 1;
            ComboRounds.Items.Clear();

            if (CI >= 0 && CI < ContestList.Length)
            {
                C = ContestList[CI];
                C.Questions = DataBase.LoadQuestions(C.Id);
                C.Rounds = DataBase.LoadRounds(C.Id);

                ComboRounds.Items.Add(C.Rounds.Length > 0 ? "(Seleccione)" : "(No hay rondas)");

                for (int i = 0; i < C.Rounds.Length; i++)
                    ComboRounds.Items.Add(Round.RoundName(i, C.Rounds.Length));

                //  Si hay suficientes preguntas para jugar
                if (C.Questions.Length > C.RequiredQuestions)
                {
                    //  Activamos y ya...
                    ComboRounds.Enabled =
                        ButtonRoundStart.Enabled =
                        true;
                    goto End;
                }

                //  Si no hay suficientes preguntas, mandamos el mensaje.
                MessageBox.Show("No se podrá jugar «" + C.Name + "» ya que requiere de " + C.RequiredQuestions + " preguntas y" +
                    (C.Questions.Length > 0 ? " solo se cuenta con " + C.Questions.Length : " no hay preguntas") +
                    " en el banco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                C = null;
                ComboRounds.Items.Add("(No hay rondas)");
            }

            ComboRounds.Enabled = false;
            ButtonRoundStart.Enabled = false;

            ButtonRoundStart.Text = "Iniciar";

            //  Marcamos el primer elemento...
            End:
                ComboRounds.SelectedIndex = 0;
        }

        private void RoundStart(object sender, EventArgs e)
        {
            //  Si el boton esta en Terminar, Terminamos 
            if (ButtonRoundStart.Text == "Terminar")
            {
                ButtonRoundStart.Text = "Iniciar";
                return;
            }

            //  Cambiamos el indice de la Ronda
            RI = ComboContest.SelectedIndex - 1;

            //  Y checamos que sea un index valido
            if (RI >= 0 && RI < C.Rounds.Length)
            {
                R = C.Rounds[RI];

                //  Cargamos los jugadores
                R.Players = DataBase.LoadPlayers(R.Id);


                DashBoard.Enabled = true;
                ButtonRoundStart.Text = "Terminar";
            }
            //  Si no, no arranca la ronda
            else
            {
                R = null;
                DashBoard.Enabled = false;
                ButtonRoundStart.Text = "Iniciar";
            }
        }
        void FillPlayerList()
        {
            ListPlayers.Items.Clear();
            foreach(Player P in R.Players)
            {
                ListViewItem IT = new ListViewItem();
                IT.Text = P.Firstname + " " + P.Lastname;
                //  Aqui te quedaste
            }
        }

        private void onDrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > ((ComboBox)sender).Items.Count || e.Index < 0)
                return;

            e.DrawBackground();
            Brush myBrush = Brushes.Black;
            Font ft = ((ComboBox)sender).Font;
            e.Graphics.DrawString(((ComboBox)sender).Items[e.Index].ToString(), ft, myBrush, e.Bounds.X, e.Bounds.Y + 5, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }
    }
}
