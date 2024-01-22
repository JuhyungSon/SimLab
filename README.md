# SimLab

SimLab can be used both autonomously or with other students and instructors. In single-user
mode, the students interact with the virtual environment (e.g., presentation in Lobby, valves in
the chemical plant, and interactable buttons in the control room) on their own. Such single-user
interaction allows students to practice operating the distillation column in the chemical plant
at their own pace. This mode can be used as a preparation for actual practice in presence of an
instructor or to review practice material.
To operate the distillation column, the student must follow six consecutive steps over three
scenes (Lobby, Chemical Plant, and Control Room). 

(1) Lobby Scene. The student spawns in the Lobby scene. In single-user mode, SimLab provides
the student with fundamental information about the distillation unit in this scene.
The student presses a button on the table in the lobby to display a scrollable slide containing
relevant information. The student can scroll up and down through hand gestures on the Oculus
controller. Besides static slides, the students also have the option to watch a pre-recorded lecture.
Once familiar with the material, the student can enter to the chemical plant scene to perform
the necessary operation protocols.

(2) Chemical Plant Scene (Preparatory Tour). After reviewing the information presented in the
lobby, the student can teleport to chemical plant scene. The student is immersed
in the interactive virtual chemical plant to acquire realistic knowledge of chemical plant units,
specifically the feed tank, preheater, distillation column, reboiler, condenser, reflux drum, process
pipes, cooling water pipes, and steam pipes. Compared to the Lobby scene, this scene focuses
on the actual operation of the chemical plant. By pressing a button in this scene, details of
fundamental units pop up to explain their functions and usage. Once the student is familiar, the
portal then guides the student to the control room.

(3) Control Room Scene (Guide). In the control room, the student can learn the production
objectives, the overall process flow diagram, and the operational procedures of the plant. This
room resembles that in industrial plants which comprises workstations running specialized
computer programs, and digital/analog buttons to manage the chemical processes. To simplify
the user interaction, I create three screens with interactable – pressable buttons for isolating
and controlling valves and pumps on the displayed screen. The DC operation undergoes three
consecutive states: non-active (initial), pre-startup, and operation. The student must teleport
back to the Chemical Plant in order to change the DC state from non-active to the pre-startup
state.

(4) Chemical Plant Scene (Pre-startup). The users ought to conduct on-site checks and follow
guidelines to prepare for operating the plant units. The Chemical Plant scene provides the
student with a list of protocols for inspection (e.g., turning valves or checking the pump system The goal of such activities corresponds to the real-life scenario where the engineer must conduct
safety checks to ensure safe operation. Afterward, the student receives three related questions
to assess his/her understanding. Once answered, the distillation column becomes operable
(Pre-startup state) and the door to the control room is opened.

(5) Control Room Scene (Operation). Given that the objective of the operation is to concentrate
alcohol from 30% feed to 70% distillate and observe the liquid flows in the distillation column.
For this purpose, I create three virtual widescreens in the Control Room scene which become
interactable to the student. Screen 1 presents the distillation objective, screen 2
represents changes in the graphical representation during the transition between the DC states,
while screen 3 provides him/her with step-by-step distillation instructions. The student must
follow these instructions sequentially. Once completed, the state of DC changes to the operation
state automatically.

(6) Chemical Plant Scene (Distillation Animation). At this stage, the student has accomplished
all the operation tasks. We design a see-through feature that allows the student to observe the
mixture distillation as it occurs. As a result of the distillation objective in the previous stage, the
student can see an animation of the fluid and the vapor flow in the distillation column. This
animation is intended to engage the students and provide an immersive learning experience. I
create the animation using the fluid simulator in Blender. I adjust the settings so that the fluid
flows inside the distillation column and through each tray like water. The fluid animation is
then exported to an Alembic file and imported into Unity. The color, texture, and transparency of the fluid flowing are then adjusted to simulate real water. Finally, a vapor effect is added using
Unity to make the animation look more realistic.




## WorkFlow and Code Explanation 

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
