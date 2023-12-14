
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BowmenGame
{
    partial class BattlefieldForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent1()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattlefieldForm));
            this.ButtonRestartGame = new System.Windows.Forms.Button();
            this.cell44 = new BowmenGame.CellButton("cell44", this);
            this.cell34 = new BowmenGame.CellButton("cell34", this);
            this.cell24 = new BowmenGame.CellButton("cell24", this);
            this.cell14 = new BowmenGame.CellButton("cell14", this);
            this.cell43 = new BowmenGame.CellButton("cell43", this);
            this.cell33 = new BowmenGame.CellButton("cell33", this);
            this.cell23 = new BowmenGame.CellButton("cell23", this);
            this.cell13 = new BowmenGame.CellButton("cell13", this);
            this.cell42 = new BowmenGame.CellButton("cell42", this);
            this.cell32 = new BowmenGame.CellButton("cell32", this);
            this.cell22 = new BowmenGame.CellButton("cell22", this);
            this.cell12 = new BowmenGame.CellButton("cell12", this);
            this.cell41 = new BowmenGame.CellButton("cell41", this);
            this.cell31 = new BowmenGame.CellButton("cell31", this);
            this.cell21 = new BowmenGame.CellButton("cell21", this);
            this.cell11 = new BowmenGame.CellButton("cell11", this);
            this.cell04 = new BowmenGame.CellButton("cell04", this);
            this.cell03 = new BowmenGame.CellButton("cell03", this);
            this.cell02 = new BowmenGame.CellButton("cell02", this);
            this.cell01 = new BowmenGame.CellButton("cell01", this);
            this.cell40 = new BowmenGame.CellButton("cell40", this);
            this.cell30 = new BowmenGame.CellButton("cell30", this);
            this.cell20 = new BowmenGame.CellButton("cell20", this);
            this.cell10 = new BowmenGame.CellButton("cell10", this);
            this.cell00 = new BowmenGame.CellButton("cell00", this);
            this.SuspendLayout();
            // 
            // ButtonRestartGame
            // 
            this.ButtonRestartGame.BackColor = System.Drawing.Color.FromArgb(127, 0, 0);
            this.ButtonRestartGame.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRestartGame.Location = new System.Drawing.Point(137, 593);
            this.ButtonRestartGame.Name = "ButtonRestartGame";
            this.ButtonRestartGame.Size = new System.Drawing.Size(285, 60);
            this.ButtonRestartGame.TabIndex = 25;
            this.ButtonRestartGame.Text = "Начать заново";
            this.ButtonRestartGame.UseVisualStyleBackColor = false;
            this.ButtonRestartGame.Click += new System.EventHandler(this.ButtonRestartGame_Click);
            // 
            // cell44
            // 
            this.cell44.BackColor = System.Drawing.Color.SandyBrown;
            this.cell44.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell44.FlatAppearance.BorderSize = 0;
            this.cell44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell44.Image = ((System.Drawing.Image)(resources.GetObject("cell44.Image")));
            this.cell44.LinkedCells = null;
            this.cell44.Location = new System.Drawing.Point(467, 469);
            this.cell44.Name = "cell44";
            this.cell44.Size = new System.Drawing.Size(65, 65);
            this.cell44.TabIndex = 24;
            this.cell44.UseVisualStyleBackColor = false;
            // 
            // cell34
            // 
            this.cell34.BackColor = System.Drawing.Color.SandyBrown;
            this.cell34.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell34.FlatAppearance.BorderSize = 0;
            this.cell34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell34.Image = ((System.Drawing.Image)(resources.GetObject("cell34.Image")));
            this.cell34.LinkedCells = null;
            this.cell34.Location = new System.Drawing.Point(357, 469);
            this.cell34.Name = "cell34";
            this.cell34.Size = new System.Drawing.Size(65, 65);
            this.cell34.TabIndex = 23;
            this.cell34.UseVisualStyleBackColor = false;
            // 
            // cell24
            // 
            this.cell24.BackColor = System.Drawing.Color.SandyBrown;
            this.cell24.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell24.FlatAppearance.BorderSize = 0;
            this.cell24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell24.Image = ((System.Drawing.Image)(resources.GetObject("cell24.Image")));
            this.cell24.LinkedCells = null;
            this.cell24.Location = new System.Drawing.Point(247, 469);
            this.cell24.Name = "cell24";
            this.cell24.Size = new System.Drawing.Size(65, 65);
            this.cell24.TabIndex = 22;
            this.cell24.UseVisualStyleBackColor = false;
            // 
            // cell14
            // 
            this.cell14.BackColor = System.Drawing.Color.SandyBrown;
            this.cell14.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell14.FlatAppearance.BorderSize = 0;
            this.cell14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell14.Image = ((System.Drawing.Image)(resources.GetObject("cell14.Image")));
            this.cell14.LinkedCells = null;
            this.cell14.Location = new System.Drawing.Point(137, 469);
            this.cell14.Name = "cell14";
            this.cell14.Size = new System.Drawing.Size(65, 65);
            this.cell14.TabIndex = 21;
            this.cell14.UseVisualStyleBackColor = false;
            // 
            // cell43
            // 
            this.cell43.BackColor = System.Drawing.Color.White;
            this.cell43.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell43.FlatAppearance.BorderSize = 0;
            this.cell43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell43.Image = ((System.Drawing.Image)(resources.GetObject("cell43.Image")));
            this.cell43.LinkedCells = null;
            this.cell43.Location = new System.Drawing.Point(467, 359);
            this.cell43.Name = "cell43";
            this.cell43.Size = new System.Drawing.Size(65, 65);
            this.cell43.TabIndex = 20;
            this.cell43.UseVisualStyleBackColor = false;
            // 
            // cell33
            // 
            this.cell33.BackColor = System.Drawing.Color.White;
            this.cell33.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell33.FlatAppearance.BorderSize = 0;
            this.cell33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell33.Image = ((System.Drawing.Image)(resources.GetObject("cell33.Image")));
            this.cell33.LinkedCells = null;
            this.cell33.Location = new System.Drawing.Point(357, 359);
            this.cell33.Name = "cell33";
            this.cell33.Size = new System.Drawing.Size(65, 65);
            this.cell33.TabIndex = 19;
            this.cell33.UseVisualStyleBackColor = false;
            // 
            // cell23
            // 
            this.cell23.BackColor = System.Drawing.Color.White;
            this.cell23.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell23.FlatAppearance.BorderSize = 0;
            this.cell23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell23.Image = ((System.Drawing.Image)(resources.GetObject("cell23.Image")));
            this.cell23.LinkedCells = null;
            this.cell23.Location = new System.Drawing.Point(247, 359);
            this.cell23.Name = "cell23";
            this.cell23.Size = new System.Drawing.Size(65, 65);
            this.cell23.TabIndex = 18;
            this.cell23.UseVisualStyleBackColor = false;
            // 
            // cell13
            // 
            this.cell13.BackColor = System.Drawing.Color.White;
            this.cell13.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell13.FlatAppearance.BorderSize = 0;
            this.cell13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell13.Image = ((System.Drawing.Image)(resources.GetObject("cell13.Image")));
            this.cell13.LinkedCells = null;
            this.cell13.Location = new System.Drawing.Point(137, 359);
            this.cell13.Name = "cell13";
            this.cell13.Size = new System.Drawing.Size(65, 65);
            this.cell13.TabIndex = 17;
            this.cell13.UseVisualStyleBackColor = false;
            // 
            // cell42
            // 
            this.cell42.BackColor = System.Drawing.Color.White;
            this.cell42.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell42.FlatAppearance.BorderSize = 0;
            this.cell42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell42.Image = ((System.Drawing.Image)(resources.GetObject("cell42.Image")));
            this.cell42.LinkedCells = null;
            this.cell42.Location = new System.Drawing.Point(467, 249);
            this.cell42.Name = "cell42";
            this.cell42.Size = new System.Drawing.Size(65, 65);
            this.cell42.TabIndex = 16;
            this.cell42.UseVisualStyleBackColor = false;
            // 
            // cell32
            // 
            this.cell32.BackColor = System.Drawing.Color.White;
            this.cell32.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell32.FlatAppearance.BorderSize = 0;
            this.cell32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell32.Image = ((System.Drawing.Image)(resources.GetObject("cell32.Image")));
            this.cell32.LinkedCells = null;
            this.cell32.Location = new System.Drawing.Point(357, 249);
            this.cell32.Name = "cell32";
            this.cell32.Size = new System.Drawing.Size(65, 65);
            this.cell32.TabIndex = 15;
            this.cell32.UseVisualStyleBackColor = false;
            // 
            // cell22
            // 
            this.cell22.BackColor = System.Drawing.Color.White;
            this.cell22.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell22.FlatAppearance.BorderSize = 0;
            this.cell22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell22.Image = ((System.Drawing.Image)(resources.GetObject("cell22.Image")));
            this.cell22.LinkedCells = null;
            this.cell22.Location = new System.Drawing.Point(247, 249);
            this.cell22.Name = "cell22";
            this.cell22.Size = new System.Drawing.Size(65, 65);
            this.cell22.TabIndex = 14;
            this.cell22.UseVisualStyleBackColor = false;
            // 
            // cell12
            // 
            this.cell12.BackColor = System.Drawing.Color.White;
            this.cell12.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell12.FlatAppearance.BorderSize = 0;
            this.cell12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell12.Image = ((System.Drawing.Image)(resources.GetObject("cell12.Image")));
            this.cell12.LinkedCells = null;
            this.cell12.Location = new System.Drawing.Point(137, 249);
            this.cell12.Name = "cell12";
            this.cell12.Size = new System.Drawing.Size(65, 65);
            this.cell12.TabIndex = 13;
            this.cell12.UseVisualStyleBackColor = false;
            // 
            // cell41
            // 
            this.cell41.BackColor = System.Drawing.Color.White;
            this.cell41.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell41.FlatAppearance.BorderSize = 0;
            this.cell41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell41.Image = ((System.Drawing.Image)(resources.GetObject("cell41.Image")));
            this.cell41.LinkedCells = null;
            this.cell41.Location = new System.Drawing.Point(467, 139);
            this.cell41.Name = "cell41";
            this.cell41.Size = new System.Drawing.Size(65, 65);
            this.cell41.TabIndex = 12;
            this.cell41.UseVisualStyleBackColor = false;
            // 
            // cell31
            // 
            this.cell31.BackColor = System.Drawing.Color.White;
            this.cell31.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell31.FlatAppearance.BorderSize = 0;
            this.cell31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell31.Image = ((System.Drawing.Image)(resources.GetObject("cell31.Image")));
            this.cell31.LinkedCells = null;
            this.cell31.Location = new System.Drawing.Point(357, 139);
            this.cell31.Name = "cell31";
            this.cell31.Size = new System.Drawing.Size(65, 65);
            this.cell31.TabIndex = 11;
            this.cell31.UseVisualStyleBackColor = false;
            // 
            // cell21
            // 
            this.cell21.BackColor = System.Drawing.Color.White;
            this.cell21.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell21.FlatAppearance.BorderSize = 0;
            this.cell21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell21.Image = ((System.Drawing.Image)(resources.GetObject("cell21.Image")));
            this.cell21.LinkedCells = null;
            this.cell21.Location = new System.Drawing.Point(247, 139);
            this.cell21.Name = "cell21";
            this.cell21.Size = new System.Drawing.Size(65, 65);
            this.cell21.TabIndex = 10;
            this.cell21.UseVisualStyleBackColor = false;
            // 
            // cell11
            // 
            this.cell11.BackColor = System.Drawing.Color.White;
            this.cell11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell11.FlatAppearance.BorderSize = 0;
            this.cell11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell11.Image = ((System.Drawing.Image)(resources.GetObject("cell11.Image")));
            this.cell11.LinkedCells = null;
            this.cell11.Location = new System.Drawing.Point(137, 139);
            this.cell11.Name = "cell11";
            this.cell11.Size = new System.Drawing.Size(65, 65);
            this.cell11.TabIndex = 9;
            this.cell11.UseVisualStyleBackColor = false;
            // 
            // cell04
            // 
            this.cell04.BackColor = System.Drawing.Color.SandyBrown;
            this.cell04.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell04.FlatAppearance.BorderSize = 0;
            this.cell04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell04.Image = ((System.Drawing.Image)(resources.GetObject("cell04.Image")));
            this.cell04.LinkedCells = null;
            this.cell04.Location = new System.Drawing.Point(27, 469);
            this.cell04.Name = "cell04";
            this.cell04.Size = new System.Drawing.Size(65, 65);
            this.cell04.TabIndex = 8;
            this.cell04.UseVisualStyleBackColor = false;
            // 
            // cell03
            // 
            this.cell03.BackColor = System.Drawing.Color.White;
            this.cell03.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell03.FlatAppearance.BorderSize = 0;
            this.cell03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell03.Image = ((System.Drawing.Image)(resources.GetObject("cell03.Image")));
            this.cell03.LinkedCells = null;
            this.cell03.Location = new System.Drawing.Point(27, 359);
            this.cell03.Name = "cell03";
            this.cell03.Size = new System.Drawing.Size(65, 65);
            this.cell03.TabIndex = 7;
            this.cell03.UseVisualStyleBackColor = false;
            // 
            // cell02
            // 
            this.cell02.BackColor = System.Drawing.Color.White;
            this.cell02.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell02.FlatAppearance.BorderSize = 0;
            this.cell02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell02.Image = ((System.Drawing.Image)(resources.GetObject("cell02.Image")));
            this.cell02.LinkedCells = null;
            this.cell02.Location = new System.Drawing.Point(27, 249);
            this.cell02.Name = "cell02";
            this.cell02.Size = new System.Drawing.Size(65, 65);
            this.cell02.TabIndex = 6;
            this.cell02.UseVisualStyleBackColor = false;
            // 
            // cell01
            // 
            this.cell01.BackColor = System.Drawing.Color.White;
            this.cell01.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell01.FlatAppearance.BorderSize = 0;
            this.cell01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell01.Image = ((System.Drawing.Image)(resources.GetObject("cell01.Image")));
            this.cell01.LinkedCells = null;
            this.cell01.Location = new System.Drawing.Point(27, 139);
            this.cell01.Name = "cell01";
            this.cell01.Size = new System.Drawing.Size(65, 65);
            this.cell01.TabIndex = 5;
            this.cell01.UseVisualStyleBackColor = false;
            // 
            // cell40
            // 
            this.cell40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cell40.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell40.FlatAppearance.BorderSize = 0;
            this.cell40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell40.Image = ((System.Drawing.Image)(resources.GetObject("cell40.Image")));
            this.cell40.LinkedCells = null;
            this.cell40.Location = new System.Drawing.Point(467, 29);
            this.cell40.Name = "cell40";
            this.cell40.Size = new System.Drawing.Size(65, 65);
            this.cell40.TabIndex = 4;
            this.cell40.UseVisualStyleBackColor = false;
            // 
            // cell30
            // 
            this.cell30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cell30.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell30.FlatAppearance.BorderSize = 0;
            this.cell30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell30.Image = ((System.Drawing.Image)(resources.GetObject("cell30.Image")));
            this.cell30.LinkedCells = null;
            this.cell30.Location = new System.Drawing.Point(357, 29);
            this.cell30.Name = "cell30";
            this.cell30.Size = new System.Drawing.Size(65, 65);
            this.cell30.TabIndex = 3;
            this.cell30.UseVisualStyleBackColor = false;
            // 
            // cell20
            // 
            this.cell20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cell20.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell20.FlatAppearance.BorderSize = 0;
            this.cell20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell20.Image = ((System.Drawing.Image)(resources.GetObject("cell20.Image")));
            this.cell20.LinkedCells = null;
            this.cell20.Location = new System.Drawing.Point(247, 29);
            this.cell20.Name = "cell20";
            this.cell20.Size = new System.Drawing.Size(65, 65);
            this.cell20.TabIndex = 2;
            this.cell20.UseVisualStyleBackColor = false;
            // 
            // cell10
            // 
            this.cell10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cell10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell10.FlatAppearance.BorderSize = 0;
            this.cell10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell10.Image = ((System.Drawing.Image)(resources.GetObject("cell10.Image")));
            this.cell10.LinkedCells = null;
            this.cell10.Location = new System.Drawing.Point(137, 29);
            this.cell10.Name = "cell10";
            this.cell10.Size = new System.Drawing.Size(65, 65);
            this.cell10.TabIndex = 1;
            this.cell10.UseVisualStyleBackColor = false;
            // 
            // cell00
            // 
            this.cell00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cell00.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cell00.FlatAppearance.BorderSize = 0;
            this.cell00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell00.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell00.Image = ((System.Drawing.Image)(resources.GetObject("cell00.Image")));
            this.cell00.LinkedCells = null;
            this.cell00.Location = new System.Drawing.Point(27, 29);
            this.cell00.Name = "cell00";
            this.cell00.Size = new System.Drawing.Size(65, 65);
            this.cell00.TabIndex = 0;
            this.cell00.UseVisualStyleBackColor = false;
            // 
            // BattlefieldForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(567, 665);
            this.Controls.Add(this.ButtonRestartGame);
            this.Controls.Add(this.cell44);
            this.Controls.Add(this.cell34);
            this.Controls.Add(this.cell24);
            this.Controls.Add(this.cell14);
            this.Controls.Add(this.cell43);
            this.Controls.Add(this.cell33);
            this.Controls.Add(this.cell23);
            this.Controls.Add(this.cell13);
            this.Controls.Add(this.cell42);
            this.Controls.Add(this.cell32);
            this.Controls.Add(this.cell22);
            this.Controls.Add(this.cell12);
            this.Controls.Add(this.cell41);
            this.Controls.Add(this.cell31);
            this.Controls.Add(this.cell21);
            this.Controls.Add(this.cell11);
            this.Controls.Add(this.cell04);
            this.Controls.Add(this.cell03);
            this.Controls.Add(this.cell02);
            this.Controls.Add(this.cell01);
            this.Controls.Add(this.cell40);
            this.Controls.Add(this.cell30);
            this.Controls.Add(this.cell20);
            this.Controls.Add(this.cell10);
            this.Controls.Add(this.cell00);
            this.Name = "BattlefieldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bowmen Game v1.0.0";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private CellButton cell00;
        private CellButton cell10;
        private CellButton cell20;
        private CellButton cell30;
        private CellButton cell40;
        private CellButton cell01;
        private CellButton cell02;
        private CellButton cell03;
        private CellButton cell04;
        private CellButton cell41;
        private CellButton cell31;
        private CellButton cell21;
        private CellButton cell11;
        private CellButton cell42;
        private CellButton cell32;
        private CellButton cell22;
        private CellButton cell12;
        private CellButton cell43;
        private CellButton cell33;
        private CellButton cell23;
        private CellButton cell13;
        private CellButton cell44;
        private CellButton cell34;
        private CellButton cell24;
        private CellButton cell14;
        private System.Windows.Forms.Button ButtonRestartGame;
    }
}

