using System.Runtime.InteropServices;

namespace VrepSharp
{
    public static class Vrep_Sharp
    {
        private const string dllName = "remoteApi.dll";

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int simxStart(string ip, int port, bool waitForConnection, bool reconnectOnDisconnect, int timeoutMS, int cycleTimeMS);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void simxFinish(int clientID);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int simxGetLastCmdTime(int clientID);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Simx_Error simxGetObjectHandle(int clientID, string objectName, out int handle, Simx_OpenMode opmode);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int simxGetConnectionId(int clientID);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Simx_Error simxStartSimulation(int clientID, Simx_OpenMode opmode);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Simx_Error simxStopSimulation(int clientID, Simx_OpenMode opmode);

    }
}
