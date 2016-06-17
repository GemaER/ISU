#!/bin/bash
tput setab 7
clear
#FALTA WHILE
tput cup 3 3; echo "Nombre del grupo :"
tput cup 4 3; echo "GID :"

tput cup 3 22; read nombre
tput cup 4 9; read grupid

if groupadd -g $grupid $nombre 
then
	tput cup 3 3; echo "Grupo $nombre, creado"
else
	tput cup 2 3; tput setaf 1; read -p "Error"; tput setaf 0
fi
