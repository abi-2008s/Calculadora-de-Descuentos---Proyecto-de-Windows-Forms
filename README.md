# Calculadora de Descuentos - Proyecto de Windows Forms
Este proyecto es una aplicación de escritorio desarrollada en C# por María Fernanda
Campos Mejía y Emma Abigail Romero Rivas, con Windows Forms para la asignatura de
Programación Estructurada. Su objetivo es calcular el precio final de un producto aplicando
un descuento porcentual que depende de la categoría del artículo y del monto total de la
compra realizada.

# Cómo ejecutar el programa

Para probar la aplicación en tu equipo, sigue estos sencillos pasos:
- **1. Descomprimir:** Extrae el contenido del archivo ZIP en una carpeta de tu
computadora.

- **2. Abrir la solución:** Navega dentro de la carpeta extraída y haz doble clic en el
archivo de solución llamado ProyectoDescuentos.sln. Esto abrirá todo el proyecto en
Visual Studio.

- **3. Compilar y Ejecutar:**
   - Una vez en Visual Studio, asegúrate de que la configuración esté en **Debug** y
   la plataforma en **Any CPU**.
   - Presiona la tecla **F5** o haz clic en el botón verde de **"Iniciar"** en la barra de
  herramientas superior.
   
- **4\. Usar la aplicación:** Se abrirá la ventana del programa. Ingresa los datos solicitados y presiona el botón "Calcular Descuento" para ver los resultados.

# Características Implementadas
El programa incluye las siguientes funcionalidades clave:

- **Interfaz Gráfica Intuitiva:** Un formulario fácil de usar con campos de texto para el
precio y el monto total, un menú desplegable para seleccionar la categoría del
producto, y etiquetas claras para mostrar los resultados.

- **Cálculo de Descuentos Condicionado:** El sistema aplica un descuento solo si el
monto total de la compra supera un umbral específico para cada categoría, tal como
se define en las reglas de negocio:
  - **Electrónica:** 10% de descuento para compras mayores a $500.
  - **Ropa:** 15% de descuento para compras mayores a $300.
  - **Alimentos:** 5% de descuento para compras mayores a $200.
  - **Hogar:** 20% de descuento para compras mayores a $400.
  
- **Visualización de Resultados:** Muestra el precio final a pagar y un mensaje
detallado que indica si se aplicó un descuento y, en caso afirmativo, de cuánto fue el
ahorro.

# Consideraciones Adicionales
Para garantizar el correcto funcionamiento del programa, se han tomado en cuenta los
siguientes aspectos técnicos:

- **Validaciones de Datos:** Antes de realizar cualquier cálculo, el programa verifica
que:
  - Los campos de precio y monto total no estén vacíos y contengan valores
numéricos válidos y positivos.
  - Se haya seleccionado una opción en el menú de categorías.
  - En caso de error, se muestra un mensaje informativo al usuario y se detiene
el proceso para evitar fallos.
- **Estructura del Código:** La lógica principal del botón "Calcular" se basa en dos
estructuras de control fundamentales, cumpliendo con los requisitos de
implementación:
  - **switch-case:** Se utiliza para determinar el porcentaje de descuento y el
monto mínimo requerido según la categoría seleccionada por el usuario.
  - **if-else:** Se emplea para evaluar si el monto total de la compra cumple con la
condición para aplicar el descuento, decidiendo así el precio final y el
mensaje a mostrar.
