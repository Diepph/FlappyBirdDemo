using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Animationpipe : MonoBehaviour
{
    public AnimationCurve myCurve;
    // Start is called before the first frame update
    void Start()
    {
        myCurve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 3));
        myCurve.preWrapMode = WrapMode.PingPong;
        myCurve.postWrapMode = WrapMode.PingPong;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, myCurve.Evaluate((Time.time % myCurve.length)), transform.position.z);
    }
}
