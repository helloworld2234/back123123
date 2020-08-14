using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTesting {
    class Representation
    {
        public static double[] PIP_ED(double[] rawDate, int n)
        {
            double[] pipData = new double[n];

            List<int> pipIndexList = new List<int>();

            pipIndexList.Add(0); // PIP1
            pipIndexList.Add(rawDate.Length - 1); //PIP2

            for (int pipCount = 2; pipCount < n; pipCount++)
            {
                int rightPointer = 1;

                int leftPIPIndex = pipIndexList[rightPointer - 1];
                int rightPIPIndex = pipIndexList[rightPointer];

                double maxDistance = double.MinValue;
                int maxDistanceIndex = 0;

                for (int i = 1; i < rawDate.Length; i++)
                {
                    if (rightPIPIndex == i && i != rawDate.Length - 1)
                    {
                        rightPointer++;
                        leftPIPIndex = rightPIPIndex;
                        rightPIPIndex = pipIndexList[rightPointer];
                    }
                    else
                    {
                        double distance = euclideanDistance(leftPIPIndex, rawDate[leftPIPIndex], rightPIPIndex, rawDate[rightPIPIndex], i, rawDate[i]);
                        if (maxDistance < distance)
                        {
                            maxDistance = distance;
                            maxDistanceIndex = i;
                        }
                    }
                }

                for (int i = 0; i < pipIndexList.Count; i++)
                {
                    if (pipIndexList[i] > maxDistanceIndex)
                    {
                        pipIndexList.Insert(i, maxDistanceIndex);
                        break;
                    }
                }
            }

            for (int i = 0; i < pipIndexList.Count; i++)
            {
                //Console.WriteLine(pipIndexList[i]);
                pipData[i] = rawDate[pipIndexList[i]];
            }

            return pipData;
        }

        private static double euclideanDistance(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            return Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2)) + Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));
        }

        public static double[] PIP_PD(double[] rawDate, int n)
        {
            double[] pipData = new double[n];

            List<int> pipIndexList = new List<int>();

            pipIndexList.Add(0); // PIP1
            pipIndexList.Add(rawDate.Length - 1); //PIP2

            for (int pipCount = 2; pipCount < n; pipCount++)
            {
                int rightPointer = 1;

                int leftPIPIndex = pipIndexList[rightPointer - 1];
                int rightPIPIndex = pipIndexList[rightPointer];

                double maxDistance = double.MinValue;
                int maxDistanceIndex = 0;

                for (int i = 1; i < rawDate.Length; i++)
                {
                    if (rightPIPIndex == i && i != rawDate.Length - 1)
                    {
                        rightPointer++;
                        leftPIPIndex = rightPIPIndex;
                        rightPIPIndex = pipIndexList[rightPointer];
                    }
                    else
                    {
                        double distance = perpendicularDistance(leftPIPIndex, rawDate[leftPIPIndex], rightPIPIndex, rawDate[rightPIPIndex], i, rawDate[i]);
                        if (maxDistance < distance)
                        {
                            maxDistance = distance;
                            maxDistanceIndex = i;
                        }
                    }
                }

                for (int i = 0; i < pipIndexList.Count; i++)
                {
                    if (pipIndexList[i] > maxDistanceIndex)
                    {
                        pipIndexList.Insert(i, maxDistanceIndex);
                        break;
                    }
                }
            }

            for (int i = 0; i < pipIndexList.Count; i++)
            {
                //Console.WriteLine(pipIndexList[i]);
                pipData[i] = rawDate[pipIndexList[i]];
            }

            return pipData;
        }

        private static double perpendicularDistance(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double s = (y2 - y1) / (x2 - x1);

            return Math.Abs(s * x3 - y3 + y1 - s * x1) / Math.Sqrt(s * s + 1);
        }

        public static double[] PIP_VD(double[] rawDate, int n)
        {
            double[] pipData = new double[n];

            List<int> pipIndexList = new List<int>();

            pipIndexList.Add(0); // PIP1
            pipIndexList.Add(rawDate.Length - 1); //PIP2

            for (int pipCount = 2; pipCount < n; pipCount++)
            {
                int rightPointer = 1;

                int leftPIPIndex = pipIndexList[rightPointer - 1];
                int rightPIPIndex = pipIndexList[rightPointer];

                double maxDistance = double.MinValue;
                int maxDistanceIndex = 0;

                for (int i = 1; i < rawDate.Length; i++)
                {
                    if (rightPIPIndex == i && i != rawDate.Length - 1)
                    {
                        rightPointer++;
                        leftPIPIndex = rightPIPIndex;
                        rightPIPIndex = pipIndexList[rightPointer];
                    }
                    else
                    {
                        double distance = verticalDistance(leftPIPIndex, rawDate[leftPIPIndex], rightPIPIndex, rawDate[rightPIPIndex], i, rawDate[i]);
                        if (maxDistance < distance)
                        {
                            maxDistance = distance;
                            maxDistanceIndex = i;
                        }
                    }
                }

                for (int i = 0; i < pipIndexList.Count; i++)
                {
                    if (pipIndexList[i] > maxDistanceIndex)
                    {
                        pipIndexList.Insert(i, maxDistanceIndex);
                        break;
                    }
                }
            }

            for (int i = 0; i < pipIndexList.Count; i++)
            {
                //Console.WriteLine(pipIndexList[i]);
                pipData[i] = rawDate[pipIndexList[i]];
            }

            return pipData;
        }

        private static double verticalDistance(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double s = (y2 - y1) / (x2 - x1);

            return Math.Abs(s * x3 - s * x1 + y1 - y3);
        }

        public static double[] sampling(double[] rawData, int n)
        {
            double[] samplingData = new double[n];

            int interval = rawData.Length / n;

            for (int i = 0; i < n; i++)
            {
                samplingData[i] = rawData[i * interval];
            }

            return samplingData;
        }

        public static double[] PAA(double[] rawData, int n)
        {
            double[] paaData = new double[n];

            int interval = rawData.Length / n;

            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                int count = 0;
                for (int j = interval * i; j < interval * (i + 1); j++)
                {
                    sum += rawData[j];
                    count++;
                }

                if (count != 0)
                {
                    double avg = sum / count;
                    paaData[i] = avg;
                }

            }

            return paaData;
        }
    }
}
