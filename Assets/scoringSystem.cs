using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoringSystem : MonoBehaviour
{
    public float points;
    public Text scoreText;
    public AudioSource collectSound;
    public Text IR;
    
    
      private void OnTriggerEnter(Collider other) {
   
    if(other.gameObject.tag == "Bake")
    {
       points = points + 10;
       Destroy(other.gameObject);
    }
   else if(other.gameObject.tag == "Bake2")
    {
       points = points + 20;
       Destroy(other.gameObject);
    }
    else if(other.gameObject.tag == "Bake3")
    {
       points = points + 30;
       Destroy(other.gameObject);
       IR.text = "Hey, Congratz! You have got my favourite, Ice Cream:)";
    }

    scoreText.text = "Score : " + points;
    collectSound.Play();

    if(scoreText.text == "Score : 100")
    {
      scoreText.text = "Score : 100 ~ Yay! You scored full points. Let's cheer up! Enjoy roaming around now though.";
    }

} 
    }

