using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActorData : MonoBehaviour
{
    [Header("== Max Data ==")]
    [Range(0, 200.0f)]
    public float HPMax = 100.0f;


    [Header("== Current Data ==")]
    public float HP = 100.0f;
    public float ATK = 10;
    public float DEF = 5;

    public Image uiHPBar;
    public WeaponManger wm;


    void Start()
    {
        //check hp max and hp compare when game start fix bug 
        AddHP(0);
        HPBarUpdate();
        HPMaxUpdate();
    }

    public void AddHP(float value)
    {
        //HP = ValueRegulate(HP + value,0,HPMax);
        //private float ValueRegulate(float value,float min,float max)
        //{
        //    return Mathf.Clamp(value, min, max);
        //}

        HP = Mathf.Clamp(HP + value, 0, HPMax);
        HPBarUpdate();

    }
    private void HPBarUpdate()
    {
        uiHPBar.fillAmount = HP / HPMax;
    }

    private void HPMaxUpdate()
    {
        HPMax = wm.wdata.HPMax + HPMax;
    }

}
