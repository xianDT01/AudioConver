# Convertidor de Audio

Este es un programa en C# para convertir archivos de audio de varios formatos (como .m4a y .opus) a formato MP3 utilizando la biblioteca NAudio.

## Uso

1. Clona o descarga el repositorio.
2. Compila el programa en C# .
3. Ejecuta el archivo ejecutable compilado.
4. Sigue las instrucciones en pantalla:
    - Ingresa el directorio de origen que contiene los archivos de audio que deseas convertir.
    - Ingresa el directorio de destino donde deseas que se guarden los archivos MP3 convertidos.
5. Espera a que se complete el proceso de conversión.

## Requisitos

- .NET Core o .NET Framework instalado.
- Biblioteca NAudio (incluida en el proyecto).

## Formatos Soportados

Este programa admite la conversión desde los siguientes formatos de audio a MP3:
- .m4a (Audio MPEG-4)

## Notas

- Asegúrate de que el directorio de origen contenga solo archivos de audio que deseas convertir.
- Los archivos MP3 convertidos se guardarán con el mismo nombre que los archivos originales pero con la extensión .mp3.
- El programa creará el directorio de destino si no existe.

