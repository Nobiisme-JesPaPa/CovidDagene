﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input; 

namespace SpaceInvaders {
    public partial class GameForm : Form {
        private bool musicToggle = true;
        private double gameTicks = 0; 
        private int projectileTick = 0; 
        private double speedMultiplier = 1; 
        private int numAliensLeft = 55;
        private int score = 0;
        private const int rightSideDifference = 88;
        private const int projectileSpeed = 7;
        private int soundStep = 1; 
        private int deathTimer = 0; 
        private int deathType = 0; 
        private bool deathAnimation = true; 
        private int deathCycle = 0; 
        private int alienAnimation = 0; 
        private bool isGoingRight = true; 
        private const int AlienPushX = 10; 
        private const int AlienPushY = 20; 
        private int totalProjectiles = 0;
        private const int projectileGhostOffset = 16; 
        string fileName = Path.Combine(Environment.CurrentDirectory, "highscoreSingle.txt");

        private List<PictureBox> AlienPBList = new List<PictureBox>();
        private List<PictureBox> BaseBlockList = new List<PictureBox>();
        private List<PictureBox> AlienProjectileList = new List<PictureBox>();
        private List<PictureBox> AlienProjectileGhostList = new List<PictureBox>();
        private List<Enemy> AlienList = new List<Enemy>();
        private List<Enemy> BottomAliens = new List<Enemy>();
        private Bullet playerProj = new Bullet(1);
        private Player p1 = new Player();
        private static Random RandomNum = new Random();
        string[] scores = new string[] { "0", "0", "0" };

        public GameForm()
        {
            InitializeComponent();
            UseCustomFont();
            InitializeAliens();
            p1.SetPos(player.Location);
            p1.SetLives(3);
        }

        public Menu MainMenu
        {
            get => default;
            set
            {
            }
        }

        private void alienMovement_Tick(object sender, EventArgs e) 
        {
            gameTicks = Math.Round((gameTicks * speedMultiplier), 2);
            if (gameTicks >= 15) { 
                PlaySound(1);
                UpdateAliens();
                TryShoot();
                gameTicks = 0; 
            }
            CheckEndGame();
            ++gameTicks;
        }

        private void playerMovement_Tick(object sender, EventArgs e) 
        {
            if (Keyboard.IsKeyDown(Key.Left))
            {
                if (player.Location.X > 20) { 
                    player.Location = new Point(player.Location.X - 3, player.Location.Y);
                    p1.SetPos(player.Location);
                }
            }
            else if (Keyboard.IsKeyDown(Key.Right))
            {
                if (player.Location.X < this.Width - rightSideDifference) { 
                    player.Location = new Point(player.Location.X + 3, player.Location.Y);
                    p1.SetPos(player.Location);
                }
            }
            if (Keyboard.IsKeyDown(Key.Space))
            {
                if (!p1.IsFired()) {
                 p1.Fire(true);
                 playerProjectile.Location = new Point(p1.GetPos('x') + (25), p1.GetPos('y'));
                 playerProjectile.Visible = playerProj.SetVisibility(true);
                 playerProjectile.Visible = true;
                 playerProj.SetPos(p1.GetPos('x') + 25, 'x');
                 playerProj.SetPos(p1.GetPos('y'), 'y');
                 PlaySound(3);
               }
            }

            if (p1.IsFired()) {
                playerProjectileGhost.Location = new Point(playerProj.GetPos('x') - projectileGhostOffset, playerProj.GetPos('y') - projectileSpeed);
                playerProjectile.Location = new Point(playerProj.GetPos('x'), playerProj.GetPos('y') - projectileSpeed);
                playerProj.SetPos(playerProj.GetPos('y') - projectileSpeed, 'y');
                p1.Fire(OutOfBoundsCheck());
            }
        }

        private void projectileCollision_Tick(object sender, EventArgs e) 
        {
            for (int i = 0; i < 55; i++) {
                if (playerProjectile.Bounds.IntersectsWith(AlienPBList[i].Bounds) && (AlienList[i].GetState() == 1) && p1.IsFired()) { 
                    playerProjectile.Visible = playerProj.SetVisibility(false); 
                    p1.Fire(false); 
                    KillAlien(ref i);
                }
                foreach (var block in BaseBlockList.Where(block => block.Visible)) {
                    if (AlienPBList[i].Visible && AlienPBList[i].Bounds.IntersectsWith(block.Bounds))
                        block.Visible = false;
                }
            }

            
            foreach (var item in AlienProjectileList) {
                if (item.Bounds.IntersectsWith(player.Bounds)) { 
                    item.Enabled = false;
                    item.Visible = false;
                    item.Location = new Point(0, 0);
                    KillPlayer();
                    --totalProjectiles;
                }
                if (item.Location.Y > 860) { 
                    item.Enabled = false;
                    item.Visible = false;
                    item.Location = new Point(0, 0);
                    --totalProjectiles;
                }
            }

            
            if (playerProjectile.Visible || alienProjectile1.Visible || alienProjectile2.Visible || alienProjectile3.Visible) 
            {
                foreach (var item in BaseBlockList.Where(item => item.Visible)) {
                    if (playerProjectileGhost.Bounds.IntersectsWith(item.Bounds)) {
                        item.Visible = false;
                        playerProjectile.Visible = playerProj.SetVisibility(false);
                        p1.Fire(false);
                    }

                    for (int i = 0; i < AlienProjectileList.Count; i++) {
                        if (AlienProjectileList[i].Enabled &&
                            AlienProjectileGhostList[i].Bounds.IntersectsWith(item.Bounds)) {
                            item.Visible = false;
                            AlienProjectileList[i].Enabled = false;
                            AlienProjectileList[i].Visible = false;
                            AlienProjectileList[i].Location = new Point(0, 0);
                            --totalProjectiles;
                        }
                    }
                }
            }

            
            for (int i = 0; i < AlienProjectileList.Count; i++) {
                if (AlienProjectileList[i].Enabled) {
                    AlienProjectileList[i].Location = new Point(AlienProjectileList[i].Location.X, AlienProjectileList[i].Location.Y + (projectileSpeed));
                    AlienProjectileGhostList[i].Location = new Point(AlienProjectileList[i].Location.X - projectileGhostOffset, AlienProjectileList[i].Location.Y + (projectileSpeed));
                }

            }
        }

        private void objectDeath_Tick(object sender, EventArgs e) 
        {
            switch (deathType) {
                case 0: { 
                        ++deathTimer;
                        if (deathTimer == 10) { 
                            for (int i = 0; i < 55; i++) { 
                                if (AlienList[i].GetState() == 0) { 
                                    AlienPBList[i].Visible = false; 
                                    objectDeath.Enabled = false; 
                                }
                            }
                            deathTimer = 0;
                            objectDeath.Enabled = false; 
                        }
                        break;
                    }
                case 1: { 
                        ++deathTimer;
                        alienMovement.Enabled = false; 
                        playerMovement.Enabled = false;
                        projectileCollision.Enabled = false;
                        projectileAnimation.Enabled = false;
                        if (deathCycle <= 10) { 
                            if (deathTimer == 10 && deathAnimation) {
                                player.Image = Image.FromFile("resources/textures/PlayerDeath_1.png");
                                ++deathCycle;
                                deathAnimation = false;
                                deathTimer = 0;
                            }
                            else if (deathTimer == 10 && !deathAnimation) {
                                player.Image = Image.FromFile("resources/textures/PlayerDeath_2.png");
                                ++deathCycle;
                                deathAnimation = true;
                                deathTimer = 0;
                            }
                        }
                        if (deathCycle == 11 && p1.GetLives() >= 0) { 
                            deathCycle = 0; 
                            alienMovement.Enabled = true; 
                            playerMovement.Enabled = true;
                            projectileCollision.Enabled = true;
                            projectileAnimation.Enabled = true;
                            player.Image = Image.FromFile("resources/textures/PlayerShip.png");
                            player.Location = new Point(355, 824); 
                            p1.SetPos(player.Location);
                            deathTimer = 0; 
                            objectDeath.Enabled = false; 
                        }
                        break;
                    }
            }
        }

        private void projectileAnimation_Tick(object sender, EventArgs e) 
        {
            if (projectileTick < 10) {
                alienProjectile1.Image = Image.FromFile("resources/textures/AlienProjectile1_1.png");
                alienProjectile2.Image = Image.FromFile("resources/textures/AlienProjectile2_1.png");
                alienProjectile3.Image = Image.FromFile("resources/textures/AlienProjectile3_1.png");

            }
            else if (projectileTick > 10 && projectileTick < 20) {
                alienProjectile1.Image = Image.FromFile("resources/textures/AlienProjectile1_2.png");
                alienProjectile2.Image = Image.FromFile("resources/textures/AlienProjectile2_2.png");
                alienProjectile3.Image = Image.FromFile("resources/textures/AlienProjectile3_2.png");
            }
            else if (projectileTick > 20 && projectileTick < 30) {
                alienProjectile1.Image = Image.FromFile("resources/textures/AlienProjectile1_3.png");
                alienProjectile2.Image = Image.FromFile("resources/textures/AlienProjectile2_3.png");
                alienProjectile3.Image = Image.FromFile("resources/textures/AlienProjectile3_3.png");

            }
            else if (projectileTick > 30 && projectileTick < 40) {
                alienProjectile1.Image = Image.FromFile("resources/textures/AlienProjectile1_4.png");
                alienProjectile2.Image = Image.FromFile("resources/textures/AlienProjectile2_4.png");
                alienProjectile3.Image = Image.FromFile("resources/textures/AlienProjectile3_4.png");
            }
            if (projectileTick >= 40) {
                projectileTick = 0;
            }
            ++projectileTick;
        }

        private bool OutOfBoundsCheck() 
        {
            
            if (playerProj.GetPos('y') < 67) {
                playerProjectile.Visible = playerProj.SetVisibility(false);
                return false;
            }
            else {
                return true;
            }
        }

        private void InitializeAliens() 
        {
            #region Create and add Alien objects to list
            AlienList.Add(new Enemy(3, pbAlien1.Image, pbAlien1.Location.X, pbAlien1.Location.Y));
            AlienList.Add(new Enemy(3, pbAlien2.Image, pbAlien2.Location.X, pbAlien2.Location.Y));
            AlienList.Add(new Enemy(3, pbAlien3.Image, pbAlien3.Location.X, pbAlien3.Location.Y));
            AlienList.Add(new Enemy(3, pbAlien4.Image, pbAlien4.Location.X, pbAlien4.Location.Y));
            AlienList.Add(new Enemy(3, pbAlien5.Image, pbAlien5.Location.X, pbAlien5.Location.Y));
            AlienList.Add(new Enemy(3, pbAlien6.Image, pbAlien6.Location.X, pbAlien6.Location.Y));
            AlienList.Add(new Enemy(3, pbAlien7.Image, pbAlien7.Location.X, pbAlien7.Location.Y));
            AlienList.Add(new Enemy(3, pbAlien8.Image, pbAlien8.Location.X, pbAlien8.Location.Y));
            AlienList.Add(new Enemy(3, pbAlien9.Image, pbAlien9.Location.X, pbAlien9.Location.Y));
            AlienList.Add(new Enemy(3, pbAlien10.Image, pbAlien10.Location.X, pbAlien10.Location.Y));
            AlienList.Add(new Enemy(3, pbAlien11.Image, pbAlien11.Location.X, pbAlien11.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien12.Image, pbAlien12.Location.X, pbAlien12.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien13.Image, pbAlien13.Location.X, pbAlien13.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien14.Image, pbAlien14.Location.X, pbAlien14.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien15.Image, pbAlien15.Location.X, pbAlien15.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien16.Image, pbAlien16.Location.X, pbAlien16.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien17.Image, pbAlien17.Location.X, pbAlien17.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien18.Image, pbAlien18.Location.X, pbAlien18.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien19.Image, pbAlien19.Location.X, pbAlien19.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien20.Image, pbAlien20.Location.X, pbAlien20.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien21.Image, pbAlien21.Location.X, pbAlien21.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien22.Image, pbAlien22.Location.X, pbAlien22.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien23.Image, pbAlien23.Location.X, pbAlien23.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien24.Image, pbAlien24.Location.X, pbAlien24.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien25.Image, pbAlien25.Location.X, pbAlien25.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien26.Image, pbAlien26.Location.X, pbAlien26.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien27.Image, pbAlien27.Location.X, pbAlien27.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien28.Image, pbAlien28.Location.X, pbAlien28.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien29.Image, pbAlien29.Location.X, pbAlien29.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien30.Image, pbAlien30.Location.X, pbAlien30.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien31.Image, pbAlien31.Location.X, pbAlien31.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien32.Image, pbAlien32.Location.X, pbAlien32.Location.Y));
            AlienList.Add(new Enemy(2, pbAlien33.Image, pbAlien33.Location.X, pbAlien33.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien34.Image, pbAlien34.Location.X, pbAlien34.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien35.Image, pbAlien35.Location.X, pbAlien35.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien36.Image, pbAlien36.Location.X, pbAlien36.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien37.Image, pbAlien37.Location.X, pbAlien37.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien38.Image, pbAlien38.Location.X, pbAlien38.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien39.Image, pbAlien39.Location.X, pbAlien39.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien40.Image, pbAlien40.Location.X, pbAlien40.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien41.Image, pbAlien41.Location.X, pbAlien41.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien42.Image, pbAlien42.Location.X, pbAlien42.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien43.Image, pbAlien43.Location.X, pbAlien43.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien44.Image, pbAlien44.Location.X, pbAlien44.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien45.Image, pbAlien45.Location.X, pbAlien45.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien46.Image, pbAlien46.Location.X, pbAlien46.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien47.Image, pbAlien47.Location.X, pbAlien47.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien48.Image, pbAlien48.Location.X, pbAlien48.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien49.Image, pbAlien49.Location.X, pbAlien49.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien50.Image, pbAlien50.Location.X, pbAlien50.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien51.Image, pbAlien51.Location.X, pbAlien51.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien52.Image, pbAlien52.Location.X, pbAlien52.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien53.Image, pbAlien53.Location.X, pbAlien53.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien54.Image, pbAlien54.Location.X, pbAlien54.Location.Y));
            AlienList.Add(new Enemy(1, pbAlien55.Image, pbAlien55.Location.X, pbAlien55.Location.Y));
            #endregion

            #region Add pictureboxes to list
            AlienPBList.Add(pbAlien1);
            AlienPBList.Add(pbAlien2);
            AlienPBList.Add(pbAlien3);
            AlienPBList.Add(pbAlien4);
            AlienPBList.Add(pbAlien5);
            AlienPBList.Add(pbAlien6);
            AlienPBList.Add(pbAlien7);
            AlienPBList.Add(pbAlien8);
            AlienPBList.Add(pbAlien9);
            AlienPBList.Add(pbAlien10);
            AlienPBList.Add(pbAlien11);
            AlienPBList.Add(pbAlien12);
            AlienPBList.Add(pbAlien13);
            AlienPBList.Add(pbAlien14);
            AlienPBList.Add(pbAlien15);
            AlienPBList.Add(pbAlien16);
            AlienPBList.Add(pbAlien17);
            AlienPBList.Add(pbAlien18);
            AlienPBList.Add(pbAlien19);
            AlienPBList.Add(pbAlien20);
            AlienPBList.Add(pbAlien21);
            AlienPBList.Add(pbAlien22);
            AlienPBList.Add(pbAlien23);
            AlienPBList.Add(pbAlien24);
            AlienPBList.Add(pbAlien25);
            AlienPBList.Add(pbAlien26);
            AlienPBList.Add(pbAlien27);
            AlienPBList.Add(pbAlien28);
            AlienPBList.Add(pbAlien29);
            AlienPBList.Add(pbAlien30);
            AlienPBList.Add(pbAlien31);
            AlienPBList.Add(pbAlien32);
            AlienPBList.Add(pbAlien33);
            AlienPBList.Add(pbAlien34);
            AlienPBList.Add(pbAlien35);
            AlienPBList.Add(pbAlien36);
            AlienPBList.Add(pbAlien37);
            AlienPBList.Add(pbAlien38);
            AlienPBList.Add(pbAlien39);
            AlienPBList.Add(pbAlien40);
            AlienPBList.Add(pbAlien41);
            AlienPBList.Add(pbAlien42);
            AlienPBList.Add(pbAlien43);
            AlienPBList.Add(pbAlien44);
            AlienPBList.Add(pbAlien45);
            AlienPBList.Add(pbAlien46);
            AlienPBList.Add(pbAlien47);
            AlienPBList.Add(pbAlien48);
            AlienPBList.Add(pbAlien49);
            AlienPBList.Add(pbAlien50);
            AlienPBList.Add(pbAlien51);
            AlienPBList.Add(pbAlien52);
            AlienPBList.Add(pbAlien53);
            AlienPBList.Add(pbAlien54);
            AlienPBList.Add(pbAlien55);
            #endregion

            #region Add each individual block of each of the four bases to a list for hit detection
            BaseBlockList.Add(pbBlock1);
            BaseBlockList.Add(pbBlock2);
            BaseBlockList.Add(pbBlock3);
            BaseBlockList.Add(pbBlock4);
            BaseBlockList.Add(pbBlock5);
            BaseBlockList.Add(pbBlock6);
            BaseBlockList.Add(pbBlock7);
            BaseBlockList.Add(pbBlock8);
            BaseBlockList.Add(pbBlock9);
            BaseBlockList.Add(pbBlock10);
            BaseBlockList.Add(pbBlock12);
            BaseBlockList.Add(pbBlock13);
            BaseBlockList.Add(pbBlock14);
            BaseBlockList.Add(pbBlock15);
            BaseBlockList.Add(pbBlock16);
            BaseBlockList.Add(pbBlock17);
            BaseBlockList.Add(pbBlock18);
            BaseBlockList.Add(pbBlock19);
            BaseBlockList.Add(pbBlock20);
            BaseBlockList.Add(pbBlock21);
            BaseBlockList.Add(pbBlock22);
            BaseBlockList.Add(pbBlock23);
            BaseBlockList.Add(pbBlock24);
            BaseBlockList.Add(pbBlock25);
            BaseBlockList.Add(pbBlock27);
            BaseBlockList.Add(pbBlock28);
            BaseBlockList.Add(pbBlock29);
            BaseBlockList.Add(pbBlock30);
            BaseBlockList.Add(pbBlock31);
            BaseBlockList.Add(pbBlock32);
            BaseBlockList.Add(pbBlock33);
            BaseBlockList.Add(pbBlock34);
            BaseBlockList.Add(pbBlock35);
            BaseBlockList.Add(pbBlock36);
            BaseBlockList.Add(pbBlock37);
            BaseBlockList.Add(pbBlock38);
            BaseBlockList.Add(pbBlock39);
            BaseBlockList.Add(pbBlock40);
            BaseBlockList.Add(pbBlock42);
            BaseBlockList.Add(pbBlock43);
            BaseBlockList.Add(pbBlock44);
            BaseBlockList.Add(pbBlock45);
            BaseBlockList.Add(pbBlock46);
            BaseBlockList.Add(pbBlock47);
            BaseBlockList.Add(pbBlock48);
            BaseBlockList.Add(pbBlock49);
            BaseBlockList.Add(pbBlock50);
            BaseBlockList.Add(pbBlock51);
            BaseBlockList.Add(pbBlock52);
            BaseBlockList.Add(pbBlock53);
            BaseBlockList.Add(pbBlock54);
            BaseBlockList.Add(pbBlock55);
            BaseBlockList.Add(pbBlock57);
            BaseBlockList.Add(pbBlock58);
            BaseBlockList.Add(pbBlock59);
            BaseBlockList.Add(pbBlock60);
            BaseBlockList.Add(pbBlock61);
            BaseBlockList.Add(pbBlock62);
            BaseBlockList.Add(pbBlock63);
            BaseBlockList.Add(pbBlock64);
            BaseBlockList.Add(pbBlock65);
            BaseBlockList.Add(pbBlock66);
            BaseBlockList.Add(pbBlock67);
            BaseBlockList.Add(pbBlock68);
            #endregion

            #region Add three potential and their ghosts alien projectiles to a list
            AlienProjectileList.Add(alienProjectile1);
            AlienProjectileList.Add(alienProjectile2);
            AlienProjectileList.Add(alienProjectile3);
            AlienProjectileGhostList.Add(alienProjectile1Ghost);
            AlienProjectileGhostList.Add(alienProjectile2Ghost);
            AlienProjectileGhostList.Add(alienProjectile3Ghost);
            #endregion

            
            for (int i = 1; i < 12; i++)
                BottomAliens.Add(AlienList[AlienList.Count - i]);
        }

        private void UpdateAliens() 
        {
            #region Alien Animation
            switch (alienAnimation) {
                case 0: {
                        foreach (var item in AlienList) {
                            if (item.GetAlienType() == 1)
                                item.SetImage(Image.FromFile("resources/textures/Alien1_2.png"));
                            if (item.GetAlienType() == 2)
                                item.SetImage(Image.FromFile("resources/textures/Alien2_2.png"));
                            if (item.GetAlienType() == 3)
                                item.SetImage(Image.FromFile("resources/textures/Alien3_2.png"));
                        }
                        ++alienAnimation;
                        break;
                    }
                case 1: {
                        foreach (var item in AlienList) {
                            if (item.GetAlienType() == 1)
                                item.SetImage(Image.FromFile("resources/textures/Alien1_1.png"));
                            if (item.GetAlienType() == 2)
                                item.SetImage(Image.FromFile("resources/textures/Alien2_1.png"));
                            if (item.GetAlienType() == 3)
                                item.SetImage(Image.FromFile("resources/textures/Alien3_1.png"));
                        }
                        --alienAnimation;
                        break;
                    }
            }

            
            for (int i = 0; i < 55; i++) {
                if (AlienList[i].GetState() == 1) {
                    AlienPBList[i].Image = AlienList[i].GetImage();
                }
            }
            #endregion
            #region Alien Movement
            bool noneEdge = true; 

            foreach (var item in AlienPBList) { 
                if (item.Location.X > this.Width - rightSideDifference && item.Visible == true) 
                {
                    noneEdge = false;
                    break;
                }

                if (item.Location.X >= 20 || !item.Visible) continue;
                noneEdge = false;
                break;
            }

            if (noneEdge) { 
                if (isGoingRight) 
                    foreach (var item in AlienPBList.Where(item => item.Visible))
                        item.Location = new Point(item.Location.X + AlienPushX, item.Location.Y);
                else 
                    foreach (var item in AlienPBList.Where(item => item.Visible))
                        item.Location = new Point(item.Location.X - AlienPushX, item.Location.Y);
            }
            else { 
                if (isGoingRight) {
                    foreach (var item in AlienPBList.Where(item => item.Visible))
                        item.Location = new Point(item.Location.X - 10, item.Location.Y + AlienPushY);
                    isGoingRight = false;
                }
                else {
                    foreach (var item in AlienPBList.Where(item => item.Visible))
                        item.Location = new Point(item.Location.X + 10, item.Location.Y + AlienPushY);
                    isGoingRight = true;
                }
            }
            #endregion
            #region Update Alien Position
            for (int i = 0; i < AlienList.Count; i++) {
                AlienList[i].SetXCord(AlienPBList[i].Location.X);
                AlienList[i].SetYCord(AlienPBList[i].Location.Y);
            }
            #endregion
        }

        private void PlaySound(int input) 
        {
            if (musicToggle) {
                var sp = new System.Windows.Media.MediaPlayer();
                switch (input) {
                    case 1 when soundStep == 1: { 
                            var path = Path.Combine(Directory.GetCurrentDirectory(), "resources/sounds/tick1.wav");
                            sp.Open(new Uri(path));
                            sp.Play();
                            ++soundStep;
                            break;
                        }
                    case 1 when soundStep == 2: { 
                            var path = Path.Combine(Directory.GetCurrentDirectory(), "resources/sounds/tick2.wav");
                            sp.Open(new Uri(path));
                            sp.Play();
                            ++soundStep;
                            break;
                        }
                    case 1 when soundStep == 3: { 
                            var path = Path.Combine(Directory.GetCurrentDirectory(), "resources/sounds/tick3.wav");
                            sp.Open(new Uri(path));
                            sp.Play();
                            ++soundStep;
                            break;
                        }
                    case 1 when soundStep == 4: {
                            var path = Path.Combine(Directory.GetCurrentDirectory(), "resources/sounds/tick4.wav");
                            sp.Open(new Uri(path));
                            sp.Play();
                            soundStep = 1;
                            break;
                        }
                    case 2: {

                            var path = Path.Combine(Directory.GetCurrentDirectory(), "resources/sounds/alienDeath.wav");
                            sp.Open(new Uri(path));
                            sp.Play();
                            break;
                        }
                    case 3: { 
                            var path = Path.Combine(Directory.GetCurrentDirectory(), "resources/sounds/playerShoot.wav");
                            sp.Open(new Uri(path));
                            sp.Play();
                            break;
                        }
                    case 4: { 
                            var path = Path.Combine(Directory.GetCurrentDirectory(), "resources/sounds/playerDeath.wav");
                            sp.Open(new Uri(path));
                            sp.Play();
                            break;
                        }
                }
            }
        }

        private void KillPlayer() 
        {
            PlaySound(4);
            Thread.Sleep(10); 
            p1.LoseLife();
            deathType = 1;
            deathCycle = 0;
            objectDeath.Enabled = true;
        }

        private void KillAlien(ref int i) 
        {
            AlienList[i].SetState(0); 
            AlienPBList[i].Image = Image.FromFile("resources/textures/AlienDeath.png"); 
            speedMultiplier *= 1.02; 
            PlaySound(2); 
            UpdateScore(ref i);
            --numAliensLeft;
            deathType = 0;
            objectDeath.Enabled = true;

            if (i - 11 > -1) {
                for (int j = i; j > -1; j -= 10) {
                    if (AlienList[j].GetState() == 1) {
                        BottomAliens[j % 11] = AlienList[i - 11];
                        break;
                    }
                }
            }
        }

        private void CheckEndGame() 
        {
            if (numAliensLeft == 0) {
                alienMovement.Enabled = false;
                playerMovement.Enabled = false;
                projectileCollision.Enabled = false;
                Thread.Sleep(1000);
                GameForm NewForm = new GameForm(); 
                NewForm.p1.SetLives(p1.GetLives());
                NewForm.score = score;
                NewForm.playerScore.Text = playerScore.Text;
                NewForm.Show();
                Dispose(false);
            }
            
            foreach (var item in AlienPBList) {
                if (item.Location.Y > 720 && item.Visible == true) {
                    player.Visible = false;
                    DisableAllTimers();
                    foreach (var item2 in AlienPBList)
                        item2.Visible = false;
                    foreach (var item2 in AlienProjectileList)
                        item2.Visible = false;
                    playerProjectile.Visible = false;
                    gameOver.Visible = true;
                    UpdateHighScore();
                }
            }
            
            switch (p1.GetLives()) {
                case 2: {
                        livesCounter.Image = Image.FromFile("resources/textures/2.png");
                        lifeTwo.Visible = false;
                        break;
                    }
                case 1: {
                        livesCounter.Image = Image.FromFile("resources/textures/2.png");
                        lifeTwo.Visible = false;
                        livesCounter.Image = Image.FromFile("resources/textures/1.png");
                        lifeThree.Visible = false;
                        break;
                    }
                case 0: { 
                        livesCounter.Image = Image.FromFile("resources/textures/0.png");
                        player.Visible = false;
                        DisableAllTimers();
                        foreach (var item2 in AlienPBList)
                            item2.Visible = false;
                        foreach (var item2 in AlienProjectileList)
                            item2.Visible = false;
                        musicToggle = false;
                        playerProjectile.Visible = false;
                        gameOver.Visible = true;
                        UpdateHighScore();
                        break;
                    }
            }
        }

        private void TryShoot() 
        {
            foreach (var alien in BottomAliens) {
                if ((alien.GetState() == 1) && totalProjectiles <= 3) { 
                    int rand = RandomNum.Next(0, numAliensLeft);
                    if (rand == 1) {
                        int randAlien = RandomNum.Next(0, BottomAliens.Count); 
                        while (BottomAliens[randAlien].GetState() == 0 && numAliensLeft > 0) 
                            randAlien = RandomNum.Next(0, BottomAliens.Count);
                        foreach (var item in AlienProjectileList) {
                            if (item.Enabled == false) {
                                item.Location = new Point(BottomAliens[randAlien].GetXCord(), BottomAliens[randAlien].GetYCord());
                                item.Enabled = true;
                                item.Visible = true;
                                ++totalProjectiles;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void UpdateScore(ref int i)
        {
            switch ((AlienList[i].GetAlienType())) {
                case 1: {
                        playerScore.Text = ($"{score += 10}"); 
                        break;
                    }
                case 2: {
                        playerScore.Text = ($"{score += 20}"); 
                        break;
                    }
                case 3: {
                        playerScore.Text = ($"{score += 30}"); 
                        break;
                    }
            }
        }

        private void UpdateHighScore() 
        {
            using (StreamWriter fileWrite = new StreamWriter(fileName)) {
                int itemCounter = 0;
                int tempHolder = Convert.ToInt32(scores[2]);
                foreach (string Item in scores) {
                    if (score > Convert.ToInt32(Item)) {
                        tempHolder = Convert.ToInt32(scores[itemCounter]);
                        scores[itemCounter] = score.ToString();
                        break;
                    }
                    itemCounter++;
                }
                for (int i = itemCounter + 1; i < 2; i++) {
                    if (itemCounter == i - 1)
                        scores[i] = tempHolder.ToString();
                    else
                        scores[i] = scores[i - 1];
                }
                fileWrite.WriteLine(scores[0]);
                fileWrite.WriteLine(scores[1]);
                fileWrite.WriteLine(scores[2]);
            }
        }

        private void UseCustomFont()
        {
            PrivateFontCollection customFont = new PrivateFontCollection();

            customFont.AddFontFile("SpaceInvadersFont.ttf");

            scoreText.Font = new Font(customFont.Families[0], 20);

            playerScore.Font = new Font(customFont.Families[0], 20);

            btnControls.Font = new Font(customFont.Families[0], 12);
        }

        private void DisableAllTimers()
        {
            alienMovement.Enabled = false;
            playerMovement.Enabled = false;
            projectileCollision.Enabled = false;
            projectileAnimation.Enabled = false;
        }

        private void EnableAllTimers()
        {
            alienMovement.Enabled = true;
            playerMovement.Enabled = true;
            projectileCollision.Enabled = true;
            projectileAnimation.Enabled = true;
        }
    }
}
