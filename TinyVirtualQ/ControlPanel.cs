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
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        ScreenController PROYECTOR;
        ScreenController MONITOR;

        Round CurrentRound;
        Round[] Rondas;
        

        private void onLoad(object sender, EventArgs e)
        {
            QuestionBank = Question.FromFile(@"question.db");
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
            // Knuth shuffle algorithm :: courtesy of Wikipedia :)
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
            string id = ListPlayers.SelectedItems[0].Text;
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
            }
        }
    }
}
