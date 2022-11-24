Console.Clear();
Console.WriteLine("Player 1. Please choose a character! pirate[1] stone chewer[2] ghost warrior[3] outworlder[4] monster knight[5] dark goblin[6]");
int player1 = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Player 2. Please choose a character! pirate[1] stone chewer[2] ghost warrior[3] outworlder[4] monster knight[5] dark goblin[6]");
int player2 = int.Parse(Console.ReadLine()!);
Console.Clear();

double health1 = 0;
int attack1 = 0;
int speed1 = 0;
int amor1 = 0;

double health2 = 0;
int attack2 = 0;
int speed2 = 0;
int amor2 = 0;

const int pirate = 1;
const int pirate_health = 20;
const int pirate_attack = 3;
const int pirate_speed = 3;
const int pirate_amor = 3;

const int stone = 2;
const int stone_health = 50;
const int stone_attack = 8;
const int stone_speed = 1;
const int stone_amor = 10;

const int ghost = 3;
const int ghost_health = 20;
const int ghost_attack = 2;
const int ghost_speed = 5;
const int ghost_amor = 2;

const int outworlder = 4;
const int out_health = 15;
const int out_attack = 1;
const int out_speed = 10;
const int out_amor = 2;

const int monster = 5;
const int monster_health = 15;
const int monster_attack = 4;
const int monster_speed = 3;
const int monster_amor = 3;

const int goblin = 6;
const int goblin_health = 10;
const int goblin_attack = 1;
const int goblin_speed = 3;
const int goblin_amor = 8;

switch (player1)
{
    case pirate:
        health1 += pirate_health;
        attack1 += pirate_attack;
        speed1 += pirate_speed;
        amor1 += pirate_amor;
        break;
    case stone:
        health1 += stone_health;
        attack1 += stone_attack;
        speed1 += stone_speed;
        amor1 += stone_amor;
        break;
    case ghost:
        health1 += ghost_health;
        attack1 += ghost_attack;
        speed1 += ghost_speed;
        amor1 += ghost_amor;
        break;
    case outworlder:
        health1 += out_health;
        attack1 += out_attack;
        speed1 += out_speed;
        amor1 += out_amor;
        break;
    case monster:
        health1 += monster_health;
        attack1 += monster_attack;
        speed1 += monster_speed;
        amor1 += monster_amor;
        break;
    case goblin:
        health1 += goblin_health;
        attack1 += goblin_attack;
        speed1 += goblin_speed;
        amor1 += goblin_amor;
        break;
}
switch (player2)
{
    case pirate:
        health2 += pirate_health;
        attack2 += pirate_attack;
        speed2 += pirate_speed;
        amor2 += pirate_amor;
        break;
    case stone:
        health2 += stone_health;
        attack2 += stone_attack;
        speed2 += stone_speed;
        amor2 += stone_amor;
        break;
    case ghost:
        health2 += ghost_health;
        attack2 += ghost_attack;
        speed2 += ghost_speed;
        amor2 += ghost_amor;
        break;
    case outworlder:
        health2 += out_health;
        attack2 += out_attack;
        speed2 += out_speed;
        amor2 += out_amor;
        break;
    case monster:
        health2 += monster_health;
        attack2 += monster_attack;
        speed2 += monster_speed;
        amor2 += monster_amor;
        break;
    case goblin:
        health2 += goblin_health;
        attack2 += goblin_attack;
        speed2 += goblin_speed;
        amor2 += goblin_amor;
        break;
}
//int round = 0;
health1 = health1 + amor1;
health2 = health2 + amor2;

while (health1 > 0 && health2 > 0)
{
    for (int i = 0; i < speed2; i++)
    {
        double p = Random.Shared.Next(85, 116) / 100d;
        double new_attack2 = attack2 * p;
        health1 -= new_attack2;
        Console.WriteLine("Health player 1: " + health1);
    }

    for (int j = 0; j < speed1; j++)
    {
        double p = Random.Shared.Next(85, 116) / 100d;
        double new_attack1 = attack1 * p;
        health2 -= new_attack1;
        Console.WriteLine("Health player 2: " + health2);
    }
}

if (health1 > 0)
{
    Console.WriteLine("Player 1 won the game with {0} health points", health1);
}
else if (health2 > 0)
{
    Console.WriteLine("Player 2 won the game with {0} health points", health2);
}
else
{
    Console.WriteLine("Nobody won");
}

