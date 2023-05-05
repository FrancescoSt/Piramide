# Piramide
Esercizio piramide

## Descrizione
Si chiede di realizzae un programma che dati in ingressi un numero di mattoni, ritorni il numero di piani

## Codice (senza commenti)

```c#

namespace Piramide
{
public static class Piramide
{

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
}

}

``` 


## Codice (con commenti)
```c#
public static int Piani(int mattoni)
{
    // inizializza il numero di piani a 0
    int piani = 0; 
    // inizializza il numero di mattoni utilizzati a 0
    int mattoni_usati = 0; 
    while (mattoni_usati + (piani + 1) * (piani + 1) <= mattoni)
    // finché i mattoni utilizzati + i mattoni necessari per costruire il prossimo piano
    // non superano la quantità totale di mattoni disponibili
    {
        // incrementa il numero di piani
        piani++; 
        // incrementa i mattoni utilizzati
        mattoni_usati += piani * piani; 
        
    }
    return piani; // restituisce il numero massimo di piani costruibili
}

public static int Rimanenti(int mattoni)
{
    int piani = Piani(mattoni); // determina il numero massimo di piani utilizzando il metodo Piani
    int mattoni_usati = 0; // inizializza il numero di mattoni utilizzati a 0
    for (int i = 1; i <= piani; i++) // per ogni piano costruito
    {
        mattoni_usati += i * i; // incrementa i mattoni utilizzati
    }
    return mattoni - mattoni_usati; // restituisce i mattoni rimanenti
}

```
## Divisione del codice

