using UnityEngine;
using System.Collections;

public class DragDrop : MonoBehaviour {

    Vector3 origPos, curMousePos;
    public Camera camera;
    
    void OnMouseDown()
    {
        curMousePos = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

        origPos = transform.position;

        StartCoroutine("DragObject");
        transform.rigidbody2D.isKinematic = false;
        
       
    }

    IEnumerator DragObject()
    {
        while (Input.GetMouseButton(0))
        {
            Vector3 newMousePos = Input.mousePosition;
            
            
            newMousePos = camera.ScreenToWorldPoint(newMousePos);

            newMousePos.z = 0;

            transform.position = newMousePos;
            transform.position.Set(transform.position.x,transform.position.y,0);

            yield return 0;
        }

        transform.position = origPos;
        transform.rigidbody2D.isKinematic = true;
        
    }

}
