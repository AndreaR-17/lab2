# Laboratorio de Programación en C#

##  Parte 1:Declaración y Uso de Variables
Se declararon las siguientes variables y se pidieron valores al usuario:
- **int** (Número entero)
- **double** (Número decimal)
- **string** (Texto)
- **bool** (Valor verdadero/falso)

##  Parte 2: Operaciones Matemáticas
Se realizaron operaciones matemáticas con distintos tipos de datos:
- **Suma** (+)
- **Resta** (-)
- **Multiplicación** (*)
- **División** (/)

##  Parte 3: Operaciones Lógicas
Se implementaron comparaciones con operadores:
- **Mayor que** (>)
- **Menor que** (<)
- **Igualdad** (==)
- **Operadores lógicos** (AND `&&`, OR `||`)

###  Preguntas
###  ¿Para qué crees que se usan los operadores lógicos en programación?
Los operadores lógicos permiten tomar decisiones en el código, evaluando condiciones como comparaciones numéricas o booleanas.

###  ¿Por qué es importante declarar correctamente el tipo de dato de una variable?
Es importante porque ayuda a gestionar la memoria y evita errores en operaciones matemáticas o comparaciones lógicas.

#### ENUNCIADO 1
#### ¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
Se uso  if-else porque estamos evaluando rangos de valores (edad < 12, edad >= 12 && edad <= 17, etc.).
La estructura switch en C# no permite trabajar con rangos de valores de forma directa, sino con valores específicos.
Si quisiéramos usar switch, necesitaríamos casos específicos (como case 12: case 13: case 14: ...), lo cual no es práctico.
Por eso, if-else es la mejor opción para este problema.
#### ENUNCIADO 2
#### ¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
Se uso switch, por que:
- Más claro y fácil de leer: 
- Más eficiente: switch puede ser optimizado internamente por el compilador, mientras que if-else evalúa condiciones en secuencia.
- Código más limpio: Se evita repetir if (numero == x) varias veces.
#### ENUNCIADO 3
#### ¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
Se uso if-else, porque se estan evaluando múltiples condiciones que dependen una de otra:
- Si el usuario existe, verificamos la contraseña.
- Si la contraseña es correcta, concedemos el acceso.
- Si la contraseña es incorrecta, mostramos un mensaje de error.
- Si el usuario no está registrado, mostramos otro mensaje de error.