using UnityEngine;

public class SmoothCameraScript : MonoBehaviour
{
    [SerializeField] private Vector3 offset;

    [SerializeField] private float damping;
    
    public Transform target;
    private Vector3 vel= Vector3.zero;
    private void FixedUpdate() {
            Vector3 targetPosition = target.position + offset;
        targetPosition.z = transform.position.z;
        
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref vel, damping);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
