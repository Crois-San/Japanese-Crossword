using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Itog_Smolnicov
{
    public partial class Form1 : Form
    {
        PictureBox cell = null;
        Label task = null;
        string check, game_task1, game_task2;
        int cellY, cellX, a, tmr_sec, tmr_min, task1W, task1H, task2W, task2H, field_sizeH, field_sizeW, gamenum;
        Font task_font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
        Color game_clr;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void игра1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Start.Enabled = true;
            lbl_game.Text = игра1ToolStripMenuItem.Text;
            lbl_game.Visible = true;
            task1W = 2;
            task1H = 10;
            task2W = 10;
            task2H = 3;
            field_sizeH = 10;
            field_sizeW = 10;
            gamenum = 1;
            game_clr = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label txtclr = (Label)sender;
            txtclr.ForeColor = Color.White;
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            Label txtclr = (Label)sender;
            txtclr.ForeColor = Color.Black;
        }

        private void примерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpExample_frm exFrm = new HelpExample_frm();
            exFrm.ShowDialog();
            exFrm.Dispose();
        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpRules_frm rulFrm = new HelpRules_frm();
            rulFrm.ShowDialog();
            rulFrm.Dispose();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Вы точно хотите выйти?", "Подтверждение.", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {

            game_timer.Start();

            lbl_game.ForeColor = game_clr;
            lbl_time.Visible = true;
            check = "";
            pnl_cells.BackgroundImage = null;
            pnl_cells.Controls.Clear();
            pnl_task1.Controls.Clear();
            pnl_task2.Controls.Clear();
            a = 0;
            cellX = 0;
            cellY = 0;
            pnl_task1.Visible = true;
            pnl_task2.Visible = true;
            for (int i = 0; i < field_sizeH; i++)
            {

                for (int k = 0; k < field_sizeW; k++)
                {

                    cell = new PictureBox();
                    cell.SizeMode = PictureBoxSizeMode.StretchImage;
                    cell.Height = pnl_cells.Height / field_sizeH;
                    cell.Width = pnl_cells.Width / field_sizeW;
                    //cell.BackColor = Color.DarkGray;
                    //cell.BorderStyle = BorderStyle.FixedSingle;
                    cell.BackgroundImage = Properties.Resources.cell_img;
                    cell.BackgroundImageLayout = ImageLayout.Stretch;
                    cell.Tag = a;
                    a++;
                    pnl_cells.Controls.Add(cell);
                    cell.Top = cellY;
                    cell.Left = cellX;
                    cellX += cell.Width;
                    cell.MouseDown += new MouseEventHandler(cell_MouseDown);
                    cell.DoubleClick += new EventHandler(cell_DoubleClick);
                    cell.MouseEnter += new EventHandler(cell_MouseEnter);
                    cell.MouseLeave += new EventHandler(cell_MouseLeave);
                    check += "0";
                }
                cellX = 0;
                cellY += cell.Height;
            }
            cellX = 0;
            cellY = 0;
            a = 0;

            for (int i = 0; i < task1H; i++)
            {

                for (int k = 0; k < task1W; k++)
                {

                    task = new Label();
                    task.Text = "";
                    task.Height = pnl_task1.Height / task1H;
                    task.Width = pnl_task1.Width / task1W;
                    task.Font = task_font;
                    task.BackColor = Color.DarkGray;
                    task.BorderStyle = BorderStyle.FixedSingle;
                    pnl_task1.Controls.Add(task);
                    task.Top = cellY;
                    task.Left = cellX;
                    cellX += task.Width;
                    game_task1 = Properties.Resources.ResourceManager.GetObject("game" + gamenum.ToString() + "_task1").ToString();
                    string b = game_task1.Substring(a, 2);
                    task.Click += new EventHandler(task_Click);
                    task.DoubleClick += new EventHandler(task_DoubleClick);

                    if (game_task1.Substring(a, 2) != "..")
                    {
                        task.BackColor = game_clr;
                        task.Text = "" + (int.Parse(game_task1.Substring(a, 2))).ToString();
                    }
                    a += 2;

                }
                cellX = 0;
                cellY += task.Height;
            }
            cellX = 0;
            cellY = 0;
            a = 0;

            for (int i = 0; i < task2H; i++)
            {

                for (int k = 0; k < task2W; k++)
                {

                    task = new Label();
                    task.Text = "";
                    task.Height = pnl_task2.Height / task2H;
                    task.Width = pnl_task2.Width / task2W;
                    task.Font = task_font;
                    task.BackColor = Color.DarkGray;
                    task.BorderStyle = BorderStyle.FixedSingle;
                    pnl_task2.Controls.Add(task);
                    task.Top = cellY;
                    task.Left = cellX;
                    cellX += task.Width;
                    game_task2 = Properties.Resources.ResourceManager.GetObject("game" + gamenum.ToString() + "_task2").ToString();
                    task.Click += new EventHandler(task_Click);
                    task.DoubleClick += new EventHandler(task_DoubleClick);
                    if (game_task2.Substring(a, 2) != "..")
                    {
                        task.BackColor = game_clr;
                        task.Text = " " + (int.Parse(game_task2.Substring(a, 2))).ToString();
                    }
                    a += 2;
                }
                cellX = 0;
                cellY += task.Height;
            }
        }
        void cell_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {

                cell.Image = Properties.Resources.zero;
                check = check.Remove((int)cell.Tag, 1);
                check = check.Insert((int)cell.Tag, "0");
            }
            else
            {

                cell.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("zadanie" + gamenum);
                check = check.Remove((int)cell.Tag, 1);
                check = check.Insert((int)cell.Tag, "1");

            }

            if (check == Properties.Resources.ResourceManager.GetObject("Game" + gamenum).ToString())
            {
                //Вы решили кроссворд!
                game_timer.Stop();
                RightSolution1_Frm RsolFrm = new RightSolution1_Frm();
                RsolFrm.pictureBox1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("win" + gamenum);
                RsolFrm.ShowDialog();
                RsolFrm.Dispose();
            }

        }
        void cell_DoubleClick(object sender, EventArgs e)
        {
            cell = (PictureBox)sender;
            cell.Image = null;
            check = check.Remove((int)cell.Tag, 1);
            check = check.Insert((int)cell.Tag, "0");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            tmr_sec = 0;
            tmr_min = 0;
            lbl_game.Text = игра1ToolStripMenuItem.Text;


        }

        private void btn_GiveUp_Click(object sender, EventArgs e)
        {
            game_timer.Stop();
            RightSolution1_Frm RsolFrm = new RightSolution1_Frm();
            RsolFrm.pictureBox1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("win" + gamenum);
            RsolFrm.label1.Text = "Правильное решение: ";
            RsolFrm.ShowDialog();
            RsolFrm.Dispose();
        }

        private void game_timer_Tick(object sender, EventArgs e)
        {

            tmr_sec++;
            if (tmr_sec > 60)
            {
                tmr_sec = 0;
                tmr_min++;
            }
            if (tmr_min == 2)
            {
                btn_GiveUp.Visible = true;
            }
            lbl_time.Text = tmr_min.ToString() + ":" + tmr_sec.ToString();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            btn_Start.Enabled = true;
            lbl_game.Text = toolStripMenuItem2.Text;
            lbl_game.Visible = true;
            task1W = 3;
            task1H = 12;
            task2W = 13;
            task2H = 2;
            field_sizeW = 13;
            field_sizeH = 12;
            gamenum = 2;
            game_clr = Color.RoyalBlue;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            btn_Start.Enabled = true;
            lbl_game.Text = toolStripMenuItem3.Text;
            lbl_game.Visible = true;
            task1W = 4;
            task1H = 11;
            task2W = 11;
            task2H = 2;
            field_sizeW = 11;
            field_sizeH = 11;
            gamenum = 3;
            game_clr = Color.DarkViolet;
        }
        void task_Click(object sender, EventArgs e)
        {
            task = (Label)sender;
            task.ForeColor = Color.White;
        }
        void task_DoubleClick(object sender, EventArgs e)
        {
            task = (Label)sender;
            task.ForeColor = Color.Black;
        }
        void cell_MouseEnter(object sender, EventArgs e)
        {
            cell = (PictureBox)sender;
            int a = (int)cell.Tag / field_sizeW;
            int b = (int)cell.Tag % field_sizeW;
            foreach (PictureBox light in pnl_cells.Controls)
            {

                if (a == (int)light.Tag / field_sizeW)
                {
                    light.BackgroundImage = Properties.Resources.cell_img2;
                    //light.BackColor = Color.LightGray;
                }
                if (b == (int)light.Tag % field_sizeW)
                {
                    light.BackgroundImage = Properties.Resources.cell_img2;
                    //light.BackColor = Color.LightGray;
                }

            }
        }
        void cell_MouseLeave(object sender, EventArgs e)
        {
            cell = (PictureBox)sender;
            int a = (int)cell.Tag / field_sizeW;
            int b = (int)cell.Tag % field_sizeW;
            foreach (PictureBox light in pnl_cells.Controls)
            {

                if (a == (int)light.Tag / field_sizeW)
                {
                    light.BackgroundImage = Properties.Resources.cell_img;
                    //light.BackColor = Color.DarkGray;
                }
                if (b == (int)light.Tag % field_sizeW)
                {
                    light.BackgroundImage = Properties.Resources.cell_img;
                    //light.BackColor = Color.DarkGray;
                }
            }

        }


    }
}
