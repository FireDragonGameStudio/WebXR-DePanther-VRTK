using UnityEngine;
using Zinnia.Action;

public class InvertedBooleanAction : BooleanAction {
    [SerializeField]
    private BooleanAction boolAction;

    public void Update() {
        Receive(!boolAction.Value);
    }
}
