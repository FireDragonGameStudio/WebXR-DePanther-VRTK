using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputTextChecker : MonoBehaviour {

    [SerializeField]
    private TextMeshProUGUI leftHandText;
    [SerializeField]
    private TextMeshProUGUI rightHandText;
    [SerializeField]
    private List<InputTextModel> textModelsLeft = new List<InputTextModel>();
    [SerializeField]
    private List<InputTextModel> textModelsRight = new List<InputTextModel>();

    private void Update() {
        foreach (var textModel in textModelsLeft) {
            if (textModel.BooleanInput.Value) {
                leftHandText.text = textModel.Name;
                break;
            }
        }
        foreach (var textModel in textModelsRight) {
            if (textModel.BooleanInput.Value) {
                rightHandText.text = textModel.Name;
                break;
            }
        }
    }
}
