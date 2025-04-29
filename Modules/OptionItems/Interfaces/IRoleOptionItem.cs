using TheDarkRoles.Roles.Core;
using UnityEngine;

namespace TheDarkRoles.Modules.OptionItems.Interfaces;

public interface IRoleOptionItem
{
    public CustomRoles RoleId { get; }
    public Color RoleColor { get; }
}
