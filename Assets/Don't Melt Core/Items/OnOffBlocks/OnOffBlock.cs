﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class OnOffBlock : MonoBehaviour
{
    public bool IsOnBlock = false;

    private RG_Collider RGC;
    private SpriteRenderer SR;

    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        RGC = GetComponent<RG_Collider>();
    }

    private void Update()
    {
        if (Stage_Player.Instance == null)
        {
            RGC.enabled = false;
        }
        else
        {
            if (IsOnBlock == Stage_Player.Instance.OnOffIsOn)
            {
                RGC.enabled = true;
                SR.color = GUIHelper.White;
            }
            else
            {
                RGC.enabled = false;
                SR.color = GUIHelper.Translucent;
            }
        }
    }
}