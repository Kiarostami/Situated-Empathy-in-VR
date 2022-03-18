using UnityEngine;
using PixelCrushers.DialogueSystem;

/// <summary>
/// Moves the Dialogue Manager's world space canvas Dialogue Panel to 
/// an offset from this GameObject relative to the camera when a
/// conversation starts.
/// </summary>
public class MoveDialoguePanel : MonoBehaviour
{

    public bool lookAtCamera = true;
    public bool flip = true;
    public Vector3 offset;

    void OnConversationStart(Transform actor)
    {
        if (Camera.main == null) return;

        // Face the player:
        if (lookAtCamera)
        {
            var lookAtPosition = Camera.main.transform.position;
            lookAtPosition.y = transform.position.y;
            transform.LookAt(lookAtPosition);
        }

        // Get reference to dialogue panel's canvas:
        var dialoguePanel = DialogueManager.standardDialogueUI.conversationUIElements.mainPanel;
        if (dialoguePanel == null) return;
        var dialoguePanelCanvas = dialoguePanel.GetComponentInParent<Canvas>();
        if (dialoguePanelCanvas == null) return;

        // May need to flip based on NPC's rotation (i.e., if NPC's model rotation is backward):
        if (flip)
        {
            var scale = dialoguePanelCanvas.transform.localScale;
            scale.x = -Mathf.Abs(scale.x);
            dialoguePanelCanvas.transform.localScale = scale;
        }

        // Move dialogue panel to offset from me:
        dialoguePanelCanvas.transform.rotation = transform.rotation;
        dialoguePanelCanvas.transform.position = transform.position + transform.rotation * offset;
    }

}
