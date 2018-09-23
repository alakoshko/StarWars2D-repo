using System;
using System.Drawing;

namespace StarWars
{
	/// <summary>
	/// Класс Туманности
	/// </summary>
	class Nebula : GameObject
    {
		Point[] Dots;

		/// <summary>
		/// Конструктор класса Туманности
		/// </summary>
		/// <param name="param">Параметры объекта</param>
        public Nebula(BaseObjectParams param) : base(param)
        {
			Dots = new Point[50];
			Random rnd = new Random();
			for (int i = 0; i < Dots.Length; i++)
			{
				Dots[i] = new Point(rnd.Next() % 100, rnd.Next() % 100);
			}
		}

		/// <summary>
		/// Метод рисования
		/// </summary>
		public override void Draw()
		{
			// Pos.X Pos.Y - центр звезды
			Game.Buffer.Graphics.FillEllipse(Brushes.DarkViolet, new Rectangle(_Position.X - _Size.Width / 2, _Position.Y - _Size.Height / 2, _Size.Width, _Size.Height));
			int[] a = { 5, 4, 3, 0 };
			int k = 4;
			for (int i = 0; i < a.Length; i++)
			{
				Game.Buffer.Graphics.FillEllipse(Brushes.DarkViolet, new Rectangle(_Position.X - a[i] * _Size.Width / 3 / k - _Size.Width / 8,
				  _Position.Y - a[a.Length - i - 1] * _Size.Height / 3 / k - _Size.Height / 4, _Size.Width / 4, _Size.Height / 2));
				Game.Buffer.Graphics.FillEllipse(Brushes.DarkViolet, new Rectangle(_Position.X - a[i] * _Size.Width / 3 / k - _Size.Width / 8,
				  _Position.Y + a[a.Length - i - 1] * _Size.Height / 3 / k - _Size.Height / 4, _Size.Width / 4, _Size.Height / 2));
				Game.Buffer.Graphics.FillEllipse(Brushes.DarkViolet, new Rectangle(_Position.X + a[i] * _Size.Width / 3 / k - _Size.Width / 8,
				  _Position.Y - a[a.Length - i - 1] * _Size.Height / 3 / k - _Size.Height / 4, _Size.Width / 4, _Size.Height / 2));
				Game.Buffer.Graphics.FillEllipse(Brushes.DarkViolet, new Rectangle(_Position.X + a[i] * _Size.Width / 3 / k - _Size.Width / 8,
				  _Position.Y + a[a.Length - i - 1] * _Size.Height / 3 / k - _Size.Height / 4, _Size.Width / 4, _Size.Height / 2));
			}
			int kw = 70;
			int kh = 35;
			for (int i = 0; i < Dots.Length; i++)
			{
				float x = _Position.X - _Size.Width / 3f,
				  y = _Position.Y - _Size.Height / 3f,
				  dx = kw * Dots[i].X / 100f,
				  dy = kh * Dots[i].Y / 100f;

				Game.Buffer.Graphics.DrawLine(Pens.White, x + dx - 1, y + dy - 1, x + dx + 1, y + dy + 1);
				Game.Buffer.Graphics.DrawLine(Pens.White, x + dx - 1, y + dy + 1, x + dx + 1, y + dy - 1);
			}
		}

		/// <summary>
		/// Метод обновления
		/// </summary>
		public override void Update()
		{
			Random rnd = new Random();
			_Position.X += _Speed.X;
			if (_Position.X < -_Size.Width)
			{
				_Position.X = Game.Width + _Size.Width;
				_Position.Y = (rnd.Next() % (Game.Height - 120)) + 60;
				for (int i = 0; i < Dots.Length; i++)
				{
					Dots[i].X = rnd.Next() % 100;
					Dots[i].Y = rnd.Next() % 100;
				}
			}
		}

	}
}
