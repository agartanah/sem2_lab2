using System;

namespace sem2_lab2 {
  public static class Func {
    private static string textFunction;
    public static string TextFunction { 
      get {
        return textFunction;
      }
      set {
        if (FunctionParser.Expression.IsExpression(value, idsNames)) {
          textFunction = value;
        } else {
          throw new Exception("Функция написана неверно !!!");
        }
      }
    }
    public static string[] idsNames;
    public static double[] idsValues;

    public static double Dychotomy(double a, double b, double e, double x = default) {
      if (Fun(a) * Fun(b) > 0) {
        throw new Exception($"Нет единственного решения на отрезке [{a}; {b}] !!!\n\n");
      }
      
      while ((b - a) > e) {
        x = (b - a) / 2 + a;

        if (Fun(a) * Fun(x) < 0) {
          b = x;
        } else if (Fun(a) == 0) {
          return a;
        } else if (Fun(b) * Fun(x) < 0) {
          a = x;
        } else if (Fun(b) == 0) {
          return b;
        } else if (Fun(x) == 0) {
          return x;
        }
      }

      return x;
    }

    public static double Nutone(double a, double b, double e) {
      double x0;

      x0 = (a + b) / 2;

      double x1 = x0;

      do {
        x0 = x1;
        x1 = x0 - (Derivative(x0) / Derivative2(x0));
      } while (Math.Abs(x1 - x0) > e);

      if (x1 > b || x1 < a) {
        throw new Exception("На данном отрезке нет экстремума !!!");
      }

      return x1;
    }

    public static double NutoneIntersection(double a, double b, double e) {
      double x0;
      double h = 0.001;

      x0 = (a + b) / 2;

      double x1 = x0;

      do {
        x0 = x1;
        if (Derivative(x0) == 0) {
          x0 = x0 / 2 - e;
        }

        x1 = x0 - (Fun(x0) / Derivative(x0));
      } while (Math.Abs(Fun(x0) / Derivative(x0)) > h);

      if (x1 > b || x1 < a) {
        throw new Exception("На данном отрезке нет точек пересечения !!!");
      }

      return x1;
    }

    public static double DychotomyLocMin(double a, double b, double e) {
      double delta = e / 10;

      while (b - a >= e) {
        double middle = (a + b) / 2;
        double lambda = a + delta, mu = b - delta; ;
        if (Fun(lambda) < Fun(mu))
          b = mu;
        else
          a = lambda;
      }

      return (a + b) / 2;
    }

    public static double DychotomyLocMax(double a, double b, double e) {
      double delta = e / 10;

      while (b - a >= e) {
        double middle = (a + b) / 2;
        double lambda = a + delta, mu = b - delta;
        if (-Fun(lambda) < -Fun(mu))
          b = mu;
        else
          a = lambda;
      }

      return (a + b) / 2;
    }

    public static double Derivative(double x) {
      idsValues[0] = x;

      double e = 0.01;
      
      double result1 = Fun(idsValues[0] + e);
      idsValues[0] -= e;

      double result2 = Fun(idsValues[0] - e);
      idsValues[0] += e;

      return (result1 - result2) / (2 * e);
    }

    public static double Derivative2(double x) {
      idsValues[0] = x;

      double e = 0.01;

      double result1 = Fun(idsValues[0] + e);
      idsValues[0] -= e;

      double result2 = Fun(idsValues[0] - e);
      idsValues[0] += e;

      double result3 = Fun(idsValues[0]);

      return (result1 - 2 * result3 + result2) / (e * e);
    }

    public static double Fun(double x) {
      if (FunctionParser.Expression.IsExpression(TextFunction, idsNames)) {
        FunctionParser.Expression expression = new FunctionParser.Expression(TextFunction, idsNames, null);

        idsValues[0] = x;

        double res = expression.CalculateValue(idsValues);

        return res;
      } else {
        throw new Exception("Функция написана неверно !!!");
      }
    }
  }
}
