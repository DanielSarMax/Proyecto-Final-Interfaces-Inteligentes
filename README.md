# Prototipo - Interfaces Inteligentes
## Índice

- [Integrantes del grupo](#integrantes-del-grupo)
- [Cuestiones importantes para el uso](#cuestiones-importantes-para-el-uso)
- [Hitos de programación logrados](#hitos-de-programación-logrados)
- [Aspectos a destacar](#aspectos-a-destacar)
- [Sensores utilizados](#sensores-utilizados)
- [Gif animado de ejecución](#gif-animado-de-ejecución)
- [Acta de acuerdos del grupo](#acta-de-acuerdos-del-grupo)

## Integrantes del grupo

- Daniel David Sarmiento Barrera (alu0101499208@ull.edu.es)
- Roberto Báez Herrera (alu0101497013@ull.edu.es)
- Adrián Alejandro Padrón López (alu0101480213@ull.edu.es)
- Adrián Suárez Tabares (alu0101495439@ull.edu.es)

## Cuestiones importantes para el uso

1. La apk está diseñada para ser compatible con dispositivos Android.
2. Es recomendable contar con gafas de realidad virtual compatible con dispositivos móviles Android. 
    - En este caso la apk fue pensada para funcionar con las Google Cardboard.
3. El manejo del juego ha sido diseñado para funcionar con un mando a través de bluetooth. 
    - Fue testeado con una mando de la PlayStation 5, pero es compatible con otro tipo de mandos.
4. Es necesario conceder los permisos de acceso necesarios al instalar la aplicación.

## Breve descripción del juego
Se trata de un shooter en primera persona (FPS) en donde debemos disparar a las dianas para poder ganar puntos. La munición se encuentra esparcida por el suelo y debemos recogerla. Los niveles tienen 3 dianas ocultas y hay que buscarlas y dispararlas. Cuando se encuentran las 3 dianas pasamos al siguiente nivel. Hay 3 niveles jugables, siendo el primero una _demo_ para acostumbrarse a los controles.




### Mecánicas y controles

- Disparar: R2
- Recoger munición: Botón Cuadrado
- Moverse: Joystick izquierdo
- Girar la mira: Giroscopio
- Teletransportarse: Botón X

## Hitos de programación logrados

1.    Uso de sensores.
2. Uso de eventos que controlan aspectos como la puntuación y el desbloqueo de niveles y escenarios.
    - Implementación del patrón observador con objetos suscriptores y notificadores.
3. El manejo y uso de los controles del mando se ha mapeado desde el input actions.
4. Manejo de físicas del juego utilizando componentes como RigidBody.
5. Manejo de las rotaciones de las flechas a través de Quaternions.
6. Implementación de la interfaz de usuario en la que el jugador puede saber cuál es su puntuación total y el nivel en el que se encuentra, así como la munición restante. 


## Aspectos a destacar

1. Se han utilizado diferentes prefabs de la Unity Asset Store para elementos interactivos como dianas y flechas, además de elementos geográficos y demás.
2. Se han tenido en cuenta los ejemplos y consejos de buenas prácticas para el desarrollo de aplicaciones en realidad virtual como se describen en la checklist.
3. Se han utilizado texturas básicas para el entorno con el objetivo de tener un rendimiento óptimo en una gran variedad de dispositivos.
4. Se ha creado un entorno inicial demo para que el usuario se familiarice con el entorno y el funcionamiento del juego.
5. Se ha añadido música de ambiente para mejorar la experiencia del jugador y favorecer la inmersión en el juego. No obstante, se ha tenido en cuenta que aún se pueden escuchar sonidos del exterior.
6. Se han desarrollado varios escenarios con el objetivo de mantener la experiencia del jugador dinámica y entretenida.
7. Se han utilizado prefabs como una buena práctica de desarrollo para optimizar la gestión y reutilización de componentes.
8. Se ha escalado cada escenario para que guarde concordancia y proporcione una experiencia coherente.
9. Se ha añadido la posibilidad de teletransporte en el editor de Unity, mejorando la navegación y la interacción en el entorno de desarrollo.

## Sensores utilizados.

 - Giroscopio

## Gif animado de ejecución

![](demo.gif)

## Acta de acuerdos del grupo

- Diseño del mapa: Adrián Alejandro Padrón López, Daniel David Sarmiento Barrera, Adrián Suárez Tabares, Roberto Báez Herrera.
- Desarrollo de scripts: Adrián Alejandro Padrón López, Daniel David Sarmiento Barrera.
- Escritura del README: Daniel David Sarmiento Barrera, Adrián Suárez Tabares, Roberto Báez Herrera.
- Diseño de mecánicas: Adrián Alejandro Padrón López, Roberto Báez Herrera.
- Control de accesibilidad: Adrián Suárez Tabares.

## Checklist de puntos a cumplir
- Evitar movimientos automáticos de cámara.
- Eliminar movimientos de cabeza al caminar.
- Crear entornos relajantes y no confusos.
- Garantizar un rendimiento óptimo del juego.
- Hacer el juego interesante.
- Considerar agregar un "modelo de nariz".
- Elegir mecánicas de locomoción adecuadas.
- Seleccionar géneros de juego adecuados.

