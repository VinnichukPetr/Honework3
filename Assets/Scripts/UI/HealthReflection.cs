using System.Collections.Generic;
using Player;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class HealthReflection : MonoBehaviour
    {
        [Header("Player")]
        [SerializeField] private PlayerModel player;

        [Header("Sprite")] 
        [SerializeField] private Image heartImage;

        private List<Image> _heartImages;

        private void Start()
        {
            _heartImages = new List<Image>();
            var position = transform.position;
            
            for (var i = 0; i < player.MaxHealth; i++)
            {
                var heart = Instantiate(heartImage, position, Quaternion.identity, transform);
                
                _heartImages.Add(heart);
                position.x -= 25;
            }
        }

        private void OnEnable() => player.HealthChanged += OnHealthChange;
        private void OnDisable() => player.HealthChanged -= OnHealthChange;

        private void OnHealthChange()
        {
            var heart = _heartImages[^1];
            _heartImages.Remove(heart);
            Destroy(heart);
        }
    }

}