using UnityEngine;

public class Placement : MonoBehaviour
{
    private BuildingSystem _buildtngSystem;
    private GameObject _currentPrefab;
    private void Start()
    {
        _buildtngSystem = BuildingSystem.Current;
    }
    
    private void OnMouseDown()
    {
        _currentPrefab = _buildtngSystem.CurrentPrefab;
        _buildtngSystem.InizializeGameObject(_currentPrefab, gameObject.transform.position);
        Destroy(gameObject);
    }
}