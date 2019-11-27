using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sims_6_magic_ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       string[][] a =
        {
            new string[] { "Бесспорно", "Предрешено", "Никаких сомнений", "Определённо да", "Можешь быть уверен в этом"},
            new string[] { "Мне кажется — «да»", "Вероятнее всего", "Хорошие перспективы", "Знаки говорят — «да»", "Да"},
            new string[] { "Пока не ясно, попробуй снова", "Спроси позже", "Лучше не рассказывать", "Сейчас нельзя предсказать", "Сконцентрируйся и спроси опять" },
            new string[] { "Даже не думай", "Мой ответ — «нет»", "По моим данным — «нет»", "Перспективы не очень хорошие", "Весьма сомнительно" }
        };
        Random rnd = new Random();
        double alpha;

        private void button1_Click(object sender, EventArgs e)
        {
            c();
            if(textBox1.Text!="")
            {
                int k = 0, i = 0;
                alpha = rnd.NextDouble() * 4;
                k = s(alpha, k);
                alpha = rnd.NextDouble() * 5;
                i = s(alpha, i);
                answer.Text = a[k][i];
            }
            else
            {
                warning.Visible = true;
            }
        }

        private void c()
        {
            answer.Text = "";
            warning.Visible = false;
        }

        private int s(double alpha, int k)
        {
            while (alpha > 0)
            {
                alpha -= 1;
                k++;
            }
            return k - 1;
        }
    }
}
