# Unity 2D Fetch Mechanic Prototype

A technical prototype developed in Unity to demonstrate 2D physics interactions, state-based logic, and input handling. The project focuses on a "Delivery System" mechanic where the player navigates a vehicle to collect and transport items using a boolean state machine logic.

## 🎮 Key Features & Technical Details

### 1. State-Based Interaction Logic
Instead of simple collisions, the gameplay relies on a logic flow managed by the `Collector` script (formerly Treat.cs).
* **Boolean State Machine:** The player uses a `FullMouth` boolean flag to switch between "Collecting" and "Delivering" states.
* **Logic Safety:** Ensures the player cannot collect multiple items simultaneously or deliver without holding an item.

### 2. Physics & Movement (Driver.cs)
* **Input System Integration:** Utilized Unity's `UnityEngine.InputSystem` namespace for handling real-time keyboard inputs (`Keyboard.current`).
* **Vector Mathematics:** Movement is calculated using `transform.Translate` and `transform.Rotate` combined with `Time.deltaTime` to ensure frame-rate independent gameplay.
* **Dynamic Speed Handling:** Implemented a boost mechanic that alters the vehicle's velocity state upon triggering specific zones (`OnTriggerEnter2D` vs `OnCollisionEnter2D`).

### 3. Feedback Systems
* **Visual Feedback:** Integrated Particle Systems that trigger programmatically upon successful collection and delivery events.
* **UI Updates:** Real-time UI text updates using `TMPro` (TextMeshPro) to indicate boost status.

## 🕹️ Controls

* **Up / Down Arrows:** Move Forward / Backward
* **Left / Right Arrows:** Steer Vehicle
* **Objective:** Find the **"Treat"** object to collect it, then navigate to the **"Guardian"** to deliver it.

## 🛠️ Installation & How to Run

1.  Clone this repository:
    ```bash
    git clone [https://github.com/delioglu22/Unity-2D-Fetch-Mechanic-Prototype.git](https://github.com/YourUsername/Unity-2D-Fetch-Mechanic-Prototype.git)
    ```
2.  Open **Unity Hub**.
3.  Click **Add** and select the cloned folder.
4.  Open the project (Recommended Version: Unity 2022.3 LTS or later).
5.  Open the `SampleScene` and press **Play**.

---
*This project was developed as a technical study for game development internships.*
