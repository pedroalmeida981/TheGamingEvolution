# The Gaming Evolution — Multi-mode Unity project

**Unity 2020.3.48f1 · C# · 2D / 3D / Tetris gameplay**

> **Status:** Historical academic game-development project. Multiple gameplay scenes and systems are present; a full working build has not been independently verified.

## Project concept

The Gaming Evolution explores several styles of gameplay within one Unity project. The repository includes a 2D platforming module, a 3D exploration/platforming module, a Tetris-style minigame, menu and end-game scenes.

This is better described as a **multi-mode learning project** than as a commercial game.

## Modules found in source

| Area | Evidence in repository |
| --- | --- |
| 2D platforming | `Assets/2DPlatforme/`, with movement, character controller and ability modules |
| 3D gameplay | `Assets/3D platform/`, with movement, collectible tracking, camera and scene scripts |
| Tetris-style minigame | `Assets/TetrisGame/`, including tetromino prefabs, spawning, rotations, collision checks and line deletion |
| Scene navigation | `Assets/Scenes/`, menu and end-game content |

The 2D module contains numerous ability script files; the presence of a script **does not guarantee the ability is enabled or configured in a playable scene**.

## Technologies

- **Unity editor:** 2020.3.48f1, as recorded in `ProjectSettings/ProjectVersion.txt`.
- **Programming:** C# and Unity MonoBehaviour lifecycle.
- **Mechanics:** input polling, collisions, grid logic, prefab spawning, scene loading and animation.
- **Assets:** Unity scenes, prefabs, scripts, graphics and models.

## Open the project

1. Clone this repository.
2. Import the folder using Unity Hub; prefer Unity 2020.3.48f1 initially.
3. Inspect `Assets/Scenes/` and Build Settings.
4. Run the 2D, 3D and Tetris scenes **separately** when assessing whether the modes work; do not assume all transitions are configured correctly.
5. Review external asset licences before repackaging or distributing the project.

## Engineering observations

The Tetris script `TetrisBlock.cs` implements a 10×20 occupancy grid, movement/rotation validity checks and line clearing. This is a good example of a subsystem that could be separated from Unity objects for unit testing.

Potential edge cases include boundary rotations, top-of-grid spawning, clearing consecutive lines, fast-drop behaviour and invalid array positions. In the scene-switching scripts, collision and scene-name assumptions should also be checked.

Because the repository mixes many modules and assets, ownership/origin and active versus unused content should be clarified before claiming specific functionality as original implementation.

## QA opportunities

- **Tetris:** boundary moves, repeated rotations, valid grid positions, line clearing and new-piece spawning.
- **2D platformer:** collision handling, jumps, ability changes, blocked movement and scene transition.
- **3D:** collectible triggers, player movement, win condition and scene flow.
- **Cross-scene:** menu navigation, input consistency, loading failures and frame-rate differences.

These are suggested checks, not recorded test results.

## Portfolio context

An academic-era Unity project suited to explaining gameplay mechanics, source-code exploration, integration risk and how to convert complicated game rules into repeatable test cases.