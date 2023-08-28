import java.util.Scanner;

/**
 * @author joel Moix
 * @version 21.03.2023
 */
public class searchFirst
{

    public static void main(String[] args)
    {
        Scanner input = new Scanner(System.in);
        System.out.print("Inserisci valori: ");

        String find = input.next();

        searchFirst(find, input);
    }

    /**
     * Funzione per cercare un valore
     *
     * @param p_value
     * @param p_args
     */
    public static void searchFirst(String p_value, Scanner p_args)
    {

        String token = p_args.nextLine().trim();

        String[] args = token.split(" ");

        int pos = -1;
        for (int i = 0; i < args.length; i++)
        {
            if (args[i].equals((p_value)) && pos==-1)
            {
                pos = i;
            }
        }

        printArr(args);
        if (pos == -1)
        {
            System.out.println("Valore non trovato");
        } else
        {
            System.out.println(pos);
        }

    }

    /**
     * Funzione per la stampa di un array
     *
     * @param p_arr_print array da stampare
     */
    public static void printArr(String[] p_arr_print)
    {
        for (int i = 0; i < p_arr_print.length; i++)
        {
            System.out.print(p_arr_print[i] + " ");

        }
        System.out.println("");
    }
}
