using UnityEngine;

namespace Defense.Player
{
    public class Player : MonoBehaviour
    {
        public float speed = 10;
    
        void Update()
        {
            var horizontalInput = Input.GetAxis("Horizontal");
            var verticalInput = Input.GetAxis("Vertical");
            var vec = new Vector3(horizontalInput, 0, verticalInput).normalized;
        
            transform.rotation = Quaternion.LookRotation(vec);
            transform.Translate(vec * (Time.deltaTime * speed), Space.World);

        }
    }
}
