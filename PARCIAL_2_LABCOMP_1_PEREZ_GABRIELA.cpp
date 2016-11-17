#include<iostream.h>
#include<stdio.h>
#include<string.h>
#include<conio.h>

int main()
{
    int var,num_1,num_2,num_3,num_4,tamanio,valor;
    const int prom=2;
    char palabra[100];
    
    printf("\n Menu de opciones \n\n");
    printf(" 1) Obtener el promedio de 2 valores ingresados \n");
    printf(" 2) Mostrar el largo de una palabra \n");
    printf(" 3) El cubo de un valor ingresado \n");
    printf(" 4) Mostrar los meses del 2do semestre del año \n");
    printf(" 5) Salir \n");
    printf(" ______________________________ \n\n");
    
    printf(" Opcion ingresada: ");
    scanf("%i",&var);
       
    while(var>=1 && var<5)
     {
     if(var==1)
       {
         printf("Ingrese un valor: ");scanf("%i",&num_1);
         printf("Ingrese otro valor: ");scanf("%i",&num_2);
         num_3=((num_1+num_2)/prom);
         printf("Primer valor ingresado: %i\n",num_1);
         printf("Segundo valor ingresado: %i\n",num_2);
         printf("El promedio de los valores %i y %i es: %i\n",num_1,num_2,num_3);
       }
      else if(var==2)
            {
               printf("Ingrese una palabra: ");scanf("%s",&palabra);
               tamanio=strlen(palabra);
               printf("La palabra ingresada es: %s\n\n",palabra);
               printf("Su largo es de %i caracteres \n\n",tamanio);
            }
         else if(var==3)
               {
                 printf("Ingrese un valor: \n");scanf("%i",&num_4);
                 valor=(num_4*num_4*num_4);
                 printf("El valor ingresado es: %i\n",num_4);
                 printf("Su cubo es: %i\n",valor);
               }
           else if(var==4)
                 {
                   printf("Los meses del 2do cuatrimestre son: \n");     
                   printf(" Julio \n");
                   printf(" Agosto \n");
                   printf(" Septiembre \n");
                   printf(" Octubre \n");
                   printf(" Noviembre \n");
                   printf(" Diciembre \n");
                 }
         

       system("pause");
       system("cls");
       printf("\n Menu de opciones \n\n");
       printf(" 1) Obtener el promedio de 2 valores ingresados \n");
       printf(" 2) Mostrar el largo de una palabra \n");
       printf(" 3) El cubo de un valor ingresado \n");
       printf(" 4) Mostrar los meses del 2do semestre del año \n");
       printf(" 5) Salir \n");
       printf(" ______________________________ \n\n");
    
       printf(" Opcion ingresada: \n");
       scanf("%i",&var);
       if(var<1 || var>5)
                {
                  printf("Ingreso una opcion no contemplada \n\n");  
                  printf("Opcion ingresada: \n");scanf("%i",&var);
                } 
       }
    system("pause");
    
}
            
                  
      
