using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(TankController))]
public class Player : MonoBehaviour
{
    public int totalTreasure = 0;

    [SerializeField] int _maxHealth = 3;
    int _currentHealth;

    public bool isInvincible = false;

    TankController _tankController;

    [SerializeField] Text _treasureAmountText;

    public Material bodyMaterial;

    private void Awake()
    {
        _tankController = GetComponent<TankController>();
    }

    
    void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void IncreaseHealth(int amount)
    {
        _currentHealth += amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
        Debug.Log("Player's health: " + _currentHealth);
    }

    public void DecreaseHealth(int amount)
    {
        if(isInvincible == false)
        {
            _currentHealth -= amount;
            Debug.Log("Player's health: " + _currentHealth);
            if (_currentHealth <= 0)
            {
                Kill();
            }
        }
    }

    public void Kill()
    {
        if(isInvincible == false)
        {
            gameObject.SetActive(false);
        }
        
        //play particles
        // play sounds
    }

    public void IncreaseTreasure(int amount)
    {
        totalTreasure += amount;
        _treasureAmountText.text = "Treasure: " + totalTreasure;
    }
}
