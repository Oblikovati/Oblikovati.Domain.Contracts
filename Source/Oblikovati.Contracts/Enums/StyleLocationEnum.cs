namespace Oblikovati.Contracts.Enums;
/// <summary>
/// There this style is stored
/// </summary>
public enum StyleLocationEnum
{
      /// <summary>
      /// Application wide styles, which comes out of the box with Oblikovati
      /// </summary>
      OblikovatiStyleLocation,
      /// <summary>
      /// Project scoped styles, accessible for all the documents.
      /// </summary>
      ProjectStyleLocation,
      /// <summary>
      /// Document scoped styles, accessible only for the document.
      /// </summary>
      DocumentStyleLocation,
}