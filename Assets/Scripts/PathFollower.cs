using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _arrivalThresholds;
    private Path _path;
    private Waypoint _currentWaypoint;

    // Start is called before the first frame update
    void Start()
    {
        SetupPath();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 WaypointPosition = _currentWaypoint.Getposition();
        transform.LookAt(_currentWaypoint.Getposition() + new Vector3(0, transform.position.y, 0));
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        float DistanceToWaypoint = Vector3.Distance(transform.position, WaypointPosition);
        if (DistanceToWaypoint < _arrivalThresholds)
        {
            if (_currentWaypoint == _path.GetPathEnd())
            {
                pathComplete();
            }
            else
            {
                _currentWaypoint = _path.GetNextWaypoint(_currentWaypoint);
                transform.LookAt(_currentWaypoint.Getposition());
            }
        }
    }

    private void SetupPath()
    {
        _path = FindObjectOfType<Path>();
        _currentWaypoint = _path.GetPathStart();
    }

    private void pathComplete()
    {
        Debug.Log("PathComplete");
        Destroy(gameObject);
    }
}