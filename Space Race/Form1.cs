using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Space_Race
{
    public partial class Form1 : Form
    {
        Rectangle player1 = new Rectangle(500, 480, 10, 20);
        Rectangle player2 = new Rectangle(300, 480, 10, 20);
        Rectangle WALL = new Rectangle(400, 400, 10, 350);
       
        List<Rectangle> bullet = new List<Rectangle>();
        int bulletSize = 3;
        int bulletSpeed = 6;

        int playerspeed = 8;
        int player1score = 0;
        int player2score = 0;

        int ballSpeed = 8;
        string gamestate = "waiting";
        
        
        bool wDown = false;
        bool sDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;

        bool start;
        bool exit;

        SolidBrush whiteBrush = new SolidBrush(Color.White);


        int player1Score = 0;
        int player2Score = 0;

        Random randGen = new Random();
        int randValue = 0;



        public Form1()
        {
            InitializeComponent();
            

        }
        public void GameInitalize()
        {
           GameTimer.Enabled = true;
            winOutput.Text = "";
            Start.Text = "";
            bullet.Clear();
            player1Score = 0;
            player2Score = 0;
            
            player1.Y = 480;
            player2.Y = 480; 


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            if (GameTimer.Enabled == true)
            {


                e.Graphics.FillRectangle(whiteBrush, player1);
                e.Graphics.FillRectangle(whiteBrush, player2);
                e.Graphics.FillRectangle(whiteBrush, WALL);

                for (int i = 0; i < bullet.Count(); i++)
                {
                    e.Graphics.FillRectangle(whiteBrush, bullet[i]);
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                

                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;

                case Keys.Space:
                    start = false;
                    break;
                case Keys.Escape:
                    exit = false;
                    break ; 



            }
        }




        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;



                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;

                case Keys.Space:
                    if(gamestate == "waiting")
                    {
                        GameInitalize();
                    } 
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Player1ScoreOutput.Text = "0";
            Player2ScoreOutput.Text = "0";


            //move player1
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= playerspeed;
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += playerspeed;
            }


            //move player 2
            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= playerspeed;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += playerspeed;
            }



            //is it time to make a new bullet?
            randValue = randGen.Next(1, 10);

            if (randValue < 5)
            {
                int y = randGen.Next(0, 400 - bulletSize * 2);
                Rectangle newBullet = new Rectangle(0, y, bulletSize, bulletSize);
                bullet.Add(newBullet);

            }

            //MMMMMMMOOOOOOOOOOOOOVVVVVVVVVEEEEEEEEEEEEEEEE
            for (int i = 0; i < bullet.Count(); i++)
            {
                //find the new position of y based on speed
                int x = bullet[i].X + bulletSpeed;

                ///replace the rectangle with updated one
                bullet[i] = new Rectangle(x, bullet[i].Y, bulletSize, bulletSize);



            }

            // if any player interacts with asteroid they get sent back
         for (int i = 0; i < bullet.Count(); i++)
            {
                if (bullet[i].IntersectsWith(player1))
                {
                    bullet.Remove(bullet[i]);
                    player1.Y = 480;
                    
                    SoundPlayer goofin = new SoundPlayer(Properties.Resources.New_Recording_22);

                    goofin.Play();
                }

                if (bullet[i].IntersectsWith(player2))
                {
                    bullet.Remove(bullet[i]);
                    player2.Y = 480;
                    SoundPlayer goofin = new SoundPlayer(Properties.Resources.New_Recording_22);

                    goofin.Play();
                }

            }

         for (int i = 0;i < bullet.Count(); i++)
            {
                if (player1.Y == 0)
                {
                    player1Score++;
                    player1.Y = 480;
                    SoundPlayer SCORE = new SoundPlayer(Properties.Resources.New_Recording_21);

                    SCORE.Play();
                }
                if (player2.Y == 0)
                {
                    player2Score++;
                    player2.Y = 480;
                    SoundPlayer SCORE = new SoundPlayer(Properties.Resources.New_Recording_21);

                    SCORE.Play();
                }

                if (player1Score == 3)
                {
                    Player2ScoreOutput.Text = "";
                    Player1ScoreOutput.Text = "";
                    GameTimer.Enabled = false;
                    winOutput.Text = "Player1 Wins";
                    Start.Text = "Press space to play again\n press esc to quit";
                }

                if (player2Score == 3)
                {
                    Player1ScoreOutput.Text = "";
                    Player2ScoreOutput.Text = "";
                    GameTimer.Enabled = false;
                    winOutput.Text = "Player2 Wins";
                    Start.Text = "Press spacee to play again\n press esc to quit";
                }
            }

            Player1ScoreOutput.Text = $"{player1Score}";
            Player2ScoreOutput.Text = $"{player2Score}";
            Refresh();
        }

        private void Player1ScoreOutput_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            winOutput.Text = "Space Race";
            Start.Text = "Press space to start";
            
        }
    }
}
