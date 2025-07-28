using System;
using System.Windows.Forms;

namespace FrogsWindowsFormsApp
{
    public partial class MainForm : Form
    {
        public int score=0;
        int bestScore = 24;
        public MainForm()
        {
            InitializeComponent();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            score++;
            scoreLabel.Text = score.ToString();
            Swap((PictureBox)sender);
        }

        private void Swap(PictureBox clickedPicture)
        {
            var distance=Math.Abs(clickedPicture.Location.X-emptyPictureBox.Location.X)/emptyPictureBox.Size.Width;

            if (distance>2)
            {
                MessageBox.Show("Лягушка не умеет прыгать так далеко!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                var location = clickedPicture.Location;
                clickedPicture.Location = emptyPictureBox.Location;
                emptyPictureBox.Location = location;

                if (EndGame())
                {
                    if (score == bestScore)
                    {
                        MessageBox.Show("Игра окончена!\nВы победили с лучшим счётом!");
                    }
                    else
                    {
                        MessageBox.Show("Игра окончена!\nВы победили, но не за минимальное количество ходов!\nМинимальное количество: 24");
                    }
                }
            }
        }
        private bool EndGame()
        {
            return rightPictureBox1.Location.X < emptyPictureBox.Location.X && rightPictureBox2.Location.X < emptyPictureBox.Location.X 
                && rightPictureBox3.Location.X < emptyPictureBox.Location.X && rightPictureBox4.Location.X < emptyPictureBox.Location.X 
                && emptyPictureBox.Location.X == 450;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WelcomeForm welcome = new WelcomeForm();
            welcome.ShowDialog();
            scoreLabel.Text = score.ToString();
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoolsForm rools= new RoolsForm();
            rools.ShowDialog();
        }

        private void начатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
