using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace sem2_lab2 {
  public partial class Form1 : Form {
    private double a, b, e, x, y;
    private const double step = 0.01;

    private void найтиМинимумToolStripMenuItem_Click(object sender, EventArgs e) {
      if (!double.TryParse(textBoxA.Text, out a)) {
        labelCondition.Text = "Неправильный формат данных для значения a !!!\n\n";

        return;
      }

      if (!double.TryParse(textBoxB.Text, out b)) {
        labelCondition.Text = "Неправильный формат данных для значения b !!!\n\n";

        return;
      }

      if (a > b) {
        labelCondition.Text = "a и b должны быть такие, что: \n a <= b\n\n";

        return;
      }

      //textBoxE.Text[textBoxE.Text.Length - 1] != '1'
      if (!double.TryParse(textBoxE.Text, out this.e) || !Regex.IsMatch(textBoxE.Text, @"(1|10+)|(0,(1|0+1))")
        || textBoxE.Text[0] == '-') {
        labelCondition.Text = "Неправильный формат данных для значения e !!!\n\n";

        return;
      }

      try {
        Func.TextFunction = functionTextBox.Text;
      } catch (Exception ex) {
        labelCondition.Text = ex.Message;

        return;
      }

      x = a;

      double pointXMin = Math.Round(Func.DychotomyLocMin(a, b, this.e), Math.Abs((int)Math.Log10(this.e)));
      double pointYMin = Func.Fun(pointXMin);

      labelCondition.Text += $"Минимум функции на отрезке [{a}; {b}]:\n\tx = {pointXMin}\n\ty = " +
        $"{pointYMin}\n\n";

      PaintFun();
    }

    private void найтиМаксимумToolStripMenuItem_Click(object sender, EventArgs e) {
      if (!double.TryParse(textBoxA.Text, out a)) {
        labelCondition.Text = "Неправильный формат данных для значения a !!!\n\n";

        return;
      }

      if (!double.TryParse(textBoxB.Text, out b)) {
        labelCondition.Text = "Неправильный формат данных для значения b !!!\n\n";

        return;
      }

      if (a > b) {
        labelCondition.Text = "a и b должны быть такие, что: \n a <= b\n\n";

        return;
      }

      //textBoxE.Text[textBoxE.Text.Length - 1] != '1'
      if (!double.TryParse(textBoxE.Text, out this.e) || !Regex.IsMatch(textBoxE.Text, @"(1|10+)|(0,(1|0+1))")
        || textBoxE.Text[0] == '-') {
        labelCondition.Text = "Неправильный формат данных для значения e !!!\n\n";

        return;
      }

      try {
        Func.TextFunction = functionTextBox.Text;
      } catch (Exception ex) {
        labelCondition.Text = ex.Message;

        return;
      }

      x = a;

      double pointXMax = Math.Round(Func.DychotomyLocMax(a, b, this.e), Math.Abs((int)Math.Log10(this.e)));
      double pointYMax = Func.Fun(pointXMax);

      labelCondition.Text += $"Максимум функции на отрезке [{a}; {b}]:\n\tx = {pointXMax}\n\ty = " +
        $"{pointYMax}\n\n";

      PaintFun();
    }

    private void найтиМинимумToolStripMenuItem1_Click(object sender, EventArgs e) {
      if (!double.TryParse(textBoxA.Text, out a)) {
        labelCondition.Text = "Неправильный формат данных для значения a !!!\n\n";

        return;
      }

      if (!double.TryParse(textBoxB.Text, out b)) {
        labelCondition.Text = "Неправильный формат данных для значения b !!!\n\n";

        return;
      }

      if (a > b) {
        labelCondition.Text = "a и b должны быть такие, что: \n a <= b\n\n";

        return;
      }

      //textBoxE.Text[textBoxE.Text.Length - 1] != '1'
      if (!double.TryParse(textBoxE.Text, out this.e) || !Regex.IsMatch(textBoxE.Text, @"(1|10+)|(0,(1|0+1))")
        || textBoxE.Text[0] == '-') {
        labelCondition.Text = "Неправильный формат данных для значения e !!!\n\n";

        return;
      }

      try {
        Func.TextFunction = functionTextBox.Text;
      } catch (Exception ex) {
        labelCondition.Text = ex.Message;

        return;
      }

      x = a;

      double pointXMin = default;
      try {
        pointXMin = Math.Round(Func.Nutone(a, b, this.e), Math.Abs((int)Math.Log10(this.e)));
      } catch (Exception ex) {
        labelCondition.Text += ex.Message;

        return;
      }

      if (double.IsNaN(pointXMin)) {
        labelCondition.Text = "Функция не подходит под метод ньютона !!!\n\n";

        return;
      }

      double pointYMin = Func.Fun(pointXMin);

      labelCondition.Text = $"Экстремум функции на отрезке [{a}; {b}]:\n\tx = {pointXMin}\n\ty = " +
        $"{pointYMin}\n\n";

      if (Func.Derivative2(pointXMin) > 0) {
        labelCondition.Text += $"Этот экстремум: точка минимума !!!\n\n";
      } else if (Func.Derivative2(pointXMin) < 0) {
        labelCondition.Text += $"Этот экстремум: точка максимума !!!\n\n";
      }

      PaintFun();
    }

    private void textBox1_TextChanged(object sender, EventArgs e) {

    }

    private void начертитьToolStripMenuItem_Click(object sender, EventArgs e) {
      try {
        Func.TextFunction = functionTextBox.Text;
      } catch (Exception ex) {
        labelCondition.Text = ex.Message;

        return;
      }

      PaintFun();
    }

    private void решениеFx0ToolStripMenuItem_Click(object sender, EventArgs e) {
      if (!double.TryParse(textBoxA.Text, out a)) {
        labelCondition.Text = "Неправильный формат данных для значения a !!!\n\n";

        return;
      }

      if (!double.TryParse(textBoxB.Text, out b)) {
        labelCondition.Text = "Неправильный формат данных для значения b !!!\n\n";

        return;
      }

      if (a > b) {
        labelCondition.Text = "a и b должны быть такие, что: \n a <= b\n\n";

        return;
      }

      //textBoxE.Text[textBoxE.Text.Length - 1] != '1'
      if (!double.TryParse(textBoxE.Text, out this.e) || !Regex.IsMatch(textBoxE.Text, @"(1|10+)|(0,(1|0+1))")
        || textBoxE.Text[0] == '-') {
        labelCondition.Text = "Неправильный формат данных для значения e !!!\n\n";

        return;
      }

      x = a;

      try {
        Func.TextFunction = functionTextBox.Text;
      } catch (Exception ex) {
        labelCondition.Text = ex.Message;

        return;
      }

      double pointX;

      try {
        pointX = Math.Round((double)Func.NutoneIntersection(a, b, this.e), Math.Abs((int)Math.Log10(this.e)));
      } catch (Exception ex) {
        labelCondition.Text = ex.Message;

        return;
      }


      double pointY = Math.Truncate(Func.Fun(pointX));

      labelCondition.Text = $"Решение уравнения f(x) = 0 на отрезке [{a}; {b}]:\n\tx = {pointX}\n\ty = {pointY}\n\n\t";

      PaintFun();
    }

    public Form1() {
      InitializeComponent();
      Func.idsNames = new string[] { "x", "e" };
      Func.idsValues = new double[] { default, Math.E };
    }

    private void построитьГрафикToolStripMenuItem_Click(object sender, EventArgs e) {
      if (!double.TryParse(textBoxA.Text, out a)) {
        labelCondition.Text = "Неправильный формат данных для значения a !!!\n\n";

        return;
      }

      if (!double.TryParse(textBoxB.Text, out b)) {
        labelCondition.Text = "Неправильный формат данных для значения b !!!\n\n";

        return;
      }

      if (a > b) {
        labelCondition.Text = "a и b должны быть такие, что: \n a <= b\n\n";

        return;
      }

      //textBoxE.Text[textBoxE.Text.Length - 1] != '1'
      if (!double.TryParse(textBoxE.Text, out this.e) || !Regex.IsMatch(textBoxE.Text, @"(1|10+)|(0,(1|0+1))")
        || textBoxE.Text[0] == '-') {
        labelCondition.Text = "Неправильный формат данных для значения e !!!\n\n";

        return;
      }

      x = a;

      try {
        Func.TextFunction = functionTextBox.Text;
      } catch (Exception ex) {
        labelCondition.Text = ex.Message;

        return;
      }

      try {
        Func.Dychotomy(a, b, this.e);
      } catch (Exception ex) {
        labelCondition.Text = ex.Message;

        return;
      }

      double pointX;

      try {
        pointX = Math.Round((double)Func.Dychotomy(a, b, this.e), Math.Abs((int)Math.Log10(this.e)));
      } catch (Exception ex) {
        labelCondition.Text = ex.Message;

        return;
      }
      

      double pointY = Math.Truncate(Func.Fun(pointX));

      labelCondition.Text = $"Решение уравнения f(x) = 0 на отрезке [{a}; {b}]:\n\tx = {pointX}\n\ty = {pointY}\n\n\t";

      double pointXMin = Math.Round(Func.DychotomyLocMin(a, b, this.e), Math.Abs((int)Math.Log10(this.e)));

      labelCondition.Text += $"Минимум функции на отрезке [{a}; {b}]: {pointXMin}\n\n";

      double pointXMax = Math.Round(Func.DychotomyLocMax(a, b, this.e), Math.Abs((int)Math.Log10(this.e)));

      labelCondition.Text += $"Максимум функции на отрезке [{a}; {b}]: {pointXMax}";

      PaintFun();
    }

    private void очиститьГрафикToolStripMenuItem_Click(object sender, EventArgs e) {
      chart.Series[0].Points.Clear();
      labelCondition.Text = string.Empty;
    }

    private void PaintFun() {
      chart.Series[0].Points.Clear();

      chart.ChartAreas[0].AxisX.Crossing = 0;

      if (a - b == 0) {
        a = -10;
        b = 10;
      }

      x = a;

      while (x <= b) {
        y = Func.Fun(x);

        chart.Series[0].Points.AddXY(x, y);
        x += step;
      }
    }
  }
}
