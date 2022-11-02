using UnityEngine;
using TMPro;
using Facebook.WitAi;
public class Dog : MonoBehaviour {
    private Wit wit;
    private Animator anim;
    private new AudioSource audio;
    [SerializeField]private TMP_Text debugText;
    private void Start() {
        wit = FindObjectOfType<Wit>();
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();

        debugText = GameObject.FindWithTag("Status").GetComponent<TMP_Text>();
    }
    private void Update() {
        if(!wit.Active && Input.GetMouseButton(0)) {
            wit.Activate();
        }
    }
    public void DogTrick(string trick) {
        if (trick == "Sit" || trick == "Shake" || trick == "Play Dead" || trick == "Roll Over") {
            anim.SetTrigger(trick);
            audio.Play();
        } else {
            debugText.text = "!Sorry did'nt get that";
        }
    }
}
