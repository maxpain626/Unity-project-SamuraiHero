using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySkeletonDie : MonoBehaviour
{
    public GameObject coinsOnDestroy;
    public float delay = 0f;
    private Animator animator;

    [SerializeField] AudioSource dieSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator = GetComponent<Animator>();

        if (collision.gameObject.tag == "Player")
        {
            animator.SetTrigger("dieSkeleton");
            Destroy(this.gameObject.GetComponent<BoxCollider2D>());
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
            dieSound.Play();
            GameObject newObject = Instantiate(coinsOnDestroy, gameObject.GetComponent<Transform>().position, Quaternion.identity) as GameObject;
        }
        else if (collision.gameObject.tag == "Suriken")
        {
            animator.SetTrigger("dieSkeleton");
            Destroy(this.gameObject.GetComponent<BoxCollider2D>());
            Destroy(this.gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
            dieSound.Play();
            GameObject newObject = Instantiate(coinsOnDestroy, gameObject.GetComponent<Transform>().position, Quaternion.identity) as GameObject;
        }
        else if (collision.gameObject.tag == "Ground")
        {
            animator.SetTrigger("dieSkeleton");
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
            dieSound.Play();
            Debug.Log("Booom!");
        }
    }
}
