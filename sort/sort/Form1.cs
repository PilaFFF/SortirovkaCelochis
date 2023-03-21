using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApp
{
    public partial class Form1 : Form
    {
        int[] array;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (array == null)
            {
                MessageBox.Show("Сначала введите массив!");
                return;
            }

            Stopwatch stopwatch = Stopwatch.StartNew();
            
            int[] sortedArray = null;

            switch (cmbSort.SelectedIndex)
            {
                case 0: // Bubble Sort
                    stopwatch.Start();
                    sortedArray = BubbleSort(array);
                    stopwatch.Stop();
                    break;
                case 1: // Insertion Sort
                    stopwatch.Start();
                    sortedArray = InsertionSort(array);
                    stopwatch.Stop();
                    break;
                case 2: // Shaker Sorting
                    stopwatch.Start();
                    sortedArray = ShakerSort(array);
                    stopwatch.Stop();
                    break;
                case 3: // Shell Sorting
                    stopwatch.Start();
                    sortedArray = ShellSort(array);
                    stopwatch.Stop();
                    break;
            }

            DisplaySortedArray(sortedArray);
            lblTime.Text = "Время: " + stopwatch.ElapsedMilliseconds.ToString() + " мс";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtArray.Text))
            {
                MessageBox.Show("Пожалуйста, введите массив!");
                return;
            }

            string[] input = txtArray.Text.Split(',');
            array = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if (!int.TryParse(input[i], out array[i]))
                {
                    MessageBox.Show("Ошибка ввода");
                    array = null;
                    return;
                }
            }

            MessageBox.Show("Массив успешно введён");
        }

        private int[] BubbleSort(int[] arr)
        {
            int n = arr.Length;
            int temp;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }

        private int[] InsertionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }

            return arr;
        }

        private int[] ShakerSort(int[] arr)
        {
            int n = arr.Length;
            int temp;
            int left = 0;
            int right = n - 1;
            int shift = 0;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        shift = i;
                    }
                }

                right = shift;

                for (int j = right; j > left; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                        shift = j;
                    }
                }

                left = shift;
            }

            return arr;
        }

        private int[] ShellSort(int[] arr)
        {
            int n = arr.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j = i;

                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }

                    arr[j] = temp;
                }

                gap /= 2;
            }

            return arr;
        }

        private void DisplaySortedArray(int[] arr)
        {
            string output = "";

            for (int i = 0; i < arr.Length; i++)
            {
                output += arr[i].ToString() + ",";
            }

            output = output.TrimEnd(',');

            txtSortedArray.Text = output;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtArray_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
