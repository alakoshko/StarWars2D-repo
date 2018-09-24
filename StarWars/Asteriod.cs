using System;
using System.Drawing;


namespace StarWars
{
    // Создаем класс Asteroid, так как мы теперь не можем создавать объекты абстрактного класса BaseObject
    class Asteroid : GameObject, ICloneable
    {
        public int Power { get; set; } = 1;
        protected ImageObjectParams imageObjectParams = new ImageObjectParams();

        public Asteroid(BaseObjectParams param, int Power) : base(param)
        {
            this.Power = Power;
        }

        public override void Draw()
        {
            //Game.Buffer.Graphics.DrawImage(imageObjectParams.ObjectImage, new Rectangle(_Position, _Size));
            Game.Buffer.Graphics.DrawImage(imageObjectParams.ObjectImage, new Rectangle(_Position, _Size));
            Font drawFont = new Font("Arial", 16);
            Game.Buffer.Graphics.DrawString(Power.ToString(), drawFont, Brushes.Red, _Position);
            //Game.Buffer.Graphics.FillEllipse(Brushes.White, _Position.X, _Position.Y, _Size.Width, _Size.Height);
        }

        public void Die()
        {
            //Game.Buffer.Graphics.DrawImage()
        }

        public override void Update()
        {
            _Position.X -= _Speed.X;
            if (_Position.X < 0)
            {
                _Position.X = Game.Width;
            }
        
            _Position.Y -= _Speed.Y;
            if (_Position.Y < 0)
            {
                _Position.Y = Game.Height;
            }
            if (_Position.Y > Game.Height)
            {
                _Position.Y = 0;
            }
        }
        
        //неявная реализация интерфейса
        public object Clone()
        {
            //return new Asteroid(param, Power);

            //Автоматическое клонирование через MemberwiseClone
            var new_Asteroid = (Asteroid)MemberwiseClone();
            new_Asteroid.Power = Power+1;

            return new_Asteroid;
        }

        //явная реализация
        //object ICloneable.Clone()
        //{
        //    return new Asteroid(param, Power);
        //}
    }
}
