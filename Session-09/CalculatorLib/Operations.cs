﻿namespace CalculatorLib {
    public class Addition {
        public decimal Do(decimal? x, decimal? y) {

            decimal ret = 0;

            if (x != null && y != null) {
                ret = x.Value + y.Value;
            }

            return ret;
        }
    }

    public class Substraction {
        public decimal Do(decimal? x, decimal? y) {

            decimal ret = 0;

            if (x != null && y != null) {
                ret = x.Value - y.Value;
            }

            return ret;
        }
    }

    public class Multiplication {
        public decimal Do(decimal? x, decimal? y) {

            decimal ret = 0;

            if (x != null && y != null) {
                ret = x.Value * y.Value;
            }

            return ret;
        }
    }

    public class Division {
        public decimal Do(decimal? x, decimal? y) {

            decimal ret = 0;

            if (x != null && y != null && y != 0) {
                ret = x.Value / y.Value;
            }

            return ret;
        }
    }

    public class Power {
        public decimal Do(decimal? x, decimal? y) {

            decimal ret = 0;

            if (x != null && y != null) {
                ret = (decimal) Math.Pow((double) x.Value, (double) y.Value);
            }

            return ret;
        }
    }

    public class Root {
        public decimal Do(decimal? x, decimal? y) {

            decimal ret = 0;

            if (x != null && y != null) {
                ret = (decimal)Math.Sqrt((double)x.Value);
            }

            return ret;
        }
    }
}