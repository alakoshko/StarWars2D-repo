using System;
using System.Drawing;


namespace StarWars
{
    class Bullet : GameObject
    {
        private int _Power { get; set; }

        public Bullet(BaseObjectParams param, int Power) : base(param)
        {
            _Power = Power;
        }
        public override void Draw()
        {
            Game.Buffer.Graphics.DrawRectangle(Pens.OrangeRed, new Rectangle(_Position, _Size));
        }
        public override void Update()
        {
            _Position.X = _Position.X + _Speed.X;
        }

        public int Power()
        {
            return _Power;
        }
    }
}
