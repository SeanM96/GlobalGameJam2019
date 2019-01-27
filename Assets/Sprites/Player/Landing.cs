using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landing : MonoBehaviour
{
    private static bool _landed;
    private GameObject currentPlanet;
    [SerializeField] private Sprite newSprite;
    private float drainTime;
    private Animator anim;
    
    private void OnTriggerStay2D(Collider2D other)
    {
       
        currentPlanet = other.gameObject;
        _landed = currentPlanet.CompareTag("Planet");
        anim = currentPlanet.GetComponent<Animator>();
        
        if (_landed)
        {
            if (Input.GetKey("space"))
            {
                Debug.Log(drainTime += Time.deltaTime);
                Debug.Log("Draining");
                if(currentPlanet.CompareTag("Planet"))
                {
                    anim.enabled = true;
                }
            }
            else
            {
                anim.enabled = false;
            }
        }
    }
}
