using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPersonaje : MonoBehaviour
{
    private float checkPointPositionX, checkPointPositionY;
    /*public GameObject[] vida;
    private int life = 5;*/

    private void Start()
    {
        if (PlayerPrefs.GetFloat("checkPointPositionX") != 0)
        {
            transform.position = (new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"),
                PlayerPrefs.GetFloat("checkPointPositionY")));
        }
    }

    public void ReachedCheckPonit(float x, float y)
    {
        PlayerPrefs.SetFloat("checkPointPositionX", x);
        PlayerPrefs.SetFloat("checkPointPositionY", y);
    }
    
    /*private void Update()
    {
        if(life < 1)
        {
            Destroy(vida[0].gameObject);
        }
        else if(life < 2)
        {
            Destroy(vida[1].gameObject);
        }
        else if(life < 3)
        {
            Destroy(vida[2].gameObject);
        }
        else if(life < 4)
        {
            Destroy(vida[3].gameObject);
        }
        else if (life < 5)
        {
            Destroy(vida[4].gameObject);
        }
    }

    public void PlayerDamaged()
    {
        life--;
    }*/
}
