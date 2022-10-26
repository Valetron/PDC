using System.Diagnostics;

namespace task1
{
    public partial class Form1 : Form
    {
        ParallelArray bubbleArray;
        ParallelArray quickArray;
        ParallelArray stupidArray;
        private Stopwatch totalTime;
        private int[] arrayB;
        private int[] arrayQ;
        private int[] arrayS;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (null != comboBox1.SelectedItem)
            {

                Random rnd = new Random();
                arrayB = new int[Convert.ToInt32(comboBox1.SelectedItem)];
                arrayQ = new int[Convert.ToInt32(comboBox1.SelectedItem)];
                arrayS = new int[Convert.ToInt32(comboBox1.SelectedItem)];

                for (int i = 0; i < arrayB.Length; ++i)
                {
                    int num = rnd.Next(0, 101);
                    arrayB[i] = num;
                    arrayQ[i] = num;
                    arrayS[i] = num;
                }              

                bubbleArray = new ParallelArray(arrayB);
                quickArray = new ParallelArray(arrayQ);
                stupidArray = new ParallelArray(arrayS);

                totalTime = Stopwatch.StartNew();

                if (checkBoxThreading.Checked)
                {
                    Thread bubbleThread = new Thread(bubbleArray.bubbleSort);
                    bubbleThread.Start();

                    Thread quickThread = new Thread(quickArray.quickSort);
                    quickThread.Start();

                    Thread stupidThread = new Thread(stupidArray.stupidSort);
                    stupidThread.Start();

                    totalTime.Stop();
                }
                else
                {
                    bubbleArray.bubbleSort();
                    quickArray.quickSort();
                    stupidArray.stupidSort();
                    
                    totalTime.Stop();
                }

                label_bubble_sorted.Text = "Sorted: " + bubbleArray.isSorted();
                label_bubble_comp.Text = "Compare: " + bubbleArray.getCompare();
                label_bubble_swaps.Text = "Swaps: " + bubbleArray.getSwaps().ToString();
                label_bubble_time.Text = "Time: " + bubbleArray.getTime().ElapsedMilliseconds.ToString();

                label_quick_sorted.Text = "Sorted: " + quickArray.isSorted();
                label_quick_comp.Text = "Compare: " + quickArray.getCompare();
                label_quick_swaps.Text = "Swaps: " + quickArray.getSwaps().ToString();
                label_quick_time.Text = "Time: " + quickArray.getTime().ElapsedMilliseconds.ToString();

                label_stupid_sorted.Text = "Sorted: " + stupidArray.isSorted();
                label_stupid_comp.Text = "Compare: " + stupidArray.getCompare();
                label_stupid_swaps.Text = "Swaps: " + stupidArray.getSwaps().ToString();
                label_stupid_time.Text = "Time: " + stupidArray.getTime().ElapsedMilliseconds.ToString();

                labelTotalTime.Text = "Total time: " + totalTime.ElapsedMilliseconds.ToString();
            }
            else
                MessageBox.Show("Size not set!");
        }
    }
}