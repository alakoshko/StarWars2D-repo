using System.Drawing;
using System;



namespace StarWars
{
    /// <summary>Игровой объект - звезда</summary>
    class Star : GameObject
    {
        /// <summary>Инициализация новой звезды</summary>
        /// <param name="Position">ПОложение на игровой сцене</param>
        /// <param name="Speed">Скорость перемещения между кадрами</param>
        /// <param name="Size">Размер на игровой сцене</param>
        public Star(BaseObjectParams param) : base(param) // Передача параметров в конструктор предка
        {
             // Конструктор звезды ничего больше не делает
        }

        /// <summary>Переорпделяем метод рисования</summary>
        public override void Draw()
        {
            var g = Game.Buffer.Graphics;
            g.DrawLine(Pens.White,
                _Position.X, _Position.Y,
                _Position.X + _Size.Width, _Position.Y + _Size.Height);
            g.DrawLine(Pens.White,
                _Position.X + _Size.Width, _Position.Y,
                _Position.X, _Position.Y + _Size.Height);

            //double c = 2.0 / 3.0;
            //Game.Buffer.Graphics.DrawLine(Pens.White,
            //    (float)(_Position.X - _Size.Width / 2 * c),
            //    (float)(_Position.Y - _Size.Height / 2 * c),
            //    (float)(_Position.X + _Size.Width / 2 * c),
            //    (float)(_Position.Y + _Size.Height / 2 * c));
            //Game.Buffer.Graphics.DrawLine(Pens.White,
            //    (float)(_Position.X + _Size.Width / 2 * c),
            //    (float)(_Position.Y - _Size.Height / 2 * c),
            //    (float)(_Position.X - _Size.Width / 2 * c),
            //    (float)(_Position.Y + _Size.Height / 2 * c));
            ////добавлен +
            //Game.Buffer.Graphics.DrawLine(Pens.White, _Position.X, _Position.Y - _Size.Height / 2, _Position.X, _Position.Y + _Size.Height / 2);
            //Game.Buffer.Graphics.DrawLine(Pens.White, _Position.X - _Size.Width / 2, _Position.Y, _Position.X + _Size.Width / 2, _Position.Y);
        }

        /// <summary>Переопределяем метод обновления состояния</summary>
        public override void Update()
        {
            _Position.X -= _Speed.X;
            if (_Position.X < 0)
            {
                //Random rnd = new Random(_Position.Y);

                //Zoom(rnd.Next(1, 10));

                _Position.X = Game.Width + _Size.Width;
                //_Position.Y = (rnd.Next() % (Game.Height - 120)) + 60;
            }

            //_Position.X += _Speed.X;
            //if (_Position.X < -_Size.Width)
            //{


            //    _Position.X = Game.Width + _Size.Width;
            //    _Position.Y = (rnd.Next() % (Game.Height - 120)) + 60;
            //    //_Speed.X = -5 * ((rnd.Next() % 10) + 5);
            //    //SpeedX = -5 * ((rnd.Next() % 10) + 5);

            //}
        }
    }
}