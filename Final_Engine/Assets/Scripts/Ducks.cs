using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ducks : MonoBehaviour
{
    int ducks_missed = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(10, 0, 0);

        if(ducks_missed >= 2)
        {

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);

        ducks_missed++;
    }
}
