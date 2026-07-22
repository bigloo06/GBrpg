using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Collidable
{
    [TextArea(2, 5)]
    public string[] lines;
    public string[] speakers;
    public Dia dialogue;
    private bool talked = false;
    protected override void OnCollide(Collider2D coll)
    {
        if (talked)
        {
            return;
        }
        talked = true;
        dialogue.lines = lines;
        dialogue.speakers = speakers;
        dialogue.gameObject.SetActive(true);
        dialogue.startDia();
    }
}
