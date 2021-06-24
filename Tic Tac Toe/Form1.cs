using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void bt_2players_Click(object sender, EventArgs e)
        {
            //Abrir jogo 2p
            JogoGalo JG = new JogoGalo();
            JG.Show();
            this.Hide();
        }

        private void bt_defenicoes_Click(object sender, EventArgs e)
        {
            //Abrir ajuda
            Ajuda AJ = new Ajuda();
            AJ.Show();
            this.Hide();
        }

        private void bt_1player_Click(object sender, EventArgs e)
        {
            //Abrir 1p
            MenuBvsP MBP = new MenuBvsP();
            MBP.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Fechar jogo
            Application.Exit();
        }
    }
}
