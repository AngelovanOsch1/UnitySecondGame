using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float velocity = 2.4f;
    public float moveSpeed = 5;
    private new Rigidbody2D rigidbody;

    public GameObject killWhenNotOnScreen;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = Vector2.up * velocity;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;

        }
    }

    public void OnBecameInvisible()
    {
        Destroy(killWhenNotOnScreen);
        SceneManager.LoadScene(0);
    }
}