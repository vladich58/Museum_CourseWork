using System;
using System.IO;
using System.Linq;
using System.Drawing;
using Newtonsoft.Json;
using System.Collections;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CourseWork
{
	public partial class Form1 : Form
	{
        /// <summary>Файл посещений</summary>
        const string PFILENAME = "Participants.json";
        /// <summary>Файл экспонатов</summary>
        const string EFILENAME = "Exhibits.json";

		struct Participant
		{
            /// <summary>Имя посетителя</summary>
            public string name;
            /// <summary>Фамилия посетителя</summary>
            public string surname;
            /// <summary>Отчество посетителя</summary>
            public string lastname;
            /// <summary>Дата и время посещения</summary>
            public string time;
		}

		struct Exhibit
		{
            /// <summary>Название экспоната</summary>
            public string name;
            /// <summary>Эпоха, к которой относится</summary>
            public string era;
            /// <summary>Оригинальность экспоната</summary>
            public string originality;
            /// <summary>Дата создания</summary>
            public string birth;
		}

		public Form1()
		{
			Task.Run(() => File.Open(PFILENAME, FileMode.OpenOrCreate).Close());
			Task.Run(() => File.Open(EFILENAME, FileMode.OpenOrCreate).Close());

			using (var form4 = new Form4())
			{
				form4.ShowDialog();
			}

			InitializeComponent();
		}

        /// <summary>Запись в файл посетителей</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataP">The data p.</param>
        async Task WriteToFileP<T>(List<T> dataP)
		{
			using (var streamWriterP = new StreamWriter(PFILENAME, false))
			{
				await streamWriterP.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(dataP)));
			}
		}

        /// <summary>Запись в файл экспонатов</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataE">The data e.</param>
        async Task WriteToFileE<T>(List<T> dataE)
		{
			using (var streamWriterE = new StreamWriter(EFILENAME, false))
			{
				await streamWriterE.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(dataE)));
			}
		}

        /// <summary>Чтение из файла посетителей</summary>
        /// <typeparam name="T"></typeparam>
        async Task<List<T>> ReadFromFileP<T>()
		{
			using (var streamReaderP = new StreamReader(PFILENAME))
			{
				return await Task.Run(async () => JsonConvert.DeserializeObject<List<T>>(await streamReaderP.ReadToEndAsync()) ?? new List<T>());
			}
		}

        /// <summary>Чтение из файла экспонатов</summary>
        /// <typeparam name="T"></typeparam>
        async Task<List<T>> ReadFromFileE<T>()
		{
			using (var streamReaderE = new StreamReader(EFILENAME))
			{
				return await Task.Run(async () => JsonConvert.DeserializeObject<List<T>>(await streamReaderE.ReadToEndAsync()) ?? new List<T>());
			}
		}

        /// <summary>Добавление записи в файл посетителей</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">The data.</param>
        async Task AddToFileP<T>(T data)
		{
			var datas = await ReadFromFileP<T>();
			datas.Add(data);
			await WriteToFileP(datas);
		}

        /// <summary>Добавление записи в файл экспонатов</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">The data.</param>
        async Task AddToFileE<T>(T data)
		{
			var datas = await ReadFromFileE<T>();
			datas.Add(data);
			await WriteToFileE(datas);
		}

        /// <summary>Удаление записи из файла посетителей</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="index">The index.</param>
        async Task DeleteFromFileAtP<T>(int index)
		{
			var datas = await ReadFromFileP<T>();
			datas.RemoveAt(index);
			await WriteToFileP(datas);
		}

        /// <summary>Удаление записи из файла экспонатов</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="index">The index.</param>
        async Task DeleteFromFileAtE<T>(int index)
		{
			var datas = await ReadFromFileE<T>();
			datas.RemoveAt(index);
			await WriteToFileE(datas);
		}

        /// <summary>Проверка корректности ввода в текстовые поля</summary>
        /// <param name="tb">The tb.</param>
        bool CheckOnCorrectTextBox(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") && Regex.IsMatch(tb.Text, @"^[а-яА-Яa-zA-Z ]+$") || (tb.BackColor = Color.Red) != Color.Red;
        /// <summary>Проверка выбора значения в выпадающем списке</summary>
        /// <param name="cb">The cb.</param>
        bool CheckOnCorrectComboBox(ComboBox cb) => !(cb.SelectedItem is null) || (cb.BackColor = Color.Red) != Color.Red;

        /// <summary>Проверка на корректность всех полей при регистрации посетителя</summary>
        bool CheckOnCorrectFieldsP =>
			CheckOnCorrectTextBox(Firstname) &
			CheckOnCorrectTextBox(Surname) &
			CheckOnCorrectTextBox(Lastname);

        /// <summary>Проверка на корректность всех полей при регистрации экспоната</summary>
        bool CheckOnCorrectFieldsE =>
			CheckOnCorrectTextBox(ExNameBox) &
			CheckOnCorrectComboBox(ExEraBox) &
			CheckOnCorrectComboBox(ExOriginalityBox);

        /// <summary>Очистка всех полей в форме регистрации посетителя</summary>
        void ClearAllFieldP()
		{
			Firstname.Text = Surname.Text = Lastname.Text = default;
		}

        /// <summary>Очистка всех полей в форме регистрации экспоната</summary>
        void ClearAllFieldE()
		{
			ExNameBox.Text = ExEraBox.Text = ExOriginalityBox.Text = default;

		}

        /// <summary>Добавление записи о посещение</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        async void RegParticipant_Click(object sender, EventArgs e)
		{
			if (CheckOnCorrectFieldsP)
			{
				await AddToFileP(new Participant
				{
					name = Firstname.Text,
					surname = Surname.Text,
					lastname = Lastname.Text,
					time = DateTime.Now.ToString()
				});

				ClearAllFieldP();

				MessageBox.Show("Пользователь зарегистрирован");
				return;
			}

			MessageBox.Show("Введите корректные данные");
		}

        /// <summary>Добавление записи об экспонате</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        async void RegExhibit_Click(object sender, EventArgs e)
		{
			if (CheckOnCorrectFieldsE)
			{
				await AddToFileE(new Exhibit
				{
					name = ExNameBox.Text,
					era = ExEraBox.SelectedItem as string,
					originality = ExOriginalityBox.SelectedItem as string,
					birth = Convert.ToString(ExBirthBox.Value)
				});

				ClearAllFieldE();

				MessageBox.Show("Экспонат зарегистрирован");
				return;
			}

			MessageBox.Show("Введите корректные данные");
		}

        /// <summary>Вывод данных о посещениях из файла в таблицу</summary>
        /// <param name="participants">The participants.</param>
        void DisplayDataP(List<Participant> participants)
		{
			Display.Items.Clear();

			var i = 0;
			foreach (var participant in participants)
			{
				var listViewItemP = new ListViewItem(i.ToString());
				listViewItemP.SubItems.Add(participant.surname);
				listViewItemP.SubItems.Add(participant.name);
				listViewItemP.SubItems.Add(participant.lastname);
				listViewItemP.SubItems.Add(participant.time);


				Display.Items.Add(listViewItemP);
				++i;
			}
		}

        /// <summary>Вывод данных об экспонатах из файла в таблицу</summary>
        /// <param name="exhibits">The exhibits.</param>
        void DisplayDataE(List<Exhibit> exhibits)
		{
			ExDisplay.Items.Clear();

			var j = 0;
			foreach (var exhibit in exhibits)
			{
				var listViewItemE = new ListViewItem(j.ToString());
				listViewItemE.SubItems.Add(exhibit.name);
				listViewItemE.SubItems.Add(exhibit.era);
				listViewItemE.SubItems.Add(exhibit.originality);
				listViewItemE.SubItems.Add(exhibit.birth);


				ExDisplay.Items.Add(listViewItemE);
				++j;
			}
		}

        /// <summary>Отображение всех данных о посещениях</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        async void Display_SelectedIndexChangedP(object sender, EventArgs e) => DisplayDataP(await ReadFromFileP<Participant>());
        /// <summary>Отображение всех данных об экспонатах</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        async void Display_SelectedIndexChangedE(object sender, EventArgs e) => DisplayDataE(await ReadFromFileE<Exhibit>());

        /// <summary>Класс сортировки</summary>
        class ListViewItemComparer : IComparer
		{
			public int column;
			public int Compare(object x, object y) => string.Compare((x as ListViewItem).SubItems[column].Text, (y as ListViewItem).SubItems[column].Text);
		}

        /// <summary>Сортировка посетителей при нажатии на колонку</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ColumnClickEventArgs" /> instance containing the event data.</param>
        void Display_ColumnClick(object sender, ColumnClickEventArgs e) => Display.ListViewItemSorter = new ListViewItemComparer { column = e.Column };

        /// <summary>Сортировка экспонатов при нажатии на колонку</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ColumnClickEventArgs" /> instance containing the event data.</param>
        void ExDisplay_ColumnClick(object sender, ColumnClickEventArgs e) => ExDisplay.ListViewItemSorter = new ListViewItemComparer { column = e.Column };

        /// <summary>Фильтр по имени и/или отчеству</summary>
        async void ShowSearch()
		{
			using (var form2 = new Form2())
			{
				if (form2.ShowDialog() == DialogResult.OK)
				{
					var queryResult =
						from participant in await ReadFromFileP<Participant>()
						where string.IsNullOrEmpty(form2.GetName) || participant.name == form2.GetName
						where string.IsNullOrEmpty(form2.GetLastname) || participant.lastname == form2.GetLastname
						select participant;

					DisplayDataP(queryResult.ToList());
				}
			}
		}

        /// <summary>Удаление записи о посещении</summary>
        async void ShowDeleteP()
		{
			using (var form3 = new Form3())
			{
				if (form3.ShowDialog() == DialogResult.OK)
				{
					try
					{
						await DeleteFromFileAtP<Participant>(form3.GetDelPartIndex);
						DisplayDataP(await ReadFromFileP<Participant>());
					}
					catch (ArgumentOutOfRangeException)
					{
						MessageBox.Show("Пользователя с таким ID не существует");
					}
				}
			}
		}

        /// <summary>Удаление записи об экспонате</summary>
        async void ShowDeleteE()
		{
			using (var form5 = new Form5())
			{
				if (form5.ShowDialog() == DialogResult.OK)
				{
					try
					{
						await DeleteFromFileAtE<Exhibit>(form5.GetDelExIndex);
						DisplayDataE(await ReadFromFileE<Exhibit>());
					}
					catch (ArgumentOutOfRangeException)
					{
						MessageBox.Show("Экспоната с таким ID не существует");
					}
				}
			}
		}

        /// <summary>Вызов форм фильтрации и удаления </summary>
        /// <param name="message">The message.</param>
        /// <param name="keys">The keys.</param>
        protected override bool ProcessCmdKey(ref Message message, Keys keys)
		{
			if (tabControl1.SelectedTab == ListOfAllParticipants)
			{
				switch (keys)
				{
					case Keys.Control | Keys.E:
						ShowDeleteE();
						return true;

					case Keys.Control | Keys.P:
						ShowDeleteP();
						return true;

					case Keys.Control | Keys.S:
						ShowSearch();
						return true;
				}
			}

			return base.ProcessCmdKey(ref message, keys);
		}

		void TextBox_Click(object sender, EventArgs e) => (sender as Control).BackColor = Color.White;

		void ComboBox_Click(object sender, EventArgs e) => (sender as Control).BackColor = Color.White;

		private void RegistrationOfParticipants_Click(object sender, EventArgs e)
		{

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void Display_SelectedIndexChanged(object sender, EventArgs e)
		{

		}


		private void ExDisplay_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}