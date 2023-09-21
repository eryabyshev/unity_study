
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _gameMenu;
     
    public void Play()
    {
        _gameMenu.SetActive(false);
    }
   
    
    
}
