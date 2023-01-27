using UnityEngine;

namespace Player
{
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private PlayerModel player;
        
        private void FixedUpdate()
        {
            var horizontal = Input.GetAxis("Horizontal") * player.RotationSpeed * Time.fixedDeltaTime;
            var vertical = Input.GetAxis("Vertical") * player.Sped * Time.fixedDeltaTime;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                horizontal = player.Acceleration * horizontal;
                vertical = player.Acceleration * vertical;
            }

            transform.Translate(0f, 0f, vertical);
            transform.Rotate(0f, horizontal, 0f);
        }
    }
}