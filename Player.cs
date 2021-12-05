using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int _health;
    public int Health
    {
        get {
            return _health;
        }
        
        set {
            _health = value;
        }
    }


    private int _power;
    public int Power
    {
        get {
            return _power;
        }
        
        set {
            Power = value;
        }
    }
    private string _name;
    public string Name
    {
        get {
            return _name;
        }
        
        set {
            _name = value;
        }
    }

    public Player() {}
    
    public Player(int health, int power, string name)
    {
        _health = health;
        Power = power;
        Name = name;
    }

    private void Attack () {
        Debug.Log("Attacking " + Name);
    }
    
    public void Info(){
        Debug.Log("Name: " + Name + " Health: " + _health + " Power: " + Power);
    }
}