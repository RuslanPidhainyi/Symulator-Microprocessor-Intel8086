using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Symulator_Microprocessor_Intel8086
{
    
    /// Logika interakcji dla klasy MainWindow.xaml
    
    public partial class MainWindow : Window
    {
        /*
        
         TextBox в C# (C-Sharp) - це один з контролів (або елементів керування),
        який використовується для відображення та редагування тексту на графічному інтерфейсі користувача (GUI) додатка. 
        Він часто використовується для створення текстових полів, де користувач може вводити текст. 
        TextBox дозволяє програмістам забезпечити взаємодію з користувачем, щоб вони могли вводити, редагувати та переглядати текст.

        У вас є можливість встановлювати текст в TextBox програмно (за допомогою коду) або дозволяти користувачам вводити текст вручну
        через інтерфейс. Також ви можете встановлювати різні властивості для налаштування зовнішнього вигляду і поведінки TextBox, такі як розмір,
        шрифт, колір тексту, колір фону та багато інших.

        */

        private Dictionary<string, TextBox> Registers;
        public MainWindow()
        {
            InitializeComponent();
            Registers = new Dictionary<string, TextBox>
            {
                //Registers: AL, AH, BL, BH, CL, CH, DL, DH 
                {"AL",AL},
                {"AH",AH},
                {"BL",BL},
                {"BH",BH},
                {"CL",CL},
                {"CH",CH},
                {"DL",DL},
                {"DH",DH}
                
            };
        }



        /*
         Методи WPF містять два аргументи object sender i RoutedEventArgs e: 

        Перший, object sender (відправник об’єкта), визначає, який xaml
        елемент, який називається заданим методом (наприклад, кнопка, пункт меню тощо). 
        
        Другий, RoutedEventArgs e, містить дані, пов’язані з подією. В обох випадках елемент
        яка підняла подію, відповідає за створення та заповнення цих аргументів.
         */

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tx = (TextBox)sender;
            string chars = "0123456789ABCDEF";
            

            if(tx.Text.Length > 2)
            {
                MessageBox.Show("Incorrect number entered! You need write in formulars two numbers.");

                tx.Text = "";
                return;
            }

            foreach(var item in tx.Text)
            {
                if(!chars.Contains(item))
                {

                    MessageBox.Show("Wrong data! You need write in formularS 0-9 or A-F. Example: 11, 2A, FF.");

                    tx.Text = "";
                    return;
                }
            }
        }


        private void actionMOV(object sender, RoutedEventArgs e)
        {
            string register1 = (string)r1.SelectedItem;
            string register2 = (string)r2.SelectedItem;

            if (register1 == null || register2 == null)
                MessageBox.Show("You need choose registers");
            else
                Registers[register1].Text = Registers[register2].Text;
        }

        private void actionXCHG(object sender, RoutedEventArgs e)
        {
            string register1 = (string)r1.SelectedItem;
            string register2 = (string)r2.SelectedItem;

                if (register1 == null || register2 == null)
                    MessageBox.Show("You need choose registers");
                else
                {
                    string temp;

                    temp = Registers[register1].Text;
                    Registers[register1].Text = Registers[register2].Text;
                    Registers[register2].Text = temp;
                }
        }

       

    }
}
