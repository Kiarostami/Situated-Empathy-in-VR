Basic Unity XR Interaction - Dialogue System Example
Updated: 2021-12-02

Exported from:
- Unity 2019.4+
- Dialogue System for Unity 2.2.22

You MUST install these packages via the Package Manager window:
- Input System
- Oculus XR Plugin
- Universal RP (optional)
- Windows XR Plugin
- XR Interaction Toolkit (preview)
- XR Plugin Management

Since the XR Interaction Toolkit is built on the new Input System package, you must enable the
Dialogue System's Input System integration. In the Welcome Window, tick USE_NEW_INPUT.

If you are using URP, you must download and import the Demo scene's URP materials from
the Dialogue System Extras page: https://www.pixelcrushers.com/dialogue-system/dialogue-system-extras/

FEATURES:

- Simple teleportation locomotion: Use grip trigger to teleport, joystick to rotate.

- Dialogue Manager GameObject has two canvases: 
	- Screen space overlay: For alert panel.
	- World space: For dialogue panel. Expected to be moved by NPC when conversation starts.
	
- Terminal conversation: Demonstrates a world space dialogue UI.

- Private Hart conversation: Demonstrates a world space subtitle panel, and uses a simple
  script named MoveDialoguePanel to move the Dialogue Manager's dialogue panel next to the NPC
  for the response menu.
