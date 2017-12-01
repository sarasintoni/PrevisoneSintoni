using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Previsione
{
    class Sarima 
    {
        private List<int> values;
        public Sarima(List<int> val)
        {
            this.values = val;
        }

        public double predict()
        {
            var ma = new Dictionary<int, double>();
            var cma = new Dictionary<int, double>();
            var sr = new Dictionary<int, double>();
            var dest = new List<double>();
            var avgVal = new Dictionary<int, double>();
            var window = new List<double>();

            for (int i  = 0; i < values.Count; i++)
            {
                window.Add(values[i]);
                if (window.Count == 6)
                {
                    double sum = 0;
                    foreach (double v in window)
                    {
                        sum += v;
                    }
                    var avg = sum / 6;
                    ma.Add((i - 2), avg);
                    //Console.WriteLine(i-2);
                    //Console.WriteLine(avg);
                    window.Remove(window[0]);
                }
            }

            window = new List<double>();
            for (int i = 0; i < ma.Count - 1; i++)
            {
                window.Add(ma.ElementAt(i).Value);
                var avg = (ma.ElementAt(i).Value + ma.ElementAt(i+1).Value) / 2;

                //Console.WriteLine(ma.ElementAt(i).Key);
                cma.Add(ma.ElementAt(i).Key, avg);
                
                //Console.WriteLine(avg);
            }

            for (int i = 0; i < cma.Count; i++)
            {
                var v = values[cma.ElementAt(i).Key] / cma.ElementAt(i).Value;
                sr.Add(cma.ElementAt(i).Key, v);
                //Console.WriteLine(v);
            }

            /*for (int i = 0; i < sr.Count - 6; i++)
            {
                var sum = sr.ElementAt(i).Value 
            }*/

            List<Double> avgs = new List<double>();
            var start = 3;
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine("Media " + i);
                int count = 0;
                double app = 0;
                for(int v = start; v < sr.Count; v+=6) {
                    Console.WriteLine("Aggiunto il valore " + v);
                    app += sr.ElementAt(v).Value;
                    count++;
                }
                avgs.Add(app / count);
                start++;
                var news = start % 6;
                start = news;
                Console.WriteLine("Nuovo start = " + start);
            }

            Console.WriteLine(avgs[0]);
            Console.WriteLine(avgs[1]);
            Console.WriteLine(avgs[2]);
            Console.WriteLine(avgs[3]);
            Console.WriteLine(avgs[4]);
            Console.WriteLine(avgs[5]);


            for(int i = 0; i < values.Count; i++)
            {
                int idx = i % 6;
                dest.Add(values[i] / avgs[idx]);
                //Console.WriteLine(dest[i]);
            }

            var yMedia = dest.Average();
            Console.WriteLine("Y media = " + yMedia);

            var xMedia = (dest.Count+1) / 2;
            Console.WriteLine("X media = " + xMedia);

            var sumCodev = 0.0;
            var sumDev = 0.0;
            for(int i = 0; i < dest.Count; i++)
            {
                sumCodev += (((i + 1) - xMedia) * (dest[i] - yMedia));
                sumDev += Math.Pow(((i + 1) - xMedia), 2);
            }

            //Console.WriteLine("Sum codev = " + sumCodev);
            //Console.WriteLine("Sum dev = " + sumDev);
            var coeReg = sumCodev / sumDev;
            Console.WriteLine("Coe reg = " + coeReg);

            var intercetta = yMedia - (coeReg * xMedia);
            Console.WriteLine("Intercetta = " + intercetta);

            var newIndex = dest.Count + 1;
            var trendNew = intercetta + (coeReg * newIndex);
            Console.WriteLine("Trend " + newIndex + " = " + trendNew);

            //Console.WriteLine("quello che prediamo + " + (newIndex % 6) + " cioè " + avgs[newIndex % 6]);
            var prev = trendNew * avgs[(newIndex-1) % 6];
            Console.WriteLine("PREVISIONE = " + prev);

            return prev;
        }
    }
}
