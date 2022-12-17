using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionDetection : MonoBehaviour
{

    [SerializeField] new Camera camera;

    [SerializeField] GameObject player;
    
    [SerializeField] Animator playerAnim;

    [SerializeField] PlayerMoving playerMoving;
    public delegate void Impact(float speed);
    public event Impact Stop;


    // public bool throwPizza = true;
    // when collides with obstacle
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            transform.GetComponent<Rigidbody>().AddForce((transform.position- collision.gameObject.transform.position), ForceMode.Impulse);
            camera.transform.parent = null;
            Stop?.Invoke(0);
            StartCoroutine(RestartGame());
        }
    }
    
    // restart game
    IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);

    }

}
