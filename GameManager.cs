using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState{
    login, 
    menu, 
    inGame,
    gameOver
}

public class GameManager : MonoBehaviour
{
    public GameState currentGameState = GameState.login;

    //Singleton
    public static GameManager  sharedInstance;


    void Awake()
    {
        if (sharedInstance == null){
            sharedInstance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Login()
    {

    }
    //Metodo de inicio del Juego
    public void StartGame()
    {

    }

    //Método de fin del Juego
    public void GameOver()
    {

    }

    //Método de Regreso al Menú
    public void BackToMenu(){
        
    }

    private void SetGameState(GameState newGameState)
    {
        if(newGameState == GameState.login){
            //Todo: colocar la lógica del login
        }
        if (newGameState == GameState.menu){
            //TODO: colocar la lógica del menú
        }
        else if(newGameState == GameState.inGame){
            //TODO: hay que preparar la escena para jugar
        }
        else if(newGameState == GameState.gameOver){
            //TODO: preparar el juego para el Game Over
        }

        this.currentGameState = newGameState;
    }
}
