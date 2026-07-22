using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Collectable
{
    public Sprite emptyItem;
    public string item;
    [TextArea(2, 5)]
    public string[] lines;
    public string[] speakers;
    public Dia dialogue;
    protected override void OnCollect()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Animator anim = GetComponent<Animator>();

        if (!collected)
        {
            collected = true;
            GetComponent<Animator>().enabled = false;
            GetComponent<SpriteRenderer>().sprite = emptyItem;
            dialogue.lines = lines;
            dialogue.speakers = speakers;
            dialogue.gameObject.SetActive(true);
            dialogue.startDia();

        }
    }
}
