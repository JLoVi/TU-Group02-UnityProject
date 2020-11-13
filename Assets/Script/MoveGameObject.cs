using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGameObject : MonoBehaviour
{

    public float movementTime;

    public float speed;

    public bool moving;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        moving = false;

        StartCoroutine(MovementTimer());
    }

    // Update is called once per frame
    void Update()
    {
        if(moving)
        {
            transform.Translate(player.transform.rotation * Vector3.forward * Time.deltaTime * speed);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        moving = true;
    }

    public IEnumerator MovementTimer()
    {
        yield return new WaitForSeconds(movementTime);

        moving = false;
    }
}
