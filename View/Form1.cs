using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fuck_reader
{
    public partial class Form1 : Form
    {
        public OpenFileDialog o_dialog { get; private set; }
        public SaveFileDialog s_dialog { get; private set; }
        public ColorDialog c_dialog { get; private set; }
        public My_logic logic { get; set; }
        public Form1()
        {
           


            logic = new My_logic();
            InitializeComponent();
            btn_open.Click += Btn_open_Click;
            btn_save.Click += Btn_save_Click;
            btn_color.Click += Btn_color_Click;
            text_rezult.TextChanged += Text_rezult_TextChanged;
        }

        private void Text_rezult_TextChanged(object sender, EventArgs e) { logic.model.rezult = text_rezult.Text; }
       

        private void Btn_color_Click(object sender, EventArgs e)
        {
            c_dialog = new ColorDialog();
            if (c_dialog.ShowDialog() == DialogResult.OK)
                this.BackColor = c_dialog.Color;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            s_dialog = new SaveFileDialog();
            s_dialog.Filter = "TXT|*.txt";
            if (s_dialog.ShowDialog() == DialogResult.OK)
                logic.path = s_dialog.FileName;
            logic.Save();
        }

        private void Btn_open_Click(object sender, EventArgs e)
        {
            o_dialog = new OpenFileDialog();
            o_dialog.Filter = "TXT|*.txt";
            if (o_dialog.ShowDialog() == DialogResult.OK)
                logic.path = o_dialog.FileName;
            logic.Open();
            text_rezult.Text = logic.model.rezult;
        }
    }
}
