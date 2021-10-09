# RedPacifico
Examen Practico

# Instrucciones para instalar y configurar los prerrequisitos de la aplicación.
Descomprimir: https://drive.google.com/file/d/1yWekhlOxzvG1vpUYJtL0V6evOgTPFIwb/view?usp=sharing para obtener la carpeta Instalacion
En la ruta: RedPacifico/RedPacifico/bin/Release
Ejecutar el componente: RedPacifico.exe

#Instrucciones para crear e inicializar la base de datos.
Es necesario ingresar a la carpeta: Instalacion
Ejecutar: mysql-installer-community-8.0.26.0.msi
Instalar la opcion: Developer Default

Una vez instalado, buscar la aplicacion MySQL Workbench en tu computadora.
Al iniciar te va a pedir que crees un usuario y contraseña
Usuario: root
Contraseña: root

Una vez creado el usuario, dentro de la carpeta: MySql Scripts
Ejecutar el contenido en el archivo: Crear DB.txt
Despues ejecutar el contenido en el archivo: Scripts.txt

Con esto queria lista la bd para ser utilizada por la aplicacion.

#Instrucciones para preparar el código fuente para compilarlo y correrlo de manera apropiada.
Instalar Visual Studio 2019
Ingresar a la carpeta: Instalacion
Ejecutar: mysql-connector-net-8.0.26.msi
Ejecutar: mysql-for-visualstudio-1.2.10.msi

Abrir el proyecto: RedPacifico, en Visual Studio 2019
Compilar el proyecto: Ctrl + Mayus (Shift) + B
Correr el proyecto: F5

Para debugear poner breakpoints (F9) en la linea de codigo que deseas debugear
