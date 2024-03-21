using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballHoop : MonoBehaviour
{
    SportsBall _currentBall;

    public SportsBall GetCurrentBall => _currentBall;

    private void OnTriggerEnter(Collider other)
    {
        other.TryGetComponent<SportsBall>(out _currentBall);
    }

}
