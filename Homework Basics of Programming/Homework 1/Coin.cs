using UnityEngine;

public class Coin : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(-180, 0, 0) * Time.deltaTime);
    }
}
