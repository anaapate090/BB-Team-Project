using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreaker
{
    class Powerups
    {
        public Color color;
        public int size, x, y;

        public Powerups(int _x, int _y, int _size, Color _color)
        {
            x = _x;
            y = _y;
            size = _size;
            color = _color;
        }

        public void Move(int speed)
        {
            y += speed;
        }

        public void PaddleCollision(Paddle p, Powerups d)
        {
            Rectangle powerRec = new Rectangle(d.x, d.y, d.size, 10);
            Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (powerRec.IntersectsWith(paddleRec))
            {
               
            }
        }
    }
}
