# multiplayer-tutorial-unity

A multiplayer game in Unity using Photon, in which you need to shoot the other robots and kill them before they kill you!

### Controls:
WASD to move, mouse to look around, CTRL or left-click to shoot.

We added the following options in regards to the tasks:

* Shield for the player - [ShieldSpawner.cs](https://github.com/gamedev-srg/multiplayer_lesson/blob/master/Assets/ShieldSpawner.cs), [ShieldPlayer.cs](https://github.com/gamedev-srg/multiplayer_lesson/blob/master/Assets/scripts/ShieldPlayer.cs), [PlayerShield.cs](https://github.com/gamedev-srg/multiplayer_lesson/blob/master/Assets/scripts/Player/PlayerShield.cs) 
* Animations - We added the not-so-friendly robot Mike, which runs and shoots lasers from it's eyes!
* Score for hitting players with the laser - We added the following files [PlayerScore.cs](https://github.com/gamedev-srg/multiplayer_lesson/blob/master/Assets/scripts/Player/PlayerScore.cs)

In addition, we also modified the [PlayerManager.cs](https://github.com/gamedev-srg/multiplayer_lesson/blob/master/Assets/scripts/Player/PlayerManager.cs) file, in order to use the Score adder, and the Shield.
