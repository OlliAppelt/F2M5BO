using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private TowerbuildMenuUI _buildUI;
    [SerializeField] private LayerMask _layer;
    private Tile _selectedTile = null;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && _selectedTile == null)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, _layer))
            {
                Tile tile = hit.transform.gameObject.GetComponent<Tile>();
                Debug.Log(hit.transform.gameObject);
                // if (tile.HasTower)
                // {
                //     _selectedTile = tile;
                //     _buildUI.Show(true);
                //     print("Select Tile!");
                // }

                // else
                // {
                //
                // }

                _selectedTile = tile;
                Debug.Log(_selectedTile);
                _buildUI.Show(true);
                print("Select Tile!");
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _selectedTile != null)
        {
            _selectedTile = null;
            _buildUI.Show(false);
            print("Deselect Tile!");
        }
    }

    public void BuildTower(FollowRotation tower)
    {
        if (_selectedTile.HasTower)
        {
            print("Tile already has tower!");
            return;
        }

        Vector3 spawnPosition = new Vector3(_selectedTile.transform.position.x, 0.08f, _selectedTile.transform.position.z);
        Instantiate(tower, spawnPosition, Quaternion.identity, transform);

        _selectedTile.HasTower = true;
    }
    public void BuildLaserTower(LaserTower tower2)
    {
        if (_selectedTile.HasTower)
        {
            print("Tile already has tower!");
            return;
        }

        Vector3 spawnPosition = new Vector3(_selectedTile.transform.position.x, 0.08f, _selectedTile.transform.position.z);
        Instantiate(tower2, spawnPosition, Quaternion.identity, transform);

        _selectedTile.HasTower = true;
    }
    public void DefenseWall(DefenseWall tower3)
    {
        Debug.Log(_selectedTile);
        if (_selectedTile.HasTower)
        {
            print("Tile already has tower!");
            return;
        }

        Vector3 spawnPosition = new Vector3(_selectedTile.transform.position.x, 0.08f, _selectedTile.transform.position.z);
        Instantiate(tower3, spawnPosition, Quaternion.identity, transform);

        _selectedTile.HasTower = true;
    }
}
