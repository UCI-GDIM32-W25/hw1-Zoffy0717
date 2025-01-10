using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _playerTransform.Translate(Vector3.left * _speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
        }
        PlantSeed();
        _plantCountUI.UpdateSeeds(_numSeedsPlanted, _numSeeds);
    }

    public void PlantSeed ()
    {
            if(Input.GetKeyDown(KeyCode.Space) && _numSeeds > 0)
            {
                Instantiate(_plantPrefab,_playerTransform.position, _playerTransform.rotation);
                
                _numSeeds--;
                _numSeedsPlanted++;
            }
        
    }
}
