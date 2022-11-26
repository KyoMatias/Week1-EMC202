using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
//  BaseCar.cs
//  Base Car Script
//
//  Created by Kyo Matias on 11/26/2022.
//  Copyright © 2022 Kyo Matias. All rights reserved.
//

public class BaseCar : MonoBehaviour
{
    //create the components of the base car
    //Complete with base name and model.
    //create the type and category
    
    /*
     * The Base Components of Base Car.
     */
    protected string _name;//Car Name and Model.
    protected int _rating;//Car Rating based on tune.
    protected float _horsePower;// Car base horsepower.
    protected float _turbo;// Car boost based on Turbo Multiplier.
    protected float _baseSpeed;// Car Base Speed.
    protected int _level;//Car Mods Level.
    protected string _type;

    /*
     * Extra Components that are optional/Unlockable tunes.
     */
    public int NitrousLevel = 0;
    public int EngineTune = 0;// Engine Level
    public int ECUTune = 0;// ECU Level
    public int BrakeTune = 0;// Brake Level
    public int TireTune = 0;// Tire Level
    public int TurboTune = 0;// Turbo Level
    public int TransmissionTune = 0;// Transmission Level
    public int SuspensionTune = 0;// Suspension Tune
    
    /*
     * Tune Computations
     */
    public float Transmission => _baseSpeed * TransmissionTune;
    public float Nitrous => _baseSpeed + (_horsePower * NitrousLevel);// Nitrous Multiplier
    public float Turbo => _baseSpeed * _turbo;// Turbo Multiplier
    public int Rating => EngineTune + ECUTune + BrakeTune + TireTune + TurboTune + TransmissionTune + SuspensionTune + NitrousLevel / 8;// Rating Computation.
    public int Level => EngineTune + ECUTune + BrakeTune + TireTune + TurboTune + TransmissionTune + SuspensionTune + NitrousLevel;
    public BaseCar(string name = "DefaultCar", int rating = 0, float hp = 100, int lvl = 1, string type = "Null")//Creating parameters for the BaseCar Class.
    {
     //some basic debug properties
     this._name = name;//name 
     this._rating = rating;//rating
     this._horsePower = hp;//horsepower
     this._level = lvl;//level
     this._type = type;
    }

    public string GetCarStats()//calls the car stats
    {
     var alpha = _name + _rating + _horsePower + _level;
     var properties =
      $"{nameof(_name)}:{_name}, {nameof(_rating)}:{_rating},{nameof(_horsePower)}:{_horsePower},{nameof(_level)}:{_level},{nameof(_type)}:{_type}";

     return properties;
    }
}


