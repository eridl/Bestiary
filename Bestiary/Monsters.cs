using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Bestiary
{
    public partial class Monsters : Form
    {
        public int ID = 0;
        public Monsters(int ID_var)
        {
            InitializeComponent();

            
            get_Info("Select var.id_variation, var.variation_name as 'Вариация монстра', c.class_name as 'Класс монстра', t.type_name as 'Тип монстра', vul.vulnerability_name as 'Уязвимость монстра', l.loot_name as 'Добыча с монстра', var.monster_desc as 'Описание монстра' from class c join variation var on c.id_class = var.id_class join type t on var.id_type = t.id_type join vulnerability vul on var.id_vulnerability = vul.id_vulnerability join loot l on var.id_loot = l.id_loot");
            ID = ID_var;
        }


        public void get_Info(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
                dataGridView1.Columns[0].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так" + Environment.NewLine + ex.Message);
            }
        }

        private void Monsters_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                MonsterProfile win = new MonsterProfile(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()), "chng", ID);
                win.Owner = this;
                this.Hide();
                win.Show();
            }
        }

        class DoubleBufferedDataGridView : DataGridView
        {
            protected override bool DoubleBuffered { get => true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            MonsterProfile win = new MonsterProfile(0, "add", ID);
            win.Owner = this;
            this.Hide();
            win.Show();
        }


        private void search_TextChanged(object sender, EventArgs e)
        {
            get_Info("select var.id_variation, var.variation_name as 'Вариация монстра', c.class_name as 'Класс монстра', t.type_name as 'Тип монстра', vul.vulnerability_name as 'Уязвимость монстра', l.loot_name as 'Добыча с монстра', var.monster_desc as 'Описание монстра' from class c join variation var on c.id_class = var.id_class join type t on var.id_type = t.id_type join vulnerability vul on var.id_vulnerability = vul.id_vulnerability join loot l on var.id_loot = l.id_loot where concat (var.variation_name, c.class_name, vul.vulnerability_name, t.type_name, l.loot_name, var.monster_desc) like '%" + search.Text + "%'; ");
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            get_Info("Select var.id_variation, var.variation_name as 'Вариация монстра', c.class_name as 'Класс монстра', t.type_name as 'Тип монстра', vul.vulnerability_name as 'Уязвимость монстра', l.loot_name as 'Добыча с монстра', var.monster_desc as 'Описание монстра' from class c join variation var on c.id_class = var.id_class join type t on var.id_type = t.id_type join vulnerability vul on var.id_vulnerability = vul.id_vulnerability join loot l on var.id_loot = l.id_loot");

        }

        private void Monsters_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
