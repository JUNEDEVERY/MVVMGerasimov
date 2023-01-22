using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;

namespace WpfApp1
{
    public class Model 
    {

        // инициаилизуем наши "типо переменные, находящиеся на main window xaml"
        public static string tbFirst;
        public static string tbSecond;

        // создаем лист, с данными, которые будут использоваться в комбобоксе в качестве выбранного элемента. такая же аналогия со знаками. взависимости от выбранного эл-та ко-кса меняется знак
        public static List<string> cmbOperation = new List<string>() { "Сложение", "Умножение", "Деление", "Вычитание" };
        public static List<string> tbSign = new List<string>() { "+", "*", "/", "-" };


        public static TextBlock tbSignText = new TextBlock();
        public static string tbResult = "";


    }
}
