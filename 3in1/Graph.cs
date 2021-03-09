﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3in1
{
    public partial class Graph : Form
    {
        Color color = Color.Black; //Создаем переменную типа Color присваиваем ей черный цвет.
        bool isPressed = false; //логическая переменная понадобиться для опеределения когда можно рисовать на panel
        Point CurrentPoint; //Текущая точка ресунка.
        Point PrevPoint; //Это начальная точка рисунка.
        Graphics g; //Создаем графический элемент.
        ColorDialog colorDialog = new ColorDialog(); //диалоговое окно для выбора цвета.
        public Graph()
        {
            InitializeComponent();
            label2.BackColor = Color.Black; //По умолчанию для пера задан черный цвет, поэтому мы зададим такой же фон для label2
            g = panel1.CreateGraphics(); //Создаем область для работы с графикой на элементе panel
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK) //Если окно закрылось с OK, то меняем цвет для пера и фона label2
            {
                color = colorDialog.Color; //меняем цвет для пера
                label2.BackColor = colorDialog.Color; //меняем цвет для Фона label2
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            CurrentPoint = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                PrevPoint = CurrentPoint;
                CurrentPoint = e.Location;
                My_pen();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel1.Refresh(); //Очищает элемент Panel
        }
        private void My_pen()
        {
            Pen pen = new Pen(color, (float)numericUpDown1.Value); //Создаем перо, задаем ему цвет и толщину.
            g.DrawLine(pen, CurrentPoint, PrevPoint); //Соединияем точки линиями
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                PrevPoint = CurrentPoint;
                CurrentPoint = e.Location;
                My_pen();
            }
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            isPressed = true;
            CurrentPoint = e.Location;
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }
    }
}
