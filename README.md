# UI Screen Shake

Scripts that make it easy to shake UI elements, mainly for camera-shake style juice effects. 

EASY SET UP!

I make lots of AR games, and camera-shake effects are sometimes awkward to implement because usually the player controls where the camera is in the scene, not the developer. One approach I've taken for camera-shake situations is to shake the UI instead of the camera. 

To use:

1. Place a "UI Screen Shake" component on the ui element that you want to shake.
2. There are 2 ways to shake this component:
    * Call the Shake(float percentMaximum, float seconds) method on the UI Screen Shake component to shake just that component.
    * Call UIScreenShake.GlobalShake(float percentMaximum, float seconds) to shake all UI Screen Shake components at once.
3. The UI Screen Shake Button can be used to cheaply test or implement this feature. Simply drag it onto a UI Button and configure it to behave as desired.

---

### Use this package to:
* Quickly implement camera-shake style effects in the UI.

---

### Key components:

1. UIScreenShake
	* Place this component on a gameobject with a RectTransform that you want to shake.
2. UIScreenShakeButton
	* Place this on a gameobject with a UI button to cheaply shake UIScreenShake components.