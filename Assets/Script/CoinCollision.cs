using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour {

    // Handle collision of coin with other objects
    private void OnCollisionEnter(Collision other)
    {
        // Simply destroy coin without evoking a function if floor is hit
        if(other.gameObject.tag == "Floor")
        {
            Destroy(this.gameObject);
        }

        // Evoke functions depending on which kind of coin hit the player 
       else if(other.gameObject.tag == "Player") 
        {
            if(this.gameObject.name == "CoinFly(Clone)") // When picking up the fly
            {
                GameObject.Find("GameSystem").GetComponent<GameSystem>().score = 0;
                GameObject.Find("GameSystem").GetComponent<GameSystem>().setScore(0);
                FindObjectOfType<AudioManager>().Play("FlySound");
                Destroy(this.gameObject);
            }
            else if(this.gameObject.name == "CoinHeart(Clone)") // When picking up the heart
            {
                GameObject.Find("Main Camera").GetComponent<ppcManager>().CoinHeartSetMode();
                FindObjectOfType<AudioManager>().Play("HeartSound");
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "CoinBomb(Clone)") // When picking up the bomb
            {
                GameObject[] existingPPCs = GameObject.FindGameObjectsWithTag("PPC");
                foreach(GameObject existingPPC in existingPPCs)
                {
                    Destroy(existingPPC);
                }
                FindObjectOfType<AudioManager>().Play("BombSound");
                Destroy(this.gameObject);
            }
            else if (this.gameObject.name == "CoinClock(Clone)") // When picking up the clock
            {
                GameObject.Find("Main Camera").GetComponent<ppcManager>().CoinClockSetMode();
                FindObjectOfType<AudioManager>().Play("ClockSound");
                Destroy(this.gameObject);
            }
            else
            {
                Debug.Log("Random coin hit player");
            }
        }

        // This is added so nothing happens if the coin hits popcorn objects while falling
        else
        {
            return;
        }
    } 

}
