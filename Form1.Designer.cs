namespace CSharp_Itog_Smolnicov
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_GiveUp = new System.Windows.Forms.Button();
            this.menu_Options = new System.Windows.Forms.MenuStrip();
            this.выберитеИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.игра1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.примерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Start = new System.Windows.Forms.Button();
            this.pnl_task1 = new System.Windows.Forms.Panel();
            this.pnl_task2 = new System.Windows.Forms.Panel();
            this.pnl_cells = new System.Windows.Forms.Panel();
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_game = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.menu_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_GiveUp
            // 
            this.btn_GiveUp.BackgroundImage = global::CSharp_Itog_Smolnicov.Properties.Resources.cell_img21;
            this.btn_GiveUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_GiveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GiveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_GiveUp.ForeColor = System.Drawing.Color.PeachPuff;
            this.btn_GiveUp.Location = new System.Drawing.Point(553, 566);
            this.btn_GiveUp.Name = "btn_GiveUp";
            this.btn_GiveUp.Size = new System.Drawing.Size(75, 23);
            this.btn_GiveUp.TabIndex = 2;
            this.btn_GiveUp.Text = "Сдаться?";
            this.btn_GiveUp.UseVisualStyleBackColor = true;
            this.btn_GiveUp.Visible = false;
            this.btn_GiveUp.Click += new System.EventHandler(this.btn_GiveUp_Click);
            // 
            // menu_Options
            // 
            this.menu_Options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выберитеИгруToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menu_Options.Location = new System.Drawing.Point(0, 0);
            this.menu_Options.Name = "menu_Options";
            this.menu_Options.Size = new System.Drawing.Size(678, 24);
            this.menu_Options.TabIndex = 7;
            this.menu_Options.Text = "menuStrip1";
            // 
            // выберитеИгруToolStripMenuItem
            // 
            this.выберитеИгруToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.игра1ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.выберитеИгруToolStripMenuItem.Name = "выберитеИгруToolStripMenuItem";
            this.выберитеИгруToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.выберитеИгруToolStripMenuItem.Text = "Выберите игру";
            // 
            // игра1ToolStripMenuItem
            // 
            this.игра1ToolStripMenuItem.Name = "игра1ToolStripMenuItem";
            this.игра1ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.игра1ToolStripMenuItem.Text = "игра 1";
            this.игра1ToolStripMenuItem.Click += new System.EventHandler(this.игра1ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem2.Text = "игра 2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem3.Text = "игра 3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаToolStripMenuItem,
            this.примерToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // правилаToolStripMenuItem
            // 
            this.правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            this.правилаToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.правилаToolStripMenuItem.Text = "Правила";
            this.правилаToolStripMenuItem.Click += new System.EventHandler(this.правилаToolStripMenuItem_Click);
            // 
            // примерToolStripMenuItem
            // 
            this.примерToolStripMenuItem.Name = "примерToolStripMenuItem";
            this.примерToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.примерToolStripMenuItem.Text = "Пример";
            this.примерToolStripMenuItem.Click += new System.EventHandler(this.примерToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackgroundImage = global::CSharp_Itog_Smolnicov.Properties.Resources.cell_img21;
            this.btn_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Start.Enabled = false;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.Color.PeachPuff;
            this.btn_Start.Location = new System.Drawing.Point(336, 566);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(116, 46);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "Поехали!";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // pnl_task1
            // 
            this.pnl_task1.BackColor = System.Drawing.Color.Transparent;
            this.pnl_task1.Location = new System.Drawing.Point(142, 160);
            this.pnl_task1.Name = "pnl_task1";
            this.pnl_task1.Size = new System.Drawing.Size(80, 400);
            this.pnl_task1.TabIndex = 8;
            // 
            // pnl_task2
            // 
            this.pnl_task2.BackColor = System.Drawing.Color.Transparent;
            this.pnl_task2.Location = new System.Drawing.Point(228, 34);
            this.pnl_task2.Name = "pnl_task2";
            this.pnl_task2.Size = new System.Drawing.Size(400, 120);
            this.pnl_task2.TabIndex = 9;
            // 
            // pnl_cells
            // 
            this.pnl_cells.BackgroundImage = global::CSharp_Itog_Smolnicov.Properties.Resources.pic;
            this.pnl_cells.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_cells.Location = new System.Drawing.Point(228, 160);
            this.pnl_cells.Name = "pnl_cells";
            this.pnl_cells.Size = new System.Drawing.Size(400, 400);
            this.pnl_cells.TabIndex = 0;
            // 
            // game_timer
            // 
            this.game_timer.Interval = 1000;
            this.game_timer.Tick += new System.EventHandler(this.game_timer_Tick);
            // 
            // lbl_game
            // 
            this.lbl_game.AutoSize = true;
            this.lbl_game.BackColor = System.Drawing.Color.Transparent;
            this.lbl_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_game.ForeColor = System.Drawing.Color.Black;
            this.lbl_game.Location = new System.Drawing.Point(48, 37);
            this.lbl_game.Name = "lbl_game";
            this.lbl_game.Size = new System.Drawing.Size(127, 37);
            this.lbl_game.TabIndex = 10;
            this.lbl_game.Text = "label29";
            this.lbl_game.Visible = false;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_time.Location = new System.Drawing.Point(74, 74);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(101, 31);
            this.lbl_time.TabIndex = 11;
            this.lbl_time.Text = "label30";
            this.lbl_time.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 622);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_game);
            this.Controls.Add(this.pnl_task2);
            this.Controls.Add(this.pnl_task1);
            this.Controls.Add(this.btn_GiveUp);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.pnl_cells);
            this.Controls.Add(this.menu_Options);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menu_Options;
            this.Name = "Form1";
            this.Text = "Японский кроссворд";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menu_Options.ResumeLayout(false);
            this.menu_Options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_cells;
        private System.Windows.Forms.Button btn_GiveUp;
        private System.Windows.Forms.MenuStrip menu_Options;
        private System.Windows.Forms.ToolStripMenuItem выберитеИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem игра1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Panel pnl_task1;
        private System.Windows.Forms.Panel pnl_task2;
        private System.Windows.Forms.ToolStripMenuItem правилаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem примерToolStripMenuItem;
        private System.Windows.Forms.Timer game_timer;
        private System.Windows.Forms.Label lbl_game;
        private System.Windows.Forms.Label lbl_time;
    }
}

