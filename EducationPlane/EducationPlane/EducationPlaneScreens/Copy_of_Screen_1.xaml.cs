using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EducationPlaneScreens
{
    /// <summary>
    /// Interaction logic for Copy_of_Screen_1.xaml
    /// </summary>
    public partial class Copy_of_Screen_1 : UserControl
    {
        public Copy_of_Screen_1()
        {
            this.InitializeComponent();
        }

            
    public class kaf
    {
        public string name {get; set;}
        public string nom { get; set; }
    }
        private void Textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

      

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
        }


        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (Combo.SelectedItem == "Информатика")
            {
                Document.Text = "Часов по УП:  504;  Часов по РПД: 504" + Environment.NewLine +
  "Часов по УП (без учета часов на экзамены): 504;  Часов по РПД: 504;" + Environment.NewLine +
  "Часов на интерактивные формы (ИФ) обучения по УП:" + Environment.NewLine +
  "Часов на интерактивные формы (ИФ) обучения по РПД:" + Environment.NewLine +
  "Часов на самостоятельную работу по УП: 108 (21 %);" + Environment.NewLine +
  "Часов на самостоятельную работу по РПД: 108 (21 %)" + Environment.NewLine +
  "Общая трудоемкость в ЗЕТ: 14;" + Environment.NewLine +
  "Виды контроля в семестрах (на курсах): Экзамены -3; Зачеты – 1; Зачеты с оценкой –0;  Кур-совые проекты - 0; Курсовые работы - 1." + Environment.NewLine +
  "Форма обучения: очная;" + Environment.NewLine +
  "Срок обучения:  нормативный.";
                Generate.IsEnabled = true;
            }
            if (Combo.SelectedItem == "Теория принятия решений")
            {
                Document.Text = "Часов по УП:  360;  Часов по РПД: 360" + Environment.NewLine +
           "Часов по УП (без учета часов на экзамены): 360;  Часов по РПД: 360;" + Environment.NewLine +
           "Часов на интерактивные формы (ИФ) обучения по УП:" + Environment.NewLine +
           "Часов на интерактивные формы (ИФ) обучения по РПД:" + Environment.NewLine +
           "Часов на самостоятельную работу по УП: 108 (30 %);" + Environment.NewLine +
           "Часов на самостоятельную работу по РПД: 108 (30 %)" + Environment.NewLine +
           "Общая трудоемкость в ЗЕТ: 10;" + Environment.NewLine +
           "Виды контроля в семестрах (на курсах): Экзамены -0; Зачеты – 0; Зачеты с оценкой –1;  Кур-совые проекты - 0; Курсовые работы - 0." + Environment.NewLine +
           "Форма обучения: очная;" + Environment.NewLine +
           "Срок обучения:  нормативный.";
                Generate.IsEnabled = true;
            }
            if (Combo.SelectedItem == "Основы ООП")
            {
                Document.Text = "Часов по УП:  108;  Часов по РПД: 108" + Environment.NewLine +
          "Часов по УП (без учета часов на экзамены): 108;  Часов по РПД: 108;" + Environment.NewLine +
          "Часов на интерактивные формы (ИФ) обучения по УП:" + Environment.NewLine +
          "Часов на интерактивные формы (ИФ) обучения по РПД:" + Environment.NewLine +
          "Часов на самостоятельную работу по УП: 36 (33 %);" + Environment.NewLine +
          "Часов на самостоятельную работу по РПД: 36 (33 %)" + Environment.NewLine +
          "Общая трудоемкость в ЗЕТ: 3;" + Environment.NewLine +
          "Виды контроля в семестрах (на курсах): Экзамены -1; Зачеты – 0; Зачеты с оценкой –2;  Кур-совые проекты - 0; Курсовые работы - 0." + Environment.NewLine +
          "Форма обучения: очная;" + Environment.NewLine +
          "Срок обучения:  нормативный.";
                Generate.IsEnabled = true;
            }
        }

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Generate.IsEnabled = false;
            Document.Text = "";
            Combo.Items.Clear();
            _ref.IsEnabled = false;
            Textblock1.Text = "С:\\Учебный план\\kitp.xml";
            data.IsEnabled = true;
            Combo.IsEnabled = false;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            
            _ref.IsEnabled = true;
            if (Textblock1.Text == "")
                MessageBox.Show("Не выбран файл!");
            else
            {
                Generate.IsEnabled = false;
                Document.Text = "";
                Combo.Items.Clear();
                Combo.Items.Add("Теория принятия решений");
                Combo.Items.Add("Информатика");
                Combo.Items.Add("Основы ООП");
                Combo.IsEnabled = true;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Шаблон успешно сгенерирован и сохранен в директорию программы");
        }

        private void ListView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void kaftab_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void load_Click(object sender, RoutedEventArgs e)
        {
            t1.Items.Clear();
            t2.Items.Clear();
            t3.Items.Clear();
            p1.Opacity = 100;
            p2.Opacity = 100;
            p3.Opacity = 100;
            t1.Opacity = 100;
            t2.Opacity = 100;
            t3.Opacity = 100;
            t1.Items.Add("Петров А. В.");
            t1.Items.Add("Сидорова М. Н.");
            t1.Items.Add("Иванов Н. П.");
            t2.Items.Add("Петров А. В.");
            t2.Items.Add("Сидорова М. Н.");
            t2.Items.Add("Иванов Н. П.");
            t3.Items.Add("Петров А. В.");
            t3.Items.Add("Сидорова М. Н.");
            t3.Items.Add("Иванов Н. П.");
            t1.SelectedIndex = n1;
            t2.SelectedIndex = n2;
            t3.SelectedIndex = n3;
            save.IsEnabled = true;
        }
        int n1 = 2;
        int n2 = 3;
        int n3 = 1;
        private void _ref_Click(object sender, RoutedEventArgs e)
        {
            t1.Items.Clear();
            t2.Items.Clear();
            t3.Items.Clear();
            p1.Opacity = 100;
            p2.Opacity = 100;
            p3.Opacity = 100;
            t1.Opacity = 100;
            t2.Opacity = 100;
            t3.Opacity = 100;
            t1.Items.Add("Петров А. В.");
            t1.Items.Add("Сидорова М. Н.");
            t1.Items.Add("Иванов Н. П.");
            t2.Items.Add("Петров А. В.");
            t2.Items.Add("Сидорова М. Н.");
            t2.Items.Add("Иванов Н. П.");
            t3.Items.Add("Петров А. В.");
            t3.Items.Add("Сидорова М. Н.");
            t3.Items.Add("Иванов Н. П.");
            save.IsEnabled = true;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            n1 = t1.SelectedIndex;
            n2 = t2.SelectedIndex;
            n3 = t3.SelectedIndex;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
           
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            
        }
       
        
        

    } 
        
    }
