# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [1.2.3] - 2026-07-01

- A few minor bug fixes for edge cases

## [1.2.2] - 2026-06-03

- Recompiled for BTD6 v55

## [1.2.0] - 2026-05-06

#### New functionality for Extended Vanilla Paths

- Better support for multiple extensions of the same vanilla path: you can now cycle to choose which path to use on a per-tower basis in game as well as in the upgrade screen (which sets the default).
- Extended paths can now begin before Tier 6 to create alternate branches of vanilla paths, using the same upgrade cycling to choose which path to use for each tower
  - These paths must add all upgrades from their starting tier through at least tier 5 to be valid
  - For Modders, all you have to do is give your `UpgradePlusPlus` classes a Tier <= 5, and if your `PathPlusPlus` class's `ExtendVanillaPath` value is properly set it'll do the rest
    - Optionally there's a `PathPlusPlus.UseUpgradedTowerModels` override that can be set to true to make the base TowerModel for the upgrades be the corresponding upgraded version on the original path, rather than the last TowerModel before the branching off point

## [1.1.19] - 2026-02-12

- Fixed for BTD6 v53
- Some internal reworking to better support Useful Utilities upgrade queueing

## [1.1.18] - 2025-12-03

- Fixed a buggy interaction with the Frontier Legends Sheriff upgrades UI

## [1.1.17] - 2025-12-03

- Fixed for v52

## [1.1.16] - 2025-09-27

- Fixed a visual bug that could prevent buying Tier 6+ upgrades in the main 3 paths

## [1.1.15] - 2025-09-26

- UpgradePlusPlus now has a `MaxAtOnce` to control how many of that upgrade can be purchased on different towers at the same time
  - Default is 1 for Tier 5+ upgrades (unless Unlimited5thTiers+ mod is installed), unlimited for other tiers
- Added some more patches to prevent Beast Handler extra paths from breaking

## [1.1.14] - 2025-08-29

- Fixed Paths++ UI changes to not interfere with Powers Pro upgrades

## [1.1.13] - 2025-08-27

- Additional fixes for v50

## [1.1.12] - 2025-08-27

- Fixed for BTD6 v50

## [1.1.11] - 2025-06-19

- Fixed for BTD6 v49

## [1.1.10] - 2025-02-11

- Fixed for BTD6 v47

## [1.1.9] - 2024-12-10

- Fixed for BTD6 v46

## [1.1.8] - 2024-10-23

- Fixed bug where upgrading a tower to Tier 6+ in an extra path could visually lock other towers' upgrades in Balanced Mode

## [1.1.7] - 2024-10-09

- Fixed for BTD6 v45

## [1.1.6] - 2024-08-01

- For modders, added `MultiPathPlusPlus` and `MultiUpgradePlusPlus` classes for making paths that apply to multiple towers
  - Apart from overriding `Towers` instead of `Tower`, usage will be the same

## [1.1.5] - 2024-05-29

- Fixed for BTD6 v43

## [1.1.4] - 2024-04-08

- Fixed for v42.0

## [1.1.3] - 2024-02-14

- Fixed for BTD6 v41.1
  - The specific patch in question should now also be more resilient to game updates going forward

## [1.1.2] - 2023-12-05

- Fixed for BTD6 v40.0
- The `UpgradeCount` property no longer needs to be manually specified for Paths, it will be inferred if omitted

## [1.1.1] - 2023-10-26

- Fix custom upgrade containers not appearing for tier 5+ upgrades on towers with paragons
- Fixed Balanced Mode sometimes allowing you to get one more upgrade than intended
- When Paths++ and Paragon upgrades overlap for a tower, a button now appears on the upgrade to swap which one is showing
  - The "Paragon Overlap Default" mod setting controls which is the one it starts off as showing, with Paths++ being the default
  - You can also right click the upgrade to swap
- When multiple extensions for the same vanilla path on a tower are installed together, a button now appears in the upgrades screen to cycle through which will be used in games
  - Can only swap when not in an active game
- Improved upgrade screen visuals for non 16x9 aspect ratios
- `PathPlusPlus.ValidTiers` can now override Ultimate Crosspathing when Balanced Mode is on, if the modder so desires
- Added `NeedsConfirmation`, `ConfirmationTitle` and `ConfirmationBody` overrides for `UpgradePlusPlus`s that work like they do for `ModUpgrades`s
- Added `PathPlusPlus.OnUpgraded` and `UpgradePlusPlus.OnUpgraded` overrides to perform effects when upgrades are bought
  - The `BloonsTD6Mod.OnTowerUpgraded` hook will also be called for your mod's own Paths++ upgrades

## [1.1.0] - 2023-10-14

- Fixed for BTD6 v39.0
- Added functionality for creating additional tiers for tower upgrade paths, see updated readme for more details

## [1.0.2] - 2023-07-28

- Fixed for BTD6 v38.1

## [1.0.1] - 2023-06-07

- Fixed for BTD6 v37.0
- Fixed error message when selecting the Rare Quincy Action Figure

## [1.0.0] - 2023-05-09

Initial Release

[unreleased]: https://github.com/doombubbles/PathsPlusPlus/compare/1.2.3...HEAD
[1.2.3]: https://github.com/doombubbles/PathsPlusPlus/compare/1.2.2...1.2.3
[1.2.2]: https://github.com/doombubbles/PathsPlusPlus/compare/1.2.0...1.2.2
[1.2.0]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.19...1.2.0
[1.1.19]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.18...1.1.19
[1.1.18]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.17...1.1.18
[1.1.17]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.16...1.1.17
[1.1.16]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.15...1.1.16
[1.1.15]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.14...1.1.15
[1.1.14]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.13...1.1.14
[1.1.13]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.12...1.1.13
[1.1.12]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.11...1.1.12
[1.1.11]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.10...1.1.11
[1.1.10]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.9...1.1.10
[1.1.9]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.8...1.1.9
[1.1.8]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.7...1.1.8
[1.1.7]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.6...1.1.7
[1.1.6]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.5...1.1.6
[1.1.5]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.4...1.1.5
[1.1.4]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.3...1.1.4
[1.1.3]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.2...1.1.3
[1.1.2]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.1...1.1.2
[1.1.1]: https://github.com/doombubbles/PathsPlusPlus/compare/1.1.0...1.1.1
[1.1.0]: https://github.com/doombubbles/PathsPlusPlus/compare/1.0.2...1.1.0
[1.0.2]: https://github.com/doombubbles/PathsPlusPlus/compare/1.0.1...1.0.2
[1.0.1]: https://github.com/doombubbles/PathsPlusPlus/compare/1.0.0...1.0.1
[1.0.0]: https://github.com/doombubbles/PathsPlusPlus/compare/52dcad9d0380606db119c3c7a32d14e52c63dfb9...1.0.0
