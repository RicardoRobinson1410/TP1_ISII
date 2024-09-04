# TP 1 - Ingeniería de Software
## Integrantes
*Gonzalo Robinson*
*Ricardo Jorge Robinson*
*Patricio Scidá*
*Francisco Vicente*
*Iñaqui Poch*
*Iván Mir*

### Preguntas
#### Punto 1
- ¿Puedes identificar pruebas de unidad y de integración en la práctica que realizaste?
Al testear ciertos componentes como las 

#### Punto 2
- Podría haber escrito las pruebas primero antes de modificar el código de la aplicación?
Si, podría haberlo hecho. De hecho, es una técnica muy utilizada en la mayoría de los entornos porque de esa forma podría ver los posibles errores y así evitarlos al realizar el código. Además, al hacerlo de esta manera, veremos que esté bien hecho el test definitivamente. Pues al no estar el código, el test debería fallar y arreglarse cuando subimos el código.
- ¿Cómo sería el proceso de escribir primero los tests?
El proceso se llama Test Driven Development y consiste en realizar primero los tests, que fallen y luego desarrollar el código más simple y mínimo para que la prueba pase. Luego, se mejora el código, asegurandonos de que la prueba siga pasando

#### Punto 3
- En lo que va del trabajo práctico, ¿puedes identificar 'Controladores' y 'Resguardos'?
	* _Resguardos:_ Podemos identificar el uso de resguardos, cuando probamos el método aplicar_descuento utilizando mocks. Vemos que en este caso, estamos usando una ténica de prueba descendente, por lo tanto, buscamos probar un componente de alto nivel, sin utilizar el componente de bajo nivel
	* _Controladores_ :Hasta este punto del programa, no se necesito utilizar Controladores, puesto a que utilizamos una técnica de prueba ascendente, por lo tanto aún no lo necesitamos
- ¿Qué es un mock? ¿Hay otros nombres para los objetos/funciones simulados?
Un mock, (imitación en español), es un componente que simula la respuesta de otro componente, de manera de aislar el comportamiento del componente que queremos probar. Se suele usar en pruebas de unidad o bien en pruebas de integración, cuando aún no tenemos uno de los componentes que se están integrando. Los objetos/funciones simulados, también se conocen como fakers, resguardos, entre otros.


#### Punto 4
- ¿Qué ventajas ve en el uso de fixtures? ¿Qué enfoque estaría aplicando?
	* _Ventajas:_ 
		- Reutilización de código
		- Me aseguran que los test se ejecutarán bajo las mismas condiciones.
		- Facilitan el mantenimiento, pues si necesito cambiar algo, lo hago en un solo lougar
		- Facilitan la elaboración de tests, pues nos ahorran el tema de hacer las configuraciones del entorno previas a la ejecución
	* _Enfoque:_ Se utiliza un enfoque ascendente, pues primero se crea la clase Producto, se implementan sus operaciones y luego se utilizan para poder probar un componente de nivel superior. En este caso la tienda
- Explique los conceptos de Setup y Teardown en testing
	* _Set up:_ : Se asegura de preparar el entorno antes de cada prueba, asegurando que todas inicien en un estado conocido y controlado
	* _Tear Down:_ Se asegura de limpiar o deshacer cualquier configuración realizada durante el setup o la prueba misma, asegurando que los recursos se liberen y las pruebas no interfieran entre si

#### Punto 5
- Puede describir una situación de desarrollo para este caso en donde se plantee pruebas de integración ascendente? Describa la situación.
En el caso planteado, se realiza una prueba de integración ascendente. Pues, primero se desarrollan los productos (de menor jerarquía), luego se crea la clase tienda y se implementan sus operaciones más básicas como agregar producto y calcular preico, finalmente se implementan las operaciones de mayor jerarquía, como por ejemplo, calcular_total_carrito que integra todas las funciones anteriores para poder calcular el total del carrito.
- 