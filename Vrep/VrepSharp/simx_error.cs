namespace VrepSharp
{
    public enum Simx_Error
    {
        noerror = 0,
        novalue_flag = 1,
        timeout_flag = 2,
        illegal_opmode_flag = 4,
        remote_error_flag = 8,
        split_progress_flag = 16,
        local_error_flag = 32,
        initialize_error_flag = 64,
    }
}
