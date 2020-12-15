using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blade_stick : MonoBehaviour
{
    // Start is called before the first frame update

    private int stuckNum = 0;
    public Text stuck_text;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "blade") {
            //var hit = collision.contacts[0];
          //  collision.rigidbody.constraints =
            collision.rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ |RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY ;
            stuckNum = PlayerPrefs.GetInt("StuckNum");
            stuckNum += 1;
            PlayerPrefs.SetInt("StuckNum", stuckNum);
            stuck_text.GetComponent<UnityEngine.UI.Text>().text = "Swords Stuck: " + stuckNum;

        }


    }



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
