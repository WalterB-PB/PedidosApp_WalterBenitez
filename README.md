TIA 4 INTERFAZ

Patrones de diseño utilizados

Strategy: Permite intercambiar el método de entrega sin modificar la clase 'Pedido'.
Factory Method: Se usa en 'EntregaFactory' para encapsular la lógica de selección del transporte.
Singleton: Se usa en 'RegistroPedidos' para asegurar que solo exista una instancia que almacene todos los pedidos.

1. ¿Qué ventaja tiene usar una interfaz en vez de una clase directa?
La interfaz actúa como un contrato que define qué debe hacerse, pero no cómo. Esto nos da flexibilidad para implementar múltiples estrategias (como dron, moto, camión, etc.) sin modificar el núcleo del sistema. Si usáramos una clase concreta, estaríamos atados a una única implementación, obligándonos a reescribir código cada vez que añadamos un nuevo método de entrega. Con la interfaz, simplemente creamos una nueva clase que la implemente y el sistema la integrará sin romper lo existente. Además, facilita los tests y el mantenimiento, ya que cada lógica de entrega está aislada y sigue el mismo estándar.

2. ¿Por qué no pusimos la lógica de entrega dentro de la clase Pedido?
Por el principio de responsabilidad única (SOLID). La clase Pedido debe ocuparse únicamente de gestionar los datos del pedido (productos, cliente, dirección), no de cómo se entrega. Si mezcláramos ambas responsabilidades, el código se volvería frágil: cualquier cambio en la lógica de entregas obligaría a modificar Pedido, aumentando el riesgo de errores. Al delegar esa tarea al Factory Method, mantenemos una separación clara:

Pedido: Almacena información.

Factory: Decide qué transporte usar.

Strategy: Ejecuta la entrega según el transporte.
Esto hace que el sistema sea más modular y escalable.

3. ¿Cuál principio SOLID fue clave aquí y por qué?
El principio de abierto/cerrado (OCP) fue fundamental. El sistema está diseñado para:

"Cerrado" a modificación: No necesitas alterar Pedido, RegistroPedidos o las estrategias existentes al agregar un nuevo transporte.

"Abierto" a extensión: Basta con crear una nueva clase (ej. EntregaBicicleta) e integrarla sin tocar el código probado.
Otros principios como Single Responsibility (separación de lógicas) y Dependency Inversion (depender de interfaces, no de implementaciones) también jugaron un rol clave.

4. Si queremos agregar entregas ecológicas en bicicleta, ¿qué harías?
Seguiríamos estos pasos:

Crear la clase EntregaBicicleta que implemente la interfaz ITransporte con la lógica específica (ej. calcular ruta verde, emisiones cero).

Extender el EntregaFactory para que, ante un pedido marcado como "ecológico", devuelva una instancia de EntregaBicicleta.

¡Listo! El resto del sistema (registro, procesamiento de pedidos) sigue funcionando igual.
Ventaja: Cero modificaciones en código existente, solo añadimos funcionalidad nueva.

5. ¿Cómo ayudan estos patrones a mantener el sistema?
Orden: Cada patrón resuelve un problema específico sin solaparse (Strategy = algoritmos intercambiables, Factory = creación flexible, Singleton = control de instancias).

Escalabilidad: Agregar features (ej. una nueva entrega) toma minutos, no horas.

Trabajo en equipo: Se pueden asignar módulos (ej. alguien trabaja en EntregaDron sin afectar RegistroPedidos).

Robustez: Al reducir acoplamiento, los cambios tienen menor impacto. Si un transporte falla, no cascabelea todo el sistema.

6. ¿Cuándo usarías Singleton en la vida real?
En cualquier escenario donde múltiples partes del sistema deban acceder a un único punto de verdad, como:

Registro global de pedidos (como en el ejemplo): Evita inconsistencia al tener una sola lista centralizada.

Configuraciones de la app: Que todas las clases lean la misma configuración sin recargarla desde disco.

Conexiones a bases de datos: Para reutilizar la misma conexión en vez de abrir una nueva por cada operación.
¡Pero con cuidado!: Singleton puede ser un antipatrón si se abusa, ya que dificulta los tests y oculta dependencias. Usarlo solo cuando realmente se necesita una única instancia global.

Capturas Funcionamiento 

https://docs.google.com/document/d/1IMpxVOv_236Rdj_d7vXP9YXo3q4f3r68J-cxXGXpCgM/edit?usp=sharing


