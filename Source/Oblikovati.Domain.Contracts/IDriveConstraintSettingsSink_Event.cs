using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IDriveConstraintSettingsSink_Event
{
    void add_OnCollision(DriveConstraintSettingsSink_OnCollisionEventHandler handler);
    void remove_OnCollision(DriveConstraintSettingsSink_OnCollisionEventHandler handler);
}
