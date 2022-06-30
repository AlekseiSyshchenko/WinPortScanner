using System;
using System.Threading.Tasks;

namespace WinPortScanner
{
    class FileService : IDisposable
    {
        private StreamWriter file = new StreamWriter(Settings.path, true);

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void WriteOpen(string ip, int port)
        {
            file.WriteLine($"{DateTime.Now}, {ip}, {port}, Open");
        }

        public void WriteClose(string ip, int port)
        {
            file.WriteLine($"{DateTime.Now}, {ip}, {port}, Close");
        }

        public void CloseFile()
        {
            file.Close();
        }

    }
}
