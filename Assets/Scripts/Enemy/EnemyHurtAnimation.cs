using UnityEngine;

public class EnemyHurtAnimation : MonoBehaviour
{
    private readonly int Hurt = Animator.StringToHash(nameof(Hurt));
    
    [SerializeField] private Animator _animator;
    [SerializeField] private Enemy _enemy;

    private void OnEnable()
    {
        _enemy.Hurt += SetAnimationHurt;
    }

    private void OnDisable()
    {
        _enemy.Hurt -= SetAnimationHurt;
    }

    private void SetAnimationHurt()
    {
        _animator.SetTrigger(Hurt);
    }
}
