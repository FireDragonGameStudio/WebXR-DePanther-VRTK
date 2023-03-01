using UnityEngine;
using WebXR;
using Zinnia.Action;

public class ControllerAxisAction : FloatAction {

    [SerializeField]
    private WebXRController controller;
    [SerializeField]
    private WebXRController.Axis2DTypes axis2DType;
    [SerializeField]
    private Vector2DAxisModel axisModel;

    public void Update() {
        switch (axisModel) {
            case Vector2DAxisModel.X:
                Receive(controller.GetAxis2D(axis2DType).x);
                break;
            case Vector2DAxisModel.Y:
                Receive(controller.GetAxis2D(axis2DType).y);
                break;
            default:
                Receive(0);
                break;
        }
    }
}
