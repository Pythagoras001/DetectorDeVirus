# 🛡️ VirusHashDetector (Windows Forms · C# · MVC) 28 de Agosto 2025

**VirusHashDetector** es un proyecto orientado a objetos que implementa un analizador sencillo de archivos para detectar patrones de virus.  
La idea principal es convertir cualquier archivo en una secuencia de bytes, analizar ventanas (subconjuntos) de 4 bytes y comparar sus *hashes polinomiales* contra una base de firmas para detectar coincidencias de forma eficiente.

> Proyecto con fines educativos y de práctica de conceptos: diseño por *Modelo-Vista-Controlador (MVC)*, Windows Forms para la interfaz, y algoritmos de hashing para optimizar la búsqueda de patrones.

---

## 🧩 Funcionalidad principal

- Cargar un archivo (cualquier tipo).
- Convertir el contenido a `byte[]`.
- Desplazar una ventana de tamaño 4 bytes sobre la secuencia.
- Calcular un **hash polinomial** para cada ventana.
- Buscar coincidencias en una base de firmas (hashes conocidos de patrones de virus).
- Reportar si el archivo **posiblemente** contiene alguna firma detectada y mostrar la(s) posición(es).

---

## 🧱 Tecnologías

- 🟢 **C#** (.NET 8 / .NET 7 compatible, Windows)
- 🪟 **Windows Forms** (UI)
- 🧭 Patrón arquitectónico: **MVC** (separación clara entre modelo, lógica y vista)
- 🧪 Pruebas unitarias (opcional): xUnit / NUnit

---

### 🔢 Cómo se calcula el hash

El sistema utiliza un **hash polinomial** para representar cada bloque de 4 bytes del archivo como un valor numérico único.  
Esto permite comparar secuencias de forma eficiente sin revisar byte por byte.

Primero, el archivo se divide en grupos de 4 bytes.  
Luego, para cada grupo se calcula el hash mediante la fórmula recursiva:

h[0] = s[0]
h[k] = (h[k-1] * A + s[k]) mod B


donde:
- `s[k]` es el valor del byte en la posición `k`.
- `A` es una base (por ejemplo, 257) usada para combinar los valores.
- `B` es un número primo grande o un módulo de 64 bits que reduce colisiones.

El resultado es un arreglo `h` con los hashes de todos los prefijos del archivo.  
Gracias a este preprocesamiento, el hash de cualquier subcadena puede obtenerse en **O(1)** usando operaciones aritméticas simples.  
Así, el cálculo completo de los hashes tiene una complejidad **O(n)** y la búsqueda en el diccionario de firmas se realiza en **O(1)**, logrando un análisis rápido incluso con archivos grandes.

Para minimizar colisiones, se aplico un **doble hash** con diferentes bases y módulos.

## 👥 Autor

- **Thomas Gómez** — Desarrollo, implementación del algoritmo de hash polinomial y arquitectura MVC.
