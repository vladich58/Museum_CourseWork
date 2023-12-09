using System.Windows.Forms;

namespace CourseWork
{
	public partial class Form3 : Form
	{
        /// <summary>Инициализация формы</summary>
        public Form3() => InitializeComponent();

        /// <summary>Переменная для записи ID</summary>
        public int GetDelPartIndex => (int)DelPartIndex.Value;
    }
}
