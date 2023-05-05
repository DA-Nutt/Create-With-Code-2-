using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30.0f;
    public float bottomBound = -10.0f;

    private void Update() {
        if(transform.position.z > topBound || transform.position.z < bottomBound) {
            Destroy(gameObject);
        }
    }

    
}
