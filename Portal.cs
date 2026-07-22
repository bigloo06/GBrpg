using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Portal : Collidable
{
    public string sceneName;
    protected override void OnCollide(Collider2D coll)
    {
        GameManager.instance.SaveState();
        if(coll.name == "Player")
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
