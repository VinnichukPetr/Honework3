using TMPro;
using UnityEngine;

namespace UI
{
    public class CoinsReflection : MonoBehaviour
    {
        [SerializeField] private TMP_Text coinsText;
        
        public void OnUpdateCoins(int coins)
        {
            coinsText.text = coins.ToString();
        }
    }
}