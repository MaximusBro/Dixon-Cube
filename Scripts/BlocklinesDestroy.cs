using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocklinesDestroy : MonoBehaviour
{
    


    void Update()
    {
        if(this.transform.position.y <= -20f)
        {
            Destroy(this.gameObject);
        }
    }
    
}
