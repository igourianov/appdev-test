@echo off
set dbname=Northwind
set dbserver=localhost
if exist %cd%\%dbname%.mdf (
	sqlcmd -S "%dbserver%" -E -Q "exec sp_detach_db '%dbname%'" >nul
	del "%cd%\%dbname%.mdf" "%cd%\%dbname%.ldf"
)
sqlcmd -S "%dbserver%" -E -Q "create database [%dbname%] on primary (name='%dbname%_data', filename='%cd%\%dbname%.mdf') log on (name='%dbname%_log', filename='%cd%\%dbname%.ldf')"
sqlcmd -S "%dbserver%" -E -d "%dbname%" -i "%cd%\%dbname%.sql"
pause
