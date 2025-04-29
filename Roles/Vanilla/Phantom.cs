using AmongUs.GameOptions;
using TheDarkRoles.Roles.Core;
using TheDarkRoles.Roles.Core.Interfaces;

namespace TheDarkRoles.Roles.Vanilla;

public sealed class Phantom : RoleBase, IImpostor
{
    public Phantom(PlayerControl player) : base(RoleInfo, player) { }
    public static readonly SimpleRoleInfo RoleInfo = SimpleRoleInfo.CreateForVanilla(typeof(Phantom), player => new Phantom(player), RoleTypes.Phantom);
}
