using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTesting {
    public static class SimilarityMeasure
    {
        static public double GetEuclideanDistance(double[] qTS, double[] cTS)
        {
            double distance = -1;

            if(qTS.Length == cTS.Length)
            {
                double sumOfSquare = 0;
                for(int i=0; i<qTS.Length; i++)
                {
                    sumOfSquare += Math.Pow(qTS[i] - cTS[i], 2);
                }

                distance = Math.Sqrt(sumOfSquare);
            }

            return distance;
        }

        static public double GetDynamicTimeWarpDistance(double[] qTs, double[] cTS)
        {          
            double[,] dtwTable = new double[qTs.Length + 1, cTS.Length+1];

            //테이블 초기화
            dtwTable[0, 0] = 0;
            for(int i=1; i<dtwTable.GetLength(0); i++)
                dtwTable[i, 0] = double.MaxValue;
            for (int i = 1; i < dtwTable.GetLength(1); i++)
                dtwTable[0, i] = double.MaxValue;

            for(int i=1; i<dtwTable.GetLength(0); i++)
            {
                for(int j=1; j<dtwTable.GetLength(1); j++)
                {
                    double diff = Math.Abs(qTs[i - 1] - cTS[j - 1]);
                    double minPath = dtwTable[i-1, j-1];
                    minPath = Math.Min(minPath, dtwTable[i-1, j]);
                    minPath = Math.Min(minPath, dtwTable[i, j-1]);

                    dtwTable[i, j] = diff + minPath;
                }
            }

            return dtwTable[dtwTable.GetLength(0)-1, dtwTable.GetLength(1)-1];
        }
        static public double corr(double[] default_data, double[] target_data) {

            double corr = 0;
            double multiplyXYSigma = 0;
            double xSigma = 0;
            double ySigma = 0;
            double xPowSigma = 0;
            double yPowSigma = 0;
            double numerator = 1; // 분자
            double divide = 1; //분모

            double temp_ = 0; 
            double sum_ = 0;

            try {
                if (default_data.Length == target_data.Length  && ( target_data[default_data.Length-1] - target_data[0] > 0) ) {
                    
                    for (int index = 0; index < default_data.Length; index++) {
                        sum_ = index > 0? (sum_ +  target_data[index] - temp_ ) : 0 ;

                        multiplyXYSigma += default_data[index] * target_data[index];
                        xSigma += default_data[index];
                        ySigma += target_data[index];
                        xPowSigma += default_data[index] * default_data[index];
                        yPowSigma += target_data[index] * target_data[index];

                        temp_ = target_data[index];
                    }
                    divide = Math.Sqrt(((default_data.Length * xPowSigma) - (xSigma * xSigma)) * ((target_data.Length * yPowSigma) - (ySigma * ySigma)));
                    numerator = (default_data.Length * multiplyXYSigma) - (xSigma * ySigma);

                    //corr = numerator / divide;
                    if (sum_ > 0) {
                        corr = numerator / divide;
                    }
                    else {
                        corr = 0;
                    }
                    
                }
                else {
                    corr = 0;
                }
            }
            catch {//Exception ex
                corr = 0;
                //Console.WriteLine(ex);
            }

            return corr;
        }
    }
}
