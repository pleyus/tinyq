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
            ShuffleQuestions(); // Mezclamos las preguntas

            ContestList = DataBase.LoadContests();
            LoadContestInfo();  // Cargamos la info de los concursos en el modulo
            
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
            // Limpiamos y Agregamos un elemento al combo, dependiendo de si hay o no Concursos
            AdminComboContest.Items.Clear();
            AdminComboContest.Items.Add(ContestList.Length > 0 ? "(Selecciona un concurso)" : "No hay concursos");

            foreach (Contest C in ContestList)
                AdminComboContest.Items.Add(C.Name);
            AdminComboContest.SelectedIndex = 0;

            if (ContestList.Length > 0)
                AdminComboContest.Enabled = AdminButtonContestStart.Enabled = true;
            else
                AdminComboContest.Enabled = AdminButtonContestStart.Enabled = false;
        }
        void LoadRoundsInfo(object sender, EventArgs e)
        {
            //  Sacamos el Index tal cual
            int index = AdminComboContest.SelectedIndex;

            // Y si es mayor que 0...
            if (index > 0)
            {
                // Le restamos 1... Hay que saber que al llenar esta madre, le pusimos un elemento al inicio...
                index--;
                ContestList[index].Rounds = DataBase.LoadRounds(ContestList[index].Id);

                // Al igual que los concursos, agregamos un elemento al inicio de la lista
                AdminComboRounds.Items.Clear();
                AdminComboRounds.Items.Add(ContestList[index].Rounds.Length > 0 ? "(Seleccione)"  : "(No hay rondas)");

                for (int i = 0; i < ContestList[index].Rounds.Length; i++)
                {
                    string name = "Ronda #" + (i+1);
                    if (i == ContestList[index].Rounds.Length - 1 && ContestList[index].Rounds.Length > 2)
                        name = "Final";
                    AdminComboRounds.Items.Add(name);
                }
                AdminComboRounds.SelectedIndex = 0;

                if(AdminComboRounds.Items.Count > 0)
                {
                    //  Habilita los botones de la ronda y la lista de usuarios
                    AdminComboRounds.Enabled = 
                        AdminButtonRoundStart.Enabled =
                        true;

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
                        false;                    

                    //  Habilita la Lista de concursos y su boton
                    AdminComboContest.Enabled =
                        AdminButtonContestStart.Enabled =
                        true;
                }


            }

        }
    }
}
