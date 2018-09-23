using System;
using System.Drawing;


namespace StarWars
{
    // Создаем класс Asteroid, так как мы теперь не можем создавать объекты абстрактного класса BaseObject
    class Asteroid : GameObject
    {
        public int Power { get; set; }
        public Asteroid(BaseObjectParams param, int Power) : base(param)
        {
            Power = this.Power;
        }
        public override void Draw()
        {
            Game.Buffer.Graphics.FillEllipse(Brushes.White, _Position.X, _Position.Y, _Size.Width, _Size.Height);
        }
    }
}
