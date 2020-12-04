using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginMovement : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float zAxis = transform.position.z;

        //Mouse Input
        Vector2 mousePosition = Input.mousePosition;
        Vector2 mouseLook = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 0f));

        transform.position = mouseLook;
        Mathf.Clamp(zAxis, 0f, 0f);
    }
}
