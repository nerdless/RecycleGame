using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class nomoreItems : MonoBehaviour {

   GameObject[] items;
   public Canvas youWin;
    public AudioClip cheering;
    public GameObject currentCamera;
    AudioSource speaker;
    bool youwon=false;

    void Start()
    {
        speaker = currentCamera.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        items=GameObject.FindGameObjectsWithTag("item");
        Debug.Log("faltan "+items.Length+" items");
        if (items.Length < 1&!youwon)
        {
            Debug.Log("Ya ganaste");
            youWin.enabled = true;
            youWin.gameObject.SetActive(true);
            speaker.PlayOneShot(cheering);
            youwon = true;
        }
	}
}
