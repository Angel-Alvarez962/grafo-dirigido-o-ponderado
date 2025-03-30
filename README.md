# grafo-dirigido-o-ponderado
Grafo dirigido y ponderado
En este programa representamos un grafo dirigido y ponderado el cual aplica el algoritmo de Dijkstra, el cual es usado para encontrar el camino mas corto de un nodo a otro, al igual que nos permitira ver la matriz de adyacencia.
En estre programa el usuario podra interactuar desde el menu con este para crear el grafo colocando los nodos que el desee y los caminos (aristas) con su respectivo peso entre los nodos, para despues buscar el camino mas corto entre estos al igual que les muestra la matriz de adyacencia 

Para utilizar el codigo se requiere tener instalado un depurador de codigo C# y ejecutarlo
Interactuar en el menu agregando los nodos
Agregar las aristas, dando de que nodo a que nodo van y darles su peso
Visualizar la matriz de adyacencia
Pedir el camino mas corto de un nodo a otro

El algoritmo de Dijkstra es una solución eficiente para encontrar el camino más corto entre un nodo origen y los demás nodos en un grafo dirigido y ponderado. Su funcionamiento se basa en:
Asignar una distancia inicial infinita a todos los nodos excepto al nodo origen (distancia 0).
Utilizar una cola de prioridad para seleccionar el nodo no visitado con menor distancia acumulada.
Actualizar las distancias de los vecinos del nodo seleccionado si se encuentra un camino más corto.
Repetir el proceso hasta visitar todos los nodos alcanzables.

Ejemplo de uso del programa:
Menú:
1. Agregar nodo.
2. Agregar arista.
3. Mostrar matriz de adyacencia.
4. Encontrar el camino más corto (Dijkstra).
5. Salir.
Seleccione una opción: 1
Ingrese el nombre del nodo: A
Nodo 'A' agregado.

Menú:
1. Agregar nodo.
2. Agregar arista.
3. Mostrar matriz de adyacencia.
4. Encontrar el camino más corto (Dijkstra).
5. Salir.
Seleccione una opción: 1
Ingrese el nombre del nodo: B
Nodo 'B' agregado.

Menú:
1. Agregar nodo.
2. Agregar arista.
3. Mostrar matriz de adyacencia.
4. Encontrar el camino más corto (Dijkstra).
5. Salir.
Seleccione una opción: 1
Ingrese el nombre del nodo: C
Nodo 'C' agregado.

Menú:
1. Agregar nodo.
2. Agregar arista.
3. Mostrar matriz de adyacencia.
4. Encontrar el camino más corto (Dijkstra).
5. Salir.
Seleccione una opción: 1
Ingrese el nombre del nodo: D
Nodo 'D' agregado.

Menú:
1. Agregar nodo.
2. Agregar arista.
3. Mostrar matriz de adyacencia.
4. Encontrar el camino más corto (Dijkstra).
5. Salir.
Seleccione una opción: 2
Ingrese el nodo origen: A
Ingrese el nodo destino: C
Ingrese el peso de la arista: 4
Arista desde 'A' hasta 'C' con peso 4 agregada.

Menú:
1. Agregar nodo.
2. Agregar arista.
3. Mostrar matriz de adyacencia.
4. Encontrar el camino más corto (Dijkstra).
5. Salir.
Seleccione una opción: 2
Ingrese el nodo origen: A
Ingrese el nodo destino: B
Ingrese el peso de la arista: 5
Arista desde 'A' hasta 'B' con peso 5 agregada.

Menú:
1. Agregar nodo.
2. Agregar arista.
3. Mostrar matriz de adyacencia.
4. Encontrar el camino más corto (Dijkstra).
5. Salir.
Seleccione una opción: 2
Ingrese el nodo origen: B
Ingrese el nodo destino: C
Ingrese el peso de la arista: 2
Arista desde 'B' hasta 'C' con peso 2 agregada.

Menú:
1. Agregar nodo.
2. Agregar arista.
3. Mostrar matriz de adyacencia.
4. Encontrar el camino más corto (Dijkstra).
5. Salir.
Seleccione una opción: 2
Ingrese el nodo origen: A
Ingrese el nodo destino: D
Ingrese el peso de la arista: 14
Arista desde 'A' hasta 'D' con peso 14 agregada.

Menú:
1. Agregar nodo.
2. Agregar arista.
3. Mostrar matriz de adyacencia.
4. Encontrar el camino más corto (Dijkstra).
5. Salir.
Seleccione una opción: 2
Ingrese el nodo origen: C
Ingrese el nodo destino: D
Ingrese el peso de la arista: 2
Arista desde 'C' hasta 'D' con peso 2 agregada.

Menú:
1. Agregar nodo.
2. Agregar arista.
3. Mostrar matriz de adyacencia.
4. Encontrar el camino más corto (Dijkstra).
5. Salir.
Seleccione una opción: 3

Matriz de adyacencia:
0       5       4       14
0       0       2       0
0       0       0       2
0       0       0       0

Menú:
1. Agregar nodo.
2. Agregar arista.
3. Mostrar matriz de adyacencia.
4. Encontrar el camino más corto (Dijkstra).
5. Salir.
Seleccione una opción: 4
Ingrese el nodo de inicio: A
Ingrese el nodo de fin: D

Distancia más corta desde A hasta D: 6
Camino: A -> C -> D
