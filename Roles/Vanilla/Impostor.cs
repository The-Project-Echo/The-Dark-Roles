using AmongUs.GameOptions;

using TheDarkRoles.Roles.Core;
using TheDarkRoles.Roles.Core.Interfaces;

namespace TheDarkRoles.Roles.Vanilla;

public sealed class Impostor : RoleBase, IImpostor
{
    public static readonly SimpleRoleInfo RoleInfo =
        SimpleRoleInfo.CreateForVanilla(
            typeof(Impostor),
            player => new Impostor(player),
            RoleTypes.Impostor
        );
    public Impostor(PlayerControl player)
    : base(
        RoleInfo,
        player
    )
    { }
}