using AmongUs.GameOptions;
using TheDarkRoles.Roles.Core;

namespace TheDarkRoles.Roles.Vanilla;

public sealed class Tracker : RoleBase
{
    public Tracker(PlayerControl player) : base(RoleInfo, player) { }
    public readonly static SimpleRoleInfo RoleInfo = SimpleRoleInfo.CreateForVanilla(typeof(Tracker), player => new Tracker(player), RoleTypes.Tracker, "#8cffff");
}
