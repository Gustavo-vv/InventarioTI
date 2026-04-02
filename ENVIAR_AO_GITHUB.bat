@echo off
setlocal enabledelayedexpansion

echo.
echo ==========================================================
echo    GERENCIADOR DE ENVIO - INVENTARIO TI (GITHUB)
echo ==========================================================
echo.

set /p msg="Digite a sua mensagem do commit (ex: Limpeza do codigo): "

if "!msg!"=="" (
    set msg="Atualizacao do projeto - %date% %time%"
)

echo.
echo [1/4] Removendo arquivos temporarios do rastreio do git...
git rm -r --cached "obj/" >nul 2>&1
git rm -r --cached "bin/" >nul 2>&1
git rm -r --cached ".vs/" >nul 2>&1

echo [2/4] Adicionando arquivos e preparando commit...
git add .
git commit -m "!msg!"

echo.
echo [3/4] Garantindo conexao com o GitHub...
git remote remove origin 2>nul
git remote add origin https://github.com/Gustavo-vv/InventarioTIe.git
git branch -M main

echo.
echo [4/4] Enviando para a nuvem...
git push -u origin main

echo.
echo ==========================================================
echo SE NAO APARECEU NENHUM ERRO ACIMA: 
echo O PROJETO FOI SALVO COM SUCESSO NO GITHUB!
echo ==========================================================
echo.
pause
