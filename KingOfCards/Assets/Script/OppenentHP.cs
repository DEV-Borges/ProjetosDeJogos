using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OppenentHP : MonoBehaviour
{
    public static float maxHp;
    public static float staticHp;
    public float hp;
    public Image health;
    public Text hpText;


    // Start is called before the first frame update
    void Start() {
        maxHp = 25000;
        staticHp = 20000;
    }

    // Update is called once per frame
    void Update() {
        hp = staticHp;
        health.fillAmount = hp / maxHp;

        if (hp >= maxHp) {
            hp = maxHp;
        }

        hpText.text = hp + "HP";
    }
}