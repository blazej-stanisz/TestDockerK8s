# debug.bat
docker run -v /shared:/foo --rm -p8086:8080 --name="testdockerk8s" -v "pwd":/home/app testdockerk8s