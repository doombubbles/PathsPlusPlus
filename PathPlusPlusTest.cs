using System.Collections;
using BTD_Mod_Helper.Api.Testing;
using UnityEngine;

namespace PathsPlusPlus;

/// <summary>
/// Default test for Paths++
/// </summary>
public class PathPlusPlusTest : ModContentDefaultTest<PathPlusPlus>
{
    private PathPlusPlus Path => Content;

    /// <inheritdoc />
    public override IEnumerator Test()
    {
        yield return EnsureOnMainMenuWithNoPopUps();

        yield return LoadIntoGame();

        var towerModel = Bridge.Model.GetTowerWithName(Path.Tower);

        var tower = AssertNotNull(CreateTowerAt(Bridge, new Vector2(0, 0), towerModel));

        Path.SetTier(tower.tower, -1); // Mark this as the chosen path if there are multiple options

        for (var i = 0; i < Path.UpgradeCount; i++)
        {
            Assert(UpgradeTower(Bridge, tower, Path.Path));
        }
    }
}