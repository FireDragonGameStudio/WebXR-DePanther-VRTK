using UnityEngine;
using WebXR;
using Zinnia.Action;

public class GestureAction : BooleanAction {

    [SerializeField]
    private WebXRController controller;
    [SerializeField]
    private float thumbTipJointDistance;
    [SerializeField]
    private float indexTipJointDistance;
    [SerializeField]
    private float middleTipJointDistance;
    [SerializeField]
    private float ringTipJointDistance;
    [SerializeField]
    private float pinkyTipJointDistance;
    [SerializeField]
    private float generalThreshold = 0.02f;

    private Vector3 wristPosition;
    private Vector3 thumbTipPosition;
    private Vector3 indexTipPosition;
    private Vector3 middleTipPosition;
    private Vector3 ringTipPosition;
    private Vector3 pinkyTipPosition;

    private bool isGestureFound;

    protected override void Start() {
        controller.OnHandUpdate += GetCurrentHandData;
    }

    private void GetCurrentHandData(WebXRHandData handData) {
        wristPosition = handData.joints[(int)WebXRHandJoint.wrist].position;
        thumbTipPosition = handData.joints[(int)WebXRHandJoint.thumb_tip].position;
        indexTipPosition = handData.joints[(int)WebXRHandJoint.index_finger_tip].position;
        middleTipPosition = handData.joints[(int)WebXRHandJoint.middle_finger_tip].position;
        ringTipPosition = handData.joints[(int)WebXRHandJoint.ring_finger_tip].position;
        pinkyTipPosition = handData.joints[(int)WebXRHandJoint.pinky_finger_tip].position;
    }

    private void Update() {
        isGestureFound = false;
        if (controller.isHandActive) {

            float currentDistanceThumb = Mathf.Abs(Vector3.Distance(thumbTipPosition, wristPosition));
            float currentDistanceIndex = Mathf.Abs(Vector3.Distance(indexTipPosition, wristPosition));
            float currentDistanceMiddle = Mathf.Abs(Vector3.Distance(middleTipPosition, wristPosition));
            float currentDistanceRing = Mathf.Abs(Vector3.Distance(ringTipPosition, wristPosition));
            float currentDistancePinky = Mathf.Abs(Vector3.Distance(pinkyTipPosition, wristPosition));

            bool isThumbCorrect = CheckCurrentFingerTipDistance(currentDistanceThumb, thumbTipJointDistance);
            bool isIndexCorrect = CheckCurrentFingerTipDistance(currentDistanceIndex, indexTipJointDistance);
            bool isMiddleCorrect = CheckCurrentFingerTipDistance(currentDistanceMiddle, middleTipJointDistance);
            bool isRingCorrect = CheckCurrentFingerTipDistance(currentDistanceRing, ringTipJointDistance);
            bool isPinkyCorrect = CheckCurrentFingerTipDistance(currentDistancePinky, pinkyTipJointDistance);

            isGestureFound = isThumbCorrect && isIndexCorrect && isMiddleCorrect && isRingCorrect && isPinkyCorrect;
        }
        Receive(isGestureFound);
    }

    private void OnDestroy() {
        controller.OnHandUpdate -= GetCurrentHandData;
    }

    private bool CheckCurrentFingerTipDistance(float currentDistance, float gestureDistance) {
        return (currentDistance - (gestureDistance - generalThreshold)) * ((gestureDistance + generalThreshold) - currentDistance) >= 0;
    }
}
