using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeDig : MonoBehaviour
{
    public GameObject player;
    public GameObject text;
    public bool isDig = false;
    private Text Text;
    private HeroKnight HeroKnight;
    void Start()
    {
        Text=text.GetComponent<Text>();
        HeroKnight = player.GetComponent<HeroKnight>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            isDig = !isDig;
            HeroKnight.isDig = this.isDig;
            if (isDig )
            {
                Text.text = "�ھ�ģʽ";
                Text.color = Color.blue;
            }
            else
            {
                Text.text = "����ģʽ";
                Text.color = Color.red;
            }
        }
    }
}
