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
    public partial class MonsterProfile : Form
    {
        public int ID_monster = 0;
        public MonsterProfile(int ID_m, string mode, int ID)
        {
            InitializeComponent();
            if (mode == "chng")
            {
                name_box.Visible = false;
                class_box.Visible = false;
                vulnerability_box.Visible = false;
                type_box.Visible = false;
                loot_box.Visible = false;
                bio_box.ReadOnly = true;
            }
            else if(mode == "add")
            {
                name_label.Visible = false;
                class_label.Visible = false;
                vulnerability_label.Visible = false;
                type_label.Visible = false;
                loot_label.Visible = false;
                bio_box.ReadOnly = false;
                del_btn.Visible = false;
                chng_btn.Text = "Добавить";
            }

            getBoxes("select class_name from class;", class_box);
            getBoxes("select vulnerability_name from vulnerability;", vulnerability_box);
            getBoxes("select variation_name from variation;", name_box);
            getBoxes("select type_name from type;", type_box);
            getBoxes("Select loot_name from loot;", loot_box);
            get_Info(ID_m);
            ID_monster = ID_m;

        }
        public void getBoxes(string query, ComboBox box)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        box.Items.Add(rd.GetString(0));
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка1" + Environment.NewLine + ex.Message);
            }
        }

        public void get_Info(int ID)
        {
            string query = "Select var.variation_name, c.class_name, vul.vulnerability_name, t.type_name, l.loot_name, var.monster_desc from class c join variation var on c.id_class = var.id_class join type t on var.id_type = t.id_type join vulnerability vul on var.id_vulnerability = vul.id_vulnerability join loot l on var.id_loot = l.id_loot WHERE var.id_variation =" + ID.ToString() + ";";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    name_label.Text = rd.GetString(0);
                    class_label.Text = rd.GetString(1);
                    vulnerability_label.Text = rd.GetString(2);
                    type_label.Text = rd.GetString(3);
                    loot_label.Text = rd.GetString(4);
                    bio_box.Text = rd.GetString(5);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка загрузки информации!" + Environment.NewLine + ex.Message);
            }
        }

        private void MonsterProfile_Load(object sender, EventArgs e)
        {

        }

        private void chng_btn_Click(object sender, EventArgs e)
        {
            switch (chng_btn.Text)
            {
                case "Добавить":
                    doAction("insert into variation (variation_name, id_class, id_vulnerability, id_type, id_loot, monster_desc) values ('"+name_box.Text+"',"+(class_box.SelectedIndex + 1).ToString()+","+(vulnerability_box.SelectedIndex+1).ToString()+","+(type_box.SelectedIndex+1).ToString()+","+(loot_box.SelectedIndex+1).ToString()+",'"+bio_box.Text+"');");
                    name_label.Visible = true;
                    class_label.Visible = true;
                    vulnerability_label.Visible = true;
                    type_label.Visible = true;
                    loot_label.Visible = true;
                    bio_box.ReadOnly = true;

                    name_box.Visible = false;
                    class_box.Visible = false;
                    vulnerability_box.Visible = false;
                    type_box.Visible = false;
                    loot_box.Visible = false;
                    del_btn.Visible = true;
                    chng_btn.Text = "Изменить данные";
                    string query = "select max(id_variation) from variation;";
                    MySqlConnection conn = DBUtils.GetDBConnection();
                    MySqlCommand cmDB = new MySqlCommand(query, conn);
                    try
                    {
                        conn.Open();
                        ID_monster = Convert.ToInt32(cmDB.ExecuteScalar());
                        conn.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Ошибка2" + Environment.NewLine + ex.Message);
                    }
                    get_Info(ID_monster);
                    break;
                case "Изменить данные":
                    chng_btn.Text = "Сохранить данные";
                    name_label.Visible = false;
                    class_label.Visible = false;
                    vulnerability_label.Visible = false;
                    type_label.Visible = false;
                    loot_label.Visible = false;
                    bio_box.ReadOnly = false;
                    
                    name_box.Visible = true;
                    class_box.Visible = true;
                    vulnerability_box.Visible = true;
                    type_box.Visible = true;
                    loot_box.Visible = true;
                    del_btn.Visible = false;
                    
                    name_box.Text = name_label.Text;
                    class_box.Text = class_label.Text;
                    vulnerability_box.Text = vulnerability_label.Text;
                    type_box.Text = type_label.Text;
                    loot_box.Text = loot_label.Text;
                    break;
                case "Сохранить данные":
                    doAction("update variation set variation_name='"+name_box.Text+"',id_class="+(class_box.SelectedIndex+1).ToString()+",id_vulnerability="+(vulnerability_box.SelectedIndex+1).ToString()+",id_type="+(type_box.SelectedIndex+1).ToString()+",id_loot="+(loot_box.SelectedIndex+1).ToString()+",monster_desc='"+bio_box.Text+"'where id_variation="+ID_monster.ToString()+";");
                    name_label.Visible = true;
                    class_label.Visible = true;
                    vulnerability_label.Visible = true;
                    type_label.Visible = true;
                    loot_label.Visible = true;
                    bio_box.ReadOnly = true;

                    name_box.Visible = false;
                    class_box.Visible = false;
                    vulnerability_box.Visible = false;
                    type_box.Visible = false;
                    loot_box.Visible = false;
                    del_btn.Visible = true;
                    chng_btn.Text = "Изменить данные";
                    get_Info(ID_monster);
                    break;

            }
        }
        public void doAction(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmDB.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка3" + Environment.NewLine + ex.Message);
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что нужно вычеркнуть этого монстра?", "", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                doAction("delete from variation where id_variation =" + ID_monster + ";");
                Owner.Show();
                this.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void class_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            class_box.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void vulnerability_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            vulnerability_box.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void type_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            type_box.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void loot_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            loot_box.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    } 
}
