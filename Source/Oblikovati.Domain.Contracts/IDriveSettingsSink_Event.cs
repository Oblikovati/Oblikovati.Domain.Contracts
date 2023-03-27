using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IDriveSettingsSink_Event
{
    void add_OnCollision(DriveSettingsSink_OnCollisionEventHandler handler);
    void remove_OnCollision(DriveSettingsSink_OnCollisionEventHandler handler);
}
