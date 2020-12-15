using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetRunningTime : MonoBehaviour
{
    // Start is called before the first frame update
    public Text txt;
    void Start()
    {
        //PlayerPrefs.SetInt("RedBoxScore", 0);
      //  PlayerPrefs.SetInt("BlueBoxScore", 0);
    //    PlayerPrefs.SetInt("GreenBoxScore", 0);
        PlayerPrefs.SetInt("ExplosionNum", 0);
        PlayerPrefs.SetInt("StuckNum", 0);

    }

    // Update is called once per frame
    void Update()
    {
        txt.GetComponent<UnityEngine.UI.Text>().text = "Running Time: " + Time.time;
    }
}
