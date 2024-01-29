# SimLab Open Sources code 
Simlab offers hands-on experience in manipulating virtual chemical plants. Simlab complements chemical engineering courses by providing practical and safe learning experiences in a virtual environment.

## Getting Started
These instructions will get you the project up and running on your local machine to recreate our work. 

### Prerequisites

1. Windows 
2. Unity Version: 2021.2.7f1
3. Oculus Quest2/3

### Installing

A step-by-step guide to getting a development environment running
-----------------------------------------------------------------------------------------

Simlab example version 

1. Download the Unity (Unity Version: 2021.2.7f1). 
2. Download SimLab.exe to your PC and plug in your Oculus device to your PC

-------------------------------------------------------------------------------------------

Replicate Simlab

1. Create the Lobby Scene, Control Room Scene, and Chemical Plant Scene.

2. Open the game engine and paste the codes into the appropriate game scene.

3. Build your engineering course in the scene.

4. Apply our code to the 3D object in Unity. 


## Running the tests

1. Download the Unity (Unity Version: 2021.2.7f1). 

2. Download SimLab.exe to your computer and insert your Oculus device.

# Explanation of Workflow and Code 

**[Lobby Scene]** 

- Button VR: activates the UI in the Lobby, Chemical Plant.
    
- Fade screen: The fade screen code ensures that the user's camera fades for three seconds when the user moves from the lobby scene to the control room. 

- Move Scene: for transporting the character from one scene to another.

- Network Manager: for controlling the scene within the photon network. 

- Network Player: to create the user utilizing the photon network. This allows users to communicate

- NetworkPlayerSpawen: Allow the user to spawn in the scene.

- ProgressBar: It represents the progress of the video lecture.

- Rotate: Controls the rotation of the DC(Distillation Column) in the center of the desk in the lobby scenario. The user may view the DC from the lobby.  

- SceneTransitionManager: This code assists the user in moving from scene to scene.

- VideoPlayBack: This code manages the video lecture from the lobby scene.

 **[Control Room]**

- OperationModeButton: initiate the DC(Distillation Column) protocols, so users can interact with the operation protocol screen.

  **[Chemical Plant]**


- HandleCheck, HandleChecker1, Handelcheckr2: If the user interacts with the valve, It tracks the user's attempts to open the valve. 

- TimeChecker: Tracks the completion of user tasks.


## Contributing

Please read for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use (Unity Version: 2021.2.7f1) for versioning. For the versions available, see the Unity official website.

## Gameplay Video
https://youtu.be/43hNDIgy3SA   

## License

This project is licensed under MIT. However, commercial use is not recommended. 




  
