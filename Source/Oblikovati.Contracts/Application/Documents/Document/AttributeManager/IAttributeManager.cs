using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Application.Documents.Document.AttributeManager;

public interface IAttributeManager
{
    string RevisionId { get; }
    IAttributesEnumerator FindAttributes(string AttributeSetName, string AttributeName, object AttributeValue);
    IAttributeSetsEnumerator FindAttributeSets(string AttributeSetName, string AttributeName, object AttributeValue);
    IObjectCollection FindObjects(string AttributeSetName, string AttributeName, object AttributeValue);
    IObjectCollection FindObjectsByPattern(string XPath);
    void PurgeAttributeSets(string AttributeSetName, bool Preview, out object PreviewResult);
    IAttributeSetsEnumerator OpenAttributeSets(IObjectCollection Objects, string AttributeSetName);
}