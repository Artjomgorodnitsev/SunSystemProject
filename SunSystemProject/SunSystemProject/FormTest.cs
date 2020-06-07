using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunSystemProject
{
    public partial class FormTest : Form
    {
        private int m, s, ms;
        public List<string> voprosi;
        int num;
        string vopros;
        string potvet;
        int balli = 0;
        int randomm = 9;
        public Random random = new Random();
        int kolotvetov = 0;


        public FormTest()
        {
            InitializeComponent();


            voprosi = new List<string>() { "Какая по счету от Солнца планета Земля?", "Эта планета могла стать звездой, но не набрала достаточно массы:", "Сколько спутников у Марса?",
             "Солнце – типичный представитель этого класса звезд:","Ближайшая к Солнцу планета:","Сколько всего планет в Солнечной системе?","Первооткрывателем законов движения планет Солнечной системы был:","Самая большая планета Солнечной системы?","Самый большой спутник в Солнечной системе:"};
        }

        private void buttonGameStart_Click(object sender, EventArgs e)
        {
            buttonGameStart.Visible = false;//кнопка начать игру пропадает
            timer1.Enabled = true;//таймер начинаеться
            num = random.Next(0, randomm);//береться рандомный индекс
            vopros = voprosi[num];
            label1.Text = voprosi[num];
            voprosi.RemoveAt(num);//удаляеться вопрос
            randomm -= 1;
            num = 0;

            switch (vopros)
            {
                case "Какая по счету от Солнца планета Земля?":
                    radioButton1.Text = "первая";
                    radioButton2.Text = "вторая";
                    radioButton3.Text = "третья+";
                    radioButton4.Text = "четвертая";
                    potvet = "radioButton3";
                    break;
                case "Эта планета могла стать звездой, но не набрала достаточно массы:":
                    radioButton1.Text = "Юпитер+";
                    radioButton2.Text = "Меркурий";
                    radioButton3.Text = "Нептун";
                    radioButton4.Text = "Сатурн";
                    potvet = "radioButton1";
                    break;
                case "Сколько спутников у Марса?":
                    radioButton1.Text = "у Марса нет спутников";
                    radioButton2.Text = "один спутник";
                    radioButton3.Text = "два спутника+";
                    radioButton4.Text = "пять спутников";
                    potvet = "radioButton3";
                    break;
                case "Солнце – типичный представитель этого класса звезд:":
                    radioButton1.Text = "желтый карлик+";
                    radioButton2.Text = "белый карлик";
                    radioButton3.Text = "красный гигант";
                    radioButton4.Text = "пульсар";
                    potvet = "radioButton1";
                    break;
                case "Ближайшая к Солнцу планета:":
                    radioButton1.Text = "Земля";
                    radioButton2.Text = "Юпитер";
                    radioButton3.Text = "Марс";
                    radioButton4.Text = "Меркурий+";
                    potvet = "radioButton4";
                    break;
                case "Сколько всего планет в Солнечной системе?":
                    radioButton1.Text = "шесть";
                    radioButton2.Text = "семь";
                    radioButton3.Text = "восемь+";
                    radioButton4.Text = "девять";
                    potvet = "radioButton3";
                    break;
                case "Первооткрывателем законов движения планет Солнечной системы был:":
                    radioButton1.Text = "Николай Коперник";
                    radioButton2.Text = "Иоганн Кеплер+";
                    radioButton3.Text = "Джордано Бруно";
                    radioButton4.Text = "Жак Кассини";
                    potvet = "radioButton2";
                    break;
                case "Самая большая планета Солнечной системы?":
                    radioButton1.Text = "Уран";
                    radioButton2.Text = "Церера";
                    radioButton3.Text = "Сатурн";
                    radioButton4.Text = "Юпитер+";
                    potvet = "radioButton4";
                    break;
                case "Самый большой спутник в Солнечной системе:":
                    radioButton1.Text = "Ио";
                    radioButton2.Text = "Ганимед+";
                    radioButton3.Text = "Европа";
                    radioButton4.Text = "Фобос";
                    potvet = "radioButton2";
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (kolotvetov < 8)
            {


                kolotvetov++;
                label5.Text = kolotvetov.ToString() + " / 8";
                num = 0;
                randomm -= 1;
                num = random.Next(0, randomm);
                if (radioButton1.Name == potvet && radioButton1.Checked)
                {

                    ffgf();
                    balli++;
                    label2.Text = "Правильных ответов: " + balli.ToString();

                }
                else if (radioButton2.Name == potvet && radioButton2.Checked)
                {

                    ffgf();
                    balli++;
                    label2.Text = "Правильных ответов: " + balli.ToString();
                }
                else if (radioButton3.Name == potvet && radioButton3.Checked)
                {

                    ffgf();
                    balli++;
                    label2.Text = "Правильных ответов: " + balli.ToString();

                }
                else if (radioButton4.Name == potvet && radioButton4.Checked)
                {

                    ffgf();
                    balli++;
                    label2.Text = "Правильных ответов: " + balli.ToString();

                }
                else
                {
                    ffgf();
                }
            }
            else
            {
                label1.Text = "konec";
            }

        }





        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonExitForm1_Click(object sender, EventArgs e)
        {
            this.Close();



        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ms += 1;
            if (ms == 60)
            {
                ms = 0;
                s += 1;
            }
            if (s == 60)
            {
                s = 0;
                m += 1;
            }
            times.Text = m.ToString() + " : " + s.ToString() + " : " + ms.ToString();
        }
        public void ffgf()
        {


            vopros = voprosi[num];
            label1.Text = vopros;
            voprosi.RemoveAt(num);


            switch (vopros)
            {
                case "Какая по счету от Солнца планета Земля?":
                    radioButton1.Text = "первая";
                    radioButton2.Text = "вторая";
                    radioButton3.Text = "третья+";
                    radioButton4.Text = "четвертая";
                    potvet = "radioButton3";
                    break;
                case "Эта планета могла стать звездой, но не набрала достаточно массы:":
                    radioButton1.Text = "Юпитер+";
                    radioButton2.Text = "Меркурий";
                    radioButton3.Text = "Нептун";
                    radioButton4.Text = "Сатурн";
                    potvet = "radioButton1";
                    break;
                case "Сколько спутников у Марса?":
                    radioButton1.Text = "у Марса нет спутников";
                    radioButton2.Text = "один спутник";
                    radioButton3.Text = "два спутника+";
                    radioButton4.Text = "пять спутников";
                    potvet = "radioButton3";
                    break;
                case "Солнце – типичный представитель этого класса звезд:":
                    radioButton1.Text = "желтый карлик+";
                    radioButton2.Text = "белый карлик";
                    radioButton3.Text = "красный гигант";
                    radioButton4.Text = "пульсар";
                    potvet = "radioButton1";
                    break;
                case "Ближайшая к Солнцу планета:":
                    radioButton1.Text = "Земля";
                    radioButton2.Text = "Юпитер";
                    radioButton3.Text = "Марс";
                    radioButton4.Text = "Меркурий+";
                    potvet = "radioButton4";
                    break;
                case "Сколько всего планет в Солнечной системе?":
                    radioButton1.Text = "шесть";
                    radioButton2.Text = "семь";
                    radioButton3.Text = "восемь+";
                    radioButton4.Text = "девять";
                    potvet = "radioButton3";
                    break;
                case "Первооткрывателем законов движения планет Солнечной системы был:":
                    radioButton1.Text = "Николай Коперник";
                    radioButton2.Text = "Иоганн Кеплер+";
                    radioButton3.Text = "Джордано Бруно";
                    radioButton4.Text = "Жак Кассини";
                    potvet = "radioButton2";
                    break;
                case "Самая большая планета Солнечной системы?":
                    radioButton1.Text = "Уран";
                    radioButton2.Text = "Церера";
                    radioButton3.Text = "Сатурн";
                    radioButton4.Text = "Юпитер+";
                    potvet = "radioButton4";
                    break;
                case "Самый большой спутник в Солнечной системе:":
                    radioButton1.Text = "Ио";
                    radioButton2.Text = "Ганимед+";
                    radioButton3.Text = "Европа";
                    radioButton4.Text = "Фобос";
                    potvet = "radioButton2";
                    break;
            }
        }
    }
}
