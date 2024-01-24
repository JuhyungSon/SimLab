# SimLab Open Sources code 
Welcome to Simlab, we are providing chemical engineering course to teach the practical learing expereince in the virtual environment. 

# Install Simlab platform
To run, download Chemical metaverse Hkust.apk to your computer and insert your Oculus device.

# Install
1.Download and install the unity.

2.Create the Lobby Scene, Control Room Scene, Chemical Plant (Enginereing) Scene.

3.Open the game engine and install the codes in the correct game scene.

4.Design own engineering course in the scene. 

5.Adpated our code to the 3D object in the unity. 

# Get Started 
The code is a Unity Project that contains a bunch of codes example. Download the codes and adjust to your project.

# WorkFlow and Code Explanation 

- [Lobby Scene] 

- Button VR : Button VR is the function to turn on the UI in the Lobby,chemical plant. I used this code to use all scene. So, this code can be used from lobby scene and chemical plant as well when the user interact with this button.
    
- Fade screen: Fade screen code is the role of when the user move to another scence from lobby scene to control room, the user camera will be fade during 3 sec. The, user can feel more immersive effect. 

- Move Scene: Move scene code is the role of moving the character from scene to scene.

- Network Manager: Netwrok manager code is the role of managing the scene into the photon network. If the user enter to the simlab, the scene can be created from the photon netwrok. 

- Network Player: Network player of code is the role of creating the user using the photon network. The user can communcate with other user from this code. 

- NetworkPlayerSpawen: Network player spawen code is the role of supporing the user to spawn to the scene.

- ProgressBar: Progrees bar is the role of the checking the how much the user looking
at the video lecture in the lobby. It represent that the progress of the video lecture.

- Rotate: This code is the role of the rotating the DC in the center of the desk in the lobby scene. The user can watch the DC in the lobby.  

- SceneTransitionManager: This code is help the user to move to scene to scene.

- VideoPlayBack: This code is the role of managing the video lecture from the lobby scene. 

- [Control Room] 

- OperationModeButton: If the user want to start the interacting with the operation protocol screen, this code is to oprate the DC protocols. 

- [Chemical Plant] 

- Climber,Climbinteractable: The user can climb the DC from this code. 

- HandleCheck, HandleChecker1,Handelcheckr2: If the user interact with the valve, I could check when the user interact with the valve and how much the user tried to open the valve. 

- TimeChecker: When user start the open the valve and when finish the user interaction. I could get the data from this code for user task completion.

  
# GamePlay Video
https://youtu.be/43hNDIgy3SA                




  
