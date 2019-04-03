using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttefly : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                Debug.Log("Something Hit");
                if (raycastHit.collider.name == "butterfly")
                {
                    Debug.Log("Soccer Ball clicked");
                }

                //OR with Tag
                
                if (raycastHit.collider.CompareTag("butterfly"))
                {
                    Debug.Log("Soccer Ball clicked");
                }
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Debug.Log("Somethingss Hit");
                if (hit.collider.tag == "butterfly")
                {
                    hit.transform.position.Set(Camera.main.ScreenToViewportPoint(Input.mousePosition).x, Camera.main.ScreenToViewportPoint(Input.mousePosition).y, hit.transform.position.z);
                    Debug.Log("butterfly Ball clicked");
                }
            }
        }

    }
}
