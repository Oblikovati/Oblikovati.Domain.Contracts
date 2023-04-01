using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts;

public interface ITransientObjects
{
    ITranslationContext CreateTranslationContext();
    IDataMedium CreateDataMedium();
    INameValueMap CreateNameValueMap();
    IObjectCollection CreateObjectCollection(object ObjectsEnumerator);
    IObjectCollectionByVariant CreateObjectCollectionByVariant(object ObjectsEnumeratorByVariant);
    IEdgeCollection CreateEdgeCollection(object ObjectsEnumerator);
    IFaceCollection CreateFaceCollection(object ObjectsEnumerator);
    IColor CreateColor(byte Red, byte Green, byte Blue, double Opacity);
    string CreateSignatureString(string StringToSign);
    IFileMetadata CreateFileMetadata(object FullFileName);
    ICamera CreateCamera();
}