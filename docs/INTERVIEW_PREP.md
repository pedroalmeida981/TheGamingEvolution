# Interview preparation and QA review

> These are source-review notes and **suggested** test scenarios. They do not represent executed test cases, successful builds or approved production requirements.

## Project in one sentence

Unity 2D/3D gameplay collection and Tetris-style mechanics.

## Technical interview questions and grounded answers

### 1. What does the Tetris implementation do?

TetrisBlock manages a 10×20 grid, input-based movement, rotation, gravity timing, boundary validation, occupancy checks and completed-line clearing.

### 2. Which Tetris edge cases matter?

Rotating near walls, filling the top rows, clearing multiple consecutive rows, grid indexing during RowDown and spawn overlap.

### 3. How are game modes organised?

Unity assets contain 2D platformer modules, a 3D environment and Tetris prefabs/scenes. Their coexistence does not prove fully working transitions.

### 4. Are all ability modules active?

No such claim can be made from filenames; scene component activation and runtime input bindings have to be checked.

### 5. How would you increase testability?

Move grid and line-clearing rules into a pure C# service, add unit tests for top/bottom rows, and keep scene transition tests separate.

## Suggested functional and accessibility test cases

| ID | Scenario | Expected / verification objective |
| --- | --- | --- |
| TET-01 | Move or rotate at grid edges | Piece never accesses invalid grid locations |
| TET-02 | Fill one full row | Row clears and higher cells move down correctly |
| TET-03 | Fill consecutive rows | Both rows clear without skipped updates |
| TET-04 | Spawn when top cells occupied | Defined game-over behaviour occurs; no exception |
| 2D-01 | Jump/dash near platform edge | Movement state and collisions remain valid |
| 3D-01 | Collect all objects | Count and end-scene flow remain consistent |
| SCENE-01 | Load each game mode from menu | Scene names and Build Settings match actual references |

## Limitations to disclose

Third-party or demonstration code may be included among the 2D movement modules. Do not assert individual ownership of all assets, or that every ability and game mode has been tested.

## How to discuss the project

Explain what the code currently contains, which components you actually developed, the difference between intent and implementation, one defect or risk you identified, and how you would validate a fix. Avoid claiming tests have passed unless you can provide reproducible evidence.

## Suggested next improvements

- Verify a clean checkout/build with a documented environment.
- Record reproducible bugs or missing features as GitHub Issues.
- Add evidence-backed screenshots and a short demo only after confirming they match the actual project.
- Add focused automated tests where the architecture makes them worthwhile; keep manual exploratory and accessibility testing visible.
