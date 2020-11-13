using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformGamesObject : MonoBehaviour
{

    public GameObject replacementObject;

    public float transformationTime;

    // Start is called before the first frame update
    void Start()
    {
        replacementObject.SetActive(false);

        StartCoroutine(TransformationCountdown());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator TransformationCountdown()
    {
        yield return new WaitForSeconds(transformationTime);

        replacementObject.SetActive(true);

        this.gameObject.SetActive(false);

    }
}
