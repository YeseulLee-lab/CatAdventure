using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] private FallDetector fallDetector;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioManager.instance.PlaySound("stage_clear_01");
        if (collision.gameObject.name == "player")
        {
            fallDetector.CheckPoint = gameObject.transform;
            //animator.SetTrigger("Move");
        }
    }
}
