using System;
using System.Collections.Generic;

namespace sem2_lab2 {
  public class Function {
    public static double Dychotomic(double a, double b, double e, double x = default) {
      if (Fun(a) * Fun(b) >= 0) {
        throw new Exception($"Нет единственного решения на отрезке [{a}; {b}] !!!");
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


    public static double Fun(double x) {
      return (27 - 18 * x + 2 * Math.Pow(x, 2)) * Math.Exp( -(x / 3) );
    }
  }
}
