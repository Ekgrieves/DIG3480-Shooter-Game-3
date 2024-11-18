using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{

    public int myType;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(myType == 1)
        {
            //bullet
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * 8f);
        }
        else if(myType == 2)
        {
            //enemy
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 4f);
        }
        else if (myType == 3)
        {
            //cloud
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * Random.Range(3f, 6f) * gameManager.cloudSpeed);
        }
        else if (myType == 4)
        {
            //Powerup
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 6f);
        }

        if ((transform.position .y > 9f || transform .position .y <= -9f) && myType != 3)
        {
            Destroy(this.gameObject);
        }
        else if ((transform.position.y <= -9f && myType == 3))
        {
            transform.position = new Vector3(Random.Range(-10f, 10f), 9f, 0);
        }
    }
}
