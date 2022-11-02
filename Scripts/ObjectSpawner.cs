// using UnityEngine;

// public class ObjectSpawner : MonoBehaviour
// {
//     public GameObject objectToSpawn;
//     private PlacementIndicator indicator;
//     private GameObject objectInstance;
//     private void Start() {
//         indicator = FindObjectOfType<PlacementIndicator>();
//     }
//     private void Update() {
//         if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) {
//             if (!objectInstance.activeInHierarchy) {
//                 objectInstance = Instantiate(objectToSpawn, indicator.transform.position, indicator.transform.rotation);
//                 indicator.Disable();
//             }
//         }
//     }
// }
