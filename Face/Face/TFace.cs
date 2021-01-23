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

namespace Face
{
    class TFace 
    {
        protected string Name; // поле класса
        protected Canvas g; // холст, на котором будем рисовать
        protected Brush br; // цвет рожицы

        // конструктор класса
        public TFace(string Name, Canvas g) 
        {
            this.Name = Name; // используем this для доступа

            this.g = g; // сохраняем ссылку на холст

            br = Brushes.Black; // устанавливаем цвет

            Draw(); // нарисовать себя
        }

        protected virtual void Draw()
        {
            g.Children.Clear(); // очистим холст

            Ellipse O = new Ellipse(); // создаем круг
            O.Width = g.Width;
            O.Height = g.Height;
            O.Stroke = br; // цвет рожицы
            O.StrokeThickness = 5; // толщина линии
            g.Children.Add(O); // на холст

            O = new Ellipse(); // новый круг правый глаз
            O.Width = g.Width / 5;
            O.Height = g.Height / 5;
            O.Stroke = br;
            O.StrokeThickness = 3;
            O.Margin = new Thickness(g.Width / 6.0, g.Height / 5, 0, 0);
            g.Children.Add(O);

            O = new Ellipse(); // новый круг левый глаз
            O.Width = g.Width / 5;
            O.Height = g.Height / 5;
            O.Stroke = br;
            O.StrokeThickness = 3;
            O.Margin = new Thickness(g.Width * (5.0 / 6.0) - O.Width, g.Height / 5, 0, 0);
            g.Children.Add(O);

            Rectangle R = new Rectangle(); // рот
            R.Stroke = br;
            R.StrokeThickness = 3;
            R.Width = g.Width * 0.6;
            R.Height = g.Height * 0.1;
            R.Margin = new Thickness(g.Width * 0.2, g.Height * 0.6, 0, 0);
            g.Children.Add(R);
        }

        public void SetColor(Brush br)
        {
            this.br = br;

            Draw();
        }

        public Brush Color // свойство нет скобок, но есть { }
        {
            get // вызывается при попытке прочитать свойство
            {
                MessageBox.Show(Name + " - отдал свой цвет!");
                return br; // вернуть значение
            }
            set // вызывается при попытке задать значение 
            {
                SetColor(value); // value - имеет тип свойства 
                                 // и заданное значение
            }
        }

        public void Say() // метод класса идентификатор public 
                          // позволяет вызывать метод извнеВ
        {
            MessageBox.Show(Name); // доступ к собственному полую можно без this
        }
    }


    class TFaceL : TFace // наследуем от TFace
    {
        // нужно определить новый конструктор
        public TFaceL (Canvas g) : base("Roman", g)
            // у нового конструктора параметры могут быть другими
            // но необходимо вызвать конструктор базового класса через : base() 
            // при этом при вызове базового конструктора можно параметры задать
            // константами или из числа параметров конструктора наследника
        { 
        }

        protected override void Draw()
        {
            base.Draw();
            DrawNose();
        }

        public void DrawNose()
        {
            Line L = new Line(); // создаем линию
            L.X1 = g.Width / 2.0;
            L.Y1 = g.Height / 3.0;
            L.X2 = g.Width / 2.0;
            L.Y2 = g.Height * 0.5;
            L.Stroke = br;
            L.StrokeThickness = 3;
            g.Children.Add(L);
            L = new Line(); // вторая линия
            L.X1 = g.Width / 2.0;
            L.Y1 = g.Height * 0.5;
            L.X2 = g.Width * 0.4;
            L.Y2 = g.Height * 0.5;
            L.Stroke = br;
            L.StrokeThickness = 3;
            g.Children.Add(L);
        }
    }

    class TFaceR : TFace // наследуем от TFace
    {
        public TFaceR(Canvas g) : base("Anastasia", g)
        {
        }

        protected override void Draw()
        {
            base.Draw();
            DrawNose();
        }

        public void DrawNose()
        {
            Line L = new Line(); // создаем линию
            L.X1 = g.Width / 2.0;
            L.Y1 = g.Height / 3.0;
            L.X2 = g.Width / 2.0;
            L.Y2 = g.Height * 0.5;
            L.Stroke = br;
            L.StrokeThickness = 3;
            g.Children.Add(L);
            L = new Line(); // вторая линия
            L.X1 = g.Width / 2.0;
            L.Y1 = g.Height * 0.5;
            L.X2 = g.Width * 0.6;
            L.Y2 = g.Height * 0.5;
            L.Stroke = br;
            L.StrokeThickness = 3;
            g.Children.Add(L);
        }
    }

}


