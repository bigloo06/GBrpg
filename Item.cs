using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Collectable
{
    public Sprite emptyItem;
    public string item;
    protected override void OnCollect()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Animator anim = GetComponent<Animator>();

        if (!collected)
        {
            collected = true;
        }
    }
}
