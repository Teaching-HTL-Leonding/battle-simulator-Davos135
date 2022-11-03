#region 
const string PIRATE = "p";
const string STONECHEWER = "s";
const string SPIRITWARRIOR = "sp";
const string OFFWORLDERS = " of";
const string MONSTERKNIGHT = "m";
const string DARKGOBLIN = "d";

const int Shealth = 60;
const int Sattack = 8;
const int Sspeed = 1;
const int Samor = 10;

const int SPhealth = 22;
const int SPattack = 2;
const int SPspeed = 5;
const int SPamor = 2;

const int Phealth = 23;
const int Pattack = 3;
const int Pspeed = 3;
const int Pamor = 3;


const int ofhealth = 17;
const int ofattack = 1;
const int ofspeed = 10;
const int ofamor = 2;

const int mhealth = 18;
const int mattack = 4;
const int mspeed = 3;
const int mamor = 3;

const int Dhealth = 18;
const int Dattack = 1;
const int Dspeed = 3;
const int Damor = 8;
#endregion


Console.WriteLine("player 1,which character do you use");
string character1 = Console.ReadLine()!;
Console.WriteLine("player ,which character do you use");
string character2 = Console.ReadLine()!;

double health1 = 0;
double health2 = 0;
double attack1 = 0;
double attack2 = 0;
double speed1 = 0;
double speed2 = 0;
double amor1 = 0;
double amor2 = 0;
switch (character1)
{
    case PIRATE:
        health1 = Phealth;
        attack1 = Pattack;
        speed1 = Pspeed;
        amor1 = Pamor;
        break;
    case STONECHEWER:
        health1 = Shealth;
        attack1 = Sattack;
        speed1 = Sspeed;
        amor1 = Samor;
        break;
    case SPIRITWARRIOR:
        health1 = SPhealth;
        attack1 = SPhealth;
        speed1 = SPspeed;
        amor1 = SPamor;
        break;
    case OFFWORLDERS:
        health1 = ofhealth;
        attack1 = ofattack;
        speed1 = ofspeed;
        amor1 = ofamor;
        break;
    case MONSTERKNIGHT:
        health1 = mhealth;
        attack1 = mhealth;
        speed1 = mspeed;
        amor1 = mamor;
        break;
    case DARKGOBLIN:
        health1 = Dhealth;
        attack1 = Dattack;
        speed1 = Dspeed;
        amor1 = Damor;
        break;
}


switch (character2)
{
    case PIRATE:
        health2 = Phealth;
        attack2 = Pattack;
        speed2 = Pspeed;
        amor2 = Pamor;
        break;
    case STONECHEWER:
        health2 = Shealth;
        attack2 = Sattack;
        speed2 = Sspeed;
        amor2 = Samor;
        break;
    case SPIRITWARRIOR:
        health2 = SPhealth;
        attack2 = SPhealth;
        speed2 = SPspeed;
        amor2 = SPamor;
        break;
    case OFFWORLDERS:
        health2 = ofhealth;
        attack2 = ofattack;
        speed2 = ofspeed;
        amor2 = ofamor;
        break;
    case MONSTERKNIGHT:
        health2 = mhealth;
        attack2 = mhealth;
        speed2 = mspeed;
        amor2 = mamor;
        break;
    case DARKGOBLIN:
        health2 = Dhealth;
        attack2 = Dattack;
        speed2 = Dspeed;
        amor2 = Damor;
        break;
}

while (amor1 > 0 && amor2 > 0 && health1 > 0 && health2 > 0)
{
    health1 -= attack2 * speed2 ;
    health2 -= attack1 * speed1; 




}

if (health1 > 0)
{
    Console.Write("Winner is player 2");


}


else if (health2 > 0)
{

    Console.Write("Winner is player 1");
}
else
{
    Console.Write("Draw");
}