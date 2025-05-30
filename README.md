# TrabajoPractico
Primer Trabajo practico de la materia Programacion I

Introducción
En un Gran Premio de Fórmula 1, el acceso al paddock y pit lane es altamente restringido y requiere una solicitud de acreditación previa. Este trabajo práctico simulará el sistema de registro online que la FIA (Federación Internacional del Automóvil) utiliza para gestionar las acreditaciones.

Requisitos del Sistema: 

Mostrar un mensaje de bienvenida al sistema. 
El sistema debe solicitar los siguientes datos al usuario: 
Nombre completo
DNI/Pasaporte (validar que sea numérico)
Fecha de Nacimiento
Nacionalidad
Correo Electrónico

-Tipo de Acreditación deseada: 
Paddock General (€500) → Acceso limitado a zona de paddock
VIP/Paddock Club (€3,000) → Incluye lounge y acceso a pit lane
Prensa Acreditada (€200) → Requiere credencial de medio registrado
Personal de Equipo (Gratis) → Debe ingresar código de equipo válido
Invitado FIA (Gratis) → Requiere código de aprobación

-Días de asistencia: 
Full Weekend (Viernes, Sábado y Domingo) →Precio completo
Solo domingo → 25% de descuento

La edad mínima para ingresar sin un adulto acompañante es de 18 años. 
Menores de entre 7 y 17 inclusive requieren acompañamiento de un adulto, por lo que debe registrarse el DNI del adulto responsable.
Los menores de 7 años además solo tienen acceso a las tribunas.

Si el usuario desea la vuelta guiada por boxes:
Solo está disponible viernes y sábados
Posee un costo adicional de €500 (gratis para VIP y Personal de Equipo).

Si trae una cámara profesional, se cobra un adicional de €3000, excepto si es VIP o Personal de Equipo. Debe adjuntar permiso de filmación (solicitar solo el nombre del archivo).
Los mayores de 65 años poseen un descuento del 10%. Los asistentes registrados en F1 TV Pro poseen un descuento del 15%. Ambos descuentos son acumulables.

//
Al finalizar el proceso mostrar: 
Nombre, edad, tipo de acceso, si tiene vuelta guiada, si trae cámara profesional.
El costo a pagar, si corresponde.
Un código de acreditación generado(dos letras seguidas de 5 números, por ejemplo: "F1" + número aleatorio).
La fecha y hora de emisión de la acreditación.
Un mensaje de bienvenida e indicar que se debe presentar el código más documento de identidad al ingresar.


//Aclaraciones
Leer atentamente todo el trabajo práctico antes de comenzar a programar.
Solo se recibirán trabajos por este medio dentro de la fecha de entrega.
Utilicen estructuras de control para manejar las diferentes opciones y cálculos del programa. No deben utilizarse ciclos, funciones ni clases.
Añadan comentarios en el código para explicar la lógica detrás de alguna sección importante si lo consideran necesario. 
Procuren que el programa sea interactivo y fácil de entender para el usuario.
