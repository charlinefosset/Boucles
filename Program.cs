namespace Boucles;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : faire un compteur qui va de 1 à 1
        

        for (int croissant = 1; croissant <= 10; croissant++)
        {
            Console.WriteLine(croissant);
        }



        // Etape 2 : faire un décompte qui va de 5 à 1 puis qui dit "Bonne année !"
        for ( int decompte = 5; decompte >=1; decompte--)
        {
            Console.WriteLine(decompte);
        }
        Console.WriteLine("Bonne année!");

        // Etape 3 : faire un compteur qui va de -4 à 2
        for (int lll = -4; lll<= 2; lll++)
        {
            Console.WriteLine(lll);
        }

        // Etape 4 : faire un compteur qui compte 2 par 2 de 0 à 15

        // Etape 5 : faire une boucle qui se répète à chaque fois que l'utilisateur écrit autre chose que "oui"

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}