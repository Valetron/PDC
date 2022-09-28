namespace task1
{
    public partial class Form1 : Form
    {
        ParallelArray bubbleArray;
        ParallelArray quickArray;
        ParallelArray stupidArray;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_bubble_Click(object sender, EventArgs e)
        {
            bubbleArray = new ParallelArray();
            
            bubbleArray.bubbleSort();

            label_bubble_sorted.Text = "Sorted: " + bubbleArray.isSorted();
            label_bubble_comp.Text = "Compare: " + bubbleArray.getCompare();
            label_bubble_swaps.Text = "Swaps: " + bubbleArray.getSwaps();
            label_bubble_time.Text = "Time: " + bubbleArray.getTime().ElapsedMilliseconds.ToString();

            //textBox1.Text = bubbleArray.getData() + "Size -" + bubbleArray.getSize();
        }

        private void button_quick_Click(object sender, EventArgs e)
        {
            quickArray = new ParallelArray();

            quickArray.quickSort();

            label_quick_sorted.Text = "Sorted: " + quickArray.isSorted();
            label_quick_comp.Text = "Compare: " + quickArray.getCompare();
            label_quick_swaps.Text = "Swaps: " + quickArray.getSwaps();
            label_quick_time.Text = "Time: " + quickArray.getTime().ElapsedMilliseconds.ToString();

            //textBox1.Text = quickArray.getData() + "Size -" + quickArray.getSize();
        }

        private void button_stupid_Click(object sender, EventArgs e)
        {
            stupidArray = new ParallelArray();

            stupidArray.stupidSort();

            label_stupid_sorted.Text = "Sorted: " + stupidArray.isSorted();
            label_stupid_comp.Text = "Compare: " + stupidArray.getCompare();
            label_stupid_swaps.Text = "Swaps: " + stupidArray.getSwaps();
            label_stupid_time.Text = "Time: " + stupidArray.getTime().ElapsedMilliseconds.ToString();

            //textBox1.Text = stupidArray.getData() + "Size -" + stupidArray.getSize();
        }
    }
}