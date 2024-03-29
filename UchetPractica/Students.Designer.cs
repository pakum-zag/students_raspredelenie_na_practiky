﻿namespace UchetPractica
{
    partial class Students
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
            this.components = new System.ComponentModel.Container();
            this.pStud = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cbStatusStud = new System.Windows.Forms.ComboBox();
            this.tbGrNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bEnterShow = new System.Windows.Forms.Button();
            this.bCancelShow = new System.Windows.Forms.Button();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbPatr = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bCancel = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.bEditShow = new System.Windows.Forms.Button();
            this.bAddShow = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ShowAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentsShow = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupShow = new System.Windows.Forms.ToolStripMenuItem();
            this.OldGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExelExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShablonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smiStudNewGr = new System.Windows.Forms.ToolStripMenuItem();
            this.pGroup = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbStatusGroup = new System.Windows.Forms.ComboBox();
            this.bShowGroupEnter = new System.Windows.Forms.Button();
            this.bShowGroupCancel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGroupNum = new System.Windows.Forms.TextBox();
            this.tbSpecialty = new System.Windows.Forms.TextBox();
            this.tbGroupCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lGroupNum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.pStud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pStud
            // 
            this.pStud.Controls.Add(this.label10);
            this.pStud.Controls.Add(this.cbStatusStud);
            this.pStud.Controls.Add(this.tbGrNum);
            this.pStud.Controls.Add(this.label4);
            this.pStud.Controls.Add(this.label3);
            this.pStud.Controls.Add(this.label2);
            this.pStud.Controls.Add(this.label1);
            this.pStud.Controls.Add(this.bEnterShow);
            this.pStud.Controls.Add(this.bCancelShow);
            this.pStud.Controls.Add(this.tbSurname);
            this.pStud.Controls.Add(this.tbPatr);
            this.pStud.Controls.Add(this.tbName);
            this.pStud.Controls.Add(this.label5);
            this.pStud.Location = new System.Drawing.Point(915, 95);
            this.pStud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pStud.Name = "pStud";
            this.pStud.Size = new System.Drawing.Size(461, 356);
            this.pStud.TabIndex = 0;
            this.pStud.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(19, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 24);
            this.label10.TabIndex = 56;
            this.label10.Text = "Статус";
            // 
            // cbStatusStud
            // 
            this.cbStatusStud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbStatusStud.FormattingEnabled = true;
            this.cbStatusStud.Items.AddRange(new object[] {
            "Обучается",
            "Отчислен",
            "Ак. отпуск"});
            this.cbStatusStud.Location = new System.Drawing.Point(232, 210);
            this.cbStatusStud.Name = "cbStatusStud";
            this.cbStatusStud.Size = new System.Drawing.Size(208, 30);
            this.cbStatusStud.TabIndex = 55;
            // 
            // tbGrNum
            // 
            this.tbGrNum.Enabled = false;
            this.tbGrNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGrNum.Location = new System.Drawing.Point(232, 77);
            this.tbGrNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGrNum.Name = "tbGrNum";
            this.tbGrNum.Size = new System.Drawing.Size(208, 28);
            this.tbGrNum.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(69, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Настройки студента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Имя";
            // 
            // bEnterShow
            // 
            this.bEnterShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEnterShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEnterShow.Location = new System.Drawing.Point(293, 299);
            this.bEnterShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEnterShow.Name = "bEnterShow";
            this.bEnterShow.Size = new System.Drawing.Size(147, 55);
            this.bEnterShow.TabIndex = 31;
            this.bEnterShow.Text = "Подтвердить";
            this.bEnterShow.UseVisualStyleBackColor = true;
            this.bEnterShow.Click += new System.EventHandler(this.bEnterShow_Click);
            // 
            // bCancelShow
            // 
            this.bCancelShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancelShow.Location = new System.Drawing.Point(3, 299);
            this.bCancelShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCancelShow.Name = "bCancelShow";
            this.bCancelShow.Size = new System.Drawing.Size(137, 55);
            this.bCancelShow.TabIndex = 30;
            this.bCancelShow.Text = "Отмена";
            this.bCancelShow.UseVisualStyleBackColor = true;
            this.bCancelShow.Click += new System.EventHandler(this.bCancelShow_Click);
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.Location = new System.Drawing.Point(232, 144);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(208, 28);
            this.tbSurname.TabIndex = 27;
            // 
            // tbPatr
            // 
            this.tbPatr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPatr.Location = new System.Drawing.Point(232, 177);
            this.tbPatr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPatr.Name = "tbPatr";
            this.tbPatr.Size = new System.Drawing.Size(208, 28);
            this.tbPatr.TabIndex = 28;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(232, 109);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(208, 28);
            this.tbName.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(19, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Номер группы";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(897, 356);
            this.dataGridView1.TabIndex = 1;
            // 
            // bCancel
            // 
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.Location = new System.Drawing.Point(134, 455);
            this.bCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(116, 55);
            this.bCancel.TabIndex = 11;
            this.bCancel.Text = "Назад";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bDel
            // 
            this.bDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDel.Location = new System.Drawing.Point(495, 30);
            this.bDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(116, 55);
            this.bDel.TabIndex = 14;
            this.bDel.Text = "Удалить";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Visible = false;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bEditShow
            // 
            this.bEditShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEditShow.Location = new System.Drawing.Point(792, 454);
            this.bEditShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEditShow.Name = "bEditShow";
            this.bEditShow.Size = new System.Drawing.Size(116, 55);
            this.bEditShow.TabIndex = 15;
            this.bEditShow.Text = "Изменить";
            this.bEditShow.UseVisualStyleBackColor = true;
            this.bEditShow.Click += new System.EventHandler(this.bEditShow_Click);
            // 
            // bAddShow
            // 
            this.bAddShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddShow.Location = new System.Drawing.Point(670, 454);
            this.bAddShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAddShow.Name = "bAddShow";
            this.bAddShow.Size = new System.Drawing.Size(116, 55);
            this.bAddShow.TabIndex = 16;
            this.bAddShow.Text = "Добавить";
            this.bAddShow.UseVisualStyleBackColor = true;
            this.bAddShow.Click += new System.EventHandler(this.bAddShow_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowAboutToolStripMenuItem,
            this.ExportДанныхToolStripMenuItem,
            this.smiStudNewGr});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1387, 30);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ShowAboutToolStripMenuItem
            // 
            this.ShowAboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StudentsShow,
            this.GroupShow,
            this.OldGroupsToolStripMenuItem});
            this.ShowAboutToolStripMenuItem.Name = "ShowAboutToolStripMenuItem";
            this.ShowAboutToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.ShowAboutToolStripMenuItem.Text = "Отображение данных о";
            // 
            // StudentsShow
            // 
            this.StudentsShow.Name = "StudentsShow";
            this.StudentsShow.Size = new System.Drawing.Size(224, 26);
            this.StudentsShow.Text = "Студентах";
            this.StudentsShow.Click += new System.EventHandler(this.StudentsShow_Click);
            // 
            // GroupShow
            // 
            this.GroupShow.Name = "GroupShow";
            this.GroupShow.Size = new System.Drawing.Size(224, 26);
            this.GroupShow.Text = "Группах";
            this.GroupShow.Click += new System.EventHandler(this.GroupShow_Click);
            // 
            // OldGroupsToolStripMenuItem
            // 
            this.OldGroupsToolStripMenuItem.Name = "OldGroupsToolStripMenuItem";
            this.OldGroupsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.OldGroupsToolStripMenuItem.Text = "Другие группы";
            this.OldGroupsToolStripMenuItem.Click += new System.EventHandler(this.OldGroupsToolStripMenuItem_Click);
            // 
            // ExportДанныхToolStripMenuItem
            // 
            this.ExportДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExelExportToolStripMenuItem,
            this.ShablonToolStripMenuItem});
            this.ExportДанныхToolStripMenuItem.Name = "ExportДанныхToolStripMenuItem";
            this.ExportДанныхToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.ExportДанныхToolStripMenuItem.Text = "Импорт данных";
            // 
            // ExelExportToolStripMenuItem
            // 
            this.ExelExportToolStripMenuItem.Name = "ExelExportToolStripMenuItem";
            this.ExelExportToolStripMenuItem.Size = new System.Drawing.Size(329, 26);
            this.ExelExportToolStripMenuItem.Text = "Импорт из Exel";
            this.ExelExportToolStripMenuItem.Click += new System.EventHandler(this.ExelExportToolStripMenuItem_Click);
            // 
            // ShablonToolStripMenuItem
            // 
            this.ShablonToolStripMenuItem.Name = "ShablonToolStripMenuItem";
            this.ShablonToolStripMenuItem.Size = new System.Drawing.Size(329, 26);
            this.ShablonToolStripMenuItem.Text = "Скачать шаблон Exel для импорта";
            this.ShablonToolStripMenuItem.Click += new System.EventHandler(this.ShablonToolStripMenuItem_Click);
            // 
            // smiStudNewGr
            // 
            this.smiStudNewGr.Name = "smiStudNewGr";
            this.smiStudNewGr.Size = new System.Drawing.Size(263, 24);
            this.smiStudNewGr.Text = "Перевод студента в другую группу";
            this.smiStudNewGr.Visible = false;
            this.smiStudNewGr.Click += new System.EventHandler(this.smiStudNewGr_Click);
            // 
            // pGroup
            // 
            this.pGroup.Controls.Add(this.label9);
            this.pGroup.Controls.Add(this.cbStatusGroup);
            this.pGroup.Controls.Add(this.bShowGroupEnter);
            this.pGroup.Controls.Add(this.bShowGroupCancel);
            this.pGroup.Controls.Add(this.label11);
            this.pGroup.Controls.Add(this.label8);
            this.pGroup.Controls.Add(this.label7);
            this.pGroup.Controls.Add(this.tbGroupNum);
            this.pGroup.Controls.Add(this.tbSpecialty);
            this.pGroup.Controls.Add(this.tbGroupCode);
            this.pGroup.Controls.Add(this.label6);
            this.pGroup.Location = new System.Drawing.Point(915, 96);
            this.pGroup.Name = "pGroup";
            this.pGroup.Size = new System.Drawing.Size(461, 354);
            this.pGroup.TabIndex = 25;
            this.pGroup.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(19, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 24);
            this.label9.TabIndex = 54;
            this.label9.Text = "Статус";
            // 
            // cbStatusGroup
            // 
            this.cbStatusGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbStatusGroup.FormattingEnabled = true;
            this.cbStatusGroup.Items.AddRange(new object[] {
            "Обучается",
            "Обучение окончено"});
            this.cbStatusGroup.Location = new System.Drawing.Point(234, 175);
            this.cbStatusGroup.Name = "cbStatusGroup";
            this.cbStatusGroup.Size = new System.Drawing.Size(208, 30);
            this.cbStatusGroup.TabIndex = 53;
            // 
            // bShowGroupEnter
            // 
            this.bShowGroupEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bShowGroupEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bShowGroupEnter.Location = new System.Drawing.Point(311, 297);
            this.bShowGroupEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bShowGroupEnter.Name = "bShowGroupEnter";
            this.bShowGroupEnter.Size = new System.Drawing.Size(147, 55);
            this.bShowGroupEnter.TabIndex = 52;
            this.bShowGroupEnter.Text = "Подтвердить";
            this.bShowGroupEnter.UseVisualStyleBackColor = true;
            this.bShowGroupEnter.Click += new System.EventHandler(this.bShowGroupEnter_Click);
            // 
            // bShowGroupCancel
            // 
            this.bShowGroupCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bShowGroupCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bShowGroupCancel.Location = new System.Drawing.Point(3, 297);
            this.bShowGroupCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bShowGroupCancel.Name = "bShowGroupCancel";
            this.bShowGroupCancel.Size = new System.Drawing.Size(137, 55);
            this.bShowGroupCancel.TabIndex = 51;
            this.bShowGroupCancel.Text = "Отмена";
            this.bShowGroupCancel.UseVisualStyleBackColor = true;
            this.bShowGroupCancel.Click += new System.EventHandler(this.bShowGroupCancel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(21, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 24);
            this.label11.TabIndex = 50;
            this.label11.Text = "Код группы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(21, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "Специальность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(21, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "Номер группы";
            // 
            // tbGroupNum
            // 
            this.tbGroupNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGroupNum.Location = new System.Drawing.Point(234, 78);
            this.tbGroupNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGroupNum.MaxLength = 15;
            this.tbGroupNum.Name = "tbGroupNum";
            this.tbGroupNum.Size = new System.Drawing.Size(208, 28);
            this.tbGroupNum.TabIndex = 45;
            // 
            // tbSpecialty
            // 
            this.tbSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSpecialty.Location = new System.Drawing.Point(234, 110);
            this.tbSpecialty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSpecialty.Name = "tbSpecialty";
            this.tbSpecialty.Size = new System.Drawing.Size(208, 28);
            this.tbSpecialty.TabIndex = 46;
            // 
            // tbGroupCode
            // 
            this.tbGroupCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGroupCode.Location = new System.Drawing.Point(234, 142);
            this.tbGroupCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGroupCode.MaxLength = 20;
            this.tbGroupCode.Name = "tbGroupCode";
            this.tbGroupCode.Size = new System.Drawing.Size(208, 28);
            this.tbGroupCode.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(33, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "Настройки группы";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(526, 46);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(75, 23);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.Visible = false;
            // 
            // lGroupNum
            // 
            this.lGroupNum.AutoSize = true;
            this.lGroupNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lGroupNum.Location = new System.Drawing.Point(46, 51);
            this.lGroupNum.Name = "lGroupNum";
            this.lGroupNum.Size = new System.Drawing.Size(331, 24);
            this.lGroupNum.TabIndex = 38;
            this.lGroupNum.Text = "Отображаются студенты группы №";
            this.lGroupNum.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 54);
            this.button1.TabIndex = 39;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(46, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(266, 24);
            this.label12.TabIndex = 40;
            this.label12.Text = "Отображается список групп";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(413, 469);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(251, 28);
            this.tbSearch.TabIndex = 41;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseMove);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(343, 472);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 24);
            this.label13.TabIndex = 44;
            this.label13.Text = "Поиск";
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 522);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lGroupNum);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bAddShow);
            this.Controls.Add(this.bEditShow);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pStud);
            this.Controls.Add(this.pGroup);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Группы и студенты";
            this.Load += new System.EventHandler(this.Students_Load);
            this.pStud.ResumeLayout(false);
            this.pStud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pGroup.ResumeLayout(false);
            this.pGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pStud;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bEditShow;
        private System.Windows.Forms.Button bAddShow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button bEnterShow;
        private System.Windows.Forms.Button bCancelShow;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbPatr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowAboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StudentsShow;
        private System.Windows.Forms.ToolStripMenuItem GroupShow;
        private System.Windows.Forms.ToolStripMenuItem ExportДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExelExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShablonToolStripMenuItem;
        private System.Windows.Forms.Panel pGroup;
        private System.Windows.Forms.TextBox tbGroupNum;
        private System.Windows.Forms.TextBox tbSpecialty;
        private System.Windows.Forms.TextBox tbGroupCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bShowGroupEnter;
        private System.Windows.Forms.Button bShowGroupCancel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lGroupNum;
        private System.Windows.Forms.ToolStripMenuItem OldGroupsToolStripMenuItem;
        private System.Windows.Forms.TextBox tbGrNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbStatusGroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbStatusStud;
        private System.Windows.Forms.ToolStripMenuItem smiStudNewGr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label13;
    }
}