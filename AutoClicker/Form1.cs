using AutoClicker.Components;
using System;
using System.Threading;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        public bool enabledClicker = false;
        KeyLogger kl = new KeyLogger();
        MouseCoords mouseCoords = new MouseCoords();
        Thread clickerThread;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        void kl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad8) {
                writeCoords();
            }

            if (e.KeyCode == Keys.NumPad5) {
                startStop();
            }
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Вешаем обработчики событий на клавишу NUM8 и NUM5
            kl.HookedKeys.Add(Keys.NumPad8);
            kl.HookedKeys.Add(Keys.NumPad5);
            kl.KeyUp += new KeyEventHandler(kl_KeyUp);
        }

        private void writeCoords()
        {
            mouseCoords.writeCurrentCoords();
            MessageBox.Show("Координаты записаны!", "Инструкция", MessageBoxButtons.OK);
            coordsXtextBox.Text = mouseCoords.positionX.ToString();
            coordsYtextBox.Text = mouseCoords.positionY.ToString();
        }

        private void startStop() {

            // Если потока нет и кликер не включен
            // Создаем поток и запускаем кликер в цикле
            if (clickerThread == null && enabledClicker == false) {

                // Проверка валидности задержки между кликами
                if (!int.TryParse(delayTextBox.Text, out int n))  {
                    MessageBox.Show("Введены некорректные значения задержки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                int delay = Convert.ToInt32(delayTextBox.Text);

                if (delay < 1) {
                    MessageBox.Show("Введены некорректные значения задержки: Задержка не может быть меньше 1 миллисекунды", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                enabledClicker = true;
                clickerThread = new Thread(new ThreadStart(() => {
                    while (enabledClicker) {
                        Thread.Sleep(delay);
                        mouseCoords.clickByCoords();
                    }
                }));
                clickerThread.Start();
            } else if (enabledClicker || clickerThread != null) { // Если поток существует и кликер включен, запрещаем кликать и убиваем поток
                enabledClicker = false;
                clickerThread.Abort();
                clickerThread = null;
            }
        }

        // Обработчик ввода задержки
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(delayTextBox.Text, out int n))
            {
                labelDelayError.Visible = true;
                labelDelayError.Text = "Вводите только числа!";
                delayTextBox.Text = "";
            }
            else {
                labelDelayError.Visible = false;
                labelDelayError.Text = "";
            }
        }
    }
}
