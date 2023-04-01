using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IDebugInstrumentationSink
{
    void ObjectCreated(int Cookie);
    void ObjectDestroyed(int Cookie);
    void ObjectAddRefd(int Cookie, int ToReferenceCount);
    void ObjectReleased(int Cookie, int ToReferenceCount);
    void ObjectQueryInterfaced(int Cookie, string InterfaceIID, bool Successful);
    void OnMemberInvoke(int Cookie, string MemberName, EventTimingEnum BeforeOrAfter, int Result);
}