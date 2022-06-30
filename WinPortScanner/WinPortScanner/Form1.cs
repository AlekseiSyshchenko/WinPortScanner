namespace WinPortScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btScan.Click += bt_Scan;
        }

        
        private void bt_Scan(object? sender, EventArgs e)
        {
            string ip = tbIpAddr.Text;
            int startPort = int.Parse(tbStartPort.Text);
            int endPort = int.Parse(tbEndPort.Text);
            
            NetService.ScanPort(ip, startPort, endPort);
        }
        
    }
}