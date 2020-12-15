using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gravity_gun_pull : MonoBehaviour
{

    public Text pulled_text;
    public Text launched_text;
    private GameObject selection;
    //bool rotLock = false;
    const float pullFactor = .15f;
    Vector3 shiftRayCast = new Vector3(0.0f, 0.0f, 0.0f);
    Vector3 shiftBarrelPos = new Vector3(0.0f, -1.0f, 0.0f);
    private int pulledIter = 0;
    private int launchedIter = 0;
    private bool newPull = true;
    private bool newLaunch = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            GG_RayInteraction();
        }

    }
    void Default_PushPull(RaycastHit hit)
    {
        //Vector3 upward = new Vector3(0,0,5);
        float distancePullFactor = pullFactor;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 100.0f;
        //Transform gg_ = this.gameObject.GetChild(0).GetChild(0).transform;
        //Debug.DrawRay(transform.position, forward, Color.green, 50.0f);
      //  Debug.Log("okay it works");
        //float step = .5f * Time.deltaTime;
        Vector3 pullForceDirection = transform.position - hit.collider.gameObject.GetComponent<Transform>().position;
        //objectTransform =
        //Vector3 towardVec = Vector3.MoveTowards(transform.position,  hit.collider.gameObject.GetComponent<Transform>().position, step);
        float distance = Vector3.Distance(transform.position, hit.collider.gameObject.GetComponent<Transform>().position);
      //  bool rotLock = true;

        if(distance < 6)
        {

          //  hit.collider.gameObject.GetComponent<Rigidbody>().constraints.FreezeRotation = true;
            if(OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.RTouch) > 0.1f)
            {
              //  Debug.Log(forward);
                hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(50.0f * transform.forward);
                if(newLaunch)
                {
                  launchedIter += 1;
                  launched_text.GetComponent<UnityEngine.UI.Text>().text = "Objects Launched: " + launchedIter;
                  newLaunch = false;
                }
                newPull = true;
            }
            else
            {

              if(newPull)
              {
                pulledIter += 1;
                pulled_text.GetComponent<UnityEngine.UI.Text>().text = "Objects Pulled: " + pulledIter;
                newPull = false;
              }
              newLaunch = true;
              hit.collider.gameObject.GetComponent<Transform>().position = transform.position + transform.forward.normalized*2;
              hit.collider.gameObject.GetComponent<Transform>().rotation = transform.rotation;
            }
        }
        else
        {

            if(distance < 50)
            {
                distancePullFactor = ((1/distance)*.5f)+pullFactor;
              //  Debug.Log(distancePullFactor);
            }
            if(OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.RTouch) < 0.1f && distance > 6)
            {
              hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(distancePullFactor * pullForceDirection);
            }

        }

    }
    void Barrel_PushPull(RaycastHit hit)
    {
        //Vector3 upward = new Vector3(0,0,5);
        float distancePullFactor = pullFactor;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 100.0f;
        //Transform gg_ = this.gameObject.GetChild(0).GetChild(0).transform;
        //Debug.DrawRay(transform.position, forward, Color.green, 50.0f);
      //  Debug.Log("okay it works");
        //float step = .5f * Time.deltaTime;
        Vector3 pullForceDirection = transform.position - hit.collider.gameObject.GetComponent<Transform>().position;
        //objectTransform =
        //Vector3 towardVec = Vector3.MoveTowards(transform.position,  hit.collider.gameObject.GetComponent<Transform>().position, step);
        float distance = Vector3.Distance(transform.position, hit.collider.gameObject.GetComponent<Transform>().position);
      //  bool rotLock = true;

        if(distance < 6)
        {

          //  hit.collider.gameObject.GetComponent<Rigidbody>().constraints.FreezeRotation = true;
            if(OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.RTouch) > 0.1f)
            {
              //  Debug.Log(forward);
                hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(50.0f * transform.forward);
                if(newLaunch)
                {
                  launchedIter += 1;
                  launched_text.GetComponent<UnityEngine.UI.Text>().text = "Objects Launched: " + launchedIter;
                  newLaunch = false;
                }
                newPull = true;
            }
            else
            {
              if(newPull)
              {
                pulledIter += 1;
                pulled_text.GetComponent<UnityEngine.UI.Text>().text = "Objects Pulled: " + pulledIter;
                newPull = false;
              }
              newLaunch = true;
              hit.collider.gameObject.GetComponent<Transform>().position = (transform.position+shiftBarrelPos) + transform.forward.normalized*2;
              //hit.collider.gameObject.GetComponent<Transform>().position += shiftBarrelPos;
              hit.collider.gameObject.GetComponent<Transform>().rotation = transform.rotation;
            }
        }
        else
        {

            if(distance < 50)
            {
                distancePullFactor = ((1/distance)*.5f)+pullFactor;
              //  Debug.Log(distancePullFactor);
            }
            if(OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.RTouch) < 0.1f && distance > 6)
            {
              hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(distancePullFactor * pullForceDirection);
            }

        }
    }
    void Blade_PushPull(RaycastHit hit)
    {
      //Vector3 upward = new Vector3(0,0,5);
      hit.collider.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
      float distancePullFactor = pullFactor;
      Vector3 forward = transform.TransformDirection(Vector3.forward) * 100.0f;
      //Transform gg_ = this.gameObject.GetChild(0).GetChild(0).transform;
      //Debug.DrawRay(transform.position, forward, Color.green, 50.0f);
    //  Debug.Log("okay it works");
      //float step = .5f * Time.deltaTime;
      Vector3 pullForceDirection = transform.position - hit.collider.gameObject.GetComponent<Transform>().position;
      //objectTransform =
      //Vector3 towardVec = Vector3.MoveTowards(transform.position,  hit.collider.gameObject.GetComponent<Transform>().position, step);
      float distance = Vector3.Distance(transform.position, hit.collider.gameObject.GetComponent<Transform>().position);
    //  bool rotLock = true;

      if(distance < 6)
      {

        //  hit.collider.gameObject.GetComponent<Rigidbody>().constraints.FreezeRotation = true;
          if(OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.RTouch) > 0.1f)
          {
            //  Debug.Log(forward);
              hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(50.0f * transform.forward);
              if(newLaunch)
              {
                launchedIter += 1;
                launched_text.GetComponent<UnityEngine.UI.Text>().text = "Objects Launched: " + launchedIter;
                newLaunch = false;
              }
              newPull = true;
          }
          else
          {
            if(newPull)
            {
              pulledIter += 1;
              pulled_text.GetComponent<UnityEngine.UI.Text>().text = "Objects Pulled: " + pulledIter;
              newPull = false;
            }
            newLaunch = true;
            hit.collider.gameObject.GetComponent<Transform>().position = transform.position + transform.forward.normalized*2;
            hit.collider.gameObject.GetComponent<Transform>().rotation = transform.rotation;
            hit.collider.gameObject.GetComponent<Transform>().rotation *= Quaternion.Euler(90, 90, 90);
          }
      }
      else
      {

          if(distance < 50)
          {
              distancePullFactor = ((1/distance)*.5f)+pullFactor;
            //  Debug.Log(distancePullFactor);
          }
          if(OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.RTouch) < 0.1f && distance > 6)
          {
            hit.collider.gameObject.GetComponent<Rigidbody>().AddForce((distancePullFactor*5) * pullForceDirection);
          }

      }
    }
    void GG_RayInteraction()
    {
        RaycastHit hit;
        //Transform gg_transform = this.gameObject.GetChild(0).GetChild(0).transform;
        if(Physics.Raycast(transform.position+shiftRayCast, transform.forward, out hit))
        {
            if(hit.transform.gameObject.tag == "crate")
            {
                Default_PushPull(hit);
                //hit.collider.gameObject.GetComponent<Rigidbody>().constraints.FreezeRotation = false;
            }
            if(hit.transform.gameObject.tag == "barrel")
            {
                Barrel_PushPull(hit);
                //hit.collider.gameObject.GetComponent<Rigidbody>().constraints.FreezeRotation = false;
            }
            if(hit.transform.gameObject.tag == "blade")
            {
                Blade_PushPull(hit);
            }
        }
    }

}
