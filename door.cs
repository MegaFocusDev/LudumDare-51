using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    public bool isOpen;
    public Animator animator;
    public Animator sceneanimator;
    public float neededCount;
    public string LevelName;
    void Start()
    {
        animator.SetBool("isOpen_", isOpen);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && isOpen)
        {
            StartCoroutine(changeLevel());
        }
    }
    public IEnumerator changeLevel() {
        sceneanimator.SetBool("end", true);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(LevelName);
    }


    // Update is called once per frame
    void Update()
    {
        if (neededCount <= 0) isOpen = true;
        animator.SetBool("isOpen_", isOpen);
    }
}
