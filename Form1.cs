using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CodyHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            Hide();

            Form2 form2 = new Form2();

            form2.Show();
        }

        private void button_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа предназначенна для неопытных пользователей. " + "\n"+ "\n"+
                "Обновления: " + 
                "\n" +
                "- Разработанна функция голосового управления Cody Voice(чтобы запустить определенное приложение, необходимо сказать 'запустить' и указать команду, указзаную ниже)" + "\n" +
                "\n" + "- Команды: "
                + "\n" + "1) Калькулятор" + 
                "\n" + "2) Visual Studio" + 
                "\n" + "3) Google" + "\n"
                +"4) Telegram" + 
                "\n" + 
                "5) Командная строка" + "\n" +
                "6) Редактор реестра" + 
                "\n" + 
                "7) Android Studio" +
                "\n"
                + "8) Qt" + "\n" +
                "9) Диспетчер задач" + "\n" +"\n"+ "ПРИМЕЧАНИЕ!!!" + "\n" + "Если программа не запускается, необходимо чётче сказать предложение");
        }

        private void button_Book_Click(object sender, EventArgs e)
        {
            Process.Start("https://elims.org.ua/blog/windows-zapusk-osnastok-i-elementov-upravleniya-iz-komandnoj-stroki/");
        }
    }
}
