using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Player player;

    private Animator _animator;
    private const string IS_WALKING = "IsWalking";

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         _animator.SetBool(IS_WALKING, player.IsWalking());
    }
}
