using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCounter : MonoBehaviour
{
    private static int moneyCount = 0;

    private float leftBound = -10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoneyCount();
    }

    private void MoneyCount()
    {
        if (transform.position.x < leftBound)
        {
            moneyCount += 1;
            Debug.Log("moneyCount");
            Destroy(gameObject);
            
        }

        if (moneyCount > 3)
        {
            PlayerControllerX.gameOver = true;
            Debug.Log("Game Over");
        }
    }
}
