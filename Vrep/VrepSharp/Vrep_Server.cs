namespace VrepSharp
{

    public class Vrep_Server
    {
        /// <summary>
        /// Default Constructor With Default Value
        /// </summary>
        public Vrep_Server()
        {
            this.IP = "127.0.0.1";
            this.Port = 19997;
            this.Wait = true;
            this.Reconnect = true;
            this.TimeOut = 5000;
            this.CycleTime = 5;
        }

        /// <summary>
        /// Second Constructor
        /// </summary>
        /// <param name="ip">Server Ip Address (default Ip 127.0.0.1)</param>
        /// <param name="port">Server Port (default port 19997)</param>
        /// <param name="wait">Wait For Connection (default value true)</param>
        /// <param name="reconnect">Reconnect on Disconnect (default value true)</param>
        /// <param name="timeout">Connection Time Out Milliseconds (default value 5000ms)</param>
        /// <param name="cycletime">Cycle Time Milliseconds (default value 5ms)</param>
        public Vrep_Server(string ip, int port, bool wait, bool reconnect, int timeout, int cycletime)
        {
            this.IP = ip;
            this.Port = port;
            this.Wait = wait;
            this.Reconnect = reconnect;
            this.TimeOut = timeout;
            this.CycleTime = cycletime;
        }


        public string IP { get; set; }

        public int Port { get; set; }

        public bool Wait { get; set; }

        public bool Reconnect { get; set; }

        public int TimeOut { get; set; }

        public int CycleTime { get; set; }
    }

}
