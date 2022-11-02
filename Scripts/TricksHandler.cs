using UnityEngine;
using Facebook.WitAi;
using Facebook.WitAi.Lib;
#if PLATFORM_ANDROID
using UnityEngine.Android;
#endif
public class TricksHandler : MonoBehaviour
{
    private Dog dog;
    private void Start() {
        dog = FindObjectOfType<Dog>();
        #if PLATFORM_ANDROID
        if (!Permission.HasUserAuthorizedPermission(Permission.Microphone)) {
            Permission.RequestUserPermission(Permission.Microphone);
        }
        #endif
    }
    public void PerformTrick(WitResponseNode response) {
        var intent = WitResultUtilities.GetIntentName(response);
        if(intent == "perform_trick") {
            var trick = WitResultUtilities.GetFirstEntityValue(response, "trick:trick");
            dog.DogTrick(trick.ToString());
        }
    }
}
