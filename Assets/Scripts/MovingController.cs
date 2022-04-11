using System.Collections;
using UnityEngine;

public class MovingController : MonoBehaviour
{
    [SerializeField] private string _forwardAnimName = "Forward";
    [SerializeField] private string _sideAnimName = "Side";
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnAnimatorMove()
    {
        transform.position += _animator.deltaPosition;
    }

    private void Update()
    {
        _animator.SetFloat(_forwardAnimName, Input.GetAxis("Vertical"));
        _animator.SetFloat(_sideAnimName, Input.GetAxis("Horizontal"));
    }
}