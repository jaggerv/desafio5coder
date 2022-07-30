using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject[] cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            setFirstPerson();
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            setThirdPerson();
        }
    }

    void setFirstPerson()
    {
        cam[0].SetActive(false);
        cam[1].SetActive(true);
    }

    void setThirdPerson()
    {
        cam[0].SetActive(true);
        cam[1].SetActive(false);
    }
}
