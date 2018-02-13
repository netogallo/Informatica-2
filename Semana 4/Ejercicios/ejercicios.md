## Faciles

1) Dado un string, escribir un programa que invierta el orden de sus letras. "Hola mundo" se vuleve "odnum aloH".
2) Dado un string, escribir un programa que determina si es un anagrama (se escribe igual en ambas direcciones, como toto)
3) Dado un entero, escribir un programa que lo factorize a sus numeros primos: 80 -> [2,2,2,2,5]
4) Dado dos strings, determinar si son palindromes (tienen las mismas letras pero en diferente orden)
5) Dado dos strings, determinar si el primer string esta contenido en el segundo string.
6) Dado un numero "n" y un array de enteros primos no repetidos (se puede asumir que ese es el caso), determinar cual es la suma
    de toods los numeros divisibles entre algun numero del array menores a "n".

## intermedias
1) Dados dos arreglos con numeros ordenados, juntarlos en un arreglo, tambien ordenados. Ej. [1,3,6,7,8] y [0,5] => [0,1,3,5,6,7,8]
2) Escribir un algoritmo que liste los numeros pares de fibonacci menores a un numero N, dado como parametro. Los numeros de fibonnaci se definen como:
    f(0) = 1
    f(1) = 1
    f(n) = f(n - 1) + f(n - 2)
3) Dada la interfaz

interface IHuevoSeRompe{
    bool SeRompe(int piso);
}

Escribir un metodo que tome como parametro una instancia de dicha interfaz, y determine en que piso se rompe el huevo si se deja caer de ahi.
REcordar que se rompera en todos los niveles mas altos que dicho piso y no se rompera en todos los niveles mas bajos. El algoritmo debe
encontrar la respuesta utilizando la menor cantidad de llamadas al metodo "SeRompe".

4) Dado un arreglo de numeros ordenado y un numero, encontrar si dicho numero se encuentra en el arreglo. Debe hacerlo utilizando la menor
cantidad de lookups (arreglo[i]) possible.

5) Escribir un algoritmo que remueve los caracteres que aparecen mas de una vez en un string.

## dificiles

1) Escribir un programa que dada una lista de numeros de longitud desconocida (aka. un linked list), escoger un numero aleatoreamente recorriendo la lista a lo
maximo una vez. Todos los numeros deben tener la misma probabilidad de ser escogidos.

2) Dado un arreglo, (de numeros positivos y negativos), escribir el programa que encuentra el sub-arreglo (subconjunto del arreglo en el mismo orden) que
tenga la mayor suma. El programa nunca debe solicitar todos sus indices 2 veces.

## Fuente:

Para mas ejercicios de programacion:

* Glassdoor (www.glassdoor.com)
* Project Euler (https://projecteuler.net/)