﻿namespace SpaceInvaders {
    partial class GameForm {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.alienMovement = new System.Windows.Forms.Timer(this.components);
            this.playerMovement = new System.Windows.Forms.Timer(this.components);
            this.playerScore = new System.Windows.Forms.Label();
            this.projectileCollision = new System.Windows.Forms.Timer(this.components);
            this.objectDeath = new System.Windows.Forms.Timer(this.components);
            this.projectileAnimation = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.alienProjectile1Ghost = new System.Windows.Forms.PictureBox();
            this.alienProjectile2Ghost = new System.Windows.Forms.PictureBox();
            this.alienProjectile3Ghost = new System.Windows.Forms.PictureBox();
            this.playerProjectileGhost = new System.Windows.Forms.PictureBox();
            this.bottomBoundsBox = new System.Windows.Forms.PictureBox();
            this.lifeTwo = new System.Windows.Forms.PictureBox();
            this.lifeThree = new System.Windows.Forms.PictureBox();
            this.livesCounter = new System.Windows.Forms.PictureBox();
            this.pbAlien46 = new System.Windows.Forms.PictureBox();
            this.pbAlien47 = new System.Windows.Forms.PictureBox();
            this.pbAlien48 = new System.Windows.Forms.PictureBox();
            this.pbAlien49 = new System.Windows.Forms.PictureBox();
            this.pbAlien53 = new System.Windows.Forms.PictureBox();
            this.pbAlien52 = new System.Windows.Forms.PictureBox();
            this.pbAlien55 = new System.Windows.Forms.PictureBox();
            this.pbAlien54 = new System.Windows.Forms.PictureBox();
            this.pbAlien51 = new System.Windows.Forms.PictureBox();
            this.pbAlien50 = new System.Windows.Forms.PictureBox();
            this.pbAlien45 = new System.Windows.Forms.PictureBox();
            this.pbAlien35 = new System.Windows.Forms.PictureBox();
            this.pbAlien36 = new System.Windows.Forms.PictureBox();
            this.pbAlien37 = new System.Windows.Forms.PictureBox();
            this.pbAlien38 = new System.Windows.Forms.PictureBox();
            this.pbAlien42 = new System.Windows.Forms.PictureBox();
            this.pbAlien41 = new System.Windows.Forms.PictureBox();
            this.pbAlien44 = new System.Windows.Forms.PictureBox();
            this.pbAlien43 = new System.Windows.Forms.PictureBox();
            this.pbAlien40 = new System.Windows.Forms.PictureBox();
            this.pbAlien39 = new System.Windows.Forms.PictureBox();
            this.pbAlien34 = new System.Windows.Forms.PictureBox();
            this.pbAlien24 = new System.Windows.Forms.PictureBox();
            this.pbAlien25 = new System.Windows.Forms.PictureBox();
            this.pbAlien26 = new System.Windows.Forms.PictureBox();
            this.pbAlien27 = new System.Windows.Forms.PictureBox();
            this.pbAlien31 = new System.Windows.Forms.PictureBox();
            this.pbAlien30 = new System.Windows.Forms.PictureBox();
            this.pbAlien33 = new System.Windows.Forms.PictureBox();
            this.pbAlien32 = new System.Windows.Forms.PictureBox();
            this.pbAlien29 = new System.Windows.Forms.PictureBox();
            this.pbAlien28 = new System.Windows.Forms.PictureBox();
            this.pbAlien23 = new System.Windows.Forms.PictureBox();
            this.pbAlien13 = new System.Windows.Forms.PictureBox();
            this.pbAlien14 = new System.Windows.Forms.PictureBox();
            this.pbAlien15 = new System.Windows.Forms.PictureBox();
            this.pbAlien16 = new System.Windows.Forms.PictureBox();
            this.pbAlien20 = new System.Windows.Forms.PictureBox();
            this.pbAlien19 = new System.Windows.Forms.PictureBox();
            this.pbAlien22 = new System.Windows.Forms.PictureBox();
            this.pbAlien21 = new System.Windows.Forms.PictureBox();
            this.pbAlien18 = new System.Windows.Forms.PictureBox();
            this.pbAlien17 = new System.Windows.Forms.PictureBox();
            this.pbAlien12 = new System.Windows.Forms.PictureBox();
            this.pbAlien2 = new System.Windows.Forms.PictureBox();
            this.pbAlien3 = new System.Windows.Forms.PictureBox();
            this.pbAlien4 = new System.Windows.Forms.PictureBox();
            this.pbAlien5 = new System.Windows.Forms.PictureBox();
            this.pbAlien9 = new System.Windows.Forms.PictureBox();
            this.pbAlien8 = new System.Windows.Forms.PictureBox();
            this.pbAlien11 = new System.Windows.Forms.PictureBox();
            this.pbAlien10 = new System.Windows.Forms.PictureBox();
            this.pbAlien7 = new System.Windows.Forms.PictureBox();
            this.pbAlien6 = new System.Windows.Forms.PictureBox();
            this.pbAlien1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.playerProjectile = new System.Windows.Forms.PictureBox();
            this.alienProjectile1 = new System.Windows.Forms.PictureBox();
            this.alienProjectile2 = new System.Windows.Forms.PictureBox();
            this.alienProjectile3 = new System.Windows.Forms.PictureBox();
            this.btnControls = new System.Windows.Forms.Button();
            this.gameOver = new System.Windows.Forms.PictureBox();
            this.pbBlock14 = new System.Windows.Forms.PictureBox();
            this.pbBlock9 = new System.Windows.Forms.PictureBox();
            this.pbBlock4 = new System.Windows.Forms.PictureBox();
            this.pbBlock10 = new System.Windows.Forms.PictureBox();
            this.pbBlock5 = new System.Windows.Forms.PictureBox();
            this.pbBlock1 = new System.Windows.Forms.PictureBox();
            this.pbBlock6 = new System.Windows.Forms.PictureBox();
            this.pbBlock2 = new System.Windows.Forms.PictureBox();
            this.pbBlock12 = new System.Windows.Forms.PictureBox();
            this.pbBlock7 = new System.Windows.Forms.PictureBox();
            this.pbBlock3 = new System.Windows.Forms.PictureBox();
            this.pbBlock15 = new System.Windows.Forms.PictureBox();
            this.pbBlock13 = new System.Windows.Forms.PictureBox();
            this.pbBlock8 = new System.Windows.Forms.PictureBox();
            this.pbBlock29 = new System.Windows.Forms.PictureBox();
            this.pbBlock24 = new System.Windows.Forms.PictureBox();
            this.pbBlock19 = new System.Windows.Forms.PictureBox();
            this.pbBlock25 = new System.Windows.Forms.PictureBox();
            this.pbBlock20 = new System.Windows.Forms.PictureBox();
            this.pbBlock16 = new System.Windows.Forms.PictureBox();
            this.pbBlock21 = new System.Windows.Forms.PictureBox();
            this.pbBlock17 = new System.Windows.Forms.PictureBox();
            this.pbBlock27 = new System.Windows.Forms.PictureBox();
            this.pbBlock22 = new System.Windows.Forms.PictureBox();
            this.pbBlock18 = new System.Windows.Forms.PictureBox();
            this.pbBlock30 = new System.Windows.Forms.PictureBox();
            this.pbBlock28 = new System.Windows.Forms.PictureBox();
            this.pbBlock23 = new System.Windows.Forms.PictureBox();
            this.pbBlock59 = new System.Windows.Forms.PictureBox();
            this.pbBlock54 = new System.Windows.Forms.PictureBox();
            this.pbBlock49 = new System.Windows.Forms.PictureBox();
            this.pbBlock55 = new System.Windows.Forms.PictureBox();
            this.pbBlock50 = new System.Windows.Forms.PictureBox();
            this.pbBlock46 = new System.Windows.Forms.PictureBox();
            this.pbBlock51 = new System.Windows.Forms.PictureBox();
            this.pbBlock47 = new System.Windows.Forms.PictureBox();
            this.pbBlock57 = new System.Windows.Forms.PictureBox();
            this.pbBlock52 = new System.Windows.Forms.PictureBox();
            this.pbBlock48 = new System.Windows.Forms.PictureBox();
            this.pbBlock60 = new System.Windows.Forms.PictureBox();
            this.pbBlock58 = new System.Windows.Forms.PictureBox();
            this.pbBlock53 = new System.Windows.Forms.PictureBox();
            this.pbBlock44 = new System.Windows.Forms.PictureBox();
            this.pbBlock39 = new System.Windows.Forms.PictureBox();
            this.pbBlock34 = new System.Windows.Forms.PictureBox();
            this.pbBlock40 = new System.Windows.Forms.PictureBox();
            this.pbBlock35 = new System.Windows.Forms.PictureBox();
            this.pbBlock31 = new System.Windows.Forms.PictureBox();
            this.pbBlock36 = new System.Windows.Forms.PictureBox();
            this.pbBlock32 = new System.Windows.Forms.PictureBox();
            this.pbBlock42 = new System.Windows.Forms.PictureBox();
            this.pbBlock37 = new System.Windows.Forms.PictureBox();
            this.pbBlock33 = new System.Windows.Forms.PictureBox();
            this.pbBlock45 = new System.Windows.Forms.PictureBox();
            this.pbBlock43 = new System.Windows.Forms.PictureBox();
            this.pbBlock38 = new System.Windows.Forms.PictureBox();
            this.alienBoundsPanel = new System.Windows.Forms.Panel();
            this.pbBlock68 = new System.Windows.Forms.PictureBox();
            this.pbBlock65 = new System.Windows.Forms.PictureBox();
            this.pbBlock63 = new System.Windows.Forms.PictureBox();
            this.pbBlock66 = new System.Windows.Forms.PictureBox();
            this.pbBlock67 = new System.Windows.Forms.PictureBox();
            this.pbBlock64 = new System.Windows.Forms.PictureBox();
            this.pbBlock62 = new System.Windows.Forms.PictureBox();
            this.pbBlock61 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.alienProjectile1Ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienProjectile2Ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienProjectile3Ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerProjectileGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBoundsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livesCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerProjectile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienProjectile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienProjectile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienProjectile3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock38)).BeginInit();
            this.alienBoundsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock61)).BeginInit();
            this.SuspendLayout();
            // 
            // EnemyMovement
            // 
            this.alienMovement.Enabled = true;
            this.alienMovement.Interval = 50;
            this.alienMovement.Tick += new System.EventHandler(this.alienMovement_Tick);
            // 
            // playerMovement
            // 
            this.playerMovement.Enabled = true;
            this.playerMovement.Interval = 1;
            this.playerMovement.Tick += new System.EventHandler(this.playerMovement_Tick);
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.ForeColor = System.Drawing.SystemColors.Control;
            this.playerScore.Location = new System.Drawing.Point(175, 30);
            this.playerScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(36, 39);
            this.playerScore.TabIndex = 5;
            this.playerScore.Text = "0";
            // 
            // BulletCollision
            // 
            this.projectileCollision.Enabled = true;
            this.projectileCollision.Interval = 1;
            this.projectileCollision.Tick += new System.EventHandler(this.projectileCollision_Tick);
            // 
            // objectDeath
            // 
            this.objectDeath.Interval = 10;
            this.objectDeath.Tick += new System.EventHandler(this.objectDeath_Tick);
            // 
            // BulletAnimation
            // 
            this.projectileAnimation.Enabled = true;
            this.projectileAnimation.Interval = 15;
            this.projectileAnimation.Tick += new System.EventHandler(this.projectileAnimation_Tick);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.SystemColors.Control;
            this.scoreText.Location = new System.Drawing.Point(28, 30);
            this.scoreText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(139, 39);
            this.scoreText.TabIndex = 83;
            this.scoreText.Text = "SCORE";
            // 
            // alienBulletGhost
            // 
            this.alienProjectile1Ghost.Image = ((System.Drawing.Image)(resources.GetObject("alienProjectile1Ghost.Image")));
            this.alienProjectile1Ghost.Location = new System.Drawing.Point(891, 1108);
            this.alienProjectile1Ghost.Margin = new System.Windows.Forms.Padding(4);
            this.alienProjectile1Ghost.Name = "alienProjectile1Ghost";
            this.alienProjectile1Ghost.Size = new System.Drawing.Size(16, 34);
            this.alienProjectile1Ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.alienProjectile1Ghost.TabIndex = 79;
            this.alienProjectile1Ghost.TabStop = false;
            this.alienProjectile1Ghost.Visible = false;
            // 
            // alienBulletGhost2
            // 
            this.alienProjectile2Ghost.Image = ((System.Drawing.Image)(resources.GetObject("alienProjectile2Ghost.Image")));
            this.alienProjectile2Ghost.Location = new System.Drawing.Point(867, 1108);
            this.alienProjectile2Ghost.Margin = new System.Windows.Forms.Padding(4);
            this.alienProjectile2Ghost.Name = "alienProjectile2Ghost";
            this.alienProjectile2Ghost.Size = new System.Drawing.Size(16, 34);
            this.alienProjectile2Ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.alienProjectile2Ghost.TabIndex = 80;
            this.alienProjectile2Ghost.TabStop = false;
            this.alienProjectile2Ghost.Visible = false;
            // 
            // alienBulletGhost3
            // 
            this.alienProjectile3Ghost.Image = ((System.Drawing.Image)(resources.GetObject("alienProjectile3Ghost.Image")));
            this.alienProjectile3Ghost.Location = new System.Drawing.Point(843, 1108);
            this.alienProjectile3Ghost.Margin = new System.Windows.Forms.Padding(4);
            this.alienProjectile3Ghost.Name = "alienProjectile3Ghost";
            this.alienProjectile3Ghost.Size = new System.Drawing.Size(16, 34);
            this.alienProjectile3Ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.alienProjectile3Ghost.TabIndex = 81;
            this.alienProjectile3Ghost.TabStop = false;
            this.alienProjectile3Ghost.Visible = false;
            // 
            // playerBulletGhost
            // 
            this.playerProjectileGhost.Image = global::SpaceInvaders.Properties.Resources.PlayerProjectile;
            this.playerProjectileGhost.Location = new System.Drawing.Point(915, 1122);
            this.playerProjectileGhost.Margin = new System.Windows.Forms.Padding(4);
            this.playerProjectileGhost.Name = "playerProjectileGhost";
            this.playerProjectileGhost.Size = new System.Drawing.Size(5, 20);
            this.playerProjectileGhost.TabIndex = 78;
            this.playerProjectileGhost.TabStop = false;
            this.playerProjectileGhost.Visible = false;
            // 
            // bottomBoundsBox
            // 
            this.bottomBoundsBox.Image = ((System.Drawing.Image)(resources.GetObject("bottomBoundsBox.Image")));
            this.bottomBoundsBox.Location = new System.Drawing.Point(0, 1095);
            this.bottomBoundsBox.Margin = new System.Windows.Forms.Padding(4);
            this.bottomBoundsBox.Name = "bottomBoundsBox";
            this.bottomBoundsBox.Size = new System.Drawing.Size(1028, 2);
            this.bottomBoundsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomBoundsBox.TabIndex = 77;
            this.bottomBoundsBox.TabStop = false;
            // 
            // lifeTwo
            // 
            this.lifeTwo.Image = ((System.Drawing.Image)(resources.GetObject("lifeTwo.Image")));
            this.lifeTwo.Location = new System.Drawing.Point(141, 1103);
            this.lifeTwo.Margin = new System.Windows.Forms.Padding(4);
            this.lifeTwo.Name = "lifeTwo";
            this.lifeTwo.Size = new System.Drawing.Size(52, 32);
            this.lifeTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lifeTwo.TabIndex = 76;
            this.lifeTwo.TabStop = false;
            // 
            // lifeThree
            // 
            this.lifeThree.Image = ((System.Drawing.Image)(resources.GetObject("lifeThree.Image")));
            this.lifeThree.Location = new System.Drawing.Point(64, 1103);
            this.lifeThree.Margin = new System.Windows.Forms.Padding(4);
            this.lifeThree.Name = "lifeThree";
            this.lifeThree.Size = new System.Drawing.Size(52, 32);
            this.lifeThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lifeThree.TabIndex = 75;
            this.lifeThree.TabStop = false;
            // 
            // livesCounter
            // 
            this.livesCounter.Image = ((System.Drawing.Image)(resources.GetObject("livesCounter.Image")));
            this.livesCounter.Location = new System.Drawing.Point(0, 1108);
            this.livesCounter.Margin = new System.Windows.Forms.Padding(4);
            this.livesCounter.Name = "livesCounter";
            this.livesCounter.Size = new System.Drawing.Size(57, 34);
            this.livesCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.livesCounter.TabIndex = 74;
            this.livesCounter.TabStop = false;
            // 
            // pbEnemy46
            // 
            this.pbAlien46.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien46.Image")));
            this.pbAlien46.Location = new System.Drawing.Point(169, 373);
            this.pbAlien46.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien46.Name = "pbAlien46";
            this.pbAlien46.Size = new System.Drawing.Size(64, 39);
            this.pbAlien46.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien46.TabIndex = 67;
            this.pbAlien46.TabStop = false;
            // 
            // pbEnemy47
            // 
            this.pbAlien47.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien47.Image")));
            this.pbAlien47.Location = new System.Drawing.Point(247, 373);
            this.pbAlien47.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien47.Name = "pbAlien47";
            this.pbAlien47.Size = new System.Drawing.Size(64, 39);
            this.pbAlien47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien47.TabIndex = 66;
            this.pbAlien47.TabStop = false;
            // 
            // pbEnemy48
            // 
            this.pbAlien48.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien48.Image")));
            this.pbAlien48.Location = new System.Drawing.Point(324, 373);
            this.pbAlien48.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien48.Name = "pbAlien48";
            this.pbAlien48.Size = new System.Drawing.Size(64, 39);
            this.pbAlien48.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien48.TabIndex = 65;
            this.pbAlien48.TabStop = false;
            // 
            // pbEnemy49
            // 
            this.pbAlien49.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien49.Image")));
            this.pbAlien49.Location = new System.Drawing.Point(401, 373);
            this.pbAlien49.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien49.Name = "pbAlien49";
            this.pbAlien49.Size = new System.Drawing.Size(64, 39);
            this.pbAlien49.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien49.TabIndex = 64;
            this.pbAlien49.TabStop = false;
            // 
            // pbEnemy53
            // 
            this.pbAlien53.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien53.Image")));
            this.pbAlien53.Location = new System.Drawing.Point(711, 373);
            this.pbAlien53.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien53.Name = "pbAlien53";
            this.pbAlien53.Size = new System.Drawing.Size(64, 39);
            this.pbAlien53.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien53.TabIndex = 63;
            this.pbAlien53.TabStop = false;
            // 
            // pbEnemy52
            // 
            this.pbAlien52.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien52.Image")));
            this.pbAlien52.Location = new System.Drawing.Point(633, 373);
            this.pbAlien52.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien52.Name = "pbAlien52";
            this.pbAlien52.Size = new System.Drawing.Size(64, 39);
            this.pbAlien52.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien52.TabIndex = 62;
            this.pbAlien52.TabStop = false;
            // 
            // pbEnemy55
            // 
            this.pbAlien55.Image = global::SpaceInvaders.Properties.Resources.Alien1_1;
            this.pbAlien55.Location = new System.Drawing.Point(865, 373);
            this.pbAlien55.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien55.Name = "pbAlien55";
            this.pbAlien55.Size = new System.Drawing.Size(64, 39);
            this.pbAlien55.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien55.TabIndex = 61;
            this.pbAlien55.TabStop = false;
            // 
            // pbEnemy54
            // 
            this.pbAlien54.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien54.Image")));
            this.pbAlien54.Location = new System.Drawing.Point(788, 373);
            this.pbAlien54.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien54.Name = "pbAlien54";
            this.pbAlien54.Size = new System.Drawing.Size(64, 39);
            this.pbAlien54.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien54.TabIndex = 60;
            this.pbAlien54.TabStop = false;
            // 
            // pbEnemy51
            // 
            this.pbAlien51.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien51.Image")));
            this.pbAlien51.Location = new System.Drawing.Point(556, 373);
            this.pbAlien51.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien51.Name = "pbAlien51";
            this.pbAlien51.Size = new System.Drawing.Size(64, 39);
            this.pbAlien51.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien51.TabIndex = 58;
            this.pbAlien51.TabStop = false;
            // 
            // pbEnemy50
            // 
            this.pbAlien50.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien50.Image")));
            this.pbAlien50.Location = new System.Drawing.Point(479, 373);
            this.pbAlien50.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien50.Name = "pbAlien50";
            this.pbAlien50.Size = new System.Drawing.Size(64, 39);
            this.pbAlien50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien50.TabIndex = 57;
            this.pbAlien50.TabStop = false;
            // 
            // pbEnemy45
            // 
            this.pbAlien45.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien45.Image")));
            this.pbAlien45.Location = new System.Drawing.Point(92, 373);
            this.pbAlien45.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien45.Name = "pbAlien45";
            this.pbAlien45.Size = new System.Drawing.Size(64, 39);
            this.pbAlien45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien45.TabIndex = 56;
            this.pbAlien45.TabStop = false;
            // 
            // pbEnemy35
            // 
            this.pbAlien35.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien35.Image")));
            this.pbAlien35.Location = new System.Drawing.Point(169, 303);
            this.pbAlien35.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien35.Name = "pbAlien35";
            this.pbAlien35.Size = new System.Drawing.Size(64, 39);
            this.pbAlien35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien35.TabIndex = 55;
            this.pbAlien35.TabStop = false;
            // 
            // pbEnemy36
            // 
            this.pbAlien36.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien36.Image")));
            this.pbAlien36.Location = new System.Drawing.Point(247, 303);
            this.pbAlien36.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien36.Name = "pbAlien36";
            this.pbAlien36.Size = new System.Drawing.Size(64, 39);
            this.pbAlien36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien36.TabIndex = 54;
            this.pbAlien36.TabStop = false;
            // 
            // pbEnemy37
            // 
            this.pbAlien37.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien37.Image")));
            this.pbAlien37.Location = new System.Drawing.Point(324, 303);
            this.pbAlien37.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien37.Name = "pbAlien37";
            this.pbAlien37.Size = new System.Drawing.Size(64, 39);
            this.pbAlien37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien37.TabIndex = 53;
            this.pbAlien37.TabStop = false;
            // 
            // pbEnemy38
            // 
            this.pbAlien38.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien38.Image")));
            this.pbAlien38.Location = new System.Drawing.Point(401, 303);
            this.pbAlien38.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien38.Name = "pbAlien38";
            this.pbAlien38.Size = new System.Drawing.Size(64, 39);
            this.pbAlien38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien38.TabIndex = 52;
            this.pbAlien38.TabStop = false;
            // 
            // pbEnemy42
            // 
            this.pbAlien42.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien42.Image")));
            this.pbAlien42.Location = new System.Drawing.Point(711, 303);
            this.pbAlien42.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien42.Name = "pbAlien42";
            this.pbAlien42.Size = new System.Drawing.Size(64, 39);
            this.pbAlien42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien42.TabIndex = 51;
            this.pbAlien42.TabStop = false;
            // 
            // pbEnemy41
            // 
            this.pbAlien41.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien41.Image")));
            this.pbAlien41.Location = new System.Drawing.Point(633, 303);
            this.pbAlien41.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien41.Name = "pbAlien41";
            this.pbAlien41.Size = new System.Drawing.Size(64, 39);
            this.pbAlien41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien41.TabIndex = 50;
            this.pbAlien41.TabStop = false;
            // 
            // pbEnemy44
            // 
            this.pbAlien44.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien44.Image")));
            this.pbAlien44.Location = new System.Drawing.Point(865, 303);
            this.pbAlien44.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien44.Name = "pbAlien44";
            this.pbAlien44.Size = new System.Drawing.Size(64, 39);
            this.pbAlien44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien44.TabIndex = 49;
            this.pbAlien44.TabStop = false;
            // 
            // pbEnemy43
            // 
            this.pbAlien43.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien43.Image")));
            this.pbAlien43.Location = new System.Drawing.Point(788, 303);
            this.pbAlien43.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien43.Name = "pbAlien43";
            this.pbAlien43.Size = new System.Drawing.Size(64, 39);
            this.pbAlien43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien43.TabIndex = 48;
            this.pbAlien43.TabStop = false;
            // 
            // pbEnemy40
            // 
            this.pbAlien40.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien40.Image")));
            this.pbAlien40.Location = new System.Drawing.Point(556, 303);
            this.pbAlien40.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien40.Name = "pbAlien40";
            this.pbAlien40.Size = new System.Drawing.Size(64, 39);
            this.pbAlien40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien40.TabIndex = 46;
            this.pbAlien40.TabStop = false;
            // 
            // pbEnemy39
            // 
            this.pbAlien39.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien39.Image")));
            this.pbAlien39.Location = new System.Drawing.Point(479, 303);
            this.pbAlien39.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien39.Name = "pbAlien39";
            this.pbAlien39.Size = new System.Drawing.Size(64, 39);
            this.pbAlien39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien39.TabIndex = 45;
            this.pbAlien39.TabStop = false;
            // 
            // pbEnemy34
            // 
            this.pbAlien34.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien34.Image")));
            this.pbAlien34.Location = new System.Drawing.Point(92, 303);
            this.pbAlien34.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien34.Name = "pbAlien34";
            this.pbAlien34.Size = new System.Drawing.Size(64, 39);
            this.pbAlien34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien34.TabIndex = 44;
            this.pbAlien34.TabStop = false;
            // 
            // pbEnemy24
            // 
            this.pbAlien24.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien24.Image")));
            this.pbAlien24.Location = new System.Drawing.Point(169, 234);
            this.pbAlien24.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien24.Name = "pbAlien24";
            this.pbAlien24.Size = new System.Drawing.Size(64, 39);
            this.pbAlien24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien24.TabIndex = 43;
            this.pbAlien24.TabStop = false;
            // 
            // pbEnemy25
            // 
            this.pbAlien25.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien25.Image")));
            this.pbAlien25.Location = new System.Drawing.Point(247, 234);
            this.pbAlien25.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien25.Name = "pbAlien25";
            this.pbAlien25.Size = new System.Drawing.Size(64, 39);
            this.pbAlien25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien25.TabIndex = 42;
            this.pbAlien25.TabStop = false;
            // 
            // pbEnemy26
            // 
            this.pbAlien26.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien26.Image")));
            this.pbAlien26.Location = new System.Drawing.Point(324, 234);
            this.pbAlien26.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien26.Name = "pbAlien26";
            this.pbAlien26.Size = new System.Drawing.Size(64, 39);
            this.pbAlien26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien26.TabIndex = 41;
            this.pbAlien26.TabStop = false;
            // 
            // pbEnemy27
            // 
            this.pbAlien27.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien27.Image")));
            this.pbAlien27.Location = new System.Drawing.Point(401, 234);
            this.pbAlien27.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien27.Name = "pbAlien27";
            this.pbAlien27.Size = new System.Drawing.Size(64, 39);
            this.pbAlien27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien27.TabIndex = 40;
            this.pbAlien27.TabStop = false;
            // 
            // pbEnemy31
            // 
            this.pbAlien31.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien31.Image")));
            this.pbAlien31.Location = new System.Drawing.Point(711, 234);
            this.pbAlien31.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien31.Name = "pbAlien31";
            this.pbAlien31.Size = new System.Drawing.Size(64, 39);
            this.pbAlien31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien31.TabIndex = 39;
            this.pbAlien31.TabStop = false;
            // 
            // pbEnemy30
            // 
            this.pbAlien30.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien30.Image")));
            this.pbAlien30.Location = new System.Drawing.Point(633, 234);
            this.pbAlien30.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien30.Name = "pbAlien30";
            this.pbAlien30.Size = new System.Drawing.Size(64, 39);
            this.pbAlien30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien30.TabIndex = 38;
            this.pbAlien30.TabStop = false;
            // 
            // pbEnemy33
            // 
            this.pbAlien33.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien33.Image")));
            this.pbAlien33.Location = new System.Drawing.Point(865, 234);
            this.pbAlien33.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien33.Name = "pbAlien33";
            this.pbAlien33.Size = new System.Drawing.Size(64, 39);
            this.pbAlien33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien33.TabIndex = 37;
            this.pbAlien33.TabStop = false;
            // 
            // pbEnemy32
            // 
            this.pbAlien32.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien32.Image")));
            this.pbAlien32.Location = new System.Drawing.Point(788, 234);
            this.pbAlien32.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien32.Name = "pbAlien32";
            this.pbAlien32.Size = new System.Drawing.Size(64, 39);
            this.pbAlien32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien32.TabIndex = 36;
            this.pbAlien32.TabStop = false;
            // 
            // pbEnemy29
            // 
            this.pbAlien29.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien29.Image")));
            this.pbAlien29.Location = new System.Drawing.Point(556, 234);
            this.pbAlien29.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien29.Name = "pbAlien29";
            this.pbAlien29.Size = new System.Drawing.Size(64, 39);
            this.pbAlien29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien29.TabIndex = 34;
            this.pbAlien29.TabStop = false;
            // 
            // pbEnemy28
            // 
            this.pbAlien28.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien28.Image")));
            this.pbAlien28.Location = new System.Drawing.Point(479, 234);
            this.pbAlien28.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien28.Name = "pbAlien28";
            this.pbAlien28.Size = new System.Drawing.Size(64, 39);
            this.pbAlien28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien28.TabIndex = 33;
            this.pbAlien28.TabStop = false;
            // 
            // pbEnemy23
            // 
            this.pbAlien23.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien23.Image")));
            this.pbAlien23.Location = new System.Drawing.Point(92, 234);
            this.pbAlien23.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien23.Name = "pbAlien23";
            this.pbAlien23.Size = new System.Drawing.Size(64, 39);
            this.pbAlien23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien23.TabIndex = 32;
            this.pbAlien23.TabStop = false;
            // 
            // pbEnemy13
            // 
            this.pbAlien13.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien13.Image")));
            this.pbAlien13.Location = new System.Drawing.Point(169, 162);
            this.pbAlien13.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien13.Name = "pbAlien13";
            this.pbAlien13.Size = new System.Drawing.Size(64, 39);
            this.pbAlien13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien13.TabIndex = 31;
            this.pbAlien13.TabStop = false;
            // 
            // pbEnemy14
            // 
            this.pbAlien14.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien14.Image")));
            this.pbAlien14.Location = new System.Drawing.Point(247, 162);
            this.pbAlien14.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien14.Name = "pbAlien14";
            this.pbAlien14.Size = new System.Drawing.Size(64, 39);
            this.pbAlien14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien14.TabIndex = 30;
            this.pbAlien14.TabStop = false;
            // 
            // pbEnemy15
            // 
            this.pbAlien15.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien15.Image")));
            this.pbAlien15.Location = new System.Drawing.Point(324, 162);
            this.pbAlien15.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien15.Name = "pbAlien15";
            this.pbAlien15.Size = new System.Drawing.Size(64, 39);
            this.pbAlien15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien15.TabIndex = 29;
            this.pbAlien15.TabStop = false;
            // 
            // pbEnemy16
            // 
            this.pbAlien16.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien16.Image")));
            this.pbAlien16.Location = new System.Drawing.Point(401, 162);
            this.pbAlien16.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien16.Name = "pbAlien16";
            this.pbAlien16.Size = new System.Drawing.Size(64, 39);
            this.pbAlien16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien16.TabIndex = 28;
            this.pbAlien16.TabStop = false;
            // 
            // pbEnemy20
            // 
            this.pbAlien20.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien20.Image")));
            this.pbAlien20.Location = new System.Drawing.Point(711, 162);
            this.pbAlien20.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien20.Name = "pbAlien20";
            this.pbAlien20.Size = new System.Drawing.Size(64, 39);
            this.pbAlien20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien20.TabIndex = 27;
            this.pbAlien20.TabStop = false;
            // 
            // pbEnemy19
            // 
            this.pbAlien19.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien19.Image")));
            this.pbAlien19.Location = new System.Drawing.Point(633, 162);
            this.pbAlien19.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien19.Name = "pbAlien19";
            this.pbAlien19.Size = new System.Drawing.Size(64, 39);
            this.pbAlien19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien19.TabIndex = 26;
            this.pbAlien19.TabStop = false;
            // 
            // pbEnemy22
            // 
            this.pbAlien22.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien22.Image")));
            this.pbAlien22.Location = new System.Drawing.Point(865, 162);
            this.pbAlien22.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien22.Name = "pbAlien22";
            this.pbAlien22.Size = new System.Drawing.Size(64, 39);
            this.pbAlien22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien22.TabIndex = 25;
            this.pbAlien22.TabStop = false;
            // 
            // pbEnemy21
            // 
            this.pbAlien21.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien21.Image")));
            this.pbAlien21.Location = new System.Drawing.Point(788, 162);
            this.pbAlien21.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien21.Name = "pbAlien21";
            this.pbAlien21.Size = new System.Drawing.Size(64, 39);
            this.pbAlien21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien21.TabIndex = 24;
            this.pbAlien21.TabStop = false;
            // 
            // pbEnemy18
            // 
            this.pbAlien18.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien18.Image")));
            this.pbAlien18.Location = new System.Drawing.Point(556, 162);
            this.pbAlien18.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien18.Name = "pbAlien18";
            this.pbAlien18.Size = new System.Drawing.Size(64, 39);
            this.pbAlien18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien18.TabIndex = 22;
            this.pbAlien18.TabStop = false;
            // 
            // pbEnemy17
            // 
            this.pbAlien17.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien17.Image")));
            this.pbAlien17.Location = new System.Drawing.Point(479, 162);
            this.pbAlien17.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien17.Name = "pbAlien17";
            this.pbAlien17.Size = new System.Drawing.Size(64, 39);
            this.pbAlien17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien17.TabIndex = 21;
            this.pbAlien17.TabStop = false;
            // 
            // pbEnemy12
            // 
            this.pbAlien12.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien12.Image")));
            this.pbAlien12.Location = new System.Drawing.Point(92, 162);
            this.pbAlien12.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien12.Name = "pbAlien12";
            this.pbAlien12.Size = new System.Drawing.Size(64, 39);
            this.pbAlien12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien12.TabIndex = 20;
            this.pbAlien12.TabStop = false;
            // 
            // pbEnemy2
            // 
            this.pbAlien2.Image = global::SpaceInvaders.Properties.Resources.Alien3_1;
            this.pbAlien2.Location = new System.Drawing.Point(169, 94);
            this.pbAlien2.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien2.Name = "pbAlien2";
            this.pbAlien2.Size = new System.Drawing.Size(64, 39);
            this.pbAlien2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien2.TabIndex = 19;
            this.pbAlien2.TabStop = false;
            // 
            // pbEnemy3
            // 
            this.pbAlien3.Image = global::SpaceInvaders.Properties.Resources.Alien3_1;
            this.pbAlien3.Location = new System.Drawing.Point(247, 94);
            this.pbAlien3.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien3.Name = "pbAlien3";
            this.pbAlien3.Size = new System.Drawing.Size(64, 39);
            this.pbAlien3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien3.TabIndex = 18;
            this.pbAlien3.TabStop = false;
            // 
            // pbEnemy4
            // 
            this.pbAlien4.Image = global::SpaceInvaders.Properties.Resources.Alien3_1;
            this.pbAlien4.Location = new System.Drawing.Point(324, 94);
            this.pbAlien4.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien4.Name = "pbAlien4";
            this.pbAlien4.Size = new System.Drawing.Size(64, 39);
            this.pbAlien4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien4.TabIndex = 17;
            this.pbAlien4.TabStop = false;
            // 
            // pbEnemy5
            // 
            this.pbAlien5.Image = global::SpaceInvaders.Properties.Resources.Alien3_1;
            this.pbAlien5.Location = new System.Drawing.Point(401, 94);
            this.pbAlien5.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien5.Name = "pbAlien5";
            this.pbAlien5.Size = new System.Drawing.Size(64, 39);
            this.pbAlien5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien5.TabIndex = 16;
            this.pbAlien5.TabStop = false;
            // 
            // pbEnemy9
            // 
            this.pbAlien9.Image = global::SpaceInvaders.Properties.Resources.Alien3_1;
            this.pbAlien9.Location = new System.Drawing.Point(711, 94);
            this.pbAlien9.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien9.Name = "pbAlien9";
            this.pbAlien9.Size = new System.Drawing.Size(64, 39);
            this.pbAlien9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien9.TabIndex = 15;
            this.pbAlien9.TabStop = false;
            // 
            // pbEnemy8
            // 
            this.pbAlien8.Image = global::SpaceInvaders.Properties.Resources.Alien3_1;
            this.pbAlien8.Location = new System.Drawing.Point(633, 94);
            this.pbAlien8.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien8.Name = "pbAlien8";
            this.pbAlien8.Size = new System.Drawing.Size(64, 39);
            this.pbAlien8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien8.TabIndex = 14;
            this.pbAlien8.TabStop = false;
            // 
            // pbEnemy11
            // 
            this.pbAlien11.Image = global::SpaceInvaders.Properties.Resources.Alien3_1;
            this.pbAlien11.Location = new System.Drawing.Point(865, 94);
            this.pbAlien11.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien11.Name = "pbAlien11";
            this.pbAlien11.Size = new System.Drawing.Size(64, 39);
            this.pbAlien11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien11.TabIndex = 13;
            this.pbAlien11.TabStop = false;
            // 
            // pbEnemy10
            // 
            this.pbAlien10.Image = global::SpaceInvaders.Properties.Resources.Alien3_1;
            this.pbAlien10.Location = new System.Drawing.Point(788, 94);
            this.pbAlien10.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien10.Name = "pbAlien10";
            this.pbAlien10.Size = new System.Drawing.Size(64, 39);
            this.pbAlien10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien10.TabIndex = 12;
            this.pbAlien10.TabStop = false;
            // 
            // pbEnemy7
            // 
            this.pbAlien7.Image = global::SpaceInvaders.Properties.Resources.Alien3_1;
            this.pbAlien7.Location = new System.Drawing.Point(556, 94);
            this.pbAlien7.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien7.Name = "pbAlien7";
            this.pbAlien7.Size = new System.Drawing.Size(64, 39);
            this.pbAlien7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien7.TabIndex = 10;
            this.pbAlien7.TabStop = false;
            // 
            // pbEnemy6
            // 
            this.pbAlien6.Image = global::SpaceInvaders.Properties.Resources.Alien3_1;
            this.pbAlien6.Location = new System.Drawing.Point(479, 94);
            this.pbAlien6.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien6.Name = "pbAlien6";
            this.pbAlien6.Size = new System.Drawing.Size(64, 39);
            this.pbAlien6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien6.TabIndex = 9;
            this.pbAlien6.TabStop = false;
            // 
            // pbEnemy1
            // 
            this.pbAlien1.Image = global::SpaceInvaders.Properties.Resources.Alien3_1;
            this.pbAlien1.Location = new System.Drawing.Point(92, 94);
            this.pbAlien1.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlien1.Name = "pbAlien1";
            this.pbAlien1.Size = new System.Drawing.Size(64, 39);
            this.pbAlien1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAlien1.TabIndex = 8;
            this.pbAlien1.TabStop = false;
            // 
            // player
            // 
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(473, 1014);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(52, 32);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // playerBullet
            // 
            this.playerProjectile.Image = global::SpaceInvaders.Properties.Resources.PlayerProjectile;
            this.playerProjectile.Location = new System.Drawing.Point(1000, 1122);
            this.playerProjectile.Margin = new System.Windows.Forms.Padding(4);
            this.playerProjectile.Name = "playerProjectile";
            this.playerProjectile.Size = new System.Drawing.Size(5, 20);
            this.playerProjectile.TabIndex = 7;
            this.playerProjectile.TabStop = false;
            this.playerProjectile.Visible = false;
            // 
            // alienBullet1
            // 
            this.alienProjectile1.Enabled = false;
            this.alienProjectile1.Image = ((System.Drawing.Image)(resources.GetObject("alienProjectile1.Image")));
            this.alienProjectile1.Location = new System.Drawing.Point(976, 1108);
            this.alienProjectile1.Margin = new System.Windows.Forms.Padding(4);
            this.alienProjectile1.Name = "alienProjectile1";
            this.alienProjectile1.Size = new System.Drawing.Size(16, 34);
            this.alienProjectile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.alienProjectile1.TabIndex = 68;
            this.alienProjectile1.TabStop = false;
            this.alienProjectile1.Visible = false;
            // 
            // alienBullet2
            // 
            this.alienProjectile2.Enabled = false;
            this.alienProjectile2.Image = ((System.Drawing.Image)(resources.GetObject("alienProjectile2.Image")));
            this.alienProjectile2.Location = new System.Drawing.Point(952, 1108);
            this.alienProjectile2.Margin = new System.Windows.Forms.Padding(4);
            this.alienProjectile2.Name = "alienProjectile2";
            this.alienProjectile2.Size = new System.Drawing.Size(16, 34);
            this.alienProjectile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.alienProjectile2.TabIndex = 69;
            this.alienProjectile2.TabStop = false;
            this.alienProjectile2.Visible = false;
            // 
            // alienBullet3
            // 
            this.alienProjectile3.Enabled = false;
            this.alienProjectile3.Image = ((System.Drawing.Image)(resources.GetObject("alienProjectile3.Image")));
            this.alienProjectile3.Location = new System.Drawing.Point(928, 1108);
            this.alienProjectile3.Margin = new System.Windows.Forms.Padding(4);
            this.alienProjectile3.Name = "alienProjectile3";
            this.alienProjectile3.Size = new System.Drawing.Size(16, 34);
            this.alienProjectile3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.alienProjectile3.TabIndex = 70;
            this.alienProjectile3.TabStop = false;
            this.alienProjectile3.Visible = false;
            // 
            // btnControls
            // 
            this.btnControls.BackColor = System.Drawing.Color.Black;
            this.btnControls.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnControls.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControls.ForeColor = System.Drawing.SystemColors.Control;
            this.btnControls.Location = new System.Drawing.Point(421, 1108);
            this.btnControls.Margin = new System.Windows.Forms.Padding(4);
            this.btnControls.Name = "btnControls";
            this.btnControls.Size = new System.Drawing.Size(180, 34);
            this.btnControls.TabIndex = 85;
            this.btnControls.Text = " Controls";
            this.btnControls.UseVisualStyleBackColor = false;
            // 
            // gameOver
            // 
            this.gameOver.Image = ((System.Drawing.Image)(resources.GetObject("gameOver.Image")));
            this.gameOver.Location = new System.Drawing.Point(325, 126);
            this.gameOver.Margin = new System.Windows.Forms.Padding(4);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(248, 28);
            this.gameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gameOver.TabIndex = 0;
            this.gameOver.TabStop = false;
            this.gameOver.Visible = false;
            // 
            // pbBlock14
            // 
            this.pbBlock14.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock14.Image")));
            this.pbBlock14.Location = new System.Drawing.Point(68, 822);
            this.pbBlock14.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock14.Name = "pbBlock14";
            this.pbBlock14.Size = new System.Drawing.Size(27, 25);
            this.pbBlock14.TabIndex = 78;
            this.pbBlock14.TabStop = false;
            // 
            // pbBlock9
            // 
            this.pbBlock9.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock9.Image")));
            this.pbBlock9.Location = new System.Drawing.Point(68, 798);
            this.pbBlock9.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock9.Name = "pbBlock9";
            this.pbBlock9.Size = new System.Drawing.Size(27, 25);
            this.pbBlock9.TabIndex = 79;
            this.pbBlock9.TabStop = false;
            // 
            // pbBlock4
            // 
            this.pbBlock4.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock4.Image")));
            this.pbBlock4.Location = new System.Drawing.Point(68, 773);
            this.pbBlock4.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock4.Name = "pbBlock4";
            this.pbBlock4.Size = new System.Drawing.Size(27, 25);
            this.pbBlock4.TabIndex = 80;
            this.pbBlock4.TabStop = false;
            // 
            // pbBlock10
            // 
            this.pbBlock10.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock10.Image")));
            this.pbBlock10.Location = new System.Drawing.Point(95, 798);
            this.pbBlock10.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock10.Name = "pbBlock10";
            this.pbBlock10.Size = new System.Drawing.Size(27, 25);
            this.pbBlock10.TabIndex = 81;
            this.pbBlock10.TabStop = false;
            // 
            // pbBlock5
            // 
            this.pbBlock5.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock5.Image")));
            this.pbBlock5.Location = new System.Drawing.Point(95, 773);
            this.pbBlock5.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock5.Name = "pbBlock5";
            this.pbBlock5.Size = new System.Drawing.Size(27, 25);
            this.pbBlock5.TabIndex = 82;
            this.pbBlock5.TabStop = false;
            // 
            // pbBlock1
            // 
            this.pbBlock1.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock1.Image")));
            this.pbBlock1.Location = new System.Drawing.Point(95, 748);
            this.pbBlock1.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock1.Name = "pbBlock1";
            this.pbBlock1.Size = new System.Drawing.Size(27, 25);
            this.pbBlock1.TabIndex = 83;
            this.pbBlock1.TabStop = false;
            // 
            // pbBlock6
            // 
            this.pbBlock6.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock6.Image")));
            this.pbBlock6.Location = new System.Drawing.Point(121, 773);
            this.pbBlock6.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock6.Name = "pbBlock6";
            this.pbBlock6.Size = new System.Drawing.Size(27, 25);
            this.pbBlock6.TabIndex = 85;
            this.pbBlock6.TabStop = false;
            // 
            // pbBlock2
            // 
            this.pbBlock2.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock2.Image")));
            this.pbBlock2.Location = new System.Drawing.Point(121, 748);
            this.pbBlock2.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock2.Name = "pbBlock2";
            this.pbBlock2.Size = new System.Drawing.Size(27, 25);
            this.pbBlock2.TabIndex = 86;
            this.pbBlock2.TabStop = false;
            // 
            // pbBlock12
            // 
            this.pbBlock12.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock12.Image")));
            this.pbBlock12.Location = new System.Drawing.Point(148, 798);
            this.pbBlock12.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock12.Name = "pbBlock12";
            this.pbBlock12.Size = new System.Drawing.Size(27, 25);
            this.pbBlock12.TabIndex = 87;
            this.pbBlock12.TabStop = false;
            // 
            // pbBlock7
            // 
            this.pbBlock7.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock7.Image")));
            this.pbBlock7.Location = new System.Drawing.Point(148, 773);
            this.pbBlock7.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock7.Name = "pbBlock7";
            this.pbBlock7.Size = new System.Drawing.Size(27, 25);
            this.pbBlock7.TabIndex = 88;
            this.pbBlock7.TabStop = false;
            // 
            // pbBlock3
            // 
            this.pbBlock3.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock3.Image")));
            this.pbBlock3.Location = new System.Drawing.Point(148, 748);
            this.pbBlock3.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock3.Name = "pbBlock3";
            this.pbBlock3.Size = new System.Drawing.Size(27, 25);
            this.pbBlock3.TabIndex = 89;
            this.pbBlock3.TabStop = false;
            // 
            // pbBlock15
            // 
            this.pbBlock15.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock15.Image")));
            this.pbBlock15.Location = new System.Drawing.Point(175, 822);
            this.pbBlock15.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock15.Name = "pbBlock15";
            this.pbBlock15.Size = new System.Drawing.Size(27, 25);
            this.pbBlock15.TabIndex = 90;
            this.pbBlock15.TabStop = false;
            // 
            // pbBlock13
            // 
            this.pbBlock13.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock13.Image")));
            this.pbBlock13.Location = new System.Drawing.Point(175, 798);
            this.pbBlock13.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock13.Name = "pbBlock13";
            this.pbBlock13.Size = new System.Drawing.Size(27, 25);
            this.pbBlock13.TabIndex = 91;
            this.pbBlock13.TabStop = false;
            // 
            // pbBlock8
            // 
            this.pbBlock8.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock8.Image")));
            this.pbBlock8.Location = new System.Drawing.Point(175, 773);
            this.pbBlock8.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock8.Name = "pbBlock8";
            this.pbBlock8.Size = new System.Drawing.Size(27, 25);
            this.pbBlock8.TabIndex = 92;
            this.pbBlock8.TabStop = false;
            // 
            // pbBlock29
            // 
            this.pbBlock29.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock29.Image")));
            this.pbBlock29.Location = new System.Drawing.Point(307, 822);
            this.pbBlock29.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock29.Name = "pbBlock29";
            this.pbBlock29.Size = new System.Drawing.Size(27, 25);
            this.pbBlock29.TabIndex = 93;
            this.pbBlock29.TabStop = false;
            // 
            // pbBlock24
            // 
            this.pbBlock24.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock24.Image")));
            this.pbBlock24.Location = new System.Drawing.Point(307, 798);
            this.pbBlock24.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock24.Name = "pbBlock24";
            this.pbBlock24.Size = new System.Drawing.Size(27, 25);
            this.pbBlock24.TabIndex = 94;
            this.pbBlock24.TabStop = false;
            // 
            // pbBlock19
            // 
            this.pbBlock19.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock19.Image")));
            this.pbBlock19.Location = new System.Drawing.Point(307, 773);
            this.pbBlock19.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock19.Name = "pbBlock19";
            this.pbBlock19.Size = new System.Drawing.Size(27, 25);
            this.pbBlock19.TabIndex = 95;
            this.pbBlock19.TabStop = false;
            // 
            // pbBlock25
            // 
            this.pbBlock25.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock25.Image")));
            this.pbBlock25.Location = new System.Drawing.Point(333, 798);
            this.pbBlock25.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock25.Name = "pbBlock25";
            this.pbBlock25.Size = new System.Drawing.Size(27, 25);
            this.pbBlock25.TabIndex = 96;
            this.pbBlock25.TabStop = false;
            // 
            // pbBlock20
            // 
            this.pbBlock20.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock20.Image")));
            this.pbBlock20.Location = new System.Drawing.Point(333, 773);
            this.pbBlock20.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock20.Name = "pbBlock20";
            this.pbBlock20.Size = new System.Drawing.Size(27, 25);
            this.pbBlock20.TabIndex = 97;
            this.pbBlock20.TabStop = false;
            // 
            // pbBlock16
            // 
            this.pbBlock16.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock16.Image")));
            this.pbBlock16.Location = new System.Drawing.Point(333, 748);
            this.pbBlock16.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock16.Name = "pbBlock16";
            this.pbBlock16.Size = new System.Drawing.Size(27, 25);
            this.pbBlock16.TabIndex = 98;
            this.pbBlock16.TabStop = false;
            // 
            // pbBlock21
            // 
            this.pbBlock21.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock21.Image")));
            this.pbBlock21.Location = new System.Drawing.Point(360, 773);
            this.pbBlock21.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock21.Name = "pbBlock21";
            this.pbBlock21.Size = new System.Drawing.Size(27, 25);
            this.pbBlock21.TabIndex = 100;
            this.pbBlock21.TabStop = false;
            // 
            // pbBlock17
            // 
            this.pbBlock17.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock17.Image")));
            this.pbBlock17.Location = new System.Drawing.Point(360, 748);
            this.pbBlock17.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock17.Name = "pbBlock17";
            this.pbBlock17.Size = new System.Drawing.Size(27, 25);
            this.pbBlock17.TabIndex = 101;
            this.pbBlock17.TabStop = false;
            // 
            // pbBlock27
            // 
            this.pbBlock27.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock27.Image")));
            this.pbBlock27.Location = new System.Drawing.Point(387, 798);
            this.pbBlock27.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock27.Name = "pbBlock27";
            this.pbBlock27.Size = new System.Drawing.Size(27, 25);
            this.pbBlock27.TabIndex = 102;
            this.pbBlock27.TabStop = false;
            // 
            // pbBlock22
            // 
            this.pbBlock22.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock22.Image")));
            this.pbBlock22.Location = new System.Drawing.Point(387, 773);
            this.pbBlock22.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock22.Name = "pbBlock22";
            this.pbBlock22.Size = new System.Drawing.Size(27, 25);
            this.pbBlock22.TabIndex = 103;
            this.pbBlock22.TabStop = false;
            // 
            // pbBlock18
            // 
            this.pbBlock18.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock18.Image")));
            this.pbBlock18.Location = new System.Drawing.Point(387, 748);
            this.pbBlock18.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock18.Name = "pbBlock18";
            this.pbBlock18.Size = new System.Drawing.Size(27, 25);
            this.pbBlock18.TabIndex = 104;
            this.pbBlock18.TabStop = false;
            // 
            // pbBlock30
            // 
            this.pbBlock30.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock30.Image")));
            this.pbBlock30.Location = new System.Drawing.Point(413, 822);
            this.pbBlock30.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock30.Name = "pbBlock30";
            this.pbBlock30.Size = new System.Drawing.Size(27, 25);
            this.pbBlock30.TabIndex = 105;
            this.pbBlock30.TabStop = false;
            // 
            // pbBlock28
            // 
            this.pbBlock28.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock28.Image")));
            this.pbBlock28.Location = new System.Drawing.Point(413, 798);
            this.pbBlock28.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock28.Name = "pbBlock28";
            this.pbBlock28.Size = new System.Drawing.Size(27, 25);
            this.pbBlock28.TabIndex = 106;
            this.pbBlock28.TabStop = false;
            // 
            // pbBlock23
            // 
            this.pbBlock23.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock23.Image")));
            this.pbBlock23.Location = new System.Drawing.Point(413, 773);
            this.pbBlock23.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock23.Name = "pbBlock23";
            this.pbBlock23.Size = new System.Drawing.Size(27, 25);
            this.pbBlock23.TabIndex = 107;
            this.pbBlock23.TabStop = false;
            // 
            // pbBlock59
            // 
            this.pbBlock59.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock59.Image")));
            this.pbBlock59.Location = new System.Drawing.Point(781, 822);
            this.pbBlock59.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock59.Name = "pbBlock59";
            this.pbBlock59.Size = new System.Drawing.Size(27, 25);
            this.pbBlock59.TabIndex = 108;
            this.pbBlock59.TabStop = false;
            // 
            // pbBlock54
            // 
            this.pbBlock54.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock54.Image")));
            this.pbBlock54.Location = new System.Drawing.Point(781, 798);
            this.pbBlock54.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock54.Name = "pbBlock54";
            this.pbBlock54.Size = new System.Drawing.Size(27, 25);
            this.pbBlock54.TabIndex = 109;
            this.pbBlock54.TabStop = false;
            // 
            // pbBlock49
            // 
            this.pbBlock49.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock49.Image")));
            this.pbBlock49.Location = new System.Drawing.Point(781, 773);
            this.pbBlock49.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock49.Name = "pbBlock49";
            this.pbBlock49.Size = new System.Drawing.Size(27, 25);
            this.pbBlock49.TabIndex = 110;
            this.pbBlock49.TabStop = false;
            // 
            // pbBlock55
            // 
            this.pbBlock55.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock55.Image")));
            this.pbBlock55.Location = new System.Drawing.Point(808, 798);
            this.pbBlock55.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock55.Name = "pbBlock55";
            this.pbBlock55.Size = new System.Drawing.Size(27, 25);
            this.pbBlock55.TabIndex = 111;
            this.pbBlock55.TabStop = false;
            // 
            // pbBlock50
            // 
            this.pbBlock50.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock50.Image")));
            this.pbBlock50.Location = new System.Drawing.Point(808, 773);
            this.pbBlock50.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock50.Name = "pbBlock50";
            this.pbBlock50.Size = new System.Drawing.Size(27, 25);
            this.pbBlock50.TabIndex = 112;
            this.pbBlock50.TabStop = false;
            // 
            // pbBlock46
            // 
            this.pbBlock46.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock46.Image")));
            this.pbBlock46.Location = new System.Drawing.Point(808, 748);
            this.pbBlock46.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock46.Name = "pbBlock46";
            this.pbBlock46.Size = new System.Drawing.Size(27, 25);
            this.pbBlock46.TabIndex = 113;
            this.pbBlock46.TabStop = false;
            // 
            // pbBlock51
            // 
            this.pbBlock51.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock51.Image")));
            this.pbBlock51.Location = new System.Drawing.Point(835, 773);
            this.pbBlock51.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock51.Name = "pbBlock51";
            this.pbBlock51.Size = new System.Drawing.Size(27, 25);
            this.pbBlock51.TabIndex = 115;
            this.pbBlock51.TabStop = false;
            // 
            // pbBlock47
            // 
            this.pbBlock47.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock47.Image")));
            this.pbBlock47.Location = new System.Drawing.Point(835, 748);
            this.pbBlock47.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock47.Name = "pbBlock47";
            this.pbBlock47.Size = new System.Drawing.Size(27, 25);
            this.pbBlock47.TabIndex = 116;
            this.pbBlock47.TabStop = false;
            // 
            // pbBlock57
            // 
            this.pbBlock57.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock57.Image")));
            this.pbBlock57.Location = new System.Drawing.Point(861, 798);
            this.pbBlock57.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock57.Name = "pbBlock57";
            this.pbBlock57.Size = new System.Drawing.Size(27, 25);
            this.pbBlock57.TabIndex = 117;
            this.pbBlock57.TabStop = false;
            // 
            // pbBlock52
            // 
            this.pbBlock52.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock52.Image")));
            this.pbBlock52.Location = new System.Drawing.Point(861, 773);
            this.pbBlock52.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock52.Name = "pbBlock52";
            this.pbBlock52.Size = new System.Drawing.Size(27, 25);
            this.pbBlock52.TabIndex = 118;
            this.pbBlock52.TabStop = false;
            // 
            // pbBlock48
            // 
            this.pbBlock48.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock48.Image")));
            this.pbBlock48.Location = new System.Drawing.Point(861, 748);
            this.pbBlock48.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock48.Name = "pbBlock48";
            this.pbBlock48.Size = new System.Drawing.Size(27, 25);
            this.pbBlock48.TabIndex = 119;
            this.pbBlock48.TabStop = false;
            // 
            // pbBlock60
            // 
            this.pbBlock60.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock60.Image")));
            this.pbBlock60.Location = new System.Drawing.Point(888, 822);
            this.pbBlock60.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock60.Name = "pbBlock60";
            this.pbBlock60.Size = new System.Drawing.Size(27, 25);
            this.pbBlock60.TabIndex = 120;
            this.pbBlock60.TabStop = false;
            // 
            // pbBlock58
            // 
            this.pbBlock58.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock58.Image")));
            this.pbBlock58.Location = new System.Drawing.Point(888, 798);
            this.pbBlock58.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock58.Name = "pbBlock58";
            this.pbBlock58.Size = new System.Drawing.Size(27, 25);
            this.pbBlock58.TabIndex = 121;
            this.pbBlock58.TabStop = false;
            // 
            // pbBlock53
            // 
            this.pbBlock53.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock53.Image")));
            this.pbBlock53.Location = new System.Drawing.Point(888, 773);
            this.pbBlock53.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock53.Name = "pbBlock53";
            this.pbBlock53.Size = new System.Drawing.Size(27, 25);
            this.pbBlock53.TabIndex = 122;
            this.pbBlock53.TabStop = false;
            // 
            // pbBlock44
            // 
            this.pbBlock44.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock44.Image")));
            this.pbBlock44.Location = new System.Drawing.Point(541, 822);
            this.pbBlock44.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock44.Name = "pbBlock44";
            this.pbBlock44.Size = new System.Drawing.Size(27, 25);
            this.pbBlock44.TabIndex = 123;
            this.pbBlock44.TabStop = false;
            // 
            // pbBlock39
            // 
            this.pbBlock39.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock39.Image")));
            this.pbBlock39.Location = new System.Drawing.Point(541, 798);
            this.pbBlock39.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock39.Name = "pbBlock39";
            this.pbBlock39.Size = new System.Drawing.Size(27, 25);
            this.pbBlock39.TabIndex = 124;
            this.pbBlock39.TabStop = false;
            // 
            // pbBlock34
            // 
            this.pbBlock34.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock34.Image")));
            this.pbBlock34.Location = new System.Drawing.Point(541, 773);
            this.pbBlock34.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock34.Name = "pbBlock34";
            this.pbBlock34.Size = new System.Drawing.Size(27, 25);
            this.pbBlock34.TabIndex = 125;
            this.pbBlock34.TabStop = false;
            // 
            // pbBlock40
            // 
            this.pbBlock40.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock40.Image")));
            this.pbBlock40.Location = new System.Drawing.Point(568, 798);
            this.pbBlock40.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock40.Name = "pbBlock40";
            this.pbBlock40.Size = new System.Drawing.Size(27, 25);
            this.pbBlock40.TabIndex = 126;
            this.pbBlock40.TabStop = false;
            // 
            // pbBlock35
            // 
            this.pbBlock35.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock35.Image")));
            this.pbBlock35.Location = new System.Drawing.Point(568, 773);
            this.pbBlock35.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock35.Name = "pbBlock35";
            this.pbBlock35.Size = new System.Drawing.Size(27, 25);
            this.pbBlock35.TabIndex = 127;
            this.pbBlock35.TabStop = false;
            // 
            // pbBlock31
            // 
            this.pbBlock31.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock31.Image")));
            this.pbBlock31.Location = new System.Drawing.Point(568, 748);
            this.pbBlock31.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock31.Name = "pbBlock31";
            this.pbBlock31.Size = new System.Drawing.Size(27, 25);
            this.pbBlock31.TabIndex = 128;
            this.pbBlock31.TabStop = false;
            // 
            // pbBlock36
            // 
            this.pbBlock36.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock36.Image")));
            this.pbBlock36.Location = new System.Drawing.Point(595, 773);
            this.pbBlock36.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock36.Name = "pbBlock36";
            this.pbBlock36.Size = new System.Drawing.Size(27, 25);
            this.pbBlock36.TabIndex = 130;
            this.pbBlock36.TabStop = false;
            // 
            // pbBlock32
            // 
            this.pbBlock32.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock32.Image")));
            this.pbBlock32.Location = new System.Drawing.Point(595, 748);
            this.pbBlock32.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock32.Name = "pbBlock32";
            this.pbBlock32.Size = new System.Drawing.Size(27, 25);
            this.pbBlock32.TabIndex = 131;
            this.pbBlock32.TabStop = false;
            // 
            // pbBlock42
            // 
            this.pbBlock42.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock42.Image")));
            this.pbBlock42.Location = new System.Drawing.Point(621, 798);
            this.pbBlock42.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock42.Name = "pbBlock42";
            this.pbBlock42.Size = new System.Drawing.Size(27, 25);
            this.pbBlock42.TabIndex = 132;
            this.pbBlock42.TabStop = false;
            // 
            // pbBlock37
            // 
            this.pbBlock37.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock37.Image")));
            this.pbBlock37.Location = new System.Drawing.Point(621, 773);
            this.pbBlock37.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock37.Name = "pbBlock37";
            this.pbBlock37.Size = new System.Drawing.Size(27, 25);
            this.pbBlock37.TabIndex = 133;
            this.pbBlock37.TabStop = false;
            // 
            // pbBlock33
            // 
            this.pbBlock33.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock33.Image")));
            this.pbBlock33.Location = new System.Drawing.Point(621, 748);
            this.pbBlock33.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock33.Name = "pbBlock33";
            this.pbBlock33.Size = new System.Drawing.Size(27, 25);
            this.pbBlock33.TabIndex = 134;
            this.pbBlock33.TabStop = false;
            // 
            // pbBlock45
            // 
            this.pbBlock45.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock45.Image")));
            this.pbBlock45.Location = new System.Drawing.Point(648, 822);
            this.pbBlock45.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock45.Name = "pbBlock45";
            this.pbBlock45.Size = new System.Drawing.Size(27, 25);
            this.pbBlock45.TabIndex = 135;
            this.pbBlock45.TabStop = false;
            // 
            // pbBlock43
            // 
            this.pbBlock43.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock43.Image")));
            this.pbBlock43.Location = new System.Drawing.Point(648, 798);
            this.pbBlock43.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock43.Name = "pbBlock43";
            this.pbBlock43.Size = new System.Drawing.Size(27, 25);
            this.pbBlock43.TabIndex = 136;
            this.pbBlock43.TabStop = false;
            // 
            // pbBlock38
            // 
            this.pbBlock38.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock38.Image")));
            this.pbBlock38.Location = new System.Drawing.Point(648, 773);
            this.pbBlock38.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock38.Name = "pbBlock38";
            this.pbBlock38.Size = new System.Drawing.Size(27, 25);
            this.pbBlock38.TabIndex = 137;
            this.pbBlock38.TabStop = false;
            
            // 
            // pbBlock68
            // 
            this.pbBlock68.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock68.Image")));
            this.pbBlock68.Location = new System.Drawing.Point(888, 748);
            this.pbBlock68.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock68.Name = "pbBlock68";
            this.pbBlock68.Size = new System.Drawing.Size(27, 25);
            this.pbBlock68.TabIndex = 148;
            this.pbBlock68.TabStop = false;
            // 
            // pbBlock65
            // 
            this.pbBlock65.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock65.Image")));
            this.pbBlock65.Location = new System.Drawing.Point(648, 748);
            this.pbBlock65.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock65.Name = "pbBlock65";
            this.pbBlock65.Size = new System.Drawing.Size(27, 25);
            this.pbBlock65.TabIndex = 147;
            this.pbBlock65.TabStop = false;
            // 
            // pbBlock63
            // 
            this.pbBlock63.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock63.Image")));
            this.pbBlock63.Location = new System.Drawing.Point(413, 748);
            this.pbBlock63.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock63.Name = "pbBlock63";
            this.pbBlock63.Size = new System.Drawing.Size(27, 25);
            this.pbBlock63.TabIndex = 146;
            this.pbBlock63.TabStop = false;
            // 
            // pbBlock66
            // 
            this.pbBlock66.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock66.Image")));
            this.pbBlock66.Location = new System.Drawing.Point(175, 748);
            this.pbBlock66.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock66.Name = "pbBlock66";
            this.pbBlock66.Size = new System.Drawing.Size(27, 25);
            this.pbBlock66.TabIndex = 145;
            this.pbBlock66.TabStop = false;
            // 
            // pbBlock67
            // 
            this.pbBlock67.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock67.Image")));
            this.pbBlock67.Location = new System.Drawing.Point(781, 748);
            this.pbBlock67.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock67.Name = "pbBlock67";
            this.pbBlock67.Size = new System.Drawing.Size(27, 25);
            this.pbBlock67.TabIndex = 142;
            this.pbBlock67.TabStop = false;
            // 
            // pbBlock64
            // 
            this.pbBlock64.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock64.Image")));
            this.pbBlock64.Location = new System.Drawing.Point(541, 748);
            this.pbBlock64.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock64.Name = "pbBlock64";
            this.pbBlock64.Size = new System.Drawing.Size(27, 25);
            this.pbBlock64.TabIndex = 141;
            this.pbBlock64.TabStop = false;
            // 
            // pbBlock62
            // 
            this.pbBlock62.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock62.Image")));
            this.pbBlock62.Location = new System.Drawing.Point(307, 748);
            this.pbBlock62.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock62.Name = "pbBlock62";
            this.pbBlock62.Size = new System.Drawing.Size(27, 25);
            this.pbBlock62.TabIndex = 140;
            this.pbBlock62.TabStop = false;
            // 
            // pbBlock61
            // 
            this.pbBlock61.Image = ((System.Drawing.Image)(resources.GetObject("pbBlock61.Image")));
            this.pbBlock61.Location = new System.Drawing.Point(68, 748);
            this.pbBlock61.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock61.Name = "pbBlock61";
            this.pbBlock61.Size = new System.Drawing.Size(27, 25);
            this.pbBlock61.TabIndex = 139;
            this.pbBlock61.TabStop = false;
            // 
            // alienBoundsPanel
            // 
            this.alienBoundsPanel.BackColor = System.Drawing.Color.Transparent;
            this.alienBoundsPanel.Controls.Add(this.pbBlock68);
            this.alienBoundsPanel.Controls.Add(this.pbBlock65);
            this.alienBoundsPanel.Controls.Add(this.pbBlock63);
            this.alienBoundsPanel.Controls.Add(this.pbBlock66);
            this.alienBoundsPanel.Controls.Add(this.pbBlock67);
            this.alienBoundsPanel.Controls.Add(this.pbBlock64);
            this.alienBoundsPanel.Controls.Add(this.pbBlock62);
            this.alienBoundsPanel.Controls.Add(this.pbBlock61);
            this.alienBoundsPanel.Controls.Add(this.pbBlock38);
            this.alienBoundsPanel.Controls.Add(this.pbBlock43);
            this.alienBoundsPanel.Controls.Add(this.pbBlock45);
            this.alienBoundsPanel.Controls.Add(this.pbBlock33);
            this.alienBoundsPanel.Controls.Add(this.pbBlock37);
            this.alienBoundsPanel.Controls.Add(this.pbBlock42);
            this.alienBoundsPanel.Controls.Add(this.pbBlock32);
            this.alienBoundsPanel.Controls.Add(this.pbBlock36);
            this.alienBoundsPanel.Controls.Add(this.pbBlock31);
            this.alienBoundsPanel.Controls.Add(this.pbBlock35);
            this.alienBoundsPanel.Controls.Add(this.pbBlock40);
            this.alienBoundsPanel.Controls.Add(this.pbBlock34);
            this.alienBoundsPanel.Controls.Add(this.pbBlock39);
            this.alienBoundsPanel.Controls.Add(this.pbBlock44);
            this.alienBoundsPanel.Controls.Add(this.pbBlock53);
            this.alienBoundsPanel.Controls.Add(this.pbBlock58);
            this.alienBoundsPanel.Controls.Add(this.pbBlock60);
            this.alienBoundsPanel.Controls.Add(this.pbBlock48);
            this.alienBoundsPanel.Controls.Add(this.pbBlock52);
            this.alienBoundsPanel.Controls.Add(this.pbBlock57);
            this.alienBoundsPanel.Controls.Add(this.pbBlock47);
            this.alienBoundsPanel.Controls.Add(this.pbBlock51);
            this.alienBoundsPanel.Controls.Add(this.pbBlock46);
            this.alienBoundsPanel.Controls.Add(this.pbBlock50);
            this.alienBoundsPanel.Controls.Add(this.pbBlock55);
            this.alienBoundsPanel.Controls.Add(this.pbBlock49);
            this.alienBoundsPanel.Controls.Add(this.pbBlock54);
            this.alienBoundsPanel.Controls.Add(this.pbBlock59);
            this.alienBoundsPanel.Controls.Add(this.pbBlock23);
            this.alienBoundsPanel.Controls.Add(this.pbBlock28);
            this.alienBoundsPanel.Controls.Add(this.pbBlock30);
            this.alienBoundsPanel.Controls.Add(this.pbBlock18);
            this.alienBoundsPanel.Controls.Add(this.pbBlock22);
            this.alienBoundsPanel.Controls.Add(this.pbBlock27);
            this.alienBoundsPanel.Controls.Add(this.pbBlock17);
            this.alienBoundsPanel.Controls.Add(this.pbBlock21);
            this.alienBoundsPanel.Controls.Add(this.pbBlock16);
            this.alienBoundsPanel.Controls.Add(this.pbBlock20);
            this.alienBoundsPanel.Controls.Add(this.pbBlock25);
            this.alienBoundsPanel.Controls.Add(this.pbBlock19);
            this.alienBoundsPanel.Controls.Add(this.pbBlock24);
            this.alienBoundsPanel.Controls.Add(this.pbBlock29);
            this.alienBoundsPanel.Controls.Add(this.pbBlock8);
            this.alienBoundsPanel.Controls.Add(this.pbBlock13);
            this.alienBoundsPanel.Controls.Add(this.pbBlock15);
            this.alienBoundsPanel.Controls.Add(this.pbBlock3);
            this.alienBoundsPanel.Controls.Add(this.pbBlock7);
            this.alienBoundsPanel.Controls.Add(this.pbBlock12);
            this.alienBoundsPanel.Controls.Add(this.pbBlock2);
            this.alienBoundsPanel.Controls.Add(this.pbBlock6);
            this.alienBoundsPanel.Controls.Add(this.pbBlock1);
            this.alienBoundsPanel.Controls.Add(this.pbBlock5);
            this.alienBoundsPanel.Controls.Add(this.pbBlock10);
            this.alienBoundsPanel.Controls.Add(this.pbBlock4);
            this.alienBoundsPanel.Controls.Add(this.pbBlock9);
            this.alienBoundsPanel.Controls.Add(this.pbBlock14);
            this.alienBoundsPanel.Controls.Add(this.gameOver);
            this.alienBoundsPanel.ForeColor = System.Drawing.Color.Transparent;
            this.alienBoundsPanel.Location = new System.Drawing.Point(19, 82);
            this.alienBoundsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.alienBoundsPanel.Name = "alienBoundsPanel";
            this.alienBoundsPanel.Size = new System.Drawing.Size(985, 853);
            this.alienBoundsPanel.TabIndex = 72;
            //
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1021, 1148);
            this.Controls.Add(this.btnControls);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.alienProjectile1Ghost);
            this.Controls.Add(this.alienProjectile2Ghost);
            this.Controls.Add(this.alienProjectile3Ghost);
            this.Controls.Add(this.playerProjectileGhost);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.bottomBoundsBox);
            this.Controls.Add(this.lifeTwo);
            this.Controls.Add(this.lifeThree);
            this.Controls.Add(this.livesCounter);
            this.Controls.Add(this.pbAlien46);
            this.Controls.Add(this.pbAlien47);
            this.Controls.Add(this.pbAlien48);
            this.Controls.Add(this.pbAlien49);
            this.Controls.Add(this.pbAlien53);
            this.Controls.Add(this.pbAlien52);
            this.Controls.Add(this.pbAlien55);
            this.Controls.Add(this.pbAlien54);
            this.Controls.Add(this.pbAlien51);
            this.Controls.Add(this.pbAlien50);
            this.Controls.Add(this.pbAlien45);
            this.Controls.Add(this.pbAlien35);
            this.Controls.Add(this.pbAlien36);
            this.Controls.Add(this.pbAlien37);
            this.Controls.Add(this.pbAlien38);
            this.Controls.Add(this.pbAlien42);
            this.Controls.Add(this.pbAlien41);
            this.Controls.Add(this.pbAlien44);
            this.Controls.Add(this.pbAlien43);
            this.Controls.Add(this.pbAlien40);
            this.Controls.Add(this.pbAlien39);
            this.Controls.Add(this.pbAlien34);
            this.Controls.Add(this.pbAlien24);
            this.Controls.Add(this.pbAlien25);
            this.Controls.Add(this.pbAlien26);
            this.Controls.Add(this.pbAlien27);
            this.Controls.Add(this.pbAlien31);
            this.Controls.Add(this.pbAlien30);
            this.Controls.Add(this.pbAlien33);
            this.Controls.Add(this.pbAlien32);
            this.Controls.Add(this.pbAlien29);
            this.Controls.Add(this.pbAlien28);
            this.Controls.Add(this.pbAlien23);
            this.Controls.Add(this.pbAlien13);
            this.Controls.Add(this.pbAlien14);
            this.Controls.Add(this.pbAlien15);
            this.Controls.Add(this.pbAlien16);
            this.Controls.Add(this.pbAlien20);
            this.Controls.Add(this.pbAlien19);
            this.Controls.Add(this.pbAlien22);
            this.Controls.Add(this.pbAlien21);
            this.Controls.Add(this.pbAlien18);
            this.Controls.Add(this.pbAlien17);
            this.Controls.Add(this.pbAlien12);
            this.Controls.Add(this.pbAlien2);
            this.Controls.Add(this.pbAlien3);
            this.Controls.Add(this.pbAlien4);
            this.Controls.Add(this.pbAlien5);
            this.Controls.Add(this.pbAlien9);
            this.Controls.Add(this.pbAlien8);
            this.Controls.Add(this.pbAlien11);
            this.Controls.Add(this.pbAlien10);
            this.Controls.Add(this.pbAlien7);
            this.Controls.Add(this.pbAlien6);
            this.Controls.Add(this.pbAlien1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.playerProjectile);
            this.Controls.Add(this.alienProjectile1);
            this.Controls.Add(this.alienProjectile2);
            this.Controls.Add(this.alienProjectile3);
            this.Controls.Add(this.alienBoundsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Invaders";
            ((System.ComponentModel.ISupportInitialize)(this.alienProjectile1Ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienProjectile2Ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienProjectile3Ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerProjectileGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBoundsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livesCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerProjectile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienProjectile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienProjectile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienProjectile3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock38)).EndInit();
            this.alienBoundsPanel.ResumeLayout(false);
            this.alienBoundsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock61)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer alienMovement;
        public System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer playerMovement;
        private System.Windows.Forms.Timer projectileCollision;
        private System.Windows.Forms.Timer objectDeath;
        private System.Windows.Forms.PictureBox pbAlien1;
        private System.Windows.Forms.PictureBox pbAlien6;
        private System.Windows.Forms.PictureBox pbAlien7;
        private System.Windows.Forms.PictureBox pbAlien10;
        private System.Windows.Forms.PictureBox pbAlien11;
        private System.Windows.Forms.PictureBox pbAlien8;
        private System.Windows.Forms.PictureBox pbAlien9;
        private System.Windows.Forms.PictureBox pbAlien5;
        private System.Windows.Forms.PictureBox pbAlien4;
        private System.Windows.Forms.PictureBox pbAlien3;
        private System.Windows.Forms.PictureBox pbAlien2;
        private System.Windows.Forms.PictureBox pbAlien13;
        private System.Windows.Forms.PictureBox pbAlien14;
        private System.Windows.Forms.PictureBox pbAlien15;
        private System.Windows.Forms.PictureBox pbAlien16;
        private System.Windows.Forms.PictureBox pbAlien20;
        private System.Windows.Forms.PictureBox pbAlien19;
        private System.Windows.Forms.PictureBox pbAlien22;
        private System.Windows.Forms.PictureBox pbAlien21;
        private System.Windows.Forms.PictureBox pbAlien18;
        private System.Windows.Forms.PictureBox pbAlien17;
        private System.Windows.Forms.PictureBox pbAlien12;
        private System.Windows.Forms.PictureBox pbAlien24;
        private System.Windows.Forms.PictureBox pbAlien25;
        private System.Windows.Forms.PictureBox pbAlien26;
        private System.Windows.Forms.PictureBox pbAlien27;
        private System.Windows.Forms.PictureBox pbAlien31;
        private System.Windows.Forms.PictureBox pbAlien30;
        private System.Windows.Forms.PictureBox pbAlien33;
        private System.Windows.Forms.PictureBox pbAlien32;
        private System.Windows.Forms.PictureBox pbAlien29;
        private System.Windows.Forms.PictureBox pbAlien28;
        private System.Windows.Forms.PictureBox pbAlien23;
        private System.Windows.Forms.PictureBox pbAlien35;
        private System.Windows.Forms.PictureBox pbAlien36;
        private System.Windows.Forms.PictureBox pbAlien37;
        private System.Windows.Forms.PictureBox pbAlien38;
        private System.Windows.Forms.PictureBox pbAlien42;
        private System.Windows.Forms.PictureBox pbAlien41;
        private System.Windows.Forms.PictureBox pbAlien44;
        private System.Windows.Forms.PictureBox pbAlien43;
        private System.Windows.Forms.PictureBox pbAlien40;
        private System.Windows.Forms.PictureBox pbAlien39;
        private System.Windows.Forms.PictureBox pbAlien34;
        private System.Windows.Forms.PictureBox pbAlien55;
        private System.Windows.Forms.PictureBox pbAlien54;
        private System.Windows.Forms.PictureBox pbAlien51;
        private System.Windows.Forms.PictureBox pbAlien50;
        private System.Windows.Forms.PictureBox pbAlien45;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.PictureBox pbAlien52;
        private System.Windows.Forms.PictureBox pbAlien53;
        private System.Windows.Forms.PictureBox pbAlien49;
        private System.Windows.Forms.PictureBox pbAlien48;
        private System.Windows.Forms.PictureBox pbAlien47;
        private System.Windows.Forms.PictureBox pbAlien46;
        public System.Windows.Forms.PictureBox playerProjectile;
        private System.Windows.Forms.PictureBox alienProjectile1;
        private System.Windows.Forms.PictureBox alienProjectile2;
        private System.Windows.Forms.PictureBox alienProjectile3;
        private System.Windows.Forms.Timer projectileAnimation;
        private System.Windows.Forms.PictureBox livesCounter;
        private System.Windows.Forms.PictureBox lifeThree;
        private System.Windows.Forms.PictureBox lifeTwo;
        private System.Windows.Forms.PictureBox bottomBoundsBox;
        public System.Windows.Forms.PictureBox playerProjectileGhost;
        private System.Windows.Forms.PictureBox alienProjectile1Ghost;
        private System.Windows.Forms.PictureBox alienProjectile2Ghost;
        private System.Windows.Forms.PictureBox alienProjectile3Ghost;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Button btnControls;
        private System.Windows.Forms.PictureBox gameOver;
        private System.Windows.Forms.PictureBox pbBlock14;
        private System.Windows.Forms.PictureBox pbBlock9;
        private System.Windows.Forms.PictureBox pbBlock4;
        private System.Windows.Forms.PictureBox pbBlock10;
        private System.Windows.Forms.PictureBox pbBlock5;
        private System.Windows.Forms.PictureBox pbBlock1;
        private System.Windows.Forms.PictureBox pbBlock6;
        private System.Windows.Forms.PictureBox pbBlock2;
        private System.Windows.Forms.PictureBox pbBlock12;
        private System.Windows.Forms.PictureBox pbBlock7;
        private System.Windows.Forms.PictureBox pbBlock3;
        private System.Windows.Forms.PictureBox pbBlock15;
        private System.Windows.Forms.PictureBox pbBlock13;
        private System.Windows.Forms.PictureBox pbBlock8;
        private System.Windows.Forms.PictureBox pbBlock29;
        private System.Windows.Forms.PictureBox pbBlock24;
        private System.Windows.Forms.PictureBox pbBlock19;
        private System.Windows.Forms.PictureBox pbBlock25;
        private System.Windows.Forms.PictureBox pbBlock20;
        private System.Windows.Forms.PictureBox pbBlock16;
        private System.Windows.Forms.PictureBox pbBlock21;
        private System.Windows.Forms.PictureBox pbBlock17;
        private System.Windows.Forms.PictureBox pbBlock27;
        private System.Windows.Forms.PictureBox pbBlock22;
        private System.Windows.Forms.PictureBox pbBlock18;
        private System.Windows.Forms.PictureBox pbBlock30;
        private System.Windows.Forms.PictureBox pbBlock28;
        private System.Windows.Forms.PictureBox pbBlock23;
        private System.Windows.Forms.PictureBox pbBlock59;
        private System.Windows.Forms.PictureBox pbBlock54;
        private System.Windows.Forms.PictureBox pbBlock49;
        private System.Windows.Forms.PictureBox pbBlock55;
        private System.Windows.Forms.PictureBox pbBlock50;
        private System.Windows.Forms.PictureBox pbBlock46;
        private System.Windows.Forms.PictureBox pbBlock51;
        private System.Windows.Forms.PictureBox pbBlock47;
        private System.Windows.Forms.PictureBox pbBlock57;
        private System.Windows.Forms.PictureBox pbBlock52;
        private System.Windows.Forms.PictureBox pbBlock48;
        private System.Windows.Forms.PictureBox pbBlock60;
        private System.Windows.Forms.PictureBox pbBlock58;
        private System.Windows.Forms.PictureBox pbBlock53;
        private System.Windows.Forms.PictureBox pbBlock44;
        private System.Windows.Forms.PictureBox pbBlock39;
        private System.Windows.Forms.PictureBox pbBlock34;
        private System.Windows.Forms.PictureBox pbBlock40;
        private System.Windows.Forms.PictureBox pbBlock35;
        private System.Windows.Forms.PictureBox pbBlock31;
        private System.Windows.Forms.PictureBox pbBlock36;
        private System.Windows.Forms.PictureBox pbBlock32;
        private System.Windows.Forms.PictureBox pbBlock42;
        private System.Windows.Forms.PictureBox pbBlock37;
        private System.Windows.Forms.PictureBox pbBlock33;
        private System.Windows.Forms.PictureBox pbBlock45;
        private System.Windows.Forms.PictureBox pbBlock43;
        private System.Windows.Forms.PictureBox pbBlock38;
        private System.Windows.Forms.Panel alienBoundsPanel;
        private System.Windows.Forms.PictureBox pbBlock67;
        private System.Windows.Forms.PictureBox pbBlock64;
        private System.Windows.Forms.PictureBox pbBlock62;
        private System.Windows.Forms.PictureBox pbBlock61;
        private System.Windows.Forms.PictureBox pbBlock68;
        private System.Windows.Forms.PictureBox pbBlock65;
        private System.Windows.Forms.PictureBox pbBlock63;
        private System.Windows.Forms.PictureBox pbBlock66;
    }
}

