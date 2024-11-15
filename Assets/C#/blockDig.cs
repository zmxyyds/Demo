using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class blockDig : MonoBehaviour
{
    private HeroKnight HeroKnight;
    private bool isMouseOn = false;
    private float digTime = 1.0f;//������ھ�����Ҫ��ʱ�䡣��������Ļ�����λӦ������
    private float diggingTime = 0.0f;//����ǣ����˶���ˣ�我爱你
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
            diggingTime = 0.0f;
        }
    }
}
