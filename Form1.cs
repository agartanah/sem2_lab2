using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace sem2_lab2 {
  public partial class Form1 : Form {
    private double a, b, e, x, y;
    private const double step = 0.01;

    private void найтиМинимумToolStripMenuItem_Click(object sender, EventArgs e) {
      
    }

    public Form1() {
      InitializeComponent();
    }

    private void построитьГрафикToolStripMenuItem_Click(object sender, EventArgs e) {
      if (!double.TryParse(textBoxA.Text, out a)) {
        labelCondition.Text = "Неправильный формат данных для значения a !!!";

        return;
      }

      if (!double.TryParse(textBoxB.Text, out b)) {
        labelCondition.Text = "Неправильный формат данных для значения b !!!";

        return;
      }

      //textBoxE.Text[textBoxE.Text.Length - 1] != '1'
      if (!double.TryParse(textBoxE.Text, out this.e) || !Regex.IsMatch(textBoxE.Text, @"0,(1|0+1)")) {
        labelCondition.Text = "Неправильный формат данных для значения e !!!";

        return;
      }

      x = a;

      try {
        Function.Dychotomy(a, b, this.e);
      } catch (Exception ex) {
        labelCondition.Text = ex.Message;

        return;
      }

      double pointX;

      try {
        pointX = Math.Round((double)Function.Dychotomy(a, b, this.e), (int)-Math.Log10(this.e));
      } catch (Exception ex) {
        labelCondition.Text = ex.Message;

        return;
      }
      

      double pointY = Math.Truncate(Function.Fun(pointX));

      labelCondition.Text = $"Решение уравнения f(x) = 0 на отрезке [{a}; {b}]:\n\tx = {pointX}\n\ty = {pointY}\n\n\t";

      double pointXMin = Math.Round(Function.LocMin(a, b, this.e), (int)-Math.Log10(this.e));

      labelCondition.Text += $"Минимум функции на отрезке [{a}; {b}]: {pointXMin}\n\n";

      double pointXMax = Math.Round(Function.LocMax(a, b, this.e), (int)-Math.Log10(this.e));

      labelCondition.Text += $"Максимум функции на отрезке [{a}; {b}]: {pointXMax}";

      PaintFun();
    }

    private void очиститьГрафикToolStripMenuItem_Click(object sender, EventArgs e) {
      chart.Series[0].Points.Clear();
    }

    private void PaintFun() {
      chart.Series[0].Points.Clear();

      chart.ChartAreas[0].AxisX.Crossing = 0;

      while (x <= b) {
        y = Function.Fun(x);

        chart.Series[0].Points.AddXY(x, y);
        x += step;
      }
    }
  }
}
