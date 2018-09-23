using System;
using System.Windows.Forms;

namespace StarWars
{
    internal class StarWarsForm : Form
    {
        public Button btnNew;
        public Button btnRecords;
        public Button btnExit;

        internal StarWarsForm()
        {
            Init();
        }

        internal void Init()
        {
            btnNew = new Button();
            btnRecords = new Button();
            btnExit = new Button();

            btnNew.Text = "Новая игра";
            btnNew.Top = 10;
            btnRecords.Text = "Рекорды";
            btnRecords.Top = 10;
            btnRecords.Left = 80;
            btnExit.Text = "Выход";
            btnExit.Top = 10;
            btnExit.Left = 160;

            this.Controls.AddRange(new Control[] { btnNew, btnRecords, btnExit });

            btnNew.Click += BtnNew_Click;
            btnRecords.Click += BtnRecords_Click;
            btnExit.Click += BtnExit_Click;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRecords_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        internal void BtnNew_Click(object sender, EventArgs e)
        {

            Game.Load(this);           // Загрузка данных игровой логики
            Game.Init(this);  // Инициализация игровой логики

            this.Show();      // Показываем форму на экране
        }

    }
}
