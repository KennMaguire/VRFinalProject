using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class explode_barrel : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject explosionPrefab;
    public ParticleSystem Ps_Splash;
    private MeshRenderer mh;
    private int explosionNum = 0;
    public Text explosion_text;


    void Start()
    {
        //mh = this.GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        float collisionForce = collision.impulse.magnitude / Time.fixedDeltaTime;
      //  Debug.Log("Collision Force: " + collisionForce);
        if(collisionForce > 100.0f)
        {
              //mh.enabled = false;
            //  Debug.Log("explosion");
          //    Debug.Log("Collision Force: " + collisionForce);
              //Destroy(gameObject);
              //Instantiate(explosionPrefab, transform.position, Quaternion.identity);


              Ps_Splash.Play();
              //Destroy(this.gameObject);
              Invoke("DestroyFx",2f);
        }
    }
    void DestroyFx()
    {
      explosionNum = PlayerPrefs.GetInt("ExplosionNum");
      explosionNum += 1;
      PlayerPrefs.SetInt("ExplosionNum", explosionNum);
      explosion_text.GetComponent<UnityEngine.UI.Text>().text = "Explosions: " + explosionNum;
      Destroy(this.gameObject);
    }

}
