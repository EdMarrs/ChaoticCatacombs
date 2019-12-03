using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth
{
    public event EventHandler onDamaged;            // sets the event handling for damage
    public event EventHandler onDead;               // sets the event handling for death
    private List<Heart> heartList;                  // sets the list of heart objects


    /**** sets the player health, passes # of hearts ****/
    public playerHealth(int heartAmount)
    {

        heartList = new List<Heart>();          // creates a new list of hearts

        /*** for the # of hearts, increment ***/
        for (int i = 0; i < heartAmount; i++)
        {

            Heart heart = new Heart(4);         // adds 4 new hearts

            heartList.Add(heart);               // adds hearts to the list
        }

        heartList[heartList.Count - 1].setFragments(0);     // sets the list to be decremented by the fragments
    }
    /**** gets the list of hearts ****/
    public List<Heart> getHeartsList()
    {

        return heartList;
    }
    /**** sets the damage, passes damage amount ****/
    public void damage(int damageAmount)
    {

        /** cycles through the hearts, starting from the end **/
        for (int i = heartList.Count - 1; i >= 0; i--)
        {

            Heart heart = heartList[i];

            /** test if the heart can absorb the damageAmount
             * if the heart can't absorb full damageAmount, damage the heart and go to the next heart
             * else the heart can absorb full damage, absorb and break the cycle
            **/
            if (damageAmount > heart.getFragmentAmount())
            {
                damageAmount -= heart.getFragmentAmount();
                heart.damage(heart.getFragmentAmount());
            } else
            {

                heart.damage(damageAmount);
                break;
            }
        }
        /** if the damage is null, set the damage to be empty **/
        if (onDamaged != null)
        {

            onDamaged(this, EventArgs.Empty);
        }
        /** if the player is dead, check **/
        if (isDead())
        {

            /** if the death is null, set the death to empty **/
            if (onDead != null)
            {

                onDead(this, EventArgs.Empty);
            }
        }
    }
    /**** sets player to be dead when hearts are at 0 ****/
    public bool isDead()
    {

        return heartList[0].getFragmentAmount() == 0;
    }
    /***** INNER CLASS
     * Represents a single heart 
    *****/
    public class Heart
    {

        private int fragments;              // sets fragments for heart        


        /**** constuctor for hearts, passes fragments ****/
        public Heart(int fragments)
        {

            this.fragments = fragments;     // set fragments equal to itself
        }
        /**** gets the fragment amount ****/
        public int getFragmentAmount()
        {

            return fragments;
        }
        /**** sets the fragment amount, passes fragments ****/
        public void setFragments(int fragments)
        {
            this.fragments = fragments;
        }
        /**** sets damage amount ****/
        public void damage(int damageAmount)
        {

            /** if the damage amount is greater than or equal to the fragments, set fragments equal to 0
             * else if, decrement the fragments by the damage amount
            **/
            if (damageAmount >= fragments)
            {
                fragments = 0;
            } else
            {
                fragments -= damageAmount;
            }
        }
    }
}
