using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopFire
{
    public partial class Form1 : Form
    {
        static Size sSize = Screen.PrimaryScreen.Bounds.Size;
        int changePoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyMainWindowConfig();
            SettingButtonConfig();
            CloseButtonConfig();
            FireWithCursor();
            CreateFileForChangePoint();
            MainPanelConfig();
        }

        private void CreateFileForChangePoint()
        {
            if (!File.Exists("ChangePoint.txt"))
            {
                fire.Visible = false;
                ghost.Visible = false;
                black_Hole.Visible = false;
                pikachu.Visible = false;
                cherizard.Visible = false;
                bulbazavr.Visible = false;
                ghastly.Visible = false;
                golbat.Visible = false;

                using (StreamWriter sw = new StreamWriter("ChangePoint.txt"))
                {
                    sw.Write(changePoint.ToString());
                }
            }
            else
            {
                using (StreamReader sr = new StreamReader("ChangePoint.txt"))
                {
                    changePoint = Convert.ToInt32(sr.ReadToEnd());
                }
            }
        }
        private void MyMainWindowConfig()
        {
            Size = new Size(sSize.Width, sSize.Height);
            Location = new Point(0, 0);
            FormBorderStyle = FormBorderStyle.None;
        }
        private void SettingButtonConfig()
        {
            settingsButton.Size = new Size(65, 20);
            settingsButton.Location = new Point(sSize.Width-5, -15);
        }
        private void CloseButtonConfig()
        {
            button1.Size = new Size(50, 20);
            button1.Location = new Point(-45, -15);
        }
        private void MainPanelConfig()
        {
            panel1.Location = new Point(sSize.Width - panel1.Size.Width, 0);
        }
        async void FireWithCursor()
        {
            await Task.Run(() =>
            {
                for (; true;)
                {
                    checkingPoint();
                }
            });
        }

        private void checkingPoint()
        {
            switch (changePoint)
            {
                case 1:
                    fire.Visible = true;
                    ghost.Visible = false;
                    black_Hole.Visible = false;
                    pikachu.Visible = false;
                    cherizard.Visible = false;
                    bulbazavr.Visible = false;
                    ghastly.Visible = false;
                    golbat.Visible = false;

                    fire.Size = new Size(64, 64);
                    Thread.Sleep(1);
                    fire.Location = new Point(Cursor.Position.X + 5, Cursor.Position.Y + 5);
                    break;
                case 2:
                    fire.Visible = false;
                    ghost.Visible = true;
                    black_Hole.Visible = false;
                    pikachu.Visible = false;
                    cherizard.Visible = false;
                    bulbazavr.Visible = false;
                    ghastly.Visible = false;
                    golbat.Visible = false;

                    ghost.Size = new Size(64, 64);
                    Thread.Sleep(1);
                    ghost.Location = new Point(Cursor.Position.X + 5, Cursor.Position.Y + 5);
                    break;
                case 3:
                    fire.Visible = false;
                    ghost.Visible = false;
                    black_Hole.Visible = true;
                    pikachu.Visible = false;
                    cherizard.Visible = false;
                    bulbazavr.Visible = false;
                    ghastly.Visible = false;
                    golbat.Visible = false;

                    black_Hole.Size = new Size(64, 64);
                    Thread.Sleep(1);
                    black_Hole.Location = new Point(Cursor.Position.X + 5, Cursor.Position.Y + 5);
                    break;
                case 4:
                    fire.Visible = false;
                    ghost.Visible = false;
                    black_Hole.Visible = false;
                    pikachu.Visible = true;
                    cherizard.Visible = false;
                    bulbazavr.Visible = false;
                    ghastly.Visible = false;
                    golbat.Visible = false;

                    pikachu.Size = new Size(67, 77);
                    Thread.Sleep(1);
                    pikachu.Location = new Point(Cursor.Position.X + 5, Cursor.Position.Y + 5);
                    break;
                case 5:
                    fire.Visible = false;
                    ghost.Visible = false;
                    black_Hole.Visible = false;
                    pikachu.Visible = false;
                    cherizard.Visible = true;
                    bulbazavr.Visible = false;
                    ghastly.Visible = false;
                    golbat.Visible = false;

                    cherizard.Size = new Size(101, 82);
                    Thread.Sleep(1);
                    cherizard.Location = new Point(Cursor.Position.X + 5, Cursor.Position.Y + 5);
                    break;
                case 6:
                    fire.Visible = false;
                    ghost.Visible = false;
                    black_Hole.Visible = false;
                    pikachu.Visible = false;
                    cherizard.Visible = false;
                    bulbazavr.Visible = true;
                    ghastly.Visible = false;
                    golbat.Visible = false;

                    bulbazavr.Size = new Size(68, 80);
                    Thread.Sleep(1);
                    bulbazavr.Location = new Point(Cursor.Position.X + 5, Cursor.Position.Y + 5);
                    break;
                case 7:
                    fire.Visible = false;
                    ghost.Visible = false;
                    black_Hole.Visible = false;
                    pikachu.Visible = false;
                    cherizard.Visible = false;
                    bulbazavr.Visible = false;
                    ghastly.Visible = true;
                    golbat.Visible = false;

                    ghastly.Size = new Size(64, 64);
                    Thread.Sleep(1);
                    ghastly.Location = new Point(Cursor.Position.X + 5, Cursor.Position.Y + 5);
                    break;
                case 8:
                    fire.Visible = false;
                    ghost.Visible = false;
                    black_Hole.Visible = false;
                    pikachu.Visible = false;
                    cherizard.Visible = false;
                    bulbazavr.Visible = false;
                    ghastly.Visible = false;
                    golbat.Visible = true;

                    golbat.Size = new Size(86, 80);
                    Thread.Sleep(1);
                    golbat.Location = new Point(Cursor.Position.X + 5, Cursor.Position.Y + 5);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            settingsButton.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            settingsButton.Visible = true;
            panel1.Visible = false;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            ChangePicture();
            Cmd("DesktopFire.exe");
            Thread.Sleep(1);
            Close();
        }
        private void Cmd(string line)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c {line}",
                WindowStyle = ProcessWindowStyle.Hidden
            });
        }
        

        private void ChangePicture()
        {
            if (radioButton1.Checked) // fire
            {
                using (StreamWriter sw = new StreamWriter("ChangePoint.txt"))
                {
                    sw.Write(1);
                }
            }
            else if (radioButton2.Checked) // ghost
            {
                using (StreamWriter sw = new StreamWriter("ChangePoint.txt"))
                {
                    sw.Write(2);
                }
            }
            else if (radioButton3.Checked) // black hole
            {
                using (StreamWriter sw = new StreamWriter("ChangePoint.txt"))
                {
                    sw.Write(3);
                }
            }
            else if (radioButton4.Checked) // pikachu
            {
                using (StreamWriter sw = new StreamWriter("ChangePoint.txt"))
                {
                    sw.Write(4);
                }
            }
            else if (radioButton5.Checked) // cherizard
            {
                using (StreamWriter sw = new StreamWriter("ChangePoint.txt"))
                {
                    sw.Write(5);
                }
            }
            else if (radioButton6.Checked) // bulbazavr
            {
                using (StreamWriter sw = new StreamWriter("ChangePoint.txt"))
                {
                    sw.Write(6);
                }
            }
            else if (radioButton7.Checked) // ghastly
            {
                using (StreamWriter sw = new StreamWriter("ChangePoint.txt"))
                {
                    sw.Write(7);
                }
            }
            else if (radioButton8.Checked) // golbat
            {
                using (StreamWriter sw = new StreamWriter("ChangePoint.txt"))
                {
                    sw.Write(8);
                }
            }
            else
            {
                MessageBox.Show("Choose anything");
            }
        }
    }
}
