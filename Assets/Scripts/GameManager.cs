using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;

public class GameManager : MonoBehaviour
{
    [Header("== Parameters Setting ==")]
    [Range(0, 10.0f)]
    public float i = 0.1f;

    [Space(10)]

    [Header("== String Setting ==")]
    public string name1;

    [Header("== ActorController Setting ==")]
    public ActorController ac1;
    public ActorController ac2;
    public InteractionManager im1;
    public InteractionManager im2;

    [Header("== FGUI Setting ==")]
    public FGUITester fgui;

    public enum STATE
    {
        IDLE,
        PLAYERA,
        PLAYERB,
        FINISHED
    }

    [Header("== Game State ==")]
    public STATE state;
    
    private bool firstEnter = true;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (state == STATE.IDLE)
        {
            if (firstEnter == true)
            {
                firstEnter = false;
                StartCoroutine("TaskIDLE");
            }
            else
            {
                // void Update() in here
                checkHP();
            }
            ////because use Coroutine ,move to IEnumerator TaskIDLE();
            //if (Input.GetKeyDown(KeyCode.Q))
            //{
            //    state = STATE.PLAYERA;
            //    ac1.anim.SetTrigger("attack");
            //    //ac2.adata.AddHP(-1*ac1.adata.ATK);
            //    //im2.DoDamage(im1);
            //}
        }
        else if (state == STATE.PLAYERA)
        {
            if (firstEnter == true)
            {
                firstEnter = false;
                StartCoroutine("TaskPLAYERA");
            }
            else
            {
                checkHP();
            }

            //if (Input.GetKeyDown(KeyCode.Q))
            //{
            //    state = STATE.PLAYERB;
            //    ac2.anim.SetTrigger("attack");
            //    //ac1.adata.AddHP(-1*ac2.adata.ATK);
            //    //im1.DoDamage(im2);
            //}
        }
        else if (state == STATE.PLAYERB)
        {

            if (firstEnter == true)
            {
                firstEnter = false;
                StartCoroutine("TaskPLAYERB");
            }
            else
            {
                checkHP();
            }

            //if (Input.GetKeyDown(KeyCode.Q))
            //{
            //    state = STATE.IDLE;
            //}
        }
        else if (state == STATE.FINISHED)
        {
            if (firstEnter == true)
            {
                StopCoroutine("TaskIDLE");
                StopCoroutine("TaskPLAYERA");
                StopCoroutine("TaskPLAYERB");
            }
        }
        else
        {

        }

    }

    private void checkHP()
    {
        if (ac1.adata.HP <= 0 || ac2.adata.HP <= 0)
        {
            state = STATE.FINISHED;
            firstEnter = true;
        }
    }


    IEnumerator TaskIDLE()
    {
        yield return new WaitForSeconds(0.5f);
        fgui.Play("SceneBattleStart");
        yield return new WaitForSeconds(2.0f);
        state = STATE.PLAYERA;
        firstEnter = true;

    }

    IEnumerator TaskPLAYERA()
    {
        ac1.anim.SetTrigger("attack");
        yield return new WaitForSeconds(2.0f);
        state = STATE.PLAYERB;
        firstEnter = true;

    }
    IEnumerator TaskPLAYERB()
    {
        ac2.anim.SetTrigger("attack");
        yield return new WaitForSeconds(2.0f);
        state = STATE.PLAYERA;
        firstEnter = true;

    }
}
