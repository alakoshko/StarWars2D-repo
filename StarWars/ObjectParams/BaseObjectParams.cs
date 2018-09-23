using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
	/// <summary>
	/// Базовый класс настроек объекта
	/// </summary>
	public class BaseObjectParams
	{
        /// <summary>
        /// Положение на игровой сцене
        /// </summary>
        public Point Position { get; set; }

        /// <summary>
        /// Скорость перемещения между кадрами
        /// </summary>
        public Point Speed { get; set; }

        /// <summary>
        /// Размер на игровой сцене
        /// </summary>
        public Size Size { get; set; }
	}
}
