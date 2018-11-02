using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace TinyVirtualQ
{
    public partial class OptionsForm : Form
    {
        Contest[] RegistredContests { get; set; }   // Todos los certamenes
        Question[] QuestionBank { get; set; }       // Todas las preguntas
        Player[] RegistredPlayers { get; set; }     // Todos los vatos

        Main Main;
        ImageList PlayersPictures;

        public OptionsForm(Main Main)
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
                ListContest.Items.Add(IT);
            }
        }

        void FillQuestions()
        {
            ListQuestions.Items.Clear();
            TextQuestionsQuestion.Text = "";
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
                ListQuestions.Items.Add( IT );
            }
        }
        void FillPlayers()
        {
            ListPlayers.Items.Clear();
            PlayersPictures = new ImageList();
            ListViewItem[] Items = new ListViewItem[RegistredPlayers.Length];

            PlayersPictures.ImageSize = new Size(35, 35);
            ListPlayers.SmallImageList = PlayersPictures;

            for (int i = 0; i< Items.Length; i++)
            {
                Items[i] = new ListViewItem(new string[] {
                    RegistredPlayers[i].Firstname + " " + RegistredPlayers[i].Lastname
                });
                PlayersPictures.Images.Add("img_" + RegistredPlayers[i].Id, Image.FromFile(Application.StartupPath + "\\pics\\" + RegistredPlayers[i].PictureFilename));
                Items[i].ImageIndex = i;
                Items[i].ImageKey = "img_" + RegistredPlayers[i].Id;
            }
            ListPlayers.Items.AddRange(Items);

            //  Preparamos para agregar nuevo
            TextPlayerFirstname.Text = TextPlayerLastname.Text = TextPlayerSelectedImage.Text = "";
            ButtonPlayerSave.Enabled =
                ButtonPlayerDelete.Enabled = false;

            ButtonPlayerNew.Enabled = true;
            PicturePlayersUserPic.BackgroundImage = null;
        }
        void FillRounds(Contest C)
        {
            //  Limpiamos la lista
            ListRounds.Items.Clear();

            //  Recorremos todas las rondas para agregarlas a la lista
            for (int i = 0; i < C.Rounds.Length; i++)
            {
                ListViewItem IT = new ListViewItem();

                IT.Text = Round.RoundName(i, C.Rounds.Length);

                IT.SubItems.Add(C.Rounds[i].RequiredPlayers.ToString());
                IT.SubItems.Add(C.Rounds[i].QuestionsByPlayer.ToString());

                //  Agregamos el item
                ListRounds.Items.Add(IT);
            }
        }
        
        private void ContestSelection(object sender = null, EventArgs e = null)
        {
            //  Deshabilitamos y limpiamos la ronda
            ListRounds.Items.Clear();
            ButtonRoundDelete.Enabled =
                ButtonRoundSave.Enabled = false;

            //  Si se seleccionó algo
            if ( ListContest.SelectedItems.Count > 0)
            {
                //  Sacamos el objeto y lo parseamos a Contest
                Contest C = RegistredContests[ListContest.SelectedIndices[0]];

                //  Sacamos las rondas del Contest
                C.Rounds = DataBase.LoadRounds(C.Id);

                //  Llenamos la lista de Rondas
                FillRounds(C);
                
                //  Mantenemos deshabilitados los botones de save y delete...
            }
        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
//            Main.LoadData();
        }

        private void RoundSelection(object sender = null, EventArgs e = null)
        {
            if(ListRounds.SelectedItems.Count > 0)
            {
                Round R = RegistredContests[ListContest.SelectedIndices[0]]
                    .Rounds[ListRounds.SelectedIndices[0]];

                NumberRoundPlayers.Value = R.RequiredPlayers;
                NumberRoundQuestions.Value = R.QuestionsByPlayer;

                ButtonRoundDelete.Enabled = ButtonRoundSave.Enabled = true;
            }
            else
                ButtonRoundDelete.Enabled = ButtonRoundSave.Enabled = false;
        }

        private void RoundButtonsClick(object sender, EventArgs e)
        {
            int CId =RegistredContests[ListContest.SelectedIndices[0]].Id;

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
                Round R = RegistredContests[ListContest.SelectedIndices[0]]
                    .Rounds[ListRounds.SelectedIndices[0]];

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
                Question Q = QuestionBank[ListQuestions.SelectedIndices[0]];

                //  Asignamos los campos
                TextQuestionsQuestion.Text = Q.Text;

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

                        // Cargamos las preguntas con lo que se estuviera buscando
                        QuestionBank = DataBase.LoadQuestions(SearchBox.Text.Trim());
                        FillQuestions();

                        return;
                    }
                }
                MessageBox.Show("No se ha podido agregar la pregunta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //  Si no, es el boton de Save o Delete
            else if (ListQuestions.SelectedItems.Count > 0)
            {
                //  Preparamos la ronda a modificar
                Question Q = QuestionBank[ListQuestions.SelectedIndices[0]];

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

                // Cargamos las preguntas con lo que se estuviera buscando
                QuestionBank = DataBase.LoadQuestions(SearchBox.Text.Trim());
                FillQuestions();
            }
        }

        private void PlayerSelection(object sender = null, EventArgs e = null)
        {
            //  Deshabilitamos y limpiamos la pregunta
            TextPlayerFirstname.Text = TextPlayerLastname.Text = TextPlayerSelectedImage.Text = "";
            ButtonPlayerSave.Enabled =
                ButtonPlayerDelete.Enabled = false;

            ButtonPlayerNew.Enabled = true;
            PicturePlayersUserPic.BackgroundImage = null;

            //  Si se seleccionó algo
            if (ListPlayers.SelectedItems.Count > 0)
            {
                //  Sacamos el objeto y lo parseamos a Contest
                Player P = RegistredPlayers[ListPlayers.SelectedIndices[0]];

                //  Asignamos los campos
                TextPlayerFirstname.Text = P.Firstname;
                TextPlayerLastname.Text = P.Lastname;
                TextPlayerSelectedImage.Text = "";

                string filename = Application.StartupPath + "\\pics\\" + P.PictureFilename;
                if (File.Exists(filename))
                    PicturePlayersUserPic.BackgroundImage = Image.FromFile(filename);
                else
                    PicturePlayersUserPic.BackgroundImage = null;

                ButtonPlayerSave.Enabled =
                    ButtonPlayerDelete.Enabled = true;

                ButtonPlayerNew.Enabled = false;

                //  Mantenemos deshabilitados los botones de save y delete...
            }
        }

        private void PlayersButtonsClick(object sender, EventArgs e)
        {
            if (sender == ButtonPlayerSelectFile)
            {
                OpenFileDialog OF = new OpenFileDialog();
                OF.Title = "Imagen de jugador (1:1)";
                OF.Filter = "Imagenes compatibles| *.jpg; *.jpeg; *.jpe; *.png";
                OF.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                OF.Multiselect = false;

                if (OF.ShowDialog() == DialogResult.OK && File.Exists(OF.FileName))
                {
                    TextPlayerSelectedImage.Text = OF.FileName;
                    PicturePlayersUserPic.BackgroundImage = Image.FromFile(OF.FileName);
                }
            }
            else if (sender == ButtonPlayerNew)
            {
                if (TextPlayerFirstname.Text.Trim() != "")
                {
                    //  Sacamos el nuevo nombre del archivo de imagen
                    string filename = "";
                    if (File.Exists(TextPlayerSelectedImage.Text))
                        filename = CalculateMD5(TextPlayerSelectedImage.Text);

                    Player P = new Player(0, TextPlayerFirstname.Text.Trim(), TextPlayerLastname.Text.Trim(), filename);
                    if (DataBase.CreateNew(P))
                    {
                        //  Si existe el archivo, lo copiamos a la carpeta de imagenes
                        if(File.Exists(TextPlayerSelectedImage.Text))
                            File.Copy(TextPlayerSelectedImage.Text, Application.StartupPath + "\\pics\\" + filename, true);
                        MessageBox.Show("Se creó correctamente el jugador", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //  Recargamos la lista de usuarios
                    RegistredPlayers = DataBase.LoadPlayers(PlayerSearch.Text.Trim());
                    FillPlayers();
                }
                else
                {
                    MessageBox.Show("Se requiere el nombre o alias para agregar un nuevo jugador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TextPlayerFirstname.Focus();
                }
            }
            else
            {
                if (ListPlayers.SelectedItems.Count > 0)
                {
                    Player P = RegistredPlayers[ListPlayers.SelectedIndices[0]];

                    if (sender == ButtonPlayerSave)
                    {
                        if (TextPlayerFirstname.Text.Trim() != "")
                        {
                            if (File.Exists(TextPlayerSelectedImage.Text))
                            {
                                string filename = CalculateMD5(TextPlayerSelectedImage.Text);
                                File.Copy(TextPlayerSelectedImage.Text, Application.StartupPath + "\\pics\\" + filename, true);
                                P.PictureFilename = filename;
                            }
                            P.Firstname = TextPlayerFirstname.Text.Trim();
                            P.Lastname = TextPlayerLastname.Text.Trim();

                            if (DataBase.Update(P))
                                MessageBox.Show("Se actualizó correctamente el jugador", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            MessageBox.Show("Se requiere el nombre o alias para actualizar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TextPlayerFirstname.Focus();
                        }
                    }
                    else
                    {
                        if (DataBase.Delete(P))
                            MessageBox.Show("Se eliminó el jugador");
                    }

                    //  Recargamos la lista de jugadores
                    RegistredPlayers = DataBase.LoadPlayers(PlayerSearch.Text.Trim());
                    FillPlayers();
                }
            }
        }
        string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void SearchQuestion(object sender, EventArgs e)
        {
            QuestionBank = DataBase.LoadQuestions(SearchBox.Text.Trim());
            FillQuestions();
        }

        private void OnPlayerSearch(object sender, EventArgs e)
        {
            RegistredPlayers = DataBase.LoadPlayers(PlayerSearch.Text.Trim());
            FillPlayers();
        }
    }
}
