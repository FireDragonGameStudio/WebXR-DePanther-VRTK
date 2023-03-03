using UnityEngine;
using WebXR;
using Zinnia.Action;

public class ControllerAxis1DAction : FloatAction {

    [SerializeField]
    private WebXRController controller;
    [SerializeField]
    private WebXRController.AxisTypes axisType;

    public void Update() {
        Receive(controller.GetAxis(axisType));
    }
}
