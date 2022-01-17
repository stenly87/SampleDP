using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WpfApp10
{
    //класс-хранилище общих данных, доступных везде
    class Data
    {
        public static List<Special> Specials = new List<Special>();
        public static List<Student> Students = new List<Student>();
        public static List<Group> Groups = new List<Group>();
    }

    /*
     Data.Students.Add...
     * */

    public class Special
    {
    }
}
