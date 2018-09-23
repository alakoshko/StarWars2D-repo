using System;
using System.Drawing;


namespace StarWars
{
    class Bullet : GameObject
    {
        public Bullet(BaseObjectParams param) : base(param)
        {
        }
        public override void Draw()
        {
            Game.Buffer.Graphics.DrawRectangle(Pens.OrangeRed, _Position.X, _Position.Y, _Size.Width,
            _Size.Height);
        }
        public override void Update()
        {
            _Position.X = _Position.X + 3;
        }
    }
}
