using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fuck_reader
{
    public class My_logic
    {

        public My_model model { get; private set; }
        public string path { get;  set; }

        public My_logic() { model = new My_model(); }
        public void Open() { model.Read(path); }
        public void Save() 
        {
            try
            {
                model.Write(path);

            }
            catch (Exception)
            {
                MessageBox.Show("Алло Выбери фаил для редактирования", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
        }
    }
}
