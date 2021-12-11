using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static CSGO_Server_Launcher.Methods.GamemodeList;
using static CSGO_Server_Launcher.Methods.CollectionsList;
using static CSGO_Server_Launcher.Methods.Saver;

namespace CSGO_Server_Launcher
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Process process = new System.Diagnostics.Process();
            ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C srcds -game csgo -console -usercon" + Gamemode + Collection + Tickrate + Port + Config + " -net_port_try 1";
            process.StartInfo = startInfo;
            process.Start();

        }

        private void Status_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Config.txt");
        }
        private void TickrateComboBox_Click(object sender, EventArgs e)
        {
            if(TickrateComboBox.Items.Count == 0)
            {
                TickrateComboBox.Items.Add("64");
                TickrateComboBox.Items.Add("128");
            }
        }
        private void GamemodeComboBox_Click(object sender, EventArgs e)
        {
            if(GamemodeComboBox.Items.Count == 0)
            {
                foreach (var gamemode in Gamemodes)
                {
                    GamemodeComboBox.Items.Add(gamemode.Key);
                }
            }
        }
        private void CollectionsComboBox_Click(object sender, EventArgs e)
        {
            if(CollectionsComboBox.Items.Count == 0)
            {
                foreach (var collection in Collections)
                {
                    CollectionsComboBox.Items.Add(collection.Key);
                }
            }
        }
        
        private void AddToFavoriteButton_Click(object sender, EventArgs e)
        {
            CollectionsComboBox.Items.Add(CollectionNameTextBox.Text);
            Collections.Add(CollectionNameTextBox.Text, " +host_workshop_collection " + CollectionLinkTextbox.Text + " +workshop_start_map " + DefaultMapTextbox.Text);
            AddToFavorite(CollectionNameTextBox.Text, " +host_workshop_collection " + CollectionLinkTextbox.Text + " +workshop_start_map " + DefaultMapTextbox.Text);
        }

        public string Tickrate
        {
            get => " -tickrate " + TickrateComboBox.Text;
        }
        public string Gamemode
        {
            get => Gamemodes[GamemodeComboBox.Text];
        }
        public string Collection
        {
            get => Collections[CollectionsComboBox.Text];
        }
        public string Config
        {
            get => " +sv_setsteamaccount " + GLST + " -authkey " + authkey;
        }
        
        public string Port
        {
            get => " -port " + PortComboBox.Text;
        }
    }
}
