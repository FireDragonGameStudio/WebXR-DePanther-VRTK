# WebXR-DePanther-VRTK
A small prototype to show De-Panther WebXR Exporter for Unity (https://github.com/De-Panther/unity-webxr-export) in combination with VRTK (https://www.vrtk.io/). You can try this here -> https://firedragongamestudio.github.io/WebXR-DePanther-VRTK/

<p align="center">
<img title="Overview" alt="Overview" src="https://user-images.githubusercontent.com/23502690/222677873-15660cf0-a386-42bd-a265-6e51915a559c.jpg" height="400">
</p>

## Quickstart (the preferred way)
This project provides a sample and a template for getting started with a blank scene, where the WebXR export, as well as the input mapping and VRTK integration are already set up. When creating WebXR experiences, check the VRTK tutorials found here -> https://www.youtube.com/@VirtualRealityToolkit/videos No need to use any VRTK Input packages!!!! The usage of the input mapping is heavily inspired by VRTK Input packages and should provide all necessary actions. Furthermore a hand tracking and gesture recognition is ready to use too and you can switch between hands and controllers. Pls note that not every Tilia package was tested explicitly, so you may encounter problems, but in general everything should work.

![image](https://user-images.githubusercontent.com/23502690/222663666-3065ce1c-31a5-4a46-b879-ed1658bfe955.png)
![image](https://user-images.githubusercontent.com/23502690/222663887-1afa8365-5bd3-482d-9a7b-fcd88eae8cba.png)

## Getting started from scratch (starting from zero)
FusedVR has a very good introduction on how to get started (https://www.youtube.com/watch?v=RKpa2tDvNiQ), but it's a little bit outdated. So in case you want to start from scratch, check out my updated and simplified tutorial here -> (coming soon) I added some information for easier testing and setup as well, so make sure to check it out. :)

## The SampleScene
The SampleScene (as the name states) is a showcase of using VRTK interactions with controllers and hand tracking. The WebXR cube on the table is grabable by controllers using the trigger and by hand tracking via index-finger pinch. The door in the back can be opened as well by grabbing it. No physics interactions with hands/controllers at the moment, but I'll try to add them later. Make sure the Interaction (small white cube in front of controllers or alongside the hand tracking wrist) touches the object you wanna interact with. Otherwise VRTK doesn't recognize the grab.

<p align="center">
<img title="Grab the cube" alt="Grab the cube" src="https://user-images.githubusercontent.com/23502690/222679125-83f8a60e-ef5f-4044-a763-9a6d2490319a.jpg" height="400">
<img title="Open the door" alt="Open the door" src="https://user-images.githubusercontent.com/23502690/222679201-d2525faa-3334-4e69-9bb4-57b4b04cd593.jpg" height="400">
</p>

Teleporting is implemented via controller and hand input. When using controller the teleport curved line pointer is shown, when the thumbstick is touched. Press the thumbstick (click) to execute the teleport. When using hand tracking it gets a little trickier. Use (and hold) Middle Finger Pinch on your left hand to show the curved line pointer. Use (and release) Middle Finger Pinch on your right hand to execute the teleport. This interaction was inspired by Chamber from Valorant. As there is no standard for hand-tracking teleport yet, feel free to implement you own solutions :) 

<p align="center">
<img title="Teleporting" alt="Teleporting" src="https://user-images.githubusercontent.com/23502690/222677206-234da07c-76b7-4531-84f0-6b22203a8c83.png">
</p>

SnapTurn and Warp via controller is implemented to use the right thumbstick. Pressing forward/backword to blink and left/right to actually snap turn. Via hand tracking use the Pinky Finger Pinch to snap turn into the desired direction.

<p align="center">
<img title="Snap turn" alt="Snap turn" src="https://user-images.githubusercontent.com/23502690/222676108-9a2d5888-a054-4cff-8f38-0099c53076b8.png">
</p>

The cubes and spheres show states of tracked interactions with hand tracking (for left and right), following this color code:

-  Cube
	- Index Finger Pinch -> Green
	- Middle Finger Pinch -> Yellow
	- Ring Finger Pinch -> Orange
	- Pinky Finger Pinch -> Blue

<p float="left">
<img title="Index Finger Pinch" alt="Index" src="https://user-images.githubusercontent.com/23502690/222676323-9f984bd2-bf57-4479-a3ce-bcdd08f24942.png" height="200">
<img title="Middle Finger Pinch" alt="Middle" src="https://user-images.githubusercontent.com/23502690/222676273-f7d91173-8034-4805-926d-dd493a27e563.png" height="200">
<img title="Ring Finger Pinch" alt="Ring" src="https://user-images.githubusercontent.com/23502690/222676194-fd1cafec-4000-4573-af39-f0c2248c56c2.png" height="200">
<img title="Pinky Finger Pinch" alt="Pinky" src="https://user-images.githubusercontent.com/23502690/222676108-9a2d5888-a054-4cff-8f38-0099c53076b8.png" height="200">
</p>

- Sphere
	- ThumbsUp Gesture -> Green
	- Shaka Gesture -> Yellow
	- Fist Gesture -> Orange
	- Rock Gesture -> Blue
	- One Gesture -> Violet
	- Two Gesture -> Cyan
	- Three Gesture -> Black
	- Four Gesture -> Pink
	
<p float="left">
<img title="ThumbsUp" alt="ThumbsUp" src="https://user-images.githubusercontent.com/23502690/205271494-824f1408-b1d7-4259-8d44-39cbcb0ce7fc.png" height="200">
<img title="Shaka" alt="Shaka" src="https://user-images.githubusercontent.com/23502690/205271573-c2e8f4f5-0acb-495d-ae65-37c76bd33988.png" height="200">
<img title="Fist" alt="Fist" src="https://user-images.githubusercontent.com/23502690/205272287-a17e7b37-0e04-4386-bd5c-dc2f3b6c440f.png" height="200">
<img title="Rock" alt="Rock" src="https://user-images.githubusercontent.com/23502690/205271635-81e5d7a9-d33b-4065-bf26-45a6a76095b8.png" height="200">
<img title="One" alt="One" src="https://user-images.githubusercontent.com/23502690/205272431-d7859764-488c-4ef6-b917-fc38c29ff82e.png" height="200">
<img title="Two" alt="Two" src="https://user-images.githubusercontent.com/23502690/205272615-d0381e15-12ee-4a94-b766-cfde825546fa.png" height="200">
<img title="Three" alt="Three" src="https://user-images.githubusercontent.com/23502690/205272675-94d7aa3b-4ca4-4e88-95de-2bd2b7f608d4.png" height="200">
<img title="Four" alt="Four" src="https://user-images.githubusercontent.com/23502690/205272749-1e34e780-fa5e-4244-bc8a-3b4d7730ea0d.png" height="200">
</p>

## The VRBowling scene
This sample is based on the VRTK tutorial located here - https://academy.vrtk.io/Documentation/Tutorials/ and modified in a way to make it usable with WebXR. The video tutorial for setting everything up is here - https://www.youtube.com/watch?v=bzz6ymwUI7A An empty scene is shipped for starters.

## The TemplateScene
This scene acts as boilerplate template, where the WebXR export, as well as the input mapping (controller + hands) and VRTK integration are already set up. Everything else, from teleporting to interactions must be implemented from scratch. Check out the VRTK Youtube channel (https://www.youtube.com/@VirtualRealityToolkit) and resources (https://www.vrtk.io/) for tutorials and inspiration.

## The details
Especially the hand tracking interactions results may vary. I implemented everything to work as reliable as possible, by granting thresholds that should work with neary every use-case. You can easily change those thresholds and limits by altering the numbers on the relevant actions in Unity.

### What does that mean?
All interactions regarding hand-tracking calculate distances between the tracked fingertips. The scripts working like this are GestureAction.cs and PinchAchtion.cs. E.g. if the distance between the thumb tip and index finger tip is less than 2cm, it's very likely that the hand executed a pinch. There is room for improvement, but it works pretty good most of the time and is generally not affecting performance.

![image](https://user-images.githubusercontent.com/23502690/222664290-fe43a7c2-48b1-4ea2-9da4-9cd1a0f737b4.png)
![image](https://user-images.githubusercontent.com/23502690/222664171-05ef2e2f-c06a-41c1-9568-5ba6b11642af.png)

It's a little more complicated in case of gesture recognition. When using gestures, the distances of all fingertips to the wrist is calculated and compared to set distances. This WILL vary, due to tracked hand sizes, but can be tweaked via the general distance and threshold settings. Feel free to play around with these settings and implement your own gestures! :)

## Informal
This is just a sample implementation and will very likely NOT be maintained actively. Tested on an Oculus Quest 2. When working with hand tracking, make sure to have sufficient lighting, because of the camera based hand recognition.
