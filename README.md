# Active Constraints in robot-assisted minimally invasive surgery
Implementation of a virtual fixture with motor redirection for robot assisted minimally invasive surgery, as described in *A Dynamic Non-Energy-Storing Guidance Constraint with Motion
Redirection for Robot-Assisted Surgery* (2020) from Nima Enayati, Eva C. Alves Costa, Giancarlo Ferrigno and Elena De Momi.

The project is deployable on a DaVinci Research Kit.
***
*Active contributors: **Alberto Rota**, Nicolò Pasini, Matteo Pecorella, Ke Fan*
***

## Implementation 
The position and velocity of the End-Effector are tracked with respect to the path to be followed. The force is computed at each timestamp as a combination of such vectors. The MTM manipulator applies a resistance proportional to the magnitude of such force, contraining the movement of the PSM as close as possible to the trajectory.
A simulation environment is provided by the means of a UnityGame, where the virtual PSMs recieve commands by subscribing to a ROS topic published by the MTM himself.

![force vectors]()

In blue, the displacement vector from the path to the EE. In green, the EE velocity. In red, the restoring force, which clearly pulls towards the path.


 ### Dependencies: 
 * ![ROS#](https://github.com/siemens/ros-sharp)
 * ![Unity version ]()
 
