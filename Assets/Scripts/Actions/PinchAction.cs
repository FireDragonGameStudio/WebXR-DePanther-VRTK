using UnityEngine;
using WebXR;
using Zinnia.Action;

public class PinchAction : BooleanAction {

    [SerializeField]
    private WebXRController controller;
    [SerializeField]
    private WebXRHandJoint fingerTipJoint;
    [SerializeField]
    private float threshold = 0.02f;

    private Vector3 thumbTipPosition;
    private Vector3 fingerTipPosition;

    protected override void Start() {
        controller.OnHandUpdate += GetCurrentHandData;
    }

    private void GetCurrentHandData(WebXRHandData handData) {
        thumbTipPosition = handData.joints[(int)WebXRHandJoint.thumb_tip].position;
        fingerTipPosition = handData.joints[(int)fingerTipJoint].position;
    }

    private void Update() {
        if (controller.isHandActive) {
            Receive(Vector3.Distance(thumbTipPosition, fingerTipPosition) < threshold);
        }
    }

    private void OnDestroy() {
        controller.OnHandUpdate -= GetCurrentHandData;
    }
}
