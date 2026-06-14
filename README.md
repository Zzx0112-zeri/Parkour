# Parkour
A Mario‑style parkour game developed with Unity Engine.

## Project Overview
This is a 2D pixel‑style parkour game prototype inspired by classic Mario‑like platformer gameplay.
The project has set up basic Unity project structure, including assets, scenes, prefabs and script folders, ready for further gameplay implementation and content creation.

## Tech Stack
- Game Engine: Unity
- Programming Language: C#
- Art Style: Retro Pixel Art

## Repository Structure
Parkour/
├── .gitignore # Git ignore config for Unity temp/cache files
├── .vsconfig # Visual Studio environment configuration
├── UpgradeLog.htm # Unity version upgrade log
├── Assets/ # Core game resources
│ ├── Animation/ # Character & scene animation assets
│ ├── Casual Game Sounds U6/ # Game sound effects (jump, hit, BGM etc.)
│ ├── Pixel Adventure 1/ # Pixel‑style asset pack & retro font
│ ├── Scenes/ # Game levels and main menu scenes
│ ├── prefab/ # Reusable game object prefabs
│ └── scripts/ # C# game logic scripts
├── Packages/ # Unity Package Manager dependencies
└── ProjectSettings/ # Global Unity project settings
## Core Assets Introduction
1. **Animation/**
Stores animation clips and related meta files for character movements and scene animations.

2. **Casual Game Sounds U6/**
Contains multiple `.mp3` audio files for in‑game sound effects and background music.

3. **Pixel Adventure 1/**
Retro pixel‑themed asset package, including `PressStart2P‑Regular.ttf` pixel font to match classic platformer visual style.

4. **Scenes/**
Directory for game level scenes, main menu and other playable scenes.

5. **prefab/**
Reusable prefabs such as player character, collectibles, obstacles and environmental objects.

6. **scripts/**
C# source code for game logic: player movement, collision detection, level rules and other core mechanics.

## Planned Gameplay Features
- Side‑scrolling platform parkour & jumping mechanics
- Obstacle avoidance and level progression
- Item collection system
- Pixel‑style retro visual experience

## Development Status
This project is in the early prototype stage:
- Basic Unity project structure and asset folders are established
- Core gameplay logic, complete level content and playable character prefabs are pending implementation

## How to Open the Project
1. Clone this repository
```bash
git clone https://github.com/Zzx0112-zeri/Parkour.git
2.Open the root Parkour folder via a compatible Unity Editor version
3.Wait for Unity to import assets and compile C# scripts
4.Open target scenes in the Assets/Scenes directory to test gameplay prototypes