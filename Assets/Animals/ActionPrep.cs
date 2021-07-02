﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[System.Serializable]
public class ActionPrep
{
    public string aniName;
    public float navSpeed;
    public float aniSpeed;
    public ActionPrep(string pAniName, float pNavSpeed, float pAniSpeed = 1)
    {
        this.aniName = pAniName;
        this.navSpeed = pNavSpeed;
        this.aniSpeed = pAniSpeed;
    }
    public void Prep(Animal script)
    {
        script.ani.Play(this.aniName);
        script.ani.speed = this.aniSpeed;
        script.nav.speed = this.navSpeed;
    }
}
