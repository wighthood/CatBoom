using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public void SpeedAddition()// fonction for add a speed when the player chose thespeed bonus
    {
        if ( PlayerController.Instance.m_Speed > 1)
        {
            PlayerController.Instance.m_Speed--; // reduce the speed for the lerp because when you reduce the lerp more speed you have when you have the animation
        } 
    }

    public void RadiusBombAddition()// function for add radius for a explosion more higter in the game when the bomb explode 
    {
        PlayerController.Instance.range += 2;
    }
}
