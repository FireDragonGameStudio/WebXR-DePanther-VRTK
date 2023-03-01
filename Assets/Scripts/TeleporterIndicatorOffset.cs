using UnityEngine;
using WebXR;

public class TeleporterIndicatorOffset : MonoBehaviour {

    [SerializeField]
    private WebXRController controller;
    [SerializeField]
    private Vector3 positionOffset;
    [SerializeField]
    private Vector3 rotationOffset;

    private bool offsetApplied = false;

    private void Update() {
        if (controller.isHandActive && !offsetApplied) {
            transform.Translate(positionOffset, Space.Self);
            transform.Rotate(rotationOffset, Space.Self);
            offsetApplied = true;
        }
        if (!controller.isHandActive && offsetApplied) {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            offsetApplied = false;
        }
    }
}
