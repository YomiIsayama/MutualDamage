using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponData : MonoBehaviour
{
    public float ATK;
    public float DEF;
    public float HPMax;

    public enum STATE
    {
        IDLE,
        ACTIVE
    }
    public STATE state;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (state == STATE.ACTIVE)
        {
            // catch target interactionmanager;
            InteractionManager im = col.GetComponent<InteractionManager>();
            if (im != null)
            {
                im.DoDamage(GetComponentInParent<InteractionManager>());
            }
        }
        
    }

}
