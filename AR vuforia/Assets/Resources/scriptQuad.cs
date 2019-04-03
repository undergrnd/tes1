using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptQuad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {

    }

    private void OnBecameInvisible()
    {
        var Vp = GetComponent<UnityEngine.Video.VideoPlayer>();
        Vp.Stop();
    }
}
