#!/bin/bash
clear 
#FALTA WHILE
# 14:15  16:10

tput cup 3 3; read -p "Ingrese la ci del usuario a modificar" ci
busqueda=$(grep -n "^$ci:" /etc/passwd)  #Guardar la linea ¿es con -n?
if [ -z $busqueda  ]
		then
			tput cup 2 3; read -p  "No existe usurio con esa ci. Presione ENTER para continuar..." aux
		else
		usuario= $(cut -d: -f1 $aux)
else
	clear
	tput cup 3 3; echo "Dato a modificar de $usuario , ci: $ci"
	tput cup 4 3; echo "1) Home"
	tput cup 5 3; echo "2) Cedula"
	tput cup 6 3; echo "3) Administrativo o no"
	tput cup 7 3; echo "4) Nombre de usuario"
	tput cup 8 3; echo "5) Menu principal"
	tput cup 9 3; read op
	modificado=false
	
		case $op in
		1)
			while [ !$modificado ]
			do
				clear
				tput cup 3 3; read -p "Ingrese el nombre del nuevo home (camino absoluto): " nomhome
	
				#si no esta creado el home no se puede asignarlo a un usuario
				if [ -d $nombrehome ] 
				then
					creado=true
					sudo usermod -d $nombrehome $usuario 
					tput cup 4 3; echo "El home de $usuario fue cambiado a $nombrehome"
					tput cup 5 3; read -p "Presione ENTER para continuar..." aux
				else
					menuhome=false
					while [!$menuhome]
					do	
						tput cup 2 3; read -p "Home no existente. ¿Desea crearlo? (S/N)" ophome
						case $ophome in

							"S") mkdir $homeuser
								sudo usermod -d $nombrehome $usuario 
								modificado=true
								menuhome=true
								tput cup 5 3; echo "Home creado y modirficado en el usuario $usuario , ci: $ci"
							;;

							"N") menuhome=true
							;;
	
							*) tput cup 6 3; tput setaf 1; read -p "Ingrese S/N" aux ; tput setaf 0
						
							;;
						esac
					done
				fi
			done
		;;
		2)
			echo $nuevaci > aux.txt
			echo "false" > aux2.txt  
			while [ ! $modificado ]  
			do
				clear
				tput cup 3 3; read -p "Ingrese la nueva ci: " nuevaci; echo $nuevaci > aux.txt
				. verificar.sh  #verifica la ci (el numero verificador y si no hay una registrada
				modificado=(cat aux2.txt)
			done
			usermod -c $nuevaci $usuario
			tput cup 4 3; read -p "La ci de el usuario $usuario fue cambiada de $ci a $nuevaci" aux
		;;
		3)
			while [ ! $modificado ] 
			do
				clear
				tput cup 3 3; read -p "El usuario $usuario con ci $ci es admiistrativo (S/N)" ngrup
				case $ngrup in
	
				"S") ngrup=10
					modificado=true
				;;
				"N") ngrup=20
					modificado=true
				;;
				*) tput cup 2 3; tput setaf 1; read -p "Ingrese S/N" aux; tput setaf 0
				;;
				esac
			done
			usermod -g $ngrup $usuario
		;;
		4) 
			while [ ! $modificado ]
			do
				clear
				tput cup 3 3; read -p "Ingrese el nuevo nombre de usuario" nuevouser
				busqueda=$(grep "$usuario:" /etc/passwd)
			
				if [ -z $busueda  ]  #si no existe el usuario se peude cambiar
				then
					usermod -l $nuevouser $usuario
					modificado=true
				else 
					tput cup 2 3; tput setaf 1 ; echo " $nuevouser ya existe"
					tput cup 2 24; tput setaf 0 ; echo " Ingrese otro nombre de usuario"
				fi
			done
		;;
		5) 
		;;
		*) tput cup 2 3; tput setaf 1; read -p "Ingrese un dato valido" aux; tput setaf 0
		;;	
		esac

fi
