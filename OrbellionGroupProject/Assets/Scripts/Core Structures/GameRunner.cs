using System;
using UnityEngine;

public class GameRunner : MonoBehaviour
{
    public Player player1;
    public Player player2;
    public Player firstPlayer;
    private Player currentPlayer;
    public int startingHand;
    public int startingEnergy;
    private bool firstTurn;
    public static event Action OnUpkeepPhase;
    public static event Action OnEndPhase;

    public void Start()
    {
       // startGame();
    }

    private void Update()
    {
        // Left for inputs, Game logic, etc.
    }

    private void startGame()
    {
        player1.deck.shuffle();
        player2.deck.shuffle();

        player1.baseEnergy = startingEnergy;
        player2.baseEnergy = startingEnergy;

        for (int i = 0; i < startingHand; i++)
        {
            player1.draw();
            player2.draw();
        }

        if(firstPlayer == null)
        {
            firstPlayer = player1;
        }
        firstTurn = true;
        nextTurn();
    }

    private void nextTurn()
    {
        if(currentPlayer == null)
        {
            currentPlayer = firstPlayer;
        } else
        {
            currentPlayer = currentPlayer.opponent;
        }

        switch (currentPlayer.team.getNumAlive())
        {
            case 3:
                currentPlayer.maxEnergy = 6;
                break;
            case 2:
                currentPlayer.maxEnergy = 8;
                break;
            case 1:
                currentPlayer.maxEnergy = 10;
                break;
        }
        if (!firstTurn)
        {
            if (currentPlayer.baseEnergy < currentPlayer.maxEnergy)
            {
                currentPlayer.baseEnergy++;
            }
        }
        currentPlayer.currentEnergy = currentPlayer.baseEnergy;

        upkeepPhase();
    }

    private void upkeepPhase()
    {
        OnUpkeepPhase?.Invoke();
        if (!firstTurn)
        {
            currentPlayer.draw();
        }
        playPhase();
    }

    private void playPhase()
    {

        endPhase();
    }

    private void endPhase()
    {
        OnEndPhase?.Invoke();
        nextTurn();
    }
}
