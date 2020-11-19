using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rank : MonoBehaviour
{
    public Transform player;
    public Text rankText;

    void Update()
    {
        rankText.text = player.position.z.ToString("0");
    }
}
