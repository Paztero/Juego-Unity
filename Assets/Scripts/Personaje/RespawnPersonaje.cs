using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnPersonaje : MonoBehaviour
{
    private float checkPointPositionX, checkPointPositionY;
    public GameObject[] vida;
    private int life;

    private void Start()
    {
        life = vida.Length;
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
    
    public void PlayerDamaged()
    {
        life--;
        if(life < 1)
        {
            Destroy(vida[0].gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
}
