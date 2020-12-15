# VRFinalProject
Implements the Gravity Gun from Half Life 2 in VR


### Introduction: Gravity Gun
One of the most groundbreaking VR games of the last year is Half Life: Alyx, a prequel to the original Half Life games. The Half Life series has always incorporated in game physics that allowed a variety of ways to approach each problem in game. In Half Life 2, a new tool was introduced, known as the Zero Point Energy Field Manipulator or more simply, the gravity gun.
https://www.youtube.com/watch?v=i5MDm-IPHHo <br/>
The gravity gun allowed you to pull objects towards it, gradually being pulled faster until they are locked into the front of the gun, and can be launched.
In Half Life: Alyx, they went with a different approach for manipulating objects. The gravity gloves allowed the users to flick their wrist to pull an object towards them, and then they could throw the object. Many people enjoyed the new system, but still missed the unique style of the gravity gun.
In this project, my goal is to implement the gravity gun in VR, while keeping the stylistic way it pulls objects based on their distance and launches them.
Design Description
Once the model is imported, I’ll have to create a scene with many different objects, each having a different weight and size, so that they have unique interactions with the gun when pulled in and launched. My goal is to have a few objects that interact differently when launched, such as a barrel that explodes when it impacts after being launched, and a few objects that will stick into surfaces in the scene when they collide with a surface. <br/>
After the objects are created, I’ll have to find a way to pull objects, such that they drag towards the gravity gun realistically when pulled in (tip over if height is higher than width, roll if they’re spherical or cylindrical and oriented horizontally, etc.), and are able to be launched semi-realistically such that they have their intended reaction with the scene, and can move other objects on impact.
### Devices and Assumptions
#### Hardware Requirements:
1)	Oculus Rift S – For viewing the in game scene and interacting <br/>
2)	Oculus Touch controllers – to control aim the gravity gun <br/>
#### Software Requirements:
1)	Unity 2019 LTS – used to develop entire game <br/>
2)	Blender – for editing the 3D model of the gravity gun <br/>
### Development Platform.
I will be implementing this using Unity 2019 LTS, an Nvidia GeForce GTX 1660-Ti GPU, Intel i7 processor, and 16GB of RAM. The test and work space is a 3x3 area, with development considering a small movement space (so the user can use Twinstick walking). The user will be able to wear the HMD to look around the scene, and use the Oculus Controllers to aim the gravity gun, at the object they intend to pick up, and wear they want to launch it.

### To Run the game
- Plug in an Oculus (wired connection) headset and turn on the right controller
- Open the build folder, and double click the file named "Maguire_Final_Project_VR.exe"

### User Interface and Controls
#### UI
The user will be able to see in game stats relating to the number of objects picked up, launched, destroyed, and stuck to a surface.
#### Controls
Object will be pulled in using the trigger on the right Oculus touch controller. <br/>
Object will be launched with hand button on right Oculus Controller. <br/>
Right stick allows user to move around the scene relative to the direction they’re looking. <br/>
B button allows user to show/hide the UI <br/>
A button allows user to jump <br/>
Right controller will be used to aim the gravity gun. Gravity gun will be attached to right controller. <br/>
### Workload Distribution
I’ve implemented entire project on my own.

### Assessment
The main strength of this project is that it is a highly desired mod for Half Life: Alyx. Many people (including myself) would love to have the ability to use the gravity gun in game but would require a significant amount of work to implement, such that it accurately reflects the implementation from Half Life 2, and it can be used on objects in while playing Half Life: Alyx. My goal is to achieve the first part of this, which is accurately recreating the gravity gun from Half Life 2 in the VR space. <br/>
The VR scene for this project should reflect the essence of the Half Life games. The room the user will be in will look similar to a warehouse, where the user has a large variety of objects to use the gravity gun with. <br/>
To evaluate success, the gravity gun will need to accurately recreate the gravity gun from Half Life 2. That is, the gun will need to pull objects and launch them in a similar way to the original gravity gun. Several different interactions must happen when objects are pulled and launched from the gravity gun, such as: slower drag when pulling in objects that would appear heavy, explosions when launching a red barrel, and blade or pointed objects sticking to surfaces when launched into the surface. <br/>
If the VR gravity gun has a similar feel to the gravity gun from Half Life 2, and interacts with objects in a similar way, then this project meets the criteria for success.
