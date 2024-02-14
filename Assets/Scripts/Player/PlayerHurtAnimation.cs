using UnityEngine;

public class PlayerHurtAnimation : MonoBehaviour
{
    private readonly int Hurt = Animator.StringToHash(nameof(Hurt));

    [SerializeField] private Animator _animator;
    [SerializeField] private Player player;

    private void OnEnable()
    {
        player.Hurt += SetAnimationHurt;
    }

    private void OnDisable()
    {
        player.Hurt -= SetAnimationHurt;
    }

    private void SetAnimationHurt()
    {
        _animator.SetTrigger(Hurt);
    }
}
