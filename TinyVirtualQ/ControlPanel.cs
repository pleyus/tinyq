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

        Contest[] ContestList;
        Question[] QuestionBank;
        

        public void onLoad(object sender = null, EventArgs e = null)
        {
            QuestionBank = DataBase.LoadQuestions();
            ContestList = DataBase.LoadContests();

            LoadContestInfo();

            ShuffleQuestions();

            MONITOR = new ScreenController(QuestionBank);
            MONITOR.SetComponent(MasterPictureScreen, MasterComboScreens, MasterButtonUpdate);
            MONITOR.SetComponent(MasterTextMessage, MasterButtonMessage, MasterButtonClear);
            MONITOR.SetMasterSwitches(MasterButtonStatus, MasterButtonLogo, MasterButtonGame);

            PROYECTOR = new ScreenController(QuestionBank);
            PROYECTOR.SetComponent(SlavePictureScreen, SlaveComboScreens, SlaveButtonUpdate);
            PROYECTOR.SetSlaveSwitches(SlaveButtonBlack, SlaveButtonLogo, SlaveButtonGame);
        }
        

        void ShuffleQuestions()
        {
            for (int t = 0; t < QuestionBank.Length; t++)
            {
                Question tmp = QuestionBank[t];
                int r = new Random().Next(t, QuestionBank.Length);
                QuestionBank[t] = QuestionBank[r];
                QuestionBank[r] = tmp;
            }
        }

        void GameActions(object sender, EventArgs e)
        {
            if (sender == AdminButtonSetQuestion && ListPlayers.SelectedItems.Count > 0)
                Put();
            if( sender == AdminButtonRun )
            {
                MONITOR.Run();
                PROYECTOR.Run();
            }

        }

        void Put()
        {
           /* string id = ListPlayers.SelectedItems[0].Text;
            int index = -1;
            for (int i = 0; i < Players.Length; i++)
                if (Players[i].Id == id)
                {
                    index = 0;
                    break;
                }

            if (index >= 0)
            {
                if (Question.Current(Players[index].Questions) == null)
                {
                    
                }
                else
                    MessageBox.Show(this, "No se puede agregar otra pregunta ya que no se ha contestado la actual",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        void LoadContestInfo()
        {
            AdminComboContest.Items.Clear();
            foreach (Contest C in ContestList)
                AdminComboContest.Items.Add(C.Name);

            if (AdminComboContest.Items.Count > 0)
            {
                AdminComboContest.Text = "(Selecciona un concurso)";
                AdminComboContest.Enabled = AdminButtonContestStart.Enabled = false;
            }
            else
            {
                AdminComboContest.Text = "No hay concursos";
                AdminComboContest.Enabled = AdminButtonContestStart.Enabled = false;
            }
        }
        void LoadRoundsInfo(object sender, EventArgs e)
        {
            int index = AdminComboContest.SelectedIndex;
            if (index > -1)
            {
                ContestList[index].Rounds = DataBase.LoadRounds(ContestList[index].Id);
                AdminComboRounds.Items.Clear();

                for (int i = 0; i < ContestList[index].Rounds.Length; i++)
                {
                    string name = "Ronda #" + (i+1);
                    if (i == ContestList[index].Rounds.Length - 1)
                        name = "Final";
                    AdminComboRounds.Items.Add(name);
                }

                if(AdminComboRounds.Items.Count > 0)
                {
                    //  Habilita los botones de la ronda y la lista de usuarios
                    AdminComboRounds.Enabled = 
                        AdminButtonRoundStart.Enabled = 
                        AdminButtonPlayers.Enabled = 
                        ListPlayers.Enabled =
                        true;

                    //  Ponemos el texto de seleccionar
                    AdminComboRounds.Text = "(Seleccione)";

                    //  Deshabilita la Lista de concursos y su boton
                    AdminComboContest.Enabled =
                        AdminButtonContestStart.Enabled =
                        false;
                }
                else
                {
                    //  Deshabilita los botones de la ronda y la lista de usuarios
                    AdminComboRounds.Enabled =
                        AdminButtonRoundStart.Enabled =
                        AdminButtonPlayers.Enabled =
                        ListPlayers.Enabled =
                        false;

                    //  Ponemos el texto de sin rondas
                    AdminComboRounds.Text = "(No hay rondas)";

                    //  Habilita la Lista de concursos y su boton
                    AdminComboContest.Enabled =
                        AdminButtonContestStart.Enabled =
                        true;
                }


            }

        }
    }
}
