using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class lightsOn : MonoBehaviour {

    public GameObject item;
    bool lights=false;
    public float transitionTime;
    public AudioClip pointSound;
    public GameObject currentCamera;
    AudioSource speaker;

	void Start () {
        GetComponent<Image>().color = Color.black;
        speaker = currentCamera.GetComponent<AudioSource>();
	}
	
	// TODO: Poner un lerp
	void Update () {
        if (item == null&!lights)
        {
            GetComponent<Image>().color = Color.white;
            //audio.PlayOneShot(pointSound);
            speaker.PlayOneShot(pointSound);
            lights = true;
        }
	}
}
