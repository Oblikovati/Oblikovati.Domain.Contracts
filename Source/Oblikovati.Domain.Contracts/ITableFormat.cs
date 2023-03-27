namespace Oblikovati.Domain.Contracts;

public interface ITableFormat
{

    IColor InsideLineColor { get; set; }
    double InsideLineWeight { get; set; }
    IColor OutsideLineColor { get; set; }
    double OutsideLineWeight { get; set; }
    ITextStyle TextStyle { get; set; }
}
