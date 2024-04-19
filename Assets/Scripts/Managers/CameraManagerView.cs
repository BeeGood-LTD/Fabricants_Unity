using UnityEngine;

public class CameraManagerView : MonoBehaviour
{
    private const float CameraSpeed = 100f;

    [SerializeField] private Transform TopAnchorCachedTransform;
    [SerializeField] private Transform BottomAnchorCachedTransform;
    
    private Camera camera;
    private Vector3 startCameraDelta;
    private Vector3 startCameraPosition;

    void Start()
    {
        camera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startCameraDelta = camera.ScreenToViewportPoint(Input.mousePosition);
            startCameraPosition = camera.transform.position;
        }

        if (Input.GetMouseButton(0))
        {
            var mouseDelta = camera.ScreenToViewportPoint(Input.mousePosition) - startCameraDelta;
            
            var mouseResultDeltaX = startCameraPosition.x + mouseDelta.x * CameraSpeed;
            var mouseResultDeltaZ = startCameraPosition.z + mouseDelta.y * CameraSpeed;
            
            CheckBorder(ref mouseResultDeltaX, ref mouseResultDeltaZ);
            
            var mouseResultDelta = new Vector3(mouseResultDeltaX,
                startCameraPosition.y, mouseResultDeltaZ);
            
            camera.transform.position = Vector3.Slerp(camera.transform.position, mouseResultDelta, 4f * Time.deltaTime);
        }
    }

    private void CheckBorder(ref float deltaX, ref float deltaZ)
    {
        if (deltaX <= BottomAnchorCachedTransform.position.x)
        {
            deltaX = BottomAnchorCachedTransform.position.x;
        }

        if (deltaX >= TopAnchorCachedTransform.position.x)
        {
            deltaX = TopAnchorCachedTransform.position.x;
        }

        if (deltaZ <= BottomAnchorCachedTransform.position.z)
        {
            deltaZ = BottomAnchorCachedTransform.position.z;
        }

        if (deltaZ >= TopAnchorCachedTransform.position.z)
        {
            deltaZ = TopAnchorCachedTransform.position.z;
        }
    }
}