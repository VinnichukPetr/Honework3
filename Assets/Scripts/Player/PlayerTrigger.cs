using Bomb;
using Coin;
using UI;
using UnityEngine;

namespace Player
{
    public class PlayerTrigger: MonoBehaviour
    {
        [SerializeField] private PlayerModel player;
        [SerializeField]private CoinsReflection coinsReflection;
        
        private int _coinCounter = 0;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out CoinPrefab coin))
            { 
                coinsReflection.OnUpdateCoins(++_coinCounter);
                Destroy(coin.gameObject);
            }
            else if(other.TryGetComponent(out BombPrefab bomb))
            {
                player.Health--;
                Destroy(bomb.gameObject);
            }
        }
    }
}