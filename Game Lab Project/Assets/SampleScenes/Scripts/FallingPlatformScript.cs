using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatformScript : MonoBehaviour
{
    public Vector3 startPosition;

    public float fallSpeed;
    public float delay;
    public float respawnTime;

    private bool falling = false;

    private float respawnCounter = 0;

    void Respawn()
    {
        falling = false;
        respawnCounter = 0;
        transform.position = startPosition;
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.collider.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }
    }

    IEnumerator Fall()
    {
        yield return new WaitForSeconds(delay);
        falling = true;
        yield return 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       if (falling)
        {
            transform.Translate(0, -1 * fallSpeed * Time.deltaTime, 0);
            respawnCounter += Time.deltaTime;
            if (respawnCounter >= respawnTime)
            {
                Respawn();
            }
        }
    }
}
