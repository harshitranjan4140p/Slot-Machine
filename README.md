# 🎰 Unity Slot Machine Game

## 📄 Overview

This project is a simple **slot machine game** built using Unity. It was developed as part of an internship assignment to demonstrate understanding of:

* Game logic and flow
* Random number generation (RNG)
* UI-based animation systems
* Clean code structure and organization

The game simulates a classic 3-reel slot machine where players spin the reels and win when all symbols match.

---

## 🎮 Features

### ✅ Core Functionality

* 3 spinning reels with smooth vertical scrolling
* Randomized outcomes using RNG
* Sequential reel stopping (left → middle → right)
* Win detection when all symbols match

---

### 🎞️ Animation & Game Feel

* Continuous looping reel system
* Smooth stopping behavior
* Delayed reel stopping for realistic slot-machine feel

---

### 💰 Winning & Payout System

* Win condition: All three symbols match
* Each symbol has a defined payout value:

| Symbol | Payout |
| ------ | ------ |
| Cherry | 10     |
| Bell   | 20     |
| BAR    | 30     |
| 7      | 50     |

* Result is displayed via UI / console output

---

### 🧠 Technical Highlights

* Object-Oriented Programming (OOP) structure
* Separation of concerns:

  * `GameManager` → controls flow
  * `ReelController` → handles reel behavior
  * RNG handled centrally (or via Unity Random)
* Clean and readable code with comments

---

## 🕹️ How to Play

1. Launch the game (WebGL build or Unity Editor)
2. Press the **Spin** button
3. Watch the reels spin and stop one by one
4. If all three symbols match → you win 🎉

---

## 🧪 How to Run (WebGL Build)

1. Navigate to the `/Build/WebGL/` folder
2. Open `index.html` in a browser
   *(or host using a local server if required)*

---

## 🛠️ Project Structure

```
Assets/
 ├── Scripts/
 │    ├── GameManager.cs
 │    ├── ReelController.cs
 │    ├── RNGManager.cs
 │
 ├── Prefabs/
 ├── Animations/
 ├── UI/
 ├── Sprites/
```

---

## 💡 Approach & Thought Process

The project was built incrementally with focus on core systems:

1. Implemented a looping reel system using UI elements
2. Ensured smooth and continuous animation
3. Introduced controlled stopping logic
4. Added sequential stopping for better game feel
5. Integrated RNG to determine outcomes
6. Implemented win detection and payout logic

Priority was given to:

* Simplicity
* Clean architecture
* Smooth user experience

---

## 🎯 Bonus Notes

* Additional buffer symbols were used in reels to prevent visual gaps during animation
* System is designed to be easily extendable (e.g., adding more symbols or features)

---

## ⚠️ Disclaimer

This project was created **solely for evaluation purposes** as part of an internship assignment.
It is not intended for commercial use or distribution.

---

## 🚀 Future Improvements (Optional)

* Add sound effects and particle effects
* Implement betting system and player balance
* Add more complex win conditions (e.g., paylines)
* Improve UI/UX polish

---

## 🙌 Final Note

This project focuses on demonstrating **game development fundamentals** rather than building a fully featured production system.

---
