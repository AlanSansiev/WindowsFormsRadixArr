using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsRadixArr
{
    class Arr
    {
    uint count; //Кол-во элементов в массиве
        Int64 time; //Время выполнения сортировки
        int[] arr; //Сортируемый массив
        int range = 10;
        int length = 0;
        public Arr()
        {
            count = 0;
            time = 0;
            arr = null;
        }
        public void loadFromFile(string path) //Загрузка из файла
        {
            List<int> l = new List<int>();
            StreamReader SR = new StreamReader(path);
            while (!SR.EndOfStream)
            {
                l.Add(Convert.ToInt32(SR.ReadLine()));
            }
            arr = l.ToArray();
            SR.Close();
            count = Convert.ToUInt32(arr.Length);
        }
        public void loadFromString(string str) //Загрузка из строки
        {
            string[] bufarr = str.Split(' ');
            arr = new int[bufarr.Length];
            for (int t = 0; t < bufarr.Length; t++)
            {
                arr[t] = Convert.ToInt32(bufarr[t]);
            }
            count = Convert.ToUInt32(arr.Length);
        }
        public void loadFromRandom(int from, int to, uint count) //Рандомный массив
        {
            arr = new int[count];
            Random rd = new Random();
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rd.Next(from, to);
            }
            this.count = Convert.ToUInt32(arr.Length);
        }
        public string toStr()
        {
            StringBuilder str = new StringBuilder("");
            for (int i = 0; i < arr.Length; i++)
            {
                str.Append(arr[i]);
                str.Append(" ");
            }
            return str.ToString();
        }
        public void Sort() //Вызов сортировки массива
        {
            DateTime t1 = DateTime.Now;
            Int64 tt1 = t1.Millisecond;
            quickSort(arr);
            DateTime t2 = DateTime.Now;
            Int64 tt2 = t2.Millisecond;
            time = tt2-tt1;
        }
        void quickSort(int[] arr)
        {
            foreach (int elem in arr)
                if (Convert.ToString(elem).Length >length ) length = elem;
            List<int>[] lists = new List<int>[range];
            for (int i = 0; i < range; ++i)
                lists[i] = new List<int>();

            for (int step = 0; step < length; ++step)
            {

                //распределение по спискам
                for (int i = 0; i < arr.Length; ++i)
                {
                    int temp = (arr[i] % (int)Math.Pow(range, step + 1)) /
                                                  (int)Math.Pow(range, step);
                    lists[temp].Add(arr[i]);
                }
                //сборка
                int k = 0;
                for (int i = 0; i < range; ++i)
                {
                    for (int j = 0; j < lists[i].Count; ++j)
                    {
                        arr[k++] = (int)lists[i][j];
                    }
                }
                for (int i = 0; i < range; ++i)
                    lists[i].Clear();
            }

        }
        public int[] getArray() //Возвращение массива
        {
            return arr;
        }
        public Int64 getTime() //Возвращение времени сортировки
        {
            return time;
        }
    }
}

