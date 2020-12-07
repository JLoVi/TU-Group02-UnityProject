using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGameObject : MonoBehaviour
{

    public float movementTime;

    public float speed;

    public bool moving;

    public GameObject player;

    public bool borderSwitch;

    // Start is called before the first frame update
    void Start()
    {
        moving = false;
        borderSwitch = false;

        StartCoroutine(MovementTimer());
    }

    // Update is called once per frame
    void Update()
    {
        if(moving)
        {

            if (borderSwitch) { 
            // transform.Translate(player.transform.rotation * Vector3.forward * Time.deltaTime * speed);

                transform.Translate(Vector3.forward * Time.deltaTime * speed);

            }

            if (!borderSwitch)
            {
                transform.Translate(Vector3.back * Time.deltaTime * speed);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        moving = true;

        StartCoroutine(BorderSwitchTimer());
    }

    public IEnumerator MovementTimer()
    {
        yield return new WaitForSeconds(movementTime);

        moving = false;
    }


    public IEnumerator BorderSwitchTimer()
    {
        yield return new WaitForSeconds(5f);

        borderSwitch = !borderSwitch;
    }
}
