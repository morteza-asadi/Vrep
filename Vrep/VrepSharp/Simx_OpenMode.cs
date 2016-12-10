namespace VrepSharp
{
    public enum Simx_OpenMode
    {
        oneshot = 0,
        oneshot_wait = 65536,
        streaming = 131072,
        continuous = 131072,
        oneshot_split = 196608,
        continuous_split = 262144,
        streaming_split = 262144,
        discontinue = 327680,
        buffer = 393216,
        remove = 458752,
    }
}
