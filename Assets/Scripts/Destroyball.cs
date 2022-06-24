using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyball: MonoBehaviour
{
    public BallManager manager;
    public Collider gawang1;
    public Collider gawang2;
    public Collider gawang3;
    public Collider gawang4;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision == gawang1 || collision == gawang2 || collision == gawang3 || collision == gawang4 )
        {
            manager.RemoveBall(gameObject);
        }
    }
}
