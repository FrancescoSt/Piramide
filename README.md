 # Piramide

 ## Descrizione
 crivere un programma che calcoli l'altezza massima di una piramide (in piani) dato un certo numero di mattoni.
 
 ## Esempio
- il primo piano ha un mattone, il secondo 9 mattoni, il terzo 25 e così via

- con 1 mattone la piramide è alta 1 piano

- con 84 mattoni la piramide è alta 4 piani
 ## Codide (senza commenti)
 ``` c#
  public static int Piani(int mattoni)
        {
            int piani = 0;
            int mattoni_usati = 0;
            while (mattoni_usati + (piani + 1) * (piani + 1) <= mattoni)
            {
                piani++;
                mattoni_usati += piani * piani;
            }
            return piani;
        }
        public static int Rimanenti(int mattoni)
        {
            int piani = Piani(mattoni);
            int mattoni_usati = 0;
            for (int i = 1; i <= piani; i++)
            {
                mattoni_usati += i * i;
            }
            return mattoni - mattoni_usati;
        }
 ```
 ## Codice Commentato 
 ``` c#
 // Questo metodo calcola il numero massimo di piani che possono essere costruiti dati un certo numero di mattoni
public static int Piani(int mattoni)
{
    int piani = 0; // Inizializza il numero di piani a 0
    int mattoni_usati = 0; // Inizializza il numero di mattoni utilizzati a 0
    // Finché il numero di mattoni utilizzati più il numero di mattoni necessari per il prossimo piano è inferiore o uguale al numero totale di mattoni disponibili
    while (mattoni_usati + (piani + 1) * (piani + 1) <= mattoni)
    {
        piani++; // Incrementa il numero di piani
        mattoni_usati += piani * piani; // Aggiunge il numero di mattoni necessari per il piano corrente al numero totale di mattoni utilizzati
    }
    return piani; // Restituisce il numero massimo di piani che possono essere costruiti
}

// Questo metodo calcola il numero di mattoni che rimarranno dopo aver costruito il numero massimo di piani
public static int Rimanenti(int mattoni)
{
    int piani = Piani(mattoni); // Ottiene il numero massimo di piani che possono essere costruiti
    int mattoni_usati = 0; // Inizializza il numero di mattoni utilizzati a 0
    // Per ogni piano che può essere costruito
    for (int i = 1; i <= piani; i++)
    {
        mattoni_usati += i * i; // Aggiunge il numero di mattoni necessari per il piano corrente al numero totale di mattoni utilizzati
    }
    return mattoni - mattoni_usati; // Restituisce il numero di mattoni rimanenti
}
```
## Divisione In blocchi

* primo blocco
``` c#
public static int Piani(int mattoni)
        {
            int piani = 0;
            int mattoni_usati = 0;
            while (mattoni_usati + (piani + 1) * (piani + 1) <= mattoni)
            {
                piani++;
                mattoni_usati += piani * piani;
            }
            return piani;
        }
```
Questo blocco definisce un metodo statico chiamato "Piani" che prende un intero in ingresso chiamato "mattoni" e restituisce un intero in uscita. Il metodo calcola il numero di piani realizzabili dato un certo numero di mattoni. Lo fa incrementando un contatore chiamato "piani" fino a quando il numero di mattoni necessari per costruire il piano successivo supera il numero totale di mattoni disponibili. Il metodo restituisce il valore finale di "piani", che rappresenta il numero massimo di piani realizzabili.
* Secondo blocco
```c#
public static int Rimanenti(int mattoni)
        {
            int piani = Piani(mattoni);
            int mattoni_usati = 0;
            for (int i = 1; i <= piani; i++)
            {
                mattoni_usati += i * i;
            }
            return mattoni - mattoni_usati;
        }
```
Questo blocco definisce un altro metodo statico chiamato "Rimanenti" che prende un intero in ingresso chiamato "mattoni" e restituisce un intero in uscita. Il metodo calcola il numero di mattoni che rimarranno dopo aver costruito il numero massimo di piani. Lo fa chiamando prima il metodo "Piani" per ottenere il numero massimo di piani, quindi calcolando il numero totale di mattoni necessari per costruire quei piani. Infine, il metodo restituisce la differenza tra il numero totale di mattoni e il numero di mattoni utilizzati per costruire i solai, che rappresenta il numero di mattoni rimasti.

 
