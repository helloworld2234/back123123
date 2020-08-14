using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTesting {
    public static class Normalization
    {
        public static double[] StandardScore(double[] rawData)
        {
            double[] normalizedData = new double[rawData.Length];

            if (rawData.Length > 0)
            {
                double sum = 0;
                double square_sum = 0;
                for (int i = 0; i < rawData.Length; i++)
                {
                    sum += rawData[i];
                    square_sum += (rawData[i] * rawData[i]);
                }

                double average = sum / rawData.Length;
                double square_average = square_sum / rawData.Length;
                double variation = square_average - (average * average);
                double standard_deviation = Math.Sqrt(variation);

                for (int i = 0; i < rawData.Length; i++)
                {
                    normalizedData[i] = (rawData[i] - average) / standard_deviation;
                }
            }

            return normalizedData;
        }

        public static double[] FeatureScaling(int[] rawData)
        {
            double[] normalizedData = new double[rawData.Length];

            if (rawData.Length > 0)
            {
                double minValue = double.MaxValue;
                double maxValue = double.MinValue;

                for (int i = 0; i < rawData.Length; i++)
                {
                    if (rawData[i] > maxValue)
                        maxValue = rawData[i];

                    if (rawData[i] < minValue)
                        minValue = rawData[i];
                }

                if (minValue < maxValue)
                {
                    for (int i = 0; i < rawData.Length; i++)
                        normalizedData[i] = (rawData[i] - minValue) / (maxValue - minValue);
                }
            }

            return normalizedData;
        }
    }
}
