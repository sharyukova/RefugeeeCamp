﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefugeeeCamp
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
            // Создание столбцов для DataGridView
            dataGridViewSecF.Columns.Add("ID", "ID");
            dataGridViewSecF.Columns.Add("Relatives", "Родственники (ФИО)");
            dataGridViewSecF.Columns.Add("Profession", "Род деятельности");
            dataGridViewSecF.Columns.Add("Financial situation", "Материальное положение");

            // Добавление данных в DataGridView
            // Здесь можно добавить данные с клавиатуры
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
