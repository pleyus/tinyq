using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        readonly string PATH = Application.StartupPath + "\\pics\\";

        Contest[] ContestList;
        int CI = -1; // Contest Index
        int RI = -1; // Round Index

        Contest C = null;  //  Current Contest
        Round R = null;    //  Current Round
        Player P = null;   //  Current Player
        ImageList PlayerImages;

        public void OnLoad(object s, EventArgs e)
        {
            ContestList = DataBase.LoadContests();
            FillContestList();  // Cargamos la info de los concursos en el modulo
        }

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
        void ContestChanged(object sender, EventArgs e)
        {
            //  Limpiamos el dashboard
            ClearDashboard();

            //  Sacamos el indice del contest
            CI = ComboContest.SelectedIndex - 1;
            ComboRounds.Items.Clear();  //  Clear combo

            //  Si el Indice esta en el rando aceptado de contest.length
            if (CI >= 0 && CI < ContestList.Length)
            {
                //  Procedemos al llenado de rondas
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
            //  Si no esta en el rando de contest.length
            else
            {
                //  Quitamos todos los comodines
                C = null;
                R = null;
                //P = null; esto no es necesario, porque se quita al momento de terminar la ronda (dos niveles adentro)

                //  Marcamos el combo de rondas
                ComboRounds.Items.Add("(No hay rondas)");
            }

            ComboRounds.Enabled = 
                ButtonRoundStart.Enabled = 
                ButtonConfig.Enabled = false;

            ButtonRoundStart.Text = "Iniciar";

            //  Marcamos el primer elemento...
            End:
                ComboRounds.SelectedIndex = 0;
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

        void RoundChanged(object sender, EventArgs e)
        {
            //  Limpiamos el dashboard
            ClearDashboard();

            //  Sacamos el indice de las rondas
            RI = ComboRounds.SelectedIndex - 1;

            //  Si esta en el randgo de C.Rounds.Lenght
            if (RI >= 0 && RI < C.Rounds.Length)
            {
                //  Cargamos el comodin de ronda
                R = C.Rounds[RI];

                //  Cargamos los players de la ronda
                R.Players = DataBase.LoadPlayers(R.Id);

                //  Habilitamos el boton de Config
                ButtonConfig.Enabled = true;


                //  Habilitamos el boton de round start: 
                //  Si tenemos los jugadores requeridos
                //  Y si hay suficientes preguntas para la ronda

                ButtonRoundStart.Enabled =
                    R.Players.Length == R.RequiredPlayers &&
                    R.RequiredQuestions > C.AvailableQuestions();

                //  Si no se puede jugar, mostramos un mensaje detallado
                if (!ButtonRoundStart.Enabled)
                    MessageBox.Show("No se puede jugar la ronda " + ComboRounds.Text + ":" +

                        (R.Players.Length != R.RequiredPlayers ? Environment.NewLine : "") + 
                            (R.Players.Length > R.RequiredPlayers
                                ? " – Hay mas jugadores de los que se requieren" : 
                                (R.Players.Length < R.RequiredPlayers 
                                    ? " – Faltan jugadores en la ronda" 
                                    : "")) +

                       (R.RequiredQuestions > C.AvailableQuestions() ? Environment.NewLine + " – Faltan preguntas en el banco" : ""), 
                       "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            //  Si no esta en el rango...
            else
            {
                //  Quitamos el comodin de ronda
                R = null;
                ButtonRoundStart.Text = "Iniciar";
                ButtonRoundStart.Enabled = false;
                ButtonConfig.Enabled = false;
            }
        }
        void RoundStart(object sender, EventArgs e)
        {
            //  Si el boton esta en Terminar, Terminamos 
            if (ButtonRoundStart.Text == "Terminar")
            {
                //  Habilitamos de seleccion
                ComboContest.Enabled =
                    ComboRounds.Enabled =
                    ButtonConfig.Enabled =
                    true;

                //  Reseteamos el boton de inicio y el dashboard
                ButtonRoundStart.Text = "Iniciar";
                ClearDashboard();
            }

            //  Si no, empezamos la ronda
            else
            {
                //  Deshabilitamos la seleccion de ronda
                ComboContest.Enabled =
                    ComboRounds.Enabled =
                    ButtonConfig.Enabled =
                    false;
                //  Llenamos con los usuarios
                FillPlayerList();

                //  Habilitamos el dashboard (solo habilitar)
                DashBoard.Enabled = true;

                //Fin
            }
        }

        Image GetPlayerImage(Player P)
        {
            if (File.Exists(PATH + P.PictureFilename))
                return Image.FromFile(PATH + P.PictureFilename);
            else
                return Res.user_base_icon;
        }
        void FillPlayerList()
        {
            ListPlayers.Items.Clear();

            ListViewItem[] Its = new ListViewItem[R.Players.Length];
            PlayerImages = new ImageList();
            
            //  Llenamos la lista de jugadores
            for(int i = 0; i < R.Players.Length; i++)
            {
                //  Cargamos la imagen del jugador
                PlayerImages.Images.Add(GetPlayerImage(R.Players[i]) );
                Its[i] = new ListViewItem();
                Its[i].SubItems.Add(P.Firstname + " " + P.Lastname);
                Its[i].SubItems.Add(P.CountQuestions(Player.CounterParams.Normal).ToString());
                Its[i].SubItems.Add(P.CountQuestions(Player.CounterParams.NormalCorrects).ToString());
                Its[i].SubItems.Add(P.CountQuestions(Player.CounterParams.TieBreak).ToString());
                Its[i].SubItems.Add(P.CountQuestions(Player.CounterParams.TieBreakCorrect).ToString());
                ListPlayers.Items.Add(Its[i]);
            }
        }

        void ClearDashboard()
        {
            DashBoard.Enabled = false;
        }
    }
}
