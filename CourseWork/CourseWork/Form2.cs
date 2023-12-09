using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CourseWork
{
	public partial class Form2 : Form
	{
        /// <summary>Инициализация формы</summary>
        public Form2() => InitializeComponent();

        /// <summary>Переменная для записи имени</summary>
		public string GetName => ParticipantName.Text;
        /// <summary>Переменная для записи отчества</summary>
        public string GetLastname => ParticipantLastname.Text;

        /// <summary>Проверка на корректность ввода</summary>
        /// <param name="tb">The tb.</param>
        bool CheckOnCorrectTextBox(TextBox tb) => string.IsNullOrEmpty(tb.Text) || !Regex.IsMatch(tb.Text, @"^\s*$") && Regex.IsMatch(tb.Text, @"^[а-яА-Яa-zA-Z ]+$") || (tb.BackColor = Color.Red) != Color.Red;

        /// <summary>Функция изменения цвета поля ввода</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        void TextBox_Click(object sender, EventArgs e) => (sender as TextBox).BackColor = Color.White;
        /// <summary>Фильтрация по заданным критериям</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        void Button1_Click(object sender, EventArgs e) => DialogResult = CheckOnCorrectTextBox(ParticipantName) & CheckOnCorrectTextBox(ParticipantLastname) ? DialogResult.OK : DialogResult.None;
	}
}