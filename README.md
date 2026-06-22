# 🚀 Rocket Booster

A 3D physics-based rocket navigation game built in **Unity**, where you launch a rocket from a launch pad, dodge obstacles, and try to land safely to progress to the next level.

---

## 📖 Game Description

You control a rocket that starts on a **launch pad**. Using simple controls, you throttle the rocket upward and steer it left or right to avoid obstacles in its path.

- Press **Space Bar** to fire the throttle and propel the rocket forward.
- Press **A** / **D** to rotate and steer the rocket's direction.
- **Dodge obstacles** along the way — colliding with one causes the rocket to **explode**.
- Successfully guide the rocket to the **landing pad** to complete the level and progress to the next one.

Simple controls, physics-driven movement, and increasingly tricky obstacle layouts make for a fun "easy to learn, hard to master" arcade experience.

---

## 🎮 Controls

| Action            | Key            |
|-------------------|----------------|
| Throttle / Thrust | `Space Bar`    |
| Rotate Left       | `A`            |
| Rotate Right      | `D`            |

---

## 🛠️ Built With

- **Unity (3D)** — Game Engine
- **C#** — Scripting
- **Unity's New Input System**
- **Unity Physics (Rigidbody)** — Force & Torque-based movement
- **Cinemachine** — Dynamic camera tracking

---

## 📚 What I Learned

This project was built as a hands-on way to strengthen my Unity fundamentals. Key concepts practiced include:

- **Namespaces & Classes** — Organizing code into clean, reusable structures.
- **New Input System** — Handling keyboard input (throttle and steering) in a modern, flexible way.
- **Physics & Rigidbody Forces** — Using `AddForce` and `AddTorque` to drive realistic rocket movement and rotation.
- **Cinematic Camera (Cinemachine)** — Setting up dynamic camera follow and framing for the rocket.
- **Audio System** — Adding sound effects for thrust, collisions, and landing.
- **Particle System** — Creating thrust flames, explosion effects, and landing effects.
- **Scene Transitions** — Loading the next level / restarting the current one on success or failure.
- **Prefabs** — Reusable obstacle, rocket, and effect prefabs for fast level building.

---

## 🚀 How to Run

1. Clone or download this repository.
2. Open the project folder in **Unity Hub**.
3. Open the main gameplay scene from the Project window.
4. Press the **Play** button to start the game.
5. Use `Space Bar` to thrust and `A` / `D` to steer the rocket toward the landing pad.

---

## 🎯 Objective

- Avoid all obstacles on the path.
- Land safely on the landing pad to advance.
- Colliding with an obstacle destroys the rocket and ends the attempt.

---

## 📌 Status

🚧 This is a **learning project**, primarily built to practice Unity physics, input handling, camera work, audio/particle effects, and scene management. Future improvements may include multiple levels, a scoring system, and polished UI/menus.
