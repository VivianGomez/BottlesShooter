# BottlesShooter-
This is a demo to interact with Oculus Go and Unity technologies, throughout the immersion in a farm in which you can shoot to bottles.

### Description

For this first approach and interaction with technologies and devices of Mixed Reality, I decided to use the Oculus Go (VR), to make a small demo in the Unity development environment and using the C # programming language.

This demo consists of shooting and throwing bottles that are distributed on a farm, in a random manner and with different organization patterns.

The controller of the Oculus Go is used to handle the weapon and in it, the PrimaryIndexTrigger, or front trigger, to be able to shoot the bullets with which they want to throw the bottles. On the other hand, with the VR glasses the environment of the farm is shown to the user, trying to achieve a better immersion both with the different graphic elements (houses, grass, birds, bottles, guns, buckets, etc.), as well as with sounds of ambience and interaction (shooting, bottle breaking)

## How to run


### Prerequisites

- [Git Bash](https://git-scm.com/downloads)
- [Unity](https://unity3d.com/es) (this project was developed using Unity.2018.3.3f1)
- [Android](https://developer.android.com/studio)

### Instructions

1. Install Unity, you can pay or use the Personal version (https://store.unity.com/download?ref=personal)
2. Install the Android SDK, or  the Android IDE (which includes the SDK). In this URL you can do it https://developer.android.com/studio
3. Using the Android IDE we need install the tools, like ndk, adb, etc. For this, you need follow this pictues that explain the configuration and instalation:

![Android Configurations](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/0.PNG)
![Settings1](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/sett1.PNG)
![Settings2](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/sett2.PNG)
![EVWindow](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/finallsett.PNG)

_

Too see the routes of SDK, JDK and JRE

![Project structure](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/1.PNG)
_

![Routes](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/2.PNG)


### Create the Environment variables:
5. Found "Environment variables" with Windows search.
6. This will open the following window, in which you must to click in "Environment variables".

![EVWindow](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/search.PNG)

7. Create the variables like is showed in the next picture (the route can change with your system username,in my case is Vivian, but please verify this)

![Variables](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/variables.PNG)

8. Open Unity > Edit > Preferences > External tools, and insert the same route of the Environment variables:

![Routes](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/5.PNG)

9. Open your git bash console in the directory of your Unity Projects (see the route in the IDE)

![GitBash](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/gibash.PNG)

10. Clone the project using your Git bash console, in this way:
```
git clone  https://github.com/VivianGomez/BottlesShooter-
```
11. Whith the project BoottlesShooter downloaded, please click on File > Open Project, and open the folder of the project

### To run  the project using your Oculus Go device.
12. Conect the Oculus Go to your PC using the USB cable
13. Click on File > Build and Run, and verify that you have the following configuration

https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/buildandRun.PNG

**Note:** If you do not have able the Android Plattaform, you must dowload it from Unity page or the assistant of Unity show to you a download button in the same window of Build and Run.

8. When you have the same configuration of the picture, you can click on Build and run, and wait that the app be executed on your conected device.



