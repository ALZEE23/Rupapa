using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 mousePositionOffset;
    private Vector3 lastPos;
    private Quaternion lastRot;

    public bool lastActive = false;

    private void Start()
    {
        lastPos = this.transform.position;
        lastRot = this.transform.rotation;
    }

    private Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseDown()
    {
        mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPosition() + mousePositionOffset;
    }

    void OnMouseUp()
    {
        if(lastActive == true){
            transform.position = lastPos;
        transform.rotation = lastRot;
        }
        
    }
}
