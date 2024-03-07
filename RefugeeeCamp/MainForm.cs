using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridViewMainF.Columns.Add("ID", "ID");
            dataGridViewMainF.Columns.Add("Name", "ФИО");
            dataGridViewMainF.Columns.Add("Age", "Возраст");
            dataGridViewMainF.Columns.Add("Country", "Страна");
            dataGridViewMainF.Columns.Add("Documents", "Документы");

            // Создание узлов для TreeView
            TreeNode rootNode = new TreeNode("Лагерь для беженцев");
            treeViewMainF.Nodes.Add(rootNode);

            TreeNode nestedNode = new TreeNode("Дополнительная информация");
            rootNode.Nodes.Add(nestedNode);

            dataGridViewMainF.Columns["ID"].DataPropertyName = "ID";

            // Обработчик события для отображения второй формы при выборе узла в TreeView
            treeViewMainF.AfterSelect += (sender, e) =>
            {
                if (e.Node.Text == "Дополнительная информация")
                {
                    SecondForm secondForm = new SecondForm();
                    secondForm.ShowDialog();
                }
            };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            labelTip.Visible = false;
            treeViewMainF.Visible = !treeViewMainF.Visible;
        }

        private void dataGridViewMainF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
