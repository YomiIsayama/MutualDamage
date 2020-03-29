using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManger : MonoBehaviour
{
    public WeaponData wdata;
    public int ATKID = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EQEnable()
    {
        //use wdata's STATE  , must WeaponData.STATE;
        wdata.state = WeaponData.STATE.ACTIVE;
    }

    public void EQDisable()
    {
        wdata.state = WeaponData.STATE.IDLE;
    }

}
