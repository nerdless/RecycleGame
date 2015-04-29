using UnityEngine;
using System.Collections;

public class gotoTrash : MonoBehaviour
{
    public Transform trash;
    //TODO: Arreglar cuando choca con dos botes
    void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("chocando");
        if (collision.transform.tag != trash.tag)
            return;
        else
        {
            
            if (Input.GetMouseButton(0))
                return;
            Debug.Log("the trash is in!");
            
            Destroy(gameObject);
            
        }
    }
}
