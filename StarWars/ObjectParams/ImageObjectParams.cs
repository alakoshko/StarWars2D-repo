using System;
using System.Drawing;
using StarWars.Properties;

namespace StarWars
{
	/// <summary>
	/// Класс параметров объекта космического пространства
	/// </summary>
	public class ImageObjectParams : BaseObjectParams
	{
		/// <summary>
		/// Изображение
		/// </summary>
		public Image ObjectImage { get; set; } = Resources.bigStar2;

    }
}
