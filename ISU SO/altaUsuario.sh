#!/bin/bash
tput setab 7
clear
#FALTA WHILE
tput cup 3 3; echo "Login :"
tput cup 6 3; echo "Cedula de identidad :"
tput cup 4 3; echo "Directorio de trabajo :"
tput cup 5 3; echo "Grupo al que pertencera :"

DnLogg=0
DnCI=0
echo "$DnCI" > aux2.txt
DnGroupp=0

while [DnLogg -eq 0]
do
	#READ
	tput cup 3 24; read Logg
	busqueda=$(grep "^$Logg:" /etc/passwd)
	
	if [ -z $busueda  ]  #si no existe el usuario se peude crear
	then
		DnLogg=1
		while [ DnCI -eq 0 ]
		do
			#READ
			tput cup 6 25; read CI
			echo $CI > aux.txt
			. verificar.sh  # Chequea que el numero verificador sea el correcto, al igual que a cantidad de digitos
			DnCI=$(cat aux2.txt)
		done
		#READ
		tput cup 4 27; read Homee
		while [ DnGroupp -ne 0 ]
		#READ
		tput cup 5 25; read Groupp
		
		busqueda=$(grep "$^Groupp:" etc/group)	
		if [ -z $busqueda ]
		then
			tput cup 2 3; tput setaf 1; read -p "Ingrese un grupo valido" aux; tput setaf 0
		else
			busqueda=$(cut -d: -f3 | grep "$Groupp" etc/group)
			if [ -z $busqueda ]
			then
				tput cup 2 3; tput setaf 1; read -p "Ingrese un grupo valido" aux; tput setaf 0
			else
				if  useradd -d $homeuser -mk /etc/skell -g $ngrup -c $come -s shell $nombreuser 
				then
					tput cup 2 3;  tput setaf 2 ; read -p "Usuario creado" ;  tput setaf 0
				fi
			fi
		fi
	else
		tput cup 2 3; tput setaf 1; read -p "El usuario ya existe" aux; tput setaf 0 
	fi
done
