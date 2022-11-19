using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Novice : MonoBehaviour
{
    protected float _experience;
    protected string _name;
    protected float _baseHealth;
    protected float _vitality;
    protected float _agility;
    protected float _power;

    public float MaxHealth => _baseHealth + (_vitality * 3);

    public int Level => Mathf.RoundToInt(_experience / 1000);

    public string Name
    {
        get => _name;
        set => _name = string.IsNullOrEmpty(value) ? "George" : value;
    }

    public Novice(string name = "Steve", float baseHealth = 100, float experience = 100)
    {
        _experience = experience;
        _name = name;
        _baseHealth = baseHealth;
    }

    public string GetProperties()
    {
        var alphabet = _name + _experience + _baseHealth;
        var properties = $"{nameof(_experience)}:{_experience},{nameof(_name)}:{_name},{nameof(_baseHealth)}:{_baseHealth}";

        return properties;
    }
}
