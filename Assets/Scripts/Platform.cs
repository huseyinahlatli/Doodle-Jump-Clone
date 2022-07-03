using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Platform : MonoBehaviour
{
    public TextMeshProUGUI Score;
    public static int scoreValue = 0;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player") && other.relativeVelocity.y <= 0f)
        {
            other.gameObject.GetComponent<CharacterControl>().CharacterSpeed();  
            Destroy(this.gameObject);    
            scoreValue += 10;
            Score.text = "Score : " + scoreValue;   
        }
    }
}
