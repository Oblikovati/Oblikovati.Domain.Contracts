using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IColor
{
    byte Blue { get; set; }
    byte Green { get; set; }
    double Opacity { get; set; }
    byte Red { get; set; }
    ColorSourceTypeEnum ColorSourceType { get; set; }
    void GetColor(out byte Red, out byte Green, out byte Blue);
    void SetColor(byte Red, byte Green, byte Blue);
}
