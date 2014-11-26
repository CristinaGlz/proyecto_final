sudo apt-get install mono-complete
sudo apt-get install nunit-console
xbuild proyectofinal.sln
nunit-console proyectofinal/bin/Debug/proyectofinal.dll
