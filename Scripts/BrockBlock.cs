using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrockBlock : MonoBehaviour
{
    [SerializeField] Sprite brockImage;
    int count = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            count++;

            if (count == 1)
            {
                GetComponent<SpriteRenderer>().sprite = brockImage;
            }
            else if (count == 2)
            {
                Destroy(gameObject);
            }
            
          
        }
    }
}
