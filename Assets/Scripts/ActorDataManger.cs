using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorDataManger : MonoBehaviour
{
    public ActorData adata;
    public WeaponManger wm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float GetATK()
    {
        return adata.ATK + wm.wdata.ATK;
    }

    public float GetATKRandom(float precentage)
    {
        float atk = adata.ATK + wm.wdata.ATK;

        return Random.Range((1-precentage) * atk , (1+precentage) * atk);
    }

    public float GetDEF()
    {
        return adata.DEF + wm.wdata.DEF;
    }

    public float GetHPMax()
    {
        return adata.HPMax + wm.wdata.HPMax;
    }

    public void AddHP(float value)
    {
        //adata.HP = Mathf.Clamp(adata.HP + value, 0, adata.HPMax);
        adata.AddHP(value);
    }
}
