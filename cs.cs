using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    // Variáveis
    float health;
    int speed = 300;
    string x = "xis";
    bool isDead = false;
 EnemyWeapon weapon
    // Função de ataque
    void Attack()
    {
        // Implemente a lógica de ataque aqui
        weapon.shoot()
    }

    // Função de movimento
    void Movement()
    {
        if (speed >= 0 && health > 0)
        {
            // Implemente a lógica de movimento aqui
        }
    }

    // Array
    int[] intArray = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    
    // Lista
    List<int> intList = new List<int>(){1, 2, 3, 4, 5, 6,7,8,9,};

    // Função para alterar a lista
    void ModifyList()
    {
        intList.Add(3);
        intList.Remove(1);
    }
    
void MovimentoEx{
    foreach (int intNumbers in intList)
    {
        
    }
    for (int i = 0; i < intArray.length; i++)
    {
        int currentNumber = intArray[i]
    }
    //não existe length dentro do intList usa (Count)
}
}
public class EnemyWeapon
{
    public float damage;
        public float FireRate;
// Escopo global com public
    void Shoot()
    {

    }
}
