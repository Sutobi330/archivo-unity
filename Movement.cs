using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //NPC Health
    public int health = 7;

    //NPC Level
    public int level = 3;

    //NPC Speed
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        int paco = this.health + this.level;
        print(paco);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

        newPosition.z += speed * Time.deltaTime;

        transform.position = newPosition;
    }
}
