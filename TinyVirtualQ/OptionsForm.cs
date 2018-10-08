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
            TextQuestionsQuestion.Text = "";
            TextQuestionsQuestion.Tag = null;
            TextQuestionsAnswer.Text = "";
            TextQuestionsCategory.Text = "";

            //  Deshabilitamos los botones... Esque al llenar la lista se deselecciona el elemento
            ButtonQuestionDelete.Enabled = ButtonQuestionSave.Enabled = false;
            ButtonQuestionNew.Enabled = true;

            foreach (Question Q in QuestionBank)
            {
                ListViewItem IT = new ListViewItem();
                IT.Text = Q.Category;
                IT.SubItems.Add(Q.Text);
                IT.SubItems.Add(Q.Answer);

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

        private void CreateContest(object sender, EventArgs e)
        {
            if(TextContestNew.Text.Trim() != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Una vez creado el concurso ya no se podrá quitar (solo directamente de la base de datos). ¿Continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (DataBase.CreateNew(new Contest(0, TextContestNew.Text)))
                    {
                        MessageBox.Show("Concurso creado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TextContestNew.Text = "";
                        RegistredContests = DataBase.LoadContests();
                        FillContests();
                    }
                    else
                        MessageBox.Show("No se pudo crear el concurso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void QuestionSelection(object sender = null, EventArgs e = null)
        {
            //  Deshabilitamos y limpiamos la pregunta
            TextQuestionsQuestion.Text = TextQuestionsAnswer.Text = TextQuestionsCategory.Text = "";
            ButtonQuestionDelete.Enabled =
                ButtonQuestionSave.Enabled = false;

            ButtonQuestionNew.Enabled = true;

            //  Si se seleccionó algo
            if (ListQuestions.SelectedItems.Count > 0)
            {
                //  Sacamos el objeto y lo parseamos a Contest
                Question Q = (Question)ListQuestions.SelectedItems[0].Tag;

                //  Asignamos los campos
                TextQuestionsQuestion.Text = Q.Text;
                TextQuestionsQuestion.Tag = Q;  // Le pasa

                TextQuestionsAnswer.Text = Q.Answer;
                TextQuestionsCategory.Text = Q.Category;

                ButtonQuestionDelete.Enabled =
                    ButtonQuestionSave.Enabled = true;
                ButtonQuestionNew.Enabled = false;

                //  Mantenemos deshabilitados los botones de save y delete...
            }
        }

        private void QuestionsButtonsClick(object sender, EventArgs e)
        {
            bool isOK = (
                TextQuestionsQuestion.Text.Trim() != ""
                || TextQuestionsAnswer.Text.Trim() != ""
                || TextQuestionsCategory.Text.Trim() != ""
            );

            // Si es es el boton de agregar...
            if (sender == ButtonQuestionNew)
            {
                if (isOK)
                {
                    Question Q = new Question(0, TextQuestionsQuestion.Text, TextQuestionsCategory.Text, TextQuestionsAnswer.Text, Question.QuestionResult.None, Question.QuestionType.Normal);
                    if (DataBase.CreateNew(Q))
                    {
                        MessageBox.Show("Se creó correctamente la pregunta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        QuestionBank = DataBase.LoadQuestions();
                        FillQuestions();

                        return;
                    }
                }
                MessageBox.Show("No se ha podido agregar la pregunta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //  Si no, es el boton de Save o Delete
            else if (TextQuestionsQuestion.Tag != null)
            {
                //  Preparamos la ronda a modificar
                Question Q = (Question)TextQuestionsQuestion.Tag;

                Q.Text = TextQuestionsQuestion.Text;
                Q.Answer = TextQuestionsAnswer.Text;
                Q.Category = TextQuestionsCategory.Text;

                //  Si es el boton de borrar
                if (sender == ButtonQuestionDelete)
                {
                    //  Si no se puede borrar mandamos un mensaje y fuera
                    if (!DataBase.Delete(Q))
                    {
                        MessageBox.Show("No se pudo borrar la pregunta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                //  Si no, es el de Guardar
                else
                {
                    if(!isOK)
                    {
                        MessageBox.Show("Se necesitan todos los campos de la pregunta para actualizar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (!DataBase.Update(Q))
                    {
                        MessageBox.Show("No se pudo actualizar la pregunta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                //  Si no hubo pedo, continuamos
                MessageBox.Show("Se aplicaron los cambios correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                QuestionBank = DataBase.LoadQuestions();
                FillQuestions();
            }
        }
    }
}
