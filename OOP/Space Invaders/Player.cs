using System.Drawing;

namespace SpaceInvaders {
    public class Player {
        private bool isShot; 
        private int xPos;
        private int yPos; 
        private int lives;

        public Player() {
        }


        public bool IsFired() {
            return (isShot);
        }

        public void Fire(bool fireState) { 
            isShot = fireState;
        }

        public int GetPos(char dim) { 
            if (dim == 'x')
                return (xPos);
            else
                return (yPos);
        }
         
        public void SetPos(Point pos) {  
            xPos = pos.X;
            yPos = pos.Y;
        }

        public int GetLives() {
            return (lives);
        }

        public void SetLives(int l) {
            lives = l;
        }

        public void LoseLife(){
            lives--;
        }
    }
}
