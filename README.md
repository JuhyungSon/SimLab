# Project 

# SimLab Open Sources code 
Welcome to Simlab, where we offer chemical engineering courses to provide practical learning experiences in a virtual environment.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. 
To run, download Chemical metaverse Hkust.exe to your computer and connect your Oculus device.

### Prerequisites

1. Windows 
2. Unity Version: 2021.2.7f1
3. Oculus Quest2/3

### Installing

A step by step series of examples that tell you how to get a development env running
-----------------------------------------------------------------------------------------

Simlab example version 

1.Download the unity (Unity Version: 2021.2.7f1). 

2.Download Chemical metaverse Hkust.exe to your computer and insert your Oculus device.

-------------------------------------------------------------------------------------------

Make own Simlab

1.Create the Lobby Scene, Control Room Scene, Chemical Plant (Enginereing) Scene.

2.Open the game engine and paste the codes into the appropriate game scene.

3.Build your own engineering course in the scene.

4.Applied our code to the 3D object in Unity. 


## Running the tests

1.Download the unity (Unity Version: 2021.2.7f1). 

2.Download Chemical metaverse Hkust.exe to your computer and insert your Oculus device.

# WorkFlow and Code Explanation 

- [Lobby Scene] 

- Button VR : Button VR is the function that activates the UI in the Lobby, Chemical Plant.
    
- Fade screen: The fade screen code ensures that when the user moves from the lobby scene to the control room, the user's camera fades for three seconds. The user can have a more immersive impression.

- Move Scene: The move scene code is in charge of transporting the character from one scene to another.

- Network Manager: Netwrok manager code is responsible for controlling the scene within the photon network. If the user enters the simlab, the scene may be produced using the photon network.

- Network Player: The job of the network player in code is to create the user utilizing the photon network. The user can communicate with other users using this code.

- NetworkPlayerSpawen: Network player spawn code is responsible for allowing the user to spawn in the scene.

- ProgressBar: It represent that the progress of the video lecture.

- Rotate: This code controls the rotation of the DC(Distillation Column) in the center of the desk in the lobby scenario. The user may view the DC(Distillation Column) from the lobby.  

- SceneTransitionManager: This code assists the user in moving from scene to scene.

- VideoPlayBack: This code is responsible for managing the video lecture from the lobby scene.

- [Control Room] 

- OperationModeButton: If the user wants to begin interacting with the operation protocol screen, this code will initiate the DC(Distillation Column) protocols.

- [Chemical Plant] 


- HandleCheck, HandleChecker1,Handelcheckr2: If the user interacts with the valve, It can be tracked  how much the user tries to open the valve. 

- TimeChecker: This code provided some data for the accomplishment of user tasks.


## Contributing

Please read for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use (Unity Version: 2021.2.7f1) for versioning. For the versions available, see the Unity offcial website.

## Authors

* **Juhyung Son**
* **Juhyung Son**
* **Juhyung Son**
* **Juhyung Son**
* **Juhyung Son**
  

See also the list who are participated in this project.

## GamePlay Video
https://youtu.be/43hNDIgy3SA   

## License

This project is licensed under the HKUST(Guangzhou) License 




  
