# UI Screen Shake
*Version: 1.0.2*
## Description: 
Scripts that make it easy to shake UI elements, mainly for camera-shake style juice effects. EASY SET UP!I make lots of AR games, and camera-shake effects are sometimes awkward to implement because usually the player controls where the camera is in the scene, not the developer. One approach I've taken for camera-shake situations is to shake the UI instead of the camera. 
## Use Cases: 
* Quickly implement camera-shake style effects in the UI. 
## Directions for Use: 
1. Place a "UI Screen Shake" component on the ui element that you want to shake.
1. There are 2 ways to shake this component:
   1. Call the Shake(float percentMaximum, float seconds) method on the UI Screen Shake component to shake just that component.
   1. Call UIScreenShake.GlobalShake(float percentMaximum, float seconds) to shake all UI Screen Shake components at once.
1. The UI Screen Shake Button can be used to cheaply test or implement this feature. Simply drag it onto a UI Button and configure it to behave as desired.
## Package Mirrors: 
[<img src='https://img.itch.zone/aW1nLzEzNzQ2ODg3LnBuZw==/original/npRUfq.png'>](https://github.com/Iron-Mountain-Software/ui-screen-shake)[<img src='https://img.itch.zone/aW1nLzEzNzQ2ODk4LnBuZw==/original/Rv4m96.png'>](https://iron-mountain.itch.io/ui-screen-shake)[<img src='https://img.itch.zone/aW1nLzEzNzQ2ODkyLnBuZw==/original/Fq0ORM.png'>](https://www.npmjs.com/package/com.iron-mountain.ui-screen-shake)
---
## Key Scripts & Components: 
1. public enum **TimeScaleType** : Enum
1. public class **UIScreenShake** : MonoBehaviour
   * Methods: 
      * public void ***Reset***()
      * public void ***Shake***(float percentMaximum, float seconds)
1. public class **UIScreenShakeButton** : MonoBehaviour
