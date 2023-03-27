﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IGeneralNote
{

    ISheet Parent { get; }
    IAttributeSets AttributeSets { get; }
    IColor Color { get; set; }
    string Text { get; set; }
    string FormattedText { get; set; }
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    ILayer Layer { get; set; }
    double LineSpacing { get; set; }
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    IPoint2d Position { get; set; }
    double WidthScale { get; set; }
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    IGeometryIntent _AttachedEntity { get; set; }
    IBox2d RangeBox { get; }
    bool Fitted { get; }
    double FittedTextHeight { get; }
    double FittedTextWidth { get; }
    double Height { get; set; }
    double Rotation { get; set; }
    ITextStyle TextStyle { get; set; }
    double Width { get; set; }
    IUnitAttributes UnitAttributes { get; }
    IColor BackgroundColor { get; set; }
    bool UseBackgroundColor { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}
