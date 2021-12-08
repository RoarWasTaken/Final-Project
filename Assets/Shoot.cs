using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public AudioSource audio;
    public GameObject clone;

    //Damage enemy
    [SerializeField]
    float damage = 10f;





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            clone = Instantiate(bullet, transform.position, transform.rotation);
            Destroy(clone.gameObject, 3);


            audio.Play();



            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);




            if (Physics.Raycast(ray, out hit, 100f))
            {
                if (hit.transform.tag == "enemy")
                {
                    EnemyHealth enemyHealthScript = hit.transform.GetComponent<EnemyHealth>();
                    enemyHealthScript.DeductHealth(damage);

                }

            }

        }
    }
}


        


