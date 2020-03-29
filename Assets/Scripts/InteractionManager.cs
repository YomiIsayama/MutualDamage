using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public ActorController ac;
    public ActorDataManger adm;

    [Header("=== EFXS ===")]
    public GameObject blockEFX;
    public GameObject attackEFX;


    // Start is called before the first frame update
    void Start()
    {
        adm.GetHPMax();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DoDamage(InteractionManager attacker)
    {
        //ac.adata.AddHP(-1 * Mathf.Max((attacker.ac.adata.ATK - this.ac.adata.DEF),0));
        float damage = Mathf.Max((attacker.adm.GetATKRandom(0.5f) - this.adm.GetDEF()), 0);

        float blockChance = Random.Range(0.0f, 1.0f);
        if (blockChance < 0.7f)
        {
            adm.adata.AddHP(-1 * damage);
            //attacker.ac.anim.SetTrigger("attack");
            this.ac.anim.SetTrigger("hit");
            Debug.Log("damage is " + (-1 * damage));
            Instantiate(attackEFX, transform.position + new Vector3(0, 1, 0), transform.rotation);
        }
        else
        {
            this.ac.anim.SetTrigger("block");
            Debug.Log("damage is " + 0);
            Instantiate(blockEFX, transform.position + new Vector3(0, 1, 0), transform.rotation);
        }
        CheckHP();


    }

    private void CheckHP()
    {
        if (this.adm.adata.HP <= 0)
        {
            this.ac.anim.SetTrigger("death");
        }
    }

}
