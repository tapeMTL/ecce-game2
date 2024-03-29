﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square
{
    public Piece piece;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    List<Observer> observers = new List<Observer>();

    //Send notifications if something has happened
    public void Notify()
    {
        for (int i = 0; i < observers.Count; i++)
        {
            //Notify all observers even though some may not be interested in what has happened
            //Each observer should check if it is interested in this event
            observers[i].OnNotify();
        }
    }

    //Add observer to the list
    public void AddObserver(Observer observer)
    {
        observers.Add(observer);
    }

    //Remove observer from the list
    public void RemoveObserver(Observer observer)
    {
    }
}
