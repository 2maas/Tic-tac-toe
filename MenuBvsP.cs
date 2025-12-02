using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoFinal
{
    public partial class MenuBvsP : Form
    {
        int n = 0;
        int PontosO = 0;
        int PontosX = 0;
        bool JogoAcabado = false;
        bool Vencedor = false;
        bool TestarCantos = true;
        bool TestarAtaque = false;
        bool TestarDefesa = false;
        public MenuBvsP()
        {
            InitializeComponent();
        }

        private void bt_CimaEsquerda_Click(object sender, EventArgs e)
        {
            if (bt_CimaEsquerda.Text == "")
            {
                if (n % 2 == 0)
                {
                    bt_CimaEsquerda.Text = "X";
                    n += 1;

                    TestarAtaque = true;
                    TestarDefesa = true;
                    
                }
            }
        }

        private void bt_CimaMeio_Click(object sender, EventArgs e)
        {
            if (bt_CimaMeio.Text == "")
            {
                if (n % 2 == 0)
                {
                    bt_CimaMeio.Text = "X";
                    n += 1;

                    TestarAtaque = true;
                    TestarDefesa = true;

                }
            }
        }

        private void bt_CimaDireita_Click(object sender, EventArgs e)
        {
            if (bt_CimaDireita.Text == "")
            {
                if (n % 2 == 0)
                {
                    bt_CimaDireita.Text = "X";
                    n += 1;

                    TestarAtaque = true;
                    TestarDefesa = true;

                }
            }
        }

        private void bt_CentroEsquerda_Click(object sender, EventArgs e)
        {
            if (bt_CentroEsquerda.Text == "")
            {
                if (n % 2 == 0)
                {
                    bt_CentroEsquerda.Text = "X";
                    n += 1;

                    TestarAtaque = true;
                    TestarDefesa = true;

                }
            }
        }

        private void bt_Meio_Click(object sender, EventArgs e)
        {
            if (bt_Meio.Text == "")
            {
                if (n % 2 == 0)
                {
                    bt_Meio.Text = "X";
                    n += 1;

                    TestarAtaque = true;
                    TestarDefesa = true;

                }
            }
        }

        private void bt_CentroDireita_Click(object sender, EventArgs e)
        {
            if (bt_CentroDireita.Text == "")
            {
                if (n % 2 == 0)
                {
                    bt_CentroDireita.Text = "X";
                    n += 1;

                    TestarAtaque = true;
                    TestarDefesa = true;

                }
            }
        }

        private void bt_BaixoEsquerda_Click(object sender, EventArgs e)
        {
            if (bt_BaixoEsquerda.Text == "")
            {
                if (n % 2 == 0)
                {
                    bt_BaixoEsquerda.Text = "X";
                    n += 1;

                    TestarAtaque = true;
                    TestarDefesa = true;

                }
            }
        }

        private void bt_BaixoMeio_Click(object sender, EventArgs e)
        {
            if (bt_BaixoMeio.Text == "")
            {
                if (n % 2 == 0)
                {
                    bt_BaixoMeio.Text = "X";
                    n += 1;

                    TestarAtaque = true;
                    TestarDefesa = true;

                }
            }
        }

        private void bt_BaixoDireita_Click(object sender, EventArgs e)
        {
            if (bt_BaixoDireita.Text == "")
            {
                if (n % 2 == 0)
                {
                    bt_BaixoDireita.Text = "X";
                    n += 1;

                    TestarAtaque = true;
                    TestarDefesa = true;

                }
            }
        }

        private void tm_Check_Tick(object sender, EventArgs e)
        {

            //Testar vitória

            //Vertical Direita
            if (bt_CimaDireita.Text != "" && bt_CentroDireita.Text != "" && bt_BaixoDireita.Text != "")
            {

                if (bt_CimaDireita.Text == bt_CentroDireita.Text && bt_CentroDireita.Text == bt_BaixoDireita.Text)
                {
                    tm_Computador.Stop();
                    tm_Check.Stop();
                    Vencedor = true;
                    bt_CimaDireita.BackColor = Color.Green;
                    bt_CimaDireita.ForeColor = Color.White;
                    bt_CentroDireita.BackColor = Color.Green;
                    bt_CentroDireita.ForeColor = Color.White;
                    bt_BaixoDireita.BackColor = Color.Green;
                    bt_BaixoDireita.ForeColor = Color.White;

                    if (bt_CimaDireita.Text == "X")
                    {
                        MessageBox.Show("Player X Ganhou!");
                        PontosX += 1;
                        JogoAcabado = true;
                    }
                    else
                    {
                        MessageBox.Show("Player O Ganhou!");
                        PontosO += 1;
                        JogoAcabado = true;
                    }
                }
            }

            //Vertical Meio
            if (bt_CimaMeio.Text != "" && bt_Meio.Text != "" && bt_BaixoMeio.Text != "")
            {
                if (bt_CimaMeio.Text == bt_Meio.Text && bt_Meio.Text == bt_BaixoMeio.Text)
                {
                    tm_Computador.Stop();
                    tm_Check.Stop();
                    Vencedor = true;
                    bt_CimaMeio.BackColor = Color.Green;
                    bt_CimaMeio.ForeColor = Color.White;
                    bt_Meio.BackColor = Color.Green;
                    bt_Meio.ForeColor = Color.White;
                    bt_BaixoMeio.BackColor = Color.Green;
                    bt_BaixoMeio.ForeColor = Color.White;

                    if (bt_CimaMeio.Text == "X")
                    {
                        MessageBox.Show("Player X Ganhou!");
                        PontosX += 1;
                        JogoAcabado = true;
                    }
                    else
                    {
                        MessageBox.Show("Player O Ganhou!");
                        PontosO += 1;
                        JogoAcabado = true;
                    }
                }
            }

            //Vertical Esquerda
            if (bt_CimaEsquerda.Text != "" && bt_CentroEsquerda.Text != "" && bt_BaixoEsquerda.Text != "")
            {
                if (bt_CimaEsquerda.Text == bt_CentroEsquerda.Text && bt_CentroEsquerda.Text == bt_BaixoEsquerda.Text)
                {
                    tm_Computador.Stop();
                    tm_Check.Stop();
                    Vencedor = true;
                    bt_CimaEsquerda.BackColor = Color.Green;
                    bt_CimaEsquerda.ForeColor = Color.White;
                    bt_CentroEsquerda.BackColor = Color.Green;
                    bt_CentroEsquerda.ForeColor = Color.White;
                    bt_BaixoEsquerda.BackColor = Color.Green;
                    bt_BaixoEsquerda.ForeColor = Color.White;

                    if (bt_CimaEsquerda.Text == "X")
                    {
                        MessageBox.Show("Player X Ganhou!");
                        PontosX += 1;
                        JogoAcabado = true;
                    }
                    else
                    {
                        MessageBox.Show("Player O Ganhou!");
                        PontosO += 1;
                        JogoAcabado = true;
                    }
                }
            }

            //Horizontal Cima
            if (bt_CimaEsquerda.Text != "" && bt_CimaMeio.Text != "" && bt_CimaDireita.Text != "")
            {
                if (bt_CimaEsquerda.Text == bt_CimaMeio.Text && bt_CimaMeio.Text == bt_CimaDireita.Text)
                {
                    tm_Computador.Stop();
                    tm_Check.Stop();
                    Vencedor = true;
                    bt_CimaEsquerda.BackColor = Color.Green;
                    bt_CimaEsquerda.ForeColor = Color.White;
                    bt_CimaMeio.BackColor = Color.Green;
                    bt_CimaMeio.ForeColor = Color.White;
                    bt_CimaDireita.BackColor = Color.Green;
                    bt_CimaDireita.ForeColor = Color.White;

                    if (bt_CimaEsquerda.Text == "X")
                    {
                        MessageBox.Show("Player X Ganhou!");
                        PontosX += 1;
                        JogoAcabado = true;
                    }
                    else
                    {
                        MessageBox.Show("Player O Ganhou!");
                        PontosO += 1;
                        JogoAcabado = true;
                    }
                }
            }

            //Horizontal Meio
            if (bt_CentroEsquerda.Text != "" && bt_Meio.Text != "" && bt_CentroDireita.Text != "")
            {
                if (bt_CentroEsquerda.Text == bt_Meio.Text && bt_Meio.Text == bt_CentroDireita.Text)
                {
                    tm_Computador.Stop();
                    tm_Check.Stop();
                    Vencedor = true;
                    bt_CentroEsquerda.BackColor = Color.Green;
                    bt_CentroEsquerda.ForeColor = Color.White;
                    bt_Meio.BackColor = Color.Green;
                    bt_Meio.ForeColor = Color.White;
                    bt_CentroDireita.BackColor = Color.Green;
                    bt_CentroDireita.ForeColor = Color.White;

                    if (bt_CentroEsquerda.Text == "X")
                    {
                        MessageBox.Show("Player X Ganhou!");
                        PontosX += 1;
                        JogoAcabado = true;
                    }
                    else
                    {
                        MessageBox.Show("Player O Ganhou!");
                        PontosO += 1;
                        JogoAcabado = true;
                    }
                }
            }

            //Horizontal Baixo
            if (bt_BaixoEsquerda.Text != "" && bt_BaixoMeio.Text != "" && bt_BaixoDireita.Text != "")
            {
                if (bt_BaixoEsquerda.Text == bt_BaixoMeio.Text && bt_BaixoMeio.Text == bt_BaixoDireita.Text)
                {
                    tm_Computador.Stop();
                    tm_Check.Stop();
                    Vencedor = true;
                    bt_BaixoEsquerda.BackColor = Color.Green;
                    bt_BaixoEsquerda.ForeColor = Color.White;
                    bt_BaixoMeio.BackColor = Color.Green;
                    bt_BaixoMeio.ForeColor = Color.White;
                    bt_BaixoDireita.BackColor = Color.Green;
                    bt_BaixoDireita.ForeColor = Color.White;

                    if (bt_BaixoEsquerda.Text == "X")
                    {
                        MessageBox.Show("Player X Ganhou!");
                        PontosX += 1;
                        JogoAcabado = true;
                    }
                    else
                    {
                        MessageBox.Show("Player O Ganhou!");
                        PontosO += 1;
                        JogoAcabado = true;
                    }
                }
            }

            //Diagonal Esquerda
            if (bt_CimaEsquerda.Text != "" && bt_Meio.Text != "" && bt_BaixoDireita.Text != "")
            {
                if (bt_CimaEsquerda.Text == bt_Meio.Text && bt_Meio.Text == bt_BaixoDireita.Text)
                {
                    tm_Computador.Stop();
                    tm_Check.Stop();
                    Vencedor = true;
                    bt_CimaEsquerda.BackColor = Color.Green;
                    bt_CimaEsquerda.ForeColor = Color.White;
                    bt_Meio.BackColor = Color.Green;
                    bt_Meio.ForeColor = Color.White;
                    bt_BaixoDireita.BackColor = Color.Green;
                    bt_BaixoDireita.ForeColor = Color.White;

                    if (bt_BaixoDireita.Text == "X")
                    {
                        MessageBox.Show("Player X Ganhou!");
                        PontosX += 1;
                        JogoAcabado = true;
                    }
                    else
                    {
                        MessageBox.Show("Player O Ganhou!");
                        PontosO += 1;
                        JogoAcabado = true;
                    }
                }
            }

            //Diagonal Direita
            if (bt_CimaDireita.Text != "" && bt_Meio.Text != "" && bt_BaixoEsquerda.Text != "")
            {
                if (bt_CimaDireita.Text == bt_Meio.Text && bt_Meio.Text == bt_BaixoEsquerda.Text)
                {
                    tm_Computador.Stop();
                    tm_Check.Stop();
                    Vencedor = true;
                    bt_CimaDireita.BackColor = Color.Green;
                    bt_CimaDireita.ForeColor = Color.White;
                    bt_Meio.BackColor = Color.Green;
                    bt_Meio.ForeColor = Color.White;
                    bt_BaixoEsquerda.BackColor = Color.Green;
                    bt_BaixoEsquerda.ForeColor = Color.White;

                    if (bt_BaixoEsquerda.Text == "X")
                    {
                        MessageBox.Show("Player X Ganhou!");
                        PontosX += 1;
                        JogoAcabado = true;
                    }
                    else
                    {
                        MessageBox.Show("Player O Ganhou!");
                        PontosO += 1;
                        JogoAcabado = true;
                    }
                }
            }

            //Empate
            if (bt_CimaDireita.Text != "" && bt_Meio.Text != "" && bt_BaixoEsquerda.Text != "" && bt_CimaEsquerda.Text != "" && bt_BaixoDireita.Text != "" && bt_BaixoMeio.Text != "" && bt_CentroEsquerda.Text != "" && bt_CentroDireita.Text != "" && bt_CimaMeio.Text != "")
            {
                if (Vencedor == false)
                {
                    tm_Computador.Stop();
                    tm_Check.Stop();
                    MessageBox.Show("Empate!");
                    JogoAcabado = true;
                }
            }
        }

        private void tm_Jogo_Tick(object sender, EventArgs e)
        {
            //Pontos dos players
            lbl_PlayerO.Text = PontosO.ToString();
            lbl_PlayerX.Text = PontosX.ToString();

            //Acabar o jogo
            if (JogoAcabado == true)
            {
                //Resetar cor
                bt_CimaDireita.BackColor = Color.White;
                bt_CimaDireita.ForeColor = Color.Black;
                bt_Meio.BackColor = Color.White;
                bt_Meio.ForeColor = Color.Black;
                bt_BaixoEsquerda.BackColor = Color.White;
                bt_BaixoEsquerda.ForeColor = Color.Black;
                bt_CimaEsquerda.BackColor = Color.White;
                bt_CimaEsquerda.ForeColor = Color.Black;
                bt_CentroDireita.BackColor = Color.White;
                bt_CentroDireita.ForeColor = Color.Black;
                bt_BaixoDireita.BackColor = Color.White;
                bt_BaixoDireita.ForeColor = Color.Black;
                bt_CentroEsquerda.BackColor = Color.White;
                bt_CentroEsquerda.ForeColor = Color.Black;
                bt_CimaMeio.BackColor = Color.White;
                bt_CimaMeio.ForeColor = Color.Black;
                bt_BaixoMeio.BackColor = Color.White;
                bt_BaixoMeio.ForeColor = Color.Black;

                //Resetar texto
                bt_CimaDireita.Text = "";
                bt_Meio.Text = "";
                bt_BaixoEsquerda.Text = "";
                bt_CimaEsquerda.Text = "";
                bt_CentroDireita.Text = "";
                bt_BaixoDireita.Text = "";
                bt_CentroEsquerda.Text = "";
                bt_CimaMeio.Text = "";
                bt_BaixoMeio.Text = "";

                //Reniciar o jogo
                JogoAcabado = false;
                tm_Computador.Start();
                tm_Check.Start();
                Vencedor = false;

            }

            //Mostrar de quem é a vez (X/O)
            if (n % 2 != 0)
            {
                lbl_vez.Text = "O";
            }

            else
            {
                lbl_vez.Text = "X";
            }

        }

        private void jogadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pontos dos players
            lbl_PlayerX.Text = PontosO.ToString();
            lbl_PlayerO.Text = PontosX.ToString();

            //Resetar texto
            bt_CimaDireita.Text = "";
            bt_Meio.Text = "";
            bt_BaixoEsquerda.Text = "";
            bt_CimaEsquerda.Text = "";
            bt_CentroDireita.Text = "";
            bt_BaixoDireita.Text = "";
            bt_CentroEsquerda.Text = "";
            bt_CimaMeio.Text = "";
            bt_BaixoMeio.Text = "";

            //Reniciar o jogo
            JogoAcabado = false;
            tm_Computador.Start();
            tm_Check.Start();
            Vencedor = false;
        }

        private void jogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sair do jogo
            Application.Exit();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir o menu principal
            MenuPrincipal MP = new MenuPrincipal();
            MP.Show();
            this.Close();
        }

        private void scoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Resetar pontos
            PontosO = 0;
            PontosX = 0;
        }

        private void tm_AI_Tick(object sender, EventArgs e)
        {
            //Computador codigo

            //Defesa
            if (TestarDefesa == true)
            {

                if (n % 2 != 0 && JogoAcabado==false)
                {

                    //Defesa vertical
                    //Vertical Esquerda
                    if (bt_BaixoEsquerda.Text == "X" && bt_CentroEsquerda.Text == "X" && bt_CimaEsquerda.Text == "" && n % 2 != 0)
                    {
                        bt_CimaEsquerda.Text = "O";
                        n += 1;
                    }

                    else if (bt_CimaEsquerda.Text == "X" && bt_BaixoEsquerda.Text == "X" && bt_CentroEsquerda.Text == "" && n % 2 != 0)
                    {
                        bt_CentroEsquerda.Text = "O";
                        n += 1;
                    }

                    else if (bt_CimaEsquerda.Text == "X" && bt_CentroEsquerda.Text == "X" && bt_BaixoEsquerda.Text == "" && n % 2 != 0)
                    {
                        bt_BaixoEsquerda.Text = "O";
                        n += 1;
                    }

                    TestarDefesa = false;

                    //Vertical Meio
                    if (bt_Meio.Text == "X" && bt_BaixoMeio.Text == "X" && bt_CimaMeio.Text == "" && n % 2 != 0)
                    {
                        bt_CimaMeio.Text = "O";
                        n += 1;
                    }

                    else if (bt_CimaMeio.Text == "X" && bt_BaixoMeio.Text == "X" && bt_Meio.Text == "" && n % 2 != 0)
                    {
                        bt_Meio.Text = "O";
                        n += 1;
                    }

                    else if (bt_CimaMeio.Text == "X" && bt_Meio.Text == "X" && bt_BaixoMeio.Text == "" && n % 2 != 0)
                    {
                        bt_BaixoMeio.Text = "O";
                        n += 1;
                    }

                    TestarDefesa = false;

                    //Vertical Direita
                    if (bt_CentroDireita.Text == "X" && bt_BaixoDireita.Text == "X" && bt_BaixoEsquerda.Text == "" && n % 2 != 0)
                    {
                        bt_CimaDireita.Text = "O";
                        n += 1;
                    }

                    else if (bt_CimaDireita.Text == "X" && bt_BaixoDireita.Text == "X" && bt_CentroDireita.Text == "" && n % 2 != 0)
                    {
                        bt_CentroDireita.Text = "O";
                        n += 1;
                    }

                    else if (bt_CimaDireita.Text == "X" && bt_CentroDireita.Text == "X" && bt_BaixoDireita.Text == "" && n % 2 != 0)
                    {
                        bt_BaixoDireita.Text = "O";
                        n += 1;
                    }

                    TestarDefesa = false;

                    //Defesa Horizontal
                    //Horizontal Cima
                    if (bt_CimaMeio.Text == "X" && bt_CimaDireita.Text == "X" && bt_CimaEsquerda.Text == "" && n % 2 != 0)
                    {
                        bt_CimaEsquerda.Text = "O";
                        n += 1;
                    }

                    else if (bt_CimaEsquerda.Text == "X" && bt_CimaDireita.Text == "X" && bt_CimaMeio.Text == "" && n % 2 != 0)
                    {
                        bt_CimaMeio.Text = "O";
                        n += 1;
                    }

                    else if (bt_CimaEsquerda.Text == "X" && bt_CimaDireita.Text == "X" && bt_CimaMeio.Text == "" && n % 2 != 0)
                    {
                        bt_CimaMeio.Text = "O";
                        n += 1;
                    }

                    TestarDefesa = false;

                    //Horizontal Centro
                    if (bt_Meio.Text == "X" && bt_CentroDireita.Text == "X" && bt_CentroEsquerda.Text == "" && n % 2 != 0)
                    {
                        bt_CentroEsquerda.Text = "O";
                        n += 1;
                    }

                    else if (bt_CentroEsquerda.Text == "X" && bt_CentroDireita.Text == "X" && bt_Meio.Text == "" && n % 2 != 0)
                    {
                        bt_Meio.Text = "O";
                        n += 1;
                    }

                    else if (bt_CentroEsquerda.Text == "X" && bt_Meio.Text == "X" && bt_CentroDireita.Text == "" && n % 2 != 0)
                    {
                        bt_CentroDireita.Text = "O";
                        n += 1;
                    }

                    TestarDefesa = false;

                    //Horizontal Baixo
                    if (bt_BaixoMeio.Text == "X" && bt_BaixoDireita.Text == "X" && bt_BaixoEsquerda.Text == "" && n % 2 != 0)
                    {
                        bt_BaixoEsquerda.Text = "O";
                        n += 1;
                    }

                    else if (bt_BaixoEsquerda.Text == "X" && bt_BaixoDireita.Text == "X" && bt_BaixoMeio.Text == "" && n % 2 != 0)
                    {
                        bt_BaixoMeio.Text = "O";
                        n += 1;
                    }

                    else if (bt_BaixoEsquerda.Text == "X" && bt_BaixoMeio.Text == "X" && bt_BaixoMeio.Text == "" && n % 2 != 0)
                    {
                        bt_BaixoMeio.Text = "O";
                        n += 1;
                    }

                    TestarDefesa = false;

                    //Defesa Diagonal
                    //Diagonal Esquerda
                    if (bt_Meio.Text == "X" && bt_BaixoDireita.Text == "X" && bt_CimaEsquerda.Text == "" && n % 2 != 0)
                    {
                        bt_CimaEsquerda.Text = "O";
                        n += 1;
                    }

                    else if (bt_CimaEsquerda.Text == "X" && bt_BaixoDireita.Text == "X" && bt_Meio.Text == "" && n % 2 != 0)
                    {
                        bt_Meio.Text = "O";
                        n += 1;
                    }

                    else if (bt_CimaEsquerda.Text == "X" && bt_Meio.Text == "X" && bt_BaixoDireita.Text == "" && n % 2 != 0)
                    {
                        bt_BaixoDireita.Text = "O";
                        n += 1;
                    }

                    TestarDefesa = false;

                    //Diagonal Direita
                    if (bt_Meio.Text == "X" && bt_BaixoEsquerda.Text == "X" && bt_CimaDireita.Text == "" && n % 2 != 0)
                    {
                        bt_CimaDireita.Text = "O";
                        n += 1;
                    }

                    else if (bt_CimaDireita.Text == "X" && bt_BaixoEsquerda.Text == "X" && bt_Meio.Text == "" && n % 2 != 0)
                    {
                        bt_Meio.Text = "O";
                        n += 1;
                    }

                    else if (bt_CimaDireita.Text == "X" && bt_Meio.Text == "X" && bt_BaixoEsquerda.Text == "" && n % 2 != 0)
                    {
                        bt_BaixoEsquerda.Text = "O";
                        n += 1;  
                    }
                    TestarAtaque = true;
                    TestarDefesa = false;
                }

            }
            else
                TestarAtaque = true;



            //Ataque
            if (TestarAtaque == true)
            {

                if (n % 2 != 0 && JogoAcabado == false)
                {

                    //Ataque vertical
                    //Vertical Esquerda
                    if (bt_BaixoEsquerda.Text == "O" && bt_CentroEsquerda.Text == "O" && bt_CimaEsquerda.Text == "" && n % 2 != 0)
                    {
                        bt_CimaEsquerda.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    else if (bt_CimaEsquerda.Text == "O" && bt_BaixoEsquerda.Text == "O" && bt_CentroEsquerda.Text == "" && n % 2 != 0)
                    {
                        bt_CentroEsquerda.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    else if (bt_CimaEsquerda.Text == "O" && bt_CentroEsquerda.Text == "O" && bt_BaixoEsquerda.Text == "" && n % 2 != 0)
                    {
                        bt_BaixoEsquerda.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    //Vertical Meio
                    if (bt_Meio.Text == "O" && bt_BaixoMeio.Text == "O" && bt_CimaMeio.Text == "" && n % 2 != 0)
                    {
                        bt_CimaMeio.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    else if (bt_CimaMeio.Text == "O" && bt_BaixoMeio.Text == "O" && bt_Meio.Text == "" && n % 2 != 0)
                    {
                        bt_Meio.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }
                    
                    else if (bt_CimaMeio.Text == "O" && bt_Meio.Text == "O" && bt_BaixoMeio.Text == "" && n % 2 != 0)
                    {
                        bt_BaixoMeio.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    //Vertical Direita
                    if (bt_CentroDireita.Text == "O" && bt_BaixoDireita.Text == "O" && bt_BaixoEsquerda.Text == "" && n % 2 != 0)
                    {
                        bt_CimaDireita.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    else if (bt_CimaDireita.Text == "O" && bt_BaixoDireita.Text == "O" && bt_CentroDireita.Text == "" && n % 2 != 0)
                    {
                        bt_CentroDireita.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    else if (bt_CimaDireita.Text == "O" && bt_CentroDireita.Text == "O" && bt_BaixoDireita.Text == "" && n % 2 != 0)
                    {
                        bt_BaixoDireita.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    //Ataque Horizontal
                    //Horizontal Cima
                    if (bt_CimaMeio.Text == "O" && bt_CimaDireita.Text == "O" && bt_CimaEsquerda.Text == "" && n % 2 != 0)
                    {
                        bt_CimaEsquerda.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    else if (bt_CimaEsquerda.Text == "O" && bt_CimaDireita.Text == "O" && bt_CimaMeio.Text == "" && n % 2 != 0)
                    {
                        bt_CimaMeio.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    else if (bt_CimaEsquerda.Text == "O" && bt_CimaDireita.Text == "O" && bt_CimaMeio.Text == "" && n % 2 != 0)
                    {
                        bt_CimaMeio.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    //Horizontal Centro
                    if (bt_Meio.Text == "O" && bt_CentroDireita.Text == "O" && bt_CentroEsquerda.Text == "" && n % 2 != 0)
                    {
                        bt_CentroEsquerda.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    else if (bt_CentroEsquerda.Text == "O" && bt_CentroDireita.Text == "O" && bt_Meio.Text == "" && n % 2 != 0)
                    {
                        bt_Meio.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    else if (bt_CentroEsquerda.Text == "O" && bt_Meio.Text == "O" && bt_CentroDireita.Text == "" && n % 2 != 0)
                    {
                        bt_CentroDireita.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    //Horizontal Baixo
                    if (bt_BaixoMeio.Text == "O" && bt_BaixoDireita.Text == "O" && bt_BaixoEsquerda.Text == "" && n % 2 != 0)
                    {
                        bt_BaixoEsquerda.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    else if (bt_BaixoEsquerda.Text == "O" && bt_BaixoDireita.Text == "O" && bt_BaixoMeio.Text == "" && n % 2 != 0)
                    {
                        bt_BaixoMeio.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    else if (bt_BaixoEsquerda.Text == "O" && bt_BaixoMeio.Text == "O" && bt_BaixoMeio.Text == "" && n % 2 != 0)
                    {
                        bt_BaixoMeio.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    //Ataque Diagonal
                    //Diagonal Esquerda
                    if (bt_Meio.Text == "O" && bt_BaixoDireita.Text == "O" && bt_CimaEsquerda.Text == "" && n % 2 != 0)
                    {
                        bt_CimaEsquerda.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    else if (bt_CimaEsquerda.Text == "O" && bt_BaixoDireita.Text == "O" && bt_Meio.Text == "" && n % 2 != 0)
                    {
                        bt_Meio.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    else if (bt_CimaEsquerda.Text == "O" && bt_Meio.Text == "O" && bt_BaixoDireita.Text == "" && n % 2 != 0)
                    {
                        bt_BaixoDireita.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    //Diagonal Direita
                    if (bt_Meio.Text == "O" && bt_BaixoEsquerda.Text == "O" && bt_CimaDireita.Text == "" && n % 2 != 0)
                    {
                        bt_CimaDireita.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    else if (bt_CimaDireita.Text == "O" && bt_BaixoEsquerda.Text == "O" && bt_Meio.Text == "" && n % 2 != 0)
                    {
                        bt_Meio.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    else if (bt_CimaDireita.Text == "O" && bt_Meio.Text == "O" && bt_BaixoEsquerda.Text == "" && n % 2 != 0)
                    {
                        bt_BaixoEsquerda.Text = "O";
                        n += 1;
                        TestarAtaque = false;
                    }

                    TestarAtaque = false;
                    TestarCantos = true;
                    
                }
            }
            else
                TestarCantos = true;



            //Caso não exista nenhuma forma de ataque/defesa
            if (TestarCantos == true)
            {

                if (n % 2 != 0 && JogoAcabado == false)
                {

                    //Testar espaços livres
                    if (bt_CimaEsquerda.Text == "")
                    {
                        bt_CimaEsquerda.Text = "O";
                        n += 1;
                        TestarCantos = false;
                    }

                    else if (bt_CimaDireita.Text == "")
                    {
                        bt_CimaDireita.Text = "O";
                        n += 1;
                        TestarCantos = false;
                    }

                    else if (bt_BaixoEsquerda.Text == "")
                    {
                        bt_BaixoEsquerda.Text = "O";
                        n += 1;
                        TestarCantos = false;
                    }

                    else if (bt_BaixoDireita.Text == "")
                    {
                        bt_BaixoDireita.Text = "O";
                        n += 1;
                        TestarCantos = false;
                    }

                    else if (bt_Meio.Text == "")
                    {
                        bt_Meio.Text = "O";
                        n += 1;
                        TestarCantos = false;
                    }

                    else if (bt_CimaMeio.Text == "")
                    {
                        bt_CimaMeio.Text = "O";
                        n += 1;
                        TestarCantos = false;
                    }

                    else if (bt_CentroDireita.Text == "")
                    {
                        bt_CentroDireita.Text = "O";
                        n += 1;
                        TestarCantos = false;
                    }

                    else if (bt_BaixoMeio.Text == "")
                    {
                        bt_BaixoMeio.Text = "O";
                        n += 1;
                        TestarCantos = false;
                    }

                    else if (bt_CentroEsquerda.Text == "")
                    {
                        bt_CentroEsquerda.Text = "O";
                        n += 1;
                        TestarCantos = false;
                    }

                    else
                        TestarDefesa = true;
                }

            }

            else
                TestarDefesa = true;
        }

    }

}
