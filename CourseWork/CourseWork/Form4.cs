using System.Windows.Forms;

namespace CourseWork
{
	public partial class Form4 : Form
	{
        /// <summary>Инициализация формы</summary>
        public Form4() => InitializeComponent();
        /// <summary>Запуск программы при нажатии любой клавиши</summary>
        /// <param name="message">The message.</param>
        /// <param name="keys">The keys.</param>
        protected override bool ProcessCmdKey(ref Message message, Keys keys) => (DialogResult = DialogResult.OK) == DialogResult.OK;
	}
}
