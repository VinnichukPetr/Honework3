using UnityEngine;
using UnityEngine.Events;

namespace Player
{
    public class PlayerModel : MonoBehaviour
    {
        [Header("Heat Point")]
        [SerializeField] private int maxHealth = 3;
        [SerializeField] private int health = 3;
        
        [Header("Speed")]
        [SerializeField] private float speed = 1f;
        [SerializeField] private float rotationSpeed = 70f; 
        [SerializeField] private float acceleration = 1.2f;

        public int Health
        {
            get => health;
            set
            {
                if (value > maxHealth || value < 0) return;
                
                health = value;
                HealthChanged?.Invoke();
            }
        }
        public int MaxHealth => maxHealth;
        public float Sped => speed;
        public float RotationSpeed => rotationSpeed;
        public float Acceleration => acceleration;

        public event UnityAction HealthChanged;
    }
}