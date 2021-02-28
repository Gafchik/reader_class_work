using System.Linq;
using System.IO;
using System.Text;

namespace fuck_reader
{
    public class My_model 
    {

        public string rezult { get; set; }
        public My_model() { rezult = ""; }
        public void Read(string path) => rezult = File.ReadAllText(path, Encoding.Default);
        public void Write(string path) => File.WriteAllText(path, rezult); 

    }
}
