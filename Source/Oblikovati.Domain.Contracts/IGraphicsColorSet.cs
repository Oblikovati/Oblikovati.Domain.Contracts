namespace Oblikovati.Domain.Contracts;

public interface IGraphicsColorSet
{
    int Count { get; }
    int Id { get; }
    IColor Color { get; set; }
    void Remove(int Index);
    void Delete();
    void GetColor(int Index, out byte Red, out byte Green, out byte Blue);
    void PutColor(int Index, byte Red, byte Green, byte Blue);
    void Add(int Index, byte Red, byte Green, byte Blue);
    void GetColors(ref List<byte> Colors);
    void PutColors(ref List<byte> Colors);
}
