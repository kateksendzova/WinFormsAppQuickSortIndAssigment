using System.Diagnostics;

namespace WinFormsAppQuickSortIndAssigment
{
    public partial class Form1 : Form
    {
        private double[] currentArray;
        private double[] arrayWithoutModaForSort;

        public struct CountElement
        {
            public double Value;
            public int Count;

            public CountElement(double value, int count)
            {
                Value = value;
                Count = count;
            }
        }

        public Form1()
        {
            InitializeComponent();

            numericUpDown_Size.Minimum = 2;

            button_GenerateArray.Click += button_GenerateArray_Click;
            button_DeleteModa.Click += button_DeleteModa_Click;
            button_Sort.Click += button_Sort_Click;

            button_Sort.Enabled = false;
        }

        private void button_GenerateArray_Click(object sender, EventArgs e)
        {
            int size = (int)numericUpDown_Size.Value;

            currentArray = GenerateArray(size);

            textBox_GeneratedArray.Text = string.Join(", ", currentArray);

            textBox_Moda.Clear();
            textBox_ArrayWithoutModa.Clear();
            richTextBox_StepsOfSorting.Clear();
            textBox_SortedArray.Clear();
            textBox_Time.Clear();

            button_Sort.Enabled = false;
            button_DeleteModa.Enabled = true;
        }

        private double[] GenerateArray(int size)
        {
            Random rand = new Random();
            double[] array = new double[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = Math.Round(rand.NextDouble() * 1.5, 1);
            }
            return array;
        }

        private void button_DeleteModa_Click(object sender, EventArgs e)
        {
            if (currentArray == null)
            {
                MessageBox.Show("Спочатку згенеруйте масив!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<double> listWithoutModa = new List<double>(currentArray);
            List<CountElement> countList = new List<CountElement>();

            for (int i = 0; i < listWithoutModa.Count; i++)
            {
                bool found = false;
                for (int j = 0; j < countList.Count; j++)
                {
                    if (countList[j].Value == listWithoutModa[i])
                    {
                        CountElement temp = countList[j];
                        temp.Count++;
                        countList[j] = temp;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    countList.Add(new CountElement(listWithoutModa[i], 1));
                }
            }

            if (countList.Count > 0)
            {
                CountElement max = countList[0];
                for (int i = 0; i < countList.Count; i++)
                {
                    if (countList[i].Count > max.Count)
                    {
                        max = countList[i];
                    }
                }

                textBox_Moda.Text = $": {max.Value}; зустрічається {max.Count} раз";

                listWithoutModa.RemoveAll(x => x == max.Value);
            }

            textBox_ArrayWithoutModa.Text = string.Join(", ", listWithoutModa);

            arrayWithoutModaForSort = listWithoutModa.ToArray();

            button_Sort.Enabled = true;
        }

        private void button_Sort_Click(object sender, EventArgs e)
        {
            if (arrayWithoutModaForSort == null)
            {
                MessageBox.Show("Спочатку видаліть моду!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            richTextBox_StepsOfSorting.Clear();
            textBox_SortedArray.Clear();
            textBox_Time.Clear();

            double[] arrayForSort = (double[])arrayWithoutModaForSort.Clone();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            if (arrayForSort.Length > 0)
            {
                QuickSort(arrayForSort, 0, arrayForSort.Length - 1, richTextBox_StepsOfSorting);
            }

            sw.Stop();

            textBox_SortedArray.Text = string.Join(", ", arrayForSort);
            textBox_Time.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ffffff");
        }

        public static void QuickSort(double[] arr, int firstIndex, int lastIndex, RichTextBox richTextBox)
        {
            if (firstIndex < lastIndex)
            {
                int pivotIndex = SplitArray(arr, firstIndex, lastIndex, richTextBox);

                QuickSort(arr, firstIndex, pivotIndex - 1, richTextBox);
                QuickSort(arr, pivotIndex + 1, lastIndex, richTextBox);
            }
        }

        private static int SplitArray(double[] array, int firstIndex, int lastIndex, RichTextBox richTextBox)
        {
            double[] subArray = new double[lastIndex - firstIndex + 1];
            Array.Copy(array, firstIndex, subArray, 0, subArray.Length);

            double pivot = array[firstIndex];

            richTextBox.AppendText($"Підмасив: {string.Join(", ", subArray)}\r\n");
            richTextBox.AppendText($"Опорний елемент: {pivot}\r\n");

            int left = firstIndex + 1;
            int right = lastIndex;

            while (true)
            {
                while (left <= right && array[left] < pivot)
                {
                    left++;
                }

                while (right >= left && array[right] > pivot)
                {
                    right--;
                }

                if (left >= right)
                {
                    break;
                }

                double tempPivot = array[right];
                array[right] = array[left];
                array[left] = tempPivot;

                left++;
                right--;
            }

            double temp = array[firstIndex];
            array[firstIndex] = array[right];
            array[right] = temp;

            double[] subArrayAfter = new double[lastIndex - firstIndex + 1];
            Array.Copy(array, firstIndex, subArrayAfter, 0, subArrayAfter.Length);

            richTextBox.AppendText($"Результат після перестановки: {string.Join(", ", subArrayAfter)}\r\n\r\n");

            return right;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_ArrayWithoutModa.Clear();
            textBox_GeneratedArray.Clear();
            textBox_SortedArray.Clear();
            richTextBox_StepsOfSorting.Clear();
            textBox_Time.Clear();
            textBox_Moda.Clear();
            button_Sort.Enabled = false;
            button_DeleteModa.Enabled = false;

        }
    }
}