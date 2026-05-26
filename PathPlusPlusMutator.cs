using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Simulation.Objects;
using Newtonsoft.Json.Linq;

namespace PathsPlusPlus;

/// <summary>
/// Internal mutator for Paths++ to apply to towers
/// </summary>
/// <param name="path">PathPlusPlus this is for</param>
public class PathPlusPlusMutator(PathPlusPlus path) : ModMutator
{
    /// <inheritdoc />
    public override int Priority => path.Priority;

    /// <inheritdoc />
    public override string Name => path.Name;

    /// <inheritdoc />
    public override bool CantBeAbsorbed => true;

    /// <summary>
    /// Using OnTowerSaved and OnTowerLoaded for backwards compatibility
    /// </summary>
    public override bool Saved => false;

    /// <inheritdoc />
    public override string MutatorId => path.Id;

    /// <inheritdoc />
    public override bool Mutate(Model baseModel, Model model, JToken data)
    {
        var tower = model.Cast<TowerModel>();
        var tier = data.Value<int>();

        path.Apply(tower, tier);

        return true;
    }

    /// <summary>
    /// Gets the tier for this mutator
    /// </summary>
    public int Tier(BehaviorMutator behaviorMutator) => GetData(behaviorMutator).Value<int>();
}