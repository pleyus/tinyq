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
    public partial class SelectPlayers : Form
    {
        Round[] Rounds;
        Player[] Players;

        int Index;

        public SelectPlayers(Round[] Rounds, int Index)
        {
            InitializeComponent();
            this.Rounds = Rounds;
            this.Index = Index;
        }

        void OnLoad( object s, EventArgs e)
        {
            //  Si es la primera ronda, podemos usar todos los jugadores disponibles
            if (Index == 0)
            {
                Players = DataBase.LoadPlayers(Rounds[Index].Players.ToArray());
                FillList(ListPlayers, Players);
            }
            else
            {
                //  Sacamos los jugadores de la ronda anterior
                Players = DataBase.LoadPlayers(Rounds[Index].Players.ToArray(), Rounds[Index-1].Id);
                FillList(ListPlayers, Players);
            }

            Text = "Jugadores para la " + roundName();
            FillList(ListInRound, Rounds[Index].Players.ToArray());
        }
        void FillList(ListView List, Player[] Players)
        {
            List.Items.Clear();
            foreach (Player P in Players)
            {
                ListViewItem IT = new ListViewItem();
                IT.Text = P.Firstname;
                IT.SubItems.Add(P.Lastname);
                IT.Tag = P;

                List.Items.Add(IT);
            }
            UpdateInfoLabels();
        }
        string roundName()
        {
            string ronda = "Ronda #" + (Index + 1);
            if (Index == Rounds.Length - 1 && Rounds.Length > 2)
                ronda = "Final";
            if (Index == Rounds.Length - 2 && Rounds.Length > 2)
                ronda = "Semifinal";
            return ronda;
        }

        void UpdateInfoLabels()
        {
            LabelAvailable.Text = "Disponibles " + Players.Length;
            //LabelInRound.Text = "En la " + roundName() + " (" + Rounds[Index].Players.Count + " / " + Rounds[Index].RequiredPlayers + ")";
        }
        void MovePlayers(object s, EventArgs e)
        {
            //  Cargamos los jugadores origen y destino
            List<Player> PO = new List<Player>(s == ButtonAdd ? Players : Rounds[Index].Players.ToArray());
            List<Player> PD = new List<Player>(s == ButtonAdd ? Rounds[Index].Players.ToArray() : Players);

            //  Preparamos las listas
            ListView LO = s == ButtonAdd ? ListPlayers : ListInRound;
            ListView LD = s == ButtonAdd ? ListInRound : ListPlayers;

            //  Recorremos la lista de origen
            foreach (ListViewItem IT in LO.SelectedItems)
            {
                IT.ForeColor = Color.Black;

                //  Al destino le pasamos el elemento de origen
                PD.Add((Player)IT.Tag);
                LD.Items.Add((ListViewItem)IT.Clone());

                //  Al origen le quitamos el Elemento actual
                PO.Remove((Player)IT.Tag);
                LO.Items.Remove(IT);
            }

            if(s == ButtonAdd)
            {
                ListPlayers = LO;
                Players = PO.ToArray();

                ListInRound = LD;
                //Rounds[Index].Players = PD;
            }
            else
            {
                ListPlayers = LD;
                Players = PD.ToArray();

                ListInRound = LO;
                //Rounds[Index].Players = PO;
            }
            UpdateInfoLabels();
        }

        private void PlayersSelection(object sender, EventArgs e)
        {
            if (sender == ListPlayers)
                ButtonAdd.Enabled = ListPlayers.SelectedItems.Count > 0;
            else
                ButtonRemove.Enabled = ListInRound.SelectedItems.Count > 0;
        }

        private void SearchItem(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < ListPlayers.Items.Count; i++)
            {
                ListPlayers.Items[i].Selected = false;
                ListPlayers.Items[i].Focused = false;
                ListPlayers.Items[i].ForeColor = Color.Black;
            }

            if(TextSearch.Text.Trim() != "")
                for (int i = 0; i < ListPlayers.Items.Count; i++)
                {
                    string concat = (ListPlayers.Items[i].Text + ListPlayers.Items[i].SubItems[1].Text).ToLower();
                    if (concat.Contains(TextSearch.Text.ToLower().Trim()))
                    {
                        ListPlayers.Items[i].Selected = true;
                        ListPlayers.Items[i].Focused = true;
                        ListPlayers.Items[i].ForeColor = Color.DodgerBlue;
                        break;
                    }
                }

            if (e.KeyCode == Keys.Enter)
                MovePlayers(ButtonAdd, null);
        }

        private void SaveRoundPlayers(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show(this,
                "Al modificar los jugadores de la ronda, se restaurarán todos los datos de dicha ronda. " +
                "¿Desea guardar los cambios?", "Alerta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (DialogResult.Yes == Res)
            {
                if (!DataBase.ResetRound(Rounds[Index].Id))
                {
                    MessageBox.Show(this, "No se pudo restaurar la ronda, algo anda mal...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(!DataBase.InsertPlayersInRound(Rounds[Index].Players.ToArray(), Rounds[Index].Id))
                {
                    MessageBox.Show(this, "No se han podido agregar los jugadores, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Close();
            }
            else if(Res == DialogResult.No)
                Close();
        }
    }
}
