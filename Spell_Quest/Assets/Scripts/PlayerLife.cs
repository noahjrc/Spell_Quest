using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public interface ICommand
{
    void Execute();
}

public class PlayerLife : MonoBehaviour, ICommand
{

    private Animator anim;
    private Rigidbody2D rb;

    [SerializeField] private AudioSource DeathSoundEffect;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.CompareTag("Trap"))
        {
            Die();

        }
    }

    private void Die()
    {
        anim.SetTrigger("death");
        rb.bodyType = RigidbodyType2D.Static;
        DeathSoundEffect.Play();
        Invoke("Execute", 1.3f);

    }

    public void Execute()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
