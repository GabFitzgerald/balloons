using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public int clicksToPop = 5;

    void OnMouseDown()
    {
        clicksToPop--;

        // balloon grows
        transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);

        // destroy balloon when no more clicks
        if (clicksToPop == 0)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
