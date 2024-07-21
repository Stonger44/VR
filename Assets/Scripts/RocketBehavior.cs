using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBehavior : MonoBehaviour
{
    private const string _player = "Player";
    private const string _rocketLauncher = "RocketLauncher";
    
    [SerializeField] float _speed = 25f;
    [SerializeField] float _timer = 2f;
    [SerializeField] GameObject _explosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyTimer());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }

    IEnumerator DestroyTimer()
    {
        yield return new WaitForSeconds(_timer);
        DestroyThisWithExplosion();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);

        if (!other.CompareTag(_rocketLauncher) && !other.CompareTag(_player))
        {
            DestroyThisWithExplosion();
        }
    }

    void DestroyThisWithExplosion()
    {
        Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
