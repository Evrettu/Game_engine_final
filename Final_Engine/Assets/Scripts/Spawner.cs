using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject duck1;
    public GameObject duck2;
    public GameObject duck3;
    public GameObject duck4;
    public GameObject duck5;

    // Start is called before the first frame update
    void Start()
    {
        duck1.SetActive(false);
        duck2.SetActive(false);
        duck3.SetActive(false);
        duck4.SetActive(false);
        duck5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        duck1.SetActive(true);
        duck2.SetActive(true);
        duck3.SetActive(true);
        duck4.SetActive(true);
        duck5.SetActive(true);
    }
}
