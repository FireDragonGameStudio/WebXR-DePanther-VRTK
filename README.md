# WebXR-DePanther-VRTK
A small prototype to show De-Panther WebXR Exporter for Unity (https://github.com/De-Panther/unity-webxr-export) in combination with VRTK (https://www.vrtk.io/).

## Quickstart (the preferred way)
This project provides a sample and a template for getting started with a blank scene, where the WebXR export, as well as the input mapping and VRTK integration are already set up. When creating WebXR experiences, check the VRTK tutorials found here -> https://www.youtube.com/@VirtualRealityToolkit/videos No need to use any VRTK Input packages!!!! The usage of the input mapping is heavily inspired by VRTK Input packages and should provide all necessary actions. Furthermore a hand tracking and gesture recognition is ready to use too. Pls note that not every Tilia package was tested explicitly, so you may encounter problems, but in general everything should work.

## Getting started from scratch (starting from zero)
FusedVR has a very good introduction on how to get started (https://www.youtube.com/watch?v=RKpa2tDvNiQ), but it's a little bit outdated. So in case you want to start from scratch, check out my updated and simplified tutorial here -> (coming soon) I added some information for easier testing and setup as well, so make sure to check it out. :)

## The SampleScene
The SampleScene (as the name states) is a showcase of using VRTK interactions with controllers and hand tracking. The WebXr cube on the table is grabable by controllers using the trigger and by hand tracking via index-finger pinch. The door in the back can be opened as well by grabbing it. No physics hands/controllers at the moment, but I'll try to add them later. Make sure the Interaction (small white cube in front of controllers or alongside the hand tracking wrist) touches the object you wanna interact with. Otherwise VRTK doesn't recognize the grab.

Teleporting is implemented via controller and hand input. When using controller the teleport curved line pointer is shown, when the thumbstick is touched. Press the thumbstick (click) to execute the teleport. When using hand tracking it gets a little trickier. Use (and hold) Middle Finger Pinch on your left hand to show the curved line pointer. Use (and release) Middle Finger Pinch on your right hand to execute the teleport. This interaction was inspired by Chamber from Valorant. As there is no standard for hand-tracking teleport yet, feel free to implement you own solutions :) 

The cubes and spheres show states of tracked interactions with hand tracking (for left and right), following this color code:

-  Cube
	- Index Finger Pinch -> Green
	- Middle Finger Pinch -> Yellow
	- Ring Finger Pinch -> Orange
	- Pinky Finger Pinch -> Blue
	
- Sphere
	- ThumbsUp Gesture -> Green
	- Shaka Gesture -> Yellow
	- Fist Gesture -> Orange
	- Rock Gesture -> Blue
	- One Gesture -> Violet
	- Two Gesture -> Cyan
	- Three Gesture -> Black
	- Four Gesture -> Pink
	
## The TemplateScene
This scene acts as boilerplate template, where the WebXR export, as well as the input mapping (controller + hands) and VRTK integration are already set up. Everything else, from teleporting to interactions must be implemented from scratch. Check out the VRTK Youtube channel (https://www.youtube.com/@VirtualRealityToolkit) and resources (https://www.vrtk.io/) for tutorials and inspiration.

## The details
Especially the hand tracking interactions resluts may vary. I implemented everything to work as reliable as possible, by granting thresholds that should work with neary every use-case. You can easily change those thresholds and limits by altering the numbers on the relevant actions in Unity.

### What does that mean?
All interactions regarding hand-tracking calculate distances between the tracked fingertips. The scripts working like this are GestureAction.cs and PinchAchtion.cs. E.g. if the distance between the thumb tip and index finger tip is less than 2cm, it's very likely that the hand executed a pinch. There is room for improvement, but it works pretty good most of the time and is generally not affecting performance.

It's a little more complicated in case of gesture recognition. When using gestures, the distances of all fingertips to the wrist is calculated and compared to set distances. This WILL vary, due to tracked hand sizes, but can be tweaked via the general distance and threshold settings. Feel free to play around with these settings and implement your own gestures! :)