using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Calc
    {
        //аргумент - значение - производная
        public static Tuple<List<double>, List<double>, List<double>> Omega(double tmin, double tmax, double tinterval, double nu, double kappa, double bigOmega)
        {
            if(tmin < 0 || tmax < 0 || tmax < tmin)
            {
                throw new ArgumentException("t не может быть меньше нуля, или tmax не может быть меньше tmin");
            }

            double omegaCurr = 0;
            double omegaNext = 0;
            double domega = 0;

            List<double> args = new List<double>();
            List<double> vals = new List<double>();
            List<double> derr = new List<double>();

            for (double i = 0; i < tmin; i += tinterval)
            {
                domega = DOmega(i, omegaCurr, nu, kappa, bigOmega);
                omegaNext = omegaCurr + tinterval * domega;

                omegaCurr = omegaNext;
            }

            for (double i = tmin; i <= tmax; i += tinterval)
            {
                domega = DOmega(i, omegaCurr, nu, kappa, bigOmega);
                omegaNext = omegaCurr + tinterval * domega;

                args.Add(i);
                vals.Add(omegaCurr);
                derr.Add(domega);

                omegaCurr = omegaNext;
            }

            return new Tuple<List<double>, List<double>, List<double>>(args, vals, derr);
        }

        public static double DOmega(double t, double omega, double nu, double kappa, double bigOmega)
        {
            return - (3 * nu * kappa * Math.Pow(omega , 5) + 5 * nu * Math.Pow(omega, 3) - 30 * bigOmega) / 
                     Math.Pow(15 * (1 + kappa * Math.Pow(omega, 2)), 2);
        }

        //аргумент - значение
        public static Tuple<List<double>, List<double>> U(double tmin, double tmax, double tinterval, double z, double nu, double kappa, double bigOmega)
        {
            var omega = Omega(tmin, tmax, tinterval, nu, kappa, bigOmega);

            List<double> args = omega.Item1;
            List<double> vals = new List<double>();

            double uCurr;

            for(int i = 0; i < omega.Item1.Count; ++i)
            {
                uCurr = omega.Item3[i] / (2 * omega.Item2[i]) * (1 + kappa * Math.Pow(omega.Item2[i], 2)) * Math.Sin(omega.Item2[i] * z);
                vals.Add(uCurr);
            }

            return new Tuple<List<double>, List<double>>(args, vals);
        }

        //аргумент - значение
        public static Tuple<List<double>, List<double>> F(double tmin, double tmax, double tinterval, double z, double nu, double kappa, double bigOmega)
        {
            var omega = Omega(tmin, tmax, tinterval, nu, kappa, bigOmega);

            List<double> args = omega.Item1;
            List<double> vals = new List<double>();

            double uCurr;

            for (int i = 0; i < omega.Item1.Count; ++i)
            {
                uCurr = omega.Item3[i] / (Math.Pow(omega.Item2[i], 2)) * (1 + kappa * Math.Pow(omega.Item2[i], 2)) * (omega.Item2[i] * z - Math.Sin(omega.Item2[i] * z));
                vals.Add(uCurr);
            }

            return new Tuple<List<double>, List<double>>(args, vals);
        }
    }
}
