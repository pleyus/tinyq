using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TinyVirtualQ
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        ScreenController PROYECTOR;
        ScreenController MONITOR;

        Main M;
        OptionsForm O;
        
        public void onLoad(object sender = null, EventArgs e = null)
        {
            if(!Directory.Exists(Application.StartupPath + "\\pics\\"))
                Directory.CreateDirectory(Application.StartupPath + "\\pics\\");

            M = new Main();
            M.TopLevel = false;
            M.Dock = DockStyle.Fill;
            tabContest.Controls.Add(M);
            M.Show();
            M.BringToFront();

            O = new OptionsForm(M);
            O.TopLevel = false;
            O.Dock = DockStyle.Fill;
            tabSettings.Controls.Add(O);
            O.Show();
            O.BringToFront();


            /*MONITOR = new ScreenController(ContestList[CI].Questions);
            MONITOR.SetComponent(MasterPictureScreen, MasterComboScreens, MasterButtonUpdate);
            MONITOR.SetComponent(MasterTextMessage, MasterButtonMessage, MasterButtonClear);
            MONITOR.SetMasterSwitches(MasterButtonStatus, MasterButtonLogo, MasterButtonGame);

            PROYECTOR = new ScreenController(ContestList[CI].Questions);
            PROYECTOR.SetComponent(SlavePictureScreen, SlaveComboScreens, SlaveButtonUpdate);
            PROYECTOR.SetSlaveSwitches(SlaveButtonBlack, SlaveButtonLogo, SlaveButtonGame);*/
        }

        private void tabContest_Click(object sender, EventArgs e)
        {

        }


        /*void ShuffleQuestions()
        {
            for (int t = 0; t < QuestionBank.Length; t++)
            {
                Question tmp = QuestionBank[t];
                int r = new Random().Next(t, QuestionBank.Length);
                QuestionBank[t] = QuestionBank[r];
                QuestionBank[r] = tmp;
            }
        }*/

        /*void GameActions(object sender, EventArgs e)
        {
            if (CurrentPlayer == null)
                return;

            // Para revisar de que se este realizando una accion sobre un mismo jugador
            bool sameplayer = false;
            foreach(ListViewItem IT in ListPlayers.Items)
                if(CurrentPlayer.Id == ((Player)IT.Tag).Id)
                {
                    sameplayer = true;
                    break;
                }
            if (sameplayer)
            {
                if (sender == AdminButtonRun)
                {
                    MONITOR.Run();
                    PROYECTOR.Run();
                }
                else if (sender == AdminButtonWait)
                {
                    MONITOR.Wait();
                    PROYECTOR.Wait();
                }
                else if (sender == AdminButtonCorrect || sender == AdminButtonWrong)
                {

                    int Rid = ContestList[CC].Rounds[CR].Id;
                    int Pid = ContestList[CC].Rounds[CR].Players[CP].Id;

                    if (DataBase.SetQuestionResult(Rid, Pid, ContestList[CI].Questions[CQ].Id,
                        sender == AdminButtonCorrect
                        ? Question.QuestionResult.Correct
                        : Question.QuestionResult.Wrong))
                    {
                        if (sender == AdminButtonCorrect)
                        {
                            MONITOR.Correct();
                            PROYECTOR.Correct();
                        }
                        else
                        {
                            MONITOR.Wrong();
                            PROYECTOR.Wrong();
                        }

                        //  Volvemos a cargar las preguntas del jugador
                        CurrentPlayer.Questions = new List<Question>(DataBase.LoadUsedQuestions(CurrentPlayer.Id, Rid));

                        //  Reasignamos el player...
                        ContestList[CC].Rounds[CR].Players[CP] = CurrentPlayer;

                        //  Estado...
                        SetAdminStatus();
                        ListPlayers.Enabled = true;

                    }
                    else
                        MessageBox.Show("Joder! Algo salio mal, intenta de nuevo o debugea", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Solo se puede interactuar con el jugador actual", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void Put()
        {
        }
        */


        /*void LoadRoundsInfo(object sender, EventArgs e)
        {
           /* if(AdminButtonContestStart.Text == "Finalizar")
            {
                ActiveContest(false);
                return;
            }*/

        // Si no continuamos...
        //  Sacamos el Index tal cual
        /*int index = AdminComboContest.SelectedIndex;

        // Y si es mayor que 0...
        if (index > 0)
        {
            // Le restamos 1... Hay que saber que al llenar esta madre, le pusimos un elemento al inicio...
            index--;

            //  Sacamos las rondas
            ContestList[index].Rounds = DataBase.LoadRounds(ContestList[index].Id);
            if(ContestList[index].Rounds.Length < 1)
            {
                MessageBox.Show("No hay rondas para jugar en este concurso, ve a Opciones para agregar al menos 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  Verificamos si es jugable
            if (ContestList[index].RequiredQuestions > ContestList[CI].Questions.Length)
            {
                MessageBox.Show("No se podrá jugar ya que se requiere de " + ContestList[index].RequiredQuestions + " preguntas y solo se cuenta con " + ContestList[CI].Questions.Length + " en el banco.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Al igual que los concursos, agregamos un elemento al inicio de la lista
            AdminComboRounds.Items.Clear();
            AdminComboRounds.Items.Add(ContestList[index].Rounds.Length > 0 ? "(Seleccione)"  : "(No hay rondas)");

            for (int i = 0; i < ContestList[index].Rounds.Length; i++)
                AdminComboRounds.Items.Add( RoundName(i, ContestList[index].Rounds.Length));

            AdminComboRounds.SelectedIndex = 0;

            //  Si tiene un elemento mas que el de Seleccione.
            ActiveContest(AdminComboRounds.Items.Count > 1);
        }

    }

    void ActiveContest(bool active)
    {
        //  Habilita los botones de la ronda y la lista de usuarios
        AdminComboRounds.Enabled =
            AdminButtonRoundStart.Enabled =
            active;

        //  Deshabilita la Lista de concursos y su boton
        AdminComboContest.Enabled = !active;


        CC = active ? AdminComboContest.SelectedIndex - 1 : -1;
    }

    void StartRound(object sender = null, EventArgs e = null)
    {
        //  Si se va a terminar la ronda...
        if(AdminButtonRoundStart.Text == "Terminar")
        {
            ListPlayers.Items.Clear();
            InitRound(false);
            return;
        }

        // Si no, seguimos

        //  Sacamos el index para trabajar
        int i = AdminComboContest.SelectedIndex - 1;
        int j = AdminComboRounds.SelectedIndex;

        if (j > 0) // Porque siempre hay un elemento al comienzo
        {
            j--;
            // Index del concurso actual

            int RId = ContestList[i].Rounds[j].Id;

            //  Quitamos y cargamos los players con sus preguntas usadas en esta ronda.
            ContestList[i].Rounds[j].Players.Clear();
            ContestList[i].Rounds[j].Players.AddRange(DataBase.LoadPlayers(RId));

            //  Cargamos los players en el listview y sus datos
            ListPlayers.Items.Clear();
            for (int k = 0; k < ContestList[i].Rounds[j].Players.Count; k++)
            {

                Player P = ContestList[i].Rounds[j].Players[k];
                P.Questions.Clear();
                P.Questions.AddRange(DataBase.LoadUsedQuestions(P.Id, RId));

                Question.QuestionResult todo = Question.QuestionResult.None;
                Question.QuestionResult ok = Question.QuestionResult.Correct;

                ListViewItem IT = new ListViewItem();
                IT.Text = P.Firstname + " " + P.Lastname;
                IT.SubItems.Add(P.CountQuestions(
                    todo,
                    Question.QuestionType.Normal,
                    ContestList[i].Rounds[j].Id
                ).ToString());

                IT.SubItems.Add(P.CountQuestions(
                    ok,
                    Question.QuestionType.Normal,
                    ContestList[i].Rounds[j].Id
                ).ToString());

                IT.SubItems.Add(P.CountQuestions(
                    todo,
                    Question.QuestionType.TieBreak,
                    ContestList[i].Rounds[j].Id
                ).ToString());

                IT.SubItems.Add(P.CountQuestions(
                    ok,
                    Question.QuestionType.TieBreak,
                    ContestList[i].Rounds[j].Id
                ).ToString());

                IT.Tag = P;

                ListPlayers.Items.Add(IT);

                ContestList[i].Rounds[j].Players[k] = P;
            }

            //  Cargamos las Preguntas usadas en esta ronda.
            //ContestList[i].Rounds[j].UsedQuestions.AddRange(DataBase.LoadUsedQuestions(RId));

            int players = ContestList[i].Rounds[j].Players.Count;
            int required = ContestList[i].Rounds[j].RequiredPlayers;

            InitRound(true);
            ActiveRound(players == required);

            if (players > required)
                MessageBox.Show(this, "Algo anda mal, hay mas jugadores de los que pide la ronda", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (players < required)
                MessageBox.Show(this, "Faltan jugadores para jugar (" + players + "/" + required + ")", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    /// <summary>
    /// Se activa o desactiva solo cuando se inicia/termina una ronda (Al pulsar iniciar/terminar)
    /// </summary>
    /// <param name="status">Define el estado de la ronda</param>
    void ActiveRound(bool status)
    {
        CR = AdminComboRounds.SelectedIndex - 1;

        AdminButtonSetBreak.Enabled =
            ContestList[CI].Questions.Length > (ContestList[CC].Rounds[CR].RequiredPlayers + ContestList[CC].RequiredQuestions);

        //  Siempre que cargue la ronda debe estar apagado
        AdminButtonSetQuestion.Enabled = false;

        AdminButtonRun.Enabled =
            AdminButtonWait.Enabled =
            AdminButtonCorrect.Enabled =
            AdminButtonWrong.Enabled =
            GStatus.Enabled = 
        status;

        if(CR >= 0)
            AdminLabelRoundUsed.Text = ContestList[CC].Rounds[CR].UsedQuestions.ToString();

    }
    void InitRound(bool status)
    {
        AdminButtonPlayers.Enabled =
            ListPlayers.Enabled = status;

        AdminComboRounds.Enabled = !status;
        AdminButtonRoundStart.Text = status ? "Terminar" : "Iniciar";

        if (status)
            SetAdminStatus();
    }

    Player CurrentPlayer;
    void SetAdminStatus()
    {

        AdminLabelBankAvailable.Text = "(" + ContestList[CI].Questions.Length.ToString() + " / " + ContestList[CC].RequiredQuestions + ")";
        AdminLabelRoundUsed.Text = ContestList[CC].Rounds[CR].UsedQuestions.ToString();

        if (CurrentPlayer == null)
        {
            AdminLabelPlayerName.Text = "«Seleccione un jugador»";
            AdminLabelAnswer.Text = "R:";
            AdminLabelQuestion.Text = "«Sin pregunta asignada»";


            AdminLabelQNCorrect.Text =
                AdminLabelQNWrong.Text =
                AdminLabelQNTotal.Text =
            AdminLabelQDCorrect.Text =
                AdminLabelQDWrong.Text =
                AdminLabelQDTotal.Text = "0";
        }
        else
        {
            for (int i = 0; i < ListPlayers.Items.Count; i++)
            {
                if (((Player)ListPlayers.Items[i].Tag).Id == CurrentPlayer.Id)
                {
                    Question.QuestionResult todo = Question.QuestionResult.None;
                    Question.QuestionResult ok = Question.QuestionResult.Correct;

                    ListPlayers.Items[i].SubItems[0].Text = CurrentPlayer.Firstname + " " + CurrentPlayer.Lastname;
                    ListPlayers.Items[i].SubItems[1].Text = CurrentPlayer.CountQuestions(
                        todo, Question.QuestionType.Normal, ContestList[CC].Rounds[CR].Id ).ToString();

                    ListPlayers.Items[i].SubItems[2].Text = CurrentPlayer.CountQuestions(
                        ok, Question.QuestionType.Normal, ContestList[CC].Rounds[CR].Id
                    ).ToString();

                    ListPlayers.Items[i].SubItems[3].Text = CurrentPlayer.CountQuestions(
                        todo, Question.QuestionType.TieBreak, ContestList[CC].Rounds[CR].Id ).ToString();

                    ListPlayers.Items[i].SubItems[4].Text = CurrentPlayer.CountQuestions(
                        ok, Question.QuestionType.TieBreak, ContestList[CC].Rounds[CR].Id ).ToString();
                    // Esto hace que se cambie el numero de preguntas al momento de cargar la lista de jugadores

                    ListPlayers.Items[i].Tag = CurrentPlayer;
                }
            }

            Question q = CurrentPlayer.GetCurrentQuestion();

            AdminLabelPlayerName.Text = CurrentPlayer.Firstname + " " + CurrentPlayer.Lastname;
            AdminLabelAnswer.Text = q != null ? q.Answer : "R:";
            AdminLabelQuestion.Text = q != null ? q.Text : "«Sin pregunta asignada»";

            int ncount = CurrentPlayer.CountQuestions(Question.QuestionResult.None, Question.QuestionType.Normal);
            int ncorrect = CurrentPlayer.CountQuestions(Question.QuestionResult.Correct, Question.QuestionType.Normal);
            int tcount = CurrentPlayer.CountQuestions(Question.QuestionResult.None, Question.QuestionType.TieBreak);
            int tcorrect = CurrentPlayer.CountQuestions(Question.QuestionResult.Correct, Question.QuestionType.TieBreak);

            AdminLabelQNCorrect.Text = ncorrect.ToString();
            AdminLabelQNWrong.Text = (ncount - ncorrect).ToString();
            AdminLabelQNTotal.Text = ncount.ToString();

            AdminLabelQDCorrect.Text = tcorrect.ToString();
            AdminLabelQDWrong.Text = (tcount - tcorrect).ToString();
            AdminLabelQDTotal.Text = tcount.ToString();
        }
    }      
    void PlayerClicked(object sender, EventArgs e)
    {
        if( ListPlayers.SelectedItems.Count > 0 )
        {
            CurrentPlayer = (Player)ListPlayers.SelectedItems[0].Tag;
            Round R = ContestList[CC].Rounds[CR];
            CP = R.Players.IndexOf(CurrentPlayer);

            //  Vemos si pondemos seguir aplicandole preguntas al men...
            AdminButtonSetQuestion.Enabled = 
                CurrentPlayer.CountQuestions(Question.QuestionResult.None, Question.QuestionType.Normal, R.Id) < R.QuestionsByPlayer;


            SetAdminStatus();
        }
    }
    void OptionsInit(object sender, EventArgs e)
    {
        OptionsForm Op = new OptionsForm(this);
        Op.ShowDialog();
    }
    private void SelectPlayersClick(object sender, EventArgs e)
    {
        SelectPlayers sp = new SelectPlayers(ContestList[CC].Rounds, CR);
        sp.ShowDialog();
        AdminButtonRoundStart.Text = "Iniciar";
        StartRound();
    }

    private void SetQuestion(object sender, EventArgs e)
    {
        if (!MONITOR.IS_READY && !MONITOR.IS_READY)
        {
            CQ++;   // Incrementamos la pregunta actual

            if (CQ >= ContestList[CI].Questions.Length)
            {
                MessageBox.Show("Ya no hay preguntas");
                CQ--;
                return;
            }

            int Rid = ContestList[CC].Rounds[CR].Id;
            int Pid = ContestList[CC].Rounds[CR].Players[CP].Id;
            Question.QuestionType type = sender == AdminButtonSetQuestion
                ? Question.QuestionType.Normal
                : Question.QuestionType.TieBreak;

            if (DataBase.AddQuestionToPlayer(Rid, Pid, ContestList[CI].Questions[CQ].Id, type))
            {
                ContestList[CC].Rounds[CR].Players[CP].Questions.Clear();
                ContestList[CC].Rounds[CR].Players[CP].Questions.AddRange(DataBase.LoadUsedQuestions(Pid, Rid));

                CurrentPlayer = ContestList[CC].Rounds[CR].Players[CP];
                for (int i = 0; i < ListPlayers.Items.Count; i++)
                {
                    if (((Player)ListPlayers.Items[i].Tag).Id == CurrentPlayer.Id)
                        ListPlayers.Items[i].ForeColor = Color.DodgerBlue;
                    else
                        ListPlayers.Items[i].ForeColor = Color.Black;
                }

                MONITOR.Put(CurrentPlayer, ContestList[CC].Rounds[CR], RoundName(CR, ContestList[CC].Rounds.Length));
                PROYECTOR.Put(CurrentPlayer, ContestList[CC].Rounds[CR], RoundName(CR, ContestList[CC].Rounds.Length));

                SetAdminStatus();
                ListPlayers.Enabled = false;
            }
            else
                CQ--;
        }

        else
            MessageBox.Show("Ya se ha asignado una pregunta para un jugador, primero asigne una respuesta.", "No se puede lanzar otra pregunta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }


*/
    }
}
