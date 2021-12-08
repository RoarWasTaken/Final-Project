using UnityEngine;

public class AutoDestruct : MonoBehaviour
{

    // Lifetime of gameObject
    // Destroy this gameObject in this many seconds after being instantiated
   

    void Start()
    {
        Destroy(gameObject, 1.5f);
    }
}
