echo %path%>path_backup.txt

set baseDir=%cd%

::echo %baseDir%
echo The current file path to our compiler and cmake is:
echo %baseDir%

set compilerDir=%baseDir%\MinGW\mingw122_64\bin
set cmakeDir=%baseDir%\Cmake\cmake-3.22.1-windows-x86_64\bin

echo "compilerDir = " %compilerDir%
echo "cmakeDir = " %cmakeDir%

set path=%compilerDir%;%PATH%
set path=%cmakeDir%;%PATH%

cd %currentDir%
