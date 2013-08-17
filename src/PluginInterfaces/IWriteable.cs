namespace F_RS232Client
{
    public interface IWriteable
    {
        void Write(byte[] bytes);
        void Write(byte b);
        void Write(string str);
    }
}
