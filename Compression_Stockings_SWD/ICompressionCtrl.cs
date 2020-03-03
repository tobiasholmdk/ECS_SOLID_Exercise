namespace CompressionStocking
{
    public interface ICompressionCtrl
    {
        void Compress();
        void Decompress();
        bool IsCompressed();
    }
}