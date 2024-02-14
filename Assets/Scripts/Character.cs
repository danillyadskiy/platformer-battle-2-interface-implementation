using System;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public event Action Hurt;
    public event Action Dead;
    
    protected int Health;

    public bool IsAlive { get; private set; } = true;

    public void GetDamage(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            IsAlive = false;
            Dead?.Invoke();
        }
        else
        {
            Hurt?.Invoke();
        }
    }
}
