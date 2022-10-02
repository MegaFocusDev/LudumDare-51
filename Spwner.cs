using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spwner : MonoBehaviour
{
    public GameObject player;
    private bool countdownS;
    private float coundon;
    private Rigidbody2D rb;
    public PlayerMovement pm;
    public TMP_Text countdownText; public Audiomanager audiomanager;
    public IEnumerator count()
    {
        coundon = 11;
        while (countdownS)
        {
            coundon--;
            if(coundon > 0)
            {
                countdownText.text = coundon.ToString(""); yield return new WaitForSeconds(1f);
            }
            else
            {
                countdownS = false;
                player.transform.position = new Vector2(transform.position.x, transform.position.y + 1); audiomanager.Play("Spawn");
                if (rb.gravityScale < 0) pm.gravityChange();
                countdownText.text = "10";
            }
            
        }
        
    }
    void Start()
    {
        countdownS = false;
        player.transform.position = new Vector2(transform.position.x, transform.position.y + 1);
        rb = player.GetComponent<Rigidbody2D>();
        audiomanager = FindObjectOfType<Audiomanager>();
    }

    void Update()
    {if(!(player.transform.position == new Vector3(transform.position.x, transform.position.y + 1, player.transform.position.z)) && countdownS == false)
        {
            countdownS = true; StartCoroutine(count());
        }
        
    }
}
