using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace client
{
    class Client
    {
        private Form1 form1;
        private Socket client;

        public Client(Form1 form1, String ip, int port)
        {
            this.form1 = form1;

            InitClient(ip, port);
        }
        private void InitClient(String ip, int port)
        {
            try
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 7000);

                client = new Socket(AddressFamily.InterNetwork,
                                         SocketType.Stream, ProtocolType.Tcp);

                client.Connect(ipep);  // 127.0.0.1 서버 7000번 포트에 접속시도

                Thread th = new Thread(new ParameterizedThreadStart(ReavThread));
                th.IsBackground = true;
                th.Start(client);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void ReavThread(object obj)
        {
            Socket sock = (Socket)obj;
            while (true)
            {
                byte[] data = ReceiveData(sock);
                if (data == null)
                    break;
                string msg = Encoding.Default.GetString(data);
                form1.RecvData(msg);
            }

            sock.Close();
        }
        private byte[] ReceiveData(Socket sock)
        {
            try
            {
                int total = 0;
                int size = 0;
                int left_data = 0;
                int recv_data = 0;
                // 수신할 데이터 크기 알아내기   
                byte[] data_size = new byte[4];
                recv_data = sock.Receive(data_size, 0, 4, SocketFlags.None);
                size = BitConverter.ToInt32(data_size, 0);
                left_data = size;

                byte[] data = new byte[size];
                // 서버에서 전송한 실제 데이터 수신
                while (total < size)
                {
                    recv_data = sock.Receive(data, total, left_data, 0);
                    if (recv_data == 0) break;
                    total += recv_data;
                    left_data -= recv_data;
                }
                return data;
            }
            catch (Exception)
            {
                //Console.WriteLine("[수신에러] : " + ex.Message);
                return null;
            }
        }
        public void SendDataOne(string msg)
        {
            try
            {
                byte[] data = Encoding.Default.GetBytes(msg);

                if (client.Connected)
                {
                    SendData(client, data);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("[데이터전송1]" + ex.Message);
            }
        }

        private void SendData(Socket s, byte[] data)
        {
            try
            {
                int total = 0;
                int size = data.Length;
                int left_data = size;
                int send_data = 0;

                // 전송할 실제 데이터의 크기 전달
                byte[] data_size = new byte[4];
                data_size = BitConverter.GetBytes(size);
                send_data = s.Send(data_size);

                // 실제 데이터 전송
                while (total < size)
                {
                    send_data = s.Send(data, total, left_data, SocketFlags.None);
                    total += send_data;
                    left_data -= send_data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[데이터전송2]" + ex.Message);
            }
        }
    }
}
