
namespace Bestiary
{
    partial class MonsterProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_label = new System.Windows.Forms.Label();
            this.class_label = new System.Windows.Forms.Label();
            this.vulnerability_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.loot_label = new System.Windows.Forms.Label();
            this.del_btn = new System.Windows.Forms.Button();
            this.chng_btn = new System.Windows.Forms.Button();
            this.class_box = new System.Windows.Forms.ComboBox();
            this.vulnerability_box = new System.Windows.Forms.ComboBox();
            this.type_box = new System.Windows.Forms.ComboBox();
            this.loot_box = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.bio_box = new System.Windows.Forms.RichTextBox();
            this.name_box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(12, 20);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(33, 13);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "name";
            // 
            // class_label
            // 
            this.class_label.AutoSize = true;
            this.class_label.Location = new System.Drawing.Point(12, 46);
            this.class_label.Name = "class_label";
            this.class_label.Size = new System.Drawing.Size(31, 13);
            this.class_label.TabIndex = 1;
            this.class_label.Text = "class";
            // 
            // vulnerability_label
            // 
            this.vulnerability_label.AutoSize = true;
            this.vulnerability_label.Location = new System.Drawing.Point(12, 74);
            this.vulnerability_label.Name = "vulnerability_label";
            this.vulnerability_label.Size = new System.Drawing.Size(62, 13);
            this.vulnerability_label.TabIndex = 2;
            this.vulnerability_label.Text = "vulnerability";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Location = new System.Drawing.Point(12, 101);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(27, 13);
            this.type_label.TabIndex = 3;
            this.type_label.Text = "type";
            // 
            // loot_label
            // 
            this.loot_label.AutoSize = true;
            this.loot_label.Location = new System.Drawing.Point(12, 129);
            this.loot_label.Name = "loot_label";
            this.loot_label.Size = new System.Drawing.Size(24, 13);
            this.loot_label.TabIndex = 4;
            this.loot_label.Text = "loot";
            // 
            // del_btn
            // 
            this.del_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del_btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_btn.Location = new System.Drawing.Point(12, 190);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(133, 23);
            this.del_btn.TabIndex = 11;
            this.del_btn.Text = "Удалить монстра";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // chng_btn
            // 
            this.chng_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chng_btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chng_btn.Location = new System.Drawing.Point(12, 161);
            this.chng_btn.Name = "chng_btn";
            this.chng_btn.Size = new System.Drawing.Size(133, 23);
            this.chng_btn.TabIndex = 12;
            this.chng_btn.Text = "Изменить данные";
            this.chng_btn.UseVisualStyleBackColor = true;
            this.chng_btn.Click += new System.EventHandler(this.chng_btn_Click);
            // 
            // class_box
            // 
            this.class_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.class_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.class_box.FormattingEnabled = true;
            this.class_box.Location = new System.Drawing.Point(12, 43);
            this.class_box.Name = "class_box";
            this.class_box.Size = new System.Drawing.Size(133, 23);
            this.class_box.TabIndex = 13;
            this.class_box.SelectedIndexChanged += new System.EventHandler(this.class_box_SelectedIndexChanged);
            // 
            // vulnerability_box
            // 
            this.vulnerability_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vulnerability_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vulnerability_box.FormattingEnabled = true;
            this.vulnerability_box.Location = new System.Drawing.Point(12, 70);
            this.vulnerability_box.Name = "vulnerability_box";
            this.vulnerability_box.Size = new System.Drawing.Size(133, 23);
            this.vulnerability_box.TabIndex = 14;
            this.vulnerability_box.SelectedIndexChanged += new System.EventHandler(this.vulnerability_box_SelectedIndexChanged);
            // 
            // type_box
            // 
            this.type_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_box.FormattingEnabled = true;
            this.type_box.Location = new System.Drawing.Point(12, 97);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(133, 23);
            this.type_box.TabIndex = 16;
            this.type_box.SelectedIndexChanged += new System.EventHandler(this.type_box_SelectedIndexChanged);
            // 
            // loot_box
            // 
            this.loot_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loot_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loot_box.FormattingEnabled = true;
            this.loot_box.Location = new System.Drawing.Point(12, 124);
            this.loot_box.Name = "loot_box";
            this.loot_box.Size = new System.Drawing.Size(133, 23);
            this.loot_box.TabIndex = 17;
            this.loot_box.SelectedIndexChanged += new System.EventHandler(this.loot_box_SelectedIndexChanged);
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(12, 219);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(133, 23);
            this.back.TabIndex = 18;
            this.back.Text = "К списку монстров";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // bio_box
            // 
            this.bio_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bio_box.Location = new System.Drawing.Point(151, 16);
            this.bio_box.Name = "bio_box";
            this.bio_box.Size = new System.Drawing.Size(163, 226);
            this.bio_box.TabIndex = 19;
            this.bio_box.Text = "";
            // 
            // name_box
            // 
            this.name_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.name_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_box.FormattingEnabled = true;
            this.name_box.Location = new System.Drawing.Point(12, 16);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(133, 23);
            this.name_box.TabIndex = 15;
            // 
            // MonsterProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bestiary.Properties.Resources._57lo0xm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(326, 256);
            this.Controls.Add(this.bio_box);
            this.Controls.Add(this.back);
            this.Controls.Add(this.loot_box);
            this.Controls.Add(this.type_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.vulnerability_box);
            this.Controls.Add(this.class_box);
            this.Controls.Add(this.chng_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.loot_label);
            this.Controls.Add(this.type_label);
            this.Controls.Add(this.vulnerability_label);
            this.Controls.Add(this.class_label);
            this.Controls.Add(this.name_label);
            this.Name = "MonsterProfile";
            this.Text = "MonsterProfile";
            this.Load += new System.EventHandler(this.MonsterProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label class_label;
        private System.Windows.Forms.Label vulnerability_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label loot_label;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button chng_btn;
        private System.Windows.Forms.ComboBox class_box;
        private System.Windows.Forms.ComboBox vulnerability_box;
        private System.Windows.Forms.ComboBox type_box;
        private System.Windows.Forms.ComboBox loot_box;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.RichTextBox bio_box;
        private System.Windows.Forms.ComboBox name_box;
    }
}