using System;
using VrepSharp;

namespace VrepExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Vrep_Server server = new Vrep_Server();

            //Connect To Vrep
            int clientID = Vrep_Sharp.simxStart(server.IP, server.Port, server.Wait, server.Reconnect, server.TimeOut, server.CycleTime);

            if (clientID != -1)
            {

                Console.WriteLine(string.Format("Connected to {0}:{1}", server.IP, server.Port));

                //Start Simulation
                Vrep_Sharp.simxStartSimulation(clientID, Simx_OpenMode.continuous);

                while (Vrep_Sharp.simxGetConnectionId(clientID) != -1)
                {
                    //DoSomething
                    //
                }

                Thread.Sleep(5);

                //Stop Simulation
                Vrep_Sharp.simxFinish(clientID);
            }
            else
            {
                Console.WriteLine("Connection Failed");
            }

            Console.ReadKey();
        }
    }
}
