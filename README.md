# 🏃 Prototype 3 - Run and Jump

![Unity Version](https://img.shields.io/badge/Unity-6.0-blueviolet)
![C#](https://img.shields.io/badge/C%23-9.0-green)
![Status](https://img.shields.io/badge/Status-In%20Development-yellow)
![GitHub](https://img.shields.io/badge/GitHub-Repository-black)

---

## 📖 Overview

**Prototype 3** is an endless side-scrolling runner game developed as part of the **Unity "Create with Code"** course. This project demonstrates core game development concepts including:

- Player physics and jumping mechanics
- Procedural obstacle spawning
- Dynamic scrolling backgrounds
- Animation state machines (Idle, Run, Jump, Death)
- Particle effects and sound integration
- Script communication and game state management

## 🎮 Gameplay Features

| Feature | Description |
|---------|-------------|
| **Player Control** | Jump over obstacles with the **Spacebar** |
| **Procedural Generation** | Infinite obstacles spawned at timed intervals |
| **Game States** | Running, Jumping, Game Over |
| **Visual Feedback** | Particle effects (dirt splatter, explosion) |
| **Audio Feedback** | Background music, jump and crash sound effects |
| **Responsive Controls** | Smooth physics-based movement using `Rigidbody` |

## 🛠️ Technology Stack

| Category | Technology |
|----------|------------|
| **Game Engine** | Unity 6.0 |
| **Programming Language** | C# |
| **IDE** | Visual Studio / VS Code |
| **Version Control** | Git & GitHub |




## 🏗️ Architecture Overview

### Core Components Flow


#### graph TD
    A[PlayerController] --> B[Rigidbody]
    A --> C[Animator]
    A --> D[AudioSource]
    E[SpawnManager] --> F[Obstacle Prefabs]
    G[MoveLeft] --> H[Background]
    G --> I[Obstacles]
    J[RepeatBackground] --> K[Seamless Scrolling]
    L[DetectCollisions] --> M[Game Over Trigger]


#### Key Scripts
Script	Responsibility
    PlayerController	Handles input, jumping, physics, and game state (gameOver)
    MoveLeft	Moves obstacles and background at constant speed
    SpawnManager	Spawns obstacles at timed intervals using InvokeRepeating
    RepeatBackground	Creates infinite scrolling effect using BoxCollider width
    DetectCollisions	Manages collision responses (Ground vs Obstacle)


## 🚀 Getting Started

Prerequisites
Unity 6.0 or higher
Git (for version control)

## Installation
 Clone the repository

        git clone https://github.com/devmourao/cwc-prototype-3-run-and-jump.git

Open in Unity Hub
Select the project folder and open with Unity 6.0
    
## Quick Start
Open the Prototype 3 scene.

Press Play in the Unity Editor.

Press Spacebar to jump over obstacles.



## 📚 Learning Objectives
This project was built to demonstrate:

Physics-based movement with Rigidbody and AddForce.

Animation State Machines for player states (SetTrigger, SetBool).

Procedural content generation via SpawnManager.

Script communication between game objects.

Particle systems for visual feedback.

Audio integration for immersive gameplay.

Professional Git workflow and documentation.

## 🔄 Current Status
Feature	Status	Notes
Player Movement	✅ Complete	Running and jumping
Obstacle Spawning	✅ Complete	Timed intervals
Background Scrolling	✅ Complete	Seamless repeat
Player Animations	✅ Complete	Run, Jump, Death
Particle Effects	⏳ In Progress	Lesson 3.4 (Current)
Sound Effects	⏳ In Progress	Lesson 3.4 (Current)
Game Over Screen	✅ Complete	Debug log message
Background Music	⏳ In Progress	Lesson 3.4 (Current)

## 👨‍💻 Development Journey
This project is part of a structured learning path:

Unit 1: Player Control (Driving Simulator)

Unit 2: Basic Gameplay (Feed the Animals)

Unit 3: Sound and Effects (Current)

✅ 3.1 Jump Force

✅ 3.2 Make the World Whiz By

✅ 3.3 Don't Just Stand There

⏳ 3.4 Particles and Sound Effects (Current)

## 🤝 Contributing
This is a learning project, but contributions are welcome!

Fork the repository.

Create a feature branch (git checkout -b feature/amazing-feature).

Commit your changes (git commit -m 'feat: add amazing feature').

Push to the branch (git push origin feature/amazing-feature).

Open a Pull Request.



## 📄 License
This project is for educational purposes. Assets provided by Synty Studios for course use only. Not for commercial distribution.

## 🙏 Acknowledgments
Unity Technologies for the "Create with Code" course.

Synty Studios for the course assets.

Built with ❤️ as part of the Create with Code learning journey



