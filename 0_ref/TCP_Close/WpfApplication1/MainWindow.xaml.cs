using System;
using System.Text;
using System.Windows;
using System.Threading;



namespace SocketBlockingInterrupt
{
    public partial class MainWindow : Window
    {

        SynchronizationContext synContext;
        
        public MainWindow()
        {
            InitializeComponent();
            synContext = SynchronizationContext.Current;
            btnStop.IsEnabled = false;
            
            
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Form1 frm2 = new Form1();
            frm2.Show();
        }
        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            //frm2.Dispose();
        }
        void updateUI(object o)
        {
            string str = (string)o;
            lbMsg.Items.Add(str);
        }
    }
}