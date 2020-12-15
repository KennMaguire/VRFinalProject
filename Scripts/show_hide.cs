using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_hide : MonoBehaviour
{
    // Start is called before the first frame update
    int tfSwitch = 0;
    public GameObject menu;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.GetUp(OVRInput.RawButton.B))
        {
            if(tfSwitch % 2 == 1)
            {
                menu.SetActive(true);
            }
            else
            {
                menu.SetActive(false);
            }
            tfSwitch += 1;

        }
    }
}
