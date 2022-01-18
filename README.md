# Active Constraints in Robot-assisted minimally invasive Surgery 
Implementation of a virtual fixture with motor redirection for robot assisted minimally invasive surgery, as described in *A Dynamic Non-Energy-Storing Guidance Constraint with Motion
Redirection for Robot-Assisted Surgery* (2020) from Nima Enayati, Eva C. Alves Costa, Giancarlo Ferrigno and Elena De Momi.

The project is deployable on a DaVinci Research Kit.
***
*Active contributors: **Alberto Rota**, Nicolò Pasini, Matteo Pecorella, Ke Fan*
***
A simulation environment is set up in Unity with a virtual model of 2 PSMs and 1 ECM. The virtual robot is controlled from a physical master Manipulator which sends the joint states in a ROS enivronment. The Unity virtual environment is captured by two virtual camera in the 3D scene, individually linked to the 2 oculars on the master manipulator. The operator therefore sees the Unity scene in 3D from the oculars while teleoperating the surgical robot.

The virtual fixture imposes a restoring viscous force on the manipulator: the magnitude and direction of such force depend on the end-effector velocity and distance to a predisposed path.

![dvrk](https://github.com/alberto-rota/Active-Constraints-in-robot-assisted-minimally-invasive-surgery/blob/main/Images/img1.png)

## Implementation 
The position and velocity of the End-Effector are tracked with respect to the path to be followed. The force is computed at each timestamp as a combination of such vectors. The MTM manipulator applies a resistance proportional to the magnitude of such force, contraining the movement of the PSM as close as possible to the trajectory. The restoring force is computed with the objective of brining the end-effector as close to the path as possible in the least amount of time, and therefore depends on the velocity vector at a given timestamp.

![vectors](https://github.com/alberto-rota/Active-Constraints-in-robot-assisted-minimally-invasive-surgery/blob/main/Images/img3.png)

In blue, the displacement vector from the path to the EE. In green, the EE velocity. In red, the restoring force.

## Force Feedback
The restoring force vector is sent back to the MTM, which applies the resistance force on the hand-held manipulator. The operator is therefore impeded in deviating from the path, but can still move away from the trajectory with enough force if necessary. The maximum force feedback is set to 5N.

 ### Dependencies: 
 * [ROS#](https://github.com/siemens/ros-sharp)
 * [DVRK control](https://github.com/jhu-dvrk/sawIntuitiveResearchKit/wiki/Full-da-Vinci) 
 * [Unity](https://unity3d.com/get-unity/download) version 2020.3.21f1
 
