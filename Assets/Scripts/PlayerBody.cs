using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBody : MonoBehaviour
{
    [SerializeField] private GameObject _mainCamera;
    [SerializeField] private float _bodyHeight = 0.5f;

    private Vector3 _cameraPosition;
    private Quaternion _cameraRotation;

    // Start is called before the first frame update
    void Start()
    {
        if (_mainCamera == null)
        {
            Debug.LogError("PlayerBody's MainCamera is null!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        _cameraPosition = _mainCamera.transform.position;
        _cameraRotation = _mainCamera.transform.rotation;

        this.transform.position = new Vector3(_cameraPosition.x, _cameraPosition.y * _bodyHeight, _cameraPosition.z);
        this.transform.rotation = new Quaternion(transform.rotation.x, _cameraRotation.y, transform.rotation.z, _cameraRotation.w);
    }
}
