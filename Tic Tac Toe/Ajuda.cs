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
    public partial class Ajuda : Form
    {
        public Ajuda()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_texto.Text = "";
            switch(cb_opções.Text)
            { 
                case ("Sobre o jogo"):
                    lbl_texto.Text = "O jogo da velha é um jogo popular.\nÉ um jogo de regras extremamente simples, que não traz grandes dificuldades para seus jogadores e é facilmente aprendido.\nA origem é desconhecida, com indicações de que pode ter começado no antigo Egito, onde foram encontrados tabuleiros esculpidos na rocha, que teriam mais de 3.500 anos.";
                    break;

                case ("Requisitos"):
                    lbl_texto.Text = "Este jogo funciona em todos os computadores atuais";
                    break;

                case ("Creditos"):
                    lbl_texto.Text = "Jogo criado por:\nTomás 10ºQ\n2020/2021";
                    break;

            }

        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal MP = new MenuPrincipal();
            MP.Show();
            this.Close();
        }

        private void aplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
