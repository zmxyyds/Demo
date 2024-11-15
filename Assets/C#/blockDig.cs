using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class blockDig : MonoBehaviour
{
    private HeroKnight HeroKnight;
    private bool isMouseOn = false;
    private float digTime = 1.0f;//这个是挖掘所需要的时间。不出意外的话，单位应该是秒
    private float diggingTime = 0.0f;//这个是（挖了多久了）
    private SpriteRenderer sr;
    public Sprite[] pictrue;
    private void OnMouseEnter()
    {
        isMouseOn = true;
        sr.sprite=pictrue[1];
    }
    private void OnMouseExit()
    {
        isMouseOn = false;
        sr.sprite=pictrue[0];
    }
    private void Start()
    {
        HeroKnight=GameObject.Find("player").GetComponent<HeroKnight>();
        sr = this.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if(isMouseOn && Input.GetMouseButton(0) && HeroKnight.isDig && !HeroKnight.m_isDeath)
        {
            diggingTime += Time.deltaTime;
            if(diggingTime > digTime)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            diggingTime = 0.00f;
        }
    }
}
