using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CelebrationState : State
{
    [SerializeField] private string _nameCelebrationAnimation;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _animator.Play(_nameCelebrationAnimation);
    }

    private void OnDisable()
    {
        _animator.StopPlayback();
    }
}
