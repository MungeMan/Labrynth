using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    // Start is called before the first frame update
    private Text healthText;
    public Player player;
    public Image heart1;
    public Image heart2;
    public Image heart3;
    void Start()
    {
        healthText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + player.health.ToString();
        switch (player.health)
        {
            case 0:
                heart1.enabled = false;
                heart2.enabled = false;
                heart3.enabled = false;
                break;
            case 1:
                heart1.enabled = true;
                heart2.enabled = false;
                heart3.enabled = false;
                break;
            case 2:
                heart1.enabled = true;
                heart2.enabled = true;
                heart3.enabled = false;
                break;
            case 3:
                heart1.enabled = true;
                heart2.enabled = true;
                heart3.enabled = true;
                break;
        }
    }
}
