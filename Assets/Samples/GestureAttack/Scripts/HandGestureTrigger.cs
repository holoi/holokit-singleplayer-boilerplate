using UnityEngine;
using HoloInteractive.XR.HoloKit;
using HoloInteractive.XR.HoloKit.iOS;

public class HandGestureTrigger : MonoBehaviour
{

    [SerializeField] HandGestureRecognitionManager m_HandGestureRecognitionManager;
    [SerializeField] Transform m_HandSampleJoint;
    [SerializeField] Transform m_EyeCenter;
    [SerializeField] GameObject m_FireBall;

    [SerializeField] float speed;

    private void Start()
    {
        // Register the callback
        m_HandGestureRecognitionManager.OnHandGestureChanged += OnHandGestureChanged;
    }

    private void OnHandGestureChanged(HandGesture handGesture)
    {
        // instantiate fire ball
        GameObject go = Instantiate(m_FireBall);

        // calculate velocity
        var direction = m_HandSampleJoint.position - m_EyeCenter.position;
        var velocity = direction.normalized * speed;
        m_FireBall.GetComponent<Rigidbody>().velocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


