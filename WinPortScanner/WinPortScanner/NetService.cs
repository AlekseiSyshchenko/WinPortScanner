using System;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace WinPortScanner
{
    class NetService : IDisposable
    {
        public static void ScanPort(string ip, int startPort, int endPort)
        {
            int closedPort = 0;
            if (startPort > endPort)
            {
                int tempPort = startPort;
                startPort = endPort;
                endPort = tempPort;
            }

            using (FileService fileService = new FileService())
            {
                using (TcpClient client = new TcpClient())
                {

                    for (int port = startPort; port <= endPort; port++)
                    {

                        try
                        {


                            closedPort = port;
                            client.Connect(ip, port);
                            fileService.WriteOpen(ip, port);
                            client.Close();

                        }

                        catch (SocketException e)
                        {

                            fileService.WriteClose(ip, closedPort);

                        }

                    }
                    client.Close();

                }
                fileService.CloseFile();
            }



        }

        public void Dispose()
        {


            //GC.SuppressFinalize(this);
            //throw new NotImplementedException();
        }
    }
}

