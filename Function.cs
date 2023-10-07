using System;
using System.Collections.Generic;

namespace sem2_lab2 {
  public class Function {
    public static double Dychotomy(double a, double b, double e, double x = default) {
      if (Fun(a) * Fun(b) >= 0) {
        throw new Exception($"Нет единственного решения на отрезке [{a}; {b}] !!!\n\n");
      }
      
      while ((b - a) > e) {
        x = (b - a) / 2 + a;

        if (Fun(a) * Fun(x) < 0) {
          b = x;
        } else {
          a = x;
        }
      }

      return x;
    }

    public static double LocMin(double a, double b, double e) {
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

    public static double LocMax(double a, double b, double e) {
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

    public static double FunDerivative(double x) {
      return (4 * x - 18) * Math.Exp(-(x / 3)) - ((2 * Math.Pow(x, 2) - 18 * x + 27) * Math.Exp(-(x / 3))) / 3;
    }

    public static double Fun(double x) {
      return (27 - 18 * x + 2 * Math.Pow(x, 2)) * Math.Exp( -(x / 3) );
    }
  }
}
