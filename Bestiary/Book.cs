using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bestiary
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                conn.Close();
            } catch(Exception ex)
            {
                MessageBox.Show("Не удалось открыть книгу. Похоже на древнюю магическую печать." + Environment.NewLine + ex.Message);
            }
            Contents win = new Contents();
            win.Owner = this;
            this.Hide();
            win.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здравствуй путник."+Environment.NewLine+ "" + Environment.NewLine + "Я першел дорогу влиятельным людям. Мне больше нет места ни в Каэдвене, ни в Редании, Аэдирн и Темерия отвернулись от меня, Цинтра и Содден мне больше не союзники, а скрыться на островах Скеллиге я уже не успею." + Environment.NewLine+ "" + Environment.NewLine + "Время уходит." + Environment.NewLine+"Я не смог найти достойного преемника, поэтому придется возложить эту ношу на первого встречного."+Environment.NewLine+ "" + Environment.NewLine + "Мне приходилось часто путешествовать по Неверленду, я сталкивался с огромным количеством монстров, о которых простой люд слышал только в сказках."+Environment.NewLine+ "В дорогу к моим приключениям нужен был Бестиарий, хранящий в себе знания о каждом опасном существе этого мира и последтсвий Сопряжения Сфер."+Environment.NewLine+ "Такая книга могла бы быть невероятно огромной и тяжелой, она не сгодилось бы под мои нужды."+Environment.NewLine+"Именно поэтому я собственноручно создал книгу одним мощным заклинанием, которое я нашел в древних письменах." + Environment.NewLine+ ""+Environment.NewLine+ "Мои чернила позволят тебе бесконечно вписывать все новых и новых монстров, встречающихся тебе на пути, а заклинание не даст страницам книги закончиться, при этом книга помещается в набедренную сумку, не занимая много места."+Environment.NewLine+ "Чтобы вспользоваться книгой, просто прошепчи слова старшей речи: 'Va'esse deireadh aep eigean, va'esse eigh faidh'ar'."+Environment.NewLine+"Если тебе нужно спрятать свои написанное, прошепчи 'Va faill', и книга скроет знания от посторонних глаз." + Environment.NewLine+""+Environment.NewLine+"Я буду тебе очень благодарен, если мои труды будут не напрасны.");
        }
    }
}
