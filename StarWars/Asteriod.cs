using System;
using System.Drawing;


namespace StarWars
{
    // Создаем класс Asteroid, так как мы теперь не можем создавать объекты абстрактного класса BaseObject
    class Asteroid : GameObject, ICloneable
    {
        public int Power { get; set; } = 1;
        public const int powerMax = 10;
        public const int powerMin = 4;
        public static int minSize { get; protected set; }
        public int Damage = 0;

        protected ImageObjectParams imageObjectParams = new ImageObjectParams();

        public Asteroid(BaseObjectParams param, int Power) : base(param)
        {
            minSize = 20;

            #region Exceptions
            //Exception размера массива
            if (Power > powerMax) throw new StarWarsExceptions($"Для астероида: недопустимая величина Power: {Power} ");
            #endregion

            _Size.Height = (Power - Damage) * minSize;
            _Size.Width = (Power - Damage) * minSize;

            this.Power = Power;
        }

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(imageObjectParams.ObjectImage, new Rectangle(_Position, _Size));

            //выводим параметр Power
            if (Power - Damage > 0)
            {
                Font drawFont = new Font("Arial", 16);
                Game.Buffer.Graphics.DrawString((Power - Damage).ToString(), drawFont, Brushes.Red, _Position);
            }
 
        }

        public void Die()
        {
            //Game.Buffer.Graphics.DrawImage()
        }

        public override void Update()
        {
            //Уменьшение размеров после попадания
            if (Damage > Power) throw new StarWarsExceptions($"Для астероида: величина Damage: {Damage}  > Power {Power}");
            _Size.Height = (Power - Damage) * minSize;
            _Size.Width = (Power - Damage) * minSize;

            //Отображение на экране
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
