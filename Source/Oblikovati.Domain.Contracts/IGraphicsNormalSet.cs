namespace Oblikovati.Domain.Contracts;

public interface IGraphicsNormalSet
{
    int Count { get; }
    int Id { get; }
    IUnitVector Normal { get; set; }
    void Remove(int Index);
    void Delete();
    void Add(int Index, IUnitVector Normal);
    void GetNormals(ref List<double> Normals);
    void PutNormals(ref List<double> Normals);
}
