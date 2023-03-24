using UnityEngine;
using WebXR;
using Zinnia.Action;

public class ControllerXAxisAction : FloatAction {

    [SerializeField]
    private WebXRController controller;
    [SerializeField]
    private WebXRController.Axis2DTypes axis2DType;

    public void Update() {
        Receive(controller.GetAxis2D(axis2DType).x);
    }
}
