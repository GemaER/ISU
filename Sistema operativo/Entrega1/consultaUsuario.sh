#!/bin/bash
DnLogg=0
while [ $DnLogg -eq 0 ]
do
	clear
	tput cup 3 3; read -p "Ingrese el usuario a buscar: " Logg
	busqueda=$(grep "^$Logg:" /etc/passwd)
	
	if [ -z $busqueda ]
then
	tput cup 2 3;  tput setaf 1;read -p  "No existe el usuario" aux; tput setaf 0 
else 
	tput cup 2 3; tput setaf 2; echo "El usuario $Logg fue encontrado"; tput setaf 0 
	aux1=$(echo $busqueda | cut -d: -f1)
	tput cup 6 3; echo "Usuario : $aux1"
	aux1=$(echo $busqueda  | cut -d: -f3) 
	tput cup 7 3; echo "UID : $aux1"
	aux1=$(echo $busqueda  | cut -d: -f4) 
	tput cup 8 3; echo "GID : $aux1"
	aux1=$(echo $busqueda | cut -d: -f6) 
	tput cup 9 3; echo "Home: $aux1"
	tput cup 11 3; read -p "Presiona ENTER para continuar..." aux
	DnLogg=1
fi
done
