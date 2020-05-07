﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders {
    class Enemy {
        private int type;
        private int state = 1;
        private int xCord;
        private int yCord;
        private Image alienImage;

        public Enemy(int t, Image i, int x, int y) {
            type = t;
            alienImage = i;
            xCord = x;
            yCord = y;
        }


        public void SetImage(Image i) {
            alienImage = i;
        }

        public void SetState(int s) {
            if (s == 0) {
                state = s;
            }
        }

        public void SetXCord(int x) {
            xCord = x;
        }

        public void SetYCord(int y) {
            yCord = y;
        }

        public int GetAlienType() {
            return type;
        }

        public Image GetImage() {
            return alienImage;
        }

        public int GetState() {
            return state;
        }

        public int GetXCord() {
            return xCord;
        }

        public int GetYCord() {
            return yCord;
        }
    }
}
