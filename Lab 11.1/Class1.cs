using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11
{
    struct Pryamaya
    {
        double k;
        double b;
        public Pryamaya(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {
            if (k == 0)
            {
                return ("Решений нет");
            }
            double r = -b / k;
            return $"Решение-{r}";

        }
    }
}
