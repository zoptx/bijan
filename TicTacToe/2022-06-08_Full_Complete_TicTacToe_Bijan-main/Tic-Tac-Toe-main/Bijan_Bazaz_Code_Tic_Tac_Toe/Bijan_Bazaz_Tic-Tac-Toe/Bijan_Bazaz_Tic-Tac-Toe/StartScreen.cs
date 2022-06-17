using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; 

namespace Bijan_Bazaz_Tic_Tac_Toe
{
    public partial class GameMenu : Form
    {
        private void playSimpleSound()
        {
           System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        }
        public GameMenu()
        {
            InitializeComponent();
            SoundPlayer.SoundLocation = "audio1";
            SoundPlayer.Play();
        }
        private void ExecuteJeux(object sender, EventArgs e)
        {
            TicTacToe ticTacToe = new TicTacToe();         
           ticTacToe.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Passez la souris sur une tuile pour voir à qui c'est le tour.\t"+"Cliquez une fois sur la tuile de votre choix pour la sélectionner.\t"+"cliquez sur menustrip, puis sur file, pour trouver d'autres contrôles tels que le redémarrage du jeu, la remise à zéro des points de jeu et la sortie du programme.");
        }

        private void GameMenu_Load(object sender, EventArgs e)
        {

        }
        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("audio1");
            simpleSound.Play();
        }

    }
}
